using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace IpsPeek
{
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();

            this.Shown += UpdateStates;
            radioButtonHex.CheckedChanged += UpdateStates;
            radioButtonText.CheckedChanged += UpdateStates;

            comboBoxText.TextChanged += UpdateStates;

            hexBoxHex.PreviewKeyDown += UpdateStates;

            hexBoxHex.ByteProvider = new DynamicByteProvider(new byte[] { });

            ((DynamicByteProvider)hexBoxHex.ByteProvider).LengthChanged += UpdateStates;
        }

        void UpdateStates(object sender, EventArgs e)
        {
            hexBoxHex.Enabled = radioButtonHex.Checked;
            comboBoxText.Enabled = radioButtonText.Checked;

            buttonFind.Enabled = ((comboBoxText.Text.Length > 0) && radioButtonText.Checked) || (hexBoxHex.ByteProvider != null) && ((((DynamicByteProvider)hexBoxHex.ByteProvider).Length > 0) && radioButtonHex.Checked);
        }
        public DialogResult ShowDialog(IWin32Window owner, out byte[] bytes)
        {
            bytes = new byte[] { };
            hexBoxHex.ReadOnly = false;
            DialogResult result = base.ShowDialog(owner);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (radioButtonHex.Checked)
                {
                    bytes = ((DynamicByteProvider)hexBoxHex.ByteProvider).Bytes.ToArray();
                }
                else
                {
                    bytes = ASCIIEncoding.ASCII.GetBytes(comboBoxText.Text);
                }
            }
            return result;
        }
    }
}
