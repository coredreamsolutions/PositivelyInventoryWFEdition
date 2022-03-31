using PositivelyInventory.Model;
using PositivelyInventory.Data;
using PositivelyInventory.Validators;

namespace PositivelyInventory.Presentation
{
    public partial class CategoriesView : Form
    {
        CategoriesRepository categoriesRepository = new CategoriesRepository();
        //CategoriesRepository categoryRepository = new CategoriesRepository();

        public List<Category> CategoryListModel { get; set; }
        public Category CategoryModel { get; set; }

        public CategoriesView(List<Category> categoryListModel, Category categoryNew) // 3 Here
        {
            InitializeComponent();

            CategoryListModel = categoryListModel ?? throw new ArgumentNullException("categoryListModel");
            CategoryModel = categoryNew ?? throw new ArgumentNullException("categoryNew");

            ConfigureGrid();
            PopulateCategoriesGrid();
        }

        private void ConfigureGrid()
        {
            CategoriesGrid.AutoGenerateColumns = false;
            CategoriesGrid.RowHeadersVisible = false;
            CategoriesGrid.Columns[0].Visible = true;
        }
        private void PopulateCategoriesGrid()
        {
            List<Category> CategoryList = categoriesRepository.GetCategories();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = CategoryList;
            CategoriesGrid.DataSource = bindingSource;
            CategoriesGrid.Update();
        }
        public void BindModel(Category category)
        {
            CategoryNameIn.DataBindings.Add("Text", category, "CategoryName", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveCategory_Click(object sender, EventArgs e)
        {
            SaveNewCategory();
        }

        public void SaveNewCategory()
        {
        
            CheckResult checkResult = CategoryValidator.ValidateSave(CategoryModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          
            categoriesRepository.SaveCategory(CategoryModel, null);
            Close();
            PopulateCategoriesGrid();
        }
    }
}
