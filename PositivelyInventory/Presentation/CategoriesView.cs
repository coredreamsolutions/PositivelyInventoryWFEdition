using PositivelyInventory.Model;
using PositivelyInventory.Data;
using PositivelyInventory.Validators;

namespace PositivelyInventory.Presentation
{
    public partial class CategoriesView : Form
    {
        static ProductRepository productRepository = new ProductRepository();
        
        public static List<Categories>? CategoriesModel { get; set; }
        public static Category? CategoryModel { get; set; }
    
        public CategoriesView(List<Categories> categories)
        {
            InitializeComponent();

            CategoriesModel = categories ?? throw new ArgumentNullException("categories");
           
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
            List<Categories> categories = productRepository.GetCategories();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = categories;
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

        public static void SaveNewCategory()
        {
            CheckResult checkResult = CategoryValidator.ValidateSave(CategoryModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            productRepository.SaveCategory(CategoryNodel, null);
         //   Close();
            //PopulateCategoriesGrid();
        }
    }
}
