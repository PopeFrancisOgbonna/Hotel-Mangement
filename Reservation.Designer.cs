namespace HotelManagementSystem
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.ReservePane = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNot = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkIn = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.checkOutCalendar = new System.Windows.Forms.DateTimePicker();
            this.checkInCalendar = new System.Windows.Forms.DateTimePicker();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.txtRoomCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboAvailableRoom = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageReserve = new System.Windows.Forms.Button();
            this.btnAddReserve = new System.Windows.Forms.Button();
            this.ReservePane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReservePane
            // 
            this.ReservePane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReservePane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReservePane.Controls.Add(this.lblTitle);
            this.ReservePane.Controls.Add(this.btnClear);
            this.ReservePane.Controls.Add(this.btnUpdate);
            this.ReservePane.Controls.Add(this.btnDelete);
            this.ReservePane.Controls.Add(this.btnSave);
            this.ReservePane.Controls.Add(this.dataGridView1);
            this.ReservePane.Controls.Add(this.groupBox3);
            this.ReservePane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservePane.Location = new System.Drawing.Point(227, 12);
            this.ReservePane.Name = "ReservePane";
            this.ReservePane.Size = new System.Drawing.Size(1057, 508);
            this.ReservePane.TabIndex = 3;
            this.ReservePane.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(763, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "label14";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(383, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 41);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(711, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(897, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(269, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 405);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNot);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.chkIn);
            this.groupBox3.Controls.Add(this.chkNo);
            this.groupBox3.Controls.Add(this.chkYes);
            this.groupBox3.Controls.Add(this.chkFemale);
            this.groupBox3.Controls.Add(this.chkMale);
            this.groupBox3.Controls.Add(this.checkOutCalendar);
            this.groupBox3.Controls.Add(this.checkInCalendar);
            this.groupBox3.Controls.Add(this.txtServiceCost);
            this.groupBox3.Controls.Add(this.txtRoomCost);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboService);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboAvailableRoom);
            this.groupBox3.Controls.Add(this.txtZip);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtLName);
            this.groupBox3.Controls.Add(this.txtFName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 445);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // chkNot
            // 
            this.chkNot.AutoSize = true;
            this.chkNot.Location = new System.Drawing.Point(396, 417);
            this.chkNot.Name = "chkNot";
            this.chkNot.Size = new System.Drawing.Size(53, 25);
            this.chkNot.TabIndex = 31;
            this.chkNot.Text = "No";
            this.chkNot.UseVisualStyleBackColor = true;
            this.chkNot.Visible = false;
            this.chkNot.CheckedChanged += new System.EventHandler(this.ChkNot_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(212, 419);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Guest checked In ?";
            this.label15.Visible = false;
            // 
            // chkIn
            // 
            this.chkIn.AutoSize = true;
            this.chkIn.Location = new System.Drawing.Point(457, 415);
            this.chkIn.Name = "chkIn";
            this.chkIn.Size = new System.Drawing.Size(61, 25);
            this.chkIn.TabIndex = 29;
            this.chkIn.Text = "Yes";
            this.chkIn.UseVisualStyleBackColor = true;
            this.chkIn.Visible = false;
            this.chkIn.CheckedChanged += new System.EventHandler(this.ChkIn_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(482, 255);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(53, 25);
            this.chkNo.TabIndex = 28;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.ChkNo_CheckedChanged);
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(417, 256);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(61, 25);
            this.chkYes.TabIndex = 28;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.ChkYes_CheckedChanged);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(429, 100);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(92, 25);
            this.chkFemale.TabIndex = 28;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.ChkFemale_CheckedChanged);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(207, 99);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(72, 25);
            this.chkMale.TabIndex = 28;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.ChkMale_CheckedChanged);
            // 
            // checkOutCalendar
            // 
            this.checkOutCalendar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutCalendar.Location = new System.Drawing.Point(207, 387);
            this.checkOutCalendar.Name = "checkOutCalendar";
            this.checkOutCalendar.Size = new System.Drawing.Size(323, 30);
            this.checkOutCalendar.TabIndex = 25;
            // 
            // checkInCalendar
            // 
            this.checkInCalendar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInCalendar.Location = new System.Drawing.Point(207, 354);
            this.checkInCalendar.Name = "checkInCalendar";
            this.checkInCalendar.Size = new System.Drawing.Size(323, 30);
            this.checkInCalendar.TabIndex = 24;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(454, 320);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(75, 28);
            this.txtServiceCost.TabIndex = 23;
            this.txtServiceCost.Visible = false;
            // 
            // txtRoomCost
            // 
            this.txtRoomCost.Location = new System.Drawing.Point(454, 286);
            this.txtRoomCost.Name = "txtRoomCost";
            this.txtRoomCost.Size = new System.Drawing.Size(75, 28);
            this.txtRoomCost.TabIndex = 23;
            this.txtRoomCost.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Cost";
            this.label14.Visible = false;
            // 
            // comboService
            // 
            this.comboService.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(207, 320);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(189, 29);
            this.comboService.TabIndex = 22;
            this.comboService.Text = "Select Services";
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.ComboService_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Cost";
            this.label13.Visible = false;
            // 
            // comboAvailableRoom
            // 
            this.comboAvailableRoom.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAvailableRoom.FormattingEnabled = true;
            this.comboAvailableRoom.Location = new System.Drawing.Point(207, 286);
            this.comboAvailableRoom.Name = "comboAvailableRoom";
            this.comboAvailableRoom.Size = new System.Drawing.Size(189, 29);
            this.comboAvailableRoom.TabIndex = 20;
            this.comboAvailableRoom.Text = "Choose Room";
            this.comboAvailableRoom.SelectedIndexChanged += new System.EventHandler(this.ComboAvailableRoom_SelectedIndexChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(207, 253);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(115, 28);
            this.txtZip.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(207, 194);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(323, 54);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(207, 128);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(323, 28);
            this.txtPhone.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 28);
            this.txtEmail.TabIndex = 16;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(207, 65);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(323, 28);
            this.txtLName.TabIndex = 13;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(207, 32);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(323, 28);
            this.txtFName.TabIndex = 12;
            this.txtFName.TextChanged += new System.EventHandler(this.TxtFName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Expected Check Out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Expected Check In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Services";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Available Rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Luggage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 171);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnManageReserve);
            this.groupBox1.Controls.Add(this.btnAddReserve);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnManageReserve
            // 
            this.btnManageReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReserve.Location = new System.Drawing.Point(17, 77);
            this.btnManageReserve.Name = "btnManageReserve";
            this.btnManageReserve.Size = new System.Drawing.Size(165, 61);
            this.btnManageReserve.TabIndex = 1;
            this.btnManageReserve.Text = "Manage Reservations";
            this.btnManageReserve.UseVisualStyleBackColor = true;
            this.btnManageReserve.Click += new System.EventHandler(this.BtnManageReserve_Click);
            // 
            // btnAddReserve
            // 
            this.btnAddReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReserve.Location = new System.Drawing.Point(17, 29);
            this.btnAddReserve.Name = "btnAddReserve";
            this.btnAddReserve.Size = new System.Drawing.Size(165, 36);
            this.btnAddReserve.TabIndex = 0;
            this.btnAddReserve.Text = "Reserve Rooms";
            this.btnAddReserve.UseVisualStyleBackColor = true;
            this.btnAddReserve.Click += new System.EventHandler(this.BtnAddReserve_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 538);
            this.Controls.Add(this.ReservePane);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation";
            this.ReservePane.ResumeLayout(false);
            this.ReservePane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReservePane;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker checkOutCalendar;
        private System.Windows.Forms.DateTimePicker checkInCalendar;
        private System.Windows.Forms.TextBox txtRoomCost;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboAvailableRoom;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageReserve;
        private System.Windows.Forms.Button btnAddReserve;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkNot;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkIn;
    }
}