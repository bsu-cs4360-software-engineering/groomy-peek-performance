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
using Google.Cloud.Firestore.V1;
using groomy.Customers;
using groomy.services;
using groomy;
namespace groomy
{
    public partial class CreateCustomerForm : Form
    {
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
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
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD createThisUserPlease = new customerCRUD(db);
            await createThisUserPlease.addCustomerAsync(newCustomer);
            
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
