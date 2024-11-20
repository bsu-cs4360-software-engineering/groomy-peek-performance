using Google.Cloud.Firestore;
using groomy.Customers;
using groomy.services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groomy
{
    public partial class updateUsers : Form
    {
        private string customerId; // Store the customer ID

        public updateUsers(string email, string fName, string lName, string id, string phoneNumber, string address)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhoneNumber.Text = phoneNumber;
            txtAddr1.Text = address;
            customerId = id; // Initialize customerId with the passed ID
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                firebaseConfig config = firebaseConfig.Instance;
                FirestoreDb db = config.getFirestoreDB();
                customerCRUD customerGetter = new customerCRUD(db);

                // Create a new customer object with updated details
                customer updatedCustomer = new customer
                {
                    email = txtEmail.Text,
                    fName = txtFName.Text,
                    lName = txtLName.Text,
                    id = customerId, // Use the stored customer ID
                    deleted = false,
                    phoneNumber = txtPhoneNumber.Text,
                    address = txtAddr1.Text + " " + txtAddr2.Text + " " + txtAddr3.Text, // Concatenate address fields
                };

                // Call the update method
                await customerGetter.updateCustomer(updatedCustomer);

                MessageBox.Show("Customer updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }
    }
}