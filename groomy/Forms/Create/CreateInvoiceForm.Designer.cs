﻿namespace groomy.Forms.Create
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
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.cstText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.txtCustAddr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tdpInvDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.btnServiceRemove = new System.Windows.Forms.Button();
            this.lstServices = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.cstText);
            this.grpInvoice.Controls.Add(this.label7);
            this.grpInvoice.Controls.Add(this.cmbCustName);
            this.grpInvoice.Controls.Add(this.txtCustAddr);
            this.grpInvoice.Controls.Add(this.label6);
            this.grpInvoice.Controls.Add(this.label5);
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
            // cstText
            // 
            this.cstText.Location = new System.Drawing.Point(114, 48);
            this.cstText.Name = "cstText";
            this.cstText.ReadOnly = true;
            this.cstText.Size = new System.Drawing.Size(268, 20);
            this.cstText.TabIndex = 16;
            this.cstText.TextChanged += new System.EventHandler(this.cstText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Customer Name: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(114, 20);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(268, 21);
            this.cmbCustName.TabIndex = 14;
            this.cmbCustName.SelectedIndexChanged += new System.EventHandler(this.cmbCustName_SelectedIndexChanged);
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.Location = new System.Drawing.Point(114, 83);
            this.txtCustAddr.Multiline = true;
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.ReadOnly = true;
            this.txtCustAddr.Size = new System.Drawing.Size(268, 102);
            this.txtCustAddr.TabIndex = 13;
            this.txtCustAddr.TextChanged += new System.EventHandler(this.txtCustAddr_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Address: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer Email: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(59, 456);
            this.nudTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
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
            this.clmDesc,
            this.clmPrice,
            this.clmID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 293);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 156);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clmService
            // 
            this.clmService.Text = "Service Name";
            this.clmService.Width = 180;
            // 
            // clmDesc
            // 
            this.clmDesc.Text = "Desc";
            // 
            // clmPrice
            // 
            this.clmPrice.Text = "Price";
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
            this.btnCreate.Location = new System.Drawing.Point(12, 529);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(6, 503);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnServiceAdd.TabIndex = 10;
            this.btnServiceAdd.Text = "Add Service";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // btnServiceRemove
            // 
            this.btnServiceRemove.Location = new System.Drawing.Point(87, 503);
            this.btnServiceRemove.Name = "btnServiceRemove";
            this.btnServiceRemove.Size = new System.Drawing.Size(75, 23);
            this.btnServiceRemove.TabIndex = 11;
            this.btnServiceRemove.Text = "Remove";
            this.btnServiceRemove.UseVisualStyleBackColor = true;
            this.btnServiceRemove.Click += new System.EventHandler(this.btnServiceRemove_Click);
            // 
            // lstServices
            // 
            this.lstServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.desc,
            this.price,
            this.ID});
            this.lstServices.HideSelection = false;
            this.lstServices.Location = new System.Drawing.Point(6, 19);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(377, 478);
            this.lstServices.TabIndex = 12;
            this.lstServices.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // desc
            // 
            this.desc.Text = "Description";
            // 
            // price
            // 
            this.price.Text = "price";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstServices);
            this.groupBox1.Controls.Add(this.btnServiceRemove);
            this.groupBox1.Controls.Add(this.btnServiceAdd);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 536);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Services";
            // 
            // CreateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateInvoiceForm";
            this.Text = "CreateInvoiceForm";
            this.Load += new System.EventHandler(this.CreateInvoiceForm_Load);
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmService;
        private System.Windows.Forms.ColumnHeader clmDesc;
        private System.Windows.Forms.ColumnHeader clmPrice;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cstText;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ListView lstServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader ID;
    }
}