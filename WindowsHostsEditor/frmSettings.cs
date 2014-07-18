using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsHostsEditorLib;

namespace WindowsHostsEditor
{
    public partial class frmSettings : Form
    {
        public ProgramSettings Settings { get; set; }

        public frmSettings(ProgramSettings settings)
        {
            InitializeComponent();
            if (settings == null)
                this.Settings = new ProgramSettings();
            else
                this.Settings = settings;


            radioCustomHostInputFile.Checked = Settings.UseHostInputCustomFile;
            if (Settings.UseHostInputCustomFile)
            {
                txtCustomHostInputFile.Text = Settings.HostInputCustomFilePath;
                openFileDialogHostFile.FileName = Settings.HostInputCustomFilePath;
            }
            else
            {
                Settings.HostInputCustomFilePath = "";
                openFileDialogHostFile.FileName = Hosts.DEFAULT_HOSTS_FILE;
            }

            radioCustomHostOutputFile.Checked = Settings.UseHostOutputCustomFile;
            if (Settings.UseHostOutputCustomFile)
            {
                txtCustomHostOutputFile.Text = Settings.HostOutputCustomFilePath;
                saveFileDialogHostFile.FileName = txtCustomHostOutputFile.Text;
            }
            else
            {
                txtCustomHostOutputFile.Text = "";
                saveFileDialogHostFile.FileName = openFileDialogHostFile.FileName;
            }

            chkDoBackup.Checked = Settings.DoBackupBeforeSave;
            if (Settings.DoBackupBeforeSave)
            {
                txtBackupFolder.Text = Settings.BackupFileLocation;
                folderBrowserDialogBackupLocation.SelectedPath = txtBackupFolder.Text;
            }
            else
            {
                txtBackupFolder.Text = "";
                folderBrowserDialogBackupLocation.SelectedPath = Path.GetDirectoryName(openFileDialogHostFile.FileName);
            }

            chkConfirmOnDelete.Checked = Settings.ConfirmOnDelete;
            chkWarnIfDuplicates.Checked = Settings.WarnIfDuplicates;
            chkConfirmExitWithoutSave.Checked = Settings.ConfirmOnExitWithoutSave;
        }

        #region Form Events
        private void frmSettings_Load(object sender, EventArgs e)
        {
            radioDefaultHostInputFile.Text = "Default file (" + Hosts.DEFAULT_HOSTS_FILE + ")";
            toolTipRadioDefaultHostInputFile.SetToolTip(radioDefaultHostInputFile, radioDefaultHostInputFile.Text);
            openFileDialogHostFile.InitialDirectory = Path.GetDirectoryName(Hosts.DEFAULT_HOSTS_FILE);
            openFileDialogHostFile.FileName = Path.GetFileName(Hosts.DEFAULT_HOSTS_FILE);
        }

        private void radioCustomHostInputFile_CheckedChanged(object sender, EventArgs e)
        {
            butBrowseCustomHostInputFile.Enabled = radioCustomHostInputFile.Checked;
            txtCustomHostInputFile.Enabled = radioCustomHostInputFile.Checked;
            txtCustomHostInputFile.ReadOnly = !radioCustomHostInputFile.Checked;
        }

        private void radioCustomHostOutputFile_CheckedChanged(object sender, EventArgs e)
        {
            butBrowseCustomHostOutputFile.Enabled = radioCustomHostOutputFile.Checked;
            txtCustomHostOutputFile.Enabled = radioCustomHostOutputFile.Checked;
            txtCustomHostOutputFile.ReadOnly = !radioCustomHostOutputFile.Checked;
        }

        private void butBrowseCustomHostInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogHostFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialogHostFile.FileName.ToLower() == Hosts.DEFAULT_HOSTS_FILE.ToLower())
                {
                    radioDefaultHostInputFile.Checked = true;
                    txtCustomHostInputFile.Text = "";
                }
                else
                {
                    txtCustomHostInputFile.Text = openFileDialogHostFile.FileName;
                }
            }
        }

        private void butBrowseCustomHostOutputFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogHostFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string inputHostsFiles = radioDefaultHostInputFile.Checked ? Hosts.DEFAULT_HOSTS_FILE.ToLower() : txtCustomHostInputFile.Text.ToLower();

                if (saveFileDialogHostFile.FileName.ToLower() == inputHostsFiles)
                {
                    radioDefaultHostOutputFile.Checked = true;
                    txtCustomHostOutputFile.Text = "";
                }
                else
                {
                    txtCustomHostOutputFile.Text = saveFileDialogHostFile.FileName;
                }
            }
        }

        private void chkDoBackup_CheckedChanged(object sender, EventArgs e)
        {
            txtBackupFolder.Enabled = chkDoBackup.Checked;
            txtBackupFolder.ReadOnly = !chkDoBackup.Checked;
            butBrowseBackupLocation.Enabled = chkDoBackup.Checked;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Settings.UseHostInputCustomFile = radioCustomHostInputFile.Checked;
            if (Settings.UseHostInputCustomFile)
                Settings.HostInputCustomFilePath = txtCustomHostInputFile.Text;
            else
                Settings.HostInputCustomFilePath = "";

            Settings.UseHostOutputCustomFile = radioCustomHostOutputFile.Checked;
            if (Settings.UseHostOutputCustomFile)
                Settings.HostOutputCustomFilePath = txtCustomHostOutputFile.Text;
            else
                Settings.HostOutputCustomFilePath = "";

            Settings.DoBackupBeforeSave = chkDoBackup.Checked;
            if (Settings.DoBackupBeforeSave)
                Settings.BackupFileLocation = txtBackupFolder.Text;
            else
                Settings.BackupFileLocation = "";

            Settings.ConfirmOnDelete = chkConfirmOnDelete.Checked;
            Settings.WarnIfDuplicates = chkWarnIfDuplicates.Checked;
            Settings.ConfirmOnExitWithoutSave = chkConfirmExitWithoutSave.Checked;

            ProgramSettings.ValidationResult res = Settings.Validate();
            string errorMessage = null;

            switch (res)
            {
                case ProgramSettings.ValidationResult.CustomInputWithoutValidFile:
                    errorMessage = "Invalid filename for custom hosts input file";
                    break;
                case ProgramSettings.ValidationResult.CustomOutputWithoutValidFile:
                    errorMessage = "Invalid or read-only filename for custom hosts output file";
                    break;
                case ProgramSettings.ValidationResult.BackupWithoutValidLocation:
                    errorMessage = "Invalid or read-only location for creation of backup files";
                    break;
            }

            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error saving settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void butBrowseBackupLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogBackupLocation.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBackupFolder.Text = folderBrowserDialogBackupLocation.SelectedPath;
            }
        }

        #endregion
    }
}
