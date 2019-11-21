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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void BtnAddReserve_Click(object sender, EventArgs e)
        {
            ReservePane.Visible = true;
            lblTitle.Text = "Booking and Reservation";
        }

        private void ComboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void TxtFName_TextChanged(object sender, EventArgs e)
        {
            btnClear.Visible = true;
        }

        private void BtnManageReserve_Click(object sender, EventArgs e)
        {
            ReservePane.Visible = true;
            lblTitle.Text = "Manage Reservation";
        }
    }
}
