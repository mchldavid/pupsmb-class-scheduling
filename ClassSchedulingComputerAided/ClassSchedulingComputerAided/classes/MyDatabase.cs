﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using ClassSchedulingComputerAided.Properties;
using System.IO;
using System.Net.Sockets;

namespace ClassSchedulingComputerAided
{
    class MyDatabase
    {
        //connection to my database
        MySqlConnection con = new MySqlConnection("server=" + Settings.Default["Server"].ToString()
            + "; username=" + Settings.Default["UsernameDB"].ToString()
            + "; password=" + Settings.Default["PasswordDB"].ToString()
            + "; database=" + Settings.Default["DatabaseName"].ToString()
            + "; port=" + Settings.Default["Port"].ToString() + ";");


        //=============BACKUP AND RESTORE=================
        public bool confimationPassword(string id, string password)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users WHERE users_id = @id AND password = @p;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@p", password);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "confimationPassword");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public void CreateBackup(string filepath)
        {
            string constr = "server=" + Settings.Default["Server"].ToString() + ";";
            constr += "username=" + Settings.Default["UsernameDB"].ToString() + ";";
            constr += "password=" + Settings.Default["PasswordDB"].ToString() + ";";
            constr += "database=" + Settings.Default["DatabaseName"].ToString() + ";";
            constr += "charset=utf8; convertzerodatetime=true;";
            try
            {
                string fileName = string.Format("pupsmb_backupDatabase_{0}.sql", DateTime.Now.ToString("MM'-'dd'-'yyyy'-'hh'-'sstt"));
                string backupFile = Path.Combine(filepath,fileName);
                //string file = @"C:\Users\Michael David\Documents\PUP\pam\backup.sql";
                using(MySqlConnection connection = new MySqlConnection(constr))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {

                        cmd.Connection = connection;
                        connection.Open();
                        mb.ExportToFile(backupFile);
                        connection.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CreateBackup");
            }
            finally
            {
            }
        }

        public void RestoreBackup(string filepath)
        {
            string constr = "server=" + Settings.Default["Server"].ToString() + ";";
            constr += "username=" + Settings.Default["UsernameDB"].ToString() + ";";
            constr += "password=" + Settings.Default["PasswordDB"].ToString() + ";";
            constr += "database=" + Settings.Default["DatabaseName"].ToString() + ";";
            constr += "charset=utf8; convertzerodatetime=true;";
            try
            {
                //string file = @"C:\Users\Michael David\Documents\PUP\pam\backup.sql";
                using (MySqlConnection connection = new MySqlConnection(constr))
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {

                        cmd.Connection = connection;
                        connection.Open();
                        mb.ImportFromFile(filepath);
                        connection.Close();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CreateBackup");
            }
            finally
            {
            }
        }

        //check the database connection
        public void ConnectSql()
        {
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection");
            }
            finally
            {
                con.Close();
            }
        }
        //=========================LOGIN=========================
        public bool isLogin(string username, string password)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users WHERE username = @u AND password = @p;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["loginStatus"].ToString() == "1")
                        result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "isLogin");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public void updateLogginStatus(string id, string status)
        {
            try
            {
                con.Open();
                string sql = "UPDATE tbl_users SET loginStatus = @s WHERE users_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@s", status);
                com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "updateLogginStatus");
            }
            finally
            {
                con.Close();
            }
        }
        //test the user logging in
        public string[] LoginTest(string username, string password)
        {
            string[] usersInformation = new string[10];
            try
            {
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE username=@u AND password=@p;";
                MySqlCommand com = new MySqlCommand(SqlSelectUsers, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usersInformation[3] = dr["firstName"].ToString() + " " + dr["middleName"].ToString() + " " + dr["lastName"].ToString();
                    usersInformation[2] = dr["userLevel"].ToString();
                    usersInformation[1] = dr["users_id"].ToString();
                    usersInformation[0] = "PASSED";

                    AuditTrailData.username = dr["username"].ToString();

                    usersData.p_id = dr["users_id"].ToString();
                    usersData.p_usr = dr["username"].ToString();
                    usersData.p_pwd = dr["password"].ToString();
                    usersData.p_fName = dr["firstName"].ToString();
                    usersData.p_mName = dr["middleName"].ToString();
                    usersData.p_lName = dr["lastName"].ToString();
                    usersData.p_address = dr["address"].ToString();
                    usersData.p_gender = dr["gender"].ToString();
                    usersData.p_cDepartment = dr["courseDepartment"].ToString();
                    usersData.p_tStatus= dr["teachingStatus"].ToString();
                    usersData.p_uLevel = dr["userLevel"].ToString();
                    usersData.p_uAllowed = dr["unitsAllowed"].ToString();
                }
                else
                {
                    usersInformation[0] = "FAILED";
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message,"Login Test");
            }
            finally
            {
                con.Close();
            }
            return usersInformation;
        }

        public void RegisterUser(string username, string password, string firstname, string middlename, string lastname, string address, string gender, string teachingStatus, string courseDepartment, string emailAddress, string mobileNumber)
        {
            try
            {
                con.Open();
                string sqlRegisterUser = "INSERT INTO tbl_users(username, password, firstName, middleName, lastName, address, gender, teachingStatus, courseDepartment, emailAddress, mobileNumber, status, userLevel, unitsAllowed) VALUES(@u, @p, @fN, @mN, @lN, @a, @g, @tS, @cD, @eA, @moN, 'active', 'professor', @uA);";
                MySqlCommand com = new MySqlCommand(sqlRegisterUser, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.Parameters.AddWithValue("@fN", firstname);
                com.Parameters.AddWithValue("@mN", middlename);
                com.Parameters.AddWithValue("@lN", lastname);
                com.Parameters.AddWithValue("@a", address);
                com.Parameters.AddWithValue("@g", gender);
                com.Parameters.AddWithValue("@tS", teachingStatus);
                com.Parameters.AddWithValue("@cD", courseDepartment);
                com.Parameters.AddWithValue("@eA", emailAddress);
                com.Parameters.AddWithValue("@moN", mobileNumber);
                if (teachingStatus == "Fulltimer")
                    com.Parameters.AddWithValue("@uA", 42);
                if (teachingStatus == "Parttimer")
                    com.Parameters.AddWithValue("@uA", 12);
                if (teachingStatus == "Retiree")
                    com.Parameters.AddWithValue("@uA", 6);
                com.ExecuteNonQuery();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "RegisterUser");
            }
            finally{
            con.Close();
            }
        }

        //inserting of security question answer to the user in the registration
        public void RegisterSecurityQuestion(string username, string password, string[] answer, string[] question)
        {
            try
            {
                con.Open();
                string id = "";
                string sqlSecurityQuestion = "SELECT * FROM tbl_users WHERE username = @u AND password = @p;";
                MySqlCommand com = new MySqlCommand(sqlSecurityQuestion, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["users_id"].ToString();
                }
                con.Close();
                con.Open();
                for (int x = 0; x < 3; x++)
                {
                    string sqlInsertSQ = "INSERT INTO tbl_securityquestions(users_id, answer, question) VALUES('" + id + "', @a, @q)";
                    MySqlCommand com1 = new MySqlCommand(sqlInsertSQ, con);
                    com1.Parameters.AddWithValue("@a", answer[x]);
                    com1.Parameters.AddWithValue("@q", question[x]);
                    com1.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Security Question");
            }
            finally
            {
                con.Close();
            }

        }

        public string[] UsersInformation(string id)
        {
            string[] usersInfo = new string[12];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT * FROM tbl_users WHERE users_id=@id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usersInfo[0] = dr["username"].ToString();
                    usersInfo[1] = dr["password"].ToString();
                    usersInfo[2] = dr["firstName"].ToString();
                    usersInfo[3] = dr["middleName"].ToString();
                    usersInfo[4] = dr["lastName"].ToString();
                    usersInfo[5] = dr["emailAddress"].ToString();
                    usersInfo[6] = dr["address"].ToString();
                    usersInfo[7] = dr["mobileNumber"].ToString();
                    usersInfo[8] = dr["gender"].ToString();
                    usersInfo[9] = dr["courseDepartment"].ToString();
                    usersInfo[10] = dr["teachingStatus"].ToString();
                    usersInfo[11] = dr["status"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            return usersInfo;
        }

        public void UpdateUsersAccount_1(string id, string username, string password, string firstname, string middlename, string lastname, string address, string gender, string teachingStatus, string courseDepartment, string emailAddress, string mobileNumber)
        {
            try
            {
                con.Open();
                string sqlUpdateUserInformation = "UPDATE tbl_users SET username=@u, password=@p, firstName=@fN, middleName=@mN, lastName=@lN, address=@a, gender=@g, teachingStatus=@tS, courseDepartment=@cD, emailAddress=@eA, mobileNumber=@moN, unitsAllowed=@uA WHERE users_id=@id;";
                MySqlCommand com = new MySqlCommand(sqlUpdateUserInformation, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.Parameters.AddWithValue("@fN", firstname);
                com.Parameters.AddWithValue("@mN", middlename);
                com.Parameters.AddWithValue("@lN", lastname);
                com.Parameters.AddWithValue("@a", address);
                com.Parameters.AddWithValue("@g", gender);
                com.Parameters.AddWithValue("@tS", teachingStatus);
                com.Parameters.AddWithValue("@cD", courseDepartment);
                com.Parameters.AddWithValue("@eA", emailAddress);
                com.Parameters.AddWithValue("@moN", mobileNumber);
                if (teachingStatus == "Fulltimer")
                    com.Parameters.AddWithValue("@uA", 42);
                if (teachingStatus == "Parttimer")
                    com.Parameters.AddWithValue("@uA", 12);
                if (teachingStatus == "Retiree")
                    com.Parameters.AddWithValue("@uA", 6);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE users_id = @id;";
                using (MySqlCommand cmd = new MySqlCommand(SqlSelectUsers, con))
                {
                    cmd.Parameters.AddWithValue("@id", usersData.p_id);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        usersData.p_usr = dr["username"].ToString();
                        usersData.p_pwd = dr["password"].ToString();
                        usersData.p_fName = dr["firstName"].ToString();
                        usersData.p_mName = dr["middleName"].ToString();
                        usersData.p_lName = dr["lastName"].ToString();
                        usersData.p_address = dr["address"].ToString();
                        usersData.p_gender = dr["gender"].ToString();
                        usersData.p_cDepartment = dr["courseDepartment"].ToString();
                        usersData.p_tStatus = dr["teachingStatus"].ToString();
                        usersData.p_uLevel = dr["userLevel"].ToString();
                        usersData.p_uAllowed = dr["unitsAllowed"].ToString();
                    }
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "UpdateUsersAccount_1");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateUsersAccount(string id, string username, string password, string firstname, string middlename, string lastname, string address, string gender, string teachingStatus, string courseDepartment, string emailAddress, string mobileNumber, string status)
        {
            try
            {
                con.Open();
                string sqlUpdateUserInformation = "UPDATE tbl_users SET username=@u, password=@p, firstName=@fN, middleName=@mN, lastName=@lN, address=@a, gender=@g, teachingStatus=@tS, courseDepartment=@cD, emailAddress=@eA, mobileNumber=@moN, unitsAllowed=@uA, status=@s WHERE users_id=@id;";
                MySqlCommand com = new MySqlCommand(sqlUpdateUserInformation, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.Parameters.AddWithValue("@fN", firstname);
                com.Parameters.AddWithValue("@mN", middlename);
                com.Parameters.AddWithValue("@lN", lastname);
                com.Parameters.AddWithValue("@a", address);
                com.Parameters.AddWithValue("@g", gender);
                com.Parameters.AddWithValue("@tS", teachingStatus);
                com.Parameters.AddWithValue("@cD", courseDepartment);
                com.Parameters.AddWithValue("@eA", emailAddress);
                com.Parameters.AddWithValue("@moN", mobileNumber);
                com.Parameters.AddWithValue("@s", status);
                if (teachingStatus == "Fulltimer")
                    com.Parameters.AddWithValue("@uA", 42);
                if (teachingStatus == "Parttimer")
                    com.Parameters.AddWithValue("@uA", 12);
                if (teachingStatus == "Retiree")
                    com.Parameters.AddWithValue("@uA", 6);
                com.ExecuteNonQuery();
                con.Close();
                
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE users_id = @id;";
                using (MySqlCommand cmd = new MySqlCommand(SqlSelectUsers, con))
                {
                    cmd.Parameters.AddWithValue("@id", usersData.p_id);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        usersData.p_usr = dr["username"].ToString();
                        usersData.p_pwd = dr["password"].ToString();
                        usersData.p_fName = dr["firstName"].ToString();
                        usersData.p_mName = dr["middleName"].ToString();
                        usersData.p_lName = dr["lastName"].ToString();
                        usersData.p_address = dr["address"].ToString();
                        usersData.p_gender = dr["gender"].ToString();
                        usersData.p_cDepartment = dr["courseDepartment"].ToString();
                        usersData.p_tStatus = dr["teachingStatus"].ToString();
                        usersData.p_uLevel = dr["userLevel"].ToString();
                        usersData.p_uAllowed = dr["unitsAllowed"].ToString();
                    }
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string CreateCurriculum(string title, string publishedBy, string date, string year)
        {
            string id = "";
            try
            {
                //to update the curriculum into inUsed=NO
                con.Open();
                string sqlUpdateInUsed = "UPDATE tbl_curriculums SET inUsed = 'NO';";
                MySqlCommand com2 = new MySqlCommand(sqlUpdateInUsed, con);
                com2.ExecuteNonQuery();
                con.Close();
                //to create a curriculum
                con.Open();
                string sql = "INSERT INTO tbl_curriculums(programName, createdBy, createdAt, status, inUsed, curriculumYear) VALUES(@t, @p, @d, 'active', 'YES', @cY)";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@t", title);
                com.Parameters.AddWithValue("@p", publishedBy);
                com.Parameters.AddWithValue("@d", date);
                com.Parameters.AddWithValue("@cY", year);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                string sqlGetCurriculumId = "SELECT * FROM tbl_curriculums WHERE programName = @t AND createdBy = @p;";
                MySqlCommand com1 = new MySqlCommand(sqlGetCurriculumId, con);
                com1.Parameters.AddWithValue("@t", title);
                com1.Parameters.AddWithValue("@p", publishedBy);
                com1.ExecuteNonQuery();

                MySqlDataReader dr = com1.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["curriculums_id"].ToString();
                }

            }catch(MySqlException ex){
                MessageBox.Show(ex.Message, "createCurriculum");
            }
                finally
            {
                con.Close();
            }
            return id;
        }
        
        //=====================Register============

        //=====================ListProfessors=============
        public DataGridView dgv_SearchListProfessors(string search, string by)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "";
                if (by == "Name")
                {
                    sql = "SELECT users_id AS 'ID', CONCAT(firstName,' ',middleName,' ', lastName) AS 'Name',address AS 'Address', gender AS 'Gender',teachingStatus AS 'Teaching Status', courseDepartment AS 'Department',emailAddress AS 'Email', mobileNumber AS 'Number', unitsAllowed AS 'Units Allowed', status AS 'Status' FROM tbl_users t WHERE userLevel = 'professor' AND CONCAT(firstName,' ',middleName,' ', lastName) LIKE '"+search+"%';";
                }
                else if (by == "Teaching Status")
                {
                    sql = "SELECT users_id AS 'ID', CONCAT(firstName,' ',middleName,' ', lastName) AS 'Name',address AS 'Address', gender AS 'Gender',teachingStatus AS 'Teaching Status', courseDepartment AS 'Department',emailAddress AS 'Email', mobileNumber AS 'Number', unitsAllowed AS 'Units Allowed', status AS 'Status' FROM tbl_users t WHERE userLevel = 'professor' AND teachingStatus LIKE '" + search + "%';";
                }
                else if (by == "Email")
                {
                    sql = "SELECT users_id AS 'ID', CONCAT(firstName,' ',middleName,' ', lastName) AS 'Name',address AS 'Address', gender AS 'Gender',teachingStatus AS 'Teaching Status', courseDepartment AS 'Department',emailAddress AS 'Email', mobileNumber AS 'Number', unitsAllowed AS 'Units Allowed', status AS 'Status' FROM tbl_users t WHERE userLevel = 'professor' AND emailAddress LIKE '" + search + "%';";
                }
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", curriculumData.c_id);
                com.Parameters.AddWithValue("@sem", curriculumData.c_semester);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public DataGridView dgv_showListOfProfessors()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT users_id AS 'ID', status AS 'Status', CONCAT(firstName,' ',middleName,' ', lastName) AS 'Name',address AS 'Address', gender AS 'Gender',teachingStatus AS 'Teaching Status', courseDepartment AS 'Department',emailAddress AS 'Email', mobileNumber AS 'Number', unitsAllowed AS 'Units Allowed' FROM tbl_users t WHERE userLevel = 'professor' ORDER BY status ASC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showlistOfProfessors");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public void L_DeleteProfessor(string l_id)
        {
            try
            {
                con.Open();
                string sqlSchedule = "DELETE FROM tbl_preferredschedules WHERE users_id = @id;";
                string sqlSubjects = "DELETE FROM tbl_preferredsubjects WHERE users_id = @id;";
                string sqlUsers = "DELETE FROM tbl_users WHERE users_id = @id;";
                string sqlSecurity = "DELETE FROM tbl_securityquestions WHERE users_id = @id;";
                using (MySqlCommand com = new MySqlCommand(sqlSchedule, con))
                {
                    com.Parameters.AddWithValue("@id", l_id);
                    com.ExecuteNonQuery();
                }
                using (MySqlCommand com = new MySqlCommand(sqlSubjects, con))
                {
                    com.Parameters.AddWithValue("@id", l_id);
                    com.ExecuteNonQuery();
                }
                using (MySqlCommand com = new MySqlCommand(sqlSecurity, con))
                {
                    com.Parameters.AddWithValue("@id", l_id);
                    com.ExecuteNonQuery();
                }
                using (MySqlCommand com3 = new MySqlCommand(sqlUsers, con))
                {
                    com3.Parameters.AddWithValue("@id", l_id);
                    com3.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "L_DeleteProfessor");
            }
            finally
            {
                con.Close();
            }
        }

        //=================SEt COURSES====================
        public void C_AddCourses(string c_control_id, string name, string acronym)
        {
            try
            {
                con.Open();
                string sqlCourse = "INSERT INTO tbl_course(curriculums_id, courseName, courseAcronym) VALUES(@id, @n, @a);";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@n", name);
                com1.Parameters.AddWithValue("@a", acronym);
                com1.Parameters.AddWithValue("@id", c_control_id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AddCourses");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showCourse()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT course_id AS 'ID', courseAcronym AS 'Acronym', courseName AS 'Course Name' FROM tbl_course WHERE curriculums_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", curriculumData.c_id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showCourse");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public void C_EditCourses(string id, string c_name, string c_ac)
        {
            try
            {
                con.Open();
                string sqlUpdateUserInformation = "UPDATE tbl_course SET courseName = @n, courseAcronym = @a WHERE course_id = @id ;";
                MySqlCommand com = new MySqlCommand(sqlUpdateUserInformation, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@n", c_name);
                com.Parameters.AddWithValue("@a", c_ac);
                com.ExecuteNonQuery();
                MessageBox.Show("Update Successfully!", "C_AddcoursesEdit");
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void C_DeleteCourse(string c_id)
        {
            try
            {
                con.Open();
                string sqlCourse = "DELETE FROM tbl_course WHERE course_id = @id";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@id", c_id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_DeleteCourse");
            }
            finally
            {
                con.Close();
            }
        }

        //================SET CURRICULUM===============
        public DataGridView dgv_SearchSubjects(string search, string by)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "";
                if (by == "Subject Code")
                {
                    sql = "SELECT subjects_id AS 'ID', course AS 'Program', yearLevel AS 'Year Level', subjectCode AS 'Code', subjectDescription AS 'Description', lectureHours AS 'Lecture Hours', laboratoryHours AS 'Lab Hours', units AS 'Units' FROM tbl_subjects t WHERE curriculums_id = @id AND semester = @sem AND subjectCode LIKE '" + search + "%' ORDER BY yearLevel ASC;";
                }
                else if (by == "Subject Description")
                {
                    sql = "SELECT subjects_id AS 'ID', course AS 'Course', yearLevel AS 'Year_Level', subjectCode AS 'Code', subjectDescription AS 'Description', lectureHours AS 'Lecture_Hours', laboratoryHours AS 'Lab_Hours', units AS 'Units' FROM tbl_subjects t WHERE curriculums_id = @id AND semester = @sem AND subjectDescription LIKE '" + search + "%' ORDER BY yearLevel ASC;";
                }
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", curriculumData.c_id);
                com.Parameters.AddWithValue("@sem", curriculumData.c_semester);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public void C_DeleteSubjectCurriculum(string id)
        {
            try
            {
                con.Open();
                string sqlPreferredSubjects = "DELETE FROM tbl_preferredsubjects WHERE curriculums_id = @id";
                MySqlCommand com = new MySqlCommand(sqlPreferredSubjects, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                string sqlSubjects = "DELETE FROM tbl_subjects WHERE curriculums_id = @id";
                MySqlCommand com1 = new MySqlCommand(sqlSubjects, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_DeleteSubjectCurriculum");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showSubjectCurriculum()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT subjects_id AS 'ID', course AS 'Program', yearLevel AS 'Year Level', subjectCode AS 'Code', subjectDescription AS 'Description', lectureHours AS 'Lecture Hours', laboratoryHours AS 'Lab Hours', units AS 'Units' FROM tbl_subjects t WHERE curriculums_id = @id AND semester = @sem ORDER BY yearLevel ASC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", curriculumData.c_id);
                com.Parameters.AddWithValue("@sem", curriculumData.c_semester);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showSubjectCurriculum");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public string[] ListCourse(string c_control_id)//to store all courseAcronym in the combobox
        {
            int x = 0;
            string[] cbo = new string[30];
            for (x = 0; x < 30; x++)
                cbo[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT * FROM tbl_course a, tbl_curriculums b WHERE a.curriculums_id = @c_id AND b.curriculums_id = @c_id;";
                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.Parameters.AddWithValue("@c_id", c_control_id);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cbo[x] = dr["courseAcronym"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "List course");
            }
            finally
            {
                con.Close();
            }
            return cbo;
        }

        public void C_AddSubjects(string c_control_id, string co_id, string course, string subjectCode, string subjectDescription, string lectureHours, string laboratoryHours, string units, string yearLevel, string semester)
        {
            try
            {
                con.Open();
                string sqlCourse = "INSERT INTO tbl_subjects(curriculums_id, course_id, course, subjectCode, subjectDescription, lectureHours, laboratoryHours, units, yearLevel, semester) VALUES(@cu_id, @co_id,@c, @sC, @sD, @leH, @laH, @u, @yL, @sem);";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@cu_id", c_control_id);
                com1.Parameters.AddWithValue("@co_id", co_id);
                com1.Parameters.AddWithValue("@c", course);
                com1.Parameters.AddWithValue("@sC", subjectCode);
                com1.Parameters.AddWithValue("@sD", subjectDescription);
                com1.Parameters.AddWithValue("@leH", lectureHours);
                com1.Parameters.AddWithValue("@laH", laboratoryHours);
                com1.Parameters.AddWithValue("@u", units);
                com1.Parameters.AddWithValue("@yL", yearLevel);
                com1.Parameters.AddWithValue("@sem", semester);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AddSubjects");
            }
            finally
            {
                con.Close();
            }
        }

        public void C_DeleteProgramCourse(string id)
        {
            try
            {
                con.Open();
                string sqlCourse = "DELETE FROM tbl_subjects WHERE subjects_id = @id";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_DeleteCourse");
            }
            finally
            {
                con.Close();
            }
        }

        public void C_UpdateProgramCourse(string id, string subjectCode, string subjectDescription, string lec, string lab, string units, string yearLevel)
        {
            try
            {
                con.Open();
                string sql = "UPDATE tbl_subjects SET subjectCode=@sC, subjectDescription=@sD, lectureHours=@lec, laboratoryHours=@lab, units=@u, yearLevel=@yL WHERE subjects_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@sC", subjectCode);
                com.Parameters.AddWithValue("@sD", subjectDescription);
                com.Parameters.AddWithValue("@lec", lec);
                com.Parameters.AddWithValue("@lab", lab);
                com.Parameters.AddWithValue("@u", units);
                com.Parameters.AddWithValue("@yL", yearLevel);

                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_UpdateProgramCourse");
            }
            finally
            {
                con.Close();
            }
        }

        public string GetCourseID(string course, string c_control_id)
        {
            string id = "";
            try
            {
                con.Open();
                string sqlGetCourseId = "SELECT * FROM tbl_course a, tbl_curriculums b WHERE courseAcronym = @cA AND b.curriculums_id = @cu_id AND a.curriculums_id = @cu_id;";
                MySqlCommand com = new MySqlCommand(sqlGetCourseId, con);
                com.Parameters.AddWithValue("@cA", course);
                com.Parameters.AddWithValue("@cu_id", c_control_id);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["course_id"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "List course");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        //===============ROOMS======================

        public void R_AddRooms(string roomName, string roomCode, string roomSlots)
        {
            try
            {
                con.Open();
                string sqlAddRoom = "INSERT INTO tbl_room(roomName, roomCode, roomSlots, roomStatus) VALUES(@rN, @rC, @rS, 'ACTIVE');";
                MySqlCommand com = new MySqlCommand(sqlAddRoom, con);
                com.Parameters.AddWithValue("@rN", roomName);
                com.Parameters.AddWithValue("@rC", roomCode);
                com.Parameters.AddWithValue("@rS", roomSlots);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AddRooms");
            }
            finally
            {
                con.Close();
            }
        }

        public void R_DeleteRoom(string id)
        {
            try
            {
                con.Open();
                string sqlCourse = "DELETE FROM tbl_room WHERE room_id = @id";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "R_DeleteRoom");
            }
            finally
            {
                con.Close();
            }
        }

        public void R_UpdateRooms(string code, string status)
        {
            try
            {
                con.Open();
                string sqlAddRoom = "UPDATE tbl_room SET roomStatus = @s WHERE roomCode = @c;";
                MySqlCommand com = new MySqlCommand(sqlAddRoom, con);
                com.Parameters.AddWithValue("@s", status);
                com.Parameters.AddWithValue("@c", code);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "R_UpdateRooms");
            }
            finally
            {
                con.Close();
            }
        }

        public void R_SetUpdateRooms(string id, string name, string code, string slots)
        {
            try
            {
                con.Open();
                string sqlAddRoom = "UPDATE tbl_room SET roomName = @rN, roomCode = @rC, roomSlots = @rS WHERE room_id = @id;";
                MySqlCommand com = new MySqlCommand(sqlAddRoom, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@rN", name);
                com.Parameters.AddWithValue("@rC", code);
                com.Parameters.AddWithValue("@rS", slots);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "R_UpdateRooms");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showRooms()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT room_id AS 'ID', roomCode AS 'Code', roomName AS 'Name', roomSlots AS 'Slots', roomStatus AS 'Status' FROM tbl_room t;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showRooms");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        //to store all roomCode in the listBox
        public string[] R_ListRooms_Active()
        {
            int x = 0;
            string[] lstActive = new string[30];
            for (x = 0; x < 30; x++)
                lstActive[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListRoomCode= "SELECT * FROM tbl_room WHERE roomStatus = 'ACTIVE';";
                MySqlCommand com = new MySqlCommand(sqlListRoomCode, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstActive[x] = dr["roomCode"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "List course");
            }
            finally
            {
                con.Close();
            }
            return lstActive;
        }

        public string[] R_ListRooms_InActive()
        {
            int x = 0;
            string[] lstActive = new string[30];
            for (x = 0; x < 30; x++)
                lstActive[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListRoomCode = "SELECT * FROM tbl_room WHERE roomStatus = 'INACTIVE';";
                MySqlCommand com = new MySqlCommand(sqlListRoomCode, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lstActive[x] = dr["roomCode"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "List course");
            }
            finally
            {
                con.Close();
            }
            return lstActive;
        }

        //to set the control id of the curriculum to the admin Form
        public string GetCurriculumId()
        {
            string id = "";
            try
            {
                con.Open();
                string sqlGetCurriculumsId = "SELECT * FROM tbl_curriculums WHERE inUsed = 'YES'";
                MySqlCommand com = new MySqlCommand(sqlGetCurriculumsId, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["curriculums_id"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "GetCurriculumId");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        //=====================SECTIONS===================
        public DataGridView dgv_SearchSections(string search)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT section_id AS 'ID' , course AS 'Course', year AS 'Year', section AS 'Section' FROM tbl_sections t "
+ "WHERE course LIKE '"+search+"%' ORDER BY year asc;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@search", search);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public bool S_sectionExisting(string course, string year)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_sections WHERE course = @c AND year = @y;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@c", course);
                com.Parameters.AddWithValue("@y", year);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public void S_DeleteExistingSections(string course, string year)
        {
            try
            {
                con.Open();
                string sqlCourse = "DELETE FROM tbl_sections WHERE course = @c AND year = @y";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@c", course);
                com1.Parameters.AddWithValue("@y", year);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "S_DeleteSEcitons");
            }
            finally
            {
                con.Close();
            }
        }

        public string[] Sections_ListCourse()//to list all course available in the inUsed curriculum to the sectionForm
        {
            int x = 0;
            string[] cboCourse = new string[30];
            for (x = 0; x < 30; x++)
            {
                cboCourse[x] = "";
            }

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT DISTINCT(courseAcronym) FROM tbl_course INNER JOIN tbl_curriculums ON tbl_course.curriculums_id = tbl_curriculums.curriculums_id WHERE tbl_curriculums.status = 'active';";
                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCourse[x] = dr["courseAcronym"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "List course");
            }
            finally
            {
                con.Close();
            }
            return cboCourse;
        }

        public void S_AddSections(string course, string year, string section)
        {
            try
            {
                con.Open();
                string sqlAddSections = "INSERT INTO tbl_sections(course, year, section) VALUES(@c, @y, @s);";
                MySqlCommand com = new MySqlCommand(sqlAddSections, con);
                com.Parameters.AddWithValue("@c", course);
                com.Parameters.AddWithValue("@y", year);
                com.Parameters.AddWithValue("@s", section);
                com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "S_AddSections");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showSections()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT section_id AS 'ID' , course AS 'Course', year AS 'Year', section AS 'Section' FROM tbl_sections t;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_show");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public void S_DeleteSections(string id)
        {
            try
            {
                con.Open();
                string sqlCourse = "DELETE FROM tbl_sections WHERE section_id = @id";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "S_DeleteSEcitons");
            }
            finally
            {
                con.Close();
            }
        }

        //=====================P_SCHEDULE START============================
        public string[] Get_id_PSchedule(string prof_id)
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListRoomCode = "SELECT * FROM tbl_preferredschedules WHERE users_id = @p_id;";
                MySqlCommand com = new MySqlCommand(sqlListRoomCode, con);
                com.Parameters.AddWithValue("@p_id", prof_id); 
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id[x] = dr["preferredSchedule_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Get_id_PreferredSchedule");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] Get_info_PSchedule(string ps_id)
        {
            string[] preferredSchedule = new string[11];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT * FROM tbl_preferredSchedules WHERE preferredSchedule_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", ps_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    preferredSchedule[0] = dr["startTime"].ToString();
                    preferredSchedule[1] = dr["endTime"].ToString();
                    preferredSchedule[2] = dr["ps_day"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            return preferredSchedule;
        }

        public void Prof_AddSchedule(string p_id, string startTime, string endTime, string day)
        {
            try
            {
                con.Open();
                string sqlAddSchedule = "INSERT INTO tbl_preferredschedules(users_id, startTime, endTime, ps_day) VALUES(@id, @sT, @eT, @d);";
                MySqlCommand com1 = new MySqlCommand(sqlAddSchedule, con);
                com1.Parameters.AddWithValue("@id", p_id);
                com1.Parameters.AddWithValue("@sT", startTime);
                com1.Parameters.AddWithValue("@eT", endTime);
                com1.Parameters.AddWithValue("@d", day);
                com1.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "prof_AddSchedule");
            }
            finally
            {
                con.Close();
            }

            //audit
            AuditTrail(AuditTrailData.username, "Add", startTime + "-" + endTime + " on " + day + " preferred schedule.");
        }

        public void Prof_UpdatePrefSchedule(string id, string start, string end ,string day)
        {
            try
            {
                con.Open();
                string sqlAddRoom = "UPDATE tbl_preferredschedules SET startTime = @sT, endTime = @eT, ps_day = @d WHERE preferredschedule_id = @id;";
                MySqlCommand com = new MySqlCommand(sqlAddRoom, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@sT", start);
                com.Parameters.AddWithValue("@eT", end);
                com.Parameters.AddWithValue("@d", day);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Prof_UpdatePrefSchedule");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_showSchedule()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT preferredSchedule_id, ps_day AS 'DAY', startTime AS 'START TIME', endTime AS 'END TIME' FROM tbl_preferredschedules WHERE users_id = @id ORDER BY ps_day, startTime ASC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_show");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        // ====================P_SUBJECTS START============================
        public DataGridView dgv_SearchAddSubjects(string courseBy, string semester, string search, string by)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "";
                //if (courseBy == "Course Subject")
                //    sql = "SELECT subjects_id AS 'ID', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum' FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id WHERE status = 'active' AND su.course = @c ORDER BY cu.programName;";
                if (courseBy == "Courses from program department.")
                {
                    if (by == "Course Code")
                    {
                        sql = "SELECT subjects_id AS 'ID', su.course AS 'Course', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                            + "FROM tbl_subjects su "
                            + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                            + "WHERE status = 'active' "
                            + "AND su.course = @c "
                            + "AND su.semester = @sem "
                            + "AND subjectCode LIKE '" + search + "%' "
                            + "ORDER BY cu.programName;";
                    }
                    if (by == "Course Description")
                    {
                        sql = "SELECT subjects_id AS 'ID', su.course AS 'Course', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                            + "FROM tbl_subjects su "
                            + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                            + "WHERE status = 'active' "
                            + "AND su.course = @c "
                            + "AND su.semester = @sem "
                            + "AND subjectDescription LIKE '" + search + "%' "
                            + "ORDER BY cu.programName;";
                    }
                }

                //if (courseBy == "Other Subject")
                //    sql = "SELECT subjects_id AS 'ID', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum' FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id WHERE status = 'active' ORDER BY cu.programName;";
                if (courseBy == "All courses from all programs.")
                {
                    if (by == "Course Code")
                    {
                        sql = "SELECT subjects_id AS 'ID', su.course AS 'Course', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                        + "FROM tbl_subjects su "
                        + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                        + "WHERE status = 'active' "
                        + "AND su.semester = @sem "
                        + "AND subjectCode LIKE '" + search + "%' "
                        + "ORDER BY cu.programName;";
                    }
                    if (by == "Course Description")
                    {
                        sql = "SELECT subjects_id AS 'ID', su.course AS 'Course', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                        + "FROM tbl_subjects su "
                        + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                        + "WHERE status = 'active' "
                        + "AND su.semester = @sem "
                        + "AND subjectDescription LIKE '" + search + "%' "
                        + "ORDER BY cu.programName;";
                    }
                }

                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@c", usersData.p_cDepartment);
                com.Parameters.AddWithValue("@sem", semester);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public DataGridView dgv_SearchPreferredSubjects(string schoolYear, string semester, string search, string by)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                //string sql = "SELECT a.preferredSubjects_id AS 'ID', subjectCode AS 'CODE', subjectDescription AS 'DESCRIPTION', course AS 'COURSE', lectureHours AS 'LEC HRS', laboratoryHours AS 'LAB HRS', units AS 'UNITS', yearLevel AS 'YR LEVEL' FROM tbl_preferredSubjects a, tbl_subjects b WHERE a.users_id = @id AND b.subjects_id = a.subjects_id;";
                string sql = "";
                if (by == "Course Code")
                {
                    sql = "SELECT a.preferredSubjects_id AS 'ID', subjectCode AS 'CODE', subjectDescription AS 'DESCRIPTION', course AS 'COURSE', lectureHours AS 'LEC HRS', laboratoryHours AS 'LAB HRS', units AS 'UNITS', yearLevel AS 'YR LEVEL' "
                    + "FROM tbl_preferredSubjects a, tbl_subjects b "
                    + "WHERE a.users_id = @id "
                    + "AND b.subjects_id = a.subjects_id "
                    + "AND a.semester = @sem "
                    + "AND a.schoolYear = @sY "
                    + "AND subjectCode LIKE '"+search+"%';";
                }
                if (by == "Course Description")
                {
                    sql = "SELECT a.preferredSubjects_id AS 'ID', subjectCode AS 'CODE', subjectDescription AS 'DESCRIPTION', course AS 'COURSE', lectureHours AS 'LEC HRS', laboratoryHours AS 'LAB HRS', units AS 'UNITS', yearLevel AS 'YR LEVEL' "
                    + "FROM tbl_preferredSubjects a, tbl_subjects b "
                    + "WHERE a.users_id = @id "
                    + "AND b.subjects_id = a.subjects_id "
                    + "AND a.semester = @sem "
                    + "AND a.schoolYear = @sY "
                    + "AND subjectDescription LIKE '" + search + "%';";
                }
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_SearchSections");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public DataGridView dgv_showPreferredSubjects(string semester, string schoolYear)
        {
            DataGridView dgv = new DataGridView();
            try
            {
                con.Open();
                //string sql = "SELECT a.preferredSubjects_id AS 'ID', subjectCode AS 'CODE', subjectDescription AS 'DESCRIPTION', course AS 'COURSE', lectureHours AS 'LEC HRS', laboratoryHours AS 'LAB HRS', units AS 'UNITS', yearLevel AS 'YR LEVEL' FROM tbl_preferredSubjects a, tbl_subjects b WHERE a.users_id = @id AND b.subjects_id = a.subjects_id;";
                string sql = "SELECT a.preferredSubjects_id AS 'ID', subjectCode AS 'CODE', subjectDescription AS 'DESCRIPTION', course AS 'COURSE', lectureHours AS 'LEC HRS', laboratoryHours AS 'LAB HRS', units AS 'UNITS', yearLevel AS 'YR LEVEL' "
                    + "FROM tbl_preferredSubjects a, tbl_subjects b "
                    + "WHERE a.users_id = @id "
                    + "AND b.subjects_id = a.subjects_id "
                    + "AND a.semester = @sem "
                    + "AND a.schoolYear = @sY;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showPreferredSubjects");
            }
            finally
            {
                con.Close();
            }
            return dgv; 
        }

        public DataGridView dgv_showAddPreferredSubjects(string courseBy, string semester)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "";
                //if (courseBy == "Course Subject")
                //    sql = "SELECT subjects_id AS 'ID', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum' FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id WHERE status = 'active' AND su.course = @c ORDER BY cu.programName;";
                if (courseBy == "Courses from program department.")
                    sql = "SELECT subjects_id AS 'ID', su.course AS 'Program', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                        + "FROM tbl_subjects su "
                        + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                        + "WHERE status = 'active' "
                        + "AND su.course = @c "
                        + "AND su.semester = @sem "
                        + "ORDER BY cu.programName;";
                //if (courseBy == "Other Subject")
                //    sql = "SELECT subjects_id AS 'ID', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum' FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id WHERE status = 'active' ORDER BY cu.programName;";
                if (courseBy == "All courses from all programs.")
                    sql = "SELECT subjects_id AS 'ID', su.course AS 'Program', subjectCode AS 'Code', subjectDescription AS 'Description', CONCAT('[',programName,']') AS 'Curriculum', su.curriculums_id "
                        + "FROM tbl_subjects su "
                        + "INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                        + "WHERE status = 'active' "
                        + "AND su.semester = @sem "
                        + "ORDER BY cu.programName;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@c", usersData.p_cDepartment);
                com.Parameters.AddWithValue("@sem", semester);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_showADD");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public int getTotalUnits(string semester, string schoolYear)
        {
            int total = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_preferredSubjects a, tbl_subjects b "
                    + "WHERE a.users_id = @id "
                    + "AND a.semester = @sem "
                    + "AND a.schoolYear = @sY "
                    + "AND b.subjects_id = a.subjects_id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                    total += Convert.ToInt32(dr["units"].ToString());
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "GetTotalUnits");
            }
            finally
            {
                con.Close();
            }
            return total;
        }

        public int getTotalSubjects(string semester, string schoolYear)
        {
            int total = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_preferredSubjects a, tbl_subjects b "
                    + "WHERE a.users_id = @id "
                    + "AND a.semester = @sem "
                    + "AND a.schoolYear = @sY "
                    + "AND b.subjects_id = a.subjects_id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", usersData.p_id);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                    total++;
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "GetTotalSubjects");
            }
            finally
            {
                con.Close();
            }
            return total;
        }

        public void Prof_AddSubjects(string subject_id, string semester, string schoolYear,string curriculums_id)
        {
            try
            {
                con.Open();
                string sqlAddSubjects = "INSERT INTO tbl_preferredsubjects(users_id, subjects_id, semester, schoolYear, curriculums_id) VALUES(@p_id, @s_id, @sem, @sY, @c_id);";
                MySqlCommand com1 = new MySqlCommand(sqlAddSubjects, con);
                com1.Parameters.AddWithValue("@p_id", usersData.p_id);
                com1.Parameters.AddWithValue("@s_id", subject_id);
                com1.Parameters.AddWithValue("@sem", semester);
                com1.Parameters.AddWithValue("@sY", schoolYear);
                com1.Parameters.AddWithValue("@c_id", curriculums_id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "prof_AddSubjects");
            }
            finally
            {
                con.Close();
            }
        }

        public void Prof_DeleteSubjects(string preferredSubj_id)
        {
            try
            {
                con.Open();
                string sqlAddSubjects = "DELETE FROM tbl_preferredsubjects WHERE preferredSubjects_id = @ps_id;";
                MySqlCommand com1 = new MySqlCommand(sqlAddSubjects, con);
                com1.Parameters.AddWithValue("@ps_id", preferredSubj_id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "prof_DeleteSubjects");
            }
            finally
            {
                con.Close();
            }
        }
        //=====================Curriculum start=========================
        public DataGridView C_dgv_showCurriculum()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT curriculums_id AS 'ID', programName AS 'Program Title', curriculumYear AS 'Curriculum Year', createdAt AS 'Date Created', status AS 'Status'  from tbl_curriculumS ORDER BY status ASC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_dgv_showCurriculum");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        public void C_DeleteCurriculumProgram(string id)
        {
            try
            {
                con.Open();
                string preferredsubjects = "DELETE FROM tbl_preferredsubjects WHERE curriculums_id = @id";
                MySqlCommand com2 = new MySqlCommand(preferredsubjects, con);
                com2.Parameters.AddWithValue("@id", id);
                com2.ExecuteNonQuery();
                con.Close();

                con.Open();
                string studentScheduled = "DELETE FROM tbl_students_scheduled WHERE curriculums_id = @id";
                MySqlCommand com4 = new MySqlCommand(studentScheduled, con);
                com4.Parameters.AddWithValue("@id", id);
                com4.ExecuteNonQuery();
                con.Close();

                con.Open();
                string roomScheduled = "DELETE FROM tbl_room_scheduled WHERE curriculums_id = @id";
                MySqlCommand com3 = new MySqlCommand(roomScheduled, con);
                com3.Parameters.AddWithValue("@id", id);
                com3.ExecuteNonQuery();
                con.Close();

                con.Open();
                string subjects = "DELETE FROM tbl_subjects WHERE curriculums_id = @id";
                MySqlCommand com5 = new MySqlCommand(subjects, con);
                com5.Parameters.AddWithValue("@id", id);
                com5.ExecuteNonQuery();
                con.Close();

                con.Open();
                string course = "DELETE FROM tbl_course WHERE curriculums_id = @id";
                MySqlCommand com = new MySqlCommand(course, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                string curriculum = "DELETE FROM tbl_curriculums WHERE curriculums_id = @id";
                MySqlCommand com1 = new MySqlCommand(curriculum, con);
                com1.Parameters.AddWithValue("@id", id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_DeleteCurriculumProgram");
            }
            finally
            {
                con.Close();
            }
        }

        public void Prof_DeleteSchedule(string prefSched_id)
        {
            try
            {
                con.Open();
                string sqlAddSubjects = "DELETE FROM tbl_preferredschedules WHERE preferredSchedule_id = @pS_id;";
                MySqlCommand com1 = new MySqlCommand(sqlAddSubjects, con);
                com1.Parameters.AddWithValue("@pS_id", prefSched_id);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "prof_DeleteSchedule");
            }
            finally
            {
                con.Close();
            }

            //audit
            AuditTrail(AuditTrailData.username, "Deleted", "Preferred schedule.");
        }

        public string[] C_dgv_Edit(string id)
        {
            string[] c_info = new string[5];
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_curriculums cu, tbl_course co WHERE cu.curriculums_id = @id AND co.curriculums_id = @id";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    c_info[0] = dr["programName"].ToString();
                    c_info[1] = dr["curriculumYear"].ToString();
                    c_info[2] = dr["status"].ToString();
                    c_info[3] = dr["inUsed"].ToString();
                    c_info[4] = dr["courseAcronym"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            return c_info;
        }

        public void C_editCurriculum(string title, string acronym, string year, string publishedBy, string date, string status)
        {
            try
            {
                //to update the all curriculum into inUsed=NO
                //if (used == "YES")
                //{
                //    con.Open();
                //    string sqlUpdateInUsed = "UPDATE tbl_curriculums SET inUsed = 'NO';";
                //    MySqlCommand com2 = new MySqlCommand(sqlUpdateInUsed, con);
                //    com2.ExecuteNonQuery();
                //    con.Close();
                //}
                //to Update a curriculum

                con.Open();
                string sql = "UPDATE tbl_curriculums SET programName = @pN, curriculumYear = @cY, createdBy = @cB, createdAt = @cA, status = @s WHERE curriculums_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@pN", title); 
                com.Parameters.AddWithValue("@cY", year);
                com.Parameters.AddWithValue("@cB", publishedBy);
                com.Parameters.AddWithValue("@cA", date);
                com.Parameters.AddWithValue("@s", status);
                com.Parameters.AddWithValue("@id", curriculumData.c_id);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                string sqlAcronym = "UPDATE tbl_course SET courseAcronym = @cA, courseName = @cN WHERE curriculums_id = @id";
                using (MySqlCommand com1 = new MySqlCommand(sqlAcronym, con))
                {
                    com1.Parameters.AddWithValue("@cA", acronym);
                    com1.Parameters.AddWithValue("@cN", title);
                    com1.Parameters.AddWithValue("@id", curriculumData.c_id);
                    com1.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_editCurriculum");
            }
            finally
            {
                con.Close();
            }
        }

        //=====================Class Scheduling Dasboard ==============================

        public string[] getCourseYearSection()
        {
            int x = 0;
            string[] cboCourse = new string[30];
            for (x = 0; x < 30; x++)
            {
                cboCourse[x] = "";
            }

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT DISTINCT(course) FROM tbl_sections ;";

                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCourse[x] = dr["course"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "getCourseYearSection");
            }
            finally
            {
                con.Close();
            }
            return cboCourse;
        }

        public string[] getCourseYear(string course)
        {
            int x = 0;
            string[] cboYear = new string[30];
            for (x = 0; x < 30; x++)
            {
                cboYear[x] = "";
            }

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT DISTINCT year FROM tbl_sections WHERE course = @c ORDER BY year ASC;";

                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.Parameters.AddWithValue("@c", course);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboYear[x] = dr["year"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "getCourseYear");
            }
            finally
            {
                con.Close();
            }
            return cboYear;
        }

        public string[] getCourseSection(string course, string year)
        {
            int x = 0;
            string[] cboSection= new string[30];
            for (x = 0; x < 30; x++)
            {
                cboSection[x] = "";
            }

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT DISTINCT section FROM tbl_sections WHERE course = @c AND year = @y ORDER BY section ASC;";

                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.Parameters.AddWithValue("@c", course);
                com.Parameters.AddWithValue("@y", year);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboSection[x] = dr["section"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "getCourseSection");
            }
            finally
            {
                con.Close();
            }
            return cboSection;
        }

        public string[] getCurriculum()
        {
            int x = 0;
            string[] cboCurriculum = new string[30];
            for (x = 0; x < 30; x++)
            {
                cboCurriculum[x] = "";
            }

            x = 0;
            try
            {
                con.Open();
                string sqlListCourse = "SELECT CONCAT(programName,' ',curriculumYear) FROM tbl_curriculums WHERE status = 'active';";

                MySqlCommand com = new MySqlCommand(sqlListCourse, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCurriculum[x] = dr["CONCAT(programName,' ',curriculumYear)"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "getCourseYearSection");
            }
            finally
            {
                con.Close();
            }
            return cboCurriculum;
        }

        public string[] get_id_StudentsScheduled(string students, string semester, string schoolYear)//to get id of the students
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_students_scheduled t "
                    + "WHERE CONCAT(course,year,section) = @stu "
                    + "AND semester = @sem "
                    + "AND schoolYear = @sY;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@stu", students);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id[x] = dr["students_scheduled_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Get_id_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] get_info_StudentsScheduled(string sS_id)
        {
            string[] roomSchedule = new string[11];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT *, CONCAT(course,' ',year,'-',section) FROM tbl_students_scheduled WHERE students_scheduled_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", sS_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    roomSchedule[0] = dr["scheduledStartTime"].ToString();
                    roomSchedule[1] = dr["scheduledEndTime"].ToString();
                    roomSchedule[2] = dr["scheduledDay"].ToString();
                    roomSchedule[3] = dr["professor"].ToString();
                    roomSchedule[4] = dr["subjectCode"].ToString();
                    roomSchedule[5] = dr["CONCAT(course,' ',year,'-',section)"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "get_info_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return roomSchedule;
        }

        public string[] get_id_PreferredScheduled(string professor, string semester, string schoolYear)//to get id of the preferred schedule professor
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                string u_id = "";
                con.Open();
                string user = "SELECT * FROM tbl_users t "
                    + "WHERE CONCAT(firstName,' ',middleName,' ',lastName) = @prof ;";
                MySqlCommand com1 = new MySqlCommand(user, con);
                com1.Parameters.AddWithValue("@prof", professor);
                com1.ExecuteNonQuery();

                MySqlDataReader dr = com1.ExecuteReader();
                if (dr.Read())
                {
                    u_id = dr["users_id"].ToString();
                }
                con.Close();


                con.Open();
                string sql = "SELECT * FROM tbl_preferredschedules t "
                    + "WHERE users_id = @id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", u_id);
                com.ExecuteNonQuery();

                MySqlDataReader drr = com.ExecuteReader();
                while (drr.Read())
                {
                    id[x] = drr["preferredSchedule_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "get_id_PreferredScheduled");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] get_info_PreferredScheduled(string sS_id)//get the info from preferredschedule
        {
            string[] roomSchedule = new string[50];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT * FROM tbl_preferredschedules WHERE preferredSchedule_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", sS_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    roomSchedule[0] = dr["startTime"].ToString();
                    roomSchedule[1] = dr["endTime"].ToString();
                    roomSchedule[2] = dr["ps_Day"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "get_info_PreferredScheduled");
            }
            finally
            {
                con.Close();
            }
            return roomSchedule;
        }

        public string[] get_id_ProfessorScheduled(string professor, string semester, string schoolYear)//to get id of the professor
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_students_scheduled t "
                    + "WHERE professor = @prof "
                    + "AND semester = @sem "
                    + "AND schoolYear = @sY;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@prof", professor);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id[x] = dr["students_scheduled_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Get_id_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] get_info_ProfessorScheduled(string sS_id)
        {
            string[] roomSchedule = new string[11];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT *, CONCAT(course,' ',year,'-',section) FROM tbl_students_scheduled WHERE students_scheduled_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", sS_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    roomSchedule[0] = dr["scheduledStartTime"].ToString();
                    roomSchedule[1] = dr["scheduledEndTime"].ToString();
                    roomSchedule[2] = dr["scheduledDay"].ToString();
                    roomSchedule[3] = dr["room"].ToString();
                    roomSchedule[4] = dr["subjectCode"].ToString();
                    roomSchedule[5] = dr["CONCAT(course,' ',year,'-',section)"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "get_info_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return roomSchedule;
        }

        public string[] get_id_StudentScheduled(string section, string semester, string schoolYear)//to get id of the section(student)
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListSection = "SELECT * FROM tbl_students_scheduled t "
                    + "WHERE CONCAT(course,' ',year,' - ',section) = @sec "
                    + "AND semester = @sem "
                    + "AND schoolYear = @sY;";
                MySqlCommand com = new MySqlCommand(sqlListSection, con);
                com.Parameters.AddWithValue("@sec", section);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id[x] = dr["students_scheduled_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Get_id_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] get_info_StudentScheduled(string sS_id)
        {
            string[] roomSchedule = new string[11];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT *, CONCAT(course,' ',year,'-',section) FROM tbl_students_scheduled WHERE students_scheduled_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", sS_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    roomSchedule[0] = dr["scheduledStartTime"].ToString();
                    roomSchedule[1] = dr["scheduledEndTime"].ToString();
                    roomSchedule[2] = dr["scheduledDay"].ToString();
                    roomSchedule[3] = dr["room"].ToString();
                    roomSchedule[4] = dr["subjectCode"].ToString();
                    roomSchedule[5] = dr["professor"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "get_info_StudentsScheduled");
            }
            finally
            {
                con.Close();
            }
            return roomSchedule;
        }

        public string[] get_id_roomScheduled(string room_code, string semester, string schoolYear)
        {
            string[] id = new string[100];
            int x = 0;
            for (x = 0; x < 100; x++)
                id[x] = "";

            x = 0;
            try
            {
                con.Open();
                string sqlListRoomCode = "SELECT * FROM tbl_room_scheduled t WHERE roomCode = @rC "
                    + "AND semester = @sem "
                    + "AND schoolYear = @sY;";
                MySqlCommand com = new MySqlCommand(sqlListRoomCode, con);
                com.Parameters.AddWithValue("@rC", room_code);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id[x] = dr["room_scheduled_id"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Get_id_roomScheduled");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string[] get_info_roomScheduled(string rS_id)
        {
            string[] roomSchedule = new string[11];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT *, CONCAT(course,' ',year,'-',section) FROM tbl_room_scheduled WHERE room_scheduled_id = @id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", rS_id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    roomSchedule[0] = dr["roomStartTime"].ToString();
                    roomSchedule[1] = dr["roomEndTime"].ToString();
                    roomSchedule[2] = dr["roomDay"].ToString();
                    roomSchedule[3] = dr["assignedProfessor"].ToString();
                    roomSchedule[4] = dr["subjectCode"].ToString();
                    roomSchedule[5] = dr["CONCAT(course,' ',year,'-',section)"].ToString();
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "get_info_roomScheduled");
            }
            finally
            {
                con.Close();
            }
            return roomSchedule;
        }

        public void CSD_ShowSubjectsForStudents(string course, string yearLevel, string program, string semester)//to set all values into the accessors 
        {
            int x = 0;
            for (x = 0; x < 11; x++)//to set all accessors into null value
            {
                SubjectForStudents.CourseCode[x] = "";
                SubjectForStudents.SubjectDescription[x] = "";
                SubjectForStudents.Units[x] = "";
                SubjectForStudents.LecHrs[x] = "";
                SubjectForStudents.LabHrs[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sqlRegistrationCard = "SELECT * FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id "
                    + "WHERE course = @c "
                    + "AND yearLevel = @y "
                    + "AND CONCAT(cu.programName,' ',cu.curriculumYear) = @pNcY "
                    + "AND su.semester = @sem "
                    + "ORDER BY su.subjectCode ASC;";

                MySqlCommand com = new MySqlCommand(sqlRegistrationCard, con);
                com.Parameters.AddWithValue("@c", course);
                com.Parameters.AddWithValue("@y", yearLevel);
                com.Parameters.AddWithValue("@pNcY", program);
                com.Parameters.AddWithValue("@sem", semester);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.CourseCode[x] = dr["subjectCode"].ToString();
                    SubjectForStudents.SubjectDescription[x] = dr["subjectDescription"].ToString();
                    SubjectForStudents.Units[x] = dr["units"].ToString();
                    SubjectForStudents.LecHrs[x] = dr["lectureHours"].ToString();
                    SubjectForStudents.LabHrs[x] = dr["laboratoryHours"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ShowSubjectsForStudents");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_ListActiveRoom()//to add items of all active rooms into combox
        {
            int x = 0;
            for (x = 0; x < 50; x++)//to set all accessors into null value - set to 50 loop
            {
                SubjectForStudents.Rooms[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sqlRegistrationCardRooms = "SELECT * FROM tbl_room WHERE roomStatus = 'ACTIVE' ORDER BY roomCode ASC;";

                MySqlCommand com = new MySqlCommand(sqlRegistrationCardRooms, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.Rooms[x] = dr["roomCode"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ListActiveRooms");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_ListAllSections()
        {
            int x = 0;
            for (x = 0; x < 50; x++)//to set all accessors into null value - set to 50 loop
            {
                SubjectForStudents.Sections[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT DISTINCT CONCAT(course,' ',year,' - ',section) "
                    + "FROM tbl_students_scheduled t "
                    + "ORDER BY course, year, section asc;";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.Sections[x] = dr["CONCAT(course,' ',year,' - ',section)"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ListAllSections");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_ListAllProfessors()
        {
            int x = 0;
            for (x = 0; x < 50; x++)//to set all accessors into null value - set to 50 loop
            {
                SubjectForStudents.ProfessorsName[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT DISTINCT professor FROM tbl_students_scheduled t WHERE professor != '';";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.ProfessorsName[x] = dr["professor"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ListAllProfessors");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_ListProfDedicated(string courseCode, string semester, string schoolYear)// to add item of professors dedicated to his/her preferred subjects into combobox
        {
            int x = 0;
            for (x = 0; x < 100; x++)//to set all accessors into null value - set to 100 loop
            {
                SubjectForStudents.Professors[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT DISTINCT ps.users_id, CONCAT(usr.firstName,' ',usr.middleName,' ', usr.lastName) "
                    + "FROM tbl_preferredSubjects ps, tbl_subjects su, tbl_users usr "
                    + "WHERE ps.subjects_id = su.subjects_id "
                    + "AND su.subjectCode = @sC "
                    + "AND su.semester = @sem "
                    + "AND ps.schoolYear = @sY "
                    + "AND ps.users_id = usr.users_id "
                    + "AND usr.status = 'active' "
                    + "ORDER BY usr.FirstName ASC;";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@sC", courseCode);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.Professors[x] = dr["CONCAT(usr.firstName,' ',usr.middleName,' ', usr.lastName)"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ListProfDedicated");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_ListProfNotDedicated()// to add item of professors not dedicated to his/her preferred subjects into combobox
        {
            int x = 0;
            for (x = 0; x < 100; x++)//to set all accessors into null value - set to 100 loop
            {
                SubjectForStudents.Professors[x] = "";
            }
            x = 0;
            try
            {
                con.Open();
                string sql = "SELECT DISTINCT CONCAT(usr.firstName,' ',usr.middleName,' ', usr.lastName) "
                    + "FROM tbl_users usr "
                    + "WHERE usr.status = 'active' "
                    + "AND usr.userLevel = 'professor';";

                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    SubjectForStudents.Professors[x] = dr["CONCAT(usr.firstName,' ',usr.middleName,' ', usr.lastName)"].ToString();
                    x++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_ListProfDedicated");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_get_professors_id(string professor)
        {
            try
            {
                con.Open();
                string sql = "SELECT users_id FROM tbl_users WHERE CONCAT(firstName,' ',middleName,' ',lastName) = @p;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p", professor);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ClassSchedule_Data.Professors_id = dr["users_id"].ToString();
                }
                else
                {
                    ClassSchedule_Data.Professors_id = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "CSD_get_professors_id");
            }
            finally
            {
                con.Close();
            }
        }

        public void CSD_insert_students_schedule(string course, string year, string section, string curriculum, string semester, string schoolYear)
        {
            try
            {
                con.Open();
                int x = 0;
                int count = 0;
                string cu = "";
                string sqlGetCurriculumId = "SELECT * FROM tbl_curriculums WHERE CONCAT(programName,' ',curriculumYear) = @cN";
                using(MySqlCommand cmd = new MySqlCommand(sqlGetCurriculumId, con))//get the curriculums id
                {
                    cmd.Parameters.AddWithValue("@cN", StudentsScheduled.curriculumsName);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        cu = dr["curriculums_id"].ToString();
                    }
                    con.Close();
                }

                con.Open();
                string sqlCount = "SELECT * FROM tbl_subjects su INNER JOIN tbl_curriculums cu ON su.curriculums_id = cu.curriculums_id WHERE course = @c AND yearLevel = @y AND CONCAT(cu.programName,' ',cu.curriculumYear) = @cN AND su.semester = @sem ORDER BY su.subjectCode ASC;";
                using(MySqlCommand cmd1 = new MySqlCommand(sqlCount, con))//count
                {
                    cmd1.Parameters.AddWithValue("@c", course);
                    cmd1.Parameters.AddWithValue("@y", year);
                    cmd1.Parameters.AddWithValue("@cN", curriculum);
                    cmd1.Parameters.AddWithValue("@sem", semester);
                    cmd1.ExecuteNonQuery();

                    MySqlDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                    }
                }
                con.Close();

                //[students schedule]to delete the existing data to replace new data at the same sections blah blah blah
                con.Open();
                string sqlDeleteStudentsScheduled = "DELETE FROM tbl_students_scheduled WHERE curriculums_id = @c_id AND course = @c AND year = @y AND section = @s AND semester = @sem AND schoolYear = @sY;";
                using (MySqlCommand cmd = new MySqlCommand(sqlDeleteStudentsScheduled, con))//to delete data from students scheduled
                {
                    cmd.Parameters.AddWithValue("@c_id", cu);
                    cmd.Parameters.AddWithValue("@c", course);
                    cmd.Parameters.AddWithValue("@y", year);
                    cmd.Parameters.AddWithValue("@s", section);
                    cmd.Parameters.AddWithValue("@sem", semester);
                    cmd.Parameters.AddWithValue("@sY", schoolYear);
                    cmd.ExecuteNonQuery();
                }
                con.Close();

                //[room schedule]to delete the existing data to replace new data at the same sections blah blah blah
                con.Open();
                string sqlDeleteRoomScheduled = "DELETE FROM tbl_room_scheduled WHERE curriculums_id = @c_id AND course = @c AND year = @y AND section = @s AND semester = @sem AND schoolYear = @sY;";
                using (MySqlCommand cmd = new MySqlCommand(sqlDeleteRoomScheduled, con))//to delete data from students scheduled
                {
                    cmd.Parameters.AddWithValue("@c_id", cu);
                    cmd.Parameters.AddWithValue("@c", course);
                    cmd.Parameters.AddWithValue("@y", year);
                    cmd.Parameters.AddWithValue("@s", section);
                    cmd.Parameters.AddWithValue("@sem", semester);
                    cmd.Parameters.AddWithValue("@sY", schoolYear);
                    cmd.ExecuteNonQuery();
                }
                con.Close();


                //inserting data
                con.Open();
                for (int y = 0; y < count; y++)// from how many count that increment that to be insert the schedule for students
                {
                    string sqlInsertStudentsSched = "INSERT INTO tbl_students_scheduled(curriculums_id, course, year, section, semester, schoolYear, room, subjectCode, subjectDescription, scheduledBy, scheduledDate, professor, scheduledStartTime, scheduledEndTime, scheduledDay, lecHours, labHours, units) VALUES(@c_id, @c, @y, @s, @sem, @sY, @r, @sC, @sD, @sB, @sDa, @p, @sS, @sE, @sDay, @lec, @lab, @u)";
                    using (MySqlCommand cmd = new MySqlCommand(sqlInsertStudentsSched, con))//to insert new data
                    {
                        cmd.Parameters.AddWithValue("@c_id", cu);
                        cmd.Parameters.AddWithValue("@c", StudentsScheduled.course);
                        cmd.Parameters.AddWithValue("@y", StudentsScheduled.year);
                        cmd.Parameters.AddWithValue("@s", StudentsScheduled.section);
                        cmd.Parameters.AddWithValue("@sem", StudentsScheduled.semester);
                        cmd.Parameters.AddWithValue("@sY", StudentsScheduled.schoolYear);

                        cmd.Parameters.AddWithValue("@r", StudentsScheduled.Rooms[x]);
                        cmd.Parameters.AddWithValue("@sC", StudentsScheduled.CourseCode[x]);
                        cmd.Parameters.AddWithValue("@sD", StudentsScheduled.SubjectDescription[x]);
                        cmd.Parameters.AddWithValue("@sB", usersData.a_id);
                        cmd.Parameters.AddWithValue("@sDa", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                        cmd.Parameters.AddWithValue("@p", StudentsScheduled.Professors[x]);
                        cmd.Parameters.AddWithValue("@sS", StudentsScheduled.startTime[x]);
                        cmd.Parameters.AddWithValue("@sE", StudentsScheduled.endTime[x]);
                        cmd.Parameters.AddWithValue("@sDay", StudentsScheduled.day[x]);
                        cmd.Parameters.AddWithValue("@lec", StudentsScheduled.LecHrs[x]);
                        cmd.Parameters.AddWithValue("@lab", StudentsScheduled.LabHrs[x]);
                        cmd.Parameters.AddWithValue("@u", StudentsScheduled.Units[x]);

                        cmd.ExecuteNonQuery();
                        x++;
                    }
                }
                con.Close();

                con.Open();
                x = 0;
                for (int y = 0; y < count; y++)// from how many count that increment that to be insert the schedule for rooms
                {
                    string sqlInsertRoomScheduled = "INSERT INTO tbl_room_scheduled(roomCode, roomStartTime, roomEndTime, roomDay, assignedProfessor, subjectCode, course, year, section, semester, schoolYear, curriculums_id) VALUES(@rC, @rST, @rET, @rD, @aP, @sC, @c, @y, @sec, @sem, @sY, @c_id)";
                    using (MySqlCommand cmd = new MySqlCommand(sqlInsertRoomScheduled, con))
                    {
                        cmd.Parameters.AddWithValue("@rC", StudentsScheduled.Rooms[x]);
                        cmd.Parameters.AddWithValue("@rST", StudentsScheduled.startTime[x]);
                        cmd.Parameters.AddWithValue("@rET", StudentsScheduled.endTime[x]);
                        cmd.Parameters.AddWithValue("@rD", StudentsScheduled.day[x]);
                        cmd.Parameters.AddWithValue("@aP", StudentsScheduled.Professors[x]);
                        cmd.Parameters.AddWithValue("@sC", StudentsScheduled.CourseCode[x]);
                        cmd.Parameters.AddWithValue("@c", StudentsScheduled.course);
                        cmd.Parameters.AddWithValue("@y", StudentsScheduled.year);
                        cmd.Parameters.AddWithValue("@sec", StudentsScheduled.section);
                        cmd.Parameters.AddWithValue("@sem", StudentsScheduled.semester);
                        cmd.Parameters.AddWithValue("@sY", StudentsScheduled.schoolYear);
                        cmd.Parameters.AddWithValue("@c_id", cu);

                        cmd.ExecuteNonQuery();
                        x++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "students_schedule");
            }
            finally
            {
                con.Close();
            }
        }

        //================My Account ============
        public void AccountInfo()
        {
            try
            {
                con.Open();
                string SqlSelectUsers = "SELECT * FROM tbl_users WHERE users_id = @a_id;";
                MySqlCommand com = new MySqlCommand(SqlSelectUsers, con);
                com.Parameters.AddWithValue("@a_id", usersData.a_id);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usersData.a_username = dr["username"].ToString();
                    usersData.a_password = dr["password"].ToString();
                    usersData.a_fName = dr["firstName"].ToString();
                    usersData.a_mName = dr["middleName"].ToString();
                    usersData.a_lName = dr["lastName"].ToString();
                    usersData.a_address = dr["address"].ToString();
                    usersData.a_emailAddress = dr["emailAddress"].ToString();
                    usersData.a_mobileNubmer = dr["mobileNumber"].ToString();
                    usersData.a_gender = dr["gender"].ToString();
                }
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.Message, "Login Test");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateUsersAdminAccount(string id, string username, string password, string firstname, string middlename, string lastname, string address, string gender, string emailAddress, string mobileNumber)
        {
            try
            {
                con.Open();
                string sqlUpdateUserInformation = "UPDATE tbl_users SET username=@u, password=@p, firstName=@fN, middleName=@mN, lastName=@lN, address=@a, gender=@g, emailAddress=@eA, mobileNumber=@moN WHERE users_id=@id;";
                MySqlCommand com = new MySqlCommand(sqlUpdateUserInformation, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.Parameters.AddWithValue("@fN", firstname);
                com.Parameters.AddWithValue("@mN", middlename);
                com.Parameters.AddWithValue("@lN", lastname);
                com.Parameters.AddWithValue("@a", address);
                com.Parameters.AddWithValue("@g", gender);
                com.Parameters.AddWithValue("@eA", emailAddress);
                com.Parameters.AddWithValue("@moN", mobileNumber);
                com.ExecuteNonQuery();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "UpdateUsersAdminAccount");
            }
            finally
            {
                con.Close();
            }
        }

        //===============Admin Account===============
        public void RegisterAdmin(string username, string password, string firstname, string middlename, string lastname, string address, string gender, string emailAddress, string mobileNumber)
        {
            try
            {
                con.Open();
                string sqlRegisterUser = "INSERT INTO tbl_users(username, password, firstName, middleName, lastName, address, gender, emailAddress, mobileNumber, status, userLevel, teachingStatus, courseDepartment, unitsAllowed) VALUES(@u, @p, @fN, @mN, @lN, @a, @g, @eA, @moN, 'active', 'administrator', 'administrator', 'administrator', 'administrator');";
                MySqlCommand com = new MySqlCommand(sqlRegisterUser, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.Parameters.AddWithValue("@fN", firstname);
                com.Parameters.AddWithValue("@mN", middlename);
                com.Parameters.AddWithValue("@lN", lastname);
                com.Parameters.AddWithValue("@a", address);
                com.Parameters.AddWithValue("@g", gender);
                com.Parameters.AddWithValue("@eA", emailAddress);
                com.Parameters.AddWithValue("@moN", mobileNumber);
                com.ExecuteNonQuery();
            }
            catch (MySqlException sq)
            {
                MessageBox.Show(sq.Message, "RegisterAdmin");
            }
            finally
            {
                con.Close();
            }
        }

        public void RegisterAdminSecurityQuestion(string username, string password, string[] answer, string[] question)
        {
            try
            {
                con.Open();
                string id = "";
                string sqlSecurityQuestion = "SELECT * FROM tbl_users WHERE username = @u AND password = @p;";
                MySqlCommand com = new MySqlCommand(sqlSecurityQuestion, con);
                com.Parameters.AddWithValue("@u", username);
                com.Parameters.AddWithValue("@p", password);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    id = dr["users_id"].ToString();
                }
                con.Close();
                con.Open();
                for (int x = 0; x < 3; x++)
                {
                    string sqlInsertSQ = "INSERT INTO tbl_securityquestions(users_id, answer, question) VALUES('" + id + "', @a, @q)";
                    MySqlCommand com1 = new MySqlCommand(sqlInsertSQ, con);
                    com1.Parameters.AddWithValue("@a", answer[x]);
                    com1.Parameters.AddWithValue("@q", question[x]);
                    com1.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Admin Security Question");
            }
            finally
            {
                con.Close();
            }

        }

        //===============Forgot Password==============
        public string[] ShowMyQuestions(string id)
        {
            string[] question = new string[3];
            try
            {
                con.Open();
                string testSqlUsers = "SELECT * FROM tbl_securityquestions WHERE users_id=@id";
                MySqlCommand com = new MySqlCommand(testSqlUsers, con);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                MySqlDataReader dr = com.ExecuteReader();
                int x = 0;
                while (dr.Read())
                {
                    question[x] = dr["question"].ToString();
                    x++;
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
            return question;
        }

        public bool UserExists(string username)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users t WHERE username = @usr;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usr", username);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usersData.p_id = dr["users_id"].ToString();
                    usersData.p_usr = dr["username"].ToString();
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "UserExists");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool ValidSecurityQuestion(string id, string answer, string question)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_securityquestions t WHERE users_id = @id AND answer = @a AND question = @q";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@a", answer);
                cmd.Parameters.AddWithValue("@q", question);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "UserExists");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public void UpdateNewPassword(string id, string newPassword)
        {
            try
            {
                con.Open();
                string sqlUpdateUserInformation = "UPDATE tbl_users SET password = @nP WHERE users_id = @id;";
                MySqlCommand com = new MySqlCommand(sqlUpdateUserInformation, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@nP", newPassword);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message, "UpdateNewPassword");
            }
            finally
            {
                con.Close();
            }
        }

        public bool TryInOtherWay(string fName, string mName, string lName, string mNumber)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users t "
                    + "WHERE firstName = @fN "
                    + "AND middleName = @mN "
                    + "AND lastName = @lN "
                    + "AND mobileNumber = @moN;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fN", fName);
                cmd.Parameters.AddWithValue("@mN", mName);
                cmd.Parameters.AddWithValue("@lN", lName);
                cmd.Parameters.AddWithValue("@moN", mNumber);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usersData.p_id = dr["users_id"].ToString();
                    usersData.p_usr = dr["username"].ToString();
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "UserExists");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        //===============Load Start-up============
        public bool EmptyCurriculum()
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_curriculums t;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "EmptyCurriculum");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool EmptySection()
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_sections t;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "EmptyCurriculum");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool EmptyRoom()
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_room t;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "EmptyCurriculum");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        //===============PRINT PREVIEW===============
        public DataGridView dgv_Example(string selectedGroupby, string sortby)
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                string sql = "";
                con.Open();
                if (sortby != "" && selectedGroupby != "")
                {
                    if (selectedGroupby == "PROGRAM")
                    {
                        if (sortby == "ALL")
                        {
                            sql = "SELECT subjectCode, subjectDescription, lecHours, labHours, units, course ,year ,section , room, professor, scheduledDay, scheduledStartTime, scheduledEndTime FROM tbl_students_scheduled t WHERE semester = @sem AND schoolYear = @sY;";
                        }
                        else
                        {
                            sql = "SELECT subjectCode, subjectDescription, lecHours, labHours, units, course ,year ,section , room, professor, scheduledDay, scheduledStartTime, scheduledEndTime FROM tbl_students_scheduled t WHERE course = @by AND semester = @sem AND schoolYear = @sY;";
                        }
                    }
                    else if (selectedGroupby == "SECTION")
                    {
                        sql = "SELECT subjectCode, subjectDescription, lecHours, labHours, units, course ,year ,section , room, professor, scheduledDay, scheduledStartTime, scheduledEndTime FROM tbl_students_scheduled t WHERE semester = @sem AND schoolYear = @sY AND CONCAT(course,' ',year,' - ',section) = @by;";
                    }
                    else if (selectedGroupby == "PROFESSOR")
                    {
                        sql = "SELECT subjectCode, subjectDescription, lecHours, labHours, units, course ,year ,section , room, professor, scheduledDay, scheduledStartTime, scheduledEndTime FROM tbl_students_scheduled t WHERE semester = @sem AND schoolYear = @sY AND professor = @by;";
                    }
                    else if (selectedGroupby == "ROOM")
                    {
                        sql = "SELECT subjectCode, subjectDescription, lecHours, labHours, units, course ,year ,section , room, professor, scheduledDay, scheduledStartTime, scheduledEndTime FROM tbl_students_scheduled t WHERE semester = @sem AND schoolYear = @sY AND room = @by;";
                    }
                }
                
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@by", sortby);
                com.Parameters.AddWithValue("@sem", SummaryData.semester);
                com.Parameters.AddWithValue("@sY", SummaryData.schoolYear);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "dgv_Example");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }


        //===============AUDIT TRAIL================
        public void AuditTrail(string username, string action, string description)
        {
            try
            {
                con.Open();
                string sqlCourse = "INSERT INTO tbl_audittrail(dateTime, username, action, description) VALUES(@dT, @u, @a, @d);";
                MySqlCommand com1 = new MySqlCommand(sqlCourse, con);
                com1.Parameters.AddWithValue("@dT", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                com1.Parameters.AddWithValue("@u", username);
                com1.Parameters.AddWithValue("@a", action);
                com1.Parameters.AddWithValue("@d", description);
                com1.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "AuditTrail");
            }
            finally
            {
                con.Close();
            }
        }

        public DataGridView dgv_AuditTrail()
        {
            DataGridView dgv1 = new DataGridView();
            try
            {
                con.Open();
                string sql = "SELECT dateTime, username, action, description FROM tbl_audittrail ORDER BY audittrail_id DESC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();
                con.Close();

                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv1.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "C_dgv_showCurriculum");
            }
            finally
            {
                con.Close();
            }
            return dgv1;
        }

        //=================CHECK IF EXISITING==============
        public bool existRoom(string code, string name)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_room WHERE roomCode = @rC AND roomName = @rN;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@rC", code);
                com.Parameters.AddWithValue("@rN", code);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existRoom");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool existUsername(string username)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_users WHERE username = @u;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@u", username);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existUsername");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool existPreferredSubject(string id, string semester, string schoolYear, string users_id)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_preferredsubjects WHERE subjects_id = @id AND semester = @sem AND schoolYear = @sY AND users_id = @u_id;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@sem", semester);
                com.Parameters.AddWithValue("@sY", schoolYear);
                com.Parameters.AddWithValue("@u_id", users_id);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existUsername");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool existProgramCourse(string id, string code, string description)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_subjects WHERE curriculums_id = @id AND subjectCode = @sC AND subjectDescription = @sD;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@sC", code);
                com.Parameters.AddWithValue("@sD", description);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existUsername");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool existProgram(string name, string year)
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_curriculums WHERE programName = @id AND curriculumYear = @sC;";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", name);
                com.Parameters.AddWithValue("@sC", year);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existUsername");
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        //====================ON GOING CLASS SCHEDULING===============

        public void changeState(string state)
        {
            try
            {
                con.Open();
                string sqlAddRoom = "UPDATE tbl_classschedulestatus SET onGoing = @o";
                MySqlCommand com = new MySqlCommand(sqlAddRoom, con);
                com.Parameters.AddWithValue("@o", state);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "R_UpdateRooms");
            }
            finally
            {
                con.Close();
            }
        }

        public bool isGoing()
        {
            bool result = false;
            try
            {
                con.Open();
                string sql = "SELECT * FROM tbl_classschedulestatus WHERE onGoing = '1'";
                MySqlCommand com = new MySqlCommand(sql, con);
                com.ExecuteNonQuery();

                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    result = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "existUsername");
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
