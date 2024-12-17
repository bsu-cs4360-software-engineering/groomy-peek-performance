namespace groomy.Forms.View
{
    partial class ViewInvoiceForm
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Service Name");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Date");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Price");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Quantity");
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtInvNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tdpInvDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpInvoice.SuspendLayout();
            this.grpNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.checkBox1);
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
            this.grpInvoice.TabIndex = 0;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number: ";
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Controls.Add(this.lblNote);
            this.grpNotes.Controls.Add(this.txtNoteTitle);
            this.grpNotes.Controls.Add(this.label6);
            this.grpNotes.Controls.Add(this.lstNotes);
            this.grpNotes.Location = new System.Drawing.Point(406, 12);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(382, 511);
            this.grpNotes.TabIndex = 1;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // txtInvNumber
            // 
            this.txtInvNumber.Location = new System.Drawing.Point(102, 20);
            this.txtInvNumber.Name = "txtInvNumber";
            this.txtInvNumber.ReadOnly = true;
            this.txtInvNumber.Size = new System.Drawing.Size(280, 20);
            this.txtInvNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // tdpInvDate
            // 
            this.tdpInvDate.Enabled = false;
            this.tdpInvDate.Location = new System.Drawing.Point(102, 47);
            this.tdpInvDate.Name = "tdpInvDate";
            this.tdpInvDate.Size = new System.Drawing.Size(200, 20);
            this.tdpInvDate.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Due Date:";
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
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(10, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 352);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clmService
            // 
            this.clmService.Text = "Service Name";
            this.clmService.Width = 120;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(13, 480);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Paid:   ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 277);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 220);
            this.txtNote.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(8, 263);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Note: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(12, 234);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(364, 20);
            this.txtNoteTitle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 217);
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
            // ViewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewInvoiceForm";
            this.Text = "Invoice View";
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tdpInvDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvNumber;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmService;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmPrice;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Id;
    }
}