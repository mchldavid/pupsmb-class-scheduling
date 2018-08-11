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
            lbl_curriculum_id.Text = md.GetCurriculumId();
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            Form c = new frmCurriculum();
            c.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form l = new frmLogin();
            l.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Form r = new frmRooms();
            r.Show();
            this.Hide();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            frmSections s = new frmSections();
            s.Show();
            for(int x = 0; x < md.Sections_ListCourse(lbl_curriculum_id.Text).Length; x++)
                if(md.Sections_ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
                    s.cboSelectCourse.Items.Add(md.Sections_ListCourse(lbl_curriculum_id.Text).GetValue(x).ToString());
            this.Hide();
        }

        private void btnClassScheduleDashboard_Click(object sender, EventArgs e)
        {
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

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            Form ma = new frmMyAccount();
            ma.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
