namespace groomy
{
    partial class AccountCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(85, 32);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(144, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(86, 58);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(143, 20);
            this.txtLast.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(86, 85);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(143, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password: ";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(235, 82);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(75, 23);
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(94, 119);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 19);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 173);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountCreateForm";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.AccountCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnCreate;
    }
}