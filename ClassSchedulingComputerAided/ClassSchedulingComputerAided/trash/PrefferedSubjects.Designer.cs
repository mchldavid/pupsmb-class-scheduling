namespace ClassSchedulingComputerAided
{
    partial class frmPrefferedSubjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAddSubject = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pnlAddSubject = new System.Windows.Forms.Panel();
            this.dgvAddSubject = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.cboSubjectBy = new MetroFramework.Controls.MetroComboBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListSubject = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlAddSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubject)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 54);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(603, 18);
            this.bunifuSeparator1.TabIndex = 129;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(491, 79);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(108, 168);
            this.btnAddSubject.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAddSubject.TabIndex = 132;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSubject.Click += new System.EventHandler(this.btn_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(491, 253);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(108, 156);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 132;
            this.metroTile2.Text = "Delete Subject";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(99, 17);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(144, 29);
            this.txtUsername.TabIndex = 134;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(30, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 25);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Search:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(249, 17);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(162, 29);
            this.metroComboBox1.TabIndex = 136;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // pnlAddSubject
            // 
            this.pnlAddSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAddSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddSubject.Controls.Add(this.dgvAddSubject);
            this.pnlAddSubject.Controls.Add(this.metroLabel6);
            this.pnlAddSubject.Controls.Add(this.btnClose);
            this.pnlAddSubject.Controls.Add(this.btnAdd);
            this.pnlAddSubject.Controls.Add(this.cboSubjectBy);
            this.pnlAddSubject.Controls.Add(this.bunifuSeparator2);
            this.pnlAddSubject.Controls.Add(this.metroLabel5);
            this.pnlAddSubject.Controls.Add(this.metroLabel4);
            this.pnlAddSubject.Controls.Add(this.metroComboBox2);
            this.pnlAddSubject.Controls.Add(this.metroLabel3);
            this.pnlAddSubject.Controls.Add(this.metroTextBox1);
            this.pnlAddSubject.Location = new System.Drawing.Point(24, 23);
            this.pnlAddSubject.Name = "pnlAddSubject";
            this.pnlAddSubject.Size = new System.Drawing.Size(550, 435);
            this.pnlAddSubject.TabIndex = 137;
            this.pnlAddSubject.Visible = false;
            this.pnlAddSubject.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSubject_Paint);
            // 
            // dgvAddSubject
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvAddSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAddSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSubject.DoubleBuffered = true;
            this.dgvAddSubject.EnableHeadersVisualStyles = false;
            this.dgvAddSubject.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAddSubject.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvAddSubject.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvAddSubject.Location = new System.Drawing.Point(55, 130);
            this.dgvAddSubject.Name = "dgvAddSubject";
            this.dgvAddSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAddSubject.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAddSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddSubject.Size = new System.Drawing.Size(434, 249);
            this.dgvAddSubject.TabIndex = 148;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(34, 392);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 33);
            this.metroLabel6.TabIndex = 147;
            this.metroLabel6.Text = "Subject by:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(405, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 32);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 395);
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
            this.cboSubjectBy.Location = new System.Drawing.Point(138, 396);
            this.cboSubjectBy.Name = "cboSubjectBy";
            this.cboSubjectBy.Size = new System.Drawing.Size(172, 29);
            this.cboSubjectBy.TabIndex = 144;
            this.cboSubjectBy.SelectedIndexChanged += new System.EventHandler(this.cboSubjectBy_SelectedIndexChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 42);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(523, 18);
            this.bunifuSeparator2.TabIndex = 143;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(3, 7);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 33);
            this.metroLabel5.TabIndex = 142;
            this.metroLabel5.Text = "Add Subject";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(55, 105);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(157, 22);
            this.metroLabel4.TabIndex = 140;
            this.metroLabel4.Text = "Select your preferred subject";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(296, 67);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(162, 29);
            this.metroComboBox2.TabIndex = 139;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 33);
            this.metroLabel3.TabIndex = 138;
            this.metroLabel3.Text = "Search:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(146, 67);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(144, 32);
            this.metroTextBox1.TabIndex = 137;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(553, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 147;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(3, 422);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 13);
            this.lbl_id.TabIndex = 172;
            this.lbl_id.Text = "Control Id";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListSubject);
            this.groupBox1.Location = new System.Drawing.Point(40, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 275);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of your preferred schedule/s";
            // 
            // dgvListSubject
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvListSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvListSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSubject.DoubleBuffered = true;
            this.dgvListSubject.EnableHeadersVisualStyles = false;
            this.dgvListSubject.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListSubject.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvListSubject.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvListSubject.Location = new System.Drawing.Point(5, 13);
            this.dgvListSubject.Name = "dgvListSubject";
            this.dgvListSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvListSubject.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSubject.Size = new System.Drawing.Size(434, 249);
            this.dgvListSubject.TabIndex = 149;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.metroComboBox1);
            this.groupBox2.Location = new System.Drawing.Point(40, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 54);
            this.groupBox2.TabIndex = 174;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search subject";
            // 
            // frmPrefferedSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.pnlAddSubject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmPrefferedSubjects";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Preffered Subject/s";
            this.Load += new System.EventHandler(this.PrefferedSubjects_Load);
            this.pnlAddSubject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubject)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public MetroFramework.Controls.MetroTile btnAddSubject;
        public MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroTextBox txtUsername;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox metroComboBox1;
        public System.Windows.Forms.Panel pnlAddSubject;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroComboBox metroComboBox2;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox metroTextBox1;
        public MetroFramework.Controls.MetroComboBox cboSubjectBy;
        public MetroFramework.Controls.MetroButton btnClose;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public MetroFramework.Controls.MetroButton btnCancel;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAddSubject;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListSubject;

    }
}