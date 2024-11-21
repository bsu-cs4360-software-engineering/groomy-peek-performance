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
            this.btnServCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServDesc = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblServDesc = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.lblServName = new System.Windows.Forms.Label();
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
            this.grpService.Location = new System.Drawing.Point(17, 16);
            this.grpService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpService.Name = "grpService";
            this.grpService.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpService.Size = new System.Drawing.Size(224, 281);
            this.grpService.TabIndex = 0;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
            // 
            // btnServCreate
            // 
            this.btnServCreate.Location = new System.Drawing.Point(8, 239);
            this.btnServCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServCreate.Name = "btnServCreate";
            this.btnServCreate.Size = new System.Drawing.Size(100, 28);
            this.btnServCreate.TabIndex = 6;
            this.btnServCreate.Text = "Create";
            this.btnServCreate.UseVisualStyleBackColor = true;
            this.btnServCreate.Click += new System.EventHandler(this.btnServCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price: $";
            // 
            // txtServDesc
            // 
            this.txtServDesc.Location = new System.Drawing.Point(12, 85);
            this.txtServDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServDesc.MaxLength = 100;
            this.txtServDesc.Multiline = true;
            this.txtServDesc.Name = "txtServDesc";
            this.txtServDesc.Size = new System.Drawing.Size(189, 114);
            this.txtServDesc.TabIndex = 4;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(73, 207);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(76, 22);
            this.nudPrice.TabIndex = 3;
            // 
            // lblServDesc
            // 
            this.lblServDesc.AutoSize = true;
            this.lblServDesc.Location = new System.Drawing.Point(8, 65);
            this.lblServDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServDesc.Name = "lblServDesc";
            this.lblServDesc.Size = new System.Drawing.Size(78, 16);
            this.lblServDesc.TabIndex = 2;
            this.lblServDesc.Text = "Description:";
            // 
            // txtServName
            // 
            this.txtServName.Location = new System.Drawing.Point(67, 31);
            this.txtServName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(133, 22);
            this.txtServName.TabIndex = 1;
            // 
            // lblServName
            // 
            this.lblServName.AutoSize = true;
            this.lblServName.Location = new System.Drawing.Point(8, 34);
            this.lblServName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServName.Name = "lblServName";
            this.lblServName.Size = new System.Drawing.Size(47, 16);
            this.lblServName.TabIndex = 0;
            this.lblServName.Text = "Name:";
            // 
            // CreateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 306);
            this.Controls.Add(this.grpService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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