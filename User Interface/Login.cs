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


namespace MIS677Project
{
    public partial class Login : Form
    {
    int attempts = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            



            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                new HomeScreen().Show();
                this.Hide();
            }

            if (txtUsername.Text == "juan" && txtPassword.Text == "bocanegra")
            {
                new NeighborPage().Show();
                this.Hide();
            }

            if (txtUsername.Text == "brett" && txtPassword.Text == "schmidt")
            {
                new NeighborPage().Show();
                this.Hide();
            }

            if (txtUsername.Text == "connor" && txtPassword.Text == "herrman")
            {
                new NeighborPage().Show();
                this.Hide();
            }

            if (txtUsername.Text == "staff" && txtPassword.Text == "staff")
            {
                new HomeScreen().Show();
                this.Hide();
            }

            if (txtUsername.Text == "program" && txtPassword.Text == "manager")
            {
                new HomeScreen().Show();
                this.Hide();
            }

            if (txtUsername.Text == "case" && txtPassword.Text == "manager")
            {
                new HomeScreen().Show();
                this.Hide();
            }

            /*else
            {
                 MessageBox.Show("The username or password you entered is incorrect, please try again!");
                 txtPassword.Clear();
                 attempts++;              
            }*/

            if (attempts >= 3)
            {
                timer.Interval = 30000; // here time in milliseconds 7,200,000 ms in 2 hours
                timer.Tick += timer_Tick;
                timer.Start();
                txtUsername.Enabled = false;
                btnSubmit.Enabled = false;
                txtPassword.Enabled = false;
                MessageBox.Show("You have failed all three of your login attempts and your account has been locked. Please contact customer support for further actions.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            btnSubmit.Enabled = true;
            timer.Stop();
        }
    }
}
