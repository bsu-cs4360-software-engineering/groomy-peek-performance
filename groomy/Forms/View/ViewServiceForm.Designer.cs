namespace groomy.Forms.View
{
    partial class ViewServiceForm
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpService = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServDesc = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblServDesc = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.lblServName = new System.Windows.Forms.Label();
            this.grpNotes.SuspendLayout();
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Controls.Add(this.lblNote);
            this.grpNotes.Controls.Add(this.txtNoteTitle);
            this.grpNotes.Controls.Add(this.label6);
            this.grpNotes.Controls.Add(this.lstNotes);
            this.grpNotes.Location = new System.Drawing.Point(186, 12);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(246, 228);
            this.grpNotes.TabIndex = 8;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(7, 147);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(223, 41);
            this.txtNote.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(7, 130);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(9, 107);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(221, 20);
            this.txtNoteTitle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
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
            this.lstNotes.Location = new System.Drawing.Point(6, 19);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(224, 68);
            this.lstNotes.TabIndex = 0;
            this.lstNotes.UseCompatibleStateImageBehavior = false;
            this.lstNotes.SelectedIndexChanged += new System.EventHandler(this.lstNotes_SelectedIndexChanged);
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
            // grpService
            // 
            this.grpService.Controls.Add(this.label1);
            this.grpService.Controls.Add(this.txtServDesc);
            this.grpService.Controls.Add(this.nudPrice);
            this.grpService.Controls.Add(this.lblServDesc);
            this.grpService.Controls.Add(this.txtServName);
            this.grpService.Controls.Add(this.lblServName);
            this.grpService.Location = new System.Drawing.Point(12, 12);
            this.grpService.Name = "grpService";
            this.grpService.Size = new System.Drawing.Size(168, 228);
            this.grpService.TabIndex = 7;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
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
            // txtServDesc
            // 
            this.txtServDesc.Location = new System.Drawing.Point(9, 69);
            this.txtServDesc.MaxLength = 100;
            this.txtServDesc.Multiline = true;
            this.txtServDesc.Name = "txtServDesc";
            this.txtServDesc.ReadOnly = true;
            this.txtServDesc.Size = new System.Drawing.Size(143, 93);
            this.txtServDesc.TabIndex = 4;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(55, 168);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ReadOnly = true;
            this.nudPrice.Size = new System.Drawing.Size(57, 20);
            this.nudPrice.TabIndex = 3;
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
            // txtServName
            // 
            this.txtServName.Location = new System.Drawing.Point(50, 25);
            this.txtServName.Name = "txtServName";
            this.txtServName.ReadOnly = true;
            this.txtServName.Size = new System.Drawing.Size(101, 20);
            this.txtServName.TabIndex = 1;
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
            // ViewServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 256);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewServiceForm";
            this.Text = "View Service";
            this.Load += new System.EventHandler(this.ViewServiceForm_Load);
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServDesc;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblServDesc;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.Label lblServName;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader Desc;
        private System.Windows.Forms.ColumnHeader Id;
    }
}