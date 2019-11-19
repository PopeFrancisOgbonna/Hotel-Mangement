using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Home_Load(object sender, EventArgs e)
        {
            scrollPane.Height = btnDashBoard.Height;
            scrollPane.Top = btnDashBoard.Top;
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            scrollPane.Height = btnDashBoard.Height;
            scrollPane.Top = btnDashBoard.Top;
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            scrollPane.Top = btnServices.Top;
            scrollPane.Height = btnServices.Height;
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            scrollPane.Top = btnCheckOut.Top;
            scrollPane.Height = btnCheckOut.Height;
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            scrollPane.Top = btnCheckIn.Top;
            scrollPane.Height = btnCheckIn.Height;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contact the I.T Admin for any Issues or xpressdreams.ng@gmail.com +2347031620728", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is Designed by Xpress SoftwareLab. xpressdreams.ng@gmail.com +2347031620728", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolGuest_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.ShowDialog();
        }

        private void ToolRooms_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.ShowDialog();
        }

        private void ToolReserve_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation();
            reserve.ShowDialog();
        }

        private void ToolBill_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.ShowDialog();
        }
    }
}
