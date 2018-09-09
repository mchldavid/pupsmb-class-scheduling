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
    public partial class professorsScheduleControl : UserControl
    {
        public professorsScheduleControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void professorsScheduleControl_Load(object sender, EventArgs e)
        {
            //lbl_id.Text = usersData.p_id;
            dgvShow.DataSource = md.dgv_showSchedule().DataSource;
            dgvShow.Columns[0].Visible = false;
            dgvSchedule.DataSource = md.dgv_showSchedule().DataSource;
        }

        //check the time from start time to end time
        public bool checkTime()
        {
            DateTime startTime = DateTime.Parse(cboStartTime.SelectedItem.ToString());
            DateTime endTime = DateTime.Parse(cboEndTime.SelectedItem.ToString());

            bool Time_Is_Valid = false;
            int i = DateTime.Compare(startTime, endTime);
            if (i > 0)
                MessageBox.Show("End time is not valid to the Start time! Please select a valid time for the 'End Time'.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (i == 0)
                MessageBox.Show("You must set the 'End Time' higher than the 'Start time'.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (i < 0)
                Time_Is_Valid = true;
            return Time_Is_Valid;
        }

        //checking the day if it is checked
        public bool checkDay()
        {
            bool Day_is_valid = false;
            if (chkMonday.Checked == true)
                Day_is_valid = true;
            if (chkTuesday.Checked == true)
                Day_is_valid = true;
            if (chkWednesday.Checked == true)
                Day_is_valid = true;
            if (chkThursday.Checked == true)
                Day_is_valid = true;
            if (chkFriday.Checked == true)
                Day_is_valid = true;
            if (chkSaturday.Checked == true)
                Day_is_valid = true;
            if (chkSunday.Checked == true)
                Day_is_valid = true;
            return Day_is_valid;
        }

        //checkings of conflicts in that day
        public bool checkConstraints(string day)
        {
            bool isValid = true;
            int scheduleIsFree = 0;
            string message = "";
            for (int x = 0; x < md.Get_id_PSchedule(usersData.p_id).Length; x++)
            {
                string ps_id = md.Get_id_PSchedule(usersData.p_id).GetValue(x).ToString();
                if (ps_id != "")
                {
                    string sT = md.Get_info_PSchedule(ps_id).GetValue(0).ToString();
                    string eT = md.Get_info_PSchedule(ps_id).GetValue(1).ToString();
                    DateTime PS_startTime = DateTime.Parse(sT);
                    DateTime PS_endTime = DateTime.Parse(eT);
                    DateTime startTime = DateTime.Parse(cboStartTime.SelectedItem.ToString());
                    DateTime endTime = DateTime.Parse(cboEndTime.SelectedItem.ToString());
                    int dt1 = DateTime.Compare(PS_startTime, startTime);
                    int dt2 = DateTime.Compare(PS_endTime, endTime);
                    int dt3 = DateTime.Compare(PS_startTime, endTime);
                    int dt4 = DateTime.Compare(PS_endTime, startTime);
                    string promptMessage = System.String.Format("There's a conflict on {0} from {1} to {2}", day, sT, eT);

                    if (md.Get_info_PSchedule(ps_id).GetValue(2).ToString() == day)
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
                MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                MessageBox.Show(message, day);
            }
            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboStartTime.SelectedIndex != -1 && cboEndTime.SelectedIndex != -1)
            {
                if (checkTime() == true)
                {
                    if (checkDay() == true)
                    {
                        if (chkMonday.Checked == true)
                        {
                            if (checkConstraints("Monday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Monday");
                        }
                        if (chkTuesday.Checked == true)
                        {
                            if (checkConstraints("Tuesday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Tuesday");
                        }
                        if (chkWednesday.Checked == true)
                        {
                            if (checkConstraints("Wednesday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Wednesday");
                        }
                        if (chkThursday.Checked == true)
                        {
                            if (checkConstraints("Thursday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Thursday");
                        }
                        if (chkFriday.Checked == true)
                        {
                            if (checkConstraints("Friday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Friday");
                        }
                        if (chkSaturday.Checked == true)
                        {
                            if (checkConstraints("Saturday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Saturday");
                        }
                        if (chkSunday.Checked == true)
                        {
                            if (checkConstraints("Sunday") == true)
                                md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Sunday");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check a day/s", "Invalid Day", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Please select time before you add", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvShow.DataSource = md.dgv_showSchedule().DataSource;
            dgvSchedule.DataSource = md.dgv_showSchedule().DataSource;
        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            if (btnViewTimetable.Text =="VIEW")
            {
                pnlView.Visible = true;
                P_viewTimeTableControl pView = new P_viewTimeTableControl();
                pnlView.Controls.Add(pView);
                btnViewTimetable.Text = "BACK";
                pnlView.BringToFront();
            }
            else
            {
                pnlView.Visible = false;
                pnlView.Controls.Clear();
                btnViewTimetable.Text = "VIEW";
            }

        }

        private void pnlView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            foreach (DataGridViewRow dr in dgvShow.SelectedRows)
            {
                if (result == DialogResult.Yes)
                {
                    md.Prof_DeleteSchedule(dr.Cells[0].Value.ToString());
                    dgvShow.DataSource = md.dgv_showSchedule().DataSource;
                    dgvShow.Columns[0].Visible = false;
                }
            }
        }
    }
}
