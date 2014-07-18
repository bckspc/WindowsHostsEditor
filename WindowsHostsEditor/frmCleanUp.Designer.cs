namespace WindowsHostsEditor
{
    partial class frmCleanUp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChanged = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSaveChanges = new System.Windows.Forms.Button();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonRemoveAllNewLines = new System.Windows.Forms.RadioButton();
            this.radioRemoveExtraNewlines = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertNewlineAfterComment = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOriginal);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtChanged);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(981, 474);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtOriginal
            // 
            this.txtOriginal.AcceptsReturn = true;
            this.txtOriginal.AcceptsTab = true;
            this.txtOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginal.Location = new System.Drawing.Point(0, 28);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(493, 446);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Output File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChanged
            // 
            this.txtChanged.AcceptsReturn = true;
            this.txtChanged.AcceptsTab = true;
            this.txtChanged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChanged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChanged.Location = new System.Drawing.Point(0, 28);
            this.txtChanged.Multiline = true;
            this.txtChanged.Name = "txtChanged";
            this.txtChanged.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChanged.Size = new System.Drawing.Size(484, 446);
            this.txtChanged.TabIndex = 1;
            this.txtChanged.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proposed changes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.butCancel);
            this.flowLayoutPanel1.Controls.Add(this.butSaveChanges);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 499);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(981, 41);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(848, 3);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(130, 35);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "&Cancel Changes";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSaveChanges
            // 
            this.butSaveChanges.Location = new System.Drawing.Point(712, 3);
            this.butSaveChanges.Name = "butSaveChanges";
            this.butSaveChanges.Size = new System.Drawing.Size(130, 35);
            this.butSaveChanges.TabIndex = 0;
            this.butSaveChanges.Text = "&Accept Changes";
            this.butSaveChanges.UseVisualStyleBackColor = true;
            this.butSaveChanges.Click += new System.EventHandler(this.butSaveChanges_Click);
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 4;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.topTableLayoutPanel.Controls.Add(this.radioButtonRemoveAllNewLines, 1, 0);
            this.topTableLayoutPanel.Controls.Add(this.radioRemoveExtraNewlines, 2, 0);
            this.topTableLayoutPanel.Controls.Add(this.radioButtonInsertNewlineAfterComment, 3, 0);
            this.topTableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(981, 25);
            this.topTableLayoutPanel.TabIndex = 2;
            // 
            // radioButtonRemoveAllNewLines
            // 
            this.radioButtonRemoveAllNewLines.AutoSize = true;
            this.radioButtonRemoveAllNewLines.Location = new System.Drawing.Point(518, 3);
            this.radioButtonRemoveAllNewLines.Name = "radioButtonRemoveAllNewLines";
            this.radioButtonRemoveAllNewLines.Size = new System.Drawing.Size(122, 17);
            this.radioButtonRemoveAllNewLines.TabIndex = 0;
            this.radioButtonRemoveAllNewLines.Tag = "RemoveAllNewline";
            this.radioButtonRemoveAllNewLines.Text = "&Remove all newlines";
            this.radioButtonRemoveAllNewLines.UseVisualStyleBackColor = true;
            this.radioButtonRemoveAllNewLines.CheckedChanged += new System.EventHandler(this.ChangeCleanupMode);
            // 
            // radioRemoveExtraNewlines
            // 
            this.radioRemoveExtraNewlines.AutoSize = true;
            this.radioRemoveExtraNewlines.Checked = true;
            this.radioRemoveExtraNewlines.Location = new System.Drawing.Point(646, 3);
            this.radioRemoveExtraNewlines.Name = "radioRemoveExtraNewlines";
            this.radioRemoveExtraNewlines.Size = new System.Drawing.Size(135, 17);
            this.radioRemoveExtraNewlines.TabIndex = 1;
            this.radioRemoveExtraNewlines.TabStop = true;
            this.radioRemoveExtraNewlines.Tag = "RemoveExtraLines";
            this.radioRemoveExtraNewlines.Text = "&Remove extra newlines";
            this.radioRemoveExtraNewlines.UseVisualStyleBackColor = true;
            this.radioRemoveExtraNewlines.CheckedChanged += new System.EventHandler(this.ChangeCleanupMode);
            // 
            // radioButtonInsertNewlineAfterComment
            // 
            this.radioButtonInsertNewlineAfterComment.AutoSize = true;
            this.radioButtonInsertNewlineAfterComment.Location = new System.Drawing.Point(787, 3);
            this.radioButtonInsertNewlineAfterComment.Name = "radioButtonInsertNewlineAfterComment";
            this.radioButtonInsertNewlineAfterComment.Size = new System.Drawing.Size(191, 17);
            this.radioButtonInsertNewlineAfterComment.TabIndex = 2;
            this.radioButtonInsertNewlineAfterComment.Tag = "InsertAfterComment";
            this.radioButtonInsertNewlineAfterComment.Text = "Insert newline only before comment";
            this.radioButtonInsertNewlineAfterComment.UseVisualStyleBackColor = true;
            this.radioButtonInsertNewlineAfterComment.CheckedChanged += new System.EventHandler(this.ChangeCleanupMode);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cleanup mode:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCleanUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 540);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.topTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCleanUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hosts file cleanup";
            this.Load += new System.EventHandler(this.frmCleanUp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSaveChanges;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtChanged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.RadioButton radioButtonRemoveAllNewLines;
        private System.Windows.Forms.RadioButton radioRemoveExtraNewlines;
        private System.Windows.Forms.RadioButton radioButtonInsertNewlineAfterComment;
        private System.Windows.Forms.Label label3;
    }
}