namespace IpsPeek
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.iPSPeekHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutIPSPeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fastObjectListViewRows = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnOffset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEnd = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIpsOffset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIpsEnd = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIpsSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openPatchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.hexBoxData = new Be.Windows.Forms.HexBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRows = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelPatchCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewRows)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPatchToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openPatchToolStripMenuItem
            // 
            this.openPatchToolStripMenuItem.Name = "openPatchToolStripMenuItem";
            this.openPatchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openPatchToolStripMenuItem.Text = "&Open...";
            this.openPatchToolStripMenuItem.Click += new System.EventHandler(this.openPatchToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(113, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportToolStripMenuItem.Text = "&Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem,
            this.dataViewToolStripMenuItem,
            this.stringViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.CheckOnClick = true;
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            this.toolbarToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.toolbarToolStripMenuItem_CheckStateChanged);
            // 
            // dataViewToolStripMenuItem
            // 
            this.dataViewToolStripMenuItem.CheckOnClick = true;
            this.dataViewToolStripMenuItem.Name = "dataViewToolStripMenuItem";
            this.dataViewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dataViewToolStripMenuItem.Text = "Data View";
            this.dataViewToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.dataViewToolStripMenuItem_CheckStateChanged);
            // 
            // stringViewToolStripMenuItem
            // 
            this.stringViewToolStripMenuItem.CheckOnClick = true;
            this.stringViewToolStripMenuItem.Name = "stringViewToolStripMenuItem";
            this.stringViewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stringViewToolStripMenuItem.Text = "String View";
            this.stringViewToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.stringViewToolStripMenuItem_CheckStateChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.iPSPeekHomeToolStripMenuItem,
            this.officialForumToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutIPSPeekToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            this.helpContentsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.helpContentsToolStripMenuItem.Text = "&Help Contents";
            this.helpContentsToolStripMenuItem.Click += new System.EventHandler(this.helpContentsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 6);
            // 
            // iPSPeekHomeToolStripMenuItem
            // 
            this.iPSPeekHomeToolStripMenuItem.Name = "iPSPeekHomeToolStripMenuItem";
            this.iPSPeekHomeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.iPSPeekHomeToolStripMenuItem.Text = "IPS Peek Home";
            this.iPSPeekHomeToolStripMenuItem.Click += new System.EventHandler(this.iPSPeekHomeToolStripMenuItem_Click);
            // 
            // officialForumToolStripMenuItem
            // 
            this.officialForumToolStripMenuItem.Name = "officialForumToolStripMenuItem";
            this.officialForumToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.officialForumToolStripMenuItem.Text = "&Official Forum";
            this.officialForumToolStripMenuItem.Click += new System.EventHandler(this.officialForumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 6);
            // 
            // aboutIPSPeekToolStripMenuItem
            // 
            this.aboutIPSPeekToolStripMenuItem.Name = "aboutIPSPeekToolStripMenuItem";
            this.aboutIPSPeekToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutIPSPeekToolStripMenuItem.Text = "About IPS Peek";
            this.aboutIPSPeekToolStripMenuItem.Click += new System.EventHandler(this.aboutIPSPeekToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fastObjectListViewRows);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hexBoxData);
            this.splitContainer1.Size = new System.Drawing.Size(635, 302);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // fastObjectListViewRows
            // 
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnOffset);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnEnd);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnSize);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnType);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnIpsOffset);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnIpsEnd);
            this.fastObjectListViewRows.AllColumns.Add(this.olvColumnIpsSize);
            this.fastObjectListViewRows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnOffset,
            this.olvColumnEnd,
            this.olvColumnSize,
            this.olvColumnType,
            this.olvColumnIpsOffset,
            this.olvColumnIpsEnd,
            this.olvColumnIpsSize});
            this.fastObjectListViewRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListViewRows.FullRowSelect = true;
            this.fastObjectListViewRows.HideSelection = false;
            this.fastObjectListViewRows.Location = new System.Drawing.Point(0, 25);
            this.fastObjectListViewRows.MultiSelect = false;
            this.fastObjectListViewRows.Name = "fastObjectListViewRows";
            this.fastObjectListViewRows.OwnerDraw = true;
            this.fastObjectListViewRows.ShowGroups = false;
            this.fastObjectListViewRows.ShowSortIndicators = false;
            this.fastObjectListViewRows.Size = new System.Drawing.Size(635, 175);
            this.fastObjectListViewRows.TabIndex = 0;
            this.fastObjectListViewRows.UseCompatibleStateImageBehavior = false;
            this.fastObjectListViewRows.View = System.Windows.Forms.View.Details;
            this.fastObjectListViewRows.VirtualMode = true;
            this.fastObjectListViewRows.SelectionChanged += new System.EventHandler(this.objectListView1_SelectionChanged);
            // 
            // olvColumnOffset
            // 
            this.olvColumnOffset.AspectName = "";
            this.olvColumnOffset.AspectToStringFormat = "";
            this.olvColumnOffset.CellPadding = null;
            this.olvColumnOffset.Sortable = false;
            this.olvColumnOffset.Text = "Offset";
            // 
            // olvColumnEnd
            // 
            this.olvColumnEnd.CellPadding = null;
            this.olvColumnEnd.Text = "End";
            // 
            // olvColumnSize
            // 
            this.olvColumnSize.AspectName = "";
            this.olvColumnSize.AspectToStringFormat = "";
            this.olvColumnSize.CellPadding = null;
            this.olvColumnSize.Sortable = false;
            this.olvColumnSize.Text = "Size";
            // 
            // olvColumnType
            // 
            this.olvColumnType.CellPadding = null;
            this.olvColumnType.Sortable = false;
            this.olvColumnType.Text = "Type";
            // 
            // olvColumnIpsOffset
            // 
            this.olvColumnIpsOffset.AspectName = "";
            this.olvColumnIpsOffset.CellPadding = null;
            this.olvColumnIpsOffset.Sortable = false;
            this.olvColumnIpsOffset.Text = "IPS Offset";
            // 
            // olvColumnIpsEnd
            // 
            this.olvColumnIpsEnd.CellPadding = null;
            this.olvColumnIpsEnd.Sortable = false;
            this.olvColumnIpsEnd.Text = "IPS End";
            // 
            // olvColumnIpsSize
            // 
            this.olvColumnIpsSize.AspectName = "";
            this.olvColumnIpsSize.CellPadding = null;
            this.olvColumnIpsSize.Sortable = false;
            this.olvColumnIpsSize.Text = "IPS Size";
            this.olvColumnIpsSize.Width = 90;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPatchToolStripButton,
            this.closeToolStripButton,
            this.toolStripSeparator1,
            this.exportToolStripButton,
            this.toolStripSeparator2,
            this.filterToolStripTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openPatchToolStripButton
            // 
            this.openPatchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openPatchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openPatchToolStripButton.Image")));
            this.openPatchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openPatchToolStripButton.Name = "openPatchToolStripButton";
            this.openPatchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openPatchToolStripButton.Text = "Open...";
            this.openPatchToolStripButton.Click += new System.EventHandler(this.openPatchToolStripButton_Click);
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeToolStripButton.Text = "Close";
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // exportToolStripButton
            // 
            this.exportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripButton.Image")));
            this.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripButton.Name = "exportToolStripButton";
            this.exportToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.exportToolStripButton.Text = "Export";
            this.exportToolStripButton.Click += new System.EventHandler(this.exportToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // filterToolStripTextBox
            // 
            this.filterToolStripTextBox.Name = "filterToolStripTextBox";
            this.filterToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.filterToolStripTextBox.Enter += new System.EventHandler(this.filterToolStripTextBox_Enter);
            this.filterToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterToolStripTextBox_KeyDown);
            this.filterToolStripTextBox.TextChanged += new System.EventHandler(this.filterToolStripTextBox_TextChanged);
            // 
            // hexBoxData
            // 
            this.hexBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBoxData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexBoxData.Location = new System.Drawing.Point(0, 0);
            this.hexBoxData.Name = "hexBoxData";
            this.hexBoxData.ReadOnly = true;
            this.hexBoxData.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBoxData.Size = new System.Drawing.Size(635, 98);
            this.hexBoxData.TabIndex = 0;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRows,
            this.ToolStripStatusLabelPatchCount,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelFileSize});
            this.statusStripMain.Location = new System.Drawing.Point(0, 326);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(635, 24);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRows
            // 
            this.toolStripStatusLabelRows.Name = "toolStripStatusLabelRows";
            this.toolStripStatusLabelRows.Size = new System.Drawing.Size(59, 19);
            this.toolStripStatusLabelRows.Text = "Row: 0 / 0";
            // 
            // ToolStripStatusLabelPatchCount
            // 
            this.ToolStripStatusLabelPatchCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabelPatchCount.Name = "ToolStripStatusLabelPatchCount";
            this.ToolStripStatusLabelPatchCount.Size = new System.Drawing.Size(64, 19);
            this.ToolStripStatusLabelPatchCount.Text = "Patches: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(403, 19);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabelFileSize
            // 
            this.toolStripStatusLabelFileSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelFileSize.Name = "toolStripStatusLabelFileSize";
            this.toolStripStatusLabelFileSize.Size = new System.Drawing.Size(94, 19);
            this.toolStripStatusLabelFileSize.Text = "File size: 0 bytes";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 350);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "IPS Peek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListViewRows)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Be.Windows.Forms.HexBox hexBoxData;
        private BrightIdeasSoftware.OLVColumn olvColumnOffset;
        private BrightIdeasSoftware.OLVColumn olvColumnSize;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnIpsOffset;
        private BrightIdeasSoftware.OLVColumn olvColumnIpsSize;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iPSPeekHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutIPSPeekToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openPatchToolStripButton;
        private System.Windows.Forms.ToolStripButton exportToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox filterToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRows;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelPatchCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileSize;
        private System.Windows.Forms.ToolStripMenuItem stringViewToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvColumnIpsEnd;
        private BrightIdeasSoftware.FastObjectListView fastObjectListViewRows;
        private BrightIdeasSoftware.OLVColumn olvColumnEnd;
    }
}

