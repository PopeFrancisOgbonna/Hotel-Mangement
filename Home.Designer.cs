namespace HotelManagementSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrollPane = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripButton();
            this.toolGuest = new System.Windows.Forms.ToolStripButton();
            this.toolRooms = new System.Windows.Forms.ToolStripButton();
            this.toolReserve = new System.Windows.Forms.ToolStripButton();
            this.toolBill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.scrollPane);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 583);
            this.panel1.TabIndex = 0;
            // 
            // scrollPane
            // 
            this.scrollPane.BackColor = System.Drawing.Color.DarkOrange;
            this.scrollPane.Location = new System.Drawing.Point(188, 213);
            this.scrollPane.Name = "scrollPane";
            this.scrollPane.Size = new System.Drawing.Size(10, 100);
            this.scrollPane.TabIndex = 8;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashBoard.Location = new System.Drawing.Point(7, 213);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(177, 53);
            this.btnDashBoard.TabIndex = 6;
            this.btnDashBoard.Text = "Dashboard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(6, 505);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(177, 53);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnServices
            // 
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServices.Location = new System.Drawing.Point(6, 432);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(177, 53);
            this.btnServices.TabIndex = 4;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckOut.Location = new System.Drawing.Point(6, 359);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(177, 53);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckIn.Location = new System.Drawing.Point(6, 286);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(177, 53);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Lime;
            this.lblUser.Location = new System.Drawing.Point(7, 161);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hotel Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus,
            this.toolGuest,
            this.toolRooms,
            this.toolReserve,
            this.toolBill,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(233, 100);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 32);
            this.toolStrip1.TabIndex = 7;
            // 
            // toolStatus
            // 
            this.toolStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStatus.Image")));
            this.toolStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(82, 29);
            this.toolStatus.Text = "Status";
            // 
            // toolGuest
            // 
            this.toolGuest.Image = ((System.Drawing.Image)(resources.GetObject("toolGuest.Image")));
            this.toolGuest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuest.Name = "toolGuest";
            this.toolGuest.Size = new System.Drawing.Size(86, 29);
            this.toolGuest.Text = "Guests";
            this.toolGuest.Click += new System.EventHandler(this.ToolGuest_Click);
            // 
            // toolRooms
            // 
            this.toolRooms.Image = ((System.Drawing.Image)(resources.GetObject("toolRooms.Image")));
            this.toolRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRooms.Name = "toolRooms";
            this.toolRooms.Size = new System.Drawing.Size(148, 29);
            this.toolRooms.Text = "Manage Rooms";
            this.toolRooms.Click += new System.EventHandler(this.ToolRooms_Click);
            // 
            // toolReserve
            // 
            this.toolReserve.Image = ((System.Drawing.Image)(resources.GetObject("toolReserve.Image")));
            this.toolReserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReserve.Name = "toolReserve";
            this.toolReserve.Size = new System.Drawing.Size(121, 29);
            this.toolReserve.Text = "Reservation";
            this.toolReserve.Click += new System.EventHandler(this.ToolReserve_Click);
            // 
            // toolBill
            // 
            this.toolBill.Image = ((System.Drawing.Image)(resources.GetObject("toolBill.Image")));
            this.toolBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBill.Name = "toolBill";
            this.toolBill.Size = new System.Drawing.Size(82, 29);
            this.toolBill.Text = "Billing";
            this.toolBill.Click += new System.EventHandler(this.ToolBill_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(81, 29);
            this.toolStripButton5.Text = "About";
            this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(71, 29);
            this.toolStripButton6.Text = "Help";
            this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1248, 604);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStatus;
        private System.Windows.Forms.ToolStripButton toolGuest;
        private System.Windows.Forms.ToolStripButton toolReserve;
        private System.Windows.Forms.ToolStripButton toolBill;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Panel scrollPane;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripButton toolRooms;
    }
}