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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        //Database connection properties
       string connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=true";

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            viewServicePane.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void BtnViewService_Click(object sender, EventArgs e)
        {
            loadSelectData();
            viewServicePane.Visible = true;
            //Hide irrelevant items
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            btnClear.Visible = true;
            btnSave.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please Fill Out all Field");
            }
            else {
                try
                {
                    string query = "insert into Service values(@param,@param1)";
                    using(SqlConnection connect =new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connect);
                        command.Parameters.AddWithValue("@param", txtName.Text.Trim());
                        command.Parameters.AddWithValue("@param1", txtCost.Text.Trim());
                        if (connect.State!=ConnectionState.Open)
                        {
                            connect.Open();
                        }
                       
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Record Saved Successfully");
                            loadData();
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCost.Clear();
            txtName.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            string query = "select * from Service";
           
            using(SqlConnection connect= new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connect);
                DataTable tbl = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                adapt.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }
        }
        private void loadSelectData()
        {
            string query = "select * from Service";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connect);
                DataTable tbl = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                adapt.Fill(tbl);
                dataGridView2.DataSource = tbl;
            }
        }
    }
}
