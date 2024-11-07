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
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm(string email, string fName, string lName, string id, string phoneNumber, string address)
        {
            InitializeComponent();
            txtEmail.Text = email;
            txtFName.Text = fName;
            txtLName.Text = lName;
            txtPhoneNumber.Text = phoneNumber;
            txtAddr1.Text = address;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
