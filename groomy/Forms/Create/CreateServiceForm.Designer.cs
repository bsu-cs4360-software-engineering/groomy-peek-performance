namespace groomy.Forms.Create
{
    partial class CreateServiceForm
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
            this.grpService = new System.Windows.Forms.GroupBox();
            this.lblServName = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.lblServDesc = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtServDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServCreate = new System.Windows.Forms.Button();
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.btnServCreate);
            this.grpService.Controls.Add(this.label1);
            this.grpService.Controls.Add(this.txtServDesc);
            this.grpService.Controls.Add(this.nudPrice);
            this.grpService.Controls.Add(this.lblServDesc);
            this.grpService.Controls.Add(this.txtServName);
            this.grpService.Controls.Add(this.lblServName);
            this.grpService.Location = new System.Drawing.Point(13, 13);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(168, 228);
            this.grpService.TabIndex = 0;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
            // 
            // lblServName
            // 
            this.lblServName.AutoSize = true;
            this.lblServName.Location = new System.Drawing.Point(6, 28);
            this.lblServName.Name = "lblServName";
            this.lblServName.Size = new System.Drawing.Size(38, 13);
            this.lblServName.TabIndex = 0;
            this.lblServName.Text = "Name:";
            // 
            // txtServName
            // 
            this.txtServName.Location = new System.Drawing.Point(50, 25);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(101, 20);
            this.txtServName.TabIndex = 1;
            // 
            // lblServDesc
            // 
            this.lblServDesc.AutoSize = true;
            this.lblServDesc.Location = new System.Drawing.Point(6, 53);
            this.lblServDesc.Name = "lblServDesc";
            this.lblServDesc.Size = new System.Drawing.Size(63, 13);
            this.lblServDesc.TabIndex = 2;
            this.lblServDesc.Text = "Description:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(55, 168);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(57, 20);
            this.nudPrice.TabIndex = 3;
            // 
            // txtServDesc
            // 
            this.txtServDesc.Location = new System.Drawing.Point(9, 69);
            this.txtServDesc.MaxLength = 100;
            this.txtServDesc.Multiline = true;
            this.txtServDesc.Name = "txtServDesc";
            this.txtServDesc.Size = new System.Drawing.Size(143, 93);
            this.txtServDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price: $";
            // 
            // btnServCreate
            // 
            this.btnServCreate.Location = new System.Drawing.Point(6, 194);
            this.btnServCreate.Name = "btnServCreate";
            this.btnServCreate.Size = new System.Drawing.Size(75, 23);
            this.btnServCreate.TabIndex = 6;
            this.btnServCreate.Text = "Create";
            this.btnServCreate.UseVisualStyleBackColor = true;
            // 
            // CreateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 249);
            this.Controls.Add(this.grpService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateServiceForm";
            this.Text = "Create Service";
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.Label lblServDesc;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.Label lblServName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServDesc;
        private System.Windows.Forms.Button btnServCreate;
    }
}