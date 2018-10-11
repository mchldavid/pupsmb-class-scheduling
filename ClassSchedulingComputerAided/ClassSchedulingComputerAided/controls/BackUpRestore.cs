using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class BackUpRestore : UserControl
    {
        public BackUpRestore()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = fbd.SelectedPath;
            }
        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == string.Empty)
            {
                MessageBox.Show("please enter the backup file location");
            }
            else
            {
                md.updateLogginStatus(usersData.a_id, "0");//update the user to 0
                md.CreateBackup(txtBackupPath.Text);
                MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                md.updateLogginStatus(usersData.a_id, "1");//update the user to 1 after the buckup
                txtBackupPath.Text = "";

            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opfd = new OpenFileDialog() { Filter = "Sql Database|*.sql;", ValidateNames = true })
            {
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.Text = opfd.FileName;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtRestorePath.Text != string.Empty)
            {
                DialogResult dr = MessageBox.Show("This will delete and replace all of your data. Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == dr)
                {
                    pnlConfirmation.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("please enter the restore file location");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (md.confimationPassword(usersData.a_id, ms.encryptPassword(txtPassword.Text)) == true)
            {
                md.RestoreBackup(txtRestorePath.Text);
                MessageBox.Show("Restore taken successfully", "Restore successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("The system will terminate. Please re-open the program.", "Exiting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlConfirmation.Visible = false;
            txtPassword.Text = "";
        }
    }
}
