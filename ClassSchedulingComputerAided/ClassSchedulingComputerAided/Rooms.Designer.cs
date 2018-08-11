namespace ClassSchedulingComputerAided
{
    partial class frmRooms
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
            this.lstActiveRooms = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lstInActiveRooms = new System.Windows.Forms.ListBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnInActive = new MetroFramework.Controls.MetroButton();
            this.btnActive = new MetroFramework.Controls.MetroButton();
            this.btnActiveAll = new MetroFramework.Controls.MetroButton();
            this.btnInactiveAll = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSetRooms = new MetroFramework.Controls.MetroButton();
            this.pnlSetRooms = new System.Windows.Forms.Panel();
            this.txtSlots = new MetroFramework.Controls.MetroTextBox();
            this.btnRoomCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtRoomName = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtRoomCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnlSetRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstActiveRooms
            // 
            this.lstActiveRooms.FormattingEnabled = true;
            this.lstActiveRooms.Location = new System.Drawing.Point(51, 105);
            this.lstActiveRooms.Name = "lstActiveRooms";
            this.lstActiveRooms.Size = new System.Drawing.Size(190, 225);
            this.lstActiveRooms.TabIndex = 0;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(40, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(157, 22);
            this.metroLabel4.TabIndex = 172;
            this.metroLabel4.Text = "List of All Active Rooms";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(346, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 22);
            this.metroLabel1.TabIndex = 174;
            this.metroLabel1.Text = "List of All Inactive Rooms";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstInActiveRooms
            // 
            this.lstInActiveRooms.FormattingEnabled = true;
            this.lstInActiveRooms.Location = new System.Drawing.Point(357, 105);
            this.lstInActiveRooms.Name = "lstInActiveRooms";
            this.lstInActiveRooms.Size = new System.Drawing.Size(190, 225);
            this.lstInActiveRooms.TabIndex = 173;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 49);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(558, 23);
            this.bunifuSeparator1.TabIndex = 175;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnInActive
            // 
            this.btnInActive.Location = new System.Drawing.Point(260, 105);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(84, 32);
            this.btnInActive.TabIndex = 177;
            this.btnInActive.Text = ">";
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(260, 143);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(84, 32);
            this.btnActive.TabIndex = 176;
            this.btnActive.Text = "<";
            // 
            // btnActiveAll
            // 
            this.btnActiveAll.Location = new System.Drawing.Point(260, 220);
            this.btnActiveAll.Name = "btnActiveAll";
            this.btnActiveAll.Size = new System.Drawing.Size(84, 32);
            this.btnActiveAll.TabIndex = 176;
            this.btnActiveAll.Text = "<<";
            // 
            // btnInactiveAll
            // 
            this.btnInactiveAll.Location = new System.Drawing.Point(260, 181);
            this.btnInactiveAll.Name = "btnInactiveAll";
            this.btnInactiveAll.Size = new System.Drawing.Size(84, 32);
            this.btnInactiveAll.TabIndex = 177;
            this.btnInactiveAll.Text = ">>";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(483, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 179;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSetRooms
            // 
            this.btnSetRooms.Location = new System.Drawing.Point(260, 258);
            this.btnSetRooms.Name = "btnSetRooms";
            this.btnSetRooms.Size = new System.Drawing.Size(84, 32);
            this.btnSetRooms.TabIndex = 180;
            this.btnSetRooms.Text = "Set Rooms";
            this.btnSetRooms.Click += new System.EventHandler(this.btnSetRooms_Click);
            // 
            // pnlSetRooms
            // 
            this.pnlSetRooms.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSetRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetRooms.Controls.Add(this.txtSlots);
            this.pnlSetRooms.Controls.Add(this.btnRoomCancel);
            this.pnlSetRooms.Controls.Add(this.metroLabel6);
            this.pnlSetRooms.Controls.Add(this.dataGridView2);
            this.pnlSetRooms.Controls.Add(this.btnDelete);
            this.pnlSetRooms.Controls.Add(this.bunifuSeparator2);
            this.pnlSetRooms.Controls.Add(this.metroLabel5);
            this.pnlSetRooms.Controls.Add(this.txtRoomName);
            this.pnlSetRooms.Controls.Add(this.btnEdit);
            this.pnlSetRooms.Controls.Add(this.btnAdd);
            this.pnlSetRooms.Controls.Add(this.metroLabel2);
            this.pnlSetRooms.Controls.Add(this.txtRoomCode);
            this.pnlSetRooms.Controls.Add(this.metroLabel7);
            this.pnlSetRooms.Controls.Add(this.metroLabel3);
            this.pnlSetRooms.Location = new System.Drawing.Point(12, 30);
            this.pnlSetRooms.Name = "pnlSetRooms";
            this.pnlSetRooms.Size = new System.Drawing.Size(565, 449);
            this.pnlSetRooms.TabIndex = 181;
            this.pnlSetRooms.Visible = false;
            // 
            // txtSlots
            // 
            this.txtSlots.Location = new System.Drawing.Point(38, 185);
            this.txtSlots.Multiline = true;
            this.txtSlots.Name = "txtSlots";
            this.txtSlots.Size = new System.Drawing.Size(198, 31);
            this.txtSlots.TabIndex = 174;
            // 
            // btnRoomCancel
            // 
            this.btnRoomCancel.Location = new System.Drawing.Point(38, 385);
            this.btnRoomCancel.Name = "btnRoomCancel";
            this.btnRoomCancel.Size = new System.Drawing.Size(200, 47);
            this.btnRoomCancel.TabIndex = 172;
            this.btnRoomCancel.Text = "CANCEL";
            this.btnRoomCancel.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(251, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 22);
            this.metroLabel6.TabIndex = 170;
            this.metroLabel6.Text = "List of All Rooms:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dataGridView2.Location = new System.Drawing.Point(251, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(300, 350);
            this.dataGridView2.TabIndex = 171;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 47);
            this.btnDelete.TabIndex = 169;
            this.btnDelete.Text = "DELETE";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 33);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(536, 18);
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
            this.metroLabel5.Location = new System.Drawing.Point(-3, 1);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(113, 33);
            this.metroLabel5.TabIndex = 167;
            this.metroLabel5.Text = "Set Rooms";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(38, 82);
            this.txtRoomName.Multiline = true;
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(197, 34);
            this.txtRoomName.TabIndex = 157;
            this.txtRoomName.Click += new System.EventHandler(this.txtFirstName_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(38, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 47);
            this.btnEdit.TabIndex = 166;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 47);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 25);
            this.metroLabel2.TabIndex = 156;
            this.metroLabel2.Text = "Room Name:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Location = new System.Drawing.Point(38, 135);
            this.txtRoomCode.Multiline = true;
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(197, 31);
            this.txtRoomCode.TabIndex = 164;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 25);
            this.metroLabel7.TabIndex = 173;
            this.metroLabel7.Text = "Slots:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 163;
            this.metroLabel3.Text = "Room Code:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(591, 491);
            this.Controls.Add(this.pnlSetRooms);
            this.Controls.Add(this.btnSetRooms);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.lstInActiveRooms);
            this.Controls.Add(this.btnActiveAll);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnInactiveAll);
            this.Controls.Add(this.lstActiveRooms);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmRooms";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.pnlSetRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public MetroFramework.Controls.MetroButton btnInActive;
        public MetroFramework.Controls.MetroButton btnActive;
        public MetroFramework.Controls.MetroButton btnActiveAll;
        public MetroFramework.Controls.MetroButton btnInactiveAll;
        public MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSetRooms;
        public System.Windows.Forms.ListBox lstActiveRooms;
        public System.Windows.Forms.ListBox lstInActiveRooms;
        public System.Windows.Forms.Panel pnlSetRooms;
        public MetroFramework.Controls.MetroButton btnDelete;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTextBox txtRoomName;
        public MetroFramework.Controls.MetroButton btnEdit;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox txtRoomCode;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public MetroFramework.Controls.MetroButton btnRoomCancel;
        public MetroFramework.Controls.MetroTextBox txtSlots;
        public MetroFramework.Controls.MetroLabel metroLabel7;
    }
}