namespace ClassSchedulingComputerAided
{
    partial class sectionsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfSection = new System.Windows.Forms.TextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboSelectCourse = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvShowSections = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOfSection);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.cboSelectYear);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cboSelectCourse);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(342, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 114);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Sections";
            // 
            // txtNumberOfSection
            // 
            this.txtNumberOfSection.BackColor = System.Drawing.Color.White;
            this.txtNumberOfSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfSection.Location = new System.Drawing.Point(156, 81);
            this.txtNumberOfSection.Name = "txtNumberOfSection";
            this.txtNumberOfSection.Size = new System.Drawing.Size(146, 22);
            this.txtNumberOfSection.TabIndex = 249;
            this.txtNumberOfSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfSection_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.CustomForeColor = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(26, 18);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(112, 29);
            this.metroLabel11.TabIndex = 175;
            this.metroLabel11.Text = "Select Program:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cboSelectYear.Size = new System.Drawing.Size(146, 24);
            this.cboSelectYear.TabIndex = 184;
            this.cboSelectYear.SelectedIndexChanged += new System.EventHandler(this.cboSelectYear_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(26, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 29);
            this.metroLabel1.TabIndex = 177;
            this.metroLabel1.Text = "Select Year:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSelectCourse
            // 
            this.cboSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectCourse.FormattingEnabled = true;
            this.cboSelectCourse.Location = new System.Drawing.Point(156, 25);
            this.cboSelectCourse.Name = "cboSelectCourse";
            this.cboSelectCourse.Size = new System.Drawing.Size(146, 24);
            this.cboSelectCourse.TabIndex = 184;
            this.cboSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cboSelectCourse_SelectedIndexChanged);
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
            this.btnAdd.Location = new System.Drawing.Point(368, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 40);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 187;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(295, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 188;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 39);
            this.panel1.TabIndex = 240;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(102, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 22);
            this.txtSearch.TabIndex = 249;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 21);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Search Program:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvShowSections
            // 
            this.dgvShowSections.AllowUserToAddRows = false;
            this.dgvShowSections.AllowUserToDeleteRows = false;
            this.dgvShowSections.AllowUserToResizeColumns = false;
            this.dgvShowSections.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvShowSections.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShowSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowSections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowSections.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowSections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowSections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShowSections.ColumnHeadersHeight = 25;
            this.dgvShowSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowSections.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvShowSections.DoubleBuffered = true;
            this.dgvShowSections.EnableHeadersVisualStyles = false;
            this.dgvShowSections.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowSections.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dgvShowSections.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvShowSections.Location = new System.Drawing.Point(10, 64);
            this.dgvShowSections.MultiSelect = false;
            this.dgvShowSections.Name = "dgvShowSections";
            this.dgvShowSections.ReadOnly = true;
            this.dgvShowSections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowSections.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvShowSections.RowHeadersWidth = 15;
            this.dgvShowSections.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShowSections.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvShowSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowSections.Size = new System.Drawing.Size(326, 403);
            this.dgvShowSections.TabIndex = 248;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 247;
            this.label1.Text = "LIST OF SECTION(S) ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sectionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.dgvShowSections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "sectionsControl";
            this.Size = new System.Drawing.Size(700, 473);
            this.Load += new System.EventHandler(this.sectionsControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        public System.Windows.Forms.ComboBox cboSelectYear;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.ComboBox cboSelectCourse;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTile btnAdd;
        public MetroFramework.Controls.MetroTile btnDelete;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvShowSections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfSection;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
