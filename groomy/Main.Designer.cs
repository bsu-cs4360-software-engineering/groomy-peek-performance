namespace groomy
{
    partial class Main
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoHome = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAppointments = new System.Windows.Forms.Panel();
            this.btnAppDelete = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnAppAdd = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.First = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAppointments.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rdoCustomer);
            this.panel1.Controls.Add(this.rdoHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 543);
            this.panel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(4, 231);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(295, 58);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Appointments";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdoHome_CheckedChanged);
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.rdoCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdoCustomer.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoCustomer.FlatAppearance.BorderSize = 0;
            this.rdoCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCustomer.ForeColor = System.Drawing.Color.White;
            this.rdoCustomer.Location = new System.Drawing.Point(4, 171);
            this.rdoCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(295, 58);
            this.rdoCustomer.TabIndex = 1;
            this.rdoCustomer.Text = "Customer";
            this.rdoCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoCustomer.UseVisualStyleBackColor = false;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.rdoHome_CheckedChanged);
            // 
            // rdoHome
            // 
            this.rdoHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.rdoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdoHome.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoHome.Checked = true;
            this.rdoHome.FlatAppearance.BorderSize = 0;
            this.rdoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHome.ForeColor = System.Drawing.Color.White;
            this.rdoHome.Location = new System.Drawing.Point(4, 107);
            this.rdoHome.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHome.Name = "rdoHome";
            this.rdoHome.Size = new System.Drawing.Size(295, 58);
            this.rdoHome.TabIndex = 0;
            this.rdoHome.TabStop = true;
            this.rdoHome.Text = "Home";
            this.rdoHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoHome.UseVisualStyleBackColor = false;
            this.rdoHome.CheckedChanged += new System.EventHandler(this.rdoHome_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.pnlAppointments);
            this.panel2.Controls.Add(this.pnlCustomer);
            this.panel2.Controls.Add(this.pnlWelcome);
            this.panel2.Controls.Add(this.pnlLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 543);
            this.panel2.TabIndex = 1;
            // 
            // pnlAppointments
            // 
            this.pnlAppointments.Controls.Add(this.btnAppDelete);
            this.pnlAppointments.Controls.Add(this.listView2);
            this.pnlAppointments.Controls.Add(this.btnAppAdd);
            this.pnlAppointments.Location = new System.Drawing.Point(549, 15);
            this.pnlAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAppointments.Name = "pnlAppointments";
            this.pnlAppointments.Size = new System.Drawing.Size(563, 523);
            this.pnlAppointments.TabIndex = 10;
            this.pnlAppointments.Visible = false;
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.Location = new System.Drawing.Point(469, 53);
            this.btnAppDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(77, 28);
            this.btnAppDelete.TabIndex = 4;
            this.btnAppDelete.Text = "Delete...";
            this.btnAppDelete.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 14);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(444, 485);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnAppAdd
            // 
            this.btnAppAdd.Location = new System.Drawing.Point(471, 17);
            this.btnAppAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppAdd.Name = "btnAppAdd";
            this.btnAppAdd.Size = new System.Drawing.Size(77, 28);
            this.btnAppAdd.TabIndex = 3;
            this.btnAppAdd.Text = "Add...";
            this.btnAppAdd.UseVisualStyleBackColor = true;
            this.btnAppAdd.Click += new System.EventHandler(this.btnAppAdd_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.button2);
            this.pnlCustomer.Controls.Add(this.button1);
            this.pnlCustomer.Controls.Add(this.btnCustomerDelete);
            this.pnlCustomer.Controls.Add(this.btnCustomerAdd);
            this.pnlCustomer.Controls.Add(this.listView1);
            this.pnlCustomer.Location = new System.Drawing.Point(4, 4);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(537, 524);
            this.pnlCustomer.TabIndex = 9;
            this.pnlCustomer.Visible = false;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(455, 60);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(77, 28);
            this.btnCustomerDelete.TabIndex = 2;
            this.btnCustomerDelete.Text = "Delete...";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(456, 25);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(77, 28);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.Text = "Add...";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First,
            this.Last,
            this.pNumber,
            this.email,
            this.address,
            this.id});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(15, 23);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 477);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // First
            // 
            this.First.Text = "First Name";
            // 
            // Last
            // 
            this.Last.Text = "Last Name";
            // 
            // pNumber
            // 
            this.pNumber.Text = "Phone Number";
            // 
            // email
            // 
            this.email.DisplayIndex = 4;
            this.email.Text = "Email";
            // 
            // address
            // 
            this.address.DisplayIndex = 3;
            this.address.Text = "Address";
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.btnBack);
            this.pnlWelcome.Controls.Add(this.label4);
            this.pnlWelcome.Location = new System.Drawing.Point(8, 15);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(267, 123);
            this.pnlWelcome.TabIndex = 8;
            this.pnlWelcome.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 91);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome!";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.lnkCreateAccount);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Location = new System.Drawing.Point(177, 193);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(746, 123);
            this.pnlLogin.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(605, 30);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 57);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // lnkCreateAccount
            // 
            this.lnkCreateAccount.AutoSize = true;
            this.lnkCreateAccount.Location = new System.Drawing.Point(280, 90);
            this.lnkCreateAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkCreateAccount.Name = "lnkCreateAccount";
            this.lnkCreateAccount.Size = new System.Drawing.Size(76, 16);
            this.lnkCreateAccount.TabIndex = 6;
            this.lnkCreateAccount.TabStop = true;
            this.lnkCreateAccount.Text = "Create one!";
            this.lnkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(179, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(418, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "No Account? ";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(179, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(418, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Groomy";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlAppointments.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoHome;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader First;
        private System.Windows.Forms.ColumnHeader Last;
        private System.Windows.Forms.Panel pnlAppointments;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnAppDelete;
        private System.Windows.Forms.Button btnAppAdd;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.ColumnHeader pNumber;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

