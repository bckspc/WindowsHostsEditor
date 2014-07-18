namespace WindowsHostsEditor
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "10.123.12.123",
            "alias1 alias2 alias3"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "192.168.1.254",
            "host1 host2"}, 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lvHostEntries = new System.Windows.Forms.ListView();
            this.columnHeaderIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHosts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostEntriesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostEntriesServerImageList128 = new System.Windows.Forms.ImageList(this.components);
            this.hostEntriesSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.hostEntriesServerImageList32 = new System.Windows.Forms.ImageList(this.components);
            this.hostEntriesServerImageList48 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStripToolBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSetToolbarSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetToolbarLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemShowToolbarIconText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAddHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReloadHosts = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCleanUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxViewMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.hostEntriesServerImageList64 = new System.Windows.Forms.ImageList(this.components);
            this.hostEntriesContextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHostEntries
            // 
            this.lvHostEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIPAddress,
            this.columnHeaderHosts,
            this.columnHeaderComments});
            this.lvHostEntries.ContextMenuStrip = this.hostEntriesContextMenuStrip;
            this.lvHostEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHostEntries.FullRowSelect = true;
            this.lvHostEntries.GridLines = true;
            listViewItem2.ToolTipText = "TESTE";
            this.lvHostEntries.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvHostEntries.LargeImageList = this.hostEntriesServerImageList128;
            this.lvHostEntries.Location = new System.Drawing.Point(0, 25);
            this.lvHostEntries.MultiSelect = false;
            this.lvHostEntries.Name = "lvHostEntries";
            this.lvHostEntries.ShowGroups = false;
            this.lvHostEntries.ShowItemToolTips = true;
            this.lvHostEntries.Size = new System.Drawing.Size(746, 290);
            this.lvHostEntries.SmallImageList = this.hostEntriesSmallImageList;
            this.lvHostEntries.TabIndex = 0;
            this.lvHostEntries.UseCompatibleStateImageBehavior = false;
            this.lvHostEntries.View = System.Windows.Forms.View.Details;
            this.lvHostEntries.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvHostEntries_ColumnClick);
            this.lvHostEntries.SelectedIndexChanged += new System.EventHandler(this.lvHostEntries_SelectedIndexChanged);
            this.lvHostEntries.DoubleClick += new System.EventHandler(this.lvHostEntries_DoubleClick);
            this.lvHostEntries.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvHostEntries_KeyUp);
            // 
            // columnHeaderIPAddress
            // 
            this.columnHeaderIPAddress.Text = "IP Address";
            this.columnHeaderIPAddress.Width = 110;
            // 
            // columnHeaderHosts
            // 
            this.columnHeaderHosts.Text = "Aliases";
            this.columnHeaderHosts.Width = 252;
            // 
            // columnHeaderComments
            // 
            this.columnHeaderComments.Text = "Comments";
            this.columnHeaderComments.Width = 100;
            // 
            // hostEntriesContextMenuStrip
            // 
            this.hostEntriesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.hostEntriesContextMenuStrip.Name = "hostEntriesContextMenuStrip";
            this.hostEntriesContextMenuStrip.Size = new System.Drawing.Size(108, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::WindowsHostsEditor.Properties.Resources.addHost;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "&Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addHostAction);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::WindowsHostsEditor.Properties.Resources.editHost;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "&Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editHostAction);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::WindowsHostsEditor.Properties.Resources.deleteHost;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteHostAction);
            // 
            // hostEntriesServerImageList128
            // 
            this.hostEntriesServerImageList128.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hostEntriesServerImageList128.ImageStream")));
            this.hostEntriesServerImageList128.TransparentColor = System.Drawing.Color.Transparent;
            this.hostEntriesServerImageList128.Images.SetKeyName(0, "server");
            // 
            // hostEntriesSmallImageList
            // 
            this.hostEntriesSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hostEntriesSmallImageList.ImageStream")));
            this.hostEntriesSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.hostEntriesSmallImageList.Images.SetKeyName(0, "server");
            this.hostEntriesSmallImageList.Images.SetKeyName(1, "up");
            this.hostEntriesSmallImageList.Images.SetKeyName(2, "down");
            // 
            // hostEntriesServerImageList32
            // 
            this.hostEntriesServerImageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hostEntriesServerImageList32.ImageStream")));
            this.hostEntriesServerImageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.hostEntriesServerImageList32.Images.SetKeyName(0, "server");
            // 
            // hostEntriesServerImageList48
            // 
            this.hostEntriesServerImageList48.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hostEntriesServerImageList48.ImageStream")));
            this.hostEntriesServerImageList48.TransparentColor = System.Drawing.Color.Transparent;
            this.hostEntriesServerImageList48.Images.SetKeyName(0, "server");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStripToolBar;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddHost,
            this.toolStripButtonEditHost,
            this.toolStripButtonDelete,
            this.toolStripSeparator2,
            this.toolStripButtonSaveChanges,
            this.toolStripButtonReloadHosts,
            this.toolStripButtonCleanUp,
            this.toolStripSeparator3,
            this.toolStripButtonSettings,
            this.toolStripSeparator4,
            this.toolStripComboBoxViewMode,
            this.toolStripSeparator5,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // contextMenuStripToolBar
            // 
            this.contextMenuStripToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetToolbarSmallIcons,
            this.toolStripMenuItemSetToolbarLargeIcons,
            this.toolStripSeparator6,
            this.toolStripMenuItemShowToolbarIconText});
            this.contextMenuStripToolBar.Name = "contextMenuStripToolBar";
            this.contextMenuStripToolBar.Size = new System.Drawing.Size(157, 76);
            // 
            // toolStripMenuItemSetToolbarSmallIcons
            // 
            this.toolStripMenuItemSetToolbarSmallIcons.Checked = true;
            this.toolStripMenuItemSetToolbarSmallIcons.CheckOnClick = true;
            this.toolStripMenuItemSetToolbarSmallIcons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSetToolbarSmallIcons.Name = "toolStripMenuItemSetToolbarSmallIcons";
            this.toolStripMenuItemSetToolbarSmallIcons.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemSetToolbarSmallIcons.Text = "&Small icons";
            this.toolStripMenuItemSetToolbarSmallIcons.CheckedChanged += new System.EventHandler(this.toolStripMenuItemSetToolbarSmallIcons_CheckedChanged);
            // 
            // toolStripMenuItemSetToolbarLargeIcons
            // 
            this.toolStripMenuItemSetToolbarLargeIcons.CheckOnClick = true;
            this.toolStripMenuItemSetToolbarLargeIcons.Name = "toolStripMenuItemSetToolbarLargeIcons";
            this.toolStripMenuItemSetToolbarLargeIcons.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemSetToolbarLargeIcons.Text = "&Large items";
            this.toolStripMenuItemSetToolbarLargeIcons.CheckedChanged += new System.EventHandler(this.toolStripMenuItemSetToolbarLargeIcons_CheckedChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripMenuItemShowToolbarIconText
            // 
            this.toolStripMenuItemShowToolbarIconText.Checked = true;
            this.toolStripMenuItemShowToolbarIconText.CheckOnClick = true;
            this.toolStripMenuItemShowToolbarIconText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemShowToolbarIconText.Name = "toolStripMenuItemShowToolbarIconText";
            this.toolStripMenuItemShowToolbarIconText.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemShowToolbarIconText.Text = "Show icons text";
            this.toolStripMenuItemShowToolbarIconText.Click += new System.EventHandler(this.toolStripMenuItemShowToolbarIconText_Click);
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.Image = global::WindowsHostsEditor.Properties.Resources.addHost;
            this.toolStripButtonAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonAddHost.Text = "&Add...";
            this.toolStripButtonAddHost.ToolTipText = "Add a host to the list";
            this.toolStripButtonAddHost.Click += new System.EventHandler(this.addHostAction);
            // 
            // toolStripButtonEditHost
            // 
            this.toolStripButtonEditHost.Image = global::WindowsHostsEditor.Properties.Resources.editHost;
            this.toolStripButtonEditHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditHost.Name = "toolStripButtonEditHost";
            this.toolStripButtonEditHost.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonEditHost.Text = "&Edit...";
            this.toolStripButtonEditHost.ToolTipText = "Edits the selected host";
            this.toolStripButtonEditHost.Click += new System.EventHandler(this.editHostAction);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = global::WindowsHostsEditor.Properties.Resources.deleteHost;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonDelete.Text = "&Delete";
            this.toolStripButtonDelete.ToolTipText = "Deletes the selected host";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.deleteHostAction);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveChanges
            // 
            this.toolStripButtonSaveChanges.Image = global::WindowsHostsEditor.Properties.Resources.saveChanges;
            this.toolStripButtonSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveChanges.Name = "toolStripButtonSaveChanges";
            this.toolStripButtonSaveChanges.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonSaveChanges.Text = "&Save";
            this.toolStripButtonSaveChanges.ToolTipText = "Saves the changes made to the host list";
            this.toolStripButtonSaveChanges.Click += new System.EventHandler(this.toolStripButtonSaveChanges_Click);
            // 
            // toolStripButtonReloadHosts
            // 
            this.toolStripButtonReloadHosts.Image = global::WindowsHostsEditor.Properties.Resources.refresh;
            this.toolStripButtonReloadHosts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReloadHosts.Name = "toolStripButtonReloadHosts";
            this.toolStripButtonReloadHosts.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonReloadHosts.Text = "&Reload";
            this.toolStripButtonReloadHosts.ToolTipText = "Reloads the hosts file from disk";
            this.toolStripButtonReloadHosts.Click += new System.EventHandler(this.toolStripButtonReloadHosts_Click);
            // 
            // toolStripButtonCleanUp
            // 
            this.toolStripButtonCleanUp.Image = global::WindowsHostsEditor.Properties.Resources.clean_up;
            this.toolStripButtonCleanUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCleanUp.Name = "toolStripButtonCleanUp";
            this.toolStripButtonCleanUp.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonCleanUp.Text = "&Clean Up";
            this.toolStripButtonCleanUp.ToolTipText = "Cleans up the hosts file removing excess newlines and spaces";
            this.toolStripButtonCleanUp.Click += new System.EventHandler(this.toolStripButtonCleanUp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Image = global::WindowsHostsEditor.Properties.Resources.programSettings;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonSettings.Text = "&Settings";
            this.toolStripButtonSettings.ToolTipText = "Shows the settings dialog";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxViewMode
            // 
            this.toolStripComboBoxViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxViewMode.DropDownWidth = 100;
            this.toolStripComboBoxViewMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBoxViewMode.Items.AddRange(new object[] {
            "Small Icons",
            "Medium Icons",
            "Large Icons",
            "Extra Large",
            "Details"});
            this.toolStripComboBoxViewMode.MaxDropDownItems = 4;
            this.toolStripComboBoxViewMode.Name = "toolStripComboBoxViewMode";
            this.toolStripComboBoxViewMode.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxViewMode.ToolTipText = "Changes the list view mode";
            this.toolStripComboBoxViewMode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxViewMode_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Image = global::WindowsHostsEditor.Properties.Resources.exitProgram;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonExit.Text = "E&xit";
            this.toolStripButtonExit.ToolTipText = "Exits the program";
            this.toolStripButtonExit.Click += new System.EventHandler(this.exitAction);
            // 
            // hostEntriesServerImageList64
            // 
            this.hostEntriesServerImageList64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("hostEntriesServerImageList64.ImageStream")));
            this.hostEntriesServerImageList64.TransparentColor = System.Drawing.Color.Transparent;
            this.hostEntriesServerImageList64.Images.SetKeyName(0, "server");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 315);
            this.Controls.Add(this.lvHostEntries);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(385, 160);
            this.Name = "frmMain";
            this.Text = "Windows Hosts Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.hostEntriesContextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripToolBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHostEntries;
        private System.Windows.Forms.ColumnHeader columnHeaderIPAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderHosts;
        private System.Windows.Forms.ImageList hostEntriesSmallImageList;
        private System.Windows.Forms.ContextMenuStrip hostEntriesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ImageList hostEntriesServerImageList128;
        private System.Windows.Forms.ImageList hostEntriesServerImageList32;
        private System.Windows.Forms.ImageList hostEntriesServerImageList48;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxViewMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveChanges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ImageList hostEntriesServerImageList64;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripToolBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetToolbarSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetToolbarLargeIcons;
        private System.Windows.Forms.ToolStripButton toolStripButtonReloadHosts;
        private System.Windows.Forms.ColumnHeader columnHeaderComments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowToolbarIconText;
        private System.Windows.Forms.ToolStripButton toolStripButtonCleanUp;
    }
}

