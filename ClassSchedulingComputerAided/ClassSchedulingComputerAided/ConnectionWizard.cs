using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassSchedulingComputerAided.Properties;
using MySql.Data.MySqlClient;

namespace ClassSchedulingComputerAided
{
    public partial class frmConnectionWizard : MetroFramework.Forms.MetroForm
    {
        public frmConnectionWizard()
        {
            InitializeComponent();
        }

        private void ConnectionWizard_Load(object sender, EventArgs e)
        {
            txtHost.Text = Settings.Default["Server"].ToString();
            txtPort.Text = Settings.Default["Port"].ToString();
            txtDatabase.Text = Settings.Default["DatabaseName"].ToString();
            txtUsername.Text = Settings.Default["UsernameDB"].ToString();
            txtPassword.Text = Settings.Default["PasswordDB"].ToString();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save connection configuration?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {
                Settings.Default["Server"] = txtHost.Text;
                Settings.Default["DatabaseName"] = txtDatabase.Text;
                Settings.Default["UsernameDB"] = txtUsername.Text;
                Settings.Default["PasswordDB"] = txtPassword.Text;
                Settings.Default["Port"] = txtPort.Text;
                Settings.Default.Save();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sqlConnection = "server=" + txtHost.Text
            + "; username=" + txtUsername.Text
            + "; password=" + txtPassword.Text
            + "; database=" + txtDatabase.Text
            + "; port=" + txtPort.Text + ";";

            MySqlConnection con = new MySqlConnection(sqlConnection);
            try
            {
                con.Open();
                MessageBox.Show("Connection successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
