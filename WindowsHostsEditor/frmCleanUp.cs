using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHostsEditor
{
    public partial class frmCleanUp : Form
    {
        private enum CleanUpType
        {
            RemoveAllNewline,
            RemoveExtraLines,
            InsertAfterComment
        }

        private string OriginalFilePath { get; set; }

        public frmCleanUp(string OriginalFilePath)
        {
            InitializeComponent();
            this.OriginalFilePath = OriginalFilePath;
        }

        #region Form Events

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void butSaveChanges_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(OriginalFilePath))
            {
                writer.Write(txtChanged.Text);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void frmCleanUp_Load(object sender, EventArgs e)
        {
            string OriginalContent = "";
            using (StreamReader reader = new StreamReader(OriginalFilePath))
            {
                OriginalContent = reader.ReadToEnd();
            }

            txtOriginal.Text = OriginalContent;
            CleanUp(CleanUpType.RemoveExtraLines);
        }

        private void CleanUp(CleanUpType type)
        {
            string OriginalContent = txtOriginal.Text;

            switch (type)
            {
                case CleanUpType.RemoveAllNewline:
                    txtChanged.Text = Regex.Replace(OriginalContent, @"( |\t|\r?\n)\1+", "$1", RegexOptions.Compiled);
                    break;
                case CleanUpType.RemoveExtraLines:
                    txtChanged.Text = Regex.Replace(OriginalContent, @"( |\t|\r?\n)\1+", Environment.NewLine + "$1", RegexOptions.Compiled);
                    break;
                case CleanUpType.InsertAfterComment:
                    string tmp = Regex.Replace(OriginalContent, @"( |\t|\r?\n)\1+", "$1", RegexOptions.Compiled);
                    txtChanged.Text = Regex.Replace(tmp, @"^\#", Environment.NewLine + "$0", RegexOptions.Multiline | RegexOptions.Compiled);
                    break;
                default:
                    break;
            }
        }

        private void ChangeCleanupMode(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio == null)
                return;

            if (radio.Checked)
            {
                CleanUp((CleanUpType)Enum.Parse(typeof(CleanUpType), radio.Tag.ToString(), true));
            }
        }

        #endregion
    }
}
