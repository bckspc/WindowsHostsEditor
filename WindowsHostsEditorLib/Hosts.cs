using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsHostsEditorLib
{
    public class Hosts
    {
        #region Consts

        public const string DEFAULT_HOSTS_FILE = @"c:\windows\system32\drivers\etc\hosts";
        public static char[] ALIASES_SEPARATORS = new char[] { '\t', ' ', '\n' };
        private const string IP_ADDRESS_REGEX_PATTERN = @"(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])";
        private const string COMMENT_CHAR = "#";


        #endregion

        #region Statics
        public static bool IsValidIPAddress(string ipAddress)
        {
            Regex regex = new Regex("^" + IP_ADDRESS_REGEX_PATTERN + "$", RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture);
            return regex.IsMatch(ipAddress);
        }

        #endregion

        #region Public Getters and Setters

        public enum HostsWriteResult
        {
            OK,
            HostsFileModified,
            HostsBackupLocationNotSet,
            HostsBackupFileNotWritable,
            ExceptionCreatingBackup
        }

        public string HostsContent { get; private set; }

        public string HostsInputFile { get; set; }

        public string HostsOutputFile { get; set; }

        public string HostsBackupDir { get; set; }

        public Dictionary<string, HostEntry> Entries { get; private set; }

        public Dictionary<string, HostEntry> DeletedEntries { get; private set; }

        #endregion

        public Hosts()
            : this(DEFAULT_HOSTS_FILE)
        {
        }

        public Hosts(string hostsInputFile)
        {

        }

        public Hosts(string hostsInputFile, string hostsOutputFile)
        {
            if (string.IsNullOrWhiteSpace(hostsInputFile))
                this.HostsInputFile = DEFAULT_HOSTS_FILE;
            else
                this.HostsInputFile = hostsInputFile;
            if (string.IsNullOrWhiteSpace(hostsOutputFile))
                this.HostsOutputFile = DEFAULT_HOSTS_FILE;
            else
                this.HostsOutputFile = hostsOutputFile;
        }

        public void LoadHosts(out bool hasDuplicates)
        {
            GetHostEntries(out hasDuplicates);
        }

        public HostsWriteResult WriteHosts(bool doBackup)
        {
            string currentContent = ReadHostsFileContent(this.HostsInputFile);
            if (!currentContent.Equals(this.HostsContent, StringComparison.CurrentCulture))
                return HostsWriteResult.HostsFileModified;

            if (doBackup)
            {
                if (String.IsNullOrWhiteSpace(HostsBackupDir))
                    return HostsWriteResult.HostsBackupLocationNotSet;

                string realBackupFile = Path.Combine(HostsBackupDir, "hosts_" + DateTime.Now.Ticks + ".bak");

                FileInfo backupFileInfo = new FileInfo(realBackupFile);
                backupFileInfo.Create().Close();
                if (backupFileInfo.Attributes.HasFlag(FileAttributes.ReadOnly))
                    return HostsWriteResult.HostsBackupFileNotWritable;
                try
                {
                    File.Copy(this.HostsInputFile, realBackupFile, true);
                }
                catch (Exception)
                {
                    return HostsWriteResult.ExceptionCreatingBackup;
                }
            }

            string[] lines = HostsContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            List<HostEntry> entriesList = Entries.Values.ToList();
            entriesList.Sort();

            List<string> linesList = lines.ToList();

            foreach (var item in entriesList)
            {
                if (item.LineNumber != -1)
                {
                    linesList[item.LineNumber - 1] = item.ToHostFormat();
                    if (!String.IsNullOrEmpty(item.Comment))
                        linesList[item.LineNumber - 2] = COMMENT_CHAR + item.Comment;
                }
                else
                {
                    if (!String.IsNullOrEmpty(item.Comment))
                        linesList.Add(COMMENT_CHAR + item.Comment);
                    linesList.Add(item.ToHostFormat());
                }
            }

            foreach (var item in DeletedEntries.Values)
            {
                if (item.LineNumber == -1)
                    continue;

                linesList[item.LineNumber - 1] = null;
                if (!String.IsNullOrEmpty(item.Comment))
                    linesList[item.LineNumber - 2] = null;
            }

            //HACK FOR DEBUG
            string output = this.HostsOutputFile;
            using (StreamWriter writer = new StreamWriter(output))
            {
                writer.Write(String.Join(Environment.NewLine, linesList));
            }

            return HostsWriteResult.OK;
        }

        public void DeleteEntry(HostEntry entryToDelete)
        {
            if (this.Entries.ContainsKey(entryToDelete.GetKey()))
                this.Entries.Remove(entryToDelete.GetKey());

            if (!this.DeletedEntries.ContainsKey(entryToDelete.GetKey()))
                this.DeletedEntries.Add(entryToDelete.GetKey(), entryToDelete);
        }

        #region Private Methods

        private static string ReadHostsFileContent(string file)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(file))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private string[] ReadHostsFile()
        {
            HostsContent = ReadHostsFileContent(this.HostsInputFile);
            return HostsContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }
        private void GetHostEntries(out bool hasDuplicates)
        {
            hasDuplicates = false;
            string[] lines = ReadHostsFile();
            string regexPattern = @"^(?<ip>" + IP_ADDRESS_REGEX_PATTERN + @")\s+(?<hosts>.*)";
            Regex regex = new Regex(regexPattern, RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture);

            Entries = new Dictionary<string, HostEntry>(lines.Length);
            DeletedEntries = new Dictionary<string, HostEntry>();

            string lastLineComment = null;

            for (int LineNumber = 1; LineNumber <= lines.Length; LineNumber++)
            {
                string line = lines[LineNumber - 1];
                string formattedLine = line.Trim();
                if (formattedLine == "")
                {
                    lastLineComment = "";
                    continue;
                }
                if (formattedLine.StartsWith(COMMENT_CHAR))
                {
                    lastLineComment = formattedLine.Substring(COMMENT_CHAR.Length);
                    continue;
                }

                Match m = regex.Match(formattedLine);

                if (!m.Success)
                {
                    lastLineComment = "";
                    continue;
                }

                string IP = m.Groups["ip"].Value.Trim();
                string RawHosts = m.Groups["hosts"].Value.Trim();
                string[] Hosts = RawHosts.Split(ALIASES_SEPARATORS, StringSplitOptions.RemoveEmptyEntries);

                HostEntry entry = new HostEntry(IP, Hosts, LineNumber);
                if (!String.IsNullOrEmpty(lastLineComment))
                    entry.Comment = lastLineComment;

                if (!Entries.ContainsKey(entry.GetKey()))
                    Entries.Add(entry.GetKey(), entry);
                else if (!hasDuplicates)
                    hasDuplicates = true;
                lastLineComment = "";
            }
        }

        #endregion
    }
}
