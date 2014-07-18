namespace WindowsHostsEditor
{
    partial class frmHostEntry
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
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.lstAliases = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHostIP = new System.Windows.Forms.Label();
            this.lblAddAlias = new System.Windows.Forms.Label();
            this.lblAliases = new System.Windows.Forms.Label();
            this.txtAddAlias = new System.Windows.Forms.TextBox();
            this.butAddAlias = new System.Windows.Forms.Button();
            this.butRemoveAlias = new System.Windows.Forms.Button();
            this.butOK = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(70, 3);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(119, 20);
            this.txtHostIP.TabIndex = 0;
            // 
            // lstAliases
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lstAliases, 2);
            this.lstAliases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAliases.FormattingEnabled = true;
            this.lstAliases.Location = new System.Drawing.Point(70, 58);
            this.lstAliases.Name = "lstAliases";
            this.lstAliases.Size = new System.Drawing.Size(420, 185);
            this.lstAliases.TabIndex = 3;
            this.lstAliases.SelectedIndexChanged += new System.EventHandler(this.lstAliases_SelectedIndexChanged);
            this.lstAliases.DoubleClick += new System.EventHandler(this.lstAliases_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblHostIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstAliases, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddAlias, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHostIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAliases, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAddAlias, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.butAddAlias, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.butRemoveAlias, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 295);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblHostIP
            // 
            this.lblHostIP.AutoSize = true;
            this.lblHostIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHostIP.Location = new System.Drawing.Point(3, 0);
            this.lblHostIP.Name = "lblHostIP";
            this.lblHostIP.Size = new System.Drawing.Size(61, 26);
            this.lblHostIP.TabIndex = 0;
            this.lblHostIP.Text = "IP Address:";
            this.lblHostIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddAlias
            // 
            this.lblAddAlias.AutoSize = true;
            this.lblAddAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddAlias.Location = new System.Drawing.Point(3, 26);
            this.lblAddAlias.Name = "lblAddAlias";
            this.lblAddAlias.Size = new System.Drawing.Size(61, 29);
            this.lblAddAlias.TabIndex = 0;
            this.lblAddAlias.Text = "Alias:";
            this.lblAddAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAliases
            // 
            this.lblAliases.AutoSize = true;
            this.lblAliases.Location = new System.Drawing.Point(3, 55);
            this.lblAliases.Name = "lblAliases";
            this.lblAliases.Size = new System.Drawing.Size(43, 13);
            this.lblAliases.TabIndex = 0;
            this.lblAliases.Text = "Aliases:";
            // 
            // txtAddAlias
            // 
            this.txtAddAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddAlias.Location = new System.Drawing.Point(70, 29);
            this.txtAddAlias.Name = "txtAddAlias";
            this.txtAddAlias.Size = new System.Drawing.Size(370, 20);
            this.txtAddAlias.TabIndex = 1;
            this.txtAddAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAddAlias_KeyUp);
            // 
            // butAddAlias
            // 
            this.butAddAlias.Location = new System.Drawing.Point(446, 29);
            this.butAddAlias.Name = "butAddAlias";
            this.butAddAlias.Size = new System.Drawing.Size(44, 23);
            this.butAddAlias.TabIndex = 2;
            this.butAddAlias.Text = "&Add...";
            this.butAddAlias.UseVisualStyleBackColor = true;
            this.butAddAlias.Click += new System.EventHandler(this.butAddAlias_Click);
            // 
            // butRemoveAlias
            // 
            this.butRemoveAlias.Enabled = false;
            this.butRemoveAlias.Location = new System.Drawing.Point(70, 269);
            this.butRemoveAlias.Name = "butRemoveAlias";
            this.butRemoveAlias.Size = new System.Drawing.Size(75, 23);
            this.butRemoveAlias.TabIndex = 4;
            this.butRemoveAlias.Text = "&Remove...";
            this.butRemoveAlias.UseVisualStyleBackColor = true;
            this.butRemoveAlias.Click += new System.EventHandler(this.butRemoveAlias_Click);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(334, 301);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 3;
            this.butOK.Text = "&OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(415, 301);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "&Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(70, 249);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(370, 20);
            this.txtComment.TabIndex = 6;
            // 
            // frmHostEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(493, 332);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHostEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHostEntry";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.ListBox lstAliases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHostIP;
        private System.Windows.Forms.Label lblAddAlias;
        private System.Windows.Forms.Label lblAliases;
        private System.Windows.Forms.TextBox txtAddAlias;
        private System.Windows.Forms.Button butAddAlias;
        private System.Windows.Forms.Button butRemoveAlias;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
    }
}