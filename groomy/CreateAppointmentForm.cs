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
            comboBox1.Items.Clear();
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);

            var customers = await customerGetter.getAllCustomers();
            List<customer> potato = customers;
            Console.WriteLine(potato.Count);
            if (potato == null || potato.Count == 0)
            {
                MessageBox.Show("No customers found.");
                return;
            }

            foreach (customer cust in potato)
            {
                comboBox1.Items.Add(cust.email);
            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
