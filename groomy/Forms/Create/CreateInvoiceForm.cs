using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using groomy.Invoices;
using groomy.services;
using groomy.Customers;
using groomy.Auth;
using Google.Cloud.Firestore;

namespace groomy.Forms.Create
{
    public partial class CreateInvoiceForm : Form
    {
        public async void loadCustomers()
        {
            cmbCustName.Items.Clear();
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
                cmbCustName.Items.Add(cust.email);
            }
        }
        public CreateInvoiceForm()
        {
            InitializeComponent();

            loadCustomers();
        }
        //Here's the create button function!  Add the fun stuff with the database to this. 
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            InvoiceCRUD invoiceCRUD = new InvoiceCRUD(db);
            customer cust = await customerGetter.getCustomerByEmail(cmbCustName.Text);
            List<LineItem> lineItems = new List<LineItem>();
            foreach(ListViewItem item in listView1.Items)
            {
                LineItem lineItem = new LineItem {
                    ServiceId = item.SubItems[3].Text,
                    ServiceName = item.SubItems[0].Text,
                    Cost = double.Parse(item.SubItems[1].Text),
                    Quantity = 1,
                };
                lineItems.Add(lineItem);
            }

            Invoice invToAdd = new Invoice
            {
                ClientId = cust.id,
                Total = (double)(nudTotal.Value),
                LineItems = lineItems,
                CreatedDate = DateTime.Now,
                DueDate = dateTimePicker1.Value,


            };

            MessageBox.Show("Invoice Created!", "Invoice Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {

        }

        private async void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirestoreDb _db = firebaseConfig.Instance.getFirestoreDB();
            customerCRUD custCrud = new customerCRUD(_db);
            customer cust = await custCrud.getCustomerByEmail(cmbCustName.Text);
            cstText.Text = cust.fName + " " + cust.lName;
            txtCustAddr.Text = cust.address;
        }

        private void CreateInvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
