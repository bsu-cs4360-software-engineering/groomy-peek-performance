namespace groomy.Forms.Update
{
    partial class UpdateServiceForm
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
            this.btnServUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServDesc = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblServDesc = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.lblServName = new System.Windows.Forms.Label();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.btnNoteCreate = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpService
            // 
            this.grpService.Controls.Add(this.btnServUpdate);
            this.grpService.Controls.Add(this.label1);
            this.grpService.Controls.Add(this.txtServDesc);
            this.grpService.Controls.Add(this.nudPrice);
            this.grpService.Controls.Add(this.lblServDesc);
            this.grpService.Controls.Add(this.txtServName);
            this.grpService.Controls.Add(this.lblServName);
            this.grpService.Location = new System.Drawing.Point(16, 15);
            this.grpService.Margin = new System.Windows.Forms.Padding(4);
            this.grpService.Name = "grpService";
            this.grpService.Padding = new System.Windows.Forms.Padding(4);
            this.grpService.Size = new System.Drawing.Size(224, 281);
            this.grpService.TabIndex = 1;
            this.grpService.TabStop = false;
            this.grpService.Text = "Service";
            // 
            // btnServUpdate
            // 
            this.btnServUpdate.Location = new System.Drawing.Point(8, 239);
            this.btnServUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnServUpdate.Name = "btnServUpdate";
            this.btnServUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnServUpdate.TabIndex = 6;
            this.btnServUpdate.Text = "Update";
            this.btnServUpdate.UseVisualStyleBackColor = true;
            this.btnServUpdate.Click += new System.EventHandler(this.btnServUpdate_Click);
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
            this.txtServDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtServDesc.MaxLength = 100;
            this.txtServDesc.Multiline = true;
            this.txtServDesc.Name = "txtServDesc";
            this.txtServDesc.Size = new System.Drawing.Size(189, 114);
            this.txtServDesc.TabIndex = 4;
            this.txtServDesc.TextChanged += new System.EventHandler(this.txtServDesc_TextChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(73, 207);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(76, 22);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.ValueChanged += new System.EventHandler(this.nudPrice_ValueChanged);
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
            this.txtServName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(133, 22);
            this.txtServName.TabIndex = 1;
            this.txtServName.TextChanged += new System.EventHandler(this.txtServName_TextChanged);
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
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.btnDelete);
            this.grpNotes.Controls.Add(this.btnEditNote);
            this.grpNotes.Controls.Add(this.btnNoteCreate);
            this.grpNotes.Controls.Add(this.txtNote);
            this.grpNotes.Controls.Add(this.lblNote);
            this.grpNotes.Controls.Add(this.txtNoteTitle);
            this.grpNotes.Controls.Add(this.label6);
            this.grpNotes.Controls.Add(this.lstNotes);
            this.grpNotes.Location = new System.Drawing.Point(248, 15);
            this.grpNotes.Margin = new System.Windows.Forms.Padding(4);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Padding = new System.Windows.Forms.Padding(4);
            this.grpNotes.Size = new System.Drawing.Size(328, 281);
            this.grpNotes.TabIndex = 6;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(116, 239);
            this.btnEditNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(100, 28);
            this.btnEditNote.TabIndex = 6;
            this.btnEditNote.Text = "&Edit";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // btnNoteCreate
            // 
            this.btnNoteCreate.Location = new System.Drawing.Point(8, 239);
            this.btnNoteCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoteCreate.Name = "btnNoteCreate";
            this.btnNoteCreate.Size = new System.Drawing.Size(100, 28);
            this.btnNoteCreate.TabIndex = 5;
            this.btnNoteCreate.Text = "&Create";
            this.btnNoteCreate.UseVisualStyleBackColor = true;
            this.btnNoteCreate.Click += new System.EventHandler(this.btnNoteCreate_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(9, 181);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(296, 50);
            this.txtNote.TabIndex = 4;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(9, 160);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(42, 16);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note: ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(12, 132);
            this.txtNoteTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(293, 22);
            this.txtNoteTitle.TabIndex = 2;
            this.txtNoteTitle.TextChanged += new System.EventHandler(this.txtNoteTitle_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title: ";
            // 
            // lstNotes
            // 
            this.lstNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Created,
            this.desc,
            this.id});
            this.lstNotes.HideSelection = false;
            this.lstNotes.Location = new System.Drawing.Point(8, 23);
            this.lstNotes.Margin = new System.Windows.Forms.Padding(4);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(297, 83);
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
            // desc
            // 
            this.desc.Text = "Description";
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // UpdateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 315);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateServiceForm";
            this.Text = "Update Service";
            this.grpService.ResumeLayout(false);
            this.grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpService;
        private System.Windows.Forms.Button btnServUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServDesc;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblServDesc;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.Label lblServName;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.Button btnEditNote;
        private System.Windows.Forms.Button btnNoteCreate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstNotes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Created;
        private System.Windows.Forms.ColumnHeader desc;
        private System.Windows.Forms.ColumnHeader id;
    }
}