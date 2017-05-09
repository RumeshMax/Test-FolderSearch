namespace Test_FolderSearch
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tvFolderNavigation = new System.Windows.Forms.TreeView();
            this.txtSelectedPath = new System.Windows.Forms.TextBox();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFolder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.fbdSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainerRightInner = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightInner)).BeginInit();
            this.splitContainerRightInner.Panel1.SuspendLayout();
            this.splitContainerRightInner.Panel2.SuspendLayout();
            this.splitContainerRightInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tvFolderNavigation);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRightInner);
            this.splitContainerMain.Size = new System.Drawing.Size(802, 451);
            this.splitContainerMain.SplitterDistance = 267;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tvFolderNavigation
            // 
            this.tvFolderNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFolderNavigation.Location = new System.Drawing.Point(12, 12);
            this.tvFolderNavigation.Name = "tvFolderNavigation";
            this.tvFolderNavigation.Size = new System.Drawing.Size(252, 427);
            this.tvFolderNavigation.TabIndex = 0;
            // 
            // txtSelectedPath
            // 
            this.txtSelectedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedPath.Location = new System.Drawing.Point(3, 9);
            this.txtSelectedPath.Multiline = true;
            this.txtSelectedPath.Name = "txtSelectedPath";
            this.txtSelectedPath.Size = new System.Drawing.Size(386, 55);
            this.txtSelectedPath.TabIndex = 5;
            this.txtSelectedPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSelectedPath_KeyPress);
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FilePath,
            this.FileType,
            this.OpenFolder,
            this.OpenFile});
            this.dgvFileList.Location = new System.Drawing.Point(3, 3);
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.ReadOnly = true;
            this.dgvFileList.Size = new System.Drawing.Size(513, 235);
            this.dgvFileList.TabIndex = 7;
            this.dgvFileList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileList_CellClick);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            // 
            // FileType
            // 
            this.FileType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FileType.HeaderText = "File Type";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            this.FileType.Width = 75;
            // 
            // OpenFolder
            // 
            this.OpenFolder.HeaderText = "";
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.ReadOnly = true;
            this.OpenFolder.Text = "";
            // 
            // OpenFile
            // 
            this.OpenFile.HeaderText = "";
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.ReadOnly = true;
            this.OpenFile.Text = "";
            // 
            // lstFileList
            // 
            this.lstFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.Location = new System.Drawing.Point(3, 70);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(513, 121);
            this.lstFileList.TabIndex = 6;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(395, 9);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(121, 55);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // splitContainerRightInner
            // 
            this.splitContainerRightInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerRightInner.Location = new System.Drawing.Point(3, 3);
            this.splitContainerRightInner.Name = "splitContainerRightInner";
            this.splitContainerRightInner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightInner.Panel1
            // 
            this.splitContainerRightInner.Panel1.Controls.Add(this.txtSelectedPath);
            this.splitContainerRightInner.Panel1.Controls.Add(this.lstFileList);
            this.splitContainerRightInner.Panel1.Controls.Add(this.btnSelectFolder);
            // 
            // splitContainerRightInner.Panel2
            // 
            this.splitContainerRightInner.Panel2.Controls.Add(this.dgvFileList);
            this.splitContainerRightInner.Size = new System.Drawing.Size(525, 445);
            this.splitContainerRightInner.SplitterDistance = 194;
            this.splitContainerRightInner.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.splitContainerRightInner.Panel1.ResumeLayout(false);
            this.splitContainerRightInner.Panel1.PerformLayout();
            this.splitContainerRightInner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightInner)).EndInit();
            this.splitContainerRightInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox txtSelectedPath;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewButtonColumn OpenFolder;
        private System.Windows.Forms.DataGridViewButtonColumn OpenFile;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectFolder;
        private System.Windows.Forms.TreeView tvFolderNavigation;
        private System.Windows.Forms.SplitContainer splitContainerRightInner;

    }
}

