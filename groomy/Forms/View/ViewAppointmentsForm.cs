using Google.Cloud.Firestore;
using groomy.Notes;
using groomy.services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groomy
{
    public partial class ViewAppointmentsForm : Form
    {
        private string appointmentId;
        private string currentNoteID = null;
        private void ClearNoteFields()
        {
            txtTitle.Text = string.Empty;
            txtNote.Text = string.Empty;
            currentNoteID = null;
        }
        public ViewAppointmentsForm(string title, string desc, string start, string end, string loc, string id, string email)
        {
            InitializeComponent(); // Ensure this is called first
            SetupForm(title, desc, start, end, loc, email);
            appointmentId = id;
        }

        private void SetupForm(string title, string desc, string start, string end, string loc, string email)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            txtDescription.Text = desc;
            txtTitle.Text = title;
            txtLocation.Text = loc;
            dateTimePicker1.Value = DateTime.Parse(start);
            dateTimePicker2.Value = DateTime.Parse(end);
            cmbCust.Text = email;
        }

        public async Task LoadNotesAsync()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db, "Appointments");

            try
            {
                var notes = await notesCreate.getAllNotes(appointmentId).ConfigureAwait(false);
                List<note> allNotes = notes;

                // Use Invoke to update the ListView on the UI thread
                this.Invoke((MethodInvoker)delegate {
                    listView1.Items.Clear();
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
                        listView1.Items.Add(item);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {
            await LoadNotesAsync();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
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

        private void txtNoteTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentNoteID))
            {
                MessageBox.Show("Please select a note to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this note?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db, "Appointments");
            if (result == DialogResult.Yes)
            {
                try
                {
                    notesCreate.deleteNote(appointmentId, currentNoteID);
                    await LoadNotesAsync(); // Refresh the list
                    ClearNoteFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}