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
            scrollPane.Top = btnLogOut.Top;
            scrollPane.Height = btnLogOut.Height;
        }
    }
}
