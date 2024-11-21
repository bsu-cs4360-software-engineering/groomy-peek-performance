using Google.Cloud.Firestore;
using groomy.Notes;
using groomy.Pricing;
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

namespace groomy.Forms.Update
{
    public partial class UpdateServiceForm : Form
    {
        private string serviceId; // To store the ID of the service being updated
        private string currentNoteID;
        private async void LoadNotesAsync()
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Services");
                lstNotes.View = System.Windows.Forms.View.Details;
                lstNotes.FullRowSelect = true;
                var notes = await notesCreate.getAllNotes(serviceId);

                this.Invoke((MethodInvoker)delegate {
                        lstNotes.Items.Clear();
                    foreach (note thisNote in notes)
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
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UpdateServiceForm(Service service)
        {
            InitializeComponent();

            // Populate form fields with existing service data
            txtServName.Text = service.Name;
            txtServDesc.Text = service.Desc;
            nudPrice.Value = (decimal)service.Price;
            serviceId = service.Id;
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

        private void txtServName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtServDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnServUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Firestore database instance
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                ServicesCRUD serviceCRUD = new ServicesCRUD(db, "Services");

                // Create updated service object
                Service updatedService = new Service
                {
                    Id = serviceId,
                    Name = txtServName.Text,
                    Desc = txtServDesc.Text,
                    Price = (double)nudPrice.Value,
                    Deleted = false
                };

                // Update the service
               await serviceCRUD.UpdateService(updatedService);

                MessageBox.Show("Service Updated Successfully!", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating service: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNoteTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnNoteCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Services");

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

                await notesCreate.createNote(serviceId, newNote);
                LoadNotesAsync();

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
                notesCRUD notesCreate = new notesCRUD(db, "Services");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                note updatedNote = new note
                {
                    title = txtNoteTitle.Text,
                    desc = txtNote.Text,
                };

                notesCreate.updateNote(updatedNote, currentNoteID, serviceId);
                LoadNotesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Services");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                notesCreate.deleteNote(serviceId, currentNoteID);
                LoadNotesAsync();
                txtNote.Text = null;
                txtNoteTitle.Text = null;
                currentNoteID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateServiceForm_Load(object sender, EventArgs e)
        {
            LoadNotesAsync();
        }
    }
}
