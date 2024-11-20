namespace groomy
{
    partial class ViewCustomerForm
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
            this.txtAddr3 = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.grpID = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.btnNoteCreate = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.grpID.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(4, 70);
            this.txtAddr3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.ReadOnly = true;
            this.txtAddr3.Size = new System.Drawing.Size(337, 22);
            this.txtAddr3.TabIndex = 2;
            this.txtAddr3.Visible = false;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(5, 38);
            this.txtAddr2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.ReadOnly = true;
            this.txtAddr2.Size = new System.Drawing.Size(337, 22);
            this.txtAddr2.TabIndex = 1;
            this.txtAddr2.Visible = false;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(5, 5);
            this.txtAddr1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.ReadOnly = true;
            this.txtAddr1.Size = new System.Drawing.Size(337, 22);
            this.txtAddr1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddr3);
            this.panel1.Controls.Add(this.txtAddr2);
            this.panel1.Controls.Add(this.txtAddr1);
            this.panel1.Location = new System.Drawing.Point(100, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 103);
            this.panel1.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(101, 55);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(347, 22);
            this.txtLName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(101, 23);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(347, 22);
            this.txtFName.TabIndex = 0;
            // 
            // grpID
            // 
            this.grpID.Controls.Add(this.txtLName);
            this.grpID.Controls.Add(this.label2);
            this.grpID.Controls.Add(this.label1);
            this.grpID.Controls.Add(this.txtFName);
            this.grpID.Location = new System.Drawing.Point(16, 15);
            this.grpID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpID.Name = "grpID";
            this.grpID.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpID.Size = new System.Drawing.Size(483, 106);
            this.grpID.TabIndex = 5;
            this.grpID.TabStop = false;
            this.grpID.Text = "Identification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(100, 58);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(347, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 25);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(347, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email: ";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.label5);
            this.grpContact.Controls.Add(this.panel1);
            this.grpContact.Controls.Add(this.label4);
            this.grpContact.Controls.Add(this.txtPhoneNumber);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label3);
            this.grpContact.Location = new System.Drawing.Point(17, 128);
            this.grpContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContact.Size = new System.Drawing.Size(481, 207);
            this.grpContact.TabIndex = 6;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.btnEditNote);
            this.grpNotes.Controls.Add(this.btnNoteCreate);
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Controls.Add(this.lblNote);
            this.grpNotes.Controls.Add(this.txtNoteTitle);
            this.grpNotes.Controls.Add(this.label6);
            this.grpNotes.Controls.Add(this.lstNotes);
            this.grpNotes.Location = new System.Drawing.Point(507, 15);
            this.grpNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNotes.Size = new System.Drawing.Size(580, 362);
            this.grpNotes.TabIndex = 7;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(17, 331);
            this.btnEditNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(100, 28);
            this.btnEditNote.TabIndex = 6;
            this.btnEditNote.Text = "&Edit";
            this.btnEditNote.UseVisualStyleBackColor = true;
            // 
            // btnNoteCreate
            // 
            this.btnNoteCreate.Location = new System.Drawing.Point(13, 331);
            this.btnNoteCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoteCreate.Name = "btnNoteCreate";
            this.btnNoteCreate.Size = new System.Drawing.Size(100, 28);
            this.btnNoteCreate.TabIndex = 5;
            this.btnNoteCreate.Text = "&Create";
            this.btnNoteCreate.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(13, 229);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(557, 89);
            this.txtNote.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(13, 208);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(42, 16);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(8, 175);
            this.txtNoteTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(563, 22);
            this.txtNoteTitle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title: ";
            // 
            // lstNotes
            // 
            this.lstNotes.HideSelection = false;
            this.lstNotes.Location = new System.Drawing.Point(8, 23);
            this.lstNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(563, 121);
            this.lstNotes.TabIndex = 0;
            this.lstNotes.UseCompatibleStateImageBehavior = false;
            this.lstNotes.SelectedIndexChanged += new System.EventHandler(this.lstNotes_SelectedIndexChanged);
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 425);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpID);
            this.Controls.Add(this.grpContact);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewCustomerForm";
            this.Text = "View Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddr3;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox grpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Button btnNoteCreate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.Button btnEditNote;
    }
}