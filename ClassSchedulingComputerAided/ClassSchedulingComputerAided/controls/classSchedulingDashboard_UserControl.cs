using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ClassSchedulingComputerAided
{
    public partial class classSchedulingDashboard_UserControl : UserControl
    {
        public classSchedulingDashboard_UserControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        

        private void lblLecHours_4_Click(object sender, EventArgs e)
        {

        }

        private void cboDay_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEnd_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboStart_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_LabHours_4_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_4_Click(object sender, EventArgs e)
        {

        }

        private void lblUnits_4_Click(object sender, EventArgs e)
        {

        }

        private void lblCode_4_Click(object sender, EventArgs e)
        {

        }

        public void LoadSaveData()//to load the set data from xml filetype
        {
            //to set the name for the file save
            string name = cboCourse.SelectedItem.ToString();
            name += cboYear.SelectedItem.ToString();
            name += cboSection.SelectedItem.ToString();
            name += cboSemester.SelectedItem.ToString();
            name += cboSchoolYear.SelectedItem.ToString();
            name += cboCurriculum.SelectedItem.ToString();

            if (File.Exists(name + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SaveInfoData));
                FileStream read = new FileStream(name + ".xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveInfoData sid = (SaveInfoData)xs.Deserialize(read);

                cboProfessor_1.Text = sid.Prof_1;
                cboStart_1.SelectedIndex = sid.Start_1;
                cboEnd_1.SelectedIndex = sid.End_1;
                cboDay_1.SelectedIndex = sid.Day_1;
                cboRoom_1.Text = sid.Room_1;

                cboProfessor_2.Text = sid.Prof_2;
                cboStart_2.SelectedIndex = sid.Start_2;
                cboEnd_2.SelectedIndex = sid.End_2;
                cboDay_2.SelectedIndex = sid.Day_2;
                cboRoom_2.Text = sid.Room_2;

                cboProfessor_3.Text = sid.Prof_3;
                cboStart_3.SelectedIndex = sid.Start_3;
                cboEnd_3.SelectedIndex = sid.End_3;
                cboDay_3.SelectedIndex = sid.Day_3;
                cboRoom_3.Text = sid.Room_3;

                cboProfessor_4.Text = sid.Prof_4;
                cboStart_4.SelectedIndex = sid.Start_4;
                cboEnd_4.SelectedIndex = sid.End_4;
                cboDay_4.SelectedIndex = sid.Day_4;
                cboRoom_4.Text = sid.Room_4;

                cboProfessor_5.Text = sid.Prof_5;
                cboStart_5.SelectedIndex = sid.Start_5;
                cboEnd_5.SelectedIndex = sid.End_5;
                cboDay_5.SelectedIndex = sid.Day_5;
                cboRoom_5.Text = sid.Room_5;

                cboProfessor_6.Text = sid.Prof_6;
                cboStart_6.SelectedIndex = sid.Start_6;
                cboEnd_6.SelectedIndex = sid.End_6;
                cboDay_6.SelectedIndex = sid.Day_6;
                cboRoom_6.Text = sid.Room_6;

                cboProfessor_7.Text = sid.Prof_7;
                cboStart_7.SelectedIndex = sid.Start_7;
                cboEnd_7.SelectedIndex = sid.End_7;
                cboDay_7.SelectedIndex = sid.Day_7;
                cboRoom_7.Text = sid.Room_7;

                cboProfessor_8.Text = sid.Prof_8;
                cboStart_8.SelectedIndex = sid.Start_8;
                cboEnd_8.SelectedIndex = sid.End_8;
                cboDay_8.SelectedIndex = sid.Day_8;
                cboRoom_8.Text = sid.Room_8;

                cboProfessor_9.Text = sid.Prof_9;
                cboStart_9.SelectedIndex = sid.Start_9;
                cboEnd_9.SelectedIndex = sid.End_9;
                cboDay_9.SelectedIndex = sid.Day_9;
                cboRoom_9.Text = sid.Room_9;

                cboProfessor_10.Text = sid.Prof_10;
                cboStart_10.SelectedIndex = sid.Start_10;
                cboEnd_10.SelectedIndex = sid.End_10;
                cboDay_10.SelectedIndex = sid.Day_10;
                cboRoom_10.Text = sid.Room_10;
            }
        }

        

        public void ListCourseCode()//list For CourseCode
        {
            lblCode_1.Text = SubjectForStudents.CourseCode[0];
            lblCode_2.Text = SubjectForStudents.CourseCode[1];
            lblCode_3.Text = SubjectForStudents.CourseCode[2];
            lblCode_4.Text = SubjectForStudents.CourseCode[3];
            lblCode_5.Text = SubjectForStudents.CourseCode[4];
            lblCode_6.Text = SubjectForStudents.CourseCode[5];
            lblCode_7.Text = SubjectForStudents.CourseCode[6];
            lblCode_8.Text = SubjectForStudents.CourseCode[7];
            lblCode_9.Text = SubjectForStudents.CourseCode[8];
            lblCode_10.Text = SubjectForStudents.CourseCode[9];

            lblCode_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            lblCode_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            lblCode_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            lblCode_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            lblCode_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            lblCode_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            lblCode_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            lblCode_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            lblCode_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            lblCode_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListSubjectDescription()//list for description
        {
            lblDescription_1.Text = SubjectForStudents.SubjectDescription[0];
            lblDescription_2.Text = SubjectForStudents.SubjectDescription[1];
            lblDescription_3.Text = SubjectForStudents.SubjectDescription[2];
            lblDescription_4.Text = SubjectForStudents.SubjectDescription[3];
            lblDescription_5.Text = SubjectForStudents.SubjectDescription[4];
            lblDescription_6.Text = SubjectForStudents.SubjectDescription[5];
            lblDescription_7.Text = SubjectForStudents.SubjectDescription[6];
            lblDescription_8.Text = SubjectForStudents.SubjectDescription[7];
            lblDescription_9.Text = SubjectForStudents.SubjectDescription[8];
            lblDescription_10.Text = SubjectForStudents.SubjectDescription[9];

            lblDescription_1.Visible = (SubjectForStudents.SubjectDescription[0] != "") ? true : false;
            lblDescription_2.Visible = (SubjectForStudents.SubjectDescription[1] != "") ? true : false;
            lblDescription_3.Visible = (SubjectForStudents.SubjectDescription[2] != "") ? true : false;
            lblDescription_4.Visible = (SubjectForStudents.SubjectDescription[3] != "") ? true : false;
            lblDescription_5.Visible = (SubjectForStudents.SubjectDescription[4] != "") ? true : false;
            lblDescription_6.Visible = (SubjectForStudents.SubjectDescription[5] != "") ? true : false;
            lblDescription_7.Visible = (SubjectForStudents.SubjectDescription[6] != "") ? true : false;
            lblDescription_8.Visible = (SubjectForStudents.SubjectDescription[7] != "") ? true : false;
            lblDescription_9.Visible = (SubjectForStudents.SubjectDescription[8] != "") ? true : false;
            lblDescription_10.Visible = (SubjectForStudents.SubjectDescription[9] != "") ? true : false;
        }

        public void ListUnits()//list for units
        {
            lblUnits_1.Text = SubjectForStudents.Units[0];
            lblUnits_2.Text = SubjectForStudents.Units[1];
            lblUnits_3.Text = SubjectForStudents.Units[2];
            lblUnits_4.Text = SubjectForStudents.Units[3];
            lblUnits_5.Text = SubjectForStudents.Units[4];
            lblUnits_6.Text = SubjectForStudents.Units[5];
            lblUnits_7.Text = SubjectForStudents.Units[6];
            lblUnits_8.Text = SubjectForStudents.Units[7];
            lblUnits_9.Text = SubjectForStudents.Units[8];
            lblUnits_10.Text = SubjectForStudents.Units[9];

            lblUnits_1.Visible = (SubjectForStudents.Units[0] != "") ? true : false;
            lblUnits_2.Visible = (SubjectForStudents.Units[1] != "") ? true : false;
            lblUnits_3.Visible = (SubjectForStudents.Units[2] != "") ? true : false;
            lblUnits_4.Visible = (SubjectForStudents.Units[3] != "") ? true : false;
            lblUnits_5.Visible = (SubjectForStudents.Units[4] != "") ? true : false;
            lblUnits_6.Visible = (SubjectForStudents.Units[5] != "") ? true : false;
            lblUnits_7.Visible = (SubjectForStudents.Units[6] != "") ? true : false;
            lblUnits_8.Visible = (SubjectForStudents.Units[7] != "") ? true : false;
            lblUnits_9.Visible = (SubjectForStudents.Units[8] != "") ? true : false;
            lblUnits_10.Visible = (SubjectForStudents.Units[9] != "") ? true : false;
        }

        public void ListLecHrs()//list for lecture hours
        {
            lblLecHours_1.Text = SubjectForStudents.LecHrs[0];
            lblLecHours_2.Text = SubjectForStudents.LecHrs[1];
            lblLecHours_3.Text = SubjectForStudents.LecHrs[2];
            lblLecHours_4.Text = SubjectForStudents.LecHrs[3];
            lblLecHours_5.Text = SubjectForStudents.LecHrs[4];
            lblLecHours_6.Text = SubjectForStudents.LecHrs[5];
            lblLecHours_7.Text = SubjectForStudents.LecHrs[6];
            lblLecHours_8.Text = SubjectForStudents.LecHrs[7];
            lblLecHours_9.Text = SubjectForStudents.LecHrs[8];
            lblLecHours_10.Text = SubjectForStudents.LecHrs[9];

            lblLecHours_1.Visible = (SubjectForStudents.LecHrs[0] != "") ? true : false;
            lblLecHours_2.Visible = (SubjectForStudents.LecHrs[1] != "") ? true : false;
            lblLecHours_3.Visible = (SubjectForStudents.LecHrs[2] != "") ? true : false;
            lblLecHours_4.Visible = (SubjectForStudents.LecHrs[3] != "") ? true : false;
            lblLecHours_5.Visible = (SubjectForStudents.LecHrs[4] != "") ? true : false;
            lblLecHours_6.Visible = (SubjectForStudents.LecHrs[5] != "") ? true : false;
            lblLecHours_7.Visible = (SubjectForStudents.LecHrs[6] != "") ? true : false;
            lblLecHours_8.Visible = (SubjectForStudents.LecHrs[7] != "") ? true : false;
            lblLecHours_9.Visible = (SubjectForStudents.LecHrs[8] != "") ? true : false;
            lblLecHours_10.Visible = (SubjectForStudents.LecHrs[9] != "") ? true : false;
        }

        public void ListlabHrs()//List for laboratory hours
        {
            lbl_LabHours_1.Text = SubjectForStudents.LabHrs[0];
            lbl_LabHours_2.Text = SubjectForStudents.LabHrs[1];
            lbl_LabHours_3.Text = SubjectForStudents.LabHrs[2];
            lbl_LabHours_4.Text = SubjectForStudents.LabHrs[3];
            lbl_LabHours_5.Text = SubjectForStudents.LabHrs[4];
            lbl_LabHours_6.Text = SubjectForStudents.LabHrs[5];
            lbl_LabHours_7.Text = SubjectForStudents.LabHrs[6];
            lbl_LabHours_8.Text = SubjectForStudents.LabHrs[7];
            lbl_LabHours_9.Text = SubjectForStudents.LabHrs[8];
            lbl_LabHours_10.Text = SubjectForStudents.LabHrs[9];

            lbl_LabHours_1.Visible = (SubjectForStudents.LabHrs[0] != "") ? true : false;
            lbl_LabHours_2.Visible = (SubjectForStudents.LabHrs[1] != "") ? true : false;
            lbl_LabHours_3.Visible = (SubjectForStudents.LabHrs[2] != "") ? true : false;
            lbl_LabHours_4.Visible = (SubjectForStudents.LabHrs[3] != "") ? true : false;
            lbl_LabHours_5.Visible = (SubjectForStudents.LabHrs[4] != "") ? true : false;
            lbl_LabHours_6.Visible = (SubjectForStudents.LabHrs[5] != "") ? true : false;
            lbl_LabHours_7.Visible = (SubjectForStudents.LabHrs[6] != "") ? true : false;
            lbl_LabHours_8.Visible = (SubjectForStudents.LabHrs[7] != "") ? true : false;
            lbl_LabHours_9.Visible = (SubjectForStudents.LabHrs[8] != "") ? true : false;
            lbl_LabHours_10.Visible = (SubjectForStudents.LabHrs[9] != "") ? true : false;
        }

        public void ListProfessors()//list of professors referring to its course code
        {
            cboProfessor_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboProfessor_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboProfessor_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboProfessor_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboProfessor_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboProfessor_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboProfessor_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboProfessor_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboProfessor_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboProfessor_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListStartTime()//list of start time referring to its course code
        {
            cboStart_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboStart_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboStart_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboStart_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboStart_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboStart_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboStart_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboStart_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboStart_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboStart_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListEndTime()//list of End time referring to its course code
        {
            cboEnd_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboEnd_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboEnd_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboEnd_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboEnd_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboEnd_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboEnd_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboEnd_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboEnd_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboEnd_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListDay()//list of Day referring to its course code
        {
            cboDay_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboDay_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboDay_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboDay_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboDay_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboDay_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboDay_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboDay_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboDay_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboDay_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListRoom()//list of Room referring to its course code
        {
            cboRoom_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            cboRoom_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            cboRoom_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            cboRoom_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            cboRoom_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            cboRoom_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            cboRoom_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            cboRoom_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            cboRoom_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            cboRoom_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        public void ListSet()//List of button'set' referring to its course code
        {
            btnSet_1.Visible = (SubjectForStudents.CourseCode[0] != "") ? true : false;
            btnSet_2.Visible = (SubjectForStudents.CourseCode[1] != "") ? true : false;
            btnSet_3.Visible = (SubjectForStudents.CourseCode[2] != "") ? true : false;
            btnSet_4.Visible = (SubjectForStudents.CourseCode[3] != "") ? true : false;
            btnSet_5.Visible = (SubjectForStudents.CourseCode[4] != "") ? true : false;
            btnSet_6.Visible = (SubjectForStudents.CourseCode[5] != "") ? true : false;
            btnSet_7.Visible = (SubjectForStudents.CourseCode[6] != "") ? true : false;
            btnSet_8.Visible = (SubjectForStudents.CourseCode[7] != "") ? true : false;
            btnSet_9.Visible = (SubjectForStudents.CourseCode[8] != "") ? true : false;
            btnSet_10.Visible = (SubjectForStudents.CourseCode[9] != "") ? true : false;
        }

        private void classSchedulingDashboard_UserControl_Load(object sender, EventArgs e)
        {
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Add(rttc);

            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Add(ptt);

            cboSemester.Items.Add("1ST");
            cboSemester.Items.Add("2ND");
            cboSemester.Items.Add("3RD");

            //to fill the school year
            string sy = "";
            DateTime dt = new DateTime(2015, DateTime.Now.Month, DateTime.Now.Day);
            bool flag = true;
            while (flag)
            {
                if (dt.Year != DateTime.Now.Year)
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                }
                else {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                    flag = false;
                }
            }
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboYear.Items.Clear();
            cboYear.Text = "";
            for (int x = 0; x < md.getCourseYear(cboCourse.SelectedItem.ToString()).Length; x++)
                if (md.getCourseYear(cboCourse.SelectedItem.ToString()).GetValue(x).ToString() != "")
                    cboYear.Items.Add(md.getCourseYear(cboCourse.SelectedItem.ToString()).GetValue(x).ToString());

            cboSection.Items.Clear();
        }

        public void SetToEnabled()//method to set button 'set' to enabled
        {
            //set btnSet to Enabled
            btnSet_1.Enabled = true;
            btnSet_2.Enabled = true;
            btnSet_3.Enabled = true;
            btnSet_4.Enabled = true;
            btnSet_5.Enabled = true;
            btnSet_6.Enabled = true;
            btnSet_7.Enabled = true;
            btnSet_8.Enabled = true;
            btnSet_9.Enabled = true;
            btnSet_10.Enabled = true;
        }

        public void SetComboBoxToDisabled()//method to set comboxes to disabled
        {
            //set cboprofessor to disabled
            cboProfessor_1.Enabled = false;
            cboProfessor_2.Enabled = false;
            cboProfessor_3.Enabled = false;
            cboProfessor_4.Enabled = false;
            cboProfessor_5.Enabled = false;
            cboProfessor_6.Enabled = false;
            cboProfessor_7.Enabled = false;
            cboProfessor_8.Enabled = false;
            cboProfessor_9.Enabled = false;
            cboProfessor_10.Enabled = false;
            //set cboStart to disabled
            cboStart_1.Enabled = false;
            cboStart_2.Enabled = false;
            cboStart_3.Enabled = false;
            cboStart_4.Enabled = false;
            cboStart_5.Enabled = false;
            cboStart_6.Enabled = false;
            cboStart_7.Enabled = false;
            cboStart_8.Enabled = false;
            cboStart_9.Enabled = false;
            cboStart_10.Enabled = false;
            //set cboEnd to disabled
            cboEnd_1.Enabled = false;
            cboEnd_2.Enabled = false;
            cboEnd_3.Enabled = false;
            cboEnd_4.Enabled = false;
            cboEnd_5.Enabled = false;
            cboEnd_6.Enabled = false;
            cboEnd_7.Enabled = false;
            cboEnd_8.Enabled = false;
            cboEnd_9.Enabled = false;
            cboEnd_10.Enabled = false;
            //set cboDay to disabled
            cboDay_1.Enabled = false;
            cboDay_2.Enabled = false;
            cboDay_3.Enabled = false;
            cboDay_4.Enabled = false;
            cboDay_5.Enabled = false;
            cboDay_6.Enabled = false;
            cboDay_7.Enabled = false;
            cboDay_8.Enabled = false;
            cboDay_9.Enabled = false;
            cboDay_10.Enabled = false;
            //set cboRoom to disabled
            cboRoom_1.Enabled = false;
            cboRoom_2.Enabled = false;
            cboRoom_3.Enabled = false;
            cboRoom_4.Enabled = false;
            cboRoom_5.Enabled = false;
            cboRoom_6.Enabled = false;
            cboRoom_7.Enabled = false;
            cboRoom_8.Enabled = false;
            cboRoom_9.Enabled = false;
            cboRoom_10.Enabled = false;
            //set btnSet to Disabled
            btnSet_1.Enabled = false;
            btnSet_2.Enabled = false;
            btnSet_3.Enabled = false;
            btnSet_4.Enabled = false;
            btnSet_5.Enabled = false;
            btnSet_6.Enabled = false;
            btnSet_7.Enabled = false;
            btnSet_8.Enabled = false;
            btnSet_9.Enabled = false;
            btnSet_10.Enabled = false;
        }

        private void btnSet_1_Click(object sender, EventArgs e)
        {
            if (btnSet_1.Text == "SET")
            {
                //clear all listed items
                cboProfessor_1.Items.Clear();
                cboRoom_1.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_1.Enabled = true;
                cboProfessor_1.Enabled = true;
                cboStart_1.Enabled = true;
                cboEnd_1.Enabled = true;
                cboDay_1.Enabled = true;
                cboRoom_1.Enabled = true;
                btnSet_1.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for(int x = 0; x < 50; x++)//set to 50 loop
                {
                    if(SubjectForStudents.Rooms[x] != "")
                        cboRoom_1.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_1.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_1.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_1.Text;
                ClassSchedule_Data.roomCode = cboRoom_1.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_1.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_1.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_2_Click(object sender, EventArgs e)
        {
            if (btnSet_2.Text == "SET")
            {
                //clear all listed items
                cboProfessor_2.Items.Clear();
                cboRoom_2.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_2.Enabled = true;
                cboProfessor_2.Enabled = true;
                cboStart_2.Enabled = true;
                cboEnd_2.Enabled = true;
                cboDay_2.Enabled = true;
                cboRoom_2.Enabled = true;
                btnSet_2.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_2.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_2.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_2.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_2.Text;
                ClassSchedule_Data.roomCode = cboRoom_2.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_2.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_2.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_3_Click(object sender, EventArgs e)
        {
            if (btnSet_3.Text == "SET")
            {
                //clear all listed items
                cboProfessor_3.Items.Clear();
                cboRoom_3.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_3.Enabled = true;
                cboProfessor_3.Enabled = true;
                cboStart_3.Enabled = true;
                cboEnd_3.Enabled = true;
                cboDay_3.Enabled = true;
                cboRoom_3.Enabled = true;
                btnSet_3.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_3.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_3.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_3.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_3.Text;
                ClassSchedule_Data.roomCode = cboRoom_3.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_3.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_3.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_4_Click(object sender, EventArgs e)
        {
            if (btnSet_4.Text == "SET")
            {
                //clear all listed items
                cboProfessor_4.Items.Clear();
                cboRoom_4.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_4.Enabled = true;
                cboProfessor_4.Enabled = true;
                cboStart_4.Enabled = true;
                cboEnd_4.Enabled = true;
                cboDay_4.Enabled = true;
                cboRoom_4.Enabled = true;
                btnSet_4.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_4.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_4.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_4.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_4.Text;
                ClassSchedule_Data.roomCode = cboRoom_4.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_4.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_4.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_5_Click(object sender, EventArgs e)
        {
            if (btnSet_5.Text == "SET")
            {
                //clear all listed items
                cboProfessor_5.Items.Clear();
                cboRoom_5.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_5.Enabled = true;
                cboProfessor_5.Enabled = true;
                cboStart_5.Enabled = true;
                cboEnd_5.Enabled = true;
                cboDay_5.Enabled = true;
                cboRoom_5.Enabled = true;
                btnSet_5.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_5.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_5.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_5.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_5.Text;
                ClassSchedule_Data.roomCode = cboRoom_5.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_5.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_5.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_6_Click(object sender, EventArgs e)
        {
            if (btnSet_6.Text == "SET")
            {
                //clear all listed items
                cboProfessor_6.Items.Clear();
                cboRoom_6.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_6.Enabled = true;
                cboProfessor_6.Enabled = true;
                cboStart_6.Enabled = true;
                cboEnd_6.Enabled = true;
                cboDay_6.Enabled = true;
                cboRoom_6.Enabled = true;
                btnSet_6.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_6.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_6.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_6.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_6.Text;
                ClassSchedule_Data.roomCode = cboRoom_6.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_6.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_6.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_7_Click(object sender, EventArgs e)
        {
            if (btnSet_7.Text == "SET")
            {
                //clear all listed items
                cboProfessor_7.Items.Clear();
                cboRoom_7.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_7.Enabled = true;
                cboProfessor_7.Enabled = true;
                cboStart_7.Enabled = true;
                cboEnd_7.Enabled = true;
                cboDay_7.Enabled = true;
                cboRoom_7.Enabled = true;
                btnSet_7.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_7.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_7.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_7.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_7.Text;
                ClassSchedule_Data.roomCode = cboRoom_7.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_7.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_7.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_8_Click(object sender, EventArgs e)
        {
            if (btnSet_8.Text == "SET")
            {
                //clear all listed items
                cboProfessor_8.Items.Clear();
                cboRoom_8.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_8.Enabled = true;
                cboProfessor_8.Enabled = true;
                cboStart_8.Enabled = true;
                cboEnd_8.Enabled = true;
                cboDay_8.Enabled = true;
                cboRoom_8.Enabled = true;
                btnSet_8.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_8.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_8.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_8.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_8.Text;
                ClassSchedule_Data.roomCode = cboRoom_8.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_8.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_8.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_9_Click(object sender, EventArgs e)
        {
            if (btnSet_9.Text == "SET")
            {
                //clear all listed items
                cboProfessor_9.Items.Clear();
                cboRoom_9.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_9.Enabled = true;
                cboProfessor_9.Enabled = true;
                cboStart_9.Enabled = true;
                cboEnd_9.Enabled = true;
                cboDay_9.Enabled = true;
                cboRoom_9.Enabled = true;
                btnSet_9.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_9.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_9.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_9.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_9.Text;
                ClassSchedule_Data.roomCode = cboRoom_9.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_9.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_9.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void btnSet_10_Click(object sender, EventArgs e)
        {
            if (btnSet_10.Text == "SET")
            {
                //clear all listed items
                cboProfessor_10.Items.Clear();
                cboRoom_10.Items.Clear();

                SetComboBoxToDisabled();
                btnSet_10.Enabled = true;
                cboProfessor_10.Enabled = true;
                cboStart_10.Enabled = true;
                cboEnd_10.Enabled = true;
                cboDay_10.Enabled = true;
                cboRoom_10.Enabled = true;
                btnSet_10.Text = "OK";
                btnSAVE.Enabled = false;

                //to list all Active Rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboRoom_10.Items.Add(SubjectForStudents.Rooms[x]);
                }
                //to list all professors on that particular courseCode
                SubjectForStudents.Professors = new string[100];
                md.CSD_ListProfDedicated(lblCode_10.Text);
                for (int x = 0; x < 100; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Professors[x] != "")
                        cboProfessor_10.Items.Add(SubjectForStudents.Professors[x]);
                }

                //to load all data if already
                ClassSchedule_Data.professors_name = cboProfessor_10.Text;
                ClassSchedule_Data.roomCode = cboRoom_10.Text;

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(cboProfessor_10.Text);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                SetComboBoxToDisabled();
                SetToEnabled();
                btnSet_10.Text = "SET";
                btnSAVE.Enabled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboProfessor_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_1.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_1.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_2.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_2.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_3.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_3.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_4.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_4.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_5.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_5.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_6.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_6.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_7.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_7.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_8.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_8.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_9.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_9.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_10.SelectedItem.ToString());
            ClassSchedule_Data.professors_name = cboProfessor_10.SelectedItem.ToString();
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSection.Items.Clear();
            cboSection.Text = "";
            for (int x = 0; x < md.getCourseSection(cboCourse.SelectedItem.ToString(), cboYear.SelectedItem.ToString()).Length; x++)
                if (md.getCourseSection(cboCourse.SelectedItem.ToString(), cboYear.SelectedItem.ToString()).GetValue(x).ToString() != "")
                    cboSection.Items.Add(md.getCourseSection(cboCourse.SelectedItem.ToString(), cboYear.SelectedItem.ToString()).GetValue(x).ToString());
        }

        private void cboRoom_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //md.CSD_get_professors_id(cboProfessor_1.SelectedItem.ToString());
            //ClassSchedule_Data.professors_name = cboProfessor_1.SelectedItem.ToString();
            ClassSchedule_Data.roomCode = cboRoom_1.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_2.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_3.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_4.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_5.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_6.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_7.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_8.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_9.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_10.SelectedItem.ToString();
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        public void SaveData()
        {
            SaveInfoData sid = new SaveInfoData();
            sid.Prof_1 = cboProfessor_1.Text;
            sid.Start_1 = cboStart_1.SelectedIndex;
            sid.End_1 = cboEnd_1.SelectedIndex;
            sid.Day_1 = cboDay_1.SelectedIndex;
            sid.Room_1 = cboRoom_1.Text;

            sid.Prof_2 = cboProfessor_2.Text;
            sid.Start_2 = cboStart_2.SelectedIndex;
            sid.End_2 = cboEnd_2.SelectedIndex;
            sid.Day_2 = cboDay_2.SelectedIndex;
            sid.Room_2 = cboRoom_2.Text;

            sid.Prof_3 = cboProfessor_3.Text;
            sid.Start_3 = cboStart_3.SelectedIndex;
            sid.End_3 = cboEnd_3.SelectedIndex;
            sid.Day_3 = cboDay_3.SelectedIndex;
            sid.Room_3 = cboRoom_3.Text;

            sid.Prof_4 = cboProfessor_4.Text;
            sid.Start_4 = cboStart_4.SelectedIndex;
            sid.End_4 = cboEnd_4.SelectedIndex;
            sid.Day_4 = cboDay_4.SelectedIndex;
            sid.Room_4 = cboRoom_4.Text;

            sid.Prof_5 = cboProfessor_5.Text;
            sid.Start_5 = cboStart_5.SelectedIndex;
            sid.End_5 = cboEnd_5.SelectedIndex;
            sid.Day_5 = cboDay_5.SelectedIndex;
            sid.Room_5 = cboRoom_5.Text;

            sid.Prof_6 = cboProfessor_6.Text;
            sid.Start_6 = cboStart_6.SelectedIndex;
            sid.End_6 = cboEnd_6.SelectedIndex;
            sid.Day_6 = cboDay_6.SelectedIndex;
            sid.Room_6 = cboRoom_6.Text;

            sid.Prof_7 = cboProfessor_7.Text;
            sid.Start_7 = cboStart_7.SelectedIndex;
            sid.End_7 = cboEnd_7.SelectedIndex;
            sid.Day_7 = cboDay_7.SelectedIndex;
            sid.Room_7 = cboRoom_7.Text;

            sid.Prof_8 = cboProfessor_8.Text;
            sid.Start_8 = cboStart_8.SelectedIndex;
            sid.End_8 = cboEnd_8.SelectedIndex;
            sid.Day_8 = cboDay_8.SelectedIndex;
            sid.Room_8 = cboRoom_8.Text;

            sid.Prof_9 = cboProfessor_9.Text;
            sid.Start_9 = cboStart_9.SelectedIndex;
            sid.End_9 = cboEnd_9.SelectedIndex;
            sid.Day_9 = cboDay_9.SelectedIndex;
            sid.Room_9 = cboRoom_9.Text;

            sid.Prof_10 = cboProfessor_10.Text;
            sid.Start_10 = cboStart_10.SelectedIndex;
            sid.End_10 = cboEnd_10.SelectedIndex;
            sid.Day_10 = cboDay_10.SelectedIndex;
            sid.Room_10 = cboRoom_10.Text;

            //to set the name for the file save
            string name = cboCourse.SelectedItem.ToString();
            name += cboYear.SelectedItem.ToString();
            name += cboSection.SelectedItem.ToString();
            name += cboSemester.SelectedItem.ToString();
            name += cboSchoolYear.SelectedItem.ToString();
            name += cboCurriculum.SelectedItem.ToString();
            SaveXML.SaveData(sid, name + ".xml");
        }

        public void SaveScheduled()
        {
            StudentsScheduled.curriculumsName = cboCurriculum.SelectedItem.ToString();
            StudentsScheduled.course = cboCourse.SelectedItem.ToString();
            StudentsScheduled.year = cboYear.SelectedItem.ToString();
            StudentsScheduled.section = cboSection.SelectedItem.ToString();
            StudentsScheduled.semester = cboSemester.SelectedItem.ToString();
            StudentsScheduled.schoolYear = cboSchoolYear.SelectedItem.ToString();
            StudentsScheduled.CourseCode = new string[11];
            StudentsScheduled.SubjectDescription = new string[11];
            StudentsScheduled.Rooms = new string[11];
            StudentsScheduled.Professors = new string[11];
            StudentsScheduled.startTime = new string[11];
            StudentsScheduled.endTime = new string[11];
            StudentsScheduled.day = new string[11];

            StudentsScheduled.CourseCode[0] = lblCode_1.Text;
            StudentsScheduled.CourseCode[1] = lblCode_2.Text;
            StudentsScheduled.CourseCode[2] = lblCode_3.Text;
            StudentsScheduled.CourseCode[3] = lblCode_4.Text;
            StudentsScheduled.CourseCode[4] = lblCode_5.Text;
            StudentsScheduled.CourseCode[5] = lblCode_6.Text;
            StudentsScheduled.CourseCode[6] = lblCode_7.Text;
            StudentsScheduled.CourseCode[7] = lblCode_8.Text;
            StudentsScheduled.CourseCode[8] = lblCode_9.Text;
            StudentsScheduled.CourseCode[9] = lblCode_10.Text;

            StudentsScheduled.SubjectDescription[0] = lblDescription_1.Text;
            StudentsScheduled.SubjectDescription[1] = lblDescription_2.Text;
            StudentsScheduled.SubjectDescription[2] = lblDescription_3.Text;
            StudentsScheduled.SubjectDescription[3] = lblDescription_4.Text;
            StudentsScheduled.SubjectDescription[4] = lblDescription_5.Text;
            StudentsScheduled.SubjectDescription[5] = lblDescription_6.Text;
            StudentsScheduled.SubjectDescription[6] = lblDescription_7.Text;
            StudentsScheduled.SubjectDescription[7] = lblDescription_8.Text;
            StudentsScheduled.SubjectDescription[8] = lblDescription_9.Text;
            StudentsScheduled.SubjectDescription[9] = lblDescription_10.Text;

            StudentsScheduled.Rooms[0] = cboRoom_1.Text;
            StudentsScheduled.Rooms[1] = cboRoom_2.Text;
            StudentsScheduled.Rooms[2] = cboRoom_3.Text;
            StudentsScheduled.Rooms[3] = cboRoom_4.Text;
            StudentsScheduled.Rooms[4] = cboRoom_5.Text;
            StudentsScheduled.Rooms[5] = cboRoom_6.Text;
            StudentsScheduled.Rooms[6] = cboRoom_7.Text;
            StudentsScheduled.Rooms[7] = cboRoom_8.Text;
            StudentsScheduled.Rooms[8] = cboRoom_9.Text;
            StudentsScheduled.Rooms[9] = cboRoom_10.Text;

            StudentsScheduled.Professors[0] = cboProfessor_1.Text;
            StudentsScheduled.Professors[1] = cboProfessor_2.Text;
            StudentsScheduled.Professors[2] = cboProfessor_3.Text;
            StudentsScheduled.Professors[3] = cboProfessor_4.Text;
            StudentsScheduled.Professors[4] = cboProfessor_5.Text;
            StudentsScheduled.Professors[5] = cboProfessor_6.Text;
            StudentsScheduled.Professors[6] = cboProfessor_7.Text;
            StudentsScheduled.Professors[7] = cboProfessor_8.Text;
            StudentsScheduled.Professors[8] = cboProfessor_9.Text;
            StudentsScheduled.Professors[9] = cboProfessor_10.Text;

            StudentsScheduled.startTime[0] = cboStart_1.Text;
            StudentsScheduled.startTime[1] = cboStart_2.Text;
            StudentsScheduled.startTime[2] = cboStart_3.Text;
            StudentsScheduled.startTime[3] = cboStart_4.Text;
            StudentsScheduled.startTime[4] = cboStart_5.Text;
            StudentsScheduled.startTime[5] = cboStart_6.Text;
            StudentsScheduled.startTime[6] = cboStart_7.Text;
            StudentsScheduled.startTime[7] = cboStart_8.Text;
            StudentsScheduled.startTime[8] = cboStart_9.Text;
            StudentsScheduled.startTime[9] = cboStart_10.Text;

            StudentsScheduled.endTime[0] = cboEnd_1.Text;
            StudentsScheduled.endTime[1] = cboEnd_2.Text;
            StudentsScheduled.endTime[2] = cboEnd_3.Text;
            StudentsScheduled.endTime[3] = cboEnd_4.Text;
            StudentsScheduled.endTime[4] = cboEnd_5.Text;
            StudentsScheduled.endTime[5] = cboEnd_6.Text;
            StudentsScheduled.endTime[6] = cboEnd_7.Text;
            StudentsScheduled.endTime[7] = cboEnd_8.Text;
            StudentsScheduled.endTime[8] = cboEnd_9.Text;
            StudentsScheduled.endTime[9] = cboEnd_10.Text;

            StudentsScheduled.day[0] = cboDay_1.Text;
            StudentsScheduled.day[1] = cboDay_2.Text;
            StudentsScheduled.day[2] = cboDay_3.Text;
            StudentsScheduled.day[3] = cboDay_4.Text;
            StudentsScheduled.day[4] = cboDay_5.Text;
            StudentsScheduled.day[5] = cboDay_6.Text;
            StudentsScheduled.day[6] = cboDay_7.Text;
            StudentsScheduled.day[7] = cboDay_8.Text;
            StudentsScheduled.day[8] = cboDay_9.Text;
            StudentsScheduled.day[9] = cboDay_10.Text;

            md.CSD_insert_students_schedule(cboCourse.Text, cboYear.Text, cboSection.Text, cboCurriculum.Text, cboSemester.Text, cboSchoolYear.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClearAll();//to clear

            btnSettings.Visible = true;
            pnlStart.Visible = false;
            lblSection.Text = "Section:  " + cboCourse.Text + " " + cboYear.Text + " - " + cboSection.Text + "";
            lblCurriculumTitle.Text = "" + cboCurriculum.Text + " [" + cboSemester.Text + " Semester] [SY:" + cboSchoolYear.Text + "]";

            LoadSaveData();//to load the save data
            btnSAVE.Visible = true;

            ClassSchedule_Data.semester = cboSemester.Text;
            ClassSchedule_Data.schoolYear = cboSchoolYear.Text;

            tbl_pnl_layout.Visible = true;
            btnSet_1.Visible = true;
            btnSet_2.Visible = true;
            btnSet_3.Visible = true;
            btnSet_4.Visible = true;
            btnSet_5.Visible = true;
            btnSet_6.Visible = true;
            btnSet_7.Visible = true;
            btnSet_8.Visible = true;
            btnSet_9.Visible = true;
            btnSet_10.Visible = true;

            StudentsScheduled.curriculumsName = cboCurriculum.Text;
            //instanciation of an object
            SubjectForStudents.CourseCode = new string[11];
            SubjectForStudents.SubjectDescription = new string[11];
            SubjectForStudents.Units = new string[11];
            SubjectForStudents.LecHrs = new string[11];
            SubjectForStudents.LabHrs = new string[11];

            md.CSD_ShowSubjectsForStudents(cboCourse.Text, cboYear.Text, cboCurriculum.Text, cboSemester.Text, cboSchoolYear.Text);//to call function to get data into database

            //call a method to list data
            ListCourseCode();
            ListSubjectDescription();
            ListUnits();
            ListLecHrs();
            ListlabHrs();
            ListProfessors();
            ListStartTime();
            ListEndTime();
            ListDay();
            ListRoom();
            ListSet();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
            pnlStart.BringToFront();
            btnSettings.Visible = false;
            lblSection.Text = "Settings";
            lblCurriculumTitle.Text = " ";
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                SaveScheduled();
                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save");
            }
        }

        private void ClearAll()//to clear all fields
        {
            lblCode_1.Text = "";
            lblCode_2.Text = "";
            lblCode_3.Text = "";
            lblCode_4.Text = "";
            lblCode_5.Text = "";
            lblCode_6.Text = "";
            lblCode_7.Text = "";
            lblCode_8.Text = "";
            lblCode_9.Text = "";
            lblCode_10.Text = "";

            lblDescription_1.Text = "";
            lblDescription_2.Text = "";
            lblDescription_3.Text = "";
            lblDescription_4.Text = "";
            lblDescription_5.Text = "";
            lblDescription_6.Text = "";
            lblDescription_7.Text = "";
            lblDescription_8.Text = "";
            lblDescription_9.Text = "";
            lblDescription_10.Text = "";

            lblUnits_1.Text = "";
            lblUnits_2.Text = "";
            lblUnits_3.Text = "";
            lblUnits_4.Text = "";
            lblUnits_5.Text = "";
            lblUnits_6.Text = "";
            lblUnits_7.Text = "";
            lblUnits_8.Text = "";
            lblUnits_9.Text = "";
            lblUnits_10.Text = "";

            lblLecHours_1.Text = "";
            lblLecHours_2.Text = "";
            lblLecHours_3.Text = "";
            lblLecHours_4.Text = "";
            lblLecHours_5.Text = "";
            lblLecHours_6.Text = "";
            lblLecHours_7.Text = "";
            lblLecHours_8.Text = "";
            lblLecHours_9.Text = "";
            lblLecHours_10.Text = "";

            lbl_LabHours_1.Text = "";
            lbl_LabHours_2.Text = "";
            lbl_LabHours_3.Text = "";
            lbl_LabHours_4.Text = "";
            lbl_LabHours_5.Text = "";
            lbl_LabHours_6.Text = "";
            lbl_LabHours_7.Text = "";
            lbl_LabHours_8.Text = "";
            lbl_LabHours_9.Text = "";
            lbl_LabHours_10.Text = "";

            cboProfessor_1.Text = "";
            cboProfessor_2.Text = "";
            cboProfessor_3.Text = "";
            cboProfessor_4.Text = "";
            cboProfessor_5.Text = "";
            cboProfessor_6.Text = "";
            cboProfessor_7.Text = "";
            cboProfessor_8.Text = "";
            cboProfessor_9.Text = "";
            cboProfessor_10.Text = "";

            cboStart_1.Text = "";
            cboStart_2.Text = "";
            cboStart_3.Text = "";
            cboStart_4.Text = "";
            cboStart_5.Text = "";
            cboStart_6.Text = "";
            cboStart_7.Text = "";
            cboStart_8.Text = "";
            cboStart_9.Text = "";
            cboStart_10.Text = "";

            cboEnd_1.Text = "";
            cboEnd_2.Text = "";
            cboEnd_3.Text = "";
            cboEnd_4.Text = "";
            cboEnd_5.Text = "";
            cboEnd_6.Text = "";
            cboEnd_7.Text = "";
            cboEnd_8.Text = "";
            cboEnd_9.Text = "";
            cboEnd_10.Text = "";

            cboDay_1.Text = "";
            cboDay_2.Text = "";
            cboDay_3.Text = "";
            cboDay_4.Text = "";
            cboDay_5.Text = "";
            cboDay_6.Text = "";
            cboDay_7.Text = "";
            cboDay_8.Text = "";
            cboDay_9.Text = "";
            cboDay_10.Text = "";

            cboRoom_1.Text = "";
            cboRoom_2.Text = "";
            cboRoom_3.Text = "";
            cboRoom_4.Text = "";
            cboRoom_5.Text = "";
            cboRoom_6.Text = "";
            cboRoom_7.Text = "";
            cboRoom_8.Text = "";
            cboRoom_9.Text = "";
            cboRoom_10.Text = "";
        }
    }
}
