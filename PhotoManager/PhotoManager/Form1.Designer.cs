namespace PhotoManager
{
    partial class Form1
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
            this.pctbPhoto = new System.Windows.Forms.PictureBox();
            this.lvPhotosList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSource = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNextPhoto = new System.Windows.Forms.Button();
            this.pGroups = new System.Windows.Forms.Panel();
            this.lbGroupsSelector = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAutogroupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyGroupedPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90RightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90LeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbShowSideMenu = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.discardGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopAutogroupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPhoto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pGroups.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbPhoto
            // 
            this.pctbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbPhoto.Location = new System.Drawing.Point(3, 3);
            this.pctbPhoto.Name = "pctbPhoto";
            this.pctbPhoto.Size = new System.Drawing.Size(732, 603);
            this.pctbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbPhoto.TabIndex = 0;
            this.pctbPhoto.TabStop = false;
            this.pctbPhoto.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pctbPhoto_LoadCompleted);
            // 
            // lvPhotosList
            // 
            this.lvPhotosList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPhotosList.CheckBoxes = true;
            this.lvPhotosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvPhotosList.Location = new System.Drawing.Point(6, 6);
            this.lvPhotosList.Name = "lvPhotosList";
            this.lvPhotosList.Size = new System.Drawing.Size(293, 578);
            this.lvPhotosList.TabIndex = 1;
            this.lvPhotosList.UseCompatibleStateImageBehavior = false;
            this.lvPhotosList.View = System.Windows.Forms.View.Details;
            this.lvPhotosList.SelectedIndexChanged += new System.EventHandler(this.lvPhotos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 279;
            // 
            // tbSource
            // 
            this.tbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSource.Location = new System.Drawing.Point(6, 533);
            this.tbSource.Name = "tbSource";
            this.tbSource.ReadOnly = true;
            this.tbSource.Size = new System.Drawing.Size(296, 20);
            this.tbSource.TabIndex = 6;
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.Location = new System.Drawing.Point(221, 559);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(81, 23);
            this.btnSource.TabIndex = 9;
            this.btnSource.Text = "Browse";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 616);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvPhotosList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(305, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnSource);
            this.tabPage2.Controls.Add(this.tbSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(305, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvGroups);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groups";
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(3, 16);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(285, 237);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellEndEdit);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pGroups);
            this.splitContainer1.Panel1.Controls.Add(this.pctbPhoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 616);
            this.splitContainer1.SplitterDistance = 738;
            this.splitContainer1.TabIndex = 14;
            // 
            // btnNextPhoto
            // 
            this.btnNextPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPhoto.Enabled = false;
            this.btnNextPhoto.Location = new System.Drawing.Point(830, 641);
            this.btnNextPhoto.Name = "btnNextPhoto";
            this.btnNextPhoto.Size = new System.Drawing.Size(90, 21);
            this.btnNextPhoto.TabIndex = 17;
            this.btnNextPhoto.Text = "Next photo";
            this.btnNextPhoto.UseVisualStyleBackColor = true;
            this.btnNextPhoto.Click += new System.EventHandler(this.btnNextPhoto_Click);
            // 
            // pGroups
            // 
            this.pGroups.Controls.Add(this.lbGroupsSelector);
            this.pGroups.Location = new System.Drawing.Point(3, 3);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(145, 116);
            this.pGroups.TabIndex = 2;
            this.pGroups.Visible = false;
            // 
            // lbGroupsSelector
            // 
            this.lbGroupsSelector.FormattingEnabled = true;
            this.lbGroupsSelector.Location = new System.Drawing.Point(3, 3);
            this.lbGroupsSelector.Name = "lbGroupsSelector";
            this.lbGroupsSelector.Size = new System.Drawing.Size(138, 109);
            this.lbGroupsSelector.TabIndex = 1;
            this.lbGroupsSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbGroupsSelector_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectFolderToolStripMenuItem
            // 
            this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
            this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectFolderToolStripMenuItem.Text = "&Select folder";
            this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.selectFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAutogroupingToolStripMenuItem,
            this.stopAutogroupingToolStripMenuItem,
            this.discardGroupsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyGroupedPhotosToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "&Control";
            // 
            // startAutogroupingToolStripMenuItem
            // 
            this.startAutogroupingToolStripMenuItem.Name = "startAutogroupingToolStripMenuItem";
            this.startAutogroupingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.startAutogroupingToolStripMenuItem.Text = "&Start auto-grouping";
            this.startAutogroupingToolStripMenuItem.Click += new System.EventHandler(this.startAutogroupingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // copyGroupedPhotosToolStripMenuItem
            // 
            this.copyGroupedPhotosToolStripMenuItem.Name = "copyGroupedPhotosToolStripMenuItem";
            this.copyGroupedPhotosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.copyGroupedPhotosToolStripMenuItem.Text = "&Copy grouped photos";
            this.copyGroupedPhotosToolStripMenuItem.Click += new System.EventHandler(this.copyGroupedPhotosToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotate90RightToolStripMenuItem,
            this.rotate90LeftToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "&Image";
            // 
            // rotate90RightToolStripMenuItem
            // 
            this.rotate90RightToolStripMenuItem.Name = "rotate90RightToolStripMenuItem";
            this.rotate90RightToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.rotate90RightToolStripMenuItem.Text = "Rotate 90 &right";
            this.rotate90RightToolStripMenuItem.Click += new System.EventHandler(this.rotate90RightToolStripMenuItem_Click);
            // 
            // rotate90LeftToolStripMenuItem
            // 
            this.rotate90LeftToolStripMenuItem.Name = "rotate90LeftToolStripMenuItem";
            this.rotate90LeftToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.rotate90LeftToolStripMenuItem.Text = "Rotate 90 &left";
            this.rotate90LeftToolStripMenuItem.Click += new System.EventHandler(this.rotate90LeftToolStripMenuItem_Click);
            // 
            // chbShowSideMenu
            // 
            this.chbShowSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbShowSideMenu.AutoSize = true;
            this.chbShowSideMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbShowSideMenu.Checked = true;
            this.chbShowSideMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowSideMenu.Location = new System.Drawing.Point(926, 643);
            this.chbShowSideMenu.Name = "chbShowSideMenu";
            this.chbShowSideMenu.Size = new System.Drawing.Size(104, 17);
            this.chbShowSideMenu.TabIndex = 16;
            this.chbShowSideMenu.Text = "Show side menu";
            this.chbShowSideMenu.UseVisualStyleBackColor = true;
            this.chbShowSideMenu.CheckedChanged += new System.EventHandler(this.chbShowSideMenu_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1055, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // discardGroupsToolStripMenuItem
            // 
            this.discardGroupsToolStripMenuItem.Name = "discardGroupsToolStripMenuItem";
            this.discardGroupsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.discardGroupsToolStripMenuItem.Text = "&Discard groups";
            this.discardGroupsToolStripMenuItem.Click += new System.EventHandler(this.discardGroupsToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvStatistics);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(305, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgvStatistics.Location = new System.Drawing.Point(6, 6);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.Size = new System.Drawing.Size(291, 284);
            this.dgvStatistics.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Group name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Relative path";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Photos count";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // stopAutogroupingToolStripMenuItem
            // 
            this.stopAutogroupingToolStripMenuItem.Name = "stopAutogroupingToolStripMenuItem";
            this.stopAutogroupingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.stopAutogroupingToolStripMenuItem.Text = "S&top auto-grouping";
            this.stopAutogroupingToolStripMenuItem.Click += new System.EventHandler(this.stopAutogroupingToolStripMenuItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 662);
            this.Controls.Add(this.btnNextPhoto);
            this.Controls.Add(this.chbShowSideMenu);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(795, 470);
            this.Name = "Form1";
            this.Text = "Photo Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pctbPhoto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pGroups.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbPhoto;
        private System.Windows.Forms.ListView lvPhotosList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbShowSideMenu;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAutogroupingToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyGroupedPhotosToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox lbGroupsSelector;
        private System.Windows.Forms.Panel pGroups;
        private System.Windows.Forms.Button btnNextPhoto;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90RightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90LeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discardGroupsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem stopAutogroupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

