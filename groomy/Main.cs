using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using groomy.Auth;

namespace groomy
{
    public partial class Main : Form
    {
        /* This is the list of colors for the palette. 
         * White is already established within C# so it doesn't need to be declared here*/
        private Color PrimaryAccent = Color.FromArgb(15, 60, 82);
        private Color Highlight = Color.FromArgb(29,129,175);
        private Color offWhite = Color.FromArgb(254, 254, 254);
        private Color black = Color.FromArgb(16, 16, 16);
        public Main()
        {
            InitializeComponent();
            rdoCustomer.BackColor = PrimaryAccent;
        }
        




        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text != string.Empty)
            {
                txtUsername.Text = "UserName";
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form createUser = new AccountCreateForm();
            createUser.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            loginCheck checkLogin = new loginCheck(txtUsername.Text,txtPassword.Text);
            bool zbele = await checkLogin.checkUser();
            if (zbele)
            {
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
            }
            else
            {
                MessageBox.Show("Email and/or Password are not right");
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                // Optionally, set focus back to the username textbox for easier re-entry
                txtUsername.Focus();
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlWelcome.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
