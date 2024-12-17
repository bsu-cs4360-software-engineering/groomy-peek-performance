using Google.Cloud.Firestore;
using groomy.Customers;
using groomy.Notes;
using groomy.Pricing;
using groomy.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using groomy.services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;

namespace groomy.Forms.Update
{
    public partial class UpdateInvoiceForm : Form
    {
        private string invoiceId;
        private string currentNoteID;
        private List<Service> availableServices = new List<Service>();
        private List<LineItem> lineItems = new List<LineItem>();
        private Dictionary<string, customer> customerCache = new Dictionary<string, customer>();

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
        public UpdateInvoiceForm(Invoice invoice)
        {
            InitializeComponent();

            invoiceId = invoice.Id;
            tdpInvDate.Value = invoice.CreatedDate.ToDateTime();
            dateTimePicker1.Value = invoice.DueDate.ToDateTime();
            chkPaid.Checked = invoice.IsPaid;
            nudTotal.Value = (decimal)invoice.Total;
            lineItems = invoice.LineItems ?? new List<LineItem>();
            // Load customers for the combo box
            loadCustomers();

            LoadCustomerAsync(invoice.ClientId);

            // Load available services
            LoadAvailableServices();

            // Load existing line items
            LoadLineItems();

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
        private async void LoadCustomerAsync(string clientId)
        {
            
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                customerCRUD customerCRUD = new customerCRUD(db);
                customer customer = await customerCRUD.getCustomerById(clientId);
                if (customer == null)
                {
                    Console.WriteLine("CARTRWADASDFAEFSDAFVASDCASVSDZVCDSACDSACSDACASDCSDACSDACASDCASDCA");
                }
                cmbCustName.Text = customer.email;
                cstText.Text = customer.fName + " " +customer.lName;
                txtCustAddr.Text = customer.address;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadAvailableServices()
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                ServicesCRUD servicesCRUD = new ServicesCRUD(db, "Services");
                availableServices = await servicesCRUD.GetAllServices();

                lstAvailable.View = System.Windows.Forms.View.Details;
                lstAvailable.FullRowSelect = true;
                lstAvailable.Columns.Clear();
                lstAvailable.Columns.Add("Service Name", 150);
                lstAvailable.Columns.Add("Description", 150);
                lstAvailable.Columns.Add("Price", 100);

                foreach (var service in availableServices)
                {
                    if (!service.Deleted)
                    {
                        ListViewItem item = new ListViewItem(service.Name);
                        item.SubItems.Add(service.Desc);
                        item.SubItems.Add($"${service.Price:F2}");
                        item.Tag = service;
                        lstAvailable.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLineItems()
        {
            listView2.Items.Clear();
            listView2.View = System.Windows.Forms.View.Details;
            listView2.FullRowSelect = true;
            foreach (var item in lineItems)
            {
                ListViewItem lvItem = new ListViewItem(item.ServiceName);
                lvItem.SubItems.Add(DateTime.Now.ToString("d")); // You might want to store/load this
                lvItem.SubItems.Add($"${item.Cost:F2}");
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.Tag = item;
                listView2.Items.Add(lvItem);
            }
            updateNud();
        }

        private void updateNud()
        {
            double total = 0;

            foreach (ListViewItem items in listView2.Items)

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

        

        private async void btnInvUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustName.SelectedItem == null)
                {
                    MessageBox.Show("Please select a customer.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFullName = cmbCustName.SelectedItem.ToString();
                if (!customerCache.ContainsKey(selectedFullName))
                {
                    MessageBox.Show("Selected customer not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                customer selectedCustomer = customerCache[selectedFullName];

                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                InvoiceCRUD invoiceCRUD = new InvoiceCRUD(db);

                // Create updated invoice object
                Invoice updatedInvoice = new Invoice
                {
                    Id = invoiceId,
                    ClientId = selectedCustomer.id,
                    CreatedDate = Timestamp.FromDateTime(tdpInvDate.Value.ToUniversalTime()),
                    DueDate = Timestamp.FromDateTime(dateTimePicker1.Value.ToUniversalTime()),
                    IsPaid = chkPaid.Checked,
                    LineItems = lineItems,
                    Total = (double)nudTotal.Value,
                    Deleted = false
                };

                // Update the invoice
                await invoiceCRUD.UpdateInvoice(updatedInvoice);

                MessageBox.Show("Invoice Updated Successfully!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating invoice: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItems.Count > 0)
            {
                var selectedItem = lstAvailable.SelectedItems[0];
                var service = selectedItem.Tag as Service;

                if (service != null)
                {
                    var lineItem = new LineItem
                    {
                        ServiceId = service.Id,
                        ServiceName = service.Name,
                        Cost = service.Price,
                        Quantity = 1
                    };

                    lineItems.Add(lineItem);
                    LoadLineItems();
                }
            }
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var selectedItem = listView2.SelectedItems[0];
                var lineItem = selectedItem.Tag as LineItem;

                if (lineItem != null)
                {
                    lineItems.Remove(lineItem);
                    LoadLineItems();
                }
            }
        }

        private async void btnNoteAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                note newNote = new note
                {
                    title = txtNoteTitle.Text,
                    desc = txtNote.Text,
                };

                await notesCreate.createNote(invoiceId, newNote);
                await LoadNotesAsync();

                txtNoteTitle.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnNoteUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(currentNoteID))
                {
                    MessageBox.Show("Please select a note to update.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                note updatedNote = new note
                {
                    title = txtNoteTitle.Text,
                    desc = txtNote.Text,
                };

                notesCreate.updateNote(updatedNote, currentNoteID, invoiceId);
                await LoadNotesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating note: {ex.Message}", "Error",
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
                currentNoteID = selectedItem.SubItems[3].Text;
            }
        }

        private async void cmbCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirestoreDb _db = firebaseConfig.Instance.getFirestoreDB();
            customerCRUD custCrud = new customerCRUD(_db);
            customer cust = await custCrud.getCustomerByEmail(cmbCustName.Text);
            cstText.Text = cust.fName + " " + cust.lName;
            txtCustAddr.Text = cust.address;
        }

        private void btnAddService_Click_1(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItems.Count > 0)
            {
                var selectedItem = lstAvailable.SelectedItems[0];
                var service = selectedItem.Tag as Service; // Get the Service object we stored in the Tag

                if (service != null)
                {
                    ListViewItem item = new ListViewItem(service.Name);
                    item.SubItems.Add(DateTime.Now.ToString("d")); // Date
                    item.SubItems.Add(service.Price.ToString("C")); // Price
                    item.SubItems.Add("1"); // Quantity
                    item.Tag = new LineItem
                    {
                        ServiceId = service.Id,
                        ServiceName = service.Name,
                        Cost = service.Price,
                        Quantity = 1
                    };
                    listView2.Items.Add(item);
                    updateNud();
                }
            }
        }

        private async void btnInvUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbCustName.Text))
                {
                    MessageBox.Show("Please select a customer.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                InvoiceCRUD invoiceCRUD = new InvoiceCRUD(db);
                customerCRUD customerCRUD = new customerCRUD(db);

                // Get selected customer
                customer selectedCustomer = await customerCRUD.getCustomerByEmail(cmbCustName.Text);
                if (selectedCustomer == null)
                {
                    MessageBox.Show("Selected customer not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Build line items list from listView2
                List<LineItem> updatedLineItems = new List<LineItem>();
                foreach (ListViewItem item in listView2.Items)
                {
                    var lineItem = item.Tag as LineItem;
                    if (lineItem != null)
                    {
                        updatedLineItems.Add(lineItem);
                    }
                    else
                    {
                        // If Tag is not set, create new LineItem from ListView data
                        updatedLineItems.Add(new LineItem
                        {
                            ServiceName = item.SubItems[0].Text,
                            Cost = double.Parse(item.SubItems[2].Text.Replace("$", "")),
                            Quantity = int.Parse(item.SubItems[3].Text)
                        });
                    }
                }

                // Create updated invoice object
                Invoice updatedInvoice = new Invoice
                {
                    Id = invoiceId,
                    ClientId = selectedCustomer.id,
                    CreatedDate = Timestamp.FromDateTime(tdpInvDate.Value.ToUniversalTime()),
                    DueDate = Timestamp.FromDateTime(dateTimePicker1.Value.ToUniversalTime()),
                    IsPaid = chkPaid.Checked,
                    LineItems = updatedLineItems,
                    Total = (double)nudTotal.Value,
                    Deleted = false
                };

                // Update the invoice
                await invoiceCRUD.UpdateInvoice(updatedInvoice);

                MessageBox.Show("Invoice Updated Successfully!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating invoice: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnNoteAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                note newNote = new note
                {
                    title = txtNoteTitle.Text,
                    desc = txtNote.Text,
                };

                await notesCreate.createNote(invoiceId, newNote);
                await LoadNotesAsync();

                // Clear input fields after successful creation
                txtNoteTitle.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnNoteUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                note newNote = new note
                {
                    title = txtNoteTitle.Text,
                    desc = txtNote.Text,
                };

                notesCreate.updateNote(newNote, currentNoteID, invoiceId);
                await LoadNotesAsync();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            await LoadNotesAsync();

        }
        private async void btnDeleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Invoices");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await notesCreate.deleteNote(invoiceId, currentNoteID);
                await LoadNotesAsync();
                txtNote.Text = null;
                txtNoteTitle.Text = null;
                currentNoteID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstNotes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstNotes.SelectedItems[0];
                txtNoteTitle.Text = selectedItem.Text;
                txtNote.Text = selectedItem.SubItems[2].Text;
                currentNoteID = selectedItem.SubItems[3].Text;
                // Assuming the note ID is stored as a tag or you have a way to retrieve it
            }
        }

        private async void UpdateInvoiceForm_Load(object sender, EventArgs e)
        {
            await LoadNotesAsync();

        }
    }
}