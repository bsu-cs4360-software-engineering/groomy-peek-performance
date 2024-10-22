using groomy.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groomy
{
    public partial class AccountCreateForm : Form
    {
        public AccountCreateForm()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AdminUser user = new AdminUser();
            user.email = txtEmail.Text;
            user.fName = txtFirst.Text;
            user.lName = txtLast.Text;
            user.password = txtPass.Text;
            createAdminUser creating = new createAdminUser();
            await creating.AddAdminUserAsync(user);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
