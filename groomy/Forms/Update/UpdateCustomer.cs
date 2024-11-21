using Google.Cloud.Firestore;
using groomy.Appointments;
using groomy.Customers;
using groomy.Notes;
using groomy.services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace groomy
{
    public partial class updateUsers : Form
    {
        private string customerId; // Store the customer ID\
        private string currentNoteID;
        public async Task LoadNotesAsync()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db, "Customers");
            

            try
            {
                var notes = await notesCreate.getAllNotes(customerId).ConfigureAwait(false);
                List<note> allNotes = notes;

                // Use Invoke to update the ListView on the UI thread
                this.Invoke((MethodInvoker)delegate {
                    lstNotes.Items.Clear();
                    foreach (note thisNote in allNotes)
                    {
                        ListViewItem item = new ListViewItem(thisNote.title)
                        {
                            SubItems = {
                        thisNote.dateCreated.ToDateTime().ToLocalTime().ToString("g"),
                        thisNote.desc,
                        thisNote.id
                    }
                        };
                        lstNotes.Items.Add(item);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public updateUsers(string email, string fName, string lName, string id, string phoneNumber, string address)
        {
            InitializeComponent();
            lstNotes.View = View.Details;
            lstNotes.FullRowSelect = true;
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

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
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

        private async void btnNoteCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Customers");

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

                await notesCreate.createNote(customerId, newNote);
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

            private async void btnEditNote_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Customers");

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

                notesCreate.updateNote(newNote, currentNoteID, customerId);
                await LoadNotesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Customers");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                notesCreate.deleteNote(customerId, currentNoteID);
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

        private async void updateUsers_Load(object sender, EventArgs e)
        {
            await LoadNotesAsync();
        }
    }
}