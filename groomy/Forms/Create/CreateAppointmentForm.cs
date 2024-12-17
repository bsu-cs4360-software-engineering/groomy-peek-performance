using Google.Cloud.Firestore;
using groomy.Appointments;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace groomy
{
    public partial class CreateAppointmentForm : Form
    {
        public CreateAppointmentForm()
        {
            InitializeComponent();
            loadCustomers();

        }
        public async void loadCustomers()
        {
            cmbCust.Items.Clear();
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);

            var customers = await customerGetter.getAllCustomers();
            List<customer> potato = customers;
            //Console.WriteLine(potato.Count);
            if (potato == null || potato.Count == 0)
            {
                MessageBox.Show("No customers found.");
                return;
            }

            foreach (customer cust in potato)
            {
                cmbCust.Items.Add(cust.email);
            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            appointmentCRUD appointmentCRUD = new appointmentCRUD(db);

            // Assuming comboBox1.SelectedText contains the email you want to use
            customer theCustomerInQuestion = await customerGetter.getCustomerByEmail(cmbCust.Text);

            // Ensure that the customer object is not null before accessing its properties
            if (theCustomerInQuestion != null)
            {
                // Convert DateTimePicker values to UTC
                DateTime startDateTimeUtc = dtpStart.Value.ToUniversalTime();
                DateTime endDateTimeUtc = dtpEnd.Value.ToUniversalTime();

                appointment newAppointment = new appointment
                {
                    deleted = false,
                    foreignKey = theCustomerInQuestion.id, // Use the instance's id
                    id = "", // Assign a unique ID for the appointment
                    location = txtLoc.Text,
                    start = Timestamp.FromDateTime(startDateTimeUtc), // Convert to Timestamp
                    endTime = Timestamp.FromDateTime(endDateTimeUtc), // Convert to Timestamp
                    Title = txtTitle.Text,
                    desc = txtDescription.Text,
                };

                await appointmentCRUD.addAppointmentAsync(newAppointment, theCustomerInQuestion.id);
                MessageBox.Show("New Appointment made!", "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Handle the case where no customer was found
                MessageBox.Show("Customer not found.");
            }
        
    }

        private void CreateAppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
