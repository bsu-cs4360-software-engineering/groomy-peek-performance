using Google.Cloud.Firestore;
using Google.Type;
using groomy.Appointments;
using groomy.Customers;
using groomy.Notes;
using groomy.services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groomy
{
    public partial class UpdateAppointmentForm : Form
    {
        private string appointmentId; // Class-level variable to hold the appointment ID
        private string currentNoteID;
        public UpdateAppointmentForm(string title, string desc, string start, string end, string loc, string id, string email)
        {
            InitializeComponent(); // Ensure this is called first

            txtDescription.Text = desc;
            txtTitle.Text = title;
            txtLoc.Text = loc;
            dtpStart.Value = System.DateTime.Parse(start);
            dtpEnd.Value = System.DateTime.Parse(end);
            cmbCust.Text = email;
            appointmentId = id; // Assign the ID to the class-level variable
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            appointmentCRUD updatePlease = new appointmentCRUD(db);

            // Assuming comboBox1.SelectedText contains the email you want to use
            customer theCustomerInQuestion = await customerGetter.getCustomerByEmail(cmbCust.Text);
            System.DateTime startDateTimeUtc = dtpStart.Value.ToUniversalTime();
            System.DateTime endDateTimeUtc = dtpEnd.Value.ToUniversalTime();

            appointment newAppointment = new appointment
            {
                deleted = false,
                foreignKey = theCustomerInQuestion.id, // Use the instance's id
                id = appointmentId, // Use the class-level variable for the appointment ID
                location = txtLoc.Text,
                start = Timestamp.FromDateTime(startDateTimeUtc), // Convert to Timestamp
                endTime = Timestamp.FromDateTime(endDateTimeUtc), // Convert to Timestamp
                Title = txtTitle.Text,
                desc = txtDescription.Text,
            };

            await updatePlease.updateAppointment(newAppointment);
            MessageBox.Show("Appointment Updated!", "Updated", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private async void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {
            await LoadNotesAsync();
        }
        public async Task LoadNotesAsync()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db, "Appointments");
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            try
            {
                var notes = await notesCreate.getAllNotes(appointmentId).ConfigureAwait(false);
                List<note> allNotes = notes;

                // Use Invoke to update the ListView on the UI thread
                this.Invoke((MethodInvoker)delegate {
                    listView1.Items.Clear();
                    foreach (note thisNote in allNotes)
                    {
                        if (thisNote.deleted == false)
                            {ListViewItem item = new ListViewItem(thisNote.title)
                        {
                            SubItems = {
                        thisNote.dateCreated.ToDateTime().ToLocalTime().ToString("g"),
                        thisNote.desc,
                        thisNote.id
                    }
                        };
                            listView1.Items.Add(item);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtNoteTitle.Text = selectedItem.Text;
                txtNote.Text = selectedItem.SubItems[2].Text;
                currentNoteID = selectedItem.SubItems[3].Text;
                // Assuming the note ID is stored as a tag or you have a way to retrieve it
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Appointments");

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

                await notesCreate.createNote(appointmentId, newNote);
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

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Appointments");

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

                notesCreate.updateNote(newNote, currentNoteID, appointmentId);
                await LoadNotesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating note: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNoteTitle_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Appointments");

                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNoteTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    MessageBox.Show("Please enter both a title and a note.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await notesCreate.deleteNote(appointmentId, currentNoteID);
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
    }
}