﻿using Be.Windows.Forms;
using IpsLibNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace IpsPeek
{
    public partial class FormMain : Form
    {
        private long _fileSize = 0;
        public FormMain()
        {
            InitializeComponent();

            this.olvColumnIpsFileRange.AspectGetter = delegate(object row) { return string.Format("{0:X8} - {1:X8}", ((IpsPatch)row).IpsPatchRange.RangeStart, ((IpsPatch)row).IpsPatchRange.RangeStop); };
            this.olvColumnIpsFileSize.AspectGetter = delegate(object row) { return string.Format("{0:X}", ((IpsPatch)row).IpsFileSize); };
            this.olvColumnIpsFileSize.FillsFreeSpace = true;
            this.olvColumnOffset.AspectGetter = delegate(object row) { return string.Format("{0:X6}", ((IpsPatch)row).Offset); };
            this.olvColumnSize.AspectGetter = delegate(object row) { return string.Format("{0:X}", ((IpsPatch)row).Size); };
            this.olvColumnType.AspectGetter = delegate(object row) { return string.Format("{0:X}", ((IpsPatch)row).PatchType.GetDescription()); };

            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripButton.Enabled = false;
            hexBox1.LineInfoVisible = true;
            hexBox1.ColumnInfoVisible = true;
            hexBox1.VScrollBarVisible = true;
            hexBox1.StringViewVisible = true;

            toolStripStatusLabel1.Text = string.Format("Row: {0} / {1} ({2} bytes)", 0, 0, 0);

            toolbarToolStripMenuItem.Checked = true;
            dataViewToolStripMenuItem.Checked = true;
        }

        private void openPatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }


        private void objectListView1_SelectionChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObjects.Count == 1)
            {
                try
                {
                    hexBox1.LineInfoOffset = (long)((IpsPatch)objectListView1.SelectedObject).Offset;
                    hexBox1.ByteProvider = new DynamicByteProvider(((IpsPatch)objectListView1.SelectedObject).data);
                    toolStripStatusLabel1.Text = string.Format("Row: {0} / {1} ({2} bytes)", objectListView1.SelectedIndex + 1, objectListView1.Items.Count, ((IpsPatch)objectListView1.SelectedObject).data.Count());
                }
                catch
                {
                    hexBox1.ByteProvider = null;
                    try
                    {
                        toolStripStatusLabel1.Text = string.Format("Row: {0} / {1} ({2} bytes)", objectListView1.SelectedIndex + 1, objectListView1.Items.Count, ((IpsPatch)objectListView1.SelectedObject).data.Count());
                    }
                    catch
                    {

                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }


        private void openPatchToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }



        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void exportToolStripButton_Click(object sender, EventArgs e)
        {
            ExportFile();
        }

        private void CloseFile()
        {
            objectListView1.ClearObjects();
            hexBox1.ByteProvider = null;
            this.Text = Application.ProductName;
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripButton.Enabled = false;
            toolStripStatusLabel1.Text = string.Format("Row: {0} / {1} ({2} bytes)", 0, 0, 0);
        }

        private void OpenFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "IPS Files (*.ips)|*.ips";

                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    var scanner = new IpsScanner();
                    List<IpsPatch> patches = scanner.Scan(dialog.FileName);
                    objectListView1.SetObjects(patches); ;
                    objectListView1.AutoResizeColumns();
                    this.Text = string.Format("{0} - {1}", Application.ProductName, Path.GetFileName(dialog.FileName));
                    this.closeToolStripMenuItem.Enabled = true;
                    this.closeToolStripButton.Enabled = true;
                    _fileSize = new FileInfo(dialog.FileName).Length;
                    toolStripStatusLabel2.Text = string.Format("File size: {0} bytes", _fileSize);
                    objectListView1.SelectedIndex = 0;
                }
            }
        }

        private void ExportFile()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text Files (*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.ASCII))
                    {
                        writer.WriteLine("{0} Version {1}", Application.ProductName, Application.ProductVersion.ToString());
                        writer.WriteLine("IPS Patch Information Export");
                        writer.WriteLine();
                        writer.WriteLine("{0,-10}{1,-8}{2,-7}{3,-21}{4,-25}", "Offset", "Size", "Type", "IPS File Range", "IPS File Size        ");
                        try
                        {

                            foreach (IpsPatch patch in objectListView1.Objects)
                            {
                                writer.WriteLine("{0,-10}{1,-8}{2,-7}{3}-{4}{5, 9}", patch.Offset.HasValue ? patch.Offset.Value.ToString("X6") : "------", patch.Size.HasValue ? patch.Size.Value.ToString("X") : "----", patch.PatchType.GetDescription(), patch.IpsPatchRange.RangeStart.ToString("X8"), patch.IpsPatchRange.RangeStop.ToString("X8"), patch.IpsFileSize.HasValue ? patch.IpsFileSize.Value.ToString("X"): "--");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void toolbarToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolbarToolStripMenuItem.Checked;
        }

        private void dataViewToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !dataViewToolStripMenuItem.Checked;
        }
    }
}
