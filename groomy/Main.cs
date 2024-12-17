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
using groomy.Appointments;
using groomy.Auth;
using groomy.Customers;
using groomy.Forms.Update;
using groomy.services;
using groomy.Pricing;
using groomy.Forms.Create;
using groomy.Forms.View;
using groomy.Invoices;

namespace groomy
{
    public partial class Main : Form
    {
        /* This is the list of colors for the palette. 
         * White is already established within C# so it doesn't need to be declared here*/
        private Color PrimaryAccent = Color.FromArgb(15, 60, 82);
        private Color Highlight = Color.FromArgb(29, 129, 175);
        private Color offWhite = Color.FromArgb(254, 254, 254);
        private Color black = Color.FromArgb(16, 16, 16);

        //private customerCRUD custCrud = new customerCRUD();
        
        
        
        public Main()
        {
            InitializeComponent();
            rdoCustomer.BackColor = PrimaryAccent;
            this.ActiveControl = txtUsername;
        }





        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty)
            {
                txtUsername.Text = "UserName";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form createUser = new AccountCreateForm();
            createUser.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            loginCheck checkLogin = new loginCheck(txtUsername.Text, txtPassword.Text);
            bool verifyUser = await checkLogin.checkUser();
            bool verifyEmail = checkLogin.IsValidEmail(txtUsername.Text);
            if (verifyUser && verifyEmail)
            {
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
                rdoCustomer.Visible = true;
                rdoAppointments.Visible = true;
                rdoServices.Visible = true;
                rdoInvoices.Visible = true;
            }
            else
            {
                MessageBox.Show("Email and/or Password are not valid!");
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                // Optionally, set focus back to the username textbox for easier re-entry
                txtUsername.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlWelcome.Visible = false;
            rdoCustomer.Visible=false;
            rdoAppointments.Visible=false;
            pnlAppointments.Visible = false;
        }




        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private async Task loadServices()
        {
            lstServices.Items.Clear();
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
        public async void loadInvoices()
        {
            lstInvoices.Items.Clear();
            lstInvoices.View = View.Details;
            lstInvoices.FullRowSelect = true;
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerCRUD = new customerCRUD(db);
            InvoiceCRUD invoiceGetter = new InvoiceCRUD(db);

            var invoices = await invoiceGetter.GetAllInvoices();

            if (invoices == null || invoices.Count == 0)
            {
                MessageBox.Show("No invoices found.");
                return;
            }

            foreach (Invoice inv in invoices)
            {
                if (!inv.Deleted)
                {
                    customer customerInfo = await customerCRUD.getCustomerById(inv.ClientId);
                    ListViewItem item = new ListViewItem(inv.Id);
                    item.SubItems.Add(inv.CreatedDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.DueDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.Total.ToString("C"));
                    item.SubItems.Add(inv.IsPaid ? "Paid" : "Unpaid");
                    lstInvoices.Items.Add(item);
                }
            }
        }


        private void pnlInvoices_VisibleChanged(object sender, EventArgs e)
        {
            loadInvoices();
        }
        //This is where the radio buttons logic is handled.  It runs based on the text in the button. 
        public async void loadCustomers()
        {
            lstCustomers.Items.Clear();
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);

            var customers = await customerGetter.getAllCustomers();
            List<customer> potato = customers;
            if (potato == null || potato.Count == 0)
            {
                MessageBox.Show("No customers found.");
                return;
            }

            foreach (customer cust in potato)
            {
                if (cust.deleted != true)
                {
                    ListViewItem item = new ListViewItem(cust.fName);
                    item.SubItems.Add(cust.lName);
                    item.SubItems.Add(cust.phoneNumber);
                    item.SubItems.Add(cust.email);
                    item.SubItems.Add(cust.address);
                    item.SubItems.Add(cust.id);
                    lstCustomers.Items.Add(item);
                }
            }


        }
        public async void loadAppointments()

        {

            lstAppointments.Items.Clear();

            firebaseConfig config = firebaseConfig.Instance;

            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerCRUD = new customerCRUD(db);
            appointmentCRUD appointmentGetter = new appointmentCRUD(db); // Assuming you have an appointmentCRUD class


            var appointments = await appointmentGetter.getAllAppointments(); // Fetch all appointments

            List<appointment> appointmentList = appointments; // Assuming this returns a List<appointment>

            //Console.WriteLine(appointmentList.Count);


            if (appointmentList == null || appointmentList.Count == 0)

            {

                MessageBox.Show("No appointments found.");

                return;

            }


            foreach (appointment app in appointmentList)

            {

                if (!app.deleted) // Check if the appointment is not deleted

                {
                    customer customerstuff = await customerCRUD.getCustomerById(app.foreignKey);
                    ListViewItem item = new ListViewItem(app.Title); // Assuming Title is the main information to display
                    item.SubItems.Add(app.desc);
                    item.SubItems.Add(app.start.ToDateTime().ToLocalTime().ToString("g")); // Displaying start time
                    item.SubItems.Add(app.endTime.ToDateTime().ToLocalTime().ToString("g")); // Displaying end time
                    item.SubItems.Add(app.location); // Displaying location
                    item.SubItems.Add(customerstuff.fName.ToString() + " " +customerstuff.lName.ToString());
                    item.SubItems.Add(app.id.ToString());
                    item.SubItems.Add(customerstuff.email);
                    lstAppointments.Items.Add(item);

                }

            }

        }
        private async void rdoHome_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = this.pnlAccent.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Text)
                {
                    case "Home":
                        // This is the home button.  It should automatically be selected. 
                        pnlLogin.BringToFront();
                        pnlCustomer.Visible = false;
                        pnlAppointments.Visible = false;
                        break;

                    case "Customer":
                        // This is the customer button.  When this is clicked, it should run the getAllCustomers function. Jordan doesn't know how to set that up. 
                        lstCustomers.Items.Clear();
                        lstCustomers.View = View.Details;
                        lstCustomers.FullRowSelect = true;
                        pnlCustomer.BringToFront();
                        pnlLogin.Visible = !rdoCustomer.Checked;
                        pnlAppointments.Visible = pnlLogin.Visible;
                        pnlCustomer.Visible = rdoCustomer.Checked;
                        break;

                    case "Appointments":
                        //This is the appointments button.
                        lstAppointments.FullRowSelect = true;
                        lstAppointments.View = View.Details;
                        lstAppointments.Items.Clear();
                        pnlAppointments.BringToFront();
                        pnlLogin.Visible = !rdoAppointments.Checked;
                        pnlCustomer.Visible = !rdoAppointments.Checked;
                        pnlAppointments.Visible = rdoAppointments.Checked;
                        
                        
                        break;

                    case "Services":
                        //This is the services button.
                        lstServices.View = View.Details;
                        lstServices.FullRowSelect = true;
                        pnlAppointments.Visible = !rdoServices.Checked;
                        pnlServices.Visible = rdoServices.Checked;
                        pnlCustomer.Visible = !rdoServices.Checked;
                        pnlServices.BringToFront();
                        break;

                    case "Invoices":
                        pnlInvoices.Visible = rdoInvoices.Checked;
                        pnlInvoices.BringToFront();
                        pnlAppointments.Visible= rdoAppointments.Checked;
                        pnlServices.Visible= rdoServices.Checked;
                        lstInvoices.View = View.Details;
                        lstInvoices.FullRowSelect = true;
                        loadInvoices();
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CreateCustomerForm custFrm = new CreateCustomerForm();
            
            custFrm.ShowDialog();
        }

        private void btnAppAdd_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm appFrm = new CreateAppointmentForm();
            appFrm.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("I hate winforms");
        }

        private async void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            string email = lstCustomers.SelectedItems[0].SubItems[3].Text;
            //Console.WriteLine(email);
            customer cust = await customerGetter.getCustomerByEmail(email);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Are you sure?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                await customerGetter.deleteCustomerByEmail(email);
                loadCustomers();
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count > 0)
            {
                updateUsers cutForm = new updateUsers(lstCustomers.SelectedItems[0].SubItems[3].Text,
                    lstCustomers.SelectedItems[0].SubItems[0].Text,
                    lstCustomers.SelectedItems[0].SubItems[1].Text,
                    lstCustomers.SelectedItems[0].SubItems[5].Text,
                    lstCustomers.SelectedItems[0].SubItems[2].Text,
                    lstCustomers.SelectedItems[0].SubItems[4].Text);
                cutForm.ShowDialog();
            }
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCustView_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItems.Count > 0)
            {
                ViewCustomerForm cutForm = new ViewCustomerForm(lstCustomers.SelectedItems[0].SubItems[3].Text,
                    lstCustomers.SelectedItems[0].SubItems[0].Text,
                    lstCustomers.SelectedItems[0].SubItems[1].Text,
                    lstCustomers.SelectedItems[0].SubItems[5].Text,
                    lstCustomers.SelectedItems[0].SubItems[2].Text,
                    lstCustomers.SelectedItems[0].SubItems[4].Text);
                cutForm.ShowDialog();
            }

        }

        private void btnAppRefresh_Click(object sender, EventArgs e)
        {
            
            loadAppointments();
        }

        private async void btnAppDelete_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            appointmentCRUD potato = new appointmentCRUD(db);
            DialogResult deleteResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Are you sure?", MessageBoxButtons.YesNo);
            if (lstAppointments.SelectedItems.Count > 0 && deleteResult == DialogResult.Yes)
            {
                await potato.deleteAppointmentById(lstAppointments.SelectedItems[0].SubItems[6].Text);
                loadAppointments();
            }
        }

        private void btnAppUpdate_Click(object sender, EventArgs e)
        {
            if (lstAppointments.SelectedItems.Count > 0)
            {

                UpdateAppointmentForm upApp = new UpdateAppointmentForm(
                lstAppointments.SelectedItems[0].SubItems[0].Text,
                lstAppointments.SelectedItems[0].SubItems[1].Text,
                lstAppointments.SelectedItems[0].SubItems[2].Text,
                lstAppointments.SelectedItems[0].SubItems[3].Text,
                lstAppointments.SelectedItems[0].SubItems[4].Text,
                lstAppointments.SelectedItems[0].SubItems[6].Text,
                lstAppointments.SelectedItems[0].SubItems[7].Text);
                upApp.ShowDialog();
            }
        }

        private void btnAppView_Click(object sender, EventArgs e)
        {
            ViewAppointmentsForm upApp = new ViewAppointmentsForm(
            lstAppointments.SelectedItems[0].SubItems[0].Text,
            lstAppointments.SelectedItems[0].SubItems[1].Text,
            lstAppointments.SelectedItems[0].SubItems[2].Text,
            lstAppointments.SelectedItems[0].SubItems[3].Text,
            lstAppointments.SelectedItems[0].SubItems[4].Text,
            lstAppointments.SelectedItems[0].SubItems[6].Text,
            lstAppointments.SelectedItems[0].SubItems[7].Text);
            upApp.ShowDialog();
        }

        private void pnlCustomer_VisibleChanged(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void pnlAppointments_VisibleChanged(object sender, EventArgs e)
        {
            loadAppointments();
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            CreateServiceForm crtService = new CreateServiceForm();
            crtService.ShowDialog();

        }

        private async void btnServiceDelete_Click(object sender, EventArgs e)
        {
            FirestoreDb potato = firebaseConfig.Instance.getFirestoreDB();
            ServicesCRUD delServices = new ServicesCRUD(potato, "Services");
            DialogResult deleteResult = MessageBox.Show("Are you sure you want to delete this service?", "Are you sure?", MessageBoxButtons.YesNo);
            if (lstServices.SelectedItems[0].SubItems[3].Text != null &&
            deleteResult == DialogResult.Yes)
            { 
                await delServices.SoftDeleteService(lstServices.SelectedItems[0].SubItems[3].Text);
            
            }
            lstServices.Items.Clear();
            await loadServices();
            
        }

        private async void btnServiceRefresh_Click(object sender, EventArgs e)
        {
            await loadServices();
        }

        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems.Count > 0)
            {
                Service potato = new Service {
                    Name = lstServices.SelectedItems[0].SubItems[0].Text,
                    Desc = lstServices.SelectedItems[0].SubItems[1].Text,
                    Price = double.Parse(
                        lstServices.SelectedItems[0].SubItems[2].Text.Replace("$", ""),
                        System.Globalization.NumberStyles.Number
                    ),
                    Id = lstServices.SelectedItems[0].SubItems[3].Text,
                    Deleted = false
                };
                UpdateServiceForm updateServiceFrm = new UpdateServiceForm(potato);
                updateServiceFrm.ShowDialog();
            }
        }

        private void btnServiceView_Click(object sender, EventArgs e)
        {
            Service potato = new Service
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
            ViewServiceForm viewServiceFrm = new ViewServiceForm(potato);
            viewServiceFrm.ShowDialog();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void pnlServices_VisibleChanged(object sender, EventArgs e)
        {
            await loadServices();
        }

        private void btnInvAdd_Click(object sender, EventArgs e)
        {
            CreateInvoiceForm createInvoiceForm = new CreateInvoiceForm();
            createInvoiceForm.ShowDialog();
        }

        private async void btnInvDelete_Click(object sender, EventArgs e)
        {
            if (lstInvoices.SelectedItems.Count > 0)
            {
                firebaseConfig config = firebaseConfig.Instance;
                FirestoreDb db = config.getFirestoreDB();
                InvoiceCRUD invoiceCRUD = new InvoiceCRUD(db);

                DialogResult deleteResult = MessageBox.Show("Are you sure you want to delete this invoice?", "Are you sure?", MessageBoxButtons.YesNo);

                if (deleteResult == DialogResult.Yes)
                {
                    string invoiceId = lstInvoices.SelectedItems[0].SubItems[0].Text;
                    await invoiceCRUD.SoftDeleteInvoice(invoiceId);
                    loadInvoices();
                }
            }
        }

        private void btnInvRefresh_Click(object sender, EventArgs e)
        {
            loadInvoices();
        }

        private async void btnInvUpdate_Click(object sender, EventArgs e)
        {
            if (lstInvoices.SelectedItems.Count > 0)
            {
                try
                {
                    firebaseConfig config = firebaseConfig.Instance;
                    FirestoreDb db = config.getFirestoreDB();
                    InvoiceCRUD invoiceCRUD = new InvoiceCRUD(db);

                    // Get the selected invoice ID from the list view
                    string invoiceId = lstInvoices.SelectedItems[0].SubItems[0].Text;

                    // Fetch the complete invoice data
                    Invoice invoice = await invoiceCRUD.GetInvoice(invoiceId);

                    if (invoice != null)
                    {
                        UpdateInvoiceForm updateInvoiceForm = new UpdateInvoiceForm(invoice);
                        updateInvoiceForm.ShowDialog();

                        // Refresh the invoice list after the form is closed
                        loadInvoices();
                    }
                    else
                    {
                        MessageBox.Show("Unable to find the selected invoice.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading invoice: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInvView_Click(object sender, EventArgs e)
        {
            if (lstInvoices.SelectedItems.Count > 0)
            {
                // Implement view logic similar to other view methods
                // You might want to create a ViewInvoiceForm
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void rdoInvoices_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void invPaid_Click(object sender, EventArgs e)
        {
            lstInvoices.Items.Clear();
            lstInvoices.Items.Clear();
            lstInvoices.View = View.Details;
            lstInvoices.FullRowSelect = true;
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerCRUD = new customerCRUD(db);
            InvoiceCRUD invoiceGetter = new InvoiceCRUD(db);

            var invoices = await invoiceGetter.GetPaidInvoices();

            if (invoices == null || invoices.Count == 0)
            {
                MessageBox.Show("No invoices found.");
                return;
            }

            foreach (Invoice inv in invoices)
            {
                if (!inv.Deleted)
                {
                    customer customerInfo = await customerCRUD.getCustomerById(inv.ClientId);
                    ListViewItem item = new ListViewItem(inv.Id);
                    item.SubItems.Add(inv.CreatedDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.DueDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.Total.ToString("C"));
                    item.SubItems.Add(inv.IsPaid ? "Paid" : "Unpaid");
                    lstInvoices.Items.Add(item);
                }
            }
        
        }

        private async void unPaid_Click(object sender, EventArgs e)
        {
            lstInvoices.Items.Clear();
            lstInvoices.Items.Clear();
            lstInvoices.View = View.Details;
            lstInvoices.FullRowSelect = true;
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerCRUD = new customerCRUD(db);
            InvoiceCRUD invoiceGetter = new InvoiceCRUD(db);

            var invoices = await invoiceGetter.GetUnPaidInvoices();

            if (invoices == null || invoices.Count == 0)
            {
                MessageBox.Show("No invoices found.");
                return;
            }

            foreach (Invoice inv in invoices)
            {
                if (!inv.Deleted)
                {
                    customer customerInfo = await customerCRUD.getCustomerById(inv.ClientId);
                    ListViewItem item = new ListViewItem(inv.Id);
                    item.SubItems.Add(inv.CreatedDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.DueDate.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(inv.Total.ToString("C"));
                    item.SubItems.Add(inv.IsPaid ? "Paid" : "Unpaid");
                    lstInvoices.Items.Add(item);
                }
            }

        }
    }
}
