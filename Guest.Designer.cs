namespace HotelManagementSystem
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageGuest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.addGuestPane = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboRooms = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
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
            this.searchOptionPane = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.searchGuestPane = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.searchCalendar = new System.Windows.Forms.DateTimePicker();
            this.lblsearchInstruct = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.addGuestPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.searchOptionPane.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.searchGuestPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 179);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnManageGuest);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnManageGuest
            // 
            this.btnManageGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGuest.Location = new System.Drawing.Point(18, 113);
            this.btnManageGuest.Name = "btnManageGuest";
            this.btnManageGuest.Size = new System.Drawing.Size(165, 36);
            this.btnManageGuest.TabIndex = 2;
            this.btnManageGuest.Text = "Manage Guest";
            this.btnManageGuest.UseVisualStyleBackColor = true;
            this.btnManageGuest.Click += new System.EventHandler(this.BtnManageGuest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(18, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Guest";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(18, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Guest";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // addGuestPane
            // 
            this.addGuestPane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addGuestPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addGuestPane.Controls.Add(this.lblTitle);
            this.addGuestPane.Controls.Add(this.btnClear);
            this.addGuestPane.Controls.Add(this.btnUpdate);
            this.addGuestPane.Controls.Add(this.btnDelete);
            this.addGuestPane.Controls.Add(this.btnSave);
            this.addGuestPane.Controls.Add(this.dataGridView1);
            this.addGuestPane.Controls.Add(this.groupBox3);
            this.addGuestPane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGuestPane.Location = new System.Drawing.Point(241, 12);
            this.addGuestPane.Name = "addGuestPane";
            this.addGuestPane.Size = new System.Drawing.Size(1033, 508);
            this.addGuestPane.TabIndex = 1;
            this.addGuestPane.Visible = false;
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
            this.btnClear.Location = new System.Drawing.Point(383, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 41);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(269, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(547, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 405);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNo);
            this.groupBox3.Controls.Add(this.chkYes);
            this.groupBox3.Controls.Add(this.chkFemale);
            this.groupBox3.Controls.Add(this.chkMale);
            this.groupBox3.Controls.Add(this.dateOut);
            this.groupBox3.Controls.Add(this.dateIn);
            this.groupBox3.Controls.Add(this.txtServiceCost);
            this.groupBox3.Controls.Add(this.txtcost);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboService);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboRooms);
            this.groupBox3.Controls.Add(this.txtZip);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtMail);
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
            this.groupBox3.Size = new System.Drawing.Size(530, 425);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(469, 257);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(53, 25);
            this.chkNo.TabIndex = 31;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.ChkNo_CheckedChanged);
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(404, 256);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(61, 25);
            this.chkYes.TabIndex = 30;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.ChkYes_CheckedChanged);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(390, 103);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(92, 25);
            this.chkFemale.TabIndex = 29;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.ChkFemale_CheckedChanged);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(207, 100);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(72, 25);
            this.chkMale.TabIndex = 28;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.ChkMale_CheckedChanged);
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(194, 387);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(323, 28);
            this.dateOut.TabIndex = 25;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(194, 354);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(323, 28);
            this.dateIn.TabIndex = 24;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(423, 318);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(94, 28);
            this.txtServiceCost.TabIndex = 23;
            this.txtServiceCost.Visible = false;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(422, 286);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(94, 28);
            this.txtcost.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Cost";
            this.label14.Visible = false;
            // 
            // comboService
            // 
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(194, 320);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(167, 29);
            this.comboService.TabIndex = 22;
            this.comboService.SelectedIndexChanged += new System.EventHandler(this.ComboService_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Cost";
            // 
            // comboRooms
            // 
            this.comboRooms.FormattingEnabled = true;
            this.comboRooms.Location = new System.Drawing.Point(194, 286);
            this.comboRooms.Name = "comboRooms";
            this.comboRooms.Size = new System.Drawing.Size(147, 29);
            this.comboRooms.TabIndex = 20;
            this.comboRooms.SelectedIndexChanged += new System.EventHandler(this.ComboRooms_SelectedIndexChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(194, 253);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(115, 28);
            this.txtZip.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(194, 194);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(323, 54);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(194, 128);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(323, 28);
            this.txtPhone.TabIndex = 17;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(194, 161);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(323, 28);
            this.txtMail.TabIndex = 16;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(194, 65);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(323, 28);
            this.txtLName.TabIndex = 13;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(194, 32);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(323, 28);
            this.txtFName.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Checked Out Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Checked In Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Services";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Available Rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Luggage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // searchOptionPane
            // 
            this.searchOptionPane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchOptionPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchOptionPane.Controls.Add(this.groupBox2);
            this.searchOptionPane.Location = new System.Drawing.Point(12, 203);
            this.searchOptionPane.Name = "searchOptionPane";
            this.searchOptionPane.Size = new System.Drawing.Size(202, 232);
            this.searchOptionPane.TabIndex = 3;
            this.searchOptionPane.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSearchDate);
            this.groupBox2.Controls.Add(this.btnSearchID);
            this.groupBox2.Controls.Add(this.btnSearchName);
            this.groupBox2.Controls.Add(this.btnViewAll);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Options";
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDate.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Location = new System.Drawing.Point(12, 164);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(166, 41);
            this.btnSearchDate.TabIndex = 3;
            this.btnSearchDate.Text = "Search by Date";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.BtnSearchDate_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchID.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.ForeColor = System.Drawing.Color.White;
            this.btnSearchID.Location = new System.Drawing.Point(12, 117);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(166, 41);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search by ID";
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.BtnSearchID_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.ForeColor = System.Drawing.Color.White;
            this.btnSearchName.Location = new System.Drawing.Point(12, 70);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(166, 41);
            this.btnSearchName.TabIndex = 1;
            this.btnSearchName.Text = "Search by Name";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.BtnSearchName_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(12, 23);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(166, 41);
            this.btnViewAll.TabIndex = 0;
            this.btnViewAll.Text = "View All Guest";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // searchGuestPane
            // 
            this.searchGuestPane.BackColor = System.Drawing.SystemColors.ControlText;
            this.searchGuestPane.Controls.Add(this.dataGridView2);
            this.searchGuestPane.Controls.Add(this.pictureBox1);
            this.searchGuestPane.Location = new System.Drawing.Point(241, 12);
            this.searchGuestPane.Name = "searchGuestPane";
            this.searchGuestPane.Size = new System.Drawing.Size(1033, 508);
            this.searchGuestPane.TabIndex = 28;
            this.searchGuestPane.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(358, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(665, 454);
            this.dataGridView2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKey.Location = new System.Drawing.Point(11, 466);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(196, 29);
            this.txtSearchKey.TabIndex = 29;
            this.txtSearchKey.Visible = false;
            // 
            // searchCalendar
            // 
            this.searchCalendar.CustomFormat = "dd-MMM-yyyy";
            this.searchCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchCalendar.Location = new System.Drawing.Point(10, 501);
            this.searchCalendar.Name = "searchCalendar";
            this.searchCalendar.Size = new System.Drawing.Size(146, 29);
            this.searchCalendar.TabIndex = 30;
            this.searchCalendar.Visible = false;
            // 
            // lblsearchInstruct
            // 
            this.lblsearchInstruct.AutoSize = true;
            this.lblsearchInstruct.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchInstruct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblsearchInstruct.Location = new System.Drawing.Point(6, 441);
            this.lblsearchInstruct.Name = "lblsearchInstruct";
            this.lblsearchInstruct.Size = new System.Drawing.Size(59, 17);
            this.lblsearchInstruct.TabIndex = 31;
            this.lblsearchInstruct.Text = "label14";
            this.lblsearchInstruct.Visible = false;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.Color.Blue;
            this.btnGO.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.ForeColor = System.Drawing.Color.White;
            this.btnGO.Location = new System.Drawing.Point(166, 501);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(71, 42);
            this.btnGO.TabIndex = 32;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Visible = false;
            this.btnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 552);
            this.Controls.Add(this.addGuestPane);
            this.Controls.Add(this.searchGuestPane);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.lblsearchInstruct);
            this.Controls.Add(this.searchCalendar);
            this.Controls.Add(this.txtSearchKey);
            this.Controls.Add(this.searchOptionPane);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guest";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.addGuestPane.ResumeLayout(false);
            this.addGuestPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.searchOptionPane.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.searchGuestPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel addGuestPane;
        private System.Windows.Forms.Panel searchOptionPane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboRooms;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMail;
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
        private System.Windows.Forms.Panel searchGuestPane;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.DateTimePicker searchCalendar;
        private System.Windows.Forms.Label lblsearchInstruct;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnManageGuest;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label14;
    }
}