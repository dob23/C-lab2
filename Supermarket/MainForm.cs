using Supermarket.Bussines;
using Supermarket.View;
using Supermarket.Model;
using System.Diagnostics;
using Supermarket.Properties;

namespace Supermarket
{
    public partial class MainForm : Form
    {
        internal ProductsDAO productsDAO;
        internal PayModeDAO payModeDAO;
        internal ProvidersDAO providersDAO;
        internal CategoriesDAO categoriesDAO;
        public MainForm()
        {
            IsMdiContainer = true;
            productsDAO = new ProductsDAO();
            payModeDAO = new PayModeDAO();
            providersDAO = new ProvidersDAO();
            categoriesDAO = new CategoriesDAO();
            InitializeComponent();
            payModeDAO.AddPayMode(new Model.PayMode(null, "Cash"));
            productsDAO.AddProducts(new Model.Products(null, "Agua", 2000, 100));
            providersDAO.AddProvider(new Model.Providers(null, "Colombina", "Semanal", 31243566));
            categoriesDAO.AddCategory(new Model.Categories(null, "Limpieza", "productos para limpieza en hogares"));

        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();
        }

        private void ProductsMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new(ref productsDAO);
            productsForm.MdiParent = this;
            productsForm.Show();
        }

        private void ProvidersMenuItem_Click(object sender, EventArgs e)
        {
            ProvidersForm providersform = new(ref providersDAO);
            providersform.MdiParent = this;
            providersform.Show();
        }

        private void CategoriesMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesform = new(ref categoriesDAO);
            categoriesform.MdiParent = this;
            categoriesform.Show();
        }
    }
}
