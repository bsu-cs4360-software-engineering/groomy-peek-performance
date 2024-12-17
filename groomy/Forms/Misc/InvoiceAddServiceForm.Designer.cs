namespace groomy.Forms.Misc
{
    partial class InvoiceAddServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Name");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Description");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Price");
            this.button1 = new System.Windows.Forms.Button();
            this.lstServices = new System.Windows.Forms.ListView();
            this.cmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhName,
            this.cmhDescription,
            this.cmhPrice,
            this.IdP});
            this.lstServices.HideSelection = false;
            this.lstServices.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstServices.Location = new System.Drawing.Point(11, 11);
            this.lstServices.Margin = new System.Windows.Forms.Padding(2);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(349, 381);
            this.lstServices.TabIndex = 9;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // cmhName
            // 
            this.cmhName.Text = "Name";
            // 
            // cmhDescription
            // 
            this.cmhDescription.Text = "Description";
            // 
            // cmhPrice
            // 
            this.cmhPrice.Text = "Price";
            // 
            // IdP
            // 
            this.IdP.Text = "ID";
            // 
            // InvoiceAddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 429);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceAddServiceForm";
            this.Text = "InvoiceAddServiceForm";
            this.Load += new System.EventHandler(this.InvoiceAddServiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.ColumnHeader cmhName;
        private System.Windows.Forms.ColumnHeader cmhDescription;
        private System.Windows.Forms.ColumnHeader cmhPrice;
        private System.Windows.Forms.ColumnHeader IdP;
    }
}