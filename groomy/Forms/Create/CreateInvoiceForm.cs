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
    public partial class CreateInvoiceForm : Form
    {
        public CreateInvoiceForm()
        {
            InitializeComponent();
        }
        //Here's the create button function!  Add the fun stuff with the database to this. 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Created!", "Invoice Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
