using Google.Cloud.Firestore.V1;
using groomy.Auth;
using groomy.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using groomy.auth;

namespace groomy
{
    public partial class AccountCreateForm : Form
    {
        private readonly firebaseConfig config = firebaseConfig.Instance;
        private readonly FirestoreDb db;

        public AccountCreateForm()
        {
            InitializeComponent();
            db = config.getFirestoreDB();

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            adminUser user = new adminUser();
            user.email = txtEmail.Text;
            user.fName = txtFirst.Text;
            user.lName = txtLast.Text;
            user.password = txtPass.Text;
            createAdminUser creating = new createAdminUser(db);
            await creating.addadminUserAsync(user);
        }

        private void AccountCreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
