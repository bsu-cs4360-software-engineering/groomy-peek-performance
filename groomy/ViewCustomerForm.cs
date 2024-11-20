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
        public async void loadNotes()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db,"Customers");
            lstNotes.Items.Clear();
            var notes = await notesCreate.getAllNotes(__id);
            List<note> allNotes = notes;
            foreach(note thisNote in allNotes)
            {
                if(!thisNote.deleted)
                {
                    ListViewItem item = new ListViewItem(thisNote.title);
                    item.SubItems.Add(thisNote.dateCreated.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(thisNote.desc);

                    
                    lstNotes.Items.Add(item);
                }
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
            loadNotes();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
