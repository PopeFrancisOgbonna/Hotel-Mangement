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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public static string user;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtPost.Text == "" || txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Please Fill out all Fields.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //connects to home page
                Home home = new Home();
                home.lblUser.Text = user;
                home.ShowDialog();

                //clear the user input
                txtUser.Clear();
                txtPass.Clear();
                txtPost.Clear();
            }
           
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            user = txtUser.Text;
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
