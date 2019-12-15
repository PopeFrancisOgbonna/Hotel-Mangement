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

namespace HotelManagementSystem
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
            loadAvailableRooms();
            loadServices();
        }
        //Database connection property
        string connectionString = @"Data Source=.;Initial catalog=HotelManagementSystem;Integrated Security=True;";
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchOptionPane.Visible = true;
            addGuestPane.Visible = false;
            searchGuestPane.Visible = false;

            //Hide non relivance buttons
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            searchCalendar.Visible = false;
            btnGO.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            searchOptionPane.Visible = false;
            addGuestPane.Visible = true;
            lblTitle.Text = "Add New Guest";
            searchGuestPane.Visible = false;
            comboService.Text = "Choose Services";
            comboRooms.Text = "Select Room";
          
            groupBox3.Visible = true;
            btnClear.Visible = true;
            btnSave.Visible = true;

            //Hide non relevance buttons
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            searchCalendar.Visible = false;
            btnGO.Visible = false;
            dataGridView1.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void BtnManageGuest_Click(object sender, EventArgs e)
        {
            addGuestPane.Visible = true;
            lblTitle.Text = "Manage Guests";
            searchGuestPane.Visible = false;
            dataGridView1.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            loadData();

            //Clear all Fields
            txtZip.Clear();
            txtcost.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtLName.Clear();
            txtFName.Clear();
            txtFName.Clear();
            txtAddress.Clear();
            if (chkFemale.Checked) { chkFemale.Checked = false; } else { chkMale.Checked = false; }
            if (chkYes.Checked) { chkYes.Checked = false; } else { chkNo.Checked = false; }
            comboRooms.Text = "Choose Room";
            comboService.Text = "Select Services";

            //Hide non relevance button
            searchOptionPane.Visible = false;
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            searchCalendar.Visible = false;
            btnGO.Visible = false;
           // groupBox3.Visible = false;
            btnSave.Visible = false;
            btnClear.Visible = false;
        }

        private void BtnGO_Click(object sender, EventArgs e)
        {
            searchGuestPane.Visible = true;
            searchQuery();
            txtSearchKey.Clear();
           
        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            searchCalendar.Visible = false;
            lblsearchInstruct.Text = "Enter Guest Name";
            lblsearchInstruct.Visible = true;
            txtSearchKey.Visible = true;
            btnGO.Visible = true;
        }

        private void BtnSearchID_Click(object sender, EventArgs e)
        {
            searchCalendar.Visible = false;
            lblsearchInstruct.Text = "Enter Guest ID";
            lblsearchInstruct.Visible = true;
            txtSearchKey.Visible = true;
            btnGO.Visible = true;
        }

        private void BtnSearchDate_Click(object sender, EventArgs e)
        {
            searchCalendar.Visible = true; ;
            lblsearchInstruct.Text = "Choose Date below";
            lblsearchInstruct.Visible = true;
            txtSearchKey.Visible = false;
            btnGO.Visible = true;
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            searchGuestPane.Visible = true;
            lblsearchInstruct.Text = "";
            searchQuery();

            //Hide irrelevant buttons
            searchCalendar.Visible = false;
            lblsearchInstruct.Text = "";
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            btnGO.Visible = false;
        }
        string serviceId = null;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((!chkFemale.Checked && !chkMale.Checked) || (!chkNo.Checked && !chkYes.Checked))
            {
                MessageBox.Show("Please check all Box");
            }
            else if (txtAddress.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtMail.Text == "" || txtPhone.Text == "" || txtcost.Text == "" || txtZip.Text == "")
            {
                MessageBox.Show("Please Fill all Field");
            }else if (!txtMail.Text.Contains("@")) { MessageBox.Show("Please Enter a valid Email"); }
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
                        string query = "insert into Guest values(@param,@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10) insert into Bill values(@param11,(select GuestId from Guest where  Room_No=@param12),@param13) update Room set Status='Occupied' where Room_No=@param14;";
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtFName.Text.Trim());
                        command.Parameters.AddWithValue("@param1", txtLName.Text.Trim());
                        command.Parameters.AddWithValue("@param2",gender);
                        command.Parameters.AddWithValue("@param3",txtPhone.Text.Trim());
                        command.Parameters.AddWithValue("@param4",txtMail.Text.Trim());
                        command.Parameters.AddWithValue("@param5",txtAddress.Text.Trim());
                        command.Parameters.AddWithValue("@param6",txtZip.Text.Trim());
                        command.Parameters.AddWithValue("@param7",luggage);
                        command.Parameters.AddWithValue("@param8",comboRooms.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@param9",dateIn.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@param10", dateOut.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@param11",serviceId);
                        command.Parameters.AddWithValue("@param12",comboRooms.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@param13", comboRooms.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@param14", comboRooms.SelectedItem.ToString());
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
                }
                catch (Exception)
                {

                    throw;
                }  }
        }

        private void ChkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked)
            {
                chkFemale.Enabled = false;
            }
            else { chkFemale.Enabled = true; }
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

        private void ChkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked)
            {
                chkYes.Enabled = false;
            }
            else { chkYes.Enabled = true; }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtZip.Clear();
            txtcost.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtLName.Clear();
            txtFName.Clear();
            txtFName.Clear();
            txtAddress.Clear();
            if (chkFemale.Checked) { chkFemale.Checked = false; } else { chkMale.Checked = false; }
            if (chkYes.Checked) { chkYes.Checked = false; } else { chkNo.Checked = false; }
            comboRooms.Text = "Choose Room";
            comboService.Text = "Select Services";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string room = null;
            if (comboRooms.SelectedItem == null)
            {
                room = comboRooms.Text;
            }
            else
            {
                room = comboRooms.SelectedItem.ToString();
            }
            using (SqlConnection connect = new SqlConnection(connectionString))  
            {
                string query = "update Guest set FName=@param,LName=@param1,Gender=@param2,Phone_No=@param3,Email=@param4,Guest_Address=@param5,Zipcode=@param6,Luggage=@param7,Room_No=@param8,Date_In=@param9,Date_Out=@param10 where GuestId=@param11;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", txtFName.Text.Trim());
                command.Parameters.AddWithValue("@param1", txtLName.Text.Trim());
                command.Parameters.AddWithValue("@param2", Gender);
                command.Parameters.AddWithValue("@param3", txtPhone.Text.Trim());
                command.Parameters.AddWithValue("@param4", txtMail.Text.Trim());
                command.Parameters.AddWithValue("@param5", txtAddress.Text.Trim());
                command.Parameters.AddWithValue("@param6", txtZip.Text.Trim());
                command.Parameters.AddWithValue("@param7", Lugage);
                command.Parameters.AddWithValue("@param8", room);
                command.Parameters.AddWithValue("@param9", dateIn.Value.ToShortDateString());
                command.Parameters.AddWithValue("@param10", dateOut.Value.ToShortDateString());
                command.Parameters.AddWithValue("@param11", guestId);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "Delete  from Guest where GuestId=@param";
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
        private void loadAvailableRooms()//load available Room 
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
                        comboRooms.Items.Add(read[0].ToString());
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
        private void loadServices() //Loads available services to the combo box
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

        private void ComboRooms_SelectedIndexChanged(object sender, EventArgs e)//Gets the cost of selected Room
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Cost from Room where Room_No=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", comboRooms.SelectedItem.ToString());
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        txtcost.Text= read[0].ToString();
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

        private void ComboService_SelectedIndexChanged(object sender, EventArgs e)//Gets cost of service selected
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToLower());
                }
            }
        }
        //Load Data to Gride
        private void loadData()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select * from Guest";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }
        private void searchQuery()
        {
            string query = null;
           
            using(SqlConnection connect =new SqlConnection(connectionString))
            {
                SqlCommand command = null; ;

                switch (lblsearchInstruct.Text)
                {
                    case "":
                        query = "select * from Guest";
                        break;
                    case "Enter Guest Name":
                        query = "Select * from Guest where concat(FName,' ',LName)=@Name;";
                        //command.Parameters.AddWithValue("@Name", txtSearchKey.Text.Trim());
                        break;
                    case "Enter Guest ID":
                        query = "Select * from Guest where GuestId=@ID;";
                       
                        break;
                    case "Choose Date below":
                        query = "Select * from Guest where Date_In=@date;";
                      
                        break;
                }
                
                command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@Name", txtSearchKey.Text.Trim());
                command.Parameters.AddWithValue("@date", searchCalendar.Value.ToShortDateString());
                command.Parameters.AddWithValue("@ID", txtSearchKey.Text.Trim());
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataTable tbl = new DataTable();
                adapt.Fill(tbl);
                dataGridView2.DataSource = tbl;
            }
        }
        int guestId = 0;
        string Gender= null;
        string Lugage= null;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
             Gender = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMail.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddress.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtZip.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          Lugage= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            comboRooms.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
           // comboService.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            dateIn.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            dateOut.Text= dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

            if (Gender.ToLower() == "male")
            {
                chkMale.Checked = true;
                chkFemale.Checked = false;
                chkFemale.Enabled = false;
            }
            else {
                chkFemale.Checked = true;
                chkMale.Checked = false;
                chkMale.Enabled = false;
            }
            if (Lugage.ToLower() == "yes")
            {
                chkYes.Checked = true;
                chkNo.Checked = false;
                chkNo.Enabled = false;
            }
            else {
                chkNo.Checked = true;
                chkYes.Checked = false;
                chkYes.Enabled = false;
            }

            label13.Visible = false;
            txtcost.Visible = false;
        }
    }
}
