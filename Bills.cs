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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
            loadGuest();
            loadService();
        }
        //Database connection property
        string connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=true;";
        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            txtIn.Clear();
            txtName.Clear();
            txtOut.Clear();
            txtRoom.Clear();
            txtServiceCharge.Clear();
            txtTotalBill.Clear();
            comboGuest.Text = "Select Guest Name";
            comboServices.Text = "Choose Services to Add";

            comboGuest.Visible = true;
            comboServices.Visible = true;
            btnAddService.Visible = true;
            lblservice.Visible = true;
            lblguest.Visible = true;
            billDetails.Visible = false;
            btnPay.Visible = false;
            pendingPane.Visible = false;
        }

        private void BtnPendingBill_Click(object sender, EventArgs e)
        {
            pendingPane.Visible = true;
            pendingPay();
            //Hide irrelevant items
            lblguest.Visible = false;
            lblservice.Visible = false;
            comboServices.Visible = false;
            comboGuest.Visible = false;
            btnAddService.Visible = false;
            billDetails.Visible = false;
            btnPay.Visible = false;
            comboGuest.Text = "Select Guest Name";
            comboServices.Text = "Choose Services to Add";

            txtIn.Clear();
            txtName.Clear();
            txtOut.Clear();
            txtRoom.Clear();
            txtServiceCharge.Clear();
            txtTotalBill.Clear();
        }

        private void BtnReceivePay_Click(object sender, EventArgs e)
        {
            comboGuest.Visible = true;
            comboServices.Visible = false;//Hide irrelevant items starts here
            btnAddService.Visible = false;
            lblservice.Visible = false;
            lblTotal.Visible = false;
            pendingPane.Visible = false;
            txtTotalBill.Visible = false;//Hide irrelevant items stops here
            lblguest.Visible = true;
            billDetails.Visible = true;
            btnPay.Visible = true;
            comboGuest.Text = "Select Guest Name";
            comboServices.Text = "Choose Services to Add";

            txtIn.Clear();
            txtName.Clear();
            txtOut.Clear();
            txtRoom.Clear();
            txtServiceCharge.Clear();
            txtTotalBill.Clear();
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Select Guest First");
            }
            else
            {
                billDetails.Visible = true;
                btnPay.Visible = true;
            }
            

            //Hide irrelevant Items
            lblTotal.Visible = false;
            txtTotalBill.Visible = false;
            pendingPane.Visible = false;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            txtTotalBill.Visible = true;
            pendingPane.Visible = false;
            if (txtName.Text == "")
            {
                MessageBox.Show("Select Guest First");
            }
            else {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = "select distinct b.Id, s.Cost + r.Cost as Bill from Bill b,Service s, Room r,Guest g where g.GuestId = b.GuestId and b.Room_No = r.Room_No and b.ServiceId = s.ServiceId and concat(g.FName,' ',g.LName)= @param";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@param", txtName.Text.Trim());
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }
                        SqlDataReader read = command.ExecuteReader();
                        while (read.Read())
                        {
                            int fee = int.Parse(read[1].ToString());
                            int fees = ((fee) + int.Parse(txtServiceCharge.Text));
                            txtTotalBill.Text = Convert.ToString(fees);
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
            
        }
        private void pendingPay()
        {
            using(SqlConnection connect= new SqlConnection(connectionString))
            {
                string query = "select distinct b.Id, concat(g.FName,' ',g.LName) as Name,  s.Cost +r.Cost as Bill from Bill b,Service s,Room r,Guest g where g.GuestId=b.GuestId and b.Room_No= r.Room_No and b.ServiceId=s.ServiceId and g.Date_Out > g.Date_In ;";
                SqlCommand command = new SqlCommand(query, connect);
                DataTable tbl = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }
        private void loadService()
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
                        comboServices.Items.Add(read[0].ToString());
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
        private void loadGuest()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select concat(FName,' ',LName) as Name from Guest;";
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
                        comboGuest.Items.Add(read[0].ToString());
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

        private void ComboGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Room_No,Date_In,Date_Out from Guest where concat(FName,' ',LName)=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", comboGuest.SelectedItem.ToString());
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        txtRoom.Text=(read[0].ToString());
                        txtIn.Text = read[1].ToString();
                        txtOut.Text = read[2].ToString();
                        txtName.Text = comboGuest.SelectedItem.ToString();
                        txtServiceCharge.Text = "750";
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

        private void ComboServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Cost from Service where Name=@param;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@param", comboServices.SelectedItem.ToString());
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        int fee = int.Parse(read[0].ToString())+750;
                        txtServiceCharge.Text = Convert.ToString(fee);
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
    }
}
