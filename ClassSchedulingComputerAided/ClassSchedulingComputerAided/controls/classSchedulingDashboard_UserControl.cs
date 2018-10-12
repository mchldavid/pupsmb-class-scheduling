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
using ClassSchedulingComputerAided.Properties;

namespace ClassSchedulingComputerAided
{
    public partial class classSchedulingDashboard_UserControl : UserControl
    {
        public classSchedulingDashboard_UserControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        int countForColor = 0;
        string[] checkDay = {"Monday", "Tuesady", "Wednesday", "Thursday", "Friday","Sarturday", "Sunday"};

        private void lblLecHours_4_Click(object sender, EventArgs e)
        {

        }

        private void cboDay_4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEnd_4_SelectedIndexChanged(object sender, EventArgs e)
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

            pnlStart.BringToFront();

            cboSemester.Items.Add("1ST");
            cboSemester.Items.Add("2ND");
            cboSemester.Items.Add("SUMMER");

            //to fill the school year
            string startYear = Settings.Default["Year"].ToString();
            string sy = "";
            DateTime dt = new DateTime(Convert.ToInt32(startYear), DateTime.Now.Month, DateTime.Now.Day);
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
            for (int x = 0; x < md.getCourseYearSection().Length; x++)
                if (md.getCourseYearSection().GetValue(x).ToString() != "")
                    cboCourse.Items.Add(md.getCourseYearSection().GetValue(x).ToString());

            for (int x = 0; x < md.getCurriculum().Length; x++)
                if (md.getCurriculum().GetValue(x).ToString() != "")
                    cboCurriculum.Items.Add(md.getCurriculum().GetValue(x).ToString());
            LoadSaveDataCSD_Start();//to load data
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

        //check the conflicts on the students
        public bool StudentCheckConstraints(string rC, string day, string sec_sT, string sec_eT)
        {
            bool isValid = true;
            int scheduleIsFree = 0;
            string message = "";
            for (int x = 0; x < md.get_id_StudentsScheduled(rC, cboSemester.Text, cboSchoolYear.Text).Length; x++)
            {
                string ps_id = md.get_id_StudentsScheduled(rC, cboSemester.Text, cboSchoolYear.Text).GetValue(x).ToString();
                if (ps_id != "")
                {
                    string sT = md.get_info_StudentsScheduled(ps_id).GetValue(0).ToString();
                    string eT = md.get_info_StudentsScheduled(ps_id).GetValue(1).ToString();
                    string section = md.get_info_StudentsScheduled(ps_id).GetValue(5).ToString();
                    DateTime PS_startTime = DateTime.Parse(sT);
                    DateTime PS_endTime = DateTime.Parse(eT);
                    DateTime startTime = DateTime.Parse(sec_sT);
                    DateTime endTime = DateTime.Parse(sec_eT);
                    int dt1 = DateTime.Compare(PS_startTime, startTime);
                    int dt2 = DateTime.Compare(PS_endTime, endTime);
                    int dt3 = DateTime.Compare(PS_startTime, endTime);
                    int dt4 = DateTime.Compare(PS_endTime, startTime);
                    string promptMessage = System.String.Format("There's a conflict on \r\n{0} from {1} to {2} \r\n affected: {3}", day, sT, eT, section);

                    if (md.get_info_StudentsScheduled(ps_id).GetValue(2).ToString() == day)
                    {
                        if (dt1 == -1 && dt2 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt2 == -1 && dt4 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt4 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                    }
                }
            }
            if (scheduleIsFree < 1)
            {
                isValid = true;
                //MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                MessageBox.Show(message, "STUDENTS SCHEDULED CONFLICT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        //check the conflicts on that day
        public bool RoomCheckConstraints(string rC, string day, string sec_sT, string sec_eT)
        {
            bool isValid = true;
            int scheduleIsFree = 0;
            string message = "";
            for (int x = 0; x < md.get_id_roomScheduled(rC, cboSemester.Text, cboSchoolYear.Text).Length; x++)
            {
                string ps_id = md.get_id_roomScheduled(rC, cboSemester.Text, cboSchoolYear.Text).GetValue(x).ToString();
                if (ps_id != "")
                {
                    string sT = md.get_info_roomScheduled(ps_id).GetValue(0).ToString();
                    string eT = md.get_info_roomScheduled(ps_id).GetValue(1).ToString();
                    string section = md.get_info_roomScheduled(ps_id).GetValue(5).ToString();
                    DateTime PS_startTime = DateTime.Parse(sT);
                    DateTime PS_endTime = DateTime.Parse(eT);
                    DateTime startTime = DateTime.Parse(sec_sT);
                    DateTime endTime = DateTime.Parse(sec_eT);
                    int dt1 = DateTime.Compare(PS_startTime, startTime);
                    int dt2 = DateTime.Compare(PS_endTime, endTime);
                    int dt3 = DateTime.Compare(PS_startTime, endTime);
                    int dt4 = DateTime.Compare(PS_endTime, startTime);
                    string promptMessage = System.String.Format("There's a conflict on \r\n{0} from {1} to {2} \r\n affected: {3}", day, sT, eT, section);

                    if (md.get_info_roomScheduled(ps_id).GetValue(2).ToString() == day)
                    {
                        if (dt1 == -1 && dt2 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt2 == -1 && dt4 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt4 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                    }
                }
            }
            if (scheduleIsFree < 1)
            {
                isValid = true;
                //MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                MessageBox.Show(message, "ROOM SCHEDULED CONFLICT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        //check the scheduled of prof
        public bool ProfCheckConstraints(string rC, string day, string sec_sT, string sec_eT)
        {
            bool isValid = true;
            int scheduleIsFree = 0;
            string message = "";
            for (int x = 0; x < md.get_id_ProfessorScheduled(rC, cboSemester.Text, cboSchoolYear.Text).Length; x++)
            {
                string ps_id = md.get_id_ProfessorScheduled(rC, cboSemester.Text, cboSchoolYear.Text).GetValue(x).ToString();
                if (ps_id != "")
                {
                    string sT = md.get_info_ProfessorScheduled(ps_id).GetValue(0).ToString();
                    string eT = md.get_info_ProfessorScheduled(ps_id).GetValue(1).ToString();
                    string section = md.get_info_ProfessorScheduled(ps_id).GetValue(5).ToString();
                    DateTime PS_startTime = DateTime.Parse(sT);
                    DateTime PS_endTime = DateTime.Parse(eT);
                    DateTime startTime = DateTime.Parse(sec_sT);
                    DateTime endTime = DateTime.Parse(sec_eT);
                    int dt1 = DateTime.Compare(PS_startTime, startTime);
                    int dt2 = DateTime.Compare(PS_endTime, endTime);
                    int dt3 = DateTime.Compare(PS_startTime, endTime);
                    int dt4 = DateTime.Compare(PS_endTime, startTime);
                    string promptMessage = System.String.Format("There's a conflict on \r\n{0} from {1} to {2} \r\n affected: {3}", day, sT, eT, section);

                    if (md.get_info_ProfessorScheduled(ps_id).GetValue(2).ToString() == day)
                    {
                        if (dt1 == -1 && dt2 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt2 == -1 && dt4 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 1 && dt3 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt4 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 0 && dt2 == 0)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                    }
                }
            }
            if (scheduleIsFree < 1)
            {
                isValid = true;
                //MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                MessageBox.Show(message, "PROFESSOR'S SCHEDULED CONFLICT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        //check the preferred scheduled of prof
        public bool ProfPreferedSchedCheckConstraints(string rC, string day, string sec_sT, string sec_eT)
        {
            bool isValid = true;
            int scheduleIsFree = 0;
            string message = "";
            bool WalangDay = true;
            for (int x = 0; x < md.get_id_PreferredScheduled(rC, cboSemester.Text, cboSchoolYear.Text).Length; x++)
            {
                string ps_id = md.get_id_PreferredScheduled(rC, cboSemester.Text, cboSchoolYear.Text).GetValue(x).ToString();
                if (ps_id != "")
                {
                    string sT = md.get_info_PreferredScheduled(ps_id).GetValue(0).ToString();
                    string eT = md.get_info_PreferredScheduled(ps_id).GetValue(1).ToString();
                    DateTime PS_startTime = DateTime.Parse(sT);
                    DateTime PS_endTime = DateTime.Parse(eT);
                    DateTime startTime = DateTime.Parse(sec_sT);
                    DateTime endTime = DateTime.Parse(sec_eT);
                    int dt1 = DateTime.Compare(PS_startTime, startTime);
                    int dt2 = DateTime.Compare(PS_endTime, endTime);
                    int dt3 = DateTime.Compare(PS_startTime, endTime);
                    int dt4 = DateTime.Compare(PS_endTime, startTime);
                    string promptMessage = System.String.Format("The [New Schedule] does not fit with the professor's [Preferred Schedule] \r\n Do you want to force \r\n {0} [{1} {2}-{3} ]", rC, day, sec_sT, sec_eT);
                    message = promptMessage;

                    for (int a = 0; a < 7; a++)
                        if (checkDay[a] == day)
                        {
                            WalangDay = false;
                        }

                    if (md.get_info_PreferredScheduled(ps_id).GetValue(2).ToString() == day)
                    {
                        if (dt1 == 1 && dt2 == 1 && dt4 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt2 == -1 && dt4 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == 1 && dt2 == 1 && dt4 == 1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                        if (dt1 == -1 && dt2 == -1 && dt4 == -1)
                        {
                            scheduleIsFree++;
                            message = promptMessage;
                            isValid = false;
                        }
                    }
                }
            }
            if (scheduleIsFree < 1)
            {
                isValid = true;
                if (WalangDay == true)
                {
                    DialogResult dr = MessageBox.Show(message, "PROFESSOR'S PREFERRED SCHEDULED CONFLICT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                        isValid = true;
                    else
                        isValid = false;
                }
                //MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                DialogResult dr = MessageBox.Show(message, "PROFESSOR'S PREFERRED SCHEDULED CONFLICT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                    isValid = true;
                else
                    isValid = false;
            }
            return isValid;
        }

        private void btnSet_1_Click(object sender, EventArgs e)
        {
            if (btnSet_1.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_1.Text;
                CSD_defaultData.startTime = cboStart_1.Text;
                CSD_defaultData.endTime = cboEnd_1.Text;
                CSD_defaultData.day = cboDay_1.Text;
                CSD_defaultData.room = cboRoom_1.Text;

                btnCancel_1.Visible = true;

                SetComboBoxToDisabled();
                btnSet_1.Enabled = true;
                cboProfessor_1.Enabled = true;
                cboStart_1.Enabled = true;
                cboEnd_1.Enabled = true;
                cboDay_1.Enabled = true;
                cboRoom_1.Enabled = true;
                btnSet_1.Text = "OK";
                btnSAVE.Enabled = false;
                
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
                if (cboProfessor_1.Text != "" && cboStart_1.Text != "" && cboEnd_1.Text != "" && cboDay_1.Text != "" && cboRoom_1.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_1.Text, cboDay_1.Text, cboStart_1.Text, cboEnd_1.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_1.Text != "TBA") ? ProfCheckConstraints(cboProfessor_1.Text, cboDay_1.Text, cboStart_1.Text, cboEnd_1.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_1.Text, cboDay_1.Text, cboStart_1.Text, cboEnd_1.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text+cboYear.Text+cboSection.Text, cboDay_1.Text, cboStart_1.Text, cboEnd_1.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_1.Text + " was scheduled to"
                                        + cboProfessor_1.Text + " from"
                                        + cboStart_1.Text
                                        + " to "
                                        + cboEnd_1.Text + " "
                                        + cboDay_1.Text + " in "
                                        + cboRoom_1.Text);

                                    btnCancel_1.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_1.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_1.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_2_Click(object sender, EventArgs e)
        {
            if (btnSet_2.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_2.Text;
                CSD_defaultData.startTime = cboStart_2.Text;
                CSD_defaultData.endTime = cboEnd_2.Text;
                CSD_defaultData.day = cboDay_2.Text;
                CSD_defaultData.room = cboRoom_2.Text;

                btnCancel_2.Visible = true;

                SetComboBoxToDisabled();
                btnSet_2.Enabled = true;
                cboProfessor_2.Enabled = true;
                cboStart_2.Enabled = true;
                cboEnd_2.Enabled = true;
                cboDay_2.Enabled = true;
                cboRoom_2.Enabled = true;
                btnSet_2.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_2.Text != "" && cboStart_2.Text != "" && cboEnd_2.Text != "" && cboDay_2.Text != "" && cboRoom_2.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_2.Text, cboDay_2.Text, cboStart_2.Text, cboEnd_2.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_2.Text != "TBA") ? ProfCheckConstraints(cboProfessor_2.Text, cboDay_2.Text, cboStart_2.Text, cboEnd_2.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_2.Text, cboDay_2.Text, cboStart_2.Text, cboEnd_2.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_2.Text, cboStart_2.Text, cboEnd_2.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_2.Text + " was scheduled to"
                                        + cboProfessor_2.Text + " from"
                                        + cboStart_2.Text
                                        + " to "
                                        + cboEnd_2.Text + " "
                                        + cboDay_2.Text + " in "
                                        + cboRoom_2.Text);

                                    btnCancel_2.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_2.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_2.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_3_Click(object sender, EventArgs e)
        {
            if (btnSet_3.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_3.Text;
                CSD_defaultData.startTime = cboStart_3.Text;
                CSD_defaultData.endTime = cboEnd_3.Text;
                CSD_defaultData.day = cboDay_3.Text;
                CSD_defaultData.room = cboRoom_3.Text;

                btnCancel_3.Visible = true;

                SetComboBoxToDisabled();
                btnSet_3.Enabled = true;
                cboProfessor_3.Enabled = true;
                cboStart_3.Enabled = true;
                cboEnd_3.Enabled = true;
                cboDay_3.Enabled = true;
                cboRoom_3.Enabled = true;
                btnSet_3.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_3.Text != "" && cboStart_3.Text != "" && cboEnd_3.Text != "" && cboDay_3.Text != "" && cboRoom_3.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_3.Text, cboDay_3.Text, cboStart_3.Text, cboEnd_3.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_3.Text != "TBA") ? ProfCheckConstraints(cboProfessor_3.Text, cboDay_3.Text, cboStart_3.Text, cboEnd_3.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_3.Text, cboDay_3.Text, cboStart_3.Text, cboEnd_3.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_3.Text, cboStart_3.Text, cboEnd_3.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_3.Text + " was scheduled to"
                                        + cboProfessor_3.Text + " from"
                                        + cboStart_3.Text
                                        + " to "
                                        + cboEnd_3.Text + " "
                                        + cboDay_3.Text + " in "
                                        + cboRoom_3.Text);

                                    btnCancel_3.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_3.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_3.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_4_Click(object sender, EventArgs e)
        {
            if (btnSet_4.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_4.Text;
                CSD_defaultData.startTime = cboStart_4.Text;
                CSD_defaultData.endTime = cboEnd_4.Text;
                CSD_defaultData.day = cboDay_4.Text;
                CSD_defaultData.room = cboRoom_4.Text;

                btnCancel_4.Visible = true;

                SetComboBoxToDisabled();
                btnSet_4.Enabled = true;
                cboProfessor_4.Enabled = true;
                cboStart_4.Enabled = true;
                cboEnd_4.Enabled = true;
                cboDay_4.Enabled = true;
                cboRoom_4.Enabled = true;
                btnSet_4.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_4.Text != "" && cboStart_4.Text != "" && cboEnd_4.Text != "" && cboDay_4.Text != "" && cboRoom_4.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_4.Text, cboDay_4.Text, cboStart_4.Text, cboEnd_4.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_4.Text != "TBA") ? ProfCheckConstraints(cboProfessor_4.Text, cboDay_4.Text, cboStart_4.Text, cboEnd_4.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_4.Text, cboDay_4.Text, cboStart_4.Text, cboEnd_4.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_4.Text, cboStart_4.Text, cboEnd_4.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_4.Text + " was scheduled to"
                                        + cboProfessor_4.Text + " from"
                                        + cboStart_4.Text
                                        + " to "
                                        + cboEnd_4.Text + " "
                                        + cboDay_4.Text + " in "
                                        + cboRoom_4.Text);

                                    btnCancel_4.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_4.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_4.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_5_Click(object sender, EventArgs e)
        {
            if (btnSet_5.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_5.Text;
                CSD_defaultData.startTime = cboStart_5.Text;
                CSD_defaultData.endTime = cboEnd_5.Text;
                CSD_defaultData.day = cboDay_5.Text;
                CSD_defaultData.room = cboRoom_5.Text;

                btnCancel_5.Visible = true;

                SetComboBoxToDisabled();
                btnSet_5.Enabled = true;
                cboProfessor_5.Enabled = true;
                cboStart_5.Enabled = true;
                cboEnd_5.Enabled = true;
                cboDay_5.Enabled = true;
                cboRoom_5.Enabled = true;
                btnSet_5.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_5.Text != "" && cboStart_5.Text != "" && cboEnd_5.Text != "" && cboDay_5.Text != "" && cboRoom_5.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_5.Text, cboDay_5.Text, cboStart_5.Text, cboEnd_5.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_5.Text != "TBA") ? ProfCheckConstraints(cboProfessor_5.Text, cboDay_5.Text, cboStart_5.Text, cboEnd_5.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_5.Text, cboDay_5.Text, cboStart_5.Text, cboEnd_5.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_5.Text, cboStart_5.Text, cboEnd_5.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_5.Text + " was scheduled to"
                                        + cboProfessor_5.Text + " from"
                                        + cboStart_5.Text
                                        + " to "
                                        + cboEnd_5.Text + " "
                                        + cboDay_5.Text + " in "
                                        + cboRoom_5.Text);

                                    btnCancel_5.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_5.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_5.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_6_Click(object sender, EventArgs e)
        {
            if (btnSet_6.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_6.Text;
                CSD_defaultData.startTime = cboStart_6.Text;
                CSD_defaultData.endTime = cboEnd_6.Text;
                CSD_defaultData.day = cboDay_6.Text;
                CSD_defaultData.room = cboRoom_6.Text;

                btnCancel_6.Visible = true;

                SetComboBoxToDisabled();
                btnSet_6.Enabled = true;
                cboProfessor_6.Enabled = true;
                cboStart_6.Enabled = true;
                cboEnd_6.Enabled = true;
                cboDay_6.Enabled = true;
                cboRoom_6.Enabled = true;
                btnSet_6.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_6.Text != "" && cboStart_6.Text != "" && cboEnd_6.Text != "" && cboDay_6.Text != "" && cboRoom_6.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_6.Text, cboDay_6.Text, cboStart_6.Text, cboEnd_6.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_6.Text != "TBA") ? ProfCheckConstraints(cboProfessor_6.Text, cboDay_6.Text, cboStart_6.Text, cboEnd_6.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_6.Text, cboDay_6.Text, cboStart_6.Text, cboEnd_6.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_6.Text, cboStart_6.Text, cboEnd_6.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_6.Text + " was scheduled to"
                                        + cboProfessor_6.Text + " from"
                                        + cboStart_6.Text
                                        + " to "
                                        + cboEnd_6.Text + " "
                                        + cboDay_6.Text + " in "
                                        + cboRoom_6.Text);

                                    btnCancel_6.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_6.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_6.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_7_Click(object sender, EventArgs e)
        {
            if (btnSet_7.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_7.Text;
                CSD_defaultData.startTime = cboStart_7.Text;
                CSD_defaultData.endTime = cboEnd_7.Text;
                CSD_defaultData.day = cboDay_7.Text;
                CSD_defaultData.room = cboRoom_7.Text;

                btnCancel_7.Visible = true;

                SetComboBoxToDisabled();
                btnSet_7.Enabled = true;
                cboProfessor_7.Enabled = true;
                cboStart_7.Enabled = true;
                cboEnd_7.Enabled = true;
                cboDay_7.Enabled = true;
                cboRoom_7.Enabled = true;
                btnSet_7.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_7.Text != "" && cboStart_7.Text != "" && cboEnd_7.Text != "" && cboDay_7.Text != "" && cboRoom_7.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_7.Text, cboDay_7.Text, cboStart_7.Text, cboEnd_7.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_7.Text != "TBA") ? ProfCheckConstraints(cboProfessor_7.Text, cboDay_7.Text, cboStart_7.Text, cboEnd_7.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_7.Text, cboDay_7.Text, cboStart_7.Text, cboEnd_7.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_7.Text, cboStart_7.Text, cboEnd_7.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_7.Text + " was scheduled to"
                                        + cboProfessor_7.Text + " from"
                                        + cboStart_7.Text
                                        + " to "
                                        + cboEnd_7.Text + " "
                                        + cboDay_7.Text + " in "
                                        + cboRoom_7.Text);

                                    btnCancel_7.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_7.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_7.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_8_Click(object sender, EventArgs e)
        {
            if (btnSet_8.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_8.Text;
                CSD_defaultData.startTime = cboStart_8.Text;
                CSD_defaultData.endTime = cboEnd_8.Text;
                CSD_defaultData.day = cboDay_8.Text;
                CSD_defaultData.room = cboRoom_8.Text;

                btnCancel_8.Visible = true;

                SetComboBoxToDisabled();
                btnSet_8.Enabled = true;
                cboProfessor_8.Enabled = true;
                cboStart_8.Enabled = true;
                cboEnd_8.Enabled = true;
                cboDay_8.Enabled = true;
                cboRoom_8.Enabled = true;
                btnSet_8.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_8.Text != "" && cboStart_8.Text != "" && cboEnd_8.Text != "" && cboDay_8.Text != "" && cboRoom_8.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_8.Text, cboDay_8.Text, cboStart_8.Text, cboEnd_8.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_8.Text != "TBA") ? ProfCheckConstraints(cboProfessor_8.Text, cboDay_8.Text, cboStart_8.Text, cboEnd_8.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_8.Text, cboDay_8.Text, cboStart_8.Text, cboEnd_8.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_8.Text, cboStart_8.Text, cboEnd_8.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_8.Text + " was scheduled to"
                                        + cboProfessor_8.Text + " from"
                                        + cboStart_8.Text
                                        + " to "
                                        + cboEnd_8.Text + " "
                                        + cboDay_8.Text + " in "
                                        + cboRoom_8.Text);

                                    btnCancel_8.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_8.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_8.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_9_Click(object sender, EventArgs e)
        {
            if (btnSet_9.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_9.Text;
                CSD_defaultData.startTime = cboStart_9.Text;
                CSD_defaultData.endTime = cboEnd_9.Text;
                CSD_defaultData.day = cboDay_9.Text;
                CSD_defaultData.room = cboRoom_9.Text;

                btnCancel_9.Visible = true;

                SetComboBoxToDisabled();
                btnSet_9.Enabled = true;
                cboProfessor_9.Enabled = true;
                cboStart_9.Enabled = true;
                cboEnd_9.Enabled = true;
                cboDay_9.Enabled = true;
                cboRoom_9.Enabled = true;
                btnSet_9.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_9.Text != "" && cboStart_9.Text != "" && cboEnd_9.Text != "" && cboDay_9.Text != "" && cboRoom_9.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_9.Text, cboDay_9.Text, cboStart_9.Text, cboEnd_9.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_9.Text != "TBA") ? ProfCheckConstraints(cboProfessor_9.Text, cboDay_9.Text, cboStart_9.Text, cboEnd_9.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_9.Text, cboDay_9.Text, cboStart_9.Text, cboEnd_9.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_9.Text, cboStart_9.Text, cboEnd_9.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_9.Text + " was scheduled to"
                                        + cboProfessor_9.Text + " from"
                                        + cboStart_9.Text
                                        + " to "
                                        + cboEnd_9.Text + " "
                                        + cboDay_9.Text + " in "
                                        + cboRoom_9.Text);

                                    btnCancel_9.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_9.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_9.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_10_Click(object sender, EventArgs e)
        {
            if (btnSet_10.Text == "SET")
            {
                CSD_defaultData.professor = cboProfessor_10.Text;
                CSD_defaultData.startTime = cboStart_10.Text;
                CSD_defaultData.endTime = cboEnd_10.Text;
                CSD_defaultData.day = cboDay_10.Text;
                CSD_defaultData.room = cboRoom_10.Text;

                btnCancel_10.Visible = true;

                SetComboBoxToDisabled();
                btnSet_10.Enabled = true;
                cboProfessor_10.Enabled = true;
                cboStart_10.Enabled = true;
                cboEnd_10.Enabled = true;
                cboDay_10.Enabled = true;
                cboRoom_10.Enabled = true;
                btnSet_10.Text = "OK";
                btnSAVE.Enabled = false;

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
                if (cboProfessor_10.Text != "" && cboStart_10.Text != "" && cboEnd_10.Text != "" && cboDay_10.Text != "" && cboRoom_10.Text != "")
                {
                    //check constraint for preferred schedule
                    if (ProfPreferedSchedCheckConstraints(cboProfessor_10.Text, cboDay_10.Text, cboStart_10.Text, cboEnd_10.Text) == true)
                    {
                        //to determine the TBA professor
                        bool professorsConstraints = (cboProfessor_10.Text != "TBA") ? ProfCheckConstraints(cboProfessor_10.Text, cboDay_10.Text, cboStart_10.Text, cboEnd_10.Text) : true;

                        //Check constraints for professors
                        if (professorsConstraints == true)
                        {
                            //Check constraints for Rooms
                            if (RoomCheckConstraints(cboRoom_10.Text, cboDay_10.Text, cboStart_10.Text, cboEnd_10.Text) == true)
                            {
                                if (StudentCheckConstraints(cboCourse.Text + cboYear.Text + cboSection.Text, cboDay_10.Text, cboStart_10.Text, cboEnd_10.Text) == true)
                                {
                                    //audit
                                    md.AuditTrail(AuditTrailData.username, "Update", lblCode_10.Text + " was scheduled to"
                                        + cboProfessor_10.Text + " from"
                                        + cboStart_10.Text
                                        + " to "
                                        + cboEnd_10.Text + " "
                                        + cboDay_10.Text + " in "
                                        + cboRoom_10.Text);

                                    btnCancel_10.Visible = false;

                                    MessageBox.Show("Scheduled Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SaveScheduled();
                                    SaveData();

                                    SetComboBoxToDisabled();
                                    SetToEnabled();
                                    btnSet_10.Text = "SET";
                                    btnSAVE.Enabled = true;

                                    //previewing
                                    RoomTimeTableControl rttc = new RoomTimeTableControl();
                                    pnlRooms.Controls.Clear();
                                    pnlRooms.Controls.Add(rttc);

                                    md.CSD_get_professors_id(cboProfessor_10.Text);
                                    CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                                    pnlProfessors.Controls.Clear();
                                    pnlProfessors.Controls.Add(ptt);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboProfessor_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_1.Text);
            ClassSchedule_Data.professors_name = cboProfessor_1.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_2.Text);
            ClassSchedule_Data.professors_name = cboProfessor_2.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_3.Text);
            ClassSchedule_Data.professors_name = cboProfessor_3.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_4.Text);
            ClassSchedule_Data.professors_name = cboProfessor_4.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_5.Text);
            ClassSchedule_Data.professors_name = cboProfessor_5.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_6.Text);
            ClassSchedule_Data.professors_name = cboProfessor_6.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_7.Text);
            ClassSchedule_Data.professors_name = cboProfessor_7.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_8.Text);
            ClassSchedule_Data.professors_name = cboProfessor_8.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_9.Text);
            ClassSchedule_Data.professors_name = cboProfessor_9.Text;
            CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
            pnlProfessors.Controls.Clear();
            pnlProfessors.Controls.Add(ptt);
        }

        private void cboProfessor_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            md.CSD_get_professors_id(cboProfessor_10.Text);
            ClassSchedule_Data.professors_name = cboProfessor_10.Text;
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
            ClassSchedule_Data.roomCode = cboRoom_1.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_2.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_3.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_4.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_5.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_6.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_7.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_8.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_9.Text;
            RoomTimeTableControl rttc = new RoomTimeTableControl();
            pnlRooms.Controls.Clear();
            pnlRooms.Controls.Add(rttc);
        }

        private void cboRoom_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassSchedule_Data.roomCode = cboRoom_10.Text;
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
            string name = cboCourse.Text;
            name += cboYear.Text;
            name += cboSection.Text;
            name += cboSemester.Text;
            name += cboSchoolYear.Text;
            name += cboCurriculum.Text;
            SaveXML.SaveData(sid, name + ".xml");
        }

        public void SaveDataCSD_Start()
        {
            SaveInfoData sid = new SaveInfoData();
            sid.CurriculumTitle = cboCurriculum.Text;
            sid.Semester = cboSemester.Text;
            sid.SchoolYear = cboSchoolYear.Text;
            sid.Course = cboCourse.Text;
            sid.Year = cboYear.Text;
            sid.Section = cboSection.Text;

            //to set the name for the file save
            string name = "CSD-pnlStart";
            SaveXML.SaveData(sid, name + ".xml");
        }

        public void SaveScheduled()
        {
            StudentsScheduled.curriculumsName = cboCurriculum.Text;
            StudentsScheduled.course = cboCourse.Text;
            StudentsScheduled.year = cboYear.Text;
            StudentsScheduled.section = cboSection.Text;
            StudentsScheduled.semester = cboSemester.Text;
            StudentsScheduled.schoolYear = cboSchoolYear.Text;
            StudentsScheduled.CourseCode = new string[11];
            StudentsScheduled.SubjectDescription = new string[11];
            StudentsScheduled.Rooms = new string[11];
            StudentsScheduled.Professors = new string[11];
            StudentsScheduled.startTime = new string[11];
            StudentsScheduled.endTime = new string[11];
            StudentsScheduled.day = new string[11];
            StudentsScheduled.LecHrs = new string[11];
            StudentsScheduled.LabHrs = new string[11];
            StudentsScheduled.Units = new string[11];

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

            StudentsScheduled.LecHrs[0] = lblLecHours_1.Text;
            StudentsScheduled.LecHrs[1] = lblLecHours_2.Text;
            StudentsScheduled.LecHrs[2] = lblLecHours_3.Text;
            StudentsScheduled.LecHrs[3] = lblLecHours_4.Text;
            StudentsScheduled.LecHrs[4] = lblLecHours_5.Text;
            StudentsScheduled.LecHrs[5] = lblLecHours_6.Text;
            StudentsScheduled.LecHrs[6] = lblLecHours_7.Text;
            StudentsScheduled.LecHrs[7] = lblLecHours_8.Text;
            StudentsScheduled.LecHrs[8] = lblLecHours_9.Text;
            StudentsScheduled.LecHrs[9] = lblLecHours_10.Text;

            StudentsScheduled.LabHrs[0] = lbl_LabHours_1.Text;
            StudentsScheduled.LabHrs[1] = lbl_LabHours_2.Text;
            StudentsScheduled.LabHrs[2] = lbl_LabHours_3.Text;
            StudentsScheduled.LabHrs[3] = lbl_LabHours_4.Text;
            StudentsScheduled.LabHrs[4] = lbl_LabHours_5.Text;
            StudentsScheduled.LabHrs[5] = lbl_LabHours_6.Text;
            StudentsScheduled.LabHrs[6] = lbl_LabHours_7.Text;
            StudentsScheduled.LabHrs[7] = lbl_LabHours_8.Text;
            StudentsScheduled.LabHrs[8] = lbl_LabHours_9.Text;
            StudentsScheduled.LabHrs[9] = lbl_LabHours_10.Text;

            StudentsScheduled.Units[0] = lblUnits_1.Text;
            StudentsScheduled.Units[1] = lblUnits_2.Text;
            StudentsScheduled.Units[2] = lblUnits_3.Text;
            StudentsScheduled.Units[3] = lblUnits_4.Text;
            StudentsScheduled.Units[4] = lblUnits_5.Text;
            StudentsScheduled.Units[5] = lblUnits_6.Text;
            StudentsScheduled.Units[6] = lblUnits_7.Text;
            StudentsScheduled.Units[7] = lblUnits_8.Text;
            StudentsScheduled.Units[8] = lblUnits_9.Text;
            StudentsScheduled.Units[9] = lblUnits_10.Text;

            md.CSD_insert_students_schedule(cboCourse.Text, cboYear.Text, cboSection.Text, cboCurriculum.Text, cboSemester.Text, cboSchoolYear.Text);
        }

        public void LoadSaveData()//to load the set data from xml filetype
        {
            //to set the name for the file save
            string name = cboCourse.Text;
            name += cboYear.Text;
            name += cboSection.Text;
            name += cboSemester.Text;
            name += cboSchoolYear.Text;
            name += cboCurriculum.Text;

            if (File.Exists(name + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SaveInfoData));
                FileStream read = new FileStream(name + ".xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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

        public void LoadSaveDataCSD_Start()//to load the set data from xml filetype
        {
            //to set the name for the file save
            string name = "CSD-pnlStart";

            if (File.Exists(name + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SaveInfoData));
                FileStream read = new FileStream(name + ".xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                SaveInfoData sid = (SaveInfoData)xs.Deserialize(read);

                cboCurriculum.Text = sid.CurriculumTitle;
                cboSemester.Text = sid.Semester;
                cboSchoolYear.Text = sid.SchoolYear;
                cboCourse.Text = sid.Course;
                cboYear.Text = sid.Year;
                cboSection.Text = sid.Section;
            }
        }

        public void fill_prof_room()
        {
            //======================1=====================
            //clear all listed items
            cboProfessor_1.Items.Clear();
            cboRoom_1.Items.Clear();
            //set first value to TBA
            cboProfessor_1.Items.Add("TBA");

            //to list all Active Rooms
            SubjectForStudents.Rooms = new string[100];
            md.CSD_ListActiveRoom();
            for (int x = 0; x < 50; x++)//set to 50 loop
            {
                if (SubjectForStudents.Rooms[x] != "")
                    cboRoom_1.Items.Add(SubjectForStudents.Rooms[x]);
            }
            //to list all professors on that particular courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfDedicated(lblCode_1.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_1.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_1.Items.Count; z++)
                countForColor++;

            cboProfessor_1.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_1.DrawItem += new DrawItemEventHandler(cboProfessor_1_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_1.Items.Count; y++)
                    {
                        if (cboProfessor_1.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if(toOthers == true)
                        cboProfessor_1.Items.Add(SubjectForStudents.Professors[x]);
                }
            }


            //=====================2================
            //clear all listed items
            cboProfessor_2.Items.Clear();
            cboRoom_2.Items.Clear();
            //set first value to TBA
            cboProfessor_2.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_2.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_2.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_2.Items.Count; z++)
                countForColor++;

            cboProfessor_2.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_2.DrawItem += new DrawItemEventHandler(cboProfessor_2_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_2.Items.Count; y++)
                    {
                        if (cboProfessor_2.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_2.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            //===================3======================
            //clear all listed items
            cboProfessor_3.Items.Clear();
            cboRoom_3.Items.Clear();
            //set first value to TBA
            cboProfessor_3.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_3.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_3.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_3.Items.Count; z++)
                countForColor++;

            cboProfessor_3.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_3.DrawItem += new DrawItemEventHandler(cboProfessor_3_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_3.Items.Count; y++)
                    {
                        if (cboProfessor_3.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_3.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            //======================4==================
            //clear all listed items
            cboProfessor_4.Items.Clear();
            cboRoom_4.Items.Clear();
            //set first value to TBA
            cboProfessor_4.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_4.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_4.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_4.Items.Count; z++)
                countForColor++;

            cboProfessor_4.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_4.DrawItem += new DrawItemEventHandler(cboProfessor_4_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_4.Items.Count; y++)
                    {
                        if (cboProfessor_4.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_4.Items.Add(SubjectForStudents.Professors[x]);
                }
            }

            //=================5================
            //clear all listed items
            cboProfessor_5.Items.Clear();
            cboRoom_5.Items.Clear();
            //set first value to TBA
            cboProfessor_5.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_5.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_5.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_5.Items.Count; z++)
                countForColor++;

            cboProfessor_5.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_5.DrawItem += new DrawItemEventHandler(cboProfessor_5_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_5.Items.Count; y++)
                    {
                        if (cboProfessor_5.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_5.Items.Add(SubjectForStudents.Professors[x]);
                }
            }

            //==================[6]===============
            //clear all listed items
            cboProfessor_6.Items.Clear();
            cboRoom_6.Items.Clear();
            //set first value to TBA
            cboProfessor_6.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_6.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_6.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_6.Items.Count; z++)
                countForColor++;

            cboProfessor_6.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_6.DrawItem += new DrawItemEventHandler(cboProfessor_6_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_6.Items.Count; y++)
                    {
                        if (cboProfessor_6.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_6.Items.Add(SubjectForStudents.Professors[x]);
                }
            }

            //=================[7]===================
            //clear all listed items
            cboProfessor_7.Items.Clear();
            cboRoom_7.Items.Clear();
            //set first value to TBA
            cboProfessor_7.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_7.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_7.Items.Add(SubjectForStudents.Professors[x]);
            }


            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_7.Items.Count; z++)
                countForColor++;

            cboProfessor_7.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_7.DrawItem += new DrawItemEventHandler(cboProfessor_7_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_7.Items.Count; y++)
                    {
                        if (cboProfessor_7.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_7.Items.Add(SubjectForStudents.Professors[x]);
                }
            }

            //========================[8]====================
            //clear all listed items
            cboProfessor_8.Items.Clear();
            cboRoom_8.Items.Clear();
            //set first value to TBA
            cboProfessor_8.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_8.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_8.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_8.Items.Count; z++)
                countForColor++;

            cboProfessor_8.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_8.DrawItem += new DrawItemEventHandler(cboProfessor_8_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_8.Items.Count; y++)
                    {
                        if (cboProfessor_8.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_8.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
            //=======================[9]=====================
            //clear all listed items
            cboProfessor_9.Items.Clear();
            cboRoom_9.Items.Clear();
            //set first value to TBA
            cboProfessor_9.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_9.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_9.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_9.Items.Count; z++)
                countForColor++;

            cboProfessor_9.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_9.DrawItem += new DrawItemEventHandler(cboProfessor_9_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_9.Items.Count; y++)
                    {
                        if (cboProfessor_9.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_9.Items.Add(SubjectForStudents.Professors[x]);
                }
            }

            //==========================[10]=================
            //clear all listed items
            cboProfessor_10.Items.Clear();
            cboRoom_10.Items.Clear();
            //set first value to TBA
            cboProfessor_10.Items.Add("TBA");

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
            md.CSD_ListProfDedicated(lblCode_10.Text, cboSemester.Text, cboSchoolYear.Text);
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                    cboProfessor_10.Items.Add(SubjectForStudents.Professors[x]);
            }

            //to generate other prof
            countForColor = 0;
            for (int z = 0; z < cboProfessor_10.Items.Count; z++)
                countForColor++;

            cboProfessor_10.DrawMode = DrawMode.OwnerDrawFixed;
            cboProfessor_10.DrawItem += new DrawItemEventHandler(cboProfessor_10_DrawItem);
            //to list all professors that is not particular to courseCode
            SubjectForStudents.Professors = new string[100];
            md.CSD_ListProfNotDedicated();
            for (int x = 0; x < 100; x++)//set to 50 loop
            {
                if (SubjectForStudents.Professors[x] != "")
                {
                    bool toOthers = true;
                    for (int y = 0; y < cboProfessor_10.Items.Count; y++)
                    {
                        if (cboProfessor_10.Items[y].ToString() == SubjectForStudents.Professors[x])
                            toOthers = false;
                    }
                    if (toOthers == true)
                        cboProfessor_10.Items.Add(SubjectForStudents.Professors[x]);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboCurriculum.Text != "" && cboCourse.Text != "" && cboYear.Text != "" && cboSection.Text != "" && cboSemester.Text != "" && cboSchoolYear.Text != "")
            {
                ClearAll();//to clear

                btnSettings.Visible = true;
                pnlStart.Visible = false;
                lblSection.Text = "Section:  " + cboCourse.Text + " " + cboYear.Text + " - " + cboSection.Text + "";
                lblCurriculumTitle.Text = "" + cboCurriculum.Text + " [" + cboSemester.Text + " Semester] [SY:" + cboSchoolYear.Text + "]";

                SaveDataCSD_Start();//to save the data from starts

                btnSAVE.Visible = true;

                ClassSchedule_Data.course = cboCourse.Text;
                ClassSchedule_Data.year = cboYear.Text;
                ClassSchedule_Data.section = cboSection.Text;
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

                md.CSD_ShowSubjectsForStudents(cboCourse.Text, cboYear.Text, cboCurriculum.Text, cboSemester.Text);//to call function to get data into database

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

                fill_prof_room();//to fill all comboboxes(prof,room)
                LoadSaveData();//to load the save data

                //to load all data if already
                ClassSchedule_Data.professors_name = "";
                ClassSchedule_Data.roomCode = "";

                RoomTimeTableControl rttc = new RoomTimeTableControl();
                pnlRooms.Controls.Clear();
                pnlRooms.Controls.Add(rttc);

                md.CSD_get_professors_id(ClassSchedule_Data.professors_name);
                CSD_ProfTimeTable ptt = new CSD_ProfTimeTable();
                pnlProfessors.Controls.Clear();
                pnlProfessors.Controls.Add(ptt);
            }
            else
            {
                MessageBox.Show("Fill all fields are required!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string savedName = cboCourse.Text + " " + cboYear.Text + " - " + cboSection.Text;
            DialogResult result = MessageBox.Show("Do you want to save " + savedName + "?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //audit
                    md.AuditTrail(AuditTrailData.username, "Update", cboCourse.Text + " "+cboYear.Text+"-"+cboSection.Text+" schedule was saved for "+ cboCurriculum.Text+".");

                    SaveScheduled();
                    SaveData();

                    SummaryControl sc = new SummaryControl();
                    //pnlReport.Controls.Clear();
                    pnlReport.Controls.Add(sc);
                    btnOKk.BringToFront();
                    pnlReport.Visible = true;
                    pnlReport.BringToFront();
                    pnlStudentScheduling.Enabled = false;
                    pnlRooms.Enabled = false;
                    pnlProfessors.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save");
                }
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

            cboStart_1.SelectedIndex = -1;
            cboStart_2.SelectedIndex = -1;
            cboStart_3.SelectedIndex = -1;
            cboStart_4.SelectedIndex = -1;
            cboStart_5.SelectedIndex = -1;
            cboStart_6.SelectedIndex = -1;
            cboStart_7.SelectedIndex = -1;
            cboStart_8.SelectedIndex = -1;
            cboStart_9.SelectedIndex = -1;
            cboStart_10.SelectedIndex = -1;

            cboEnd_1.SelectedIndex = -1;
            cboEnd_2.SelectedIndex = -1;
            cboEnd_3.SelectedIndex = -1;
            cboEnd_4.SelectedIndex = -1;
            cboEnd_5.SelectedIndex = -1;
            cboEnd_6.SelectedIndex = -1;
            cboEnd_7.SelectedIndex = -1;
            cboEnd_8.SelectedIndex = -1;
            cboEnd_9.SelectedIndex = -1;
            cboEnd_10.SelectedIndex = -1;

            cboDay_1.SelectedIndex = -1;
            cboDay_2.SelectedIndex = -1;
            cboDay_3.SelectedIndex = -1;
            cboDay_4.SelectedIndex = -1;
            cboDay_5.SelectedIndex = -1;
            cboDay_6.SelectedIndex = -1;
            cboDay_7.SelectedIndex = -1;
            cboDay_8.SelectedIndex = -1;
            cboDay_9.SelectedIndex = -1;
            cboDay_10.SelectedIndex = -1;

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

        private void cboStart_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboStart_1.SelectedIndex < 23)
                cboEnd_1.SelectedIndex = cboStart_1.SelectedIndex + 6;
        }

        private void cboStart_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_2.SelectedIndex < 23)
                cboEnd_2.SelectedIndex = cboStart_2.SelectedIndex + 6;
        }

        private void cboStart_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_3.SelectedIndex < 23)
                cboEnd_3.SelectedIndex = cboStart_3.SelectedIndex + 6;
        }

        private void cboStart_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_4.SelectedIndex < 23)
                cboEnd_4.SelectedIndex = cboStart_4.SelectedIndex + 6;
        }

        private void cboStart_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_5.SelectedIndex < 23)
                cboEnd_5.SelectedIndex = cboStart_5.SelectedIndex + 6;
        }

        private void cboStart_6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_6.SelectedIndex < 23)
                cboEnd_6.SelectedIndex = cboStart_6.SelectedIndex + 6;
        }

        private void cboStart_7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_7.SelectedIndex < 23)
                cboEnd_7.SelectedIndex = cboStart_7.SelectedIndex + 6;
        }

        private void cboStart_8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_8.SelectedIndex < 23)
                cboEnd_8.SelectedIndex = cboStart_8.SelectedIndex + 6;
        }

        private void cboStart_9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_9.SelectedIndex < 23)
                cboEnd_9.SelectedIndex = cboStart_9.SelectedIndex + 6;
        }

        private void cboStart_10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStart_10.SelectedIndex < 23)
                cboEnd_10.SelectedIndex = cboStart_10.SelectedIndex + 6;
        }

        private void btnOKk_Click(object sender, EventArgs e)
        {
            pnlReport.Visible = false;
            pnlStudentScheduling.Enabled = true;
            pnlRooms.Enabled = true;
            pnlProfessors.Enabled = true;
        }

        private void btnCancel_1_Click(object sender, EventArgs e)
        {
            cboProfessor_1.Text = CSD_defaultData.professor;
            cboStart_1.Text = CSD_defaultData.startTime;
            cboEnd_1.Text = CSD_defaultData.endTime;
            cboDay_1.Text = CSD_defaultData.day;
            cboRoom_1.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_1.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_1.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_1.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_1.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_1.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_1.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_1.Visible = false;

        }

        private void btnCancel_2_Click(object sender, EventArgs e)
        {
            cboProfessor_2.Text = CSD_defaultData.professor;
            cboStart_2.Text = CSD_defaultData.startTime;
            cboEnd_2.Text = CSD_defaultData.endTime;
            cboDay_2.Text = CSD_defaultData.day;
            cboRoom_2.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_2.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_2.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_2.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_2.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_2.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_2.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_2.Visible = false;
        }

        private void btnCancel_3_Click(object sender, EventArgs e)
        {
            cboProfessor_3.Text = CSD_defaultData.professor;
            cboStart_3.Text = CSD_defaultData.startTime;
            cboEnd_3.Text = CSD_defaultData.endTime;
            cboDay_3.Text = CSD_defaultData.day;
            cboRoom_3.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_3.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_3.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_3.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_3.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_3.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_3.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_3.Visible = false;
        }

        private void btnCancel_4_Click(object sender, EventArgs e)
        {
            cboProfessor_4.Text = CSD_defaultData.professor;
            cboStart_4.Text = CSD_defaultData.startTime;
            cboEnd_4.Text = CSD_defaultData.endTime;
            cboDay_4.Text = CSD_defaultData.day;
            cboRoom_4.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_4.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_4.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_4.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_4.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_4.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_4.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_4.Visible = false;
        }

        private void btnCancel_5_Click(object sender, EventArgs e)
        {
            cboProfessor_5.Text = CSD_defaultData.professor;
            cboStart_5.Text = CSD_defaultData.startTime;
            cboEnd_5.Text = CSD_defaultData.endTime;
            cboDay_5.Text = CSD_defaultData.day;
            cboRoom_5.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_5.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_5.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_5.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_5.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_5.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_5.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_5.Visible = false;
        }

        private void btnCancel_6_Click(object sender, EventArgs e)
        {
            cboProfessor_6.Text = CSD_defaultData.professor;
            cboStart_6.Text = CSD_defaultData.startTime;
            cboEnd_6.Text = CSD_defaultData.endTime;
            cboDay_6.Text = CSD_defaultData.day;
            cboRoom_6.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_6.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_6.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_6.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_6.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_6.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_6.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_6.Visible = false;
        }

        private void btnCancel_7_Click(object sender, EventArgs e)
        {
            cboProfessor_7.Text = CSD_defaultData.professor;
            cboStart_7.Text = CSD_defaultData.startTime;
            cboEnd_7.Text = CSD_defaultData.endTime;
            cboDay_7.Text = CSD_defaultData.day;
            cboRoom_7.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_7.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_7.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_7.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_7.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_7.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_7.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_7.Visible = false;
        }

        private void btnCancel_8_Click(object sender, EventArgs e)
        {
            cboProfessor_8.Text = CSD_defaultData.professor;
            cboStart_8.Text = CSD_defaultData.startTime;
            cboEnd_8.Text = CSD_defaultData.endTime;
            cboDay_8.Text = CSD_defaultData.day;
            cboRoom_8.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_8.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_8.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_8.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_8.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_8.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_8.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_8.Visible = false;
        }

        private void btnCancel_9_Click(object sender, EventArgs e)
        {
            cboProfessor_9.Text = CSD_defaultData.professor;
            cboStart_9.Text = CSD_defaultData.startTime;
            cboEnd_9.Text = CSD_defaultData.endTime;
            cboDay_9.Text = CSD_defaultData.day;
            cboRoom_9.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_9.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_9.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_9.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_9.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_9.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_9.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_9.Visible = false;
        }

        private void btnCancel_10_Click(object sender, EventArgs e)
        {
            cboProfessor_10.Text = CSD_defaultData.professor;
            cboStart_10.Text = CSD_defaultData.startTime;
            cboEnd_10.Text = CSD_defaultData.endTime;
            cboDay_10.Text = CSD_defaultData.day;
            cboRoom_10.Text = CSD_defaultData.room;

            if (CSD_defaultData.professor == "")
                cboProfessor_10.SelectedIndex = -1;
            if (CSD_defaultData.startTime == "")
                cboStart_10.SelectedIndex = -1;
            if (CSD_defaultData.endTime == "")
                cboEnd_10.SelectedIndex = -1;
            if (CSD_defaultData.day == "")
                cboDay_10.SelectedIndex = -1;
            if (CSD_defaultData.room == "")
                cboRoom_10.SelectedIndex = -1;

            SetComboBoxToDisabled();
            SetToEnabled();
            btnSet_10.Text = "SET";
            btnSAVE.Enabled = true;

            btnCancel_10.Visible = false;
        }

        private void cboProfessor_1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_1.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_1.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_2_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_2.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_2.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_3_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_3.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_3.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_4_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_4.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_4.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_5_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_5.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_5.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_6_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_6.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_6.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_7_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_7.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_7.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_8_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_8.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_8.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_9_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_9.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_9.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }

        private void cboProfessor_10_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font font = cboProfessor_10.Font;
            Brush brush = Brushes.Black;
            string text = "";
            if (e.Index != -1)
            {
                text = cboProfessor_10.Items[e.Index].ToString();
            }
            if (e.Index < countForColor)
            {
                font = new Font(font, FontStyle.Bold);
                brush = Brushes.DarkGreen;
            }
            else
            {
                brush = Brushes.DarkOrange;
            }

            e.Graphics.DrawString(text, font, brush, e.Bounds);
        }
    }
}
