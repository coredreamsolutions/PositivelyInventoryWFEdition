namespace PositivelyInventory.Presentation
{
    partial class CategoriesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CategoriesGrid = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryNameIn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteCategorySelected = new System.Windows.Forms.Button();
            this.SaveCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesGrid
            // 
            this.CategoriesGrid.AllowUserToAddRows = false;
            this.CategoriesGrid.AllowUserToDeleteRows = false;
            this.CategoriesGrid.AllowUserToResizeRows = false;
            this.CategoriesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoriesGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.CategoriesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoriesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CategoriesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CategoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName});
            this.CategoriesGrid.Location = new System.Drawing.Point(13, 13);
            this.CategoriesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriesGrid.MultiSelect = false;
            this.CategoriesGrid.Name = "CategoriesGrid";
            this.CategoriesGrid.ReadOnly = true;
            this.CategoriesGrid.RowHeadersVisible = false;
            this.CategoriesGrid.RowTemplate.Height = 25;
            this.CategoriesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGrid.Size = new System.Drawing.Size(180, 390);
            this.CategoriesGrid.TabIndex = 1;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.CategoryName.DefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(214, 174);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 21);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name";
            // 
            // CategoryNameIn
            // 
            this.CategoryNameIn.Location = new System.Drawing.Point(276, 171);
            this.CategoryNameIn.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryNameIn.Name = "CategoryNameIn";
            this.CategoryNameIn.PlaceholderText = "Category Name";
            this.CategoryNameIn.Size = new System.Drawing.Size(324, 29);
            this.CategoryNameIn.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.DeleteCategorySelected);
            this.panel1.Controls.Add(this.SaveCategory);
            this.panel1.Location = new System.Drawing.Point(201, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 141);
            this.panel1.TabIndex = 18;
            // 
            // DeleteCategorySelected
            // 
            this.DeleteCategorySelected.FlatAppearance.BorderSize = 0;
            this.DeleteCategorySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCategorySelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteCategorySelected.ForeColor = System.Drawing.Color.White;
            this.DeleteCategorySelected.Image = global::PositivelyInventory.Properties.Resources.delete_64x64;
            this.DeleteCategorySelected.Location = new System.Drawing.Point(153, 13);
            this.DeleteCategorySelected.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCategorySelected.Name = "DeleteCategorySelected";
            this.DeleteCategorySelected.Size = new System.Drawing.Size(94, 106);
            this.DeleteCategorySelected.TabIndex = 3;
            this.DeleteCategorySelected.Text = "Delete";
            this.DeleteCategorySelected.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCategorySelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCategorySelected.UseVisualStyleBackColor = true;
            // 
            // SaveCategory
            // 
            this.SaveCategory.FlatAppearance.BorderSize = 0;
            this.SaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCategory.ForeColor = System.Drawing.Color.White;
            this.SaveCategory.Image = global::PositivelyInventory.Properties.Resources.newcontact_64x642;
            this.SaveCategory.Location = new System.Drawing.Point(13, 13);
            this.SaveCategory.Margin = new System.Windows.Forms.Padding(4);
            this.SaveCategory.Name = "SaveCategory";
            this.SaveCategory.Size = new System.Drawing.Size(116, 106);
            this.SaveCategory.TabIndex = 2;
            this.SaveCategory.Text = "S&ave";
            this.SaveCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveCategory.UseVisualStyleBackColor = true;
            this.SaveCategory.Click += new System.EventHandler(this.SaveCategory_Click);
            // 
            // CategoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1108, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CategoryNameIn);
            this.Controls.Add(this.CategoriesGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CategoriesGrid;
        private DataGridViewTextBoxColumn CategoryName;
        private Label NameLabel;
        private TextBox CategoryNameIn;
        private Panel panel1;
        private Button DeleteCategorySelected;
        private Button SaveCategory;
    }
}