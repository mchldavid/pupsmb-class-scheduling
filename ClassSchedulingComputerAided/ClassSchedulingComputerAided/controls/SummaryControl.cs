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
    public partial class SummaryControl : UserControl
    {
        public SummaryControl()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            //to list all Active Rooms

            pnlStart.BringToFront();

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
                else
                {
                    sy += dt.Year.ToString();
                    dt = dt.AddYears(1);
                    sy += "-" + dt.Year.ToString();
                    cboSchoolYear.Items.Add(sy);
                    sy = "";
                    flag = false;
                }
            }

            SubjectForStudents.Rooms = new string[100];
            md.CSD_ListActiveRoom();
            for (int x = 0; x < 50; x++)//set to 50 loop
            {
                if (SubjectForStudents.Rooms[x] != "")
                    cboRoom.Items.Add(SubjectForStudents.Rooms[x]);
            }

            cboSemester.Text = ClassSchedule_Data.semester;
            cboSchoolYear.Text = ClassSchedule_Data.schoolYear;

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassSchedule_Data.roomCode = cboRoom.SelectedItem.ToString();

            SummaryData.roomCode = cboRoom.Text;

            SummaryRoomScheduledControl room = new SummaryRoomScheduledControl();
            pnlRoomSummary.Controls.Clear();
            pnlRoomSummary.Controls.Add(room);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            SummaryData.semester = cboSemester.Text;
            SummaryData.schoolYear = cboSchoolYear.Text;
        }

        private void btnOKk_Click(object sender, EventArgs e)
        {

        }
    }
}
