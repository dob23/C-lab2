using Supermarket.Bussines;
using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoriesDAO categoriesDAO;
        private bool EditMode;
        private bool IsNew;

        internal CategoriesForm(ref CategoriesDAO categoriesDAO)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\Archivos VSCM\\Supermarket\\Supermarket\\Resources\\Supermarket.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.categoriesDAO = categoriesDAO;
            LoadCategoriesList();
            EditMode = false;
            IsNew = false;
            ActivateControls(false);
        }

        private void LoadCategoriesList()
        {
            DgCategories.Rows.Clear();
            foreach (KeyValuePair<int, Categories> categoryKV in this.categoriesDAO.GetCategoryList())
            {
                DgCategories.Rows.Add(
                    categoryKV.Value.Id,
                    categoryKV.Value.Name,
                    categoryKV.Value.Description
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                EditMode = true;
                IsNew = true;
                ClearFields();
            }
            else
            {
                if (SaveCategory())
                {
                    EditMode = false;
                    ActivateControls(false);
                }
            }

            ActivateControls(EditMode);
        }

        private void ActivateControls(bool state)
        {
            txtId.Enabled = false;
            txtName.Enabled = state;
            txtDescription.Enabled = state;

            DgCategories.Enabled = !state;
            btnDelete.Enabled = !state;
            btnClose.Enabled = !state;

            if (EditMode)
            {
                btnNew.Text = "Save";
                btnEdit.Text = "Cancel";
            }
            else
            {
                btnNew.Text = "New";
                btnEdit.Text = "Edit";
            }

            if (state) txtName.Focus();
        }

        private bool SaveCategory()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a valid category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (IsNew)
            {
                Categories category = new Categories(null, txtName.Text, txtDescription.Text);

                if (!categoriesDAO.AddCategory(category))
                {
                    MessageBox.Show("Error saving the category.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Category saved successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoriesList();
                return true;
            }
            else
            {
                int id = Int32.Parse(txtId.Text);
                Categories category = categoriesDAO.GetCategory(id);

                if (category != null)
                {
                    category.Name = txtName.Text;
                    category.Description = txtDescription.Text;

                    categoriesDAO.UpdateCategory(id, category);
                    LoadCategoriesList();
                    return true;
                }

                MessageBox.Show("Category not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ClearFields();
                ActivateControls(false);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Select a category to edit", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                EditMode = true;
                IsNew = false;
                ActivateControls(true);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Select a category to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int id = Int32.Parse(txtId.Text);

            if (categoriesDAO.GetCategory(id) != null)
            {
                categoriesDAO.RemoveCategory(id);
                MessageBox.Show("Category deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoriesList();
            }
            else
            {
                MessageBox.Show("Error deleting category", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
        }

        private void DgCategories_Click_1(object sender, EventArgs e)
        {
            if (DgCategories.CurrentRow != null)
            {
                txtId.Text = DgCategories.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = DgCategories.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = DgCategories.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
