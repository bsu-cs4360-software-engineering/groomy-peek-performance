namespace groomy.Forms.Create
{
    partial class CreateInvoiceForm
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Service Name");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Date");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Price");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Quantity");
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tdpInvDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustAddr = new System.Windows.Forms.TextBox();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.btnServiceRemove = new System.Windows.Forms.Button();
            this.grpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.cmbCustName);
            this.grpInvoice.Controls.Add(this.txtCustAddr);
            this.grpInvoice.Controls.Add(this.label6);
            this.grpInvoice.Controls.Add(this.label5);
            this.grpInvoice.Controls.Add(this.chkPaid);
            this.grpInvoice.Controls.Add(this.nudTotal);
            this.grpInvoice.Controls.Add(this.label4);
            this.grpInvoice.Controls.Add(this.listView1);
            this.grpInvoice.Controls.Add(this.label3);
            this.grpInvoice.Controls.Add(this.dateTimePicker1);
            this.grpInvoice.Controls.Add(this.tdpInvDate);
            this.grpInvoice.Controls.Add(this.label2);
            this.grpInvoice.Controls.Add(this.txtInvNumber);
            this.grpInvoice.Controls.Add(this.label1);
            this.grpInvoice.Location = new System.Drawing.Point(12, 12);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(388, 511);
            this.grpInvoice.TabIndex = 2;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPaid.Location = new System.Drawing.Point(13, 480);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(59, 17);
            this.chkPaid.TabIndex = 9;
            this.chkPaid.Text = "Paid:   ";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(59, 456);
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(120, 20);
            this.nudTotal.TabIndex = 8;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total: $";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmService,
            this.clmDate,
            this.clmPrice,
            this.clmQuantity});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(10, 293);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 156);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clmService
            // 
            this.clmService.Text = "Service Name";
            this.clmService.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // tdpInvDate
            // 
            this.tdpInvDate.Enabled = false;
            this.tdpInvDate.Location = new System.Drawing.Point(102, 218);
            this.tdpInvDate.Name = "tdpInvDate";
            this.tdpInvDate.Size = new System.Drawing.Size(200, 20);
            this.tdpInvDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // txtInvNumber
            // 
            this.txtInvNumber.Location = new System.Drawing.Point(102, 191);
            this.txtInvNumber.Name = "txtInvNumber";
            this.txtInvNumber.ReadOnly = true;
            this.txtInvNumber.Size = new System.Drawing.Size(280, 20);
            this.txtInvNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number: ";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(323, 529);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(12, 529);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnServiceAdd.TabIndex = 10;
            this.btnServiceAdd.Text = "Add Service";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Address: ";
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.Location = new System.Drawing.Point(114, 44);
            this.txtCustAddr.Multiline = true;
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.ReadOnly = true;
            this.txtCustAddr.Size = new System.Drawing.Size(268, 141);
            this.txtCustAddr.TabIndex = 13;
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(114, 20);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(268, 21);
            this.cmbCustName.TabIndex = 14;
            // 
            // btnServiceRemove
            // 
            this.btnServiceRemove.Location = new System.Drawing.Point(93, 529);
            this.btnServiceRemove.Name = "btnServiceRemove";
            this.btnServiceRemove.Size = new System.Drawing.Size(75, 23);
            this.btnServiceRemove.TabIndex = 11;
            this.btnServiceRemove.Text = "Remove";
            this.btnServiceRemove.UseVisualStyleBackColor = true;
            // 
            // CreateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 560);
            this.Controls.Add(this.btnServiceRemove);
            this.Controls.Add(this.btnServiceAdd);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateInvoiceForm";
            this.Text = "CreateInvoiceForm";
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmService;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmPrice;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker tdpInvDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.TextBox txtCustAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.Button btnServiceRemove;
    }
}