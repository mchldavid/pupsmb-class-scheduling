namespace ClassSchedulingComputerAided
{
    partial class roomsControl
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lstInActiveRooms = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lstActiveRooms = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSetRooms = new MetroFramework.Controls.MetroButton();
            this.btnActive = new MetroFramework.Controls.MetroButton();
            this.btnInActive = new MetroFramework.Controls.MetroButton();
            this.btnActiveAll = new MetroFramework.Controls.MetroButton();
            this.btnInactiveAll = new MetroFramework.Controls.MetroButton();
            this.pnlSetRooms = new System.Windows.Forms.Panel();
            this.txtSlots = new System.Windows.Forms.TextBox();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.dgvShowRooms = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnRoomCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.pnlSetRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(273, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(240, 22);
            this.metroLabel1.TabIndex = 178;
            this.metroLabel1.Text = "INACTIVE";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstInActiveRooms
            // 
            this.lstInActiveRooms.AllowDrop = true;
            this.lstInActiveRooms.BackColor = System.Drawing.Color.Silver;
            this.lstInActiveRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInActiveRooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInActiveRooms.ForeColor = System.Drawing.Color.Firebrick;
            this.lstInActiveRooms.FormattingEnabled = true;
            this.lstInActiveRooms.ItemHeight = 21;
            this.lstInActiveRooms.Location = new System.Drawing.Point(273, 81);
            this.lstInActiveRooms.Name = "lstInActiveRooms";
            this.lstInActiveRooms.Size = new System.Drawing.Size(240, 380);
            this.lstInActiveRooms.TabIndex = 177;
            this.lstInActiveRooms.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstInActiveRooms_DragDrop);
            this.lstInActiveRooms.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstInActiveRooms_DragEnter);
            this.lstInActiveRooms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstInActiveRooms_MouseDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(15, 56);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(239, 22);
            this.metroLabel4.TabIndex = 176;
            this.metroLabel4.Text = "ACTIVE";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstActiveRooms
            // 
            this.lstActiveRooms.AllowDrop = true;
            this.lstActiveRooms.BackColor = System.Drawing.Color.Silver;
            this.lstActiveRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstActiveRooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActiveRooms.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lstActiveRooms.FormattingEnabled = true;
            this.lstActiveRooms.ItemHeight = 21;
            this.lstActiveRooms.Location = new System.Drawing.Point(14, 81);
            this.lstActiveRooms.Name = "lstActiveRooms";
            this.lstActiveRooms.Size = new System.Drawing.Size(240, 380);
            this.lstActiveRooms.TabIndex = 175;
            this.lstActiveRooms.SelectedIndexChanged += new System.EventHandler(this.lstActiveRooms_SelectedIndexChanged);
            this.lstActiveRooms.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstActiveRooms_DragDrop);
            this.lstActiveRooms.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstActiveRooms_DragEnter);
            this.lstActiveRooms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstActiveRooms_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 39);
            this.panel1.TabIndex = 241;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(286, 21);
            this.metroLabel2.TabIndex = 135;
            this.metroLabel2.Text = "Drag an item to the list box";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetRooms
            // 
            this.btnSetRooms.Location = new System.Drawing.Point(530, 81);
            this.btnSetRooms.Name = "btnSetRooms";
            this.btnSetRooms.Size = new System.Drawing.Size(152, 81);
            this.btnSetRooms.TabIndex = 246;
            this.btnSetRooms.Text = "Set Rooms";
            this.btnSetRooms.Click += new System.EventHandler(this.btnSetRooms_Click);
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(530, 206);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(152, 32);
            this.btnActive.TabIndex = 242;
            this.btnActive.Text = "<";
            this.btnActive.Visible = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInActive
            // 
            this.btnInActive.Location = new System.Drawing.Point(530, 168);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(152, 32);
            this.btnInActive.TabIndex = 244;
            this.btnInActive.Text = ">";
            this.btnInActive.Visible = false;
            this.btnInActive.Click += new System.EventHandler(this.btnInActive_Click);
            // 
            // btnActiveAll
            // 
            this.btnActiveAll.Location = new System.Drawing.Point(530, 283);
            this.btnActiveAll.Name = "btnActiveAll";
            this.btnActiveAll.Size = new System.Drawing.Size(152, 32);
            this.btnActiveAll.TabIndex = 243;
            this.btnActiveAll.Text = "<<";
            this.btnActiveAll.Visible = false;
            // 
            // btnInactiveAll
            // 
            this.btnInactiveAll.Location = new System.Drawing.Point(530, 244);
            this.btnInactiveAll.Name = "btnInactiveAll";
            this.btnInactiveAll.Size = new System.Drawing.Size(152, 32);
            this.btnInactiveAll.TabIndex = 245;
            this.btnInactiveAll.Text = ">>";
            this.btnInactiveAll.Visible = false;
            // 
            // pnlSetRooms
            // 
            this.pnlSetRooms.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSetRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetRooms.Controls.Add(this.txtSlots);
            this.pnlSetRooms.Controls.Add(this.txtRoomCode);
            this.pnlSetRooms.Controls.Add(this.txtRoomName);
            this.pnlSetRooms.Controls.Add(this.dgvShowRooms);
            this.pnlSetRooms.Controls.Add(this.btnCancel);
            this.pnlSetRooms.Controls.Add(this.panel2);
            this.pnlSetRooms.Controls.Add(this.btnRoomCancel);
            this.pnlSetRooms.Controls.Add(this.btnDelete);
            this.pnlSetRooms.Controls.Add(this.btnEdit);
            this.pnlSetRooms.Controls.Add(this.btnAdd);
            this.pnlSetRooms.Controls.Add(this.metroLabel3);
            this.pnlSetRooms.Controls.Add(this.metroLabel7);
            this.pnlSetRooms.Controls.Add(this.metroLabel8);
            this.pnlSetRooms.Location = new System.Drawing.Point(0, 0);
            this.pnlSetRooms.Name = "pnlSetRooms";
            this.pnlSetRooms.Size = new System.Drawing.Size(700, 473);
            this.pnlSetRooms.TabIndex = 248;
            this.pnlSetRooms.Visible = false;
            // 
            // txtSlots
            // 
            this.txtSlots.BackColor = System.Drawing.Color.White;
            this.txtSlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlots.Location = new System.Drawing.Point(110, 123);
            this.txtSlots.Name = "txtSlots";
            this.txtSlots.Size = new System.Drawing.Size(283, 22);
            this.txtSlots.TabIndex = 246;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.BackColor = System.Drawing.Color.White;
            this.txtRoomCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCode.Location = new System.Drawing.Point(110, 94);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(283, 22);
            this.txtRoomCode.TabIndex = 245;
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.White;
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(110, 64);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(283, 22);
            this.txtRoomName.TabIndex = 244;
            // 
            // dgvShowRooms
            // 
            this.dgvShowRooms.AllowUserToAddRows = false;
            this.dgvShowRooms.AllowUserToDeleteRows = false;
            this.dgvShowRooms.AllowUserToResizeColumns = false;
            this.dgvShowRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvShowRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvShowRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvShowRooms.ColumnHeadersHeight = 25;
            this.dgvShowRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowRooms.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvShowRooms.DoubleBuffered = true;
            this.dgvShowRooms.EnableHeadersVisualStyles = false;
            this.dgvShowRooms.GridColor = System.Drawing.Color.DarkGray;
            this.dgvShowRooms.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dgvShowRooms.HeaderForeColor = System.Drawing.Color.Gold;
            this.dgvShowRooms.Location = new System.Drawing.Point(403, 48);
            this.dgvShowRooms.MultiSelect = false;
            this.dgvShowRooms.Name = "dgvShowRooms";
            this.dgvShowRooms.ReadOnly = true;
            this.dgvShowRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvShowRooms.RowHeadersWidth = 15;
            this.dgvShowRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvShowRooms.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvShowRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowRooms.Size = new System.Drawing.Size(287, 420);
            this.dgvShowRooms.TabIndex = 243;
            this.dgvShowRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowRooms_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(372, 42);
            this.btnCancel.TabIndex = 242;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 42);
            this.panel2.TabIndex = 241;
            // 
            // metroLabel5
            // 
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel5.Location = new System.Drawing.Point(14, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 21);
            this.metroLabel5.TabIndex = 135;
            this.metroLabel5.Text = "Set Rooms";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRoomCancel
            // 
            this.btnRoomCancel.Location = new System.Drawing.Point(496, 420);
            this.btnRoomCancel.Name = "btnRoomCancel";
            this.btnRoomCancel.Size = new System.Drawing.Size(102, 24);
            this.btnRoomCancel.TabIndex = 172;
            this.btnRoomCancel.Text = "CANCEL";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(22, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(370, 42);
            this.btnDelete.TabIndex = 169;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(22, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(370, 42);
            this.btnEdit.TabIndex = 166;
            this.btnEdit.Text = "SAVE";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(370, 42);
            this.btnAdd.TabIndex = 165;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 25);
            this.metroLabel3.TabIndex = 156;
            this.metroLabel3.Text = "Room Name:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 25);
            this.metroLabel7.TabIndex = 173;
            this.metroLabel7.Text = "Slots:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 89);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 25);
            this.metroLabel8.TabIndex = 163;
            this.metroLabel8.Text = "Room Code:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pnlSetRooms);
            this.Controls.Add(this.btnSetRooms);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnInActive);
            this.Controls.Add(this.btnActiveAll);
            this.Controls.Add(this.btnInactiveAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lstInActiveRooms);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lstActiveRooms);
            this.Name = "roomsControl";
            this.Size = new System.Drawing.Size(700, 473);
            this.Load += new System.EventHandler(this.roomsControl_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSetRooms.ResumeLayout(false);
            this.pnlSetRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.ListBox lstInActiveRooms;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public System.Windows.Forms.ListBox lstActiveRooms;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton btnSetRooms;
        public MetroFramework.Controls.MetroButton btnActive;
        public MetroFramework.Controls.MetroButton btnInActive;
        public MetroFramework.Controls.MetroButton btnActiveAll;
        public MetroFramework.Controls.MetroButton btnInactiveAll;
        public System.Windows.Forms.Panel pnlSetRooms;
        public MetroFramework.Controls.MetroButton btnRoomCancel;
        public MetroFramework.Controls.MetroButton btnDelete;
        public MetroFramework.Controls.MetroButton btnEdit;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Panel panel2;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroButton btnCancel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvShowRooms;
        private System.Windows.Forms.TextBox txtSlots;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.TextBox txtRoomName;
    }
}
