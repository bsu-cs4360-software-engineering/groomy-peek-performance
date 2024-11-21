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
using groomy.Notes;
using groomy.services;

namespace groomy
{
    public partial class ViewCustomerForm : Form
    {
        private string __id;
        private async void LoadNotesAsync()
        {
            try
            {
                FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
                notesCRUD notesCreate = new notesCRUD(db, "Customers");
                lstNotes.View = System.Windows.Forms.View.Details;
                lstNotes.FullRowSelect = true;
                var notes = await notesCreate.getAllNotes(__id);

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
        public ViewCustomerForm(string email, string fName, string lName, string id, string phoneNumber, string address)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhoneNumber.Text = phoneNumber;
            txtAddr1.Text = address;
            __id = id;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNoteCreate_Click(object sender, EventArgs e)
        {

        }

        private void lstNotes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstNotes.SelectedItems[0];
                txtNoteTitle.Text = selectedItem.Text;
                txtNote.Text = selectedItem.SubItems[2].Text;
                // Assuming the note ID is stored as a tag or you have a way to retrieve it
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            lstNotes.View = View.Details;
            lstNotes.FullRowSelect= true;
            LoadNotesAsync();
        }
    }
}
