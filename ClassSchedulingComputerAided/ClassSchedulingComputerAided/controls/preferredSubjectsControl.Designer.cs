namespace ClassSchedulingComputerAided
{
    partial class preferredSubjectsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListSubject = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnAddSubject = new MetroFramework.Controls.MetroTile();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cboCourseDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnitsAllowed = new System.Windows.Forms.Label();
            this.lblTotalUnits = new System.Windows.Forms.Label();
            this.lblTotalSubjects = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAddSubject = new System.Windows.Forms.Panel();
            this.dgvAddSubject = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.cboSubjectBy = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAddSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubject)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.Location = new System.Drawing.Point(4, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 21);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Search:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListSubject);
            this.groupBox1.Location = new System.Drawing.Point(14, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 371);
            this.groupBox1.TabIndex = 177;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of your preferred schedule/s";
            // 
            // dgvListSubject
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvListSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvListSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSubject.DoubleBuffered = true;
            this.dgvListSubject.EnableHeadersVisualStyles = false;
            this.dgvListSubject.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListSubject.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvListSubject.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvListSubject.Location = new System.Drawing.Point(0, 19);
            this.dgvListSubject.Name = "dgvListSubject";
            this.dgvListSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListSubject.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSubject.Size = new System.Drawing.Size(524, 352);
            this.dgvListSubject.TabIndex = 149;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(544, 120);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(108, 57);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 175;
            this.metroTile2.Text = "Delete Subject";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(544, 58);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(108, 56);
            this.btnAddSubject.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddSubject.TabIndex = 176;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(600, 427);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 13);
            this.lbl_id.TabIndex = 179;
            this.lbl_id.Text = "Control Id";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(17, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 238;
            this.label2.Text = "Units Allowed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(216, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 238;
            this.label3.Text = "Total Units:";
            // 
            // lblUnitsAllowed
            // 
            this.lblUnitsAllowed.AutoSize = true;
            this.lblUnitsAllowed.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsAllowed.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUnitsAllowed.Location = new System.Drawing.Point(133, 417);
            this.lblUnitsAllowed.Name = "lblUnitsAllowed";
            this.lblUnitsAllowed.Size = new System.Drawing.Size(34, 24);
            this.lblUnitsAllowed.TabIndex = 238;
            this.lblUnitsAllowed.Text = "45";
            // 
            // lblTotalUnits
            // 
            this.lblTotalUnits.AutoSize = true;
            this.lblTotalUnits.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lblTotalUnits.Location = new System.Drawing.Point(302, 417);
            this.lblTotalUnits.Name = "lblTotalUnits";
            this.lblTotalUnits.Size = new System.Drawing.Size(34, 24);
            this.lblTotalUnits.TabIndex = 238;
            this.lblTotalUnits.Text = "45";
            // 
            // lblTotalSubjects
            // 
            this.lblTotalSubjects.AutoSize = true;
            this.lblTotalSubjects.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lblTotalSubjects.Location = new System.Drawing.Point(504, 420);
            this.lblTotalSubjects.Name = "lblTotalSubjects";
            this.lblTotalSubjects.Size = new System.Drawing.Size(34, 24);
            this.lblTotalSubjects.TabIndex = 238;
            this.lblTotalSubjects.Text = "45";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label7.Location = new System.Drawing.Point(393, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 238;
            this.label7.Text = "Total Subjects:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.cboCourseDepartment);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 39);
            this.panel1.TabIndex = 239;
            // 
            // pnlAddSubject
            // 
            this.pnlAddSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddSubject.Controls.Add(this.panel2);
            this.pnlAddSubject.Controls.Add(this.dgvAddSubject);
            this.pnlAddSubject.Controls.Add(this.metroLabel6);
            this.pnlAddSubject.Controls.Add(this.btnClose);
            this.pnlAddSubject.Controls.Add(this.btnAdd);
            this.pnlAddSubject.Controls.Add(this.cboSubjectBy);
            this.pnlAddSubject.Controls.Add(this.metroLabel4);
            this.pnlAddSubject.Location = new System.Drawing.Point(86, 9);
            this.pnlAddSubject.Name = "pnlAddSubject";
            this.pnlAddSubject.Size = new System.Drawing.Size(502, 420);
            this.pnlAddSubject.TabIndex = 150;
            this.pnlAddSubject.Visible = false;
            // 
            // dgvAddSubject
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvAddSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAddSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSubject.DoubleBuffered = true;
            this.dgvAddSubject.EnableHeadersVisualStyles = false;
            this.dgvAddSubject.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAddSubject.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvAddSubject.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvAddSubject.Location = new System.Drawing.Point(36, 91);
            this.dgvAddSubject.Name = "dgvAddSubject";
            this.dgvAddSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAddSubject.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAddSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddSubject.Size = new System.Drawing.Size(428, 268);
            this.dgvAddSubject.TabIndex = 148;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 362);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 33);
            this.metroLabel6.TabIndex = 147;
            this.metroLabel6.Text = "Subject by:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 32);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 32);
            this.btnAdd.TabIndex = 145;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboSubjectBy
            // 
            this.cboSubjectBy.FormattingEnabled = true;
            this.cboSubjectBy.ItemHeight = 23;
            this.cboSubjectBy.Items.AddRange(new object[] {
            "Course Subject",
            "Other Subject"});
            this.cboSubjectBy.Location = new System.Drawing.Point(113, 366);
            this.cboSubjectBy.Name = "cboSubjectBy";
            this.cboSubjectBy.Size = new System.Drawing.Size(148, 29);
            this.cboSubjectBy.TabIndex = 144;
            this.cboSubjectBy.SelectedIndexChanged += new System.EventHandler(this.cboSubjectBy_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(36, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(204, 22);
            this.metroLabel4.TabIndex = 140;
            this.metroLabel4.Text = "Select your preferred subject";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.metroTextBox2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 62);
            this.panel2.TabIndex = 240;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroTextBox2.CustomBackground = true;
            this.metroTextBox2.Location = new System.Drawing.Point(136, 31);
            this.metroTextBox2.Multiline = true;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(144, 21);
            this.metroTextBox2.TabIndex = 134;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(75, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 21);
            this.metroLabel1.TabIndex = 135;
            this.metroLabel1.Text = "Search:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 236;
            // 
            // preferredSubjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pnlAddSubject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalSubjects);
            this.Controls.Add(this.lblTotalUnits);
            this.Controls.Add(this.lblUnitsAllowed);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnAddSubject);
            this.Name = "preferredSubjectsControl";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.preferredSubjectsControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlAddSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListSubject;
        public MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroTile btnAddSubject;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.ComboBox cboCourseDepartment;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblUnitsAllowed;
        public System.Windows.Forms.Label lblTotalUnits;
        public System.Windows.Forms.Label lblTotalSubjects;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlAddSubject;
        private System.Windows.Forms.Panel panel2;
        public MetroFramework.Controls.MetroTextBox metroTextBox2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAddSubject;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroButton btnClose;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroComboBox cboSubjectBy;
        public MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
