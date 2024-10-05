using Supermarket.Bussines;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class ProductsForm : Form
    {
        private readonly ProductsDAO productsDAO;
        private bool EditMode;
        private bool IsNew;

        internal ProductsForm(ref ProductsDAO productsDAO)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\Archivos VSCM\\Supermarket\\Supermarket\\Resources\\Supermarket.png");
            this.productsDAO = productsDAO;
            LoadProductsList();
            EditMode = false;
            IsNew = false;
            ActivateControls(false);  
        }

        private void LoadProductsList()
        {
            DgProducts.Rows.Clear();
            foreach (KeyValuePair<int, Products> ProductsKV in this.productsDAO.GetProductsList())
            {
                DgProducts.Rows.Add(
                    ProductsKV.Value.Id,
                    ProductsKV.Value.Name,
                    ProductsKV.Value.Price,
                    ProductsKV.Value.Stock
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                IsNew = true;
                ClearFields(); 
            }
            else
            {
                if (!SaveProducts()) return;
                IsNew = false;
                EditMode = false;
            }

            ActivateControls(EditMode);
        }

        private void ActivateControls(bool state)
        {
            
            txtId.Enabled = false;

            
            txtName.Enabled = state;
            txtPrice.Enabled = state;
            txtStock.Enabled = state;

            DgProducts.Enabled = !state;
            btnDelete.Enabled = !state;
            btnClose.Enabled = !state;

            
            if (EditMode)
            {
                btnNew.Text = "Save";
                btnNew.Image = Resources.save;
                btnEdit.Text = "Cancel";
                btnEdit.Image = Resources.cancel;
            }
            else
            {
                btnNew.Text = "New";
                btnNew.Image = Resources._new;
                btnEdit.Text = "Edit";
                btnEdit.Image = Resources.edit;
            }

            if (state) txtName.Focus();
        }

        private bool SaveProducts()
        {
            if (!IsNameFilled()) return false;

            if (IsNew)
            {
               
                if (!int.TryParse(txtPrice.Text, out int price) || !int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Please enter valid numbers for price and stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Products products = new Products(null, txtName.Text, price, stock);

                if (!productsDAO.AddProducts(products))
                {
                    MessageBox.Show("Error to save", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Product saved successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductsList();
                return true;
            }
            else
            {
               
                int id = Int32.Parse(txtId.Text);
                Products products = productsDAO.GetProducts(id);

                if (products != null)
                {
                    if (!int.TryParse(txtPrice.Text, out int price) || !int.TryParse(txtStock.Text, out int stock))
                    {
                        MessageBox.Show("Please enter valid numbers for price and stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    products.Name = txtName.Text;
                    products.Price = price;
                    products.Stock = stock;
                    productsDAO.UpdateProducts(id, products);
                    LoadProductsList();
                    return true;
                }

                MessageBox.Show("Product not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsNameFilled()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Name, price, and stock are required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ClearFields();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Select a product to edit", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                EditMode = true;
                IsNew = false;
            }

            ActivateControls(EditMode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Select a product to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int id = Int32.Parse(txtId.Text);

            if (productsDAO.GetProducts(id) != null)
            {
                productsDAO.RemoveProducts(id);
                MessageBox.Show("Product deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductsList();
            }
            else
            {
                MessageBox.Show("Error deleting product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
        }

        private void DgProducts_Click(object sender, EventArgs e)
        {
            if (DgProducts.CurrentRow != null)
            {
                txtId.Text = DgProducts.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = DgProducts.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = DgProducts.CurrentRow.Cells[2].Value.ToString();
                txtStock.Text = DgProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
        }
    }
}
