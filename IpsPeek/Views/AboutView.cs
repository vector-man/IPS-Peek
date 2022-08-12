using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace IpsPeek
{
    public partial class AboutView : Form
    {
        const string website = "http://www.codeisle.com";
        public AboutView()
        {
            InitializeComponent();
            this.Text = string.Format("About {0}", Application.ProductName);
            this.labelTitle.Text = Application.ProductName;
            this.labelVersion.Text = string.Format("Version: {0}", Application.ProductVersion.ToString());
            this.labelDescription.Text = Strings.Description;
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            this.labelCopyright.Text = versionInfo.LegalCopyright;
            this.linkLabelWebsite.Text = website;
            this.AcceptButton = this.buttonOk;
            this.buttonOk.Select();
        }

        private void linkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(website);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
