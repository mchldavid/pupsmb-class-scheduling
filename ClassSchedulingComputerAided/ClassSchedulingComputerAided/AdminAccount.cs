using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassSchedulingComputerAided.Properties;

namespace ClassSchedulingComputerAided
{
    public partial class frmAdminAccount : MetroFramework.Forms.MetroForm
    {
        public frmAdminAccount()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        MySecurity ms = new MySecurity();

        private void AdminAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                md.RegisterAdmin(txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, cboGender.Text, txtEmailAddress.Text, txtMobileNumber.Text);

                //get set security questions
                string[] answer = new string[5];
                string[] question = new string[5];

                answer[0] = txtAnswer1.Text;
                answer[1] = txtAnswer2.Text;
                answer[2] = txtAnswer3.Text;
                answer[3] = txtAnswer4.Text;
                answer[4] = txtAnswer5.Text;

                question[0] = "Who is your favorite actor, musician, or artist?";
                question[1] = "What is your mother’s maiden name?";
                question[2] = "What is your favorite color?";
                question[3] = "In what city were you born?";
                question[4] = "What is the name of your favorite pet?";

                md.RegisterAdminSecurityQuestion(txtUsername.Text, ms.encryptPassword(txtPassword.Text), answer, question);
                
                MessageBox.Show("Admin account created succesdul", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                this.Hide();
                RestartsApp();//to restart the app
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
                    else
                    {
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
                MessageBox.Show("Connection Failed!", "DBexists");
            }
            return isExists;
        }

        public bool testCon()//to test if the connection is connected
        {
            string server = Settings.Default["Server"].ToString();
            string port = Settings.Default["Port"].ToString();
            string dbName = Settings.Default["DatabaseName"].ToString();
            string usrDb = Settings.Default["UsernameDB"].ToString();
            string pwdDb = Settings.Default["PasswordDB"].ToString();

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlAdmin.Location = new Point(-437, 35);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlAdmin.Location = new Point(0, 35);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
