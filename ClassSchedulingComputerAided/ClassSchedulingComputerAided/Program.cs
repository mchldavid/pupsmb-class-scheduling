using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassSchedulingComputerAided.Properties;

namespace ClassSchedulingComputerAided
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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

                if (DBExists(sqlConnection, dbName) == true)//dito
                {
                    if (isDB_Empty(sqlConnectionWithDatabase, dbName) == true)
                    {
                        Application.Run(new frmAdminAccount());
                    }
                    else
                    {
                        Application.Run(new frmLogin());
                        //Application.Run(new frmSummary());
                    }
                }
                else
                {
                    Application.Run(new frmConnectionWizard());
                }

            }
            else
            {
                Application.Run(new frmConnectionWizard());
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
    }
}
