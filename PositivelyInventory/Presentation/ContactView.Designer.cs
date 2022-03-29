namespace PositivelyInventory.Presentation
{
    partial class ContactView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteContactSelected = new System.Windows.Forms.Button();
            this.SaveCloseContact = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.OfficeNumber = new System.Windows.Forms.TextBox();
            this.MobileNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.OfficeNumberLabel = new System.Windows.Forms.Label();
            this.MobileNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.DeleteContactSelected);
            this.panel1.Controls.Add(this.SaveCloseContact);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 137);
            this.panel1.TabIndex = 3;
            // 
            // DeleteContactSelected
            // 
            this.DeleteContactSelected.FlatAppearance.BorderSize = 0;
            this.DeleteContactSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteContactSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteContactSelected.ForeColor = System.Drawing.Color.White;
            this.DeleteContactSelected.Image = global::PositivelyInventory.Properties.Resources.delete_64x64;
            this.DeleteContactSelected.Location = new System.Drawing.Point(153, 13);
            this.DeleteContactSelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteContactSelected.Name = "DeleteContactSelected";
            this.DeleteContactSelected.Size = new System.Drawing.Size(94, 106);
            this.DeleteContactSelected.TabIndex = 3;
            this.DeleteContactSelected.Text = "Delete";
            this.DeleteContactSelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteContactSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteContactSelected.UseVisualStyleBackColor = true;
            // 
            // SaveCloseContact
            // 
            this.SaveCloseContact.FlatAppearance.BorderSize = 0;
            this.SaveCloseContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCloseContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCloseContact.ForeColor = System.Drawing.Color.White;
            this.SaveCloseContact.Image = global::PositivelyInventory.Properties.Resources.newcontact_64x642;
            this.SaveCloseContact.Location = new System.Drawing.Point(13, 13);
            this.SaveCloseContact.Margin = new System.Windows.Forms.Padding(4);
            this.SaveCloseContact.Name = "SaveCloseContact";
            this.SaveCloseContact.Size = new System.Drawing.Size(116, 106);
            this.SaveCloseContact.TabIndex = 2;
            this.SaveCloseContact.Text = "S&ave && Close";
            this.SaveCloseContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveCloseContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveCloseContact.UseVisualStyleBackColor = true;
            this.SaveCloseContact.Click += new System.EventHandler(this.SaveCloseContact_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(328, 166);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.PlaceholderText = "Last Name";
            this.LastName.Size = new System.Drawing.Size(153, 29);
            this.LastName.TabIndex = 19;
            // 
            // OfficeNumber
            // 
            this.OfficeNumber.Location = new System.Drawing.Point(192, 295);
            this.OfficeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.OfficeNumber.Name = "OfficeNumber";
            this.OfficeNumber.PlaceholderText = "(000) 000-0000";
            this.OfficeNumber.Size = new System.Drawing.Size(289, 29);
            this.OfficeNumber.TabIndex = 18;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Location = new System.Drawing.Point(192, 250);
            this.MobileNumber.Margin = new System.Windows.Forms.Padding(4);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.PlaceholderText = "(000) 000-0000";
            this.MobileNumber.Size = new System.Drawing.Size(289, 29);
            this.MobileNumber.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(192, 208);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(289, 29);
            this.Email.TabIndex = 16;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(192, 166);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.PlaceholderText = "First Name";
            this.FirstName.Size = new System.Drawing.Size(127, 29);
            this.FirstName.TabIndex = 15;
            // 
            // OfficeNumberLabel
            // 
            this.OfficeNumberLabel.AutoSize = true;
            this.OfficeNumberLabel.Location = new System.Drawing.Point(30, 298);
            this.OfficeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OfficeNumberLabel.Name = "OfficeNumberLabel";
            this.OfficeNumberLabel.Size = new System.Drawing.Size(113, 21);
            this.OfficeNumberLabel.TabIndex = 14;
            this.OfficeNumberLabel.Text = "Office Number";
            // 
            // MobileNumberLabel
            // 
            this.MobileNumberLabel.AutoSize = true;
            this.MobileNumberLabel.Location = new System.Drawing.Point(30, 253);
            this.MobileNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MobileNumberLabel.Name = "MobileNumberLabel";
            this.MobileNumberLabel.Size = new System.Drawing.Size(120, 21);
            this.MobileNumberLabel.TabIndex = 13;
            this.MobileNumberLabel.Text = "Mobile Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(30, 211);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 21);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(30, 169);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 21);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name";
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(512, 360);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OfficeNumber);
            this.Controls.Add(this.MobileNumber);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.MobileNumberLabel);
            this.Controls.Add(this.OfficeNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "- Contact";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button DeleteContactSelected;
        private Button SaveCloseContact;
        private TextBox LastName;
        private TextBox OfficeNumber;
        private TextBox MobileNumber;
        private TextBox Email;
        private TextBox FirstName;
        private Label OfficeNumberLabel;
        private Label MobileNumberLabel;
        private Label EmailLabel;
        private Label NameLabel;
    }
}