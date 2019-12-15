using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HotelManagementSystem
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        //Database connection property
        string connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            dataPane.Visible = true;
            dataGridView1.Visible = false;
            btnUpdate.Visible = false;
            btnDlete.Visible = false;
            txtRoomNo.Enabled = true;

            txtCost.Clear();
            txtDescription.Clear();
            TxtStatus.Clear();
            txtType.Clear();
            txtRoomNo.Clear();
            pictureBox1.Visible = false;
        }

        private void BtnManageRoom_Click(object sender, EventArgs e)
        {
            dataPane.Visible = true;
            dataGridView1.Visible = true;
            txtRoomNo.Enabled = true;
            LoadData();
            //clear Inputs
            txtCost.Clear();
            txtDescription.Clear();
            TxtStatus.Clear();
            txtType.Clear();
            txtRoomNo.Clear();
            pictureBox1.Visible = false;
        }

        private void TxtRoomNo_TextChanged(object sender, EventArgs e)
        {
            btnClear.Visible = true;
        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {
            btnSaveRoom.Visible = true;
        }
      
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomNo.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtStatus.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            img = (byte[])(dataGridView1.Rows[e.RowIndex].Cells[3].Value); 
            txtCost.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.Visible = true;
            txtRoomNo.Enabled = false;
           
            btnUpdate.Visible = true;
            btnDlete.Visible = true;
            btnClear.Visible = false;
            btnSaveRoom.Visible = false;
        }
        string imgLoc = null;
        private void BtnImageLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgLoc = file.FileName;
                pictureBox1.ImageLocation = imgLoc;
                pictureBox1.Visible = true;

            }
        }
        byte[] img = null;
        private void BtnSaveRoom_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtDescription.Text == "" || txtRoomNo.Text == "" || TxtStatus.Text == "" || txtType.Text == "")
            {
                MessageBox.Show("Please Fill Out all Fields");
            }else if (pictureBox1.Visible == false) { MessageBox.Show("Please Upload Room Image"); }
            else
            {
                try
                {
                   
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader rd = new BinaryReader(fs);
                    img = rd.ReadBytes((int)fs.Length);
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        string query = "insert into Room values(@param,@param1,@param2,@param3,@param4);";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtRoomNo.Text.Trim());
                        command.Parameters.AddWithValue("@Param1", txtType.Text.Trim());
                        command.Parameters.AddWithValue("@param2", TxtStatus.Text.Trim());
                        command.Parameters.AddWithValue("@param3", img);
                        command.Parameters.AddWithValue("@param4", txtCost.Text.Trim());
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Saved");
                            LoadData();
                            dataGridView1.Visible = true;
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
               
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCost.Clear();
            txtDescription.Clear();
            TxtStatus.Clear();
            txtType.Clear();
            txtRoomNo.Clear();
            pictureBox1.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using(SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "update Room set Type=@param1,Status=@param2,Picture=@param3,Cost=@param4 where Room_No=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", txtRoomNo.Text.Trim());
                command.Parameters.AddWithValue("@param1", txtType.Text.Trim());
                command.Parameters.AddWithValue("@param2", TxtStatus.Text.Trim());
                command.Parameters.AddWithValue("@param3", img);
                command.Parameters.AddWithValue("@param4", txtCost.Text.Trim());
                try
                {
                    connect.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Updated");
                        LoadData();
                    }
                    connect.Close(); 
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message.ToString());
                }
            }
        }

        private void BtnDlete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "Delete from Room where Room_No=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", txtRoomNo.Text.Trim());
               
                try
                {
                    connect.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Deleted");
                        LoadData();
                    }
                    connect.Close();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message.ToString());
                }
            }
        }
        private void LoadData()//code to load data to data gride view
        {
            using(SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select * from Room";
                SqlCommand command = new SqlCommand(query, connect);
                DataTable tbl = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }
    }
}
