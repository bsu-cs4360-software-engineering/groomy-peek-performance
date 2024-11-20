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

namespace groomy
{
    public partial class ViewAppointmentsForm : Form
    {
        private string __id;
        public async void loadNotes()
        {
            FirestoreDb db = firebaseConfig.Instance.getFirestoreDB();
            notesCRUD notesCreate = new notesCRUD(db, "Customers");
            listView1.Items.Clear();
            var notes = await notesCreate.getAllNotes(__id);
            List<note> allNotes = notes;
            foreach (note thisNote in allNotes)
            {
                if (!thisNote.deleted)
                {
                    ListViewItem item = new ListViewItem(thisNote.title);
                    item.SubItems.Add(thisNote.dateCreated.ToDateTime().ToLocalTime().ToString("g"));
                    item.SubItems.Add(thisNote.desc);


                    listView1.Items.Add(item);
                }
            }

        }
        public ViewAppointmentsForm(string title, string desc, string start, string end, string loc, string id, string email)
        {
            InitializeComponent(); // Ensure this is called first

            txtDescription.Text = desc;
            txtTitle.Text = title;
            txtLocation.Text = loc;
            dateTimePicker1.Value = System.DateTime.Parse(start);
            dateTimePicker2.Value = System.DateTime.Parse(end);
            cmbCust.Text = email;
            __id = id;
            loadNotes();
        }

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
