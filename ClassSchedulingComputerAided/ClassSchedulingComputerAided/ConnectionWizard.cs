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
using System.Diagnostics;//for restarting the app
using System.Net.Sockets;//addressfamily
using System.Net;//dns

namespace ClassSchedulingComputerAided
{
    public partial class frmConnectionWizard : MetroFramework.Forms.MetroForm
    {
        public frmConnectionWizard()
        {
            InitializeComponent();
        }

        CreateDatabase cd = new CreateDatabase();// call 'CreateDatabase' class

        private void ConnectionWizard_Load(object sender, EventArgs e)
        {
            txtHost.Text = Settings.Default["Server"].ToString();
            txtPort.Text = Settings.Default["Port"].ToString();
            txtDatabase.Text = Settings.Default["DatabaseName"].ToString();
            txtUsername.Text = Settings.Default["UsernameDB"].ToString();
            txtPassword.Text = Settings.Default["PasswordDB"].ToString();

            lblIPv4.Text = GetLocalIPAddress();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {

            if (txtPort.Text != "")
            {
                if (txtHost.Text != "")
                {
                    if (txtDatabase.Text != "")
                    {
                        if (txtUsername.Text != "")
                        {
                            DialogResult dr = MessageBox.Show("Do you want to save connection configuration?", "Save connection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == dr)
                            {
                                Settings.Default["Server"] = txtHost.Text;
                                Settings.Default["DatabaseName"] = txtDatabase.Text;
                                Settings.Default["UsernameDB"] = txtUsername.Text;
                                Settings.Default["PasswordDB"] = txtPassword.Text;
                                Settings.Default["Port"] = txtPort.Text;
                                Settings.Default.Save();

                                this.Hide();
                                RestartsApp();
                            }
                        }
                        else
                            MessageBox.Show("Please specified the username.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Please specified the database.", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please specified the host.", "Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please specified the port.", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sqlConnection = "server=" + txtHost.Text
            + "; username=" + txtUsername.Text
            + "; password=" + txtPassword.Text
            + "; database=" + txtDatabase.Text
            + "; port=" + txtPort.Text + ";";
            if (txtUsername.Text != "")
            {
                if (txtDatabase.Text != "")
                {
                    MySqlConnection con = new MySqlConnection(sqlConnection);
                    try
                    {
                        con.Open();
                        MessageBox.Show("Connection successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        string str = ex.Message;
                        MessageBox.Show("Connection Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtDatabase.SelectionStart = 0;
                        txtDatabase.SelectionLength = txtDatabase.TextLength;
                        txtDatabase.Focus();
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Database name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDatabase.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if (txtDatabase.Text != "")
                {
                    string server = txtHost.Text;
                    string port = txtPort.Text;
                    string dbName = txtDatabase.Text;
                    string usrDb = txtUsername.Text;
                    string pwdDb = txtPassword.Text;

                    string sqlConnection = "server=" + server
                     + "; username=" + usrDb
                     + "; password=" + pwdDb
                     + "; port=" + port + ";";

                    if (testCon() == true)//to check if the connection is connected
                    {
                        if (DBExists(sqlConnection, dbName) == true)//to check if the database is already exist
                        {
                            MessageBox.Show("The " + txtDatabase.Text + " [DATABASE] already exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDatabase.SelectionStart = 0;
                            txtDatabase.SelectionLength = txtDatabase.TextLength;
                            txtDatabase.Focus();
                        }
                        else
                        {
                            //creation of database 
                            cd.initCreateDatabase(txtHost.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text, txtPort.Text);
                            MessageBox.Show(txtDatabase.Text + " [DATABASE] created successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            btnSAVE_Click(sender, e);
                            //to save the year
                            Settings.Default["Year"] = DateTime.Now.Year.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection Failed!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter database name!", "Create Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDatabase.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            if (txtHost.Text != "")
            {
                btnTest.Enabled = true;
                btnCreateDatabase.Enabled = true;
            }
            else
            {
                btnTest.Enabled = false;
                btnCreateDatabase.Enabled = false;
            }
        }

        //to restart the app()
        static void RestartsApp()
        {
            string server = Settings.Default["Server"].ToString();
            string port = Settings.Default["Port"].ToString();
            string dbName = Settings.Default["DatabaseName"].ToString();
            string usrDb = Settings.Default["UsernameDB"].ToString();
            string pwdDb = Settings.Default["PasswordDB"].ToString();

            if (Settings.Default["Server"].ToString() != "" &&
               Settings.Default["Port"].ToString() != "" &&
               Settings.Default["DatabaseName"].ToString() != "" &&
               Settings.Default["UsernameDB"].ToString() != "")
            {
                string sqlConnection = "server=" + server
                     + "; username=" + usrDb
                     + "; password=" + pwdDb
                     + "; port=" + port + ";";
                string sqlConnectionWithDatabase = "server=" + server
                     + "; username=" + usrDb
                     + "; password=" + pwdDb
                     + "; database=" + dbName
                     + "; port=" + port + ";";

                if (DBExists(sqlConnection, dbName) == true)
                {
                    if (isDB_Empty(sqlConnectionWithDatabase, dbName) == true)
                    {
                        frmAdminAccount aa = new frmAdminAccount();
                        aa.Show();
                    }
                    else {
                        frmLogin login = new frmLogin();
                        login.Show();
                    }
                }
                else
                {
                    frmConnectionWizard connection = new frmConnectionWizard();
                    connection.Show();
                }

            }
            else
            {
                frmConnectionWizard connection = new frmConnectionWizard();
                connection.Show();
            }
        }

        public static bool isDB_Empty(string conn, string dbName)
        {
            bool isEmpty = false;
            try
            {
                using (MySqlConnection dbconn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tbl_users;", dbconn))
                    {
                        isEmpty = false;
                        dbconn.Open();
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr["COUNT(*)"].ToString()) == 0)
                                isEmpty = true;
                        }
                        dbconn.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {

            }
            return isEmpty;
        }

        public static bool DBExists(string conn, string dbName)
        {
            bool isExists = false;
            try
            {
                using (MySqlConnection dbconn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM information_schema.schemata WHERE SCHEMA_NAME= @dbName;", dbconn))
                    {
                        isExists = false;
                        cmd.Parameters.AddWithValue("@dbName", dbName);
                        dbconn.Open();
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr["COUNT(*)"].ToString()) > 0)
                                isExists = true;
                        }
                        dbconn.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isExists;
        }

        public bool testCon()//to test if the connection is connected
        {
            string server = txtHost.Text;
            string port = txtPort.Text;
            string dbName = txtDatabase.Text;
            string usrDb = txtUsername.Text;
            string pwdDb = txtPassword.Text;

            bool isExistDB = false;

            string sqlConnection = "server=" + server
             + "; username=" + usrDb
             + "; password=" + pwdDb
             + "; port=" + port + ";";

            MySqlConnection con = new MySqlConnection(sqlConnection);
            try
            {
                con.Open();
                isExistDB = true;
            }
            catch (MySqlException ex)
            {
                string str = ex.Message;
                isExistDB = false;
            }
            finally
            {
                con.Close();
            }

            return isExistDB;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text == "CANCEL")
            {
                DialogResult result = MessageBox.Show("Connection is not set. Do you want to cancel the configuration?", "Connection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DialogResult res = MessageBox.Show("This will terminate the program, continue...", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.OK)
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
            else
            {
                frmLogin l = new frmLogin();
                l.Show();
                this.Hide();
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            string txt = "";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDatabase.Text, "^[a-zA-Z ]^"))
            {
                int result;
                foreach (char a in txtDatabase.Text)
                {
                    if (int.TryParse(a.ToString(), out result) == false)
                        txt += a;
                }
            }
            txtDatabase.Text = txt;
            txtDatabase.SelectionStart = txtDatabase.Text.Length;
            txtDatabase.SelectionLength = 0;
        }

    }
}
