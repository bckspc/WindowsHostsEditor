using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsHostsEditorLib;

namespace WindowsHostsEditor
{
    public partial class frmMain : Form
    {
        private int listViewSortColumn = -1;

        private ProgramSettings Settings;

        private bool listModified = false;

        private Hosts Hosts { get; set; }

        public frmMain()
        {
            InitializeComponent();
            lvHostEntries.MouseWheel += lvHostEntries_MouseWheel;
            Settings = ProgramSettings.Read();
        }

        #region Helpers

        private void UpdateUIButtons()
        {
            editToolStripMenuItem.Enabled = lvHostEntries.SelectedItems.Count > 0;
            toolStripButtonEditHost.Enabled = lvHostEntries.SelectedItems.Count > 0;

            deleteToolStripMenuItem.Enabled = lvHostEntries.SelectedItems.Count > 0;
            toolStripButtonDelete.Enabled = lvHostEntries.SelectedItems.Count > 0;
        }

        private ListViewItem GenerateLVIToAdd(HostEntry entry)
        {
            ListViewItem item = new ListViewItem(entry.HostIP);
            item.Tag = entry.GetKey();
            item.ImageIndex = 0;
            string formattedAliases = entry.GetFormattedAliases(",", "<none>");
            item.ToolTipText = formattedAliases;
            item.SubItems.Add(formattedAliases);
            item.SubItems.Add(String.IsNullOrEmpty(entry.Comment) ? "" : entry.Comment);
            return item;
        }

        private void ShowAddEditForm(bool isNew = false)
        {
            if (!isNew && lvHostEntries.SelectedItems.Count != 1)
                return;

            HostEntry selectedEntry = null;

            if (!isNew)
                selectedEntry = Hosts.Entries[lvHostEntries.SelectedItems[0].Tag.ToString()];

            frmHostEntry entry = new frmHostEntry(selectedEntry);
            DialogResult res = entry.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                HostEntry newHostEntry = entry.NewHostEntry;
                if (entry.GivenHostEntry != null)
                    Hosts.Entries.Remove(entry.GivenHostEntry.GetKey());

                if (Hosts.Entries.ContainsKey(entry.NewHostEntry.GetKey()))
                {
                    MessageBox.Show("This host and aliases already exist in the list", "Error adding host entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Hosts.Entries.Add(entry.NewHostEntry.GetKey(), entry.NewHostEntry);
                ListViewItem newItem = GenerateLVIToAdd(entry.NewHostEntry);

                if (entry.GivenHostEntry != null)
                {
                    ListViewItem foundItem = null;
                    foreach (ListViewItem item in lvHostEntries.Items)
                    {
                        if (item.Tag.ToString() == entry.GivenHostEntry.GetKey())
                        {
                            foundItem = item;
                            break;
                        }
                    }

                    if (foundItem != null)
                    {
                        lvHostEntries.Items.Remove(foundItem);
                    }
                }

                lvHostEntries.Items.Add(newItem);

                listModified = true;
            }
        }

        private void SaveChanges()
        {
            Hosts.HostsWriteResult res = Hosts.WriteHosts(Settings.DoBackupBeforeSave);
            string message = "";
            switch (res)
            {
                case Hosts.HostsWriteResult.OK:
                    message = "";
                    break;
                case Hosts.HostsWriteResult.HostsFileModified:
                    message = "The original hosts file was modified outside this program. Cannot save changes";
                    break;
                case Hosts.HostsWriteResult.HostsBackupLocationNotSet:
                    message = "Cannot find hosts backup location and backup action is set";
                    break;
                case Hosts.HostsWriteResult.HostsBackupFileNotWritable:
                    message = "The hosts backup location is not writable or it cannot create/edit file";
                    break;
                case Hosts.HostsWriteResult.ExceptionCreatingBackup:
                    message = "There was an unknown error creating the backup file";
                    break;
            }
            if (!String.IsNullOrWhiteSpace(message))
                MessageBox.Show(message + ".\nChanges were not saved.", "Error saving changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                listModified = false;
        }

        private void ReloadHosts()
        {
            Hosts = new Hosts(Settings.GetEffectiveHostInputFile(), Settings.GetEffectiveHostOutputFile());
            Hosts.HostsBackupDir = Settings.DoBackupBeforeSave ? Settings.BackupFileLocation : "";

            bool hasDuplicates;
            Hosts.LoadHosts(out hasDuplicates);

            if (hasDuplicates && Settings.WarnIfDuplicates)
            {
                MessageBox.Show("Some duplicate entries were found while reading hosts file.\nOnly the first entry was kept in the list", "Duplicate host entries warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lvHostEntries.Items.Clear();

            foreach (HostEntry entry in Hosts.Entries.Values)
            {
                ListViewItem newItem = GenerateLVIToAdd(entry);
                lvHostEntries.Items.Add(newItem);
            }

            lvHostEntries.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            toolStripComboBoxViewMode.SelectedIndex = 4;
            UpdateUIButtons();
        }

        #endregion

        #region Form Events

        private void addHostAction(object sender, EventArgs e)
        {
            ShowAddEditForm(true);
        }

        private void editHostAction(object sender, EventArgs e)
        {
            ShowAddEditForm();
        }

        private void deleteHostAction(object sender, EventArgs e)
        {
            if (lvHostEntries.SelectedIndices.Count != 1)
                return;

            ListViewItem selectedItem = lvHostEntries.SelectedItems[0];
            HostEntry selectedEntry = Hosts.Entries[selectedItem.Tag.ToString()];

            if (Settings.ConfirmOnDelete)
            {
                if (MessageBox.Show("Are you sure you want to remove IP Address entry: " + selectedEntry.HostIP + "?", "Confirm host deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                    return;
            }

            selectedItem.Remove();
            Hosts.DeleteEntry(selectedEntry);
            listModified = true;
        }

        private void exitAction(object sender, EventArgs e)
        {
            if (listModified && Settings.ConfirmOnExitWithoutSave)
            {
                DialogResult res = MessageBox.Show("You've made changes in you hosts list. Do you want to save changes?", "Save confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (res == System.Windows.Forms.DialogResult.Cancel)
                    return;
                if (res == System.Windows.Forms.DialogResult.Yes)
                    SaveChanges();
            }

            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReloadHosts();
        }

        private void lvHostEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIButtons();
        }

        private void lvHostEntries_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != listViewSortColumn)
            {
                if (listViewSortColumn != -1)
                    lvHostEntries.Columns[listViewSortColumn].ImageKey = null;
                // Set the sort column to the new column.
                listViewSortColumn = e.Column;
                // Set the sort order to ascending by default.
                lvHostEntries.Sorting = SortOrder.Ascending;
                lvHostEntries.Columns[e.Column].ImageKey = "up";
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lvHostEntries.Sorting == SortOrder.Ascending)
                {
                    lvHostEntries.Sorting = SortOrder.Descending;
                    lvHostEntries.Columns[e.Column].ImageKey = "down";
                }
                else
                {
                    lvHostEntries.Sorting = SortOrder.Ascending;
                    lvHostEntries.Columns[e.Column].ImageKey = "up";
                }
            }

            // Call the sort method to manually sort.
            lvHostEntries.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.lvHostEntries.ListViewItemSorter = new ListViewItemComparer(e.Column, lvHostEntries.Sorting);
        }

        private void lvHostEntries_DoubleClick(object sender, EventArgs e)
        {
            ShowAddEditForm();
        }

        private void toolStripComboBoxViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBoxViewMode.SelectedIndex)
            {
                case 0:
                    lvHostEntries.LargeImageList = hostEntriesServerImageList32;
                    lvHostEntries.View = View.LargeIcon;
                    break;
                case 1:
                    lvHostEntries.LargeImageList = hostEntriesServerImageList48;
                    lvHostEntries.View = View.LargeIcon;
                    break;
                case 2:
                    lvHostEntries.LargeImageList = hostEntriesServerImageList64;
                    lvHostEntries.View = View.LargeIcon;
                    break;
                case 3:
                    lvHostEntries.LargeImageList = hostEntriesServerImageList128;
                    lvHostEntries.View = View.LargeIcon;
                    break;
                case 4:
                    lvHostEntries.View = View.Details;
                    break;
            }
        }

        private void lvHostEntries_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteHostAction(sender, e);
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings(this.Settings.Clone());

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool reloadHosts = false;

                if (this.Settings.UseHostInputCustomFile != frm.Settings.UseHostInputCustomFile
                    || this.Settings.HostInputCustomFilePath != frm.Settings.HostInputCustomFilePath)
                {
                    DialogResult res = MessageBox.Show("You've changed the hosts input file. Do you want to reload?\nIf you press 'Yes', you will reload the hosts file and loose any pending changes\nIf you press 'No', all the changes to settings will be discarded.", "Reload hosts confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (res == System.Windows.Forms.DialogResult.No)
                        return;
                    else
                        reloadHosts = true;
                }
                this.Settings = frm.Settings;
                this.Hosts.HostsOutputFile = this.Settings.GetEffectiveHostOutputFile();
                this.Hosts.HostsBackupDir = this.Settings.BackupFileLocation;

                if (reloadHosts)
                    ReloadHosts();
                ProgramSettings.Write(this.Settings);
            }
        }

        private void toolStripMenuItemSetToolbarSmallIcons_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemSetToolbarSmallIcons.Checked)
            {
                toolStrip1.ImageScalingSize = new Size(16, 16);
                toolStrip1.Height = 16;
                toolStripMenuItemSetToolbarLargeIcons.Checked = false;
            }
        }

        private void toolStripMenuItemSetToolbarLargeIcons_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemSetToolbarLargeIcons.Checked)
            {
                toolStrip1.ImageScalingSize = new Size(32, 32);
                toolStrip1.Height = 32;
                toolStripMenuItemSetToolbarSmallIcons.Checked = false;
            }
        }

        private void toolStripButtonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void toolStripButtonReloadHosts_Click(object sender, EventArgs e)
        {
            ReloadHosts();
        }

        private void toolStripMenuItemShowToolbarIconText_Click(object sender, EventArgs e)
        {
            ToolStripItemDisplayStyle style = toolStripMenuItemShowToolbarIconText.Checked ? ToolStripItemDisplayStyle.ImageAndText : ToolStripItemDisplayStyle.Image;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = style;
            }

        }

        private void toolStripButtonCleanUp_Click(object sender, EventArgs e)
        {
            if (listModified && MessageBox.Show("You have to save changes in order to use the clean up feature.\nDo you want to save changes now?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                return;

            SaveChanges();

            frmCleanUp frm = new frmCleanUp(Settings.GetEffectiveHostOutputFile());
            frm.ShowDialog();
        }

        private void lvHostEntries_MouseWheel(object sender, MouseEventArgs e)
        {
            if (System.Windows.Forms.Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                    toolStripComboBoxViewMode.SelectedIndex = toolStripComboBoxViewMode.SelectedIndex == 4 ? 4 : toolStripComboBoxViewMode.SelectedIndex + 1;
                if (e.Delta < 0)
                    toolStripComboBoxViewMode.SelectedIndex = toolStripComboBoxViewMode.SelectedIndex == 0 ? 0 : toolStripComboBoxViewMode.SelectedIndex - 1;
            }
        }

        #endregion
    }
}
