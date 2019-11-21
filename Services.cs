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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            viewServicePane.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void BtnViewService_Click(object sender, EventArgs e)
        {
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
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
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
    }
}
