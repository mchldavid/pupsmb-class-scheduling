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
                md.CreateBackup(txtBackupPath.Text);
                MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                md.RestoreBackup(txtRestorePath.Text);
                MessageBox.Show("Restore taken successfully", "Restore successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("The system will now close.", "Exiting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("please enter the restore file location");
            }
        }
    }
}
