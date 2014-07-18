using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsHostsEditorLib;

namespace WindowsHostsEditor
{
    public partial class frmHostEntry : Form
    {
        public HostEntry GivenHostEntry { get; private set; }

        public HostEntry NewHostEntry { get; private set; }

        public frmHostEntry(HostEntry entry)
        {
            InitializeComponent();

            GivenHostEntry = entry;
            NewHostEntry = null;

            if (GivenHostEntry != null)
            {
                if (GivenHostEntry.HostIP != null)
                    txtHostIP.Text = GivenHostEntry.HostIP;

                if (GivenHostEntry.Aliases != null && GivenHostEntry.Aliases.Count > 0)
                    lstAliases.Items.AddRange(GivenHostEntry.Aliases.ToArray<string>());

                if (GivenHostEntry.Comment != null)
                    txtComment.Text = GivenHostEntry.Comment;
            }
        }

        #region Form Events
        private void lstAliases_SelectedIndexChanged(object sender, EventArgs e)
        {
            butRemoveAlias.Enabled = lstAliases.SelectedIndex >= 0;

        }

        private void butAddAlias_Click(object sender, EventArgs e)
        {
            string aliasToAdd = txtAddAlias.Text.Trim();
            string errorMessage = null;

            if (String.IsNullOrWhiteSpace(aliasToAdd))
            {
                errorMessage = "The alias must be filled in order to add it to the list";
            }

            if (errorMessage == null && aliasToAdd.Intersect(Hosts.ALIASES_SEPARATORS).Count() > 0)
            {
                errorMessage = "The alias cannot contain space, tabs or end-of-line chars";
            }

            if (errorMessage == null && lstAliases.Items.Contains(aliasToAdd))
            {
                errorMessage = "The alias you are trying to add is already in the list";
            }

            if (errorMessage == null)
            {
                lstAliases.Items.Add(aliasToAdd);
                txtAddAlias.Text = "";
            }
            else
            {
                MessageBox.Show(errorMessage, "Error adding alias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butRemoveAlias_Click(object sender, EventArgs e)
        {
            if (lstAliases.SelectedIndex < 0)
                return;

            lstAliases.Items.RemoveAt(lstAliases.SelectedIndex);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            string errorMessage = null;

            string hostIp = txtHostIP.Text.Trim();

            if (!Hosts.IsValidIPAddress(hostIp))
            {
                errorMessage = "The IP Address you entered is not valid";
            }

            if (errorMessage == null && lstAliases.Items.Count == 0)
            {
                errorMessage = "You must provide at least one alias";
            }

            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error adding alias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> aliases = new List<string>(lstAliases.Items.Count);

            foreach (var obj in lstAliases.Items)
            {
                aliases.Add(obj.ToString());
            }

            this.NewHostEntry = new HostEntry(txtHostIP.Text, aliases);
            this.NewHostEntry.Comment = txtComment.Text;
            if (this.GivenHostEntry != null)
                this.NewHostEntry.LineNumber = this.GivenHostEntry.LineNumber;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void lstAliases_DoubleClick(object sender, EventArgs e)
        {
            if (lstAliases.SelectedIndex < 0)
                return;

            txtAddAlias.Text = lstAliases.SelectedItem.ToString();
        }

        private void txtAddAlias_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAddAlias.Text != "")
            {
                butAddAlias_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        #endregion
    }
}
