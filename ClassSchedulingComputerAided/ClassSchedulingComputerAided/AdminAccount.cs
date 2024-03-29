﻿using System;
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
            cboQuestion1.SelectedIndex = 0;
            cboQuestion2.SelectedIndex = 0;
            cboQuestion3.SelectedIndex = 0;
            txtFirstName.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != ""
                && txtLastName.Text != ""
                && txtAddress.Text != ""
                && txtEmailAddress.Text != ""
                && txtMobileNumber.Text != "(+63)   -    -"
                && txtUsername.Text != ""
                && txtPassword.Text != ""
                && txtAnswer1.Text != ""
                && txtAnswer2.Text != ""
                && txtAnswer3.Text != "")
            {
                EmailValidation email = new EmailValidation();
                if (email.IsValidEmail(txtEmailAddress.Text) == true)
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        if (cboQuestion1.SelectedIndex != 0 && cboQuestion2.SelectedIndex != 0 && cboQuestion3.SelectedIndex != 0)
                        {
                            DialogResult result = MessageBox.Show("Do you want to save?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                md.RegisterAdmin(txtUsername.Text, ms.encryptPassword(txtPassword.Text), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, txtAddress.Text, cboGender.Text, txtEmailAddress.Text, cleanMobileNumber(txtMobileNumber.Text));

                                //get set security questions
                                string[] answer = new string[3];
                                string[] question = new string[3];

                                answer[0] = txtAnswer1.Text;
                                answer[1] = txtAnswer2.Text;
                                answer[2] = txtAnswer3.Text;

                                question[0] = "Who is your favorite actor, musician, or artist?";
                                question[1] = "What is your mother’s maiden name?";
                                question[2] = "What is your favorite color?";

                                md.RegisterAdminSecurityQuestion(txtUsername.Text, ms.encryptPassword(txtPassword.Text), answer, question);

                                MessageBox.Show("Admin account created succesdul", "Success!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                this.Hide();
                                RestartsApp();//to restart the app
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select questions.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The specified password do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConfirmPassword.Text = "";
                        txtConfirmPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The specified email is invalid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.Focus();
                }
            }
            else
            {
                MessageBox.Show("All Fields are required", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtAnswer5.Text == "") { txtAnswer5.Focus(); }
                if (txtAnswer4.Text == "") { txtAnswer4.Focus(); }
                if (txtAnswer3.Text == "") { txtAnswer3.Focus(); }
                if (txtAnswer2.Text == "") { txtAnswer2.Focus(); }
                if (txtAnswer1.Text == "") { txtAnswer1.Focus(); }
                if (txtConfirmPassword.Text == "") { txtConfirmPassword.Focus(); }
                if (txtPassword.Text == "") { txtPassword.Focus(); }
                if (txtUsername.Text == "") { txtUsername.Focus(); }
                if (txtMobileNumber.Text == "") { txtMobileNumber.Focus(); }
                if (txtEmailAddress.Text == "") { txtEmailAddress.Focus(); }
                if (txtAddress.Text == "") { txtAddress.Focus(); }
                if (txtLastName.Text == "") { txtLastName.Focus(); }
                if (txtFirstName.Text == "") { txtFirstName.Focus(); }
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
            if (txtFirstName.Text != ""
                && txtLastName.Text != ""
                && txtAddress.Text != ""
                && txtEmailAddress.Text != ""
                && txtMobileNumber.Text != "(+63)   -    -")
            {
                EmailValidation email = new EmailValidation();
                if (email.IsValidEmail(txtEmailAddress.Text) == true)
                {
                    pnlAdmin.Location = new Point(-437, 35);
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("The specified email is invalid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.Focus();
                }
            }
            else
            {
                if (txtMobileNumber.Text == "") { txtMobileNumber.Focus(); }
                if (txtEmailAddress.Text == "") { txtEmailAddress.Focus(); }
                if (txtAddress.Text == "") { txtAddress.Focus(); }
                if (txtLastName.Text == "") { txtLastName.Focus(); }
                if (txtFirstName.Text == "") { txtFirstName.Focus(); }
            }
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

        //to fix the number
        public string cleanMobileNumber(string s)
        {
            StringBuilder sb = new StringBuilder(s);

            sb.Replace("(+63)", "0");
            sb.Replace("-", "");

            return sb.ToString();
        }

        private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnNext_Click(sender, e);
            }
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSave_Click(sender, e);
        }
    }
}
