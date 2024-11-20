namespace groomy
{
    partial class updateUsers
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpID = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddr3 = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.btnNoteCreate = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            this.grpID.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Update";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 38);
            this.panel3.TabIndex = 4;
            // 
            // grpID
            // 
            this.grpID.BackColor = System.Drawing.SystemColors.Control;
            this.grpID.Controls.Add(this.txtLName);
            this.grpID.Controls.Add(this.label2);
            this.grpID.Controls.Add(this.label1);
            this.grpID.Controls.Add(this.txtFName);
            this.grpID.Location = new System.Drawing.Point(3, 12);
            this.grpID.Name = "grpID";
            this.grpID.Size = new System.Drawing.Size(362, 86);
            this.grpID.TabIndex = 1;
            this.grpID.TabStop = false;
            this.grpID.Text = "Identification";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(76, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(261, 20);
            this.txtFName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(76, 45);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(261, 20);
            this.txtLName.TabIndex = 1;
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(76, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(261, 20);
            this.txtFName.TabIndex = 0;
            // 
            // grpContact
            // 
            this.grpContact.BackColor = System.Drawing.SystemColors.Control;
            this.grpContact.Controls.Add(this.label5);
            this.grpContact.Controls.Add(this.panel1);
            this.grpContact.Controls.Add(this.label4);
            this.grpContact.Controls.Add(this.txtPhoneNumber);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label3);
            this.grpContact.Location = new System.Drawing.Point(3, 104);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(361, 168);
            this.grpContact.TabIndex = 3;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(75, 47);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(261, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone: ";
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddr3);
            this.panel1.Controls.Add(this.txtAddr2);
            this.panel1.Controls.Add(this.txtAddr1);
            this.panel1.Location = new System.Drawing.Point(75, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 84);
            this.panel1.TabIndex = 4;
            // 

            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(4, 4);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(254, 20);
            this.txtAddr1.TabIndex = 0;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(4, 31);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(254, 20);
            this.txtAddr2.TabIndex = 1;
            // 
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(3, 57);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.Size = new System.Drawing.Size(254, 20);
            this.txtAddr3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address: ";
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(4, 4);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(254, 20);
            this.txtAddr1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(75, 47);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(261, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email: ";
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
            this.grpNotes.Location = new System.Drawing.Point(372, 13);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(435, 294);
            this.grpNotes.TabIndex = 5;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // lstNotes
            // 
            this.lstNotes.HideSelection = false;
            this.lstNotes.Location = new System.Drawing.Point(6, 19);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(423, 99);
            this.lstNotes.TabIndex = 0;
            this.lstNotes.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(6, 142);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(423, 20);
            this.txtNoteTitle.TabIndex = 2;
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(10, 268);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(75, 23);
            this.btnEditNote.TabIndex = 6;
            this.btnEditNote.Text = "&Edit";
            this.btnEditNote.UseVisualStyleBackColor = true;
            // 
            // btnNoteCreate
            // 
            this.btnNoteCreate.Location = new System.Drawing.Point(10, 269);
            this.btnNoteCreate.Name = "btnNoteCreate";
            this.btnNoteCreate.Size = new System.Drawing.Size(75, 23);
            this.btnNoteCreate.TabIndex = 5;
            this.btnNoteCreate.Text = "&Create";
            this.btnNoteCreate.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(10, 186);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(419, 73);
            this.txtNote.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(10, 169);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note: ";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(10, 186);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(419, 73);
            this.txtNote.TabIndex = 4;
            // 
            // btnNoteCreate
            // 
            this.btnNoteCreate.Location = new System.Drawing.Point(10, 269);
            this.btnNoteCreate.Name = "btnNoteCreate";
            this.btnNoteCreate.Size = new System.Drawing.Size(75, 23);
            this.btnNoteCreate.TabIndex = 5;
            this.btnNoteCreate.Text = "&Create";
            this.btnNoteCreate.UseVisualStyleBackColor = true;
            // 
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(10, 268);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(75, 23);
            this.btnEditNote.TabIndex = 6;
            this.btnEditNote.Text = "&Edit";
            this.btnEditNote.UseVisualStyleBackColor = true;
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(6, 142);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(423, 20);
            this.txtNoteTitle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title: ";
            // 
            // lstNotes
            // 
            this.lstNotes.HideSelection = false;
            this.lstNotes.Location = new System.Drawing.Point(6, 19);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(423, 99);
            this.lstNotes.TabIndex = 0;
            this.lstNotes.UseCompatibleStateImageBehavior = false;
            // 
            // updateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 316);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpID);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateUsers";
            this.Text = "Update Customer";
            this.panel3.ResumeLayout(false);
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddr3;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.Button btnNoteCreate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Button btnEditNote;
    }
}