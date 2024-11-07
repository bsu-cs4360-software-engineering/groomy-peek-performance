using Google.Cloud.Firestore;
using Google.Type;
using groomy.Appointments;
using groomy.Customers;
using groomy.services;
using System;
using System.Windows.Forms;

namespace groomy
{
    public partial class UpdateAppointmentForm : Form
    {
        private string appointmentId; // Class-level variable to hold the appointment ID

        public UpdateAppointmentForm(string title, string desc, string start, string end, string loc, string id, string email)
        {
            InitializeComponent(); // Ensure this is called first

            txtDescription.Text = desc;
            textBox1.Text = title;
            textBox2.Text = loc;
            dateTimePicker1.Value = System.DateTime.Parse(start);
            dateTimePicker2.Value = System.DateTime.Parse(end);
            comboBox1.Text = email;
            appointmentId = id; // Assign the ID to the class-level variable
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            appointmentCRUD updatePlease = new appointmentCRUD(db);

            // Assuming comboBox1.SelectedText contains the email you want to use
            customer theCustomerInQuestion = await customerGetter.getCustomerByEmail(comboBox1.Text);
            System.DateTime startDateTimeUtc = dateTimePicker1.Value.ToUniversalTime();
            System.DateTime endDateTimeUtc = dateTimePicker2.Value.ToUniversalTime();

            appointment newAppointment = new appointment
            {
                deleted = false,
                foreignKey = theCustomerInQuestion.id, // Use the instance's id
                id = appointmentId, // Use the class-level variable for the appointment ID
                location = textBox2.Text,
                start = Timestamp.FromDateTime(startDateTimeUtc), // Convert to Timestamp
                endTime = Timestamp.FromDateTime(endDateTimeUtc), // Convert to Timestamp
                Title = textBox1.Text,
                desc = txtDescription.Text,
            };

            await updatePlease.updateAppointment(newAppointment);
        }

        private void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}