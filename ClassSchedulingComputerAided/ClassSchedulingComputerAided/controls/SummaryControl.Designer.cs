namespace ClassSchedulingComputerAided
{
    partial class SummaryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryControl));
            this.Students = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSectionName = new System.Windows.Forms.ComboBox();
            this.pnlSection = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCurriculum = new MetroFramework.Controls.MetroLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCtrl_Students = new System.Windows.Forms.TabControl();
            this.Professors = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProfessorName = new System.Windows.Forms.ComboBox();
            this.pnlProfessor = new System.Windows.Forms.Panel();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.pnlRoomSummary = new System.Windows.Forms.Panel();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.cboSchoolYear = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.Students.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.tbCtrl_Students.SuspendLayout();
            this.Professors.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.White;
            this.Students.Controls.Add(this.label2);
            this.Students.Controls.Add(this.cboSectionName);
            this.Students.Controls.Add(this.pnlSection);
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Students.Location = new System.Drawing.Point(4, 29);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(910, 599);
            this.Students.TabIndex = 0;
            this.Students.Text = "Students";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 251;
            this.label2.Text = "Select Section:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSectionName
            // 
            this.cboSectionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSectionName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSectionName.FormattingEnabled = true;
            this.cboSectionName.Location = new System.Drawing.Point(127, 1);
            this.cboSectionName.Name = "cboSectionName";
            this.cboSectionName.Size = new System.Drawing.Size(169, 25);
            this.cboSectionName.TabIndex = 250;
            this.cboSectionName.SelectedIndexChanged += new System.EventHandler(this.cboSectionName_SelectedIndexChanged);
            // 
            // pnlSection
            // 
            this.pnlSection.Location = new System.Drawing.Point(40, 27);
            this.pnlSection.Name = "pnlSection";
            this.pnlSection.Size = new System.Drawing.Size(820, 561);
            this.pnlSection.TabIndex = 249;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.lblCurriculum);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 38);
            this.panel2.TabIndex = 245;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageActive = null;
            this.btnPrint.Location = new System.Drawing.Point(176, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(24, 23);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrint.TabIndex = 249;
            this.btnPrint.TabStop = false;
            this.btnPrint.Zoom = 10;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.Location = new System.Drawing.Point(846, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 23);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 248;
            this.btnSettings.TabStop = false;
            this.btnSettings.Visible = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblCurriculum
            // 
            this.lblCurriculum.CustomBackground = true;
            this.lblCurriculum.CustomForeColor = true;
            this.lblCurriculum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurriculum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCurriculum.ForeColor = System.Drawing.Color.White;
            this.lblCurriculum.Location = new System.Drawing.Point(335, 4);
            this.lblCurriculum.Name = "lblCurriculum";
            this.lblCurriculum.Size = new System.Drawing.Size(512, 31);
            this.lblCurriculum.TabIndex = 178;
            this.lblCurriculum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 23);
            this.label12.TabIndex = 138;
            this.label12.Text = "Summary Report!";
            // 
            // tbCtrl_Students
            // 
            this.tbCtrl_Students.Controls.Add(this.Students);
            this.tbCtrl_Students.Controls.Add(this.Professors);
            this.tbCtrl_Students.Controls.Add(this.Rooms);
            this.tbCtrl_Students.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCtrl_Students.Location = new System.Drawing.Point(2, 37);
            this.tbCtrl_Students.Name = "tbCtrl_Students";
            this.tbCtrl_Students.SelectedIndex = 0;
            this.tbCtrl_Students.Size = new System.Drawing.Size(918, 632);
            this.tbCtrl_Students.TabIndex = 246;
            // 
            // Professors
            // 
            this.Professors.Controls.Add(this.label3);
            this.Professors.Controls.Add(this.cboProfessorName);
            this.Professors.Controls.Add(this.pnlProfessor);
            this.Professors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Professors.Location = new System.Drawing.Point(4, 29);
            this.Professors.Name = "Professors";
            this.Professors.Padding = new System.Windows.Forms.Padding(3);
            this.Professors.Size = new System.Drawing.Size(910, 599);
            this.Professors.TabIndex = 1;
            this.Professors.Text = "Professors";
            this.Professors.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 254;
            this.label3.Text = "Select Professor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboProfessorName
            // 
            this.cboProfessorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfessorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfessorName.FormattingEnabled = true;
            this.cboProfessorName.Location = new System.Drawing.Point(133, 2);
            this.cboProfessorName.Name = "cboProfessorName";
            this.cboProfessorName.Size = new System.Drawing.Size(169, 25);
            this.cboProfessorName.TabIndex = 253;
            this.cboProfessorName.SelectedIndexChanged += new System.EventHandler(this.cboProfessorName_SelectedIndexChanged);
            // 
            // pnlProfessor
            // 
            this.pnlProfessor.Location = new System.Drawing.Point(41, 26);
            this.pnlProfessor.Name = "pnlProfessor";
            this.pnlProfessor.Size = new System.Drawing.Size(820, 561);
            this.pnlProfessor.TabIndex = 252;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.label1);
            this.Rooms.Controls.Add(this.cboRoom);
            this.Rooms.Controls.Add(this.pnlRoomSummary);
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Rooms.Location = new System.Drawing.Point(4, 29);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(910, 599);
            this.Rooms.TabIndex = 2;
            this.Rooms.Text = "Rooms";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 246;
            this.label1.Text = "Select Room:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(111, 3);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(169, 25);
            this.cboRoom.TabIndex = 10;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // pnlRoomSummary
            // 
            this.pnlRoomSummary.Location = new System.Drawing.Point(38, 27);
            this.pnlRoomSummary.Name = "pnlRoomSummary";
            this.pnlRoomSummary.Size = new System.Drawing.Size(820, 561);
            this.pnlRoomSummary.TabIndex = 248;
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.pnlStart.Controls.Add(this.cboSchoolYear);
            this.pnlStart.Controls.Add(this.cboSemester);
            this.pnlStart.Controls.Add(this.metroLabel3);
            this.pnlStart.Controls.Add(this.metroLabel5);
            this.pnlStart.Controls.Add(this.label4);
            this.pnlStart.Controls.Add(this.btnOK);
            this.pnlStart.Location = new System.Drawing.Point(-1, 37);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(925, 636);
            this.pnlStart.TabIndex = 247;
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.FormattingEnabled = true;
            this.cboSchoolYear.Location = new System.Drawing.Point(450, 312);
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(121, 21);
            this.cboSchoolYear.TabIndex = 181;
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Location = new System.Drawing.Point(450, 275);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(121, 21);
            this.cboSemester.TabIndex = 182;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(335, 308);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 25);
            this.metroLabel3.TabIndex = 179;
            this.metroLabel3.Text = "School Year:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(335, 271);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 25);
            this.metroLabel5.TabIndex = 180;
            this.metroLabel5.Text = "Semester:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 61);
            this.label4.TabIndex = 178;
            this.label4.Text = "Please Set the semester and school year before you proceed to view the summary.";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(324, 362);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(262, 43);
            this.btnOK.TabIndex = 177;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SummaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.tbCtrl_Students);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStart);
            this.Name = "SummaryControl";
            this.Size = new System.Drawing.Size(923, 672);
            this.Load += new System.EventHandler(this.SummaryControl_Load);
            this.Students.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.tbCtrl_Students.ResumeLayout(false);
            this.Professors.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cboRoom;
        public MetroFramework.Controls.MetroButton btnOK;
        public System.Windows.Forms.ComboBox cboSectionName;
        public System.Windows.Forms.ComboBox cboProfessorName;
        public MetroFramework.Controls.MetroLabel lblCurriculum;
        public Bunifu.Framework.UI.BunifuImageButton btnPrint;
        public System.Windows.Forms.TabPage Students;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TabControl tbCtrl_Students;
        public System.Windows.Forms.TabPage Professors;
        public System.Windows.Forms.TabPage Rooms;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlRoomSummary;
        public System.Windows.Forms.Panel pnlStart;
        public System.Windows.Forms.ComboBox cboSchoolYear;
        public System.Windows.Forms.ComboBox cboSemester;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel pnlSection;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel pnlProfessor;
        public Bunifu.Framework.UI.BunifuImageButton btnSettings;
    }
}
