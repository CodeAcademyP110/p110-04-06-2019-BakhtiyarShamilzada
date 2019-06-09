using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_June_2019
{
    public partial class UpdateCategory : Form
    {
        private Category CategoryToUpdate = null;
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            UpdateProductDropdown();
        }
        private void UpdateProductDropdown()
        {
            foreach (var category in Market.GetCategories())
            {
                cmbProductCategory.Items.Add(category.Id + " - " + category.Name);
            }
        }

        private void CmbProductCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CategoryId = cmbProductCategory.Text.Substring(0, 4);
            CategoryToUpdate = Market.GetCategoryById(CategoryId);
            
            if(CategoryToUpdate != null)
            {
                txtCategoryName.Text = CategoryToUpdate.Name;
                pnlEdit.Visible = true;
            }
        }

        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text.Trim();
            if (CategoryName == string.Empty)
            {
                MessageBox.Show("Category Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation is OK, Update Category
            CategoryToUpdate.Name = CategoryName;
            DialogResult result = MessageBox.Show("Category was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
    }
}
