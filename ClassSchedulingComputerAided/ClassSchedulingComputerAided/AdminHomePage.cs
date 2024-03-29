﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSchedulingComputerAided
{
    public partial class frmAdminHomePage : MetroFramework.Forms.MetroForm
    {
        public frmAdminHomePage()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            PUPImageControl pup = new PUPImageControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(pup);

            lbl_curriculum_id.Text = md.GetCurriculumId();
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            timer1.Enabled = true;

            if (md.EmptyCurriculum() == false)
            {
                btnRooms.Enabled = false;
                btnSections.Enabled = false;
                btnClassScheduleDashboard.Enabled = false;
            }
            if (md.EmptySection() == false)
            {
                btnRooms.Enabled = false;
                btnClassScheduleDashboard.Enabled = false;
            }
            if (md.EmptyRoom() == false)
            {
                btnClassScheduleDashboard.Enabled = false;
            }
            
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            Form c = new frmCurriculum();
            c.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                md.updateLogginStatus(usersData.a_id, "0");
                Form l = new frmLogin();
                l.Show();
                this.Hide();

                //audit
                md.AuditTrail(AuditTrailData.username, "Logged Out", "Successfully!");
            }
        }

        public void btnRooms_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            roomsControl rc = new roomsControl();
            pnl.Controls.Add(rc);

            lbl_form_title.Text = "ROOMS";
        }

        public void btnSections_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            sectionsControl s = new sectionsControl();
            pnl.Controls.Add(s);
            for(int x = 0; x < md.Sections_ListCourse().Length; x++)
                if(md.Sections_ListCourse().GetValue(x).ToString() != "")
                    s.cboSelectCourse.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());
            lbl_form_title.Text = "SECTIONS";
        }

        private void btnClassScheduleDashboard_Click(object sender, EventArgs e)
        {
            ClassSchedule_Data.Professors_id = "";
            ClassSchedule_Data.professors_name = "";
            frmClassScheduleDashboard csd = new frmClassScheduleDashboard();
            csd.Show();
            this.Hide();

            //to change the state of onGoing to 1
            md.changeState("1");
        }

        private void btnListOfProfessors_Click(object sender, EventArgs e)
        {
            Form lop = new frmListOfProfessors();
            lop.Show();
            this.Hide();
        }

        public void btnMyAccount_Click(object sender, EventArgs e)
        {
            MyAccountControl mac = new MyAccountControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(mac);
            lbl_form_title.Text = "MY ACCOUNT";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PUPImageControl pup = new PUPImageControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(pup);
            lbl_form_title.Text = "ADMIN HOME";
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                lblTime.Text = DateTime.Now.ToString("h:mm tt");
                lblDay.Text = DateTime.Now.ToString("dddd");
                lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            }

            
        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {
            frmReport fr = new frmReport();
            this.Hide();
            fr.Show();
        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            EventLogControl pup = new EventLogControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(pup);
            lbl_form_title.Text = "EVENT LOG";
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackUpRestore br = new BackUpRestore();
            pnl.Controls.Clear();
            pnl.Controls.Add(br);
            lbl_form_title.Text = "BACK-UP AND RESTORE";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval == 1000)
            {
                if (md.EmptyCurriculum() == false)
                {
                    btnRooms.Enabled = false;
                    btnSections.Enabled = false;
                    btnClassScheduleDashboard.Enabled = false;
                }
                else
                {
                    if (md.EmptySection() == false)
                    {
                        btnRooms.Enabled = false;
                        btnClassScheduleDashboard.Enabled = false;
                    }
                    else
                    {
                        btnRooms.Enabled = true;
                        if (md.EmptyRoom() == false)
                        {
                            btnClassScheduleDashboard.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            btnClassScheduleDashboard.Enabled = true;
                        }
                    }
                }
            }
        }
    }
}
