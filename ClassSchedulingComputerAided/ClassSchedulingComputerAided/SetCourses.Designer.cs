namespace ClassSchedulingComputerAided
{
    partial class frmSetCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetCourses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAddCourseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditCourse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAddCourseAcronym = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCancel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.pnlAddCourse = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pnlEditCourse = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEditCourseName = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEditCourseAcronym = new MetroFramework.Controls.MetroTextBox();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.lbl_title = new MetroFramework.Controls.MetroLabel();
            this.lbl_control_id = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboCourseDepartment = new System.Windows.Forms.ComboBox();
            this.lblRowId = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.pnlAddCourse.SuspendLayout();
            this.pnlEditCourse.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddCourseName
            // 
            this.txtAddCourseName.Location = new System.Drawing.Point(49, 83);
            this.txtAddCourseName.Multiline = true;
            this.txtAddCourseName.Name = "txtAddCourseName";
            this.txtAddCourseName.Size = new System.Drawing.Size(209, 53);
            this.txtAddCourseName.TabIndex = 157;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 156;
            this.metroLabel1.Text = "Course Name:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEditCourse);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 537);
            this.panel1.TabIndex = 162;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCourse.BorderRadius = 0;
            this.btnAddCourse.ButtonText = "    Add Course";
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCourse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Iconimage")));
            this.btnAddCourse.Iconimage_right = null;
            this.btnAddCourse.Iconimage_right_Selected = null;
            this.btnAddCourse.Iconimage_Selected = null;
            this.btnAddCourse.IconMarginLeft = 0;
            this.btnAddCourse.IconMarginRight = 0;
            this.btnAddCourse.IconRightVisible = true;
            this.btnAddCourse.IconRightZoom = 0D;
            this.btnAddCourse.IconVisible = true;
            this.btnAddCourse.IconZoom = 50D;
            this.btnAddCourse.IsTab = false;
            this.btnAddCourse.Location = new System.Drawing.Point(0, 4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddCourse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAddCourse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCourse.selected = false;
            this.btnAddCourse.Size = new System.Drawing.Size(157, 42);
            this.btnAddCourse.TabIndex = 159;
            this.btnAddCourse.Text = "    Add Course";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Textcolor = System.Drawing.Color.White;
            this.btnAddCourse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "    Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 130);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(157, 42);
            this.bunifuFlatButton1.TabIndex = 159;
            this.bunifuFlatButton1.Text = "    Home";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "    Delete Course";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 50D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(0, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(157, 42);
            this.btnDelete.TabIndex = 159;
            this.btnDelete.Text = "    Delete Course";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnEditCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditCourse.BorderRadius = 0;
            this.btnEditCourse.ButtonText = "    Edit Course";
            this.btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCourse.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditCourse.ForeColor = System.Drawing.Color.White;
            this.btnEditCourse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditCourse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditCourse.Iconimage")));
            this.btnEditCourse.Iconimage_right = null;
            this.btnEditCourse.Iconimage_right_Selected = null;
            this.btnEditCourse.Iconimage_Selected = null;
            this.btnEditCourse.IconMarginLeft = 0;
            this.btnEditCourse.IconMarginRight = 0;
            this.btnEditCourse.IconRightVisible = true;
            this.btnEditCourse.IconRightZoom = 0D;
            this.btnEditCourse.IconVisible = true;
            this.btnEditCourse.IconZoom = 50D;
            this.btnEditCourse.IsTab = false;
            this.btnEditCourse.Location = new System.Drawing.Point(0, 46);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditCourse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnEditCourse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditCourse.selected = false;
            this.btnEditCourse.Size = new System.Drawing.Size(157, 42);
            this.btnEditCourse.TabIndex = 159;
            this.btnEditCourse.Text = "    Edit Course";
            this.btnEditCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCourse.Textcolor = System.Drawing.Color.White;
            this.btnEditCourse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // txtAddCourseAcronym
            // 
            this.txtAddCourseAcronym.Location = new System.Drawing.Point(49, 162);
            this.txtAddCourseAcronym.Name = "txtAddCourseAcronym";
            this.txtAddCourseAcronym.Size = new System.Drawing.Size(209, 31);
            this.txtAddCourseAcronym.TabIndex = 164;
            this.txtAddCourseAcronym.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 25);
            this.metroLabel2.TabIndex = 163;
            this.metroLabel2.Text = "Course Acronym:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(49, 241);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(210, 32);
            this.btnAddCancel.TabIndex = 166;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 32);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlAddCourse
            // 
            this.pnlAddCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAddCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCourse.Controls.Add(this.bunifuSeparator2);
            this.pnlAddCourse.Controls.Add(this.metroLabel5);
            this.pnlAddCourse.Controls.Add(this.txtAddCourseName);
            this.pnlAddCourse.Controls.Add(this.btnAddCancel);
            this.pnlAddCourse.Controls.Add(this.btnAdd);
            this.pnlAddCourse.Controls.Add(this.metroLabel1);
            this.pnlAddCourse.Controls.Add(this.metroLabel2);
            this.pnlAddCourse.Controls.Add(this.txtAddCourseAcronym);
            this.pnlAddCourse.Location = new System.Drawing.Point(148, 107);
            this.pnlAddCourse.Name = "pnlAddCourse";
            this.pnlAddCourse.Size = new System.Drawing.Size(300, 280);
            this.pnlAddCourse.TabIndex = 167;
            this.pnlAddCourse.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 42);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(266, 18);
            this.bunifuSeparator2.TabIndex = 168;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(-3, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 33);
            this.metroLabel5.TabIndex = 167;
            this.metroLabel5.Text = "Add course";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(152, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(157, 22);
            this.metroLabel4.TabIndex = 171;
            this.metroLabel4.Text = "List of all courses:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEditCourse
            // 
            this.pnlEditCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlEditCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditCourse.Controls.Add(this.bunifuSeparator3);
            this.pnlEditCourse.Controls.Add(this.metroLabel6);
            this.pnlEditCourse.Controls.Add(this.txtEditCourseName);
            this.pnlEditCourse.Controls.Add(this.btnCancel);
            this.pnlEditCourse.Controls.Add(this.btnSave);
            this.pnlEditCourse.Controls.Add(this.metroLabel7);
            this.pnlEditCourse.Controls.Add(this.metroLabel8);
            this.pnlEditCourse.Controls.Add(this.txtEditCourseAcronym);
            this.pnlEditCourse.Location = new System.Drawing.Point(149, 107);
            this.pnlEditCourse.Name = "pnlEditCourse";
            this.pnlEditCourse.Size = new System.Drawing.Size(300, 280);
            this.pnlEditCourse.TabIndex = 169;
            this.pnlEditCourse.Visible = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(15, 42);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(266, 18);
            this.bunifuSeparator3.TabIndex = 168;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(-3, 10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 33);
            this.metroLabel6.TabIndex = 167;
            this.metroLabel6.Text = "Edit Course";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEditCourseName
            // 
            this.txtEditCourseName.Location = new System.Drawing.Point(49, 81);
            this.txtEditCourseName.Multiline = true;
            this.txtEditCourseName.Name = "txtEditCourseName";
            this.txtEditCourseName.Size = new System.Drawing.Size(209, 53);
            this.txtEditCourseName.TabIndex = 157;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(49, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 32);
            this.btnCancel.TabIndex = 166;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnEditClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(49, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 32);
            this.btnSave.TabIndex = 165;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(49, 55);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 25);
            this.metroLabel7.TabIndex = 156;
            this.metroLabel7.Text = "Course Name:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(49, 137);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 25);
            this.metroLabel8.TabIndex = 163;
            this.metroLabel8.Text = "Course Acronym:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEditCourseAcronym
            // 
            this.txtEditCourseAcronym.Location = new System.Drawing.Point(49, 162);
            this.txtEditCourseAcronym.Name = "txtEditCourseAcronym";
            this.txtEditCourseAcronym.Size = new System.Drawing.Size(209, 31);
            this.txtEditCourseAcronym.TabIndex = 164;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(503, 557);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 32);
            this.btnNext.TabIndex = 175;
            this.btnNext.Text = "NEXT";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.CustomBackground = true;
            this.lbl_title.CustomForeColor = true;
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(8, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(511, 18);
            this.lbl_title.TabIndex = 176;
            this.lbl_title.Text = "Curriculum Title:";
            // 
            // lbl_control_id
            // 
            this.lbl_control_id.Location = new System.Drawing.Point(153, 571);
            this.lbl_control_id.Name = "lbl_control_id";
            this.lbl_control_id.Size = new System.Drawing.Size(108, 18);
            this.lbl_control_id.TabIndex = 177;
            this.lbl_control_id.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 70);
            this.panel2.TabIndex = 178;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(5, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 36);
            this.label12.TabIndex = 138;
            this.label12.Text = "SET COURSES";
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.Location = new System.Drawing.Point(163, 135);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(424, 416);
            this.dgvShow.TabIndex = 179;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.cboCourseDepartment);
            this.panel3.Location = new System.Drawing.Point(148, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 39);
            this.panel3.TabIndex = 240;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.CustomBackground = true;
            this.txtUsername.Location = new System.Drawing.Point(73, 10);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 21);
            this.txtUsername.TabIndex = 134;
            // 
            // metroLabel3
            // 
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel3.Location = new System.Drawing.Point(4, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 21);
            this.metroLabel3.TabIndex = 135;
            this.metroLabel3.Text = "Search:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCourseDepartment
            // 
            this.cboCourseDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourseDepartment.FormattingEnabled = true;
            this.cboCourseDepartment.Location = new System.Drawing.Point(223, 10);
            this.cboCourseDepartment.Name = "cboCourseDepartment";
            this.cboCourseDepartment.Size = new System.Drawing.Size(128, 21);
            this.cboCourseDepartment.TabIndex = 236;
            // 
            // lblRowId
            // 
            this.lblRowId.Location = new System.Drawing.Point(153, 557);
            this.lblRowId.Name = "lblRowId";
            this.lblRowId.Size = new System.Drawing.Size(108, 18);
            this.lblRowId.TabIndex = 177;
            this.lblRowId.Text = "row id";
            // 
            // frmSetCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(605, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblRowId);
            this.Controls.Add(this.pnlEditCourse);
            this.Controls.Add(this.lbl_control_id);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlAddCourse);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.panel1);
            this.Movable = false;
            this.Name = "frmSetCourses";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.SetCourses_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAddCourse.ResumeLayout(false);
            this.pnlEditCourse.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnAddCancel;
        public MetroFramework.Controls.MetroButton btnAdd;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox txtAddCourseName;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddCourse;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditCourse;
        public MetroFramework.Controls.MetroTextBox txtAddCourseAcronym;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.Panel pnlAddCourse;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public System.Windows.Forms.Panel pnlEditCourse;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroTextBox txtEditCourseName;
        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroTextBox txtEditCourseAcronym;
        public MetroFramework.Controls.MetroButton btnNext;
        public MetroFramework.Controls.MetroLabel lbl_title;
        public MetroFramework.Controls.MetroLabel lbl_control_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Panel panel3;
        public MetroFramework.Controls.MetroTextBox txtUsername;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public System.Windows.Forms.ComboBox cboCourseDepartment;
        public MetroFramework.Controls.MetroLabel lblRowId;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelete;
    }
}