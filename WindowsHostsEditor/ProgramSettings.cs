using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsHostsEditorLib;

namespace WindowsHostsEditor
{
    /// <summary>
    /// This class represents all the program settings that will be
    /// serialized/deserialized as needed.
    /// </summary>
    [Serializable]
    public class ProgramSettings
    {
        public enum ValidationResult
        {
            OK,
            CustomInputWithoutValidFile,
            CustomOutputWithoutValidFile,
            BackupWithoutValidLocation
        }

        /// <summary>
        /// If true, it will use the value of HostInputCustomFilePath to read the hosts file
        /// </summary>
        public bool UseHostInputCustomFile { get; set; }

        /// <summary>
        /// A custom path to a file that contains an hosts file
        /// </summary>
        public string HostInputCustomFilePath { get; set; }

        /// <summary>
        /// If true, it will use the value of HostOutputCustomFilePath to write the hosts file
        /// </summary>
        public bool UseHostOutputCustomFile { get; set; }

        /// <summary>
        /// A custom path to a file that will be written with the hosts file content
        /// </summary>
        public string HostOutputCustomFilePath { get; set; }

        /// <summary>
        /// If true, it will write the contents of the hosts file before saving
        /// the changes in the output file.
        /// </summary>
        public bool DoBackupBeforeSave { get; set; }

        /// <summary>
        /// Contains the path for the backup folder where the backed up hosts file
        /// will be written. The files will be written with the format: "hosts_" + DateTime.Now.Ticks + ".bak"
        /// </summary>
        public string BackupFileLocation { get; set; }

        /// <summary>
        /// If true, the interface will confirm before deleting an entry from the hosts file.
        /// </summary>
        public bool ConfirmOnDelete { get; set; }

        /// <summary>
        /// If true, the program will check for duplicate host entries everytime the list is reloaded
        /// and will warn the user
        /// </summary>
        public bool WarnIfDuplicates { get; set; }

        /// <summary>
        /// If true, the program will warn the user when it tries to exit with unsaved changes
        /// </summary>
        public bool ConfirmOnExitWithoutSave { get; set; }

        /// <summary>
        /// Returns the hosts file to use, the default or the custom one based
        /// on the properties set.
        /// </summary>
        /// <returns>The full path for the hosts file to use</returns>
        public string GetEffectiveHostInputFile()
        {
            return UseHostInputCustomFile ? HostInputCustomFilePath : Hosts.DEFAULT_HOSTS_FILE;
        }

        /// <summary>
        /// Returns the hosts file to write to, the default or the custom one based
        /// on the properties set.
        /// </summary>
        /// <returns>The full path for the hosts file to write to</returns>
        public string GetEffectiveHostOutputFile()
        {
            return UseHostOutputCustomFile ? HostOutputCustomFilePath : GetEffectiveHostInputFile();
        }

        public ProgramSettings()
        {
            UseHostInputCustomFile = false;
            HostOutputCustomFilePath = "";
            UseHostOutputCustomFile = false;
            HostOutputCustomFilePath = "";
            DoBackupBeforeSave = false;
            BackupFileLocation = "";
            ConfirmOnDelete = true;
            WarnIfDuplicates = false;
            ConfirmOnExitWithoutSave = true;
        }

        /// <summary>
        /// Validates the coherency of the Settings value. It returns an enum with the kind
        /// of error found.
        /// </summary>
        /// <returns></returns>
        public ValidationResult Validate()
        {
            if (UseHostInputCustomFile && (String.IsNullOrWhiteSpace(HostInputCustomFilePath) || !File.Exists(HostInputCustomFilePath)))
                return ValidationResult.CustomInputWithoutValidFile;

            if (UseHostOutputCustomFile)
            {
                if (String.IsNullOrWhiteSpace(HostOutputCustomFilePath))
                    return ValidationResult.CustomOutputWithoutValidFile;

                if (!File.Exists(HostOutputCustomFilePath))
                    File.Create(HostOutputCustomFilePath).Close();
                if (File.GetAttributes(HostOutputCustomFilePath).HasFlag(FileAttributes.ReadOnly))
                    return ValidationResult.CustomOutputWithoutValidFile;
            }

            if (DoBackupBeforeSave && (String.IsNullOrWhiteSpace(BackupFileLocation) || !DirectoryHasPermission(BackupFileLocation, FileSystemRights.CreateFiles)))
                return ValidationResult.BackupWithoutValidLocation;

            return ValidationResult.OK;
        }

        /// <summary>
        /// This method returns true if the current thread can write on the specified folder
        /// </summary>
        /// <param name="destDir">Folder to test the write permissions</param>
        /// <returns>True if can write to folder, false otherwise</returns>
        [Obsolete("Should use method DirectoryHasPermission")]
        private static bool HasFolderWritePermission(string destDir)
        {
            if (string.IsNullOrWhiteSpace(destDir) || !Directory.Exists(destDir))
                return false;

            try
            {
                DirectorySecurity security = Directory.GetAccessControl(destDir);
                SecurityIdentifier users = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
                SecurityIdentifier admins = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);
                foreach (AuthorizationRule rule in security.GetAccessRules(true, true, typeof(SecurityIdentifier)))
                {
                    if (rule.IdentityReference == users)
                    {
                        FileSystemAccessRule rights = ((FileSystemAccessRule)rule);
                        if (rights.AccessControlType == AccessControlType.Allow)
                        {
                            if (rights.FileSystemRights == (rights.FileSystemRights | FileSystemRights.Modify))
                                return true;
                        }
                    }
                    if (rule.IdentityReference == admins)
                    {
                        FileSystemAccessRule rights = ((FileSystemAccessRule)rule);
                        if (rights.AccessControlType == AccessControlType.Allow)
                        {
                            if (rights.FileSystemRights == (rights.FileSystemRights | FileSystemRights.Modify))
                                return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// This method returns true if the current thread can enforce the access right in the
        /// specified folder
        /// </summary>
        /// <param name="DirectoryPath">The folder path where to test the access right</param>
        /// <param name="AccessRight">The access right to test</param>
        /// <returns>True if the access right can be enforced in the specified folder</returns>
        private static bool DirectoryHasPermission(string DirectoryPath, FileSystemRights AccessRight)
        {
            if (string.IsNullOrEmpty(DirectoryPath)) return false;

            try
            {
                AuthorizationRuleCollection rules = Directory.GetAccessControl(DirectoryPath).GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                WindowsIdentity identity = WindowsIdentity.GetCurrent();

                foreach (FileSystemAccessRule rule in rules)
                {
                    if (identity.Groups.Contains(rule.IdentityReference))
                    {
                        if ((AccessRight & rule.FileSystemRights) == AccessRight)
                        {
                            if (rule.AccessControlType == AccessControlType.Allow)
                                return true;
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        /// <summary>
        /// This method reads the config file from disk and writes it in a ProgramSettings instance
        /// </summary>
        /// <returns>Returns a ProgramSettings object filled with the data from the config file.</returns>
        public static ProgramSettings Read()
        {
            ProgramSettings result = new ProgramSettings();
            string configFile = Path.ChangeExtension(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, "cfg");
            configFile = Path.Combine(Application.ExecutablePath, configFile);

            if (System.IO.File.Exists(configFile))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(configFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                result = (ProgramSettings)formatter.Deserialize(stream);
                stream.Close();
            }

            return result;
        }

        /// <summary>
        /// This method writes the config file to disk using the data in a ProgramSettings object
        /// </summary>
        /// <param name="settings">The settings to be written to disk</param>
        public static void Write(ProgramSettings settings)
        {
            string configFile = Path.ChangeExtension(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, "cfg");
            configFile = Path.Combine(Application.ExecutablePath, configFile);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(configFile, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, settings);
            stream.Close();
        }

        /// <summary>
        /// It clones the current object to ensure different memory references for all properties
        /// </summary>
        /// <returns>Returns a new copy of the ProgramSettings object</returns>
        public ProgramSettings Clone()
        {
            ProgramSettings result = new ProgramSettings();
            result.UseHostInputCustomFile = this.UseHostInputCustomFile;
            result.HostInputCustomFilePath = this.HostInputCustomFilePath;

            result.UseHostOutputCustomFile = this.UseHostOutputCustomFile;
            result.HostOutputCustomFilePath = this.HostOutputCustomFilePath;

            result.DoBackupBeforeSave = this.DoBackupBeforeSave;
            result.BackupFileLocation = this.BackupFileLocation;

            result.ConfirmOnDelete = this.ConfirmOnDelete;
            result.ConfirmOnExitWithoutSave = this.ConfirmOnExitWithoutSave;
            result.WarnIfDuplicates = this.WarnIfDuplicates;

            return result;
        }
    }
}
