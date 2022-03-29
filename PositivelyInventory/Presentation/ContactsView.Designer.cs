namespace PositivelyInventory.Presentation
{
    partial class ContactsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContactsGrid = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteContactSelected = new System.Windows.Forms.Button();
            this.NewContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsGrid
            // 
            this.ContactsGrid.AllowUserToAddRows = false;
            this.ContactsGrid.AllowUserToDeleteRows = false;
            this.ContactsGrid.AllowUserToResizeRows = false;
            this.ContactsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactsGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.ContactsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ContactsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ContactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.MobileNumber,
            this.OfficeNumber});
            this.ContactsGrid.Location = new System.Drawing.Point(13, 138);
            this.ContactsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsGrid.MultiSelect = false;
            this.ContactsGrid.Name = "ContactsGrid";
            this.ContactsGrid.ReadOnly = true;
            this.ContactsGrid.RowHeadersVisible = false;
            this.ContactsGrid.RowTemplate.Height = 25;
            this.ContactsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContactsGrid.Size = new System.Drawing.Size(780, 274);
            this.ContactsGrid.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email Address";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // MobileNumber
            // 
            this.MobileNumber.DataPropertyName = "MobileNumber";
            dataGridViewCellStyle1.Format = "(000) 000-0000";
            dataGridViewCellStyle1.NullValue = null;
            this.MobileNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.MobileNumber.HeaderText = "Mobile Number";
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            // 
            // OfficeNumber
            // 
            this.OfficeNumber.DataPropertyName = "OfficeNumber";
            dataGridViewCellStyle2.Format = "(000) 000-0000";
            dataGridViewCellStyle2.NullValue = null;
            this.OfficeNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.OfficeNumber.HeaderText = "Office Number";
            this.OfficeNumber.Name = "OfficeNumber";
            this.OfficeNumber.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.DeleteContactSelected);
            this.panel1.Controls.Add(this.NewContact);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 130);
            this.panel1.TabIndex = 2;
            // 
            // DeleteContactSelected
            // 
            this.DeleteContactSelected.FlatAppearance.BorderSize = 0;
            this.DeleteContactSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteContactSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteContactSelected.ForeColor = System.Drawing.Color.White;
            this.DeleteContactSelected.Image = global::PositivelyInventory.Properties.Resources.delete_64x64;
            this.DeleteContactSelected.Location = new System.Drawing.Point(139, 13);
            this.DeleteContactSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteContactSelected.Name = "DeleteContactSelected";
            this.DeleteContactSelected.Size = new System.Drawing.Size(107, 95);
            this.DeleteContactSelected.TabIndex = 3;
            this.DeleteContactSelected.Text = "Delete";
            this.DeleteContactSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteContactSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteContactSelected.UseVisualStyleBackColor = true;
            // 
            // NewContact
            // 
            this.NewContact.FlatAppearance.BorderSize = 0;
            this.NewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewContact.ForeColor = System.Drawing.Color.White;
            this.NewContact.Image = global::PositivelyInventory.Properties.Resources.newcontact_64x642;
            this.NewContact.Location = new System.Drawing.Point(13, 13);
            this.NewContact.Margin = new System.Windows.Forms.Padding(4);
            this.NewContact.Name = "NewContact";
            this.NewContact.Size = new System.Drawing.Size(107, 95);
            this.NewContact.TabIndex = 2;
            this.NewContact.Text = "New Contact";
            this.NewContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewContact.UseVisualStyleBackColor = true;
            this.NewContact.Click += new System.EventHandler(this.NewContact_Click);
            // 
            // ContactsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(806, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContactsGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ContactsGrid;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MobileNumber;
        private DataGridViewTextBoxColumn OfficeNumber;
        private Panel panel1;
        private Button NewContact;
        private Button DeleteContactSelected;
    }
}