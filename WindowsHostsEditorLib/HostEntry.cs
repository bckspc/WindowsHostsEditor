using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsHostsEditorLib
{
    public class HostEntry: IComparable<HostEntry>
    {
        public string HostIP { get; set; }
        public List<string> Aliases { get; set; }

        public string Comment { get; set; }

        public int LineNumber { get; set; }

        public bool IsDeleted { get; set; }

        public HostEntry()
            :this(null)
        {

        }

        public HostEntry(string HostIP)
            : this(HostIP, (string[])null)
        {
        }

        public HostEntry(string HostIP, string Alias)
            : this(HostIP, new string[] { Alias }, -1)
        {
        }

        public HostEntry(string HostIP, string Alias, int LineNumber)
            : this(HostIP, new string[] { Alias }, LineNumber)
        {
        }

        public HostEntry(String HostIP, IEnumerable<string> aliases)
            :this(HostIP, aliases.ToArray<string>(), -1)
        {
        }

        public HostEntry(String HostIP, IEnumerable<string> aliases, int LineNumber)
            : this(HostIP, aliases.ToArray<string>(), LineNumber)
        {
        }

        public HostEntry(string HostIP, string[] Aliases)
            : this(HostIP, Aliases, -1)
        {
        }

        public HostEntry(string HostIP, string[] Aliases, int LineNumber)
        {
            this.HostIP = HostIP;
            this.Aliases = new List<string>(Aliases);
            this.LineNumber = LineNumber;
            this.Comment = null;
            this.IsDeleted = false;
        }

        public string GetKey()
        {
            return HostEntry.GetKey(this);
        }

        public string GetFormattedAliases(string separator = ",", string emptyText = "")
        {
            if (Aliases == null)
                return emptyText;
            return String.Join(separator, Aliases);
        }

        public override string ToString()
        {
            string hostIp = "null";
            string aliases = "null";

            if (!String.IsNullOrWhiteSpace(hostIp))
                hostIp = HostIP;

            if (Aliases != null)
                aliases = String.Join("','", Aliases);

            return "{ ip: '" + hostIp + "', aliases: ['" + aliases + "'], line_number:" + this.LineNumber + "}";
        }

        public static string GetKey(HostEntry entry)
        {
            return entry.HostIP + "_" + String.Join("_", entry.Aliases);
        }

        public string ToHostFormat()
        {
            string result = this.HostIP;
            if(this.Aliases != null && this.Aliases.Count > 0)
                result += '\t' + string.Join("\t", this.Aliases);
            return result;
        }

        public int CompareTo(HostEntry other)
        {
            if (this.LineNumber == -1 && other.LineNumber == -1)
                return 0;

            if (this.LineNumber == -1)
                return 1;
            if (other.LineNumber == -1)
                return -1;

            return this.LineNumber.CompareTo(other.LineNumber);
        }
    }
}
