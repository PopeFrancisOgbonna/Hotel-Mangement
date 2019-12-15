using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            loadRooms();
            loadServices();
        }
        //Database connection property
        string connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        string serviceId = null;
        private void BtnAddReserve_Click(object sender, EventArgs e)
        {
            ReservePane.Visible = true;
            lblTitle.Text = "Booking and Reservation";

            dataGridView1.Visible = false;
            label15.Visible = false;
            chkNot.Visible = false;
            chkIn.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            txtAddress.Clear();
            txtEmail.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtRoomCost.Clear();
            txtZip.Clear();
            txtRoomCost.Clear();
            txtServiceCost.Clear();
            if (chkFemale.Checked) { chkFemale.Checked = false; } else { chkMale.Checked = false; }
            if (chkYes.Checked) { chkYes.Checked = false; } else { chkNo.Checked = false; }
            comboAvailableRoom.Text = "Choose Room";
            comboService.Text = "Select Services";
            label13.Visible = false;
            label14.Visible = false;
        }

        private void ComboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Cost,ServiceId from Service where Name=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", comboService.SelectedItem.ToString());
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        txtServiceCost.Text = read[0].ToString();
                        serviceId = read[1].ToString();
                    }
                    read.Close();
                    connect.Close();
                    txtServiceCost.Visible = true;
                    label14.Visible = true;
                    btnSave.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToLower());
                }
            }
          
        }
        int guestId = 0;     
        string Gender = null;
        string Lugage = null;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Gender = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtZip.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
           //ugage = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboAvailableRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            // comboService.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            checkInCalendar.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            checkOutCalendar.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            if (Gender.ToLower() == "male")
            {
                chkMale.Checked = true;
                chkFemale.Checked = false;
                chkFemale.Enabled = false;
            }
            else
            {
                chkFemale.Checked = true;
                chkMale.Checked = false;
                chkMale.Enabled = false;
            }
            //if (Lugage.ToLower() == "yes")
            //{
            //    chkYes.Checked = true;
            //    chkNo.Checked = false;
            //    chkNo.Enabled = false;
            //}
            //else
            //{
            //    chkNo.Checked = true;
            //    chkYes.Checked = false;
            //    chkYes.Enabled = false;
            //}

            label13.Visible = false;
            txtRoomCost.Visible = false;

            
            label15.Visible = true;
            chkNot.Visible = true;
            chkIn.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void TxtFName_TextChanged(object sender, EventArgs e)
        {
            btnClear.Visible = true; btnSave.Visible = true;
        }

        private void BtnManageReserve_Click(object sender, EventArgs e)
        {
            ReservePane.Visible = true;
            dataGridView1.Visible = true;
            lblTitle.Text = "Manage Reservation";
            loadData();

            label15.Visible = false;
            chkNot.Visible = false;
            chkIn.Visible = false;

            txtAddress.Clear();
            txtEmail.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtRoomCost.Clear();
            txtZip.Clear();
            txtRoomCost.Clear();
            txtServiceCost.Clear();
            if (chkFemale.Checked) { chkFemale.Checked = false; } else { chkMale.Checked = false; }
            if (chkYes.Checked) { chkYes.Checked = false; } else { chkNo.Checked = false; }
            comboAvailableRoom.Text = "Choose Room";
            comboService.Text = "Select Services";
            label13.Visible = false;
            label14.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((!chkMale.Checked && !chkFemale.Checked) || (!chkYes.Checked && !chkNo.Checked))
            {
                MessageBox.Show("Please check all Box");
            }
            else if (txtAddress.Text == "" || txtEmail.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtPhone.Text == "" || txtRoomCost.Text == "" || txtZip.Text == "")
            {
                MessageBox.Show("Please fill out all Fields");
            }
            else
            {
                string gender = null;
                string luggage = null;
                if (chkFemale.Checked)
                {
                    gender = "Female";
                }
                else { gender = "Male"; }
                if (chkYes.Checked)
                {
                    luggage = "Yes";
                }
                else
                {
                    luggage = "No";
                }
                try
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        string query = "insert into Reservation values(@param,@param1,@param2,@param3,@param4,@param5,@param6,@param8,@param9,@param10)  update Room set Status='Booked' where Room_No=@param14;";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtFName.Text.Trim());
                        command.Parameters.AddWithValue("@param1", txtLName.Text.Trim());
                        command.Parameters.AddWithValue("@param2", gender);
                        command.Parameters.AddWithValue("@param3", txtPhone.Text.Trim());
                        command.Parameters.AddWithValue("@param4", txtEmail.Text.Trim());
                        command.Parameters.AddWithValue("@param5", txtAddress.Text.Trim());
                        command.Parameters.AddWithValue("@param6", txtZip.Text.Trim());
                       // command.Parameters.AddWithValue("@param7", luggage);
                        command.Parameters.AddWithValue("@param8", comboAvailableRoom.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@param9", checkInCalendar.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@param10", checkOutCalendar.Value.ToShortDateString());
                        //command.Parameters.AddWithValue("@param11", serviceId);
                        //command.Parameters.AddWithValue("@param12", comboAvailableRoom.SelectedItem.ToString());
                        //command.Parameters.AddWithValue("@param13", comboAvailableRoom.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@param14", comboAvailableRoom.SelectedItem.ToString());
                        try
                        {
                            if (connect.State != ConnectionState.Open)
                            {
                                connect.Open();
                            }
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Record Saved");
                                loadData();
                                dataGridView1.Visible = true;
                            }
                            connect.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToLower());
                        }

                    }
                    dataGridView1.Visible = true;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
            }
        }

        private void ChkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked)
            {
                chkFemale.Enabled = false;
            }
            else { chkFemale.Enabled = true; }
        }

        private void ChkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked)
            {
                chkYes.Enabled = false;
            }
            else { chkYes.Enabled = true; }
        }

        private void ChkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked)
            {
                chkMale.Enabled = false;
            }
            else { chkMale.Enabled = true; }
        }

        private void ChkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYes.Checked)
            {
                chkNo.Enabled = false;
            }
            else { chkNo.Enabled = true; }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtRoomCost.Clear();
            txtZip.Clear();
            txtRoomCost.Clear();
            txtServiceCost.Clear();
            if (chkFemale.Checked) { chkFemale.Checked = false; } else { chkMale.Checked = false; }
            if (chkYes.Checked) { chkYes.Checked = false; } else { chkNo.Checked = false; }
            comboAvailableRoom.Text = "Choose Room";
            comboService.Text = "Select Services";
            label13.Visible = false;
            label14.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string room = null;
            if (comboAvailableRoom.SelectedItem == null)
            { 
                room = comboAvailableRoom.Text;
            }
            else 
            {
                room = comboAvailableRoom.SelectedItem.ToString();
            }
           
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                
                if ((chkYes.Checked || chkNo.Checked) && chkIn.Checked)
                {
                   //tring gender = null;
                    string luggage = null;
                    //if (chkFemale.Checked)
                    //{
                    //    gender = "Female";
                    //}
                    //else { gender = "Male"; }
                    if (chkYes.Checked)
                    {
                        luggage = "Yes";
                    }
                    else
                    {
                        luggage = "No";
                    }
                    if (comboService.SelectedItem == null)
                    {
                        MessageBox.Show("Please add Service");
                    }
                    else
                    {
                        try
                        {
                            string query = "insert into Guest values((select FName from Reservation),(select LName from Reservation),(select Gender from Reservation),(select Phone_No from Reservation),(select Email from Reservation),(select Guest_Address from Reservation),(select Zipcode from Reservation),@param7,@param8,(select Expected_In from Reservation),(select Expected_Out from Reservation)) insert into Bill values(@param11,(select GuestId from Guest where  Room_No=@param12),@param13) update Room set Status='Occupied' where Room_No=@param14  Delete  from Reservation where ReserveId=@param15;";
                            SqlCommand command = new SqlCommand(query, connect);
                            //command.Parameters.AddWithValue("@param", txtFName.Text.Trim());
                            //command.Parameters.AddWithValue("@param1", txtLName.Text.Trim());
                            //command.Parameters.AddWithValue("@param2", Gender);
                            //command.Parameters.AddWithValue("@param3", txtPhone.Text.Trim());
                            //command.Parameters.AddWithValue("@param4", txtEmail.Text.Trim());
                            //command.Parameters.AddWithValue("@param5", txtAddress.Text.Trim());
                            //command.Parameters.AddWithValue("@param6", txtZip.Text.Trim()); 
                            command.Parameters.AddWithValue("@param7", luggage);
                            command.Parameters.AddWithValue("@param8", room);
                            //command.Parameters.AddWithValue("@param9", checkInCalendar.Value.ToShortDateString());
                            //command.Parameters.AddWithValue("@param10", checkOutCalendar.Value.ToShortDateString());
                            command.Parameters.AddWithValue("@param11", serviceId);
                            command.Parameters.AddWithValue("@param12", room);
                            command.Parameters.AddWithValue("@param13", room);
                            command.Parameters.AddWithValue("@param14", room);
                            command.Parameters.AddWithValue("@param15", guestId);
                            try
                            {
                                if (connect.State != ConnectionState.Open)
                                {
                                    connect.Open();
                                }
                                int i = command.ExecuteNonQuery();
                                if (i > 0)
                                {
                                    MessageBox.Show("Record Saved");
                                    loadData();
                                    dataGridView1.Visible = true;
                                }
                                connect.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToLower());
                            }
                        }
                        catch (Exception d)
                        {
                            MessageBox.Show(d.Message.ToString());
                        }
                    }
                   
                }
                else
                {
                    string query = "update Reservation set FName=@param,LName=@param1,Gender=@param2,Phone_No=@param3,Email=@param4,Guest_Address=@param5,Zipcode=@param6,Room_No=@param7,Expected_In =@param8,Expected_Out=@param9 where ReserveId=@param10;";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtFName.Text.Trim());
                    command.Parameters.AddWithValue("@param1", txtLName.Text.Trim());
                    command.Parameters.AddWithValue("@param2", Gender);
                    command.Parameters.AddWithValue("@param3", txtPhone.Text.Trim());
                    command.Parameters.AddWithValue("@param4", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@param5", txtAddress.Text.Trim());
                    command.Parameters.AddWithValue("@param6", txtZip.Text.Trim());
                    //ommand.Parameters.AddWithValue("@param7", Lugage); 
                    command.Parameters.AddWithValue("@param7", room);
                    command.Parameters.AddWithValue("@param8", checkInCalendar.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@param9", checkOutCalendar.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@param10", guestId);
                    try
                    {
                        connect.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Updated");
                        }
                        connect.Close();
                        loadData();
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.Message.ToString());
                    }
                }
                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "Delete from Reservation where ReserveId=@param";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", guestId);
                try
                {
                    connect.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    connect.Close();
                    loadData();
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message.ToString());
                }
            }
        }
        private void loadRooms()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Room_No from Room where lower(Status)='available';";
                SqlCommand command = new SqlCommand(query, connect);

                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        comboAvailableRoom.Items.Add(read[0].ToString());
                    }
                    read.Close();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToLower());
                }

            }
        }
        private void loadServices()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Name from Service;";
                SqlCommand command = new SqlCommand(query, connect);

                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        comboService.Items.Add(read[0].ToString());
                    }
                    read.Close();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToLower());
                }

            }
        }

        private void ComboAvailableRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Cost from Room where Room_No=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", comboAvailableRoom.SelectedItem.ToString());
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        txtRoomCost.Text = read[0].ToString();
                    }
                    read.Close();
                    connect.Close();
                    txtRoomCost.Visible = true;
                    label13.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToLower());
                }
            }
        }
        private void loadData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select * from Reservation";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }

        private void ChkNot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNot.Checked)
            {
                chkIn.Enabled = false;
            }
            else { chkIn.Enabled = true; }
        }

        private void ChkIn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIn.Checked)
            {
                chkNot.Enabled = false;
            }
            else
            {
                chkNot.Enabled = true;
            }
        }
    }
}
