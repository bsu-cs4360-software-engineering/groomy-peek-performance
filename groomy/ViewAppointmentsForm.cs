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
        public ViewAppointmentsForm(string title, string desc, string start, string end, string loc, string id, string email)
        {
            InitializeComponent(); // Ensure this is called first

            txtDescription.Text = desc;
            txtTitle.Text = title;
            txtLocation.Text = loc;
            dateTimePicker1.Value = System.DateTime.Parse(start);
            dateTimePicker2.Value = System.DateTime.Parse(end);
            cmbCust.Text = email;
        }

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
