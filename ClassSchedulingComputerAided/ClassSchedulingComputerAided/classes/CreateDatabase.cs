using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClassSchedulingComputerAided.Properties;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    class CreateDatabase
    {
        public void grantPrivilegesDB(string name, string conn, string username, string password)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("GRANT ALL PRIVILEGES ON *.* TO '"+username+"'@'%' IDENTIFIED BY '"+password+"';", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand("FLUSH PRIVILEGES;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        public void initCreateDatabase(string server, string dbName, string usrDb, string pwdDb, string port)
        {
            string sqlConnection = "server=" + server
            + "; username=" + usrDb
            + "; password=" + pwdDb
            + "; port=" + port + ";";

            grantPrivilegesDB(dbName, sqlConnection, usrDb, pwdDb);
            DBNAME(dbName, sqlConnection);
            DBtable_1(dbName, sqlConnection);
            DBtable_2(dbName, sqlConnection);
            DBtable_3(dbName, sqlConnection);
            DBtable_4(dbName, sqlConnection);
            DBtable_5(dbName, sqlConnection);
            DBtable_6(dbName, sqlConnection);
            DBtable_7(dbName, sqlConnection);
            DBtable_8(dbName, sqlConnection);
            DBtable_9(dbName, sqlConnection);
            DBtable_10(dbName, sqlConnection);
            DBtable_11(dbName, sqlConnection);
            DBtable_12(dbName, sqlConnection);
            DBtable_13(dbName, sqlConnection);
        }

        //===============QUERIES==============
        private void DBNAME(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE DATABASE `" + name + "`;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_1(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_users` ( "
                    + "`users_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`username` varchar(45) NOT NULL, "
                    + "`password` varchar(100) NOT NULL, "
                    + "`firstName` varchar(45) NOT NULL, "
                    + "`middleName` varchar(45) NOT NULL, "
                    + "`lastName` varchar(45) NOT NULL, "
                    + "`address` varchar(120) NOT NULL, "
                    + "`gender` varchar(45) NOT NULL, "
                    + "`teachingStatus` varchar(45) NOT NULL, "
                    + "`courseDepartment` varchar(45) NOT NULL, "
                    + "`emailAddress` varchar(45) NOT NULL, "
                    + "`mobileNumber` varchar(45) NOT NULL, "
                    + "`status` varchar(45) NOT NULL, "
                    + "`userLevel` varchar(45) NOT NULL, "
                    + "`unitsAllowed` varchar(45) NOT NULL, "
                    + "`loginStatus` int(10) unsigned NOT NULL default '0', "
                    + "PRIMARY KEY  (`users_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_2(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_securityquestions` ("
                    + "`sq_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`users_id` int(10) unsigned NOT NULL,"
                    + "`answer` varchar(45) NOT NULL,"
                    + "`question` varchar(100) NOT NULL,"
                    + "PRIMARY KEY  (`sq_id`),"
                    + "KEY `FK_tbl_securityquestions_1` (`users_id`),"
                    + "CONSTRAINT `FK_tbl_securityquestions_1` FOREIGN KEY (`users_id`) REFERENCES `tbl_users` (`users_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_3(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_curriculums` ( "
                    + "`curriculums_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`programName` varchar(100) NOT NULL, "
                    + "`createdBy` int(10) unsigned NOT NULL, "
                    + "`createdAt` varchar(45) NOT NULL, "
                    + "`status` varchar(45) NOT NULL, "
                    + "`inUsed` varchar(45) NOT NULL, "
                    + "`curriculumYear` varchar(45) NOT NULL, "
                    + "PRIMARY KEY  (`curriculums_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_4(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_course` ( "
                    + "`course_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`curriculums_id` int(10) unsigned NOT NULL, "
                    + "`courseName` varchar(100) NOT NULL, "
                    + "`courseAcronym` varchar(45) NOT NULL, "
                    + "PRIMARY KEY  (`course_id`), "
                    + "KEY `FK_tbl_course_1` (`curriculums_id`), "
                    + "CONSTRAINT `FK_tbl_course_1` FOREIGN KEY (`curriculums_id`) REFERENCES `tbl_curriculums` (`curriculums_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;"
                    + "", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_5(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_subjects` ( "
                    + "`subjects_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`curriculums_id` int(10) unsigned NOT NULL, "
                    + "`course_id` int(10) unsigned NOT NULL, "
                    + "`subjectCode` varchar(45) NOT NULL, "
                    + "`subjectDescription` varchar(100) NOT NULL, "
                    + "`lectureHours` int(10) unsigned NOT NULL, "
                    + "`laboratoryHours` int(10) unsigned NOT NULL, "
                    + "`units` int(10) unsigned NOT NULL, "
                    + "`yearLevel` int(10) unsigned NOT NULL, "
                    + "`course` varchar(45) NOT NULL, "
                    + "`semester` varchar(45) NOT NULL, "
                    + "PRIMARY KEY  USING BTREE (`subjects_id`), "
                    + "KEY `FK_tbl_subjects_1` (`curriculums_id`), "
                    + "KEY `FK_tbl_subjects_2` (`course_id`), "
                    + "CONSTRAINT `FK_tbl_subjects_1` FOREIGN KEY (`curriculums_id`) REFERENCES `tbl_curriculums` (`curriculums_id`), "
                    + "CONSTRAINT `FK_tbl_subjects_2` FOREIGN KEY (`course_id`) REFERENCES `tbl_course` (`course_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_6(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_preferredschedules` ("
                    + "`preferredSchedule_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`users_id` int(10) unsigned NOT NULL,"
                    + "`startTime` varchar(45) NOT NULL,"
                    + "`endTime` varchar(45) NOT NULL,"
                    + "`ps_Day` varchar(45) NOT NULL,"
                    + "PRIMARY KEY  USING BTREE (`preferredSchedule_id`),"
                    + "KEY `FK_tbl_preferredschedules_1` (`users_id`),"
                    + "CONSTRAINT `FK_tbl_preferredschedules_1` FOREIGN KEY (`users_id`) REFERENCES `tbl_users` (`users_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_7(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_preferredsubjects` ("
                    + "`preferredSubjects_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`users_id` int(10) unsigned NOT NULL,"
                    + "`subjects_id` int(10) unsigned NOT NULL,"
                    + "`semester` varchar(45) NOT NULL,"
                    + "`schoolYear` varchar(45) NOT NULL,"
                    + "PRIMARY KEY  (`preferredSubjects_id`),"
                    + "KEY `FK_tbl_preferredsubjects_1` (`users_id`),"
                    + "KEY `FK_tbl_preferredsubjects_2` (`subjects_id`),"
                    + "CONSTRAINT `FK_tbl_preferredsubjects_1` FOREIGN KEY (`users_id`) REFERENCES `tbl_users` (`users_id`),"
                    + "CONSTRAINT `FK_tbl_preferredsubjects_2` FOREIGN KEY (`subjects_id`) REFERENCES `tbl_subjects` (`subjects_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;"
                    + "", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_8(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_sections` ("
                    + "`section_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`course` varchar(45) NOT NULL,"
                    + "`year` int(10) unsigned NOT NULL,"
                    + "`section` varchar(45) NOT NULL,"
                    + "PRIMARY KEY  (`section_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;"
                    + "", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_9(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_room` ("
                    + "`room_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`roomCode` varchar(45) NOT NULL,"
                    + "`roomName` varchar(45) NOT NULL,"
                    + "`roomSlots` int(10) unsigned NOT NULL,"
                    + "`roomStatus` varchar(45) NOT NULL,"
                    + "PRIMARY KEY  (`room_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_10(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_students_scheduled` ( "
                    + "`students_scheduled_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`curriculums_id` int(10) unsigned NOT NULL, "
                    + "`course` varchar(45) NOT NULL, "
                    + "`year` varchar(45) NOT NULL, "
                    + "`section` varchar(45) NOT NULL, "
                    + "`scheduledBy` varchar(45) NOT NULL, "
                    + "`scheduledDate` datetime NOT NULL, "
                    + "`semester` varchar(45) NOT NULL, "
                    + "`schoolYear` varchar(45) NOT NULL, "
                    + "`room` varchar(45) NOT NULL, "
                    + "`subjectCode` varchar(45) NOT NULL, "
                    + "`subjectDescription` varchar(200) NOT NULL, "
                    + "`professor` varchar(100) NOT NULL, "
                    + "`scheduledStartTime` varchar(45) NOT NULL, "
                    + "`scheduledEndTime` varchar(45) NOT NULL, "
                    + "`scheduledDay` varchar(45) NOT NULL, "
                    + "`lecHours` varchar(45) NOT NULL, "
                    + "`labHours` varchar(45) NOT NULL, "
                    + "`units` varchar(45) NOT NULL, "
                    + "PRIMARY KEY  USING BTREE (`students_scheduled_id`), "
                    + "KEY `FK_tbl_students_scheduled_1` (`curriculums_id`), "
                    + "CONSTRAINT `FK_tbl_students_scheduled_1` FOREIGN KEY (`curriculums_id`) REFERENCES `tbl_curriculums` (`curriculums_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=397 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_11(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_room_scheduled` ("
                    + "`room_scheduled_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`roomCode` varchar(45) NOT NULL,"
                    + "`roomStartTime` varchar(45) NOT NULL,"
                    + "`roomEndTime` varchar(45) NOT NULL,"
                    + "`roomDay` varchar(45) NOT NULL,"
                    + "`assignedProfessor` varchar(100) NOT NULL,"
                    + "`subjectCode` varchar(45) NOT NULL,"
                    + "`course` varchar(45) NOT NULL,"
                    + "`year` varchar(45) NOT NULL,"
                    + "`section` varchar(45) NOT NULL,"
                    + "`semester` varchar(45) NOT NULL,"
                    + "`schoolYear` varchar(45) NOT NULL,"
                    + "`curriculums_id` int(10) unsigned NOT NULL,"
                    + "PRIMARY KEY  (`room_scheduled_id`),"
                    + "KEY `FK_tbl_room_scheduled_1` (`curriculums_id`),"
                    + "CONSTRAINT `FK_tbl_room_scheduled_1` FOREIGN KEY (`curriculums_id`) REFERENCES `tbl_curriculums` (`curriculums_id`)"
                    + ") ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_12(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_professor_scheduled` ("
                    + "`professorsScheduled_id` int(10) unsigned NOT NULL auto_increment,"
                    + "`curriculumns_id` int(10) unsigned NOT NULL,"
                    + "`course` varchar(45) NOT NULL,"
                    + "`year` varchar(45) NOT NULL,"
                    + "`section` varchar(45) NOT NULL,"
                    + "`scheduledBy` varchar(45) NOT NULL,"
                    + "`scheduledDate` varchar(45) NOT NULL,"
                    + "`semester` varchar(45) NOT NULL,"
                    + "`schoolYear` varchar(45) NOT NULL,"
                    + "`room` varchar(45) NOT NULL,"
                    + "`subjectCode` varchar(45) NOT NULL,"
                    + "`subjectDescription` varchar(100) NOT NULL,"
                    + "`professor` varchar(100) NOT NULL,"
                    + "`scheduledStartTime` varchar(45) NOT NULL,"
                    + "`scheduledEndTime` varchar(45) NOT NULL,"
                    + "`scheduledDay` varchar(45) NOT NULL,"
                    + "PRIMARY KEY  (`professorsScheduled_id`)"
                    + ") ENGINE=InnoDB DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }

        private void DBtable_13(string name, string conn)
        {
            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("CREATE TABLE  `"
                    + name +"`.`tbl_audittrail` ( "
                    + "`auditTrail_id` int(10) unsigned NOT NULL auto_increment, "
                    + "`dateTime` datetime NOT NULL, "
                    + "`username` varchar(100) NOT NULL, "
                    + "`action` varchar(45) NOT NULL, "
                    + "`description` varchar(100) NOT NULL, "
                    + "PRIMARY KEY  (`auditTrail_id`) "
                    + ") ENGINE=InnoDB AUTO_INCREMENT=98 DEFAULT CHARSET=latin1;", dbconn))
                {
                    dbconn.Open();
                    cmd.ExecuteNonQuery();
                    dbconn.Close();
                }
            }
        }
    }
}
