﻿using System;
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
    public partial class preferredSubjectsControl : UserControl
    {
        public preferredSubjectsControl()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void preferredSubjectsControl_Load(object sender, EventArgs e)
        {
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
            loadData();//load savedata
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = true;
            pnlAddSubject.BringToFront();
            cboSubjectBy.SelectedIndex = 0;
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects("Course Subject", cboSemester.Text).DataSource;
            dgvAddSubject.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddSubject.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddSubject.SelectedRows)
            {
                md.Prof_AddSubjects(row.Cells[0].Value.ToString(), cboSemester.Text, cboSchoolYear.Text);

                dgvListSubject.DataSource = md.dgv_showPreferredSubjects(cboSemester.Text, cboSchoolYear.Text).DataSource;
                dgvListSubject.Columns[0].Visible = false;
                lblTotalUnits.Text = md.getTotalUnits(cboSemester.Text, cboSchoolYear.Text).ToString();
                lblTotalSubjects.Text = md.getTotalSubjects(cboSemester.Text, cboSchoolYear.Text).ToString();
                MessageBox.Show("You added " + row.Cells[2].Value.ToString() + " into your preferred subjects", "Adding of Subject");
            }
        }

        private void cboSubjectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAddSubject.DataSource = md.dgv_showAddPreferredSubjects(cboSubjectBy.SelectedItem.ToString(), cboSemester.Text).DataSource;
            dgvAddSubject.Columns[0].Visible = false;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListSubject.SelectedRows)
            {
                string ps_id = row.Cells[0].Value.ToString();
                string s_code = row.Cells[1].Value.ToString();
                string s_desc = row.Cells[2].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ["+ s_code + "-" +s_desc+"] from your preferred subjects?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    md.Prof_DeleteSubjects(ps_id);
                    dgvListSubject.DataSource = md.dgv_showPreferredSubjects(cboSemester.Text, cboSchoolYear.Text).DataSource;
                    dgvListSubject.Columns[0].Visible = false;
                    lblTotalUnits.Text = md.getTotalUnits(cboSemester.Text, cboSchoolYear.Text).ToString();
                    lblTotalSubjects.Text = md.getTotalSubjects(cboSemester.Text, cboSchoolYear.Text).ToString();
                    //MessageBox.Show("["+s_code + "-" + s_desc +"] Deleted successfully!", "Delete Subject");
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;

            saveData();

            lbl_title.Text = "[" + cboSemester.Text + " Semester] [SY:" + cboSchoolYear.Text + "]";

            dgvListSubject.DataSource = md.dgv_showPreferredSubjects(cboSemester.Text, cboSchoolYear.Text).DataSource;
            dgvListSubject.Columns[0].Visible = false;

            lblTotalUnits.Text = md.getTotalUnits(cboSemester.Text, cboSchoolYear.Text).ToString();
            lblTotalSubjects.Text = md.getTotalSubjects(cboSemester.Text, cboSchoolYear.Text).ToString();
            lblUnitsAllowed.Text = usersData.p_uAllowed;
        }

        private void saveData()
        {
            SaveInfoData sid = new SaveInfoData();
            sid.ProfSemester = cboSemester.SelectedIndex;
            sid.ProfSchoolYear = cboSchoolYear.SelectedIndex;
            string name = usersData.p_id + "user";
            SaveXML.SaveData(sid, name + ".xml");
        }

        private void loadData()
        {
            string name = usersData.p_id + "user";
            if (File.Exists(name + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(SaveInfoData));
                FileStream read = new FileStream(name + ".xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                SaveInfoData sid = (SaveInfoData)xs.Deserialize(read);

                cboSemester.SelectedIndex = sid.ProfSemester;
                cboSchoolYear.SelectedIndex = sid.ProfSchoolYear;
            }
        }
    }
}
