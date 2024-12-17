namespace groomy.Forms.Update
{
    partial class UpdateInvoiceForm
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
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnNoteUpdate = new System.Windows.Forms.Button();
            this.btnNoteAdd = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInvUpdate = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cstText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.txtCustAddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tdpInvDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAvailable = new System.Windows.Forms.ListView();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.grpNotes.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.btnDeleteNote);
            this.grpNotes.Controls.Add(this.btnNoteUpdate);
            this.grpNotes.Controls.Add(this.btnNoteAdd);
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Controls.Add(this.lblNote);
            this.grpNotes.Controls.Add(this.txtNoteTitle);
            this.grpNotes.Controls.Add(this.label6);
            this.grpNotes.Controls.Add(this.lstNotes);
            this.grpNotes.Location = new System.Drawing.Point(801, 16);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(382, 511);
            this.grpNotes.TabIndex = 3;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(172, 482);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNote.TabIndex = 12;
            this.btnDeleteNote.Text = "Delete";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnNoteUpdate
            // 
            this.btnNoteUpdate.Location = new System.Drawing.Point(91, 482);
            this.btnNoteUpdate.Name = "btnNoteUpdate";
            this.btnNoteUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnNoteUpdate.TabIndex = 11;
            this.btnNoteUpdate.Text = "Update";
            this.btnNoteUpdate.UseVisualStyleBackColor = true;
            this.btnNoteUpdate.Click += new System.EventHandler(this.btnNoteUpdate_Click_1);
            // 
            // btnNoteAdd
            // 
            this.btnNoteAdd.Location = new System.Drawing.Point(9, 482);
            this.btnNoteAdd.Name = "btnNoteAdd";
            this.btnNoteAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNoteAdd.TabIndex = 10;
            this.btnNoteAdd.Text = "Add Note";
            this.btnNoteAdd.UseVisualStyleBackColor = true;
            this.btnNoteAdd.Click += new System.EventHandler(this.btnNoteAdd_Click_1);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(3, 255);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 220);
            this.txtNote.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(5, 241);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Note: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(9, 212);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(364, 20);
            this.txtNoteTitle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Title: ";
            // 
            // lstNotes
            // 
            this.lstNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Created,
            this.Desc,
            this.Id});
            this.lstNotes.HideSelection = false;
            this.lstNotes.Location = new System.Drawing.Point(6, 20);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(370, 172);
            this.lstNotes.TabIndex = 5;
            this.lstNotes.UseCompatibleStateImageBehavior = false;
            this.lstNotes.SelectedIndexChanged += new System.EventHandler(this.lstNotes_SelectedIndexChanged_1);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Created
            // 
            this.Created.Text = "Created";
            // 
            // Desc
            // 
            this.Desc.Text = "Desc";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // btnInvUpdate
            // 
            this.btnInvUpdate.Location = new System.Drawing.Point(12, 530);
            this.btnInvUpdate.Name = "btnInvUpdate";
            this.btnInvUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnInvUpdate.TabIndex = 4;
            this.btnInvUpdate.Text = "&Update";
            this.btnInvUpdate.UseVisualStyleBackColor = true;
            this.btnInvUpdate.Click += new System.EventHandler(this.btnInvUpdate_Click_1);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.listView2);
            this.grpInvoice.Controls.Add(this.cstText);
            this.grpInvoice.Controls.Add(this.label1);
            this.grpInvoice.Controls.Add(this.cmbCustName);
            this.grpInvoice.Controls.Add(this.txtCustAddr);
            this.grpInvoice.Controls.Add(this.label5);
            this.grpInvoice.Controls.Add(this.label8);
            this.grpInvoice.Controls.Add(this.chkPaid);
            this.grpInvoice.Controls.Add(this.nudTotal);
            this.grpInvoice.Controls.Add(this.label4);
            this.grpInvoice.Controls.Add(this.label3);
            this.grpInvoice.Controls.Add(this.dateTimePicker1);
            this.grpInvoice.Controls.Add(this.tdpInvDate);
            this.grpInvoice.Controls.Add(this.label2);
            this.grpInvoice.Controls.Add(this.txtInvNumber);
            this.grpInvoice.Controls.Add(this.label7);
            this.grpInvoice.Location = new System.Drawing.Point(12, 13);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(388, 511);
            this.grpInvoice.TabIndex = 5;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clmDesc,
            this.columnHeader2,
            this.clmID});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 293);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(372, 156);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service Name";
            this.columnHeader1.Width = 180;
            // 
            // clmDesc
            // 
            this.clmDesc.Text = "Desc";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // cstText
            // 
            this.cstText.Location = new System.Drawing.Point(102, 48);
            this.cstText.Name = "cstText";
            this.cstText.ReadOnly = true;
            this.cstText.Size = new System.Drawing.Size(268, 20);
            this.cstText.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Name: ";
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(102, 20);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(268, 21);
            this.cmbCustName.TabIndex = 20;
            this.cmbCustName.SelectedIndexChanged += new System.EventHandler(this.cmbCustName_SelectedIndexChanged);
            // 
            // txtCustAddr
            // 
            this.txtCustAddr.Location = new System.Drawing.Point(102, 83);
            this.txtCustAddr.Multiline = true;
            this.txtCustAddr.Name = "txtCustAddr";
            this.txtCustAddr.ReadOnly = true;
            this.txtCustAddr.Size = new System.Drawing.Size(268, 102);
            this.txtCustAddr.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer Address: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Customer Email: ";
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
            this.nudTotal.Maximum = new decimal(new int[] {
            100000000,
            0,
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Invoice Number: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAvailable);
            this.groupBox1.Controls.Add(this.btnRemoveService);
            this.groupBox1.Controls.Add(this.btnAddService);
            this.groupBox1.Location = new System.Drawing.Point(406, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 511);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Services";
            // 
            // lstAvailable
            // 
            this.lstAvailable.HideSelection = false;
            this.lstAvailable.Location = new System.Drawing.Point(6, 19);
            this.lstAvailable.Name = "lstAvailable";
            this.lstAvailable.Size = new System.Drawing.Size(377, 427);
            this.lstAvailable.TabIndex = 12;
            this.lstAvailable.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Location = new System.Drawing.Point(87, 473);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveService.TabIndex = 11;
            this.btnRemoveService.Text = "Remove";
            this.btnRemoveService.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(6, 473);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 10;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click_1);
            // 
            // UpdateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.btnInvUpdate);
            this.Controls.Add(this.grpNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateInvoiceForm";
            this.Text = "Update Invoice";
            this.Load += new System.EventHandler(this.UpdateInvoiceForm_Load);
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Button btnNoteUpdate;
        private System.Windows.Forms.Button btnNoteAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnInvUpdate;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker tdpInvDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstAvailable;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox cstText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.TextBox txtCustAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clmDesc;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.Button btnDeleteNote;
    }
}