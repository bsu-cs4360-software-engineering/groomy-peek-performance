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
using groomy.Pricing;

namespace groomy.Forms.Create
{
    public partial class CreateInvoiceForm : Form
    {
        private void updateNud()
        {
            double total = 0;

            foreach (ListViewItem items in listView1.Items)

            {

                string value = items.SubItems[2].Text.ToString().Trim('$');



                // Check if the value is not empty and try to parse it

                if (!string.IsNullOrEmpty(value) && double.TryParse(value, out double parsedValue))

                {

                    total += parsedValue;

                }

                else

                {

                    // Handle the case where parsing fails (optional)

                    // You could log an error, show a message, etc.

                    Console.WriteLine($"Invalid value: {value}");

                }

            }


            // Convert total to decimal and set the nudTotal value

            nudTotal.Value = (decimal)total;
        }
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
        private async Task loadServices()
        {
            lstServices.Items.Clear();
            lstServices.View = System.Windows.Forms.View.Details;
            lstServices.FullRowSelect = true;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            ServicesCRUD serviceGetter = new ServicesCRUD(db, "Services");

            var services = await serviceGetter.GetAllServices();

            if (services == null || services.Count == 0)
            {
                MessageBox.Show("No services found.");
                return;
            }

            foreach (Service service in services)
            {
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(service.Desc);
                item.SubItems.Add(service.Price.ToString("C"));
                item.SubItems.Add(service.Id);
                lstServices.Items.Add(item);
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
                if (item != null)
                {
                    LineItem lineItem = new LineItem
                    {
                        ServiceId = item.SubItems[3].Text.ToString(),
                        ServiceName = item.SubItems[0].Text.ToString(),
                        Cost = double.Parse(item.SubItems[2].Text.Trim('$')),
                        Quantity = 1,
                    };
                    lineItems.Add(lineItem);
                }
            }

            Invoice invToAdd = new Invoice
            {
                ClientId = cust.id,
                Total = (double)(nudTotal.Value),
                LineItems = lineItems,
                CreatedDate = Timestamp.FromDateTime(DateTime.UtcNow),
                DueDate = Timestamp.FromDateTime(dateTimePicker1.Value.ToUniversalTime()),


            };
            await invoiceCRUD.CreateInvoice(invToAdd);

            MessageBox.Show("Invoice Created!", "Invoice Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems[0] != null){
                Service service = new Service
                {
                    Name = lstServices.SelectedItems[0].SubItems[0].Text,
                    Desc = lstServices.SelectedItems[0].SubItems[1].Text,
                    Price = double.Parse(
                            lstServices.SelectedItems[0].SubItems[2].Text.Replace("$", ""),
                            System.Globalization.NumberStyles.Number
                        ),
                    Id = lstServices.SelectedItems[0].SubItems[3].Text,
                    Deleted = false
                };
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(service.Desc);
                item.SubItems.Add(service.Price.ToString("C"));
                item.SubItems.Add(service.Id);
                listView1.Items.Add(item);
            }
            updateNud();
        }

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count> 0 )
            {
                listView1.SelectedItems[0].Remove();
            }
            updateNud();
        }

        private async void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirestoreDb _db = firebaseConfig.Instance.getFirestoreDB();
            customerCRUD custCrud = new customerCRUD(_db);
            customer cust = await custCrud.getCustomerByEmail(cmbCustName.Text);
            cstText.Text = cust.fName + " " + cust.lName;
            txtCustAddr.Text = cust.address;
        }

        private async void CreateInvoiceForm_Load(object sender, EventArgs e)
        {
            await loadServices();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cstText_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
