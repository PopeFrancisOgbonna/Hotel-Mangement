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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

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

            //Hide non relevance buttons
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            searchCalendar.Visible = false;
            btnGO.Visible = false;
        }

        private void BtnManageGuest_Click(object sender, EventArgs e)
        {
            addGuestPane.Visible = true;
            lblTitle.Text = "Manage Guests";
            searchGuestPane.Visible = false;

            //Hide non relevance button
            searchOptionPane.Visible = false;
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false;
            searchCalendar.Visible = false;
            btnGO.Visible = false;
        }

        private void BtnGO_Click(object sender, EventArgs e)
        {
            searchGuestPane.Visible = true;
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
            lblsearchInstruct.Visible = true ;
            txtSearchKey.Visible = false; 
            btnGO.Visible = true;
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            searchGuestPane.Visible = true;

            //Hide irrelevant buttons
            searchCalendar.Visible = false ;
            lblsearchInstruct.Text = "";
            lblsearchInstruct.Visible = false;
            txtSearchKey.Visible = false ;
            btnGO.Visible = false;
        }
    }
}
