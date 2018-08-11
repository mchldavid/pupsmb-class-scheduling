namespace ClassSchedulingComputerAided
{
    partial class frmListOfProfessors
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
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditProfessor = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnProfessorsInformation = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.pnlProfessorsInformation = new System.Windows.Forms.Panel();
            this.btnProfessorCancel = new MetroFramework.Controls.MetroButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlProfessorsInformation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 64);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(702, 11);
            this.bunifuSeparator1.TabIndex = 111;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(39, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(569, 386);
            this.dataGridView2.TabIndex = 143;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnEditProfessor
            // 
            this.btnEditProfessor.Location = new System.Drawing.Point(614, 159);
            this.btnEditProfessor.Name = "btnEditProfessor";
            this.btnEditProfessor.Size = new System.Drawing.Size(99, 32);
            this.btnEditProfessor.TabIndex = 147;
            this.btnEditProfessor.Text = "EDIT PROF";
            this.btnEditProfessor.Click += new System.EventHandler(this.btnEditProfessor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(614, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 32);
            this.btnDelete.TabIndex = 148;
            this.btnDelete.Text = "DELETE";
            // 
            // btnProfessorsInformation
            // 
            this.btnProfessorsInformation.Location = new System.Drawing.Point(614, 121);
            this.btnProfessorsInformation.Name = "btnProfessorsInformation";
            this.btnProfessorsInformation.Size = new System.Drawing.Size(99, 32);
            this.btnProfessorsInformation.TabIndex = 148;
            this.btnProfessorsInformation.Text = "PROF INFO";
            this.btnProfessorsInformation.Click += new System.EventHandler(this.btnViewInfo_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 33);
            this.metroLabel3.TabIndex = 150;
            this.metroLabel3.Text = "Search:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(97, 83);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(144, 32);
            this.metroTextBox1.TabIndex = 149;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(614, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 32);
            this.btnCancel.TabIndex = 148;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlProfessorsInformation
            // 
            this.pnlProfessorsInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlProfessorsInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfessorsInformation.Controls.Add(this.btnProfessorCancel);
            this.pnlProfessorsInformation.Controls.Add(this.panel5);
            this.pnlProfessorsInformation.Controls.Add(this.panel3);
            this.pnlProfessorsInformation.Controls.Add(this.metroLabel4);
            this.pnlProfessorsInformation.Controls.Add(this.panel2);
            this.pnlProfessorsInformation.Location = new System.Drawing.Point(64, 27);
            this.pnlProfessorsInformation.Name = "pnlProfessorsInformation";
            this.pnlProfessorsInformation.Size = new System.Drawing.Size(625, 490);
            this.pnlProfessorsInformation.TabIndex = 151;
            this.pnlProfessorsInformation.Visible = false;
            this.pnlProfessorsInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProfessorCancel
            // 
            this.btnProfessorCancel.Location = new System.Drawing.Point(513, 37);
            this.btnProfessorCancel.Name = "btnProfessorCancel";
            this.btnProfessorCancel.Size = new System.Drawing.Size(99, 32);
            this.btnProfessorCancel.TabIndex = 149;
            this.btnProfessorCancel.Text = "CANCEL";
            this.btnProfessorCancel.Click += new System.EventHandler(this.btnProfessorClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.metroLabel6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(330, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 315);
            this.panel5.TabIndex = 7;
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel6.Location = new System.Drawing.Point(23, 42);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(223, 117);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "INTE 2013 Programming";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightCoral;
            this.panel6.Controls.Add(this.metroLabel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 28);
            this.panel6.TabIndex = 3;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.LightCoral;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.CustomForeColor = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel7.Location = new System.Drawing.Point(3, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(232, 28);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Profesor\'s preferred subjects";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.metroLabel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(32, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 315);
            this.panel3.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel2.Location = new System.Drawing.Point(23, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(223, 117);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Monday 7:30am-10:30am\r\nMonday 2:00pm-7:00pm\r\nThursday 3:00pm-8:00pm\r\nFriday 7:00a" +
    "m-8:00pm";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.Controls.Add(this.metroLabel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 28);
            this.panel4.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.LightCoral;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel5.Location = new System.Drawing.Point(3, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(232, 28);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Professor\'s preferred schedule";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel4.Location = new System.Drawing.Point(35, 37);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(223, 94);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Name: Michael L. David \r\nAddress: Blk 25 lot 30 San Vicente Homes\r\nSan Vicente Ho" +
    "mes\r\nno#: 09173871717\r\nstatus: Full timer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 28);
            this.panel2.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.IndianRed;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 28);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Professor Information";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmListOfProfessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(750, 524);
            this.Controls.Add(this.pnlProfessorsInformation);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.btnProfessorsInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditProfessor);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bunifuSeparator1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmListOfProfessors";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "List Of Professors";
            this.Load += new System.EventHandler(this.ListOfProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlProfessorsInformation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public MetroFramework.Controls.MetroButton btnEditProfessor;
        public MetroFramework.Controls.MetroButton btnDelete;
        public MetroFramework.Controls.MetroButton btnProfessorsInformation;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox metroTextBox1;
        public MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Panel pnlProfessorsInformation;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton btnProfessorCancel;
    }
}