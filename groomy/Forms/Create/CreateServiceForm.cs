using FirebaseAdmin.Messaging;
using Google.Cloud.Firestore;
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

namespace groomy.Forms.Create
{
    public partial class CreateServiceForm : Form
    {
        public CreateServiceForm()
        {
            InitializeComponent();
        }

        private async void btnServCreate_Click(object sender, EventArgs e)
        {
            FirestoreDb db =  firebaseConfig.Instance.getFirestoreDB();
            ServicesCRUD createService = new ServicesCRUD(db, "Services");
            Service serviceToBeAdded = new Service
            {
                Name = txtServName.Text,
                Desc = txtServDesc.Text,
                Price = (double)nudPrice.Value,
                Deleted = false,
                Id = ""
            };
            await createService.CreateService(serviceToBeAdded);
            MessageBox.Show("Service Created Successfully!", "Service Created", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
