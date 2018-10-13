using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using ExcelDataReader;
using System.Text.RegularExpressions;

namespace ClassSchedulingComputerAided
{
    public partial class frmSetCurriculum : MetroFramework.Forms.MetroForm
    {
        public frmSetCurriculum()
        {
            InitializeComponent();
        }

        MyDatabase md = new MyDatabase();
        string id = "";

        private void SetCurriculum_Load(object sender, EventArgs e)
        {
            cboBy.Items.Add("Subject Code");
            cboBy.Items.Add("Subject Description");
            cboBy.SelectedIndex = 0;

            cboUnits.SelectedIndex = 0;
            cboLectureHours.SelectedIndex = 0;
            cboLabHours.SelectedIndex = 0;
            cboYearLevel.SelectedIndex = 0;
            dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
            dgvListSubject.Columns[0].Visible = false;

            for (int x = 0; x < md.ListCourse(curriculumData.c_id).Length; x++)
            {
                if (md.ListCourse(curriculumData.c_id).GetValue(x).ToString() != "")
                    cboCourse.Items.Add(md.ListCourse(curriculumData.c_id).GetValue(x).ToString());
            }
            cboCourse.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCurriculum c = new frmCurriculum();
            c.Show();
            this.Hide();
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //frmSetCourses sc = new frmSetCourses();
            //sc.Show();
            //sc.lbl_control_id.Text = curriculumData.c_id;
            //sc.lbl_title.Text = lbl_title.Text;
            //this.Hide();
            frmSemesterAndSchoolYear sas = new frmSemesterAndSchoolYear();
            sas.Show();
            this.Hide();
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmViewList v = new frmViewList();
            v.Show();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject a = new frmAddSubject();
            a.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.SelectedItem.ToString(), cboLabHours.SelectedItem.ToString(), cboUnits.SelectedItem.ToString(), cboYearLevel.SelectedItem.ToString(), curriculumData.c_semester);
                dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                dgvListSubject.Columns[0].Visible = false;

                MessageBox.Show(txtSubjectCode.Text + " added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSubjectCode.Text = "";
                txtSubjectDescription.Text = "";

                cboUnits.SelectedIndex = 0;
                cboLectureHours.SelectedIndex = 0;
                cboLabHours.SelectedIndex = 0;
                cboYearLevel.SelectedIndex = 0;

                txtSubjectCode.Focus();

                //audit
                md.AuditTrail(AuditTrailData.username, "Add", txtSubjectCode.Text + "course to the " + lbl_title.Text + " program.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == dr)
                {
                    //to change the course
                    md.C_UpdateProgramCourse(id, txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.Text, cboLabHours.Text, cboUnits.Text, cboYearLevel.Text);

                    txtSubjectCode.Text = "";
                    txtSubjectDescription.Text = "";
                    cboUnits.Text = "0";
                    cboLectureHours.Text = "0";
                    cboLabHours.Text = "0";
                    cboYearLevel.Text = "1";

                    btnAdd.Text = "ADD";

                    txtSubjectCode.Focus();

                    id = "";

                    dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                    dgvListSubject.Columns[0].Visible = false;

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Update", txtSubjectCode.Text + " from " + lbl_title.Text + ".");
                }
                else
                {
                    txtSubjectCode.Text = "";
                    txtSubjectDescription.Text = "";
                    cboUnits.Text = "0";
                    cboLectureHours.Text = "0";
                    cboLabHours.Text = "0";
                    cboYearLevel.Text = "1";

                    btnAdd.Text = "ADD";

                    txtSubjectCode.Focus();

                    id = "";

                    dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                    dgvListSubject.Columns[0].Visible = false;
                }
            }
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_course_id.Text = md.GetCourseID(cboCourse.SelectedItem.ToString(), curriculumData.c_id);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminHomePage ahp = new frmAdminHomePage();
            this.Hide();
            ahp.Show();
        }

        DataSet result;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opfd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls;*.xlsx;*.xlsm", ValidateNames = true })
                {
                    if (opfd.ShowDialog() == DialogResult.OK)
                    {
                        txtFile.Text = opfd.FileName;
                        FileStream fs = File.Open(opfd.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);
                        result = reader.AsDataSet();
                        cboSheets.Items.Clear();
                        foreach (DataTable dt in result.Tables)
                            cboSheets.Items.Add(dt.TableName);
                        cboSheets.SelectedIndex = 0;
                        reader.Close();

                        dgvData.DataSource = result.Tables[cboSheets.Text];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file you want to import is in used", "Error Occured!");
                txtFile.Text = "";
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            pnl_import.Visible = true;
            pnl_import.BringToFront();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvData.DataSource = result.Tables[cboSheets.SelectedIndex];
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            try
            {
                int countRetrieveData = 0;
                int countReplaced = 0;
                lbl_course_id.Text = md.GetCourseID(cboCourse.Text, curriculumData.c_id);// to get course id
                //dgvData.SelectAll();
                int r = 0;
                for (int i = 1; i < dgvData.Rows.Count - 1; i++)
                {
                    //md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, txtSubjectCode.Text, txtSubjectDescription.Text, cboLectureHours.SelectedItem.ToString(), cboLabHours.SelectedItem.ToString(), cboUnits.SelectedItem.ToString(), cboYearLevel.SelectedItem.ToString(), curriculumData.c_semester);

                    string pc = dgvData.Rows[i].Cells[0].Value.ToString();
                    string test = "";
                    string testData = "";
                    int a = 0;
                    foreach (char p in pc)
                    {
                        if (p != ' ') { test += p; }
                        else { if (a == 0) { testData = test; a++; } }
                    }
                    string getSection;
                    string getYear;

                    getSection = pc.Substring(pc.Length - 1, 1);
                    getYear = pc.Substring(pc.Length - 3, 1);
                    //if (getSection == '1')
                    //{

                    //}

                    if (testData == cboCourse.Text)
                    {
                        if (getSection == "1")
                        {

                            string subjectCode = dgvData.Rows[i].Cells[1].Value.ToString();
                            string subjecDescription = dgvData.Rows[i].Cells[2].Value.ToString();
                            string lecHours = dgvData.Rows[i].Cells[3].Value.ToString();
                            string labHours = dgvData.Rows[i].Cells[4].Value.ToString();
                            string units = dgvData.Rows[i].Cells[6].Value.ToString();
                            string yearLevel = getYear;

                            if (md.existProgramCourse(curriculumData.c_id, subjectCode, subjecDescription) == false)
                            {
                                md.C_AddSubjects(curriculumData.c_id, lbl_course_id.Text, cboCourse.Text, subjectCode, subjecDescription, lecHours, labHours, units, yearLevel, curriculumData.c_semester);
                            }
                            else
                            {
                                countReplaced++;
                            }

                            countRetrieveData++;
                            pnl_import.Visible = false;
                        }
                    }
                }
                dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                dgvListSubject.Columns[0].Visible = false;

                //prompt if the import had a data
                if (countRetrieveData > 0)
                {
                    if (countReplaced == 0)
                    {
                        MessageBox.Show("Import Program Course successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFile.Text = "";
                        cboSheets.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Import Program Course successfully. Some courses are already on the list.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFile.Text = "";
                        cboSheets.Items.Clear();
                    }
                }
                else
                    MessageBox.Show("No data was found! Please try to check program acronym if it match with the program acronym in the CSV file you try to import.", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //audit
                md.AuditTrail(AuditTrailData.username, "Add", cboCourse.Text + " imported from " + cboSheets.Text + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data in your file youre trying to import. Please recheck!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            pnl_import.Visible = false;
            txtFile.Text = "";
            cboSheets.Items.Clear();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete all?", "Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {
                md.C_DeleteSubjectCurriculum(curriculumData.c_id);
                MessageBox.Show("Delete successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                dgvListSubject.Columns[0].Visible = false;

                //audit
                md.AuditTrail(AuditTrailData.username, "Delete", cboCourse.Text + " courses from " + lbl_title.Text + ".");
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListSubject.DataSource = md.dgv_SearchSubjects(txtSearch.Text, cboBy.Text).DataSource;
            dgvListSubject.Columns[0].Visible = false;
        }

        private void dgvListSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvListSubject.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                txtSubjectCode.Text = row.Cells[3].Value.ToString();
                txtSubjectDescription.Text = row.Cells[4].Value.ToString();
                cboUnits.Text = row.Cells[7].Value.ToString();
                cboLectureHours.Text = row.Cells[5].Value.ToString();
                cboLabHours.Text = row.Cells[6].Value.ToString();
                cboYearLevel.Text = row.Cells[2].Value.ToString();

                btnAdd.Text = "SAVE";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "DELETE")
            {
                DialogResult dr = MessageBox.Show("Do you want to delete "+txtSubjectCode.Text+"?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == dr)
                {
                    //to delete course
                    md.C_DeleteProgramCourse(id);

                    txtSubjectCode.Text = "";
                    txtSubjectDescription.Text = "";
                    cboUnits.Text = "0";
                    cboLectureHours.Text = "0";
                    cboLabHours.Text = "0";
                    cboYearLevel.Text = "1";

                    btnAdd.Text = "ADD";

                    txtSubjectCode.Focus();

                    dgvListSubject.DataSource = md.dgv_showSubjectCurriculum().DataSource;
                    dgvListSubject.Columns[0].Visible = false;

                    //audit
                    md.AuditTrail(AuditTrailData.username, "Delete", txtSubjectCode.Text + " from " + lbl_title.Text + ".");
                }
            }
        }

        private void cboUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (cboUnits.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
            
        }

        private void cboUnits_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLectureHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (cboLectureHours.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void cboLabHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 13))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (cboLabHours.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void cboYearLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 13))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (cboYearLevel.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void cboUnits_Leave(object sender, EventArgs e)
        {
            if(cboUnits.Text == "")
            cboUnits.Text = "0";
        }

        private void cboLectureHours_Leave(object sender, EventArgs e)
        {
            if (cboLectureHours.Text == "")
            cboLectureHours.Text = "0";
        }

        private void cboLabHours_Leave(object sender, EventArgs e)
        {
            if (cboLabHours.Text == "")
            cboLabHours.Text = "0";
        }

        private void cboYearLevel_Leave(object sender, EventArgs e)
        {
            if (cboYearLevel.Text == "")
            cboYearLevel.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
