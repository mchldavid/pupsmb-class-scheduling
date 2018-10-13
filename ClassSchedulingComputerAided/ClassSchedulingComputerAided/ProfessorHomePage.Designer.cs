namespace ClassSchedulingComputerAided
{
    partial class frmProfessorHomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessorHomePage));
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfessorsScheduled = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyPreferredSubjects = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyPreferredSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMyInformation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new MetroFramework.Controls.MetroLabel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.timer123 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.sidePanel);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnProfessorsScheduled);
            this.panel3.Controls.Add(this.btnMyPreferredSubjects);
            this.panel3.Controls.Add(this.btnMyPreferredSchedule);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.btnMyInformation);
            this.panel3.Location = new System.Drawing.Point(-2, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 528);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.sidePanel.Location = new System.Drawing.Point(-2, 73);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 39);
            this.sidePanel.TabIndex = 111;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 73);
            this.panel2.TabIndex = 141;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "    Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 25;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 52D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 278);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(236, 42);
            this.btnLogout.TabIndex = 109;
            this.btnLogout.Text = "    Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfessorsScheduled
            // 
            this.btnProfessorsScheduled.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnProfessorsScheduled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnProfessorsScheduled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfessorsScheduled.BorderRadius = 0;
            this.btnProfessorsScheduled.ButtonText = "    Class Schedule";
            this.btnProfessorsScheduled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessorsScheduled.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfessorsScheduled.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfessorsScheduled.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProfessorsScheduled.Iconimage")));
            this.btnProfessorsScheduled.Iconimage_right = null;
            this.btnProfessorsScheduled.Iconimage_right_Selected = null;
            this.btnProfessorsScheduled.Iconimage_Selected = null;
            this.btnProfessorsScheduled.IconMarginLeft = 24;
            this.btnProfessorsScheduled.IconMarginRight = 0;
            this.btnProfessorsScheduled.IconRightVisible = true;
            this.btnProfessorsScheduled.IconRightZoom = 0D;
            this.btnProfessorsScheduled.IconVisible = true;
            this.btnProfessorsScheduled.IconZoom = 52D;
            this.btnProfessorsScheduled.IsTab = false;
            this.btnProfessorsScheduled.Location = new System.Drawing.Point(0, 237);
            this.btnProfessorsScheduled.Name = "btnProfessorsScheduled";
            this.btnProfessorsScheduled.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnProfessorsScheduled.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnProfessorsScheduled.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfessorsScheduled.selected = false;
            this.btnProfessorsScheduled.Size = new System.Drawing.Size(236, 42);
            this.btnProfessorsScheduled.TabIndex = 106;
            this.btnProfessorsScheduled.Text = "    Class Schedule";
            this.btnProfessorsScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessorsScheduled.Textcolor = System.Drawing.Color.White;
            this.btnProfessorsScheduled.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessorsScheduled.Click += new System.EventHandler(this.btnProfessorsScheduled_Click);
            // 
            // btnMyPreferredSubjects
            // 
            this.btnMyPreferredSubjects.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnMyPreferredSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyPreferredSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyPreferredSubjects.BorderRadius = 0;
            this.btnMyPreferredSubjects.ButtonText = "    Preferred Courses";
            this.btnMyPreferredSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPreferredSubjects.DisabledColor = System.Drawing.Color.Gray;
            this.btnMyPreferredSubjects.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMyPreferredSubjects.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMyPreferredSubjects.Iconimage")));
            this.btnMyPreferredSubjects.Iconimage_right = null;
            this.btnMyPreferredSubjects.Iconimage_right_Selected = null;
            this.btnMyPreferredSubjects.Iconimage_Selected = null;
            this.btnMyPreferredSubjects.IconMarginLeft = 25;
            this.btnMyPreferredSubjects.IconMarginRight = 0;
            this.btnMyPreferredSubjects.IconRightVisible = true;
            this.btnMyPreferredSubjects.IconRightZoom = 0D;
            this.btnMyPreferredSubjects.IconVisible = true;
            this.btnMyPreferredSubjects.IconZoom = 52D;
            this.btnMyPreferredSubjects.IsTab = false;
            this.btnMyPreferredSubjects.Location = new System.Drawing.Point(0, 196);
            this.btnMyPreferredSubjects.Name = "btnMyPreferredSubjects";
            this.btnMyPreferredSubjects.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyPreferredSubjects.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyPreferredSubjects.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMyPreferredSubjects.selected = false;
            this.btnMyPreferredSubjects.Size = new System.Drawing.Size(236, 42);
            this.btnMyPreferredSubjects.TabIndex = 106;
            this.btnMyPreferredSubjects.Text = "    Preferred Courses";
            this.btnMyPreferredSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyPreferredSubjects.Textcolor = System.Drawing.Color.White;
            this.btnMyPreferredSubjects.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyPreferredSubjects.Click += new System.EventHandler(this.btnMyPreferredSubjects_Click);
            // 
            // btnMyPreferredSchedule
            // 
            this.btnMyPreferredSchedule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnMyPreferredSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyPreferredSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyPreferredSchedule.BorderRadius = 0;
            this.btnMyPreferredSchedule.ButtonText = "    Preferred Schedule";
            this.btnMyPreferredSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyPreferredSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnMyPreferredSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMyPreferredSchedule.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMyPreferredSchedule.Iconimage")));
            this.btnMyPreferredSchedule.Iconimage_right = null;
            this.btnMyPreferredSchedule.Iconimage_right_Selected = null;
            this.btnMyPreferredSchedule.Iconimage_Selected = null;
            this.btnMyPreferredSchedule.IconMarginLeft = 22;
            this.btnMyPreferredSchedule.IconMarginRight = 0;
            this.btnMyPreferredSchedule.IconRightVisible = true;
            this.btnMyPreferredSchedule.IconRightZoom = 0D;
            this.btnMyPreferredSchedule.IconVisible = true;
            this.btnMyPreferredSchedule.IconZoom = 60D;
            this.btnMyPreferredSchedule.IsTab = false;
            this.btnMyPreferredSchedule.Location = new System.Drawing.Point(0, 155);
            this.btnMyPreferredSchedule.Name = "btnMyPreferredSchedule";
            this.btnMyPreferredSchedule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyPreferredSchedule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyPreferredSchedule.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMyPreferredSchedule.selected = false;
            this.btnMyPreferredSchedule.Size = new System.Drawing.Size(236, 42);
            this.btnMyPreferredSchedule.TabIndex = 105;
            this.btnMyPreferredSchedule.Text = "    Preferred Schedule";
            this.btnMyPreferredSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyPreferredSchedule.Textcolor = System.Drawing.Color.White;
            this.btnMyPreferredSchedule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyPreferredSchedule.Click += new System.EventHandler(this.btnMyPreferredTime_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "    Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 25;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(236, 42);
            this.btnHome.TabIndex = 104;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMyInformation
            // 
            this.btnMyInformation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(149)))), ((int)(((byte)(1)))));
            this.btnMyInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMyInformation.BorderRadius = 0;
            this.btnMyInformation.ButtonText = "    Information";
            this.btnMyInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyInformation.DisabledColor = System.Drawing.Color.Gray;
            this.btnMyInformation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMyInformation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMyInformation.Iconimage")));
            this.btnMyInformation.Iconimage_right = null;
            this.btnMyInformation.Iconimage_right_Selected = null;
            this.btnMyInformation.Iconimage_Selected = null;
            this.btnMyInformation.IconMarginLeft = 24;
            this.btnMyInformation.IconMarginRight = 0;
            this.btnMyInformation.IconRightVisible = true;
            this.btnMyInformation.IconRightZoom = 0D;
            this.btnMyInformation.IconVisible = true;
            this.btnMyInformation.IconZoom = 55D;
            this.btnMyInformation.IsTab = false;
            this.btnMyInformation.Location = new System.Drawing.Point(0, 114);
            this.btnMyInformation.Name = "btnMyInformation";
            this.btnMyInformation.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMyInformation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMyInformation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMyInformation.selected = false;
            this.btnMyInformation.Size = new System.Drawing.Size(236, 42);
            this.btnMyInformation.TabIndex = 104;
            this.btnMyInformation.Text = "    Information";
            this.btnMyInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyInformation.Textcolor = System.Drawing.Color.White;
            this.btnMyInformation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyInformation.Click += new System.EventHandler(this.btnMyInformation_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(232, 15);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 3;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(587, 427);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 13);
            this.lbl_id.TabIndex = 110;
            this.lbl_id.Text = "Control Id";
            this.lbl_id.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightCoral;
            this.label12.Location = new System.Drawing.Point(2, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 36);
            this.label12.TabIndex = 138;
            this.label12.Text = "Professor Home";
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(0, -3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(672, 10);
            this.metroLabel4.TabIndex = 139;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Location = new System.Drawing.Point(226, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 70);
            this.panel1.TabIndex = 140;
            // 
            // lbl_title
            // 
            this.lbl_title.CustomBackground = true;
            this.lbl_title.CustomForeColor = true;
            this.lbl_title.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_title.Location = new System.Drawing.Point(6, 42);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(511, 18);
            this.lbl_title.TabIndex = 245;
            this.lbl_title.Text = "Polytechnic University of the Philippines, Sta. Maria Campus";
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.LightCoral;
            this.lblDay.Location = new System.Drawing.Point(515, 25);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(126, 17);
            this.lblDay.TabIndex = 141;
            this.lblDay.Text = "Wednesday";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.LightCoral;
            this.lblDate.Location = new System.Drawing.Point(500, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 18);
            this.lblDate.TabIndex = 142;
            this.lblDate.Text = "29 December 1991";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTime.Location = new System.Drawing.Point(485, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(187, 24);
            this.lblTime.TabIndex = 143;
            this.lblTime.Text = "00:00 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl.Controls.Add(this.lbl_id);
            this.pnl.Location = new System.Drawing.Point(226, 67);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(668, 452);
            this.pnl.TabIndex = 141;
            // 
            // timer123
            // 
            this.timer123.Interval = 1000;
            this.timer123.Tick += new System.EventHandler(this.timer123_Tick);
            // 
            // frmProfessorHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfessorHomePage";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ProfessorHomePage_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Panel panel3;
        public Bunifu.Framework.UI.BunifuFlatButton btnMyInformation;
        public Bunifu.Framework.UI.BunifuFlatButton btnMyPreferredSubjects;
        public Bunifu.Framework.UI.BunifuFlatButton btnMyPreferredSchedule;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private System.Windows.Forms.Label label12;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel sidePanel;
        public Bunifu.Framework.UI.BunifuFlatButton btnHome;
        public Bunifu.Framework.UI.BunifuFlatButton btnProfessorsScheduled;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        public MetroFramework.Controls.MetroLabel lbl_title;
        private System.Windows.Forms.Timer timer123;

    }
}