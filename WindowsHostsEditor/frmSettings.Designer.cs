namespace WindowsHostsEditor
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioDefaultHostInputFile = new System.Windows.Forms.RadioButton();
            this.radioCustomHostInputFile = new System.Windows.Forms.RadioButton();
            this.txtCustomHostInputFile = new System.Windows.Forms.TextBox();
            this.butBrowseCustomHostInputFile = new System.Windows.Forms.Button();
            this.toolTipRadioDefaultHostInputFile = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogHostFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioDefaultHostOutputFile = new System.Windows.Forms.RadioButton();
            this.radioCustomHostOutputFile = new System.Windows.Forms.RadioButton();
            this.txtCustomHostOutputFile = new System.Windows.Forms.TextBox();
            this.butBrowseCustomHostOutputFile = new System.Windows.Forms.Button();
            this.saveFileDialogHostFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkDoBackup = new System.Windows.Forms.CheckBox();
            this.butBrowseBackupLocation = new System.Windows.Forms.Button();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogBackupLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chkConfirmOnDelete = new System.Windows.Forms.CheckBox();
            this.chkWarnIfDuplicates = new System.Windows.Forms.CheckBox();
            this.chkConfirmExitWithoutSave = new System.Windows.Forms.CheckBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hosts Input File";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radioDefaultHostInputFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioCustomHostInputFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomHostInputFile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.butBrowseCustomHostInputFile, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioDefaultHostInputFile
            // 
            this.radioDefaultHostInputFile.AutoSize = true;
            this.radioDefaultHostInputFile.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.radioDefaultHostInputFile, 2);
            this.radioDefaultHostInputFile.Location = new System.Drawing.Point(3, 3);
            this.radioDefaultHostInputFile.Name = "radioDefaultHostInputFile";
            this.radioDefaultHostInputFile.Size = new System.Drawing.Size(75, 17);
            this.radioDefaultHostInputFile.TabIndex = 0;
            this.radioDefaultHostInputFile.TabStop = true;
            this.radioDefaultHostInputFile.Text = "D&efault file";
            this.radioDefaultHostInputFile.UseVisualStyleBackColor = true;
            // 
            // radioCustomHostInputFile
            // 
            this.radioCustomHostInputFile.AutoSize = true;
            this.radioCustomHostInputFile.Location = new System.Drawing.Point(3, 26);
            this.radioCustomHostInputFile.Name = "radioCustomHostInputFile";
            this.radioCustomHostInputFile.Size = new System.Drawing.Size(76, 17);
            this.radioCustomHostInputFile.TabIndex = 0;
            this.radioCustomHostInputFile.Text = "Custom &file";
            this.radioCustomHostInputFile.UseVisualStyleBackColor = true;
            this.radioCustomHostInputFile.CheckedChanged += new System.EventHandler(this.radioCustomHostInputFile_CheckedChanged);
            // 
            // txtCustomHostInputFile
            // 
            this.txtCustomHostInputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomHostInputFile.Enabled = false;
            this.txtCustomHostInputFile.Location = new System.Drawing.Point(85, 26);
            this.txtCustomHostInputFile.Name = "txtCustomHostInputFile";
            this.txtCustomHostInputFile.ReadOnly = true;
            this.txtCustomHostInputFile.Size = new System.Drawing.Size(220, 20);
            this.txtCustomHostInputFile.TabIndex = 1;
            // 
            // butBrowseCustomHostInputFile
            // 
            this.butBrowseCustomHostInputFile.Enabled = false;
            this.butBrowseCustomHostInputFile.Location = new System.Drawing.Point(311, 26);
            this.butBrowseCustomHostInputFile.Name = "butBrowseCustomHostInputFile";
            this.butBrowseCustomHostInputFile.Size = new System.Drawing.Size(75, 20);
            this.butBrowseCustomHostInputFile.TabIndex = 2;
            this.butBrowseCustomHostInputFile.Text = "&Browse...";
            this.butBrowseCustomHostInputFile.UseVisualStyleBackColor = true;
            this.butBrowseCustomHostInputFile.Click += new System.EventHandler(this.butBrowseCustomHostInputFile_Click);
            // 
            // openFileDialogHostFile
            // 
            this.openFileDialogHostFile.Filter = "All files (*.*)|*.*";
            this.openFileDialogHostFile.SupportMultiDottedExtensions = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hosts Output File";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.radioDefaultHostOutputFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioCustomHostOutputFile, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomHostOutputFile, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.butBrowseCustomHostOutputFile, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioDefaultHostOutputFile
            // 
            this.radioDefaultHostOutputFile.AutoSize = true;
            this.radioDefaultHostOutputFile.Checked = true;
            this.tableLayoutPanel2.SetColumnSpan(this.radioDefaultHostOutputFile, 2);
            this.radioDefaultHostOutputFile.Location = new System.Drawing.Point(3, 3);
            this.radioDefaultHostOutputFile.Name = "radioDefaultHostOutputFile";
            this.radioDefaultHostOutputFile.Size = new System.Drawing.Size(108, 17);
            this.radioDefaultHostOutputFile.TabIndex = 0;
            this.radioDefaultHostOutputFile.TabStop = true;
            this.radioDefaultHostOutputFile.Text = "Same as &input file";
            this.radioDefaultHostOutputFile.UseVisualStyleBackColor = true;
            // 
            // radioCustomHostOutputFile
            // 
            this.radioCustomHostOutputFile.AutoSize = true;
            this.radioCustomHostOutputFile.Location = new System.Drawing.Point(3, 26);
            this.radioCustomHostOutputFile.Name = "radioCustomHostOutputFile";
            this.radioCustomHostOutputFile.Size = new System.Drawing.Size(76, 17);
            this.radioCustomHostOutputFile.TabIndex = 1;
            this.radioCustomHostOutputFile.Text = "Custo&m file";
            this.radioCustomHostOutputFile.UseVisualStyleBackColor = true;
            this.radioCustomHostOutputFile.CheckedChanged += new System.EventHandler(this.radioCustomHostOutputFile_CheckedChanged);
            // 
            // txtCustomHostOutputFile
            // 
            this.txtCustomHostOutputFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomHostOutputFile.Enabled = false;
            this.txtCustomHostOutputFile.Location = new System.Drawing.Point(85, 26);
            this.txtCustomHostOutputFile.Name = "txtCustomHostOutputFile";
            this.txtCustomHostOutputFile.ReadOnly = true;
            this.txtCustomHostOutputFile.Size = new System.Drawing.Size(220, 20);
            this.txtCustomHostOutputFile.TabIndex = 2;
            // 
            // butBrowseCustomHostOutputFile
            // 
            this.butBrowseCustomHostOutputFile.Enabled = false;
            this.butBrowseCustomHostOutputFile.Location = new System.Drawing.Point(311, 26);
            this.butBrowseCustomHostOutputFile.Name = "butBrowseCustomHostOutputFile";
            this.butBrowseCustomHostOutputFile.Size = new System.Drawing.Size(75, 20);
            this.butBrowseCustomHostOutputFile.TabIndex = 3;
            this.butBrowseCustomHostOutputFile.Text = "B&rowse...";
            this.butBrowseCustomHostOutputFile.UseVisualStyleBackColor = true;
            this.butBrowseCustomHostOutputFile.Click += new System.EventHandler(this.butBrowseCustomHostOutputFile_Click);
            // 
            // saveFileDialogHostFile
            // 
            this.saveFileDialogHostFile.Filter = "All files (*.*)|*.*";
            this.saveFileDialogHostFile.OverwritePrompt = false;
            this.saveFileDialogHostFile.SupportMultiDottedExtensions = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.chkDoBackup, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.butBrowseBackupLocation, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBackupFolder, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 51);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // chkDoBackup
            // 
            this.chkDoBackup.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkDoBackup, 2);
            this.chkDoBackup.Location = new System.Drawing.Point(3, 3);
            this.chkDoBackup.Name = "chkDoBackup";
            this.chkDoBackup.Size = new System.Drawing.Size(138, 17);
            this.chkDoBackup.TabIndex = 0;
            this.chkDoBackup.Text = "Do back&up before save";
            this.chkDoBackup.UseVisualStyleBackColor = true;
            this.chkDoBackup.CheckedChanged += new System.EventHandler(this.chkDoBackup_CheckedChanged);
            // 
            // butBrowseBackupLocation
            // 
            this.butBrowseBackupLocation.Enabled = false;
            this.butBrowseBackupLocation.Location = new System.Drawing.Point(311, 26);
            this.butBrowseBackupLocation.Name = "butBrowseBackupLocation";
            this.butBrowseBackupLocation.Size = new System.Drawing.Size(75, 20);
            this.butBrowseBackupLocation.TabIndex = 4;
            this.butBrowseBackupLocation.Text = "Brow&se...";
            this.butBrowseBackupLocation.UseVisualStyleBackColor = true;
            this.butBrowseBackupLocation.Click += new System.EventHandler(this.butBrowseBackupLocation_Click);
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupFolder.Location = new System.Drawing.Point(93, 26);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(212, 20);
            this.txtBackupFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Backup location";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirmations";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.chkConfirmOnDelete, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.chkWarnIfDuplicates, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.chkConfirmExitWithoutSave, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 69);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // chkConfirmOnDelete
            // 
            this.chkConfirmOnDelete.AutoSize = true;
            this.chkConfirmOnDelete.Location = new System.Drawing.Point(3, 3);
            this.chkConfirmOnDelete.Name = "chkConfirmOnDelete";
            this.chkConfirmOnDelete.Size = new System.Drawing.Size(108, 17);
            this.chkConfirmOnDelete.TabIndex = 0;
            this.chkConfirmOnDelete.Text = "Confirm on &delete";
            this.chkConfirmOnDelete.UseVisualStyleBackColor = true;
            // 
            // chkWarnIfDuplicates
            // 
            this.chkWarnIfDuplicates.AutoSize = true;
            this.chkWarnIfDuplicates.Location = new System.Drawing.Point(3, 26);
            this.chkWarnIfDuplicates.Name = "chkWarnIfDuplicates";
            this.chkWarnIfDuplicates.Size = new System.Drawing.Size(164, 17);
            this.chkWarnIfDuplicates.TabIndex = 1;
            this.chkWarnIfDuplicates.Text = "&Warn if duplicate hosts found";
            this.chkWarnIfDuplicates.UseVisualStyleBackColor = true;
            // 
            // chkConfirmExitWithoutSave
            // 
            this.chkConfirmExitWithoutSave.AutoSize = true;
            this.chkConfirmExitWithoutSave.Location = new System.Drawing.Point(3, 49);
            this.chkConfirmExitWithoutSave.Name = "chkConfirmExitWithoutSave";
            this.chkConfirmExitWithoutSave.Size = new System.Drawing.Size(210, 17);
            this.chkConfirmExitWithoutSave.TabIndex = 2;
            this.chkConfirmExitWithoutSave.Text = "Confirm on e&xit without saving changes";
            this.chkConfirmExitWithoutSave.UseVisualStyleBackColor = true;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(233, 305);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 4;
            this.butOK.Text = "&OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(314, 305);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "&Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 335);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioDefaultHostInputFile;
        private System.Windows.Forms.RadioButton radioCustomHostInputFile;
        private System.Windows.Forms.ToolTip toolTipRadioDefaultHostInputFile;
        private System.Windows.Forms.TextBox txtCustomHostInputFile;
        private System.Windows.Forms.Button butBrowseCustomHostInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogHostFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioDefaultHostOutputFile;
        private System.Windows.Forms.RadioButton radioCustomHostOutputFile;
        private System.Windows.Forms.TextBox txtCustomHostOutputFile;
        private System.Windows.Forms.Button butBrowseCustomHostOutputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogHostFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox chkDoBackup;
        private System.Windows.Forms.Button butBrowseBackupLocation;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBackupLocation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox chkConfirmOnDelete;
        private System.Windows.Forms.CheckBox chkWarnIfDuplicates;
        private System.Windows.Forms.CheckBox chkConfirmExitWithoutSave;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
    }
}