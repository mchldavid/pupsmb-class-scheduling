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
    public partial class frmProfessorHomePage : MetroFramework.Forms.MetroForm
    {
        public frmProfessorHomePage()
        {
            InitializeComponent();
            sidePanel.Height = btnMyInformation.Height - 1;
        }

        MyDatabase md = new MyDatabase();
        private void ProfessorHomePage_Load(object sender, EventArgs e)
        {
            PUPImageControl pup = new PUPImageControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(pup);

            lblTime.Text = DateTime.Now.ToString("h:mm tt");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            timer1.Enabled = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                md.updateLogginStatus(usersData.p_id, "0");
                Form l = new frmLogin();
                l.Show();
                this.Hide();

                //audit
                md.AuditTrail(AuditTrailData.username, "Logged Out", "Successfully!");
            }
        }

        private void btnMyPreferredTime_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            professorsScheduleControl psc = new professorsScheduleControl();
            pnl.Controls.Add(psc);

            sidePanel.Height = btnMyPreferredSchedule.Height - 1;
            sidePanel.Top = btnMyPreferredSchedule.Top;
            //frmPreferredSchedule pt = new frmPreferredSchedule();
            //pt.lbl_id.Text = lbl_id.Text;
            //pt.Show();
            //this.Hide();
        }

        private void btnMyPreferredSubjects_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            preferredSubjectsControl psc = new preferredSubjectsControl();
            pnl.Controls.Add(psc);

            sidePanel.Height = btnMyPreferredSubjects.Height - 1;
            sidePanel.Top = btnMyPreferredSubjects.Top;
            //frmPrefferedSubjects ps = new frmPrefferedSubjects();
            //ps.Show();
            //this.Hide();
        }

        public void btnMyInformation_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            InformtionControl ic = new InformtionControl();
            pnl.Controls.Add(ic);

            sidePanel.Height = btnMyInformation.Height - 1;
            sidePanel.Top = btnMyInformation.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            sidePanel.Height = btnHome.Height - 1;
            sidePanel.Top = btnHome.Top;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PUPImageControl pup = new PUPImageControl();
            pnl.Controls.Clear();
            pnl.Controls.Add(pup);

            pnl.Controls.Clear();
            sidePanel.Height = btnHome.Height - 1;
            sidePanel.Top = btnHome.Top;
        }

        private void btnProfessorsScheduled_Click(object sender, EventArgs e)
        {
            frmClassScheduled cs = new frmClassScheduled();
            this.Hide();
            cs.Show();

            sidePanel.Height = btnProfessorsScheduled.Height - 1;
            sidePanel.Top = btnProfessorsScheduled.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                if (md.isGoing() == true)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Class scheduling is on going. Changes are not allowed, youre about to logout!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    md.updateLogginStatus(usersData.p_id, "0");
                    Form l = new frmLogin();
                    l.Show();
                    this.Hide();

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Logged Out", "Successfully!");
                }
                lblTime.Text = DateTime.Now.ToString("h:mm tt");
                lblDay.Text = DateTime.Now.ToString("dddd");
                lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            }
        }

        
    }
}
