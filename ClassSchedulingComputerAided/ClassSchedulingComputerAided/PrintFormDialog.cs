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
    public partial class frmPrintFormDialog : MetroFramework.Forms.MetroForm
    {
        public frmPrintFormDialog()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        private void PrintFormDialog_Load(object sender, EventArgs e)
        {
            cboSelectProgram.Items.Add("ALL");
            for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                    cboSelectProgram.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());
            cboSelectProgram.SelectedIndex = 0;

            cboTimeTable.Items.Add("ALL");
            cboTimeTable.Items.Add("SECTION");
            cboTimeTable.Items.Add("PROFESSOR");
            cboTimeTable.Items.Add("ROOM");
            cboTimeTable.SelectedIndex = 0;
        }

        private void printPreview()
        {
            curriculumData.c_id = "8";
            curriculumData.c_semester = "1ST";
            PrintDataBindingSource.DataSource = md.dgv_Example(cboSelectProgram.Text).DataSource;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSemester", "1ST"),
                new Microsoft.Reporting.WinForms.ReportParameter("pSchoolYear", "2018-2019"),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateNow", DateTime.Now.ToString("MM/dd/yyyy"))
            };
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        bool min_max = true;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (min_max == true)
            {
                this.WindowState = FormWindowState.Maximized;
                min_max = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
                min_max = true;
            }
        }

        private void cboTimeTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOption.Enabled = true;
            if (cboTimeTable.Text == "ALL")
            {
                cboOption.Items.Clear();
                cboOption.Enabled = false;
            }

            if (cboTimeTable.Text == "ROOM")
            {
                cboOption.Items.Clear();
                cboOption.Items.Add("ALL");
                //to list all active rooms
                SubjectForStudents.Rooms = new string[100];
                md.CSD_ListActiveRoom();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Rooms[x] != "")
                        cboOption.Items.Add(SubjectForStudents.Rooms[x]);
                }
                cboOption.SelectedIndex = 0;
            }
            if (cboTimeTable.Text == "SECTION")
            {
                cboOption.Items.Clear();
                cboOption.Items.Add("ALL");
                //to list all sections
                SubjectForStudents.Sections = new string[100];
                md.CSD_ListAllSections();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.Sections[x] != "")
                        cboOption.Items.Add(SubjectForStudents.Sections[x]);
                }
                cboOption.SelectedIndex = 0;
            }

            if (cboTimeTable.Text == "PROFESSOR")
            {
                cboOption.Items.Clear();
                cboOption.Items.Add("ALL");
                //to list all professor that have their scheduled
                SubjectForStudents.ProfessorsName = new string[100];
                md.CSD_ListAllProfessors();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.ProfessorsName[x] != "" && SubjectForStudents.ProfessorsName[x] != "TBA")
                        cboOption.Items.Add(SubjectForStudents.ProfessorsName[x]);
                }
                cboOption.SelectedIndex = 0;
            }
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            btnMaximize.Visible = true;
            pnlStart.Visible = false;
            printPreview();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Bitmap bmp;
        private void btnViewPrintTimeTable_Click(object sender, EventArgs e)
        {
            Print(pnlStart);
        } 

        public void Print(Panel pnl)
        {
            getPrintArea(pnlStart);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        public void getPrintArea(Panel pnl)
        {
            bmp = new Bitmap(pnlStart.Width, pnlStart.Height);
            pnlStart.DrawToBitmap(bmp, new Rectangle(0, 0, pnlStart.Width, pnlStart.Height));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pageArea.Width / 2) - (pnlStart.Width / 2), pnlStart.Location.Y);
        }
    }
}
