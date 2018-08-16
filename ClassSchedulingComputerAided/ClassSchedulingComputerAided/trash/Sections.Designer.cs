namespace ClassSchedulingComputerAided
{
    partial class frmSections
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNumberOfSection = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.cboSelectCourse = new System.Windows.Forms.ComboBox();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_title = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvShowSections = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(26, 17);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 29);
            this.metroLabel11.TabIndex = 175;
            this.metroLabel11.Text = "Select Course:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(26, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 29);
            this.metroLabel1.TabIndex = 177;
            this.metroLabel1.Text = "Select Year:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfSection
            // 
            this.txtNumberOfSection.Location = new System.Drawing.Point(156, 79);
            this.txtNumberOfSection.Multiline = true;
            this.txtNumberOfSection.Name = "txtNumberOfSection";
            this.txtNumberOfSection.Size = new System.Drawing.Size(146, 25);
            this.txtNumberOfSection.TabIndex = 180;
            // 
            // metroLabel3
            // 
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(26, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 25);
            this.metroLabel3.TabIndex = 179;
            this.metroLabel3.Text = "Number of Section:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 40);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 181;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(295, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 182;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboSelectCourse
            // 
            this.cboSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCourse.FormattingEnabled = true;
            this.cboSelectCourse.Location = new System.Drawing.Point(156, 25);
            this.cboSelectCourse.Name = "cboSelectCourse";
            this.cboSelectCourse.Size = new System.Drawing.Size(146, 21);
            this.cboSelectCourse.TabIndex = 184;
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboSelectYear.Location = new System.Drawing.Point(156, 52);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(146, 21);
            this.cboSelectYear.TabIndex = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.cboSelectYear);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cboSelectCourse);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtNumberOfSection);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(332, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 114);
            this.groupBox1.TabIndex = 185;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Sections";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(0)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 56);
            this.panel1.TabIndex = 241;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(21, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 241;
            this.label7.Text = "SECTIONS";
            // 
            // lbl_title
            // 
            this.lbl_title.CustomBackground = true;
            this.lbl_title.CustomForeColor = true;
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(23, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(511, 18);
            this.lbl_title.TabIndex = 242;
            this.lbl_title.Text = "Polytechnic University of the Philippines, Sta. Maria Campus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(122, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 424);
            this.panel2.TabIndex = 242;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.dgvShowSections);
            this.groupBox3.Location = new System.Drawing.Point(30, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 377);
            this.groupBox3.TabIndex = 186;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Schedule";
            // 
            // dgvShowSections
            // 
            this.dgvShowSections.AllowUserToAddRows = false;
            this.dgvShowSections.AllowUserToDeleteRows = false;
            this.dgvShowSections.AllowUserToResizeColumns = false;
            this.dgvShowSections.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvShowSections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowSections.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowSections.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowSections.Location = new System.Drawing.Point(6, 16);
            this.dgvShowSections.Name = "dgvShowSections";
            this.dgvShowSections.ReadOnly = true;
            this.dgvShowSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowSections.Size = new System.Drawing.Size(284, 361);
            this.dgvShowSections.TabIndex = 0;
            // 
            // frmSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmSections";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Sections_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txtNumberOfSection;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTile btnAdd;
        public MetroFramework.Controls.MetroTile btnDelete;
        public System.Windows.Forms.ComboBox cboSelectCourse;
        public System.Windows.Forms.ComboBox cboSelectYear;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label7;
        public MetroFramework.Controls.MetroLabel lbl_title;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvShowSections;
    }
}