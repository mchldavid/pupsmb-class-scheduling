namespace ClassSchedulingComputerAided
{
    partial class professorsScheduleControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboDay = new System.Windows.Forms.GroupBox();
            this.chkFriday = new MetroFramework.Controls.MetroCheckBox();
            this.chkMonday = new MetroFramework.Controls.MetroCheckBox();
            this.chkTuesday = new MetroFramework.Controls.MetroCheckBox();
            this.chkWednesday = new MetroFramework.Controls.MetroCheckBox();
            this.chkThursday = new MetroFramework.Controls.MetroCheckBox();
            this.chkSaturday = new MetroFramework.Controls.MetroCheckBox();
            this.chkSunday = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btnViewTimetable = new MetroFramework.Controls.MetroButton();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.dgvShow = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.gboDay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // gboDay
            // 
            this.gboDay.BackColor = System.Drawing.Color.Gainsboro;
            this.gboDay.Controls.Add(this.chkFriday);
            this.gboDay.Controls.Add(this.chkMonday);
            this.gboDay.Controls.Add(this.chkTuesday);
            this.gboDay.Controls.Add(this.chkWednesday);
            this.gboDay.Controls.Add(this.chkThursday);
            this.gboDay.Controls.Add(this.chkSaturday);
            this.gboDay.Controls.Add(this.chkSunday);
            this.gboDay.Location = new System.Drawing.Point(341, 126);
            this.gboDay.Name = "gboDay";
            this.gboDay.Size = new System.Drawing.Size(301, 194);
            this.gboDay.TabIndex = 175;
            this.gboDay.TabStop = false;
            this.gboDay.Text = "Preferred Day/s";
            // 
            // chkFriday
            // 
            this.chkFriday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkFriday.CustomBackground = true;
            this.chkFriday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkFriday.Location = new System.Drawing.Point(170, 33);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(104, 24);
            this.chkFriday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkFriday.TabIndex = 109;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = false;
            // 
            // chkMonday
            // 
            this.chkMonday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkMonday.CustomBackground = true;
            this.chkMonday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkMonday.Location = new System.Drawing.Point(23, 33);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(104, 24);
            this.chkMonday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkMonday.TabIndex = 107;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = false;
            // 
            // chkTuesday
            // 
            this.chkTuesday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkTuesday.CustomBackground = true;
            this.chkTuesday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkTuesday.Location = new System.Drawing.Point(23, 63);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(104, 24);
            this.chkTuesday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkTuesday.TabIndex = 108;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = false;
            // 
            // chkWednesday
            // 
            this.chkWednesday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkWednesday.CustomBackground = true;
            this.chkWednesday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkWednesday.Location = new System.Drawing.Point(23, 91);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(104, 24);
            this.chkWednesday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkWednesday.TabIndex = 109;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = false;
            // 
            // chkThursday
            // 
            this.chkThursday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkThursday.CustomBackground = true;
            this.chkThursday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkThursday.Location = new System.Drawing.Point(23, 122);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(104, 24);
            this.chkThursday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkThursday.TabIndex = 109;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = false;
            // 
            // chkSaturday
            // 
            this.chkSaturday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkSaturday.CustomBackground = true;
            this.chkSaturday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkSaturday.Location = new System.Drawing.Point(170, 63);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(104, 24);
            this.chkSaturday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkSaturday.TabIndex = 109;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = false;
            // 
            // chkSunday
            // 
            this.chkSunday.BackColor = System.Drawing.Color.Gainsboro;
            this.chkSunday.CustomBackground = true;
            this.chkSunday.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.chkSunday.Location = new System.Drawing.Point(170, 93);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(104, 24);
            this.chkSunday.Style = MetroFramework.MetroColorStyle.Red;
            this.chkSunday.TabIndex = 109;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cboStartTime);
            this.groupBox1.Controls.Add(this.cboEndTime);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(341, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 98);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferred Time";
            // 
            // cboStartTime
            // 
            this.cboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Items.AddRange(new object[] {
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM"});
            this.cboStartTime.Location = new System.Drawing.Point(100, 29);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(174, 21);
            this.cboStartTime.TabIndex = 167;
            // 
            // cboEndTime
            // 
            this.cboEndTime.BackColor = System.Drawing.Color.White;
            this.cboEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndTime.FormattingEnabled = true;
            this.cboEndTime.Items.AddRange(new object[] {
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM"});
            this.cboEndTime.Location = new System.Drawing.Point(100, 56);
            this.cboEndTime.Name = "cboEndTime";
            this.cboEndTime.Size = new System.Drawing.Size(174, 21);
            this.cboEndTime.TabIndex = 167;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.TabIndex = 103;
            this.metroLabel1.Text = "Start Time:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 25);
            this.metroLabel2.TabIndex = 105;
            this.metroLabel2.Text = "End Time:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 173;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(301, 40);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 172;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(16, 429);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(52, 13);
            this.lbl_id.TabIndex = 172;
            this.lbl_id.Text = "Control Id";
            this.lbl_id.Visible = false;
            // 
            // btnViewTimetable
            // 
            this.btnViewTimetable.Location = new System.Drawing.Point(534, 416);
            this.btnViewTimetable.Name = "btnViewTimetable";
            this.btnViewTimetable.Size = new System.Drawing.Size(108, 32);
            this.btnViewTimetable.TabIndex = 168;
            this.btnViewTimetable.Text = "VIEW";
            this.btnViewTimetable.Click += new System.EventHandler(this.btnViewTimetable_Click);
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Location = new System.Drawing.Point(0, 3);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(668, 409);
            this.pnlView.TabIndex = 177;
            this.pnlView.Visible = false;
            this.pnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlView_Paint);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Maroon;
            this.lbl.Location = new System.Drawing.Point(34, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(301, 23);
            this.lbl.TabIndex = 161;
            this.lbl.Text = "LIST OF PREFERRED SCHEDULE/S";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.ColumnHeadersHeight = 25;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShow.DoubleBuffered = true;
            this.dgvShow.EnableHeadersVisualStyles = false;
            this.dgvShow.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShow.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dgvShow.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvShow.Location = new System.Drawing.Point(37, 22);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShow.RowHeadersWidth = 15;
            this.dgvShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(298, 387);
            this.dgvShow.TabIndex = 157;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(533, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 25);
            this.btnClear.TabIndex = 168;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // professorsScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnViewTimetable);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.gboDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlView);
            this.Name = "professorsScheduleControl";
            this.Size = new System.Drawing.Size(668, 451);
            this.Load += new System.EventHandler(this.professorsScheduleControl_Load);
            this.gboDay.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gboDay;
        public MetroFramework.Controls.MetroCheckBox chkFriday;
        public MetroFramework.Controls.MetroCheckBox chkMonday;
        public MetroFramework.Controls.MetroCheckBox chkTuesday;
        public MetroFramework.Controls.MetroCheckBox chkWednesday;
        public MetroFramework.Controls.MetroCheckBox chkThursday;
        public MetroFramework.Controls.MetroCheckBox chkSaturday;
        public MetroFramework.Controls.MetroCheckBox chkSunday;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cboStartTime;
        public System.Windows.Forms.ComboBox cboEndTime;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTile btnDelete;
        public MetroFramework.Controls.MetroTile btnAdd;
        public System.Windows.Forms.Label lbl_id;
        public MetroFramework.Controls.MetroButton btnViewTimetable;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvShow;
        public MetroFramework.Controls.MetroButton btnClear;
    }
}
