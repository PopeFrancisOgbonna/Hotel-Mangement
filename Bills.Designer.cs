namespace HotelManagementSystem
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReceivePay = new System.Windows.Forms.Button();
            this.btnPendingBill = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.billPayPane = new System.Windows.Forms.Panel();
            this.pendingPane = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.billDetails = new System.Windows.Forms.GroupBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboGuest = new System.Windows.Forms.ComboBox();
            this.comboServices = new System.Windows.Forms.ComboBox();
            this.lblguest = new System.Windows.Forms.Label();
            this.lblservice = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.billPayPane.SuspendLayout();
            this.pendingPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.billDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 179);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnReceivePay);
            this.groupBox1.Controls.Add(this.btnPendingBill);
            this.groupBox1.Controls.Add(this.btnAddBill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnReceivePay
            // 
            this.btnReceivePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceivePay.Location = new System.Drawing.Point(15, 112);
            this.btnReceivePay.Name = "btnReceivePay";
            this.btnReceivePay.Size = new System.Drawing.Size(165, 37);
            this.btnReceivePay.TabIndex = 2;
            this.btnReceivePay.Text = "Receive Payment";
            this.btnReceivePay.UseVisualStyleBackColor = true;
            this.btnReceivePay.Click += new System.EventHandler(this.BtnReceivePay_Click);
            // 
            // btnPendingBill
            // 
            this.btnPendingBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingBill.Location = new System.Drawing.Point(15, 66);
            this.btnPendingBill.Name = "btnPendingBill";
            this.btnPendingBill.Size = new System.Drawing.Size(165, 37);
            this.btnPendingBill.TabIndex = 1;
            this.btnPendingBill.Text = "Pending Bills";
            this.btnPendingBill.UseVisualStyleBackColor = true;
            this.btnPendingBill.Click += new System.EventHandler(this.BtnPendingBill_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Location = new System.Drawing.Point(15, 21);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(165, 36);
            this.btnAddBill.TabIndex = 0;
            this.btnAddBill.Text = "Add Guest Bills";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // billPayPane
            // 
            this.billPayPane.BackColor = System.Drawing.SystemColors.Desktop;
            this.billPayPane.Controls.Add(this.pendingPane);
            this.billPayPane.Controls.Add(this.btnPay);
            this.billPayPane.Controls.Add(this.billDetails);
            this.billPayPane.Controls.Add(this.pictureBox1);
            this.billPayPane.Location = new System.Drawing.Point(220, 21);
            this.billPayPane.Name = "billPayPane";
            this.billPayPane.Size = new System.Drawing.Size(736, 395);
            this.billPayPane.TabIndex = 4;
            // 
            // pendingPane
            // 
            this.pendingPane.Controls.Add(this.dataGridView1);
            this.pendingPane.Location = new System.Drawing.Point(276, 5);
            this.pendingPane.Name = "pendingPane";
            this.pendingPane.Size = new System.Drawing.Size(458, 388);
            this.pendingPane.TabIndex = 3;
            this.pendingPane.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Green;
            this.btnPay.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(516, 334);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(154, 49);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay Now";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // billDetails
            // 
            this.billDetails.BackColor = System.Drawing.Color.Transparent;
            this.billDetails.Controls.Add(this.txtOut);
            this.billDetails.Controls.Add(this.txtTotalBill);
            this.billDetails.Controls.Add(this.txtServiceCharge);
            this.billDetails.Controls.Add(this.txtRoom);
            this.billDetails.Controls.Add(this.txtIn);
            this.billDetails.Controls.Add(this.txtName);
            this.billDetails.Controls.Add(this.lblTotal);
            this.billDetails.Controls.Add(this.label5);
            this.billDetails.Controls.Add(this.label4);
            this.billDetails.Controls.Add(this.label3);
            this.billDetails.Controls.Add(this.label2);
            this.billDetails.Controls.Add(this.label1);
            this.billDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDetails.ForeColor = System.Drawing.Color.White;
            this.billDetails.Location = new System.Drawing.Point(289, 30);
            this.billDetails.Name = "billDetails";
            this.billDetails.Size = new System.Drawing.Size(431, 292);
            this.billDetails.TabIndex = 1;
            this.billDetails.TabStop = false;
            this.billDetails.Visible = false;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(200, 158);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(213, 26);
            this.txtOut.TabIndex = 11;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(200, 240);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(213, 26);
            this.txtTotalBill.TabIndex = 10;
            this.txtTotalBill.Visible = false;
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Location = new System.Drawing.Point(200, 199);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(213, 26);
            this.txtServiceCharge.TabIndex = 9;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(200, 76);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(213, 26);
            this.txtRoom.TabIndex = 8;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(200, 117);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(213, 26);
            this.txtIn.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 26);
            this.txtName.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Bill";
            this.lblTotal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Severvice Charge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expected Check out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check In ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboGuest
            // 
            this.comboGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGuest.FormattingEnabled = true;
            this.comboGuest.Location = new System.Drawing.Point(10, 257);
            this.comboGuest.Name = "comboGuest";
            this.comboGuest.Size = new System.Drawing.Size(194, 24);
            this.comboGuest.TabIndex = 5;
            this.comboGuest.Text = "Select Guest Name";
            this.comboGuest.Visible = false;
            this.comboGuest.SelectedIndexChanged += new System.EventHandler(this.ComboGuest_SelectedIndexChanged);
            // 
            // comboServices
            // 
            this.comboServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboServices.FormattingEnabled = true;
            this.comboServices.Location = new System.Drawing.Point(10, 322);
            this.comboServices.Name = "comboServices";
            this.comboServices.Size = new System.Drawing.Size(194, 24);
            this.comboServices.TabIndex = 6;
            this.comboServices.Text = "Choose Service to Add";
            this.comboServices.Visible = false;
            this.comboServices.SelectedIndexChanged += new System.EventHandler(this.ComboServices_SelectedIndexChanged);
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguest.ForeColor = System.Drawing.Color.Magenta;
            this.lblguest.Location = new System.Drawing.Point(32, 235);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(93, 18);
            this.lblguest.TabIndex = 7;
            this.lblguest.Text = "Select Guest";
            this.lblguest.Visible = false;
            // 
            // lblservice
            // 
            this.lblservice.AutoSize = true;
            this.lblservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice.ForeColor = System.Drawing.Color.Magenta;
            this.lblservice.Location = new System.Drawing.Point(29, 301);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(110, 18);
            this.lblservice.TabIndex = 8;
            this.lblservice.Text = "Select Services";
            this.lblservice.Visible = false;
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAddService.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(121, 363);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(76, 35);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Visible = false;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 441);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lblservice);
            this.Controls.Add(this.lblguest);
            this.Controls.Add(this.comboServices);
            this.Controls.Add(this.comboGuest);
            this.Controls.Add(this.billPayPane);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.billPayPane.ResumeLayout(false);
            this.pendingPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.billDetails.ResumeLayout(false);
            this.billDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReceivePay;
        private System.Windows.Forms.Button btnPendingBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Panel billPayPane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboGuest;
        private System.Windows.Forms.GroupBox billDetails;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox comboServices;
        private System.Windows.Forms.Label lblguest;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Panel pendingPane;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}