using Google.Cloud.Firestore;
using groomy.Notes;
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
using groomy.Pricing;

namespace groomy.Forms.View
{
    public partial class ViewServiceForm : Form
    {
        private string serviceId;
        public ViewServiceForm(Service service)
        {
            InitializeComponent();
            txtServName.Text = service.Name;
            txtServDesc.Text = service.Desc;
            nudPrice.Value = (decimal)service.Price;
            serviceId = service.Id;

        }
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
                        if (thisNote.deleted == false){
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
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ViewServiceForm_Load(object sender, EventArgs e)
        {
            LoadNotesAsync();
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

        private void grpNotes_Enter(object sender, EventArgs e)
        {

        }
    }
}
