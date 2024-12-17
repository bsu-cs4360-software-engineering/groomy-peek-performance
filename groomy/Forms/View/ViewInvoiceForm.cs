using Google.Cloud.Firestore;
using groomy.Customers;
using groomy.Notes;
using groomy.Pricing;
using groomy.Invoices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using groomy.services;
using System.Threading.Tasks;

namespace groomy.Forms.View
{
    public partial class ViewInvoiceForm : Form
    {
        private string invoiceId;
        private List<Service> availableServices = new List<Service>();
        private List<LineItem> lineItems = new List<LineItem>();

        public ViewInvoiceForm(Invoice invoice)
        {
            InitializeComponent();

            // Store invoice ID and populate form fields
            invoiceId = invoice.Id;
            txtInvNumber.Text = invoice.Id;
            tdpInvDate.Value = invoice.CreatedDate.ToDateTime();
            dateTimePicker1.Value = invoice.DueDate.ToDateTime();
            chkPaid.Checked = invoice.IsPaid;
            nudTotal.Value = (decimal)invoice.Total;
            lineItems = invoice.LineItems ?? new List<LineItem>();

            // Load customer data
            LoadCustomerAsync(invoice.ClientId);

            // Load line items
            LoadLineItems();

            // Make controls read-only
            SetControlsReadOnly();
        }

        private void SetControlsReadOnly()
        {
            // Disable controls that shouldn't be editable in view mode
            dateTimePicker1.Enabled = false;
            chkPaid.Enabled = false;
            txtNote.ReadOnly = true;
            txtNoteTitle.ReadOnly = true;
        }

        private async void LoadCustomerAsync(string clientId)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                customerCRUD customerCRUD = new customerCRUD(db);
                customer customer = await customerCRUD.getCustomerById(clientId);

                if (customer != null)
                {
                    cmbCustName.Text = customer.email;
                    txtCustAddr.Text = customer.address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLineItems()
        {
            listView1.Items.Clear();
            listView1.View = System.Windows.Forms.View.Details;

            foreach (var item in lineItems)
            {
                ListViewItem lvItem = new ListViewItem(item.ServiceName);
                lvItem.SubItems.Add(DateTime.Now.ToString("d")); // Using current date as service date
                lvItem.SubItems.Add($"${item.Cost:F2}");
                lvItem.SubItems.Add(item.Quantity.ToString());
                listView1.Items.Add(lvItem);
            }
        }

        private async Task LoadNotesAsync()
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                lstNotes.View = System.Windows.Forms.View.Details;
                lstNotes.FullRowSelect = true;

                var notes = await notesCreate.getAllNotes(invoiceId);

                lstNotes.Items.Clear();
                foreach (note thisNote in notes)
                {
                    if (!thisNote.deleted)
                    {
                        ListViewItem item = new ListViewItem(thisNote.title);
                        item.SubItems.Add(thisNote.dateCreated.ToDateTime().ToLocalTime().ToString("g"));
                        item.SubItems.Add(thisNote.desc);
                        item.SubItems.Add(thisNote.id);
                        lstNotes.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstNotes.SelectedItems[0];
                txtNoteTitle.Text = selectedItem.Text;
                txtNote.Text = selectedItem.SubItems[2].Text;
            }
        }

        private async void ViewInvoiceForm_Load(object sender, EventArgs e)
        {
            await LoadNotesAsync();
        }

        private void lstNotes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstNotes.SelectedItems[0];
                txtNoteTitle.Text = selectedItem.Text;
                txtNote.Text = selectedItem.SubItems[2].Text;
            }
        }
    }
}