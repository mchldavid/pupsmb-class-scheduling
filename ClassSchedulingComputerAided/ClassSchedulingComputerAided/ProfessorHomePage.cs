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
            sidePanel.Height = btnMyInformation.Height;
        }

        MyDatabase md = new MyDatabase();
        private void ProfessorHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Form l = new frmLogin();
                l.Show();
                this.Hide();
            }
        }

        private void btnMyPreferredTime_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            professorsScheduleControl psc = new professorsScheduleControl();
            pnl.Controls.Add(psc);

            sidePanel.Height = btnMyPreferredSchedule.Height;
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

            sidePanel.Height = btnMyPreferredSubjects.Height;
            sidePanel.Top = btnMyPreferredSubjects.Top;
            //frmPrefferedSubjects ps = new frmPrefferedSubjects();
            //ps.Show();
            //this.Hide();
        }

        private void btnMyInformation_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            InformtionControl ic = new InformtionControl();
            pnl.Controls.Add(ic);

            sidePanel.Height = btnMyInformation.Height;
            sidePanel.Top = btnMyInformation.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        
    }
}
