using System;
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
                Form l = new frmLogin();
                l.Show();
                this.Hide();
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
            Form csd = new frmClassScheduleDashboard();
            csd.Show();
            this.Hide();
        }

        private void btnListOfProfessors_Click(object sender, EventArgs e)
        {
            Form lop = new frmListOfProfessors();
            lop.Show();
            this.Hide();
        }

        public void btnMyAccount_Click(object sender, EventArgs e)
        {
            Form ma = new frmMyAccount();
            ma.Show();
            this.Hide();
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
                        btnClassScheduleDashboard.Enabled = true;
                    }
                }
            }
        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {
            frmReport fr = new frmReport();
            this.Hide();
            fr.Show();
        }
    }
}
