using Google.Cloud.Firestore;
using groomy.Customers;
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

namespace groomy
{
    public partial class updateUsers : Form
    {
        public updateUsers(string email , string fName, string lName, string id, string phoneNumber, string address)
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            customer newCustomer = new customer
            {
                email = txtEmail.Text,
                fName = txtFName.Text,
                lName = txtLName.Text,
                id = "1",
                deleted = false,
                phoneNumber = txtPhoneNumber.Text,
                address = txtAddr1.Text + txtAddr2.Text + txtAddr3.Text,
            };
            customerGetter.updateCustomer(newCustomer);
        }
    }
}
