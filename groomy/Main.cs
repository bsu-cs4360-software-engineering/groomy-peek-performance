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
using groomy.Auth;
using groomy.Customers;
using groomy.services;

namespace groomy
{
    public partial class Main : Form
    {
        /* This is the list of colors for the palette. 
         * White is already established within C# so it doesn't need to be declared here*/
        private Color PrimaryAccent = Color.FromArgb(15, 60, 82);
        private Color Highlight = Color.FromArgb(29,129,175);
        private Color offWhite = Color.FromArgb(254, 254, 254);
        private Color black = Color.FromArgb(16, 16, 16);

        //private customerCRUD custCrud = new customerCRUD();
        public Main()
        {
            InitializeComponent();
            rdoCustomer.BackColor = PrimaryAccent;
        }
        

        


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text != string.Empty)
            {
                txtUsername.Text = "UserName";
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form createUser = new AccountCreateForm();
            createUser.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            loginCheck checkLogin = new loginCheck(txtUsername.Text,txtPassword.Text);
            bool verifyUser = await checkLogin.checkUser();
            if (verifyUser)
            {
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
                rdoCustomer.Visible = true;
            }
            else
            {
                MessageBox.Show("Email and/or Password are not right");
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                // Optionally, set focus back to the username textbox for easier re-entry
                txtUsername.Focus();
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlWelcome.Visible = false;
            rdoCustomer.Visible=false;
        }




        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        //This is where the radio buttons logic is handled.  It runs based on the text in the button. 
        public async void loadCustomers()
        {
            listView1.Items.Clear();
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
     
            var customers = await customerGetter.getAllCustomers();
            List<customer> potato = customers;
            Console.WriteLine(potato.Count);
            if (potato == null || potato.Count == 0)
            {
                MessageBox.Show("No customers found.");
                return;
            }

            foreach (customer cust in potato)
            {
                if (cust.deleted != true)
                {
                    ListViewItem item = new ListViewItem(cust.fName);
                    item.SubItems.Add(cust.lName);
                    item.SubItems.Add(cust.phoneNumber);
                    item.SubItems.Add(cust.email);
                    item.SubItems.Add(cust.address);
                    item.SubItems.Add(cust.id);
                    listView1.Items.Add(item);
                }
            }
            

        }

        private async void rdoHome_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioBtn = this.panel1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Text)
                {
                    case "Home":
                        // This is the home button.  It should automatically be selected. 
                        pnlLogin.BringToFront();
                        pnlLogin.Visible = true;
                        pnlCustomer.Visible = false;
                        pnlAppointments.Visible = false;
                        break;

                    case "Customer":
                        // This is the customer button.  When this is clicked, it should run the getAllCustomers function. Jordan doesn't know how to set that up. 
                        listView1.Items.Clear();
                        listView1.View = View.Details;
                        listView1.FullRowSelect = true;
                        pnlCustomer.BringToFront();
                        pnlLogin.Visible = false;
                        pnlCustomer.Visible = true;
                        pnlAppointments.Visible = false;
                        loadCustomers();


                        break;

                    case "Appointments":
                        //This is the appointments button.
                        pnlAppointments.BringToFront();
                        pnlAppointments.Visible = true;
                        pnlLogin.Visible = false;
                        pnlCustomer.Visible = false; 
                        break;

                    default:
                        break;
                }
            }
        }

        private async void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CreateCustomerForm custFrm = new CreateCustomerForm();
            
            custFrm.ShowDialog();
        }

        private void btnAppAdd_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm appFrm = new CreateAppointmentForm();
            appFrm.ShowDialog();
        }

        private async void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("I hate winforms");
        }

        private async void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb db = config.getFirestoreDB();
            customerCRUD customerGetter = new customerCRUD(db);
            string email = listView1.SelectedItems[0].SubItems[3].Text;
            Console.WriteLine(email);
            customer cust = await customerGetter.getCustomerByEmail(email);
            await customerGetter.deleteCustomerByEmail(email);
            loadCustomers();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateUsers cutForm = new updateUsers(listView1.SelectedItems[0].SubItems[3].Text,
                listView1.SelectedItems[0].SubItems[0].Text,
                listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[5].Text,
                listView1.SelectedItems[0].SubItems[2].Text,
                listView1.SelectedItems[0].SubItems[4].Text);
            cutForm.ShowDialog();
        }
    }
}
