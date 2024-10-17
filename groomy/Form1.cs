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
    public partial class Main : Form
    {
        /* This is the list of colors for the palette. 
         * White is already established within C# so it doesn't need to be declared here*/
        private Color PrimaryAccent = Color.FromArgb(15, 60, 82);
        private Color Highlight = Color.FromArgb(29,129,175);
        private Color offWhite = Color.FromArgb(254, 254, 254);
        private Color black = Color.FromArgb(16, 16, 16);
        public Main()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groomyDataSet);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groomyDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.groomyDataSet.Users);

        }
    }
}
