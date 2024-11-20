namespace groomy
{
    partial class CreateCustomerForm
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
            this.grpID = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpID.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpID
            // 
            this.grpID.Controls.Add(this.txtLName);
            this.grpID.Controls.Add(this.label2);
            this.grpID.Controls.Add(this.label1);
            this.grpID.Controls.Add(this.txtFName);
            this.grpID.Location = new System.Drawing.Point(12, 12);
            this.grpID.Name = "grpID";
            this.grpID.Size = new System.Drawing.Size(362, 86);
            this.grpID.TabIndex = 0;
            this.grpID.TabStop = false;
            this.grpID.Text = "Identification";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(76, 45);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(261, 20);
            this.txtLName.TabIndex = 1;
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
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(319, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.label5);
            this.grpContact.Controls.Add(this.panel1);
            this.grpContact.Controls.Add(this.label4);
            this.grpContact.Controls.Add(this.txtPhoneNumber);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.label3);
            this.grpContact.Location = new System.Drawing.Point(13, 104);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(361, 168);
            this.grpContact.TabIndex = 2;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
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
            // txtAddr3
            // 
            this.txtAddr3.Location = new System.Drawing.Point(3, 57);
            this.txtAddr3.Name = "txtAddr3";
            this.txtAddr3.Size = new System.Drawing.Size(254, 20);
            this.txtAddr3.TabIndex = 2;
            this.txtAddr3.Visible = false;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(4, 31);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(254, 20);
            this.txtAddr2.TabIndex = 1;
            this.txtAddr2.Visible = false;
            // 
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 274);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 43);
            this.panel3.TabIndex = 4;
            // 
            // CreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 317);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCustomerForm";
            this.Text = "Create Customer";
            this.grpID.ResumeLayout(false);
            this.grpID.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.TextBox txtAddr3;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}