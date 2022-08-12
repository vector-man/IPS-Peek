namespace IpsPeek
{
    partial class AboutView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelWebsite = new System.Windows.Forms.LinkLabel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(85, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitle.Location = new System.Drawing.Point(97, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(245, 18);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "IPS Peek";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.linkLabelWebsite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOk, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 210);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // linkLabelWebsite
            // 
            this.linkLabelWebsite.AutoSize = true;
            this.linkLabelWebsite.Location = new System.Drawing.Point(97, 73);
            this.linkLabelWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.linkLabelWebsite.Name = "linkLabelWebsite";
            this.linkLabelWebsite.Size = new System.Drawing.Size(174, 20);
            this.linkLabelWebsite.TabIndex = 3;
            this.linkLabelWebsite.TabStop = true;
            this.linkLabelWebsite.Text = "http://www.codeisle.com";
            this.linkLabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebsite_LinkClicked);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOk.Location = new System.Drawing.Point(242, 170);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 35);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(97, 23);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(245, 20);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version: 0.0.0.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(97, 48);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(245, 20);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "Copyright (c) 2014";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(97, 113);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(245, 52);
            this.labelDescription.TabIndex = 4;
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(377, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutView";
            this.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.LinkLabel linkLabelWebsite;
        private System.Windows.Forms.Label labelCopyright;
    }
}