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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Database connection property
        string connectionString = @"Data Source=.;Initial Catalog=HotelManagementSystem;Integrated Security=True;";
        private void Home_Load(object sender, EventArgs e)
        {
            scrollPane.Height = btnDashBoard.Height;
            scrollPane.Top = btnDashBoard.Top;
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            scrollPane.Height = btnDashBoard.Height;
            scrollPane.Top = btnDashBoard.Top;
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
            scrollPane.Top = btnServices.Top;
            scrollPane.Height = btnServices.Height;
            Services service = new Services();
            service.ShowDialog();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            scrollPane.Top = btnCheckOut.Top;
            scrollPane.Height = btnCheckOut.Height;
            statusPane.Visible = false;

            int a = toDayOut();
            lblInAndOut.Text = Convert.ToString(a) + " Guests Are Checking out Today";
            inAndOutPane.Visible = true;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            scrollPane.Top = btnCheckIn.Top;
            scrollPane.Height = btnCheckIn.Height;
            statusPane.Visible = false;

            int a = toDayIn();
            lblInAndOut.Text = Convert.ToString(a) + " Guests Are Checked In Today";
            inAndOutPane.Visible = true;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            var ans = MessageBox.Show("Do you want to Exit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            inAndOutPane.Visible = false;
            statusPane.Visible = false;
            MessageBox.Show("Contact the I.T Admin for any Issues or xpressdreams.ng@gmail.com +2347031620728", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            inAndOutPane.Visible = false;
            statusPane.Visible = false;
            MessageBox.Show("This Application is Designed by Xpress SoftwareLab. xpressdreams.ng@gmail.com +2347031620728", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolGuest_Click(object sender, EventArgs e)
        {
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
            Guest guest = new Guest();
            guest.ShowDialog();
        }

        private void ToolRooms_Click(object sender, EventArgs e)
        {
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
            Rooms room = new Rooms();
            room.ShowDialog();
        }

        private void ToolReserve_Click(object sender, EventArgs e)
        {
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
            Reservation reserve = new Reservation();
            reserve.ShowDialog();
        }

        private void ToolBill_Click(object sender, EventArgs e)
        {
            statusPane.Visible = false;
            inAndOutPane.Visible = false;
            Bills bill = new Bills();
            bill.ShowDialog();
        }
        private int loadAccomodation()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select count(*) from Room";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            return i;
        }
        private  int GuestNo()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Count(*) from Guest where Date_Out > GetDate(); ";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
            return i;
        }
        private int Reserve()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select count(*) from Reservation";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
            return i;
        }
        private int availableRoom()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select count(*) from Room where lower(Status)='available'";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
            return i;
        }
        private int toDayIn()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Count(*) from Guest where Date_In =GetDate();";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
            return i;
        }
        private int toDayOut()
        {
            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string query = "select Count(*) from Guest where Date_Out =GetDate();";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader read;
                try
                {
                    connect.Open();
                    read = command.ExecuteReader();
                    while (read.Read())
                    {
                        i = int.Parse(read[0].ToString());
                    }
                    connect.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            }
            return i;
        }

        private void ToolStatus_Click(object sender, EventArgs e)
        {
            int i = loadAccomodation();
            lblAccomodation.Text = "Total Number of Accomodation = " + Convert.ToString(i);
            int b = availableRoom();
            lblAvailable.Text = "Total Number of Available Rooms = " + Convert.ToString(b);
            int c = GuestNo();
            lblguest.Text = "Total Number of Guests = " + Convert.ToString(c);
            int d = Reserve();
            lblReserve.Text = "Total Number of Reserved Rooms = " + Convert.ToString(d);

            statusPane.Visible = true;
            inAndOutPane.Visible = false;
        }

    }
}
