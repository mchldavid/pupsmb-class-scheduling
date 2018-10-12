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
        string errorSchedule = "";
        string successfulSchedule = "";

        private void professorsScheduleControl_Load(object sender, EventArgs e)
        {
            //lbl_id.Text = usersData.p_id;
            dgvShow.DataSource = md.dgv_showSchedule().DataSource;
            dgvShow.Columns[0].Visible = false;
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
                successfulSchedule += string.Format("-{0} {1}-{2} \r\n",day, cboStartTime.Text, cboEndTime.Text);
                //MessageBox.Show("Your preferred schedule has been added", day);
            }
            else
            {
                errorSchedule += string.Format("-{0} {1}-{2} \r\n", day, cboStartTime.Text, cboEndTime.Text);
               // MessageBox.Show(message, day);
            }
            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            successfulSchedule = "";
            errorSchedule = "";
            if (cboStartTime.SelectedIndex != -1 && cboEndTime.SelectedIndex != -1)
            {
                if (checkTime() == true)
                {
                    if (checkDay() == true)
                    {
                        if (btnAdd.Text == "Add")
                        {
                            if (chkMonday.Checked == true)
                            {
                                if (checkConstraints("Monday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Monday");
                                    defaultStatus();
                                }
                            if (chkTuesday.Checked == true)
                            {
                                if (checkConstraints("Tuesday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Tuesday");
                                    defaultStatus();
                                }
                            }
                            if (chkWednesday.Checked == true)
                            {
                                if (checkConstraints("Wednesday") == true)
                                {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Wednesday");
                                    defaultStatus();
                                }
                            }
                            if (chkThursday.Checked == true)
                            {
                                if (checkConstraints("Thursday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Thursday");
                                    defaultStatus();
                                }
                            }
                            if (chkFriday.Checked == true)
                            {
                                if (checkConstraints("Friday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Friday");
                                    defaultStatus();
                                }
                            }
                            if (chkSaturday.Checked == true)
                            {
                                if (checkConstraints("Saturday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Saturday");
                                    defaultStatus();
                                }
                            }
                            if (chkSunday.Checked == true)
                            {
                                if (checkConstraints("Sunday") == true)
                                    {
                                    md.Prof_AddSchedule(usersData.p_id, cboStartTime.SelectedItem.ToString(), cboEndTime.SelectedItem.ToString(), "Sunday");
                                    defaultStatus();
                                }
                            }

                            if(successfulSchedule != "")
                            MessageBox.Show("Your preferred schedule was added: \r\n" + successfulSchedule,"Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(errorSchedule != "")
                            MessageBox.Show("There was a conflict on these schedule: \r\n" + errorSchedule, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult dr = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                if (chkMonday.Checked == true)
                                {
                                    if (checkConstraints("Monday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Monday");
                                        defaultStatus();
                                    }
                                }
                                if (chkTuesday.Checked == true)
                                {
                                    if (checkConstraints("Tuesday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Tuesday");
                                        defaultStatus();
                                    }
                                }
                                if (chkWednesday.Checked == true)
                                {
                                    if (checkConstraints("Wednesday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Wednesday");
                                        defaultStatus();
                                    }
                                }
                                if (chkThursday.Checked == true)
                                {
                                    if (checkConstraints("Thursday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Thursday");
                                        defaultStatus();
                                    }
                                }
                                if (chkFriday.Checked == true)
                                {
                                    if (checkConstraints("Friday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Friday");
                                        defaultStatus();
                                    }
                                }
                                if (chkSaturday.Checked == true)
                                {
                                    if (checkConstraints("Saturday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Saturday");
                                        defaultStatus();
                                    }
                                }
                                if (chkSunday.Checked == true)
                                {
                                    if (checkConstraints("Sunday") == true)
                                    {
                                        md.Prof_UpdatePrefSchedule(id, cboStartTime.Text, cboEndTime.Text, "Sunday");
                                        defaultStatus();
                                    }
                                }
                                if (successfulSchedule != "")
                                    MessageBox.Show("Your preferred schedule was added: \r\n" + successfulSchedule, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (errorSchedule != "")
                                    MessageBox.Show("There was a conflict on these schedule: \r\n" + errorSchedule, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
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
        }

        public void defaultStatus()
        {
            btnAdd.Text = "Add";
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;
            cboStartTime.SelectedIndex = -1;
            cboEndTime.SelectedIndex = -1;
            gboDay.Enabled = true;
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

        string id = "";
        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;
            foreach (DataGridViewRow row in dgvShow.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                string day = row.Cells[1].Value.ToString();
                string sT = row.Cells[2].Value.ToString();
                string eT = row.Cells[3].Value.ToString();

                if (day == chkMonday.Text)
                    chkMonday.Checked = true;
                if (day == chkTuesday.Text)
                    chkTuesday.Checked = true;
                if (day == chkWednesday.Text)
                    chkWednesday.Checked = true;
                if (day == chkThursday.Text)
                    chkThursday.Checked = true;
                if (day == chkFriday.Text)
                    chkFriday.Checked = true;
                if (day == chkSaturday.Text)
                    chkSaturday.Checked = true;
                if (day == chkSunday.Text)
                    chkSunday.Checked = true;

                cboStartTime.Text = sT;
                cboEndTime.Text = eT;

                btnAdd.Text = "Save";

                gboDay.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;

            cboStartTime.SelectedIndex = -1;
            cboEndTime.SelectedIndex = -1;

            gboDay.Enabled = true;

            btnAdd.Text = "Add";
        }
    }
}
