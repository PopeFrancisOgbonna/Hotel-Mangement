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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            dataPane.Visible = true;
        }

        private void BtnManageRoom_Click(object sender, EventArgs e)
        {
            dataPane.Visible = true;
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
            btnUpdate.Visible = true;
            btnDlete.Visible = true;
        }
    }
}
