using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;

namespace ClassSchedulingComputerAided
{
    public partial class frmPrintFormDialog : MetroFramework.Forms.MetroForm
    {
        public frmPrintFormDialog()
        {
            InitializeComponent();
        }
        MyDatabase md = new MyDatabase();
        PaperSize paperSize = new PaperSize("papersize", 792, 612);//set the paper size

        private void PrintFormDialog_Load(object sender, EventArgs e)
        {

            cboTimeTable.Items.Add("PROGRAM");
            cboTimeTable.Items.Add("SECTION");
            cboTimeTable.Items.Add("PROFESSOR");
            cboTimeTable.Items.Add("ROOM");
            
            cboTimeTable.SelectedIndex = 0;

            pnlPrintTimeTable.Controls.Clear();
            SummaryData.section = "BSA 3 - 1";
            SummaryStudentScheduledControl section = new SummaryStudentScheduledControl();
            pnlPrintTimeTable.Controls.Clear();
            pnlPrintTimeTable.Controls.Add(section);

            int width = pnlPrintTimeTable.Size.Width;
            int height = pnlPrintTimeTable.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            pnlPrintTimeTable.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            //SaveFileDialog dialog = new SaveFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //   int w = Convert.ToInt32(pnlPrintTimeTable.Width); 
            //   int h = Convert.ToInt32(pnlPrintTimeTable.Height);
            //   Bitmap bmp = new Bitmap(w, h);        
            //   pnlPrintTimeTable.DrawToBitmap(bmp, new Rectangle(0, 0, w, h));
            //   bmp.Save(dialog.FileName, ImageFormat.Png);
            //}
        }

        private void printPreview()
        {
            curriculumData.c_id = "8";
            curriculumData.c_semester = "1ST";
            PrintDataBindingSource.DataSource = md.dgv_Example(cboTimeTable.Text, cboOption.Text).DataSource;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSemester", SummaryData.semester),
                new Microsoft.Reporting.WinForms.ReportParameter("pSchoolYear", SummaryData.schoolYear),
                new Microsoft.Reporting.WinForms.ReportParameter("pDateNow", DateTime.Now.ToString("MM/dd/yyyy"))
            };
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void printPreview1()
        {
            curriculumData.c_id = "8";
            curriculumData.c_semester = "1ST";
            PrintDataBindingSource.DataSource = md.dgv_Example(cboTimeTable.Text, cboOption.Text).DataSource;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pSemester", SummaryData.semester),
                new Microsoft.Reporting.WinForms.ReportParameter("pSchoolYear", SummaryData.schoolYear),
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
                //to list all professor that have their scheduled
                SubjectForStudents.ProfessorsName = new string[100];
                md.CSD_ListAllProfessors();
                for (int x = 0; x < 50; x++)//set to 50 loop
                {
                    if (SubjectForStudents.ProfessorsName[x] != "")
                        cboOption.Items.Add(SubjectForStudents.ProfessorsName[x]);
                }
                cboOption.SelectedIndex = 0;
            }

            if (cboTimeTable.Text == "PROGRAM")
            {
                cboOption.Items.Clear();
                cboOption.Items.Add("ALL");
                for (int x = 0; x < md.Sections_ListCourse().Length; x++)
                    if (md.Sections_ListCourse().GetValue(x).ToString() != "")
                        cboOption.Items.Add(md.Sections_ListCourse().GetValue(x).ToString());
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

        private void btnViewPrintTimeTable_Click(object sender, EventArgs e)
        {
            btnMaximize.Visible = true;
            pnlStart.Visible = false;
            printPreview1();

            //printPreviewDialog1.Document = pdocSection;
            //((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Enabled
            //= false;//disable the direct print from printpreview.as when we click that Print button PrintPage event fires again.
            //pdocSection.DefaultPageSettings.PaperSize = paperSize;
            //printPreviewDialog1.ShowDialog();
        } 

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        int itemperPage = 0;
        private void pdocSection_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // declare  one variable for height measurement
            e.Graphics.DrawString("Print in Multiple Pages", DefaultFont, Brushes.Black, 10, 0);//this will print one heading/title in every page of the document
            //currentY += 15;
            Bitmap bmp = new Bitmap(pnlPrintTimeTable.Width, pnlPrintTimeTable.Height);
            pnlPrintTimeTable.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPrintTimeTable.Width, pnlPrintTimeTable.Height));
            Rectangle pageArea = e.PageBounds;

            while (itemperPage <= 5)
            {
                
                itemperPage++;
                e.Graphics.DrawImage(bmp, (pageArea.Width / 2) - (pnlPrintTimeTable.Width / 2), 20);
                e.HasMorePages = true;
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
