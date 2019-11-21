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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
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
            //Hide irrelevant items
            lblguest.Visible = false;
            lblservice.Visible = false;
            comboServices.Visible = false;
            comboGuest.Visible = false;
            btnAddService.Visible = false;
            billDetails.Visible = false;
            btnPay.Visible = false;
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
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            billDetails.Visible = true;
            btnPay.Visible = true;

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
        }
    }
}
