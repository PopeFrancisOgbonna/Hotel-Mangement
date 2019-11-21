namespace HotelManagementSystem
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dataPane = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDlete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImageLoad = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dataPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 142);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnManageRoom);
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Location = new System.Drawing.Point(12, 71);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(165, 36);
            this.btnManageRoom.TabIndex = 1;
            this.btnManageRoom.Text = "Manage Rooms";
            this.btnManageRoom.UseVisualStyleBackColor = true;
            this.btnManageRoom.Click += new System.EventHandler(this.BtnManageRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Location = new System.Drawing.Point(12, 27);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(165, 36);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Rooms";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // dataPane
            // 
            this.dataPane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataPane.Controls.Add(this.dataGridView1);
            this.dataPane.Controls.Add(this.btnDlete);
            this.dataPane.Controls.Add(this.btnUpdate);
            this.dataPane.Controls.Add(this.btnClear);
            this.dataPane.Controls.Add(this.btnSaveRoom);
            this.dataPane.Controls.Add(this.groupBox2);
            this.dataPane.Location = new System.Drawing.Point(224, 24);
            this.dataPane.Name = "dataPane";
            this.dataPane.Size = new System.Drawing.Size(930, 425);
            this.dataPane.TabIndex = 2;
            this.dataPane.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 348);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnDlete
            // 
            this.btnDlete.BackColor = System.Drawing.Color.Red;
            this.btnDlete.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlete.ForeColor = System.Drawing.Color.White;
            this.btnDlete.Image = ((System.Drawing.Image)(resources.GetObject("btnDlete.Image")));
            this.btnDlete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDlete.Location = new System.Drawing.Point(798, 375);
            this.btnDlete.Name = "btnDlete";
            this.btnDlete.Size = new System.Drawing.Size(118, 40);
            this.btnDlete.TabIndex = 2;
            this.btnDlete.Text = "Delete";
            this.btnDlete.UseVisualStyleBackColor = false;
            this.btnDlete.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(660, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(178, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveRoom.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRoom.ForeColor = System.Drawing.Color.White;
            this.btnSaveRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRoom.Image")));
            this.btnSaveRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveRoom.Location = new System.Drawing.Point(64, 301);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(99, 40);
            this.btnSaveRoom.TabIndex = 1;
            this.btnSaveRoom.Text = "Save";
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            this.btnSaveRoom.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImageLoad);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.TxtStatus);
            this.groupBox2.Controls.Add(this.txtRoomNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnImageLoad
            // 
            this.btnImageLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageLoad.Location = new System.Drawing.Point(136, 176);
            this.btnImageLoad.Name = "btnImageLoad";
            this.btnImageLoad.Size = new System.Drawing.Size(211, 37);
            this.btnImageLoad.TabIndex = 11;
            this.btnImageLoad.Text = "Upload Room Image";
            this.btnImageLoad.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 141);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 29);
            this.txtDescription.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(136, 219);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(211, 29);
            this.txtCost.TabIndex = 9;
            this.txtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(136, 71);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(211, 29);
            this.txtType.TabIndex = 8;
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(136, 106);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(211, 29);
            this.TxtStatus.TabIndex = 7;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(136, 36);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(211, 29);
            this.txtRoomNo.TabIndex = 6;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.TxtRoomNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 464);
            this.Controls.Add(this.dataPane);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rooms";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.dataPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel dataPane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDlete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Button btnImageLoad;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label6;
    }
}