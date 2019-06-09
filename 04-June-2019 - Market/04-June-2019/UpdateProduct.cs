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
    public partial class UpdateProduct : Form
    {
        private Product ProductToUpdate = null;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProductId = cmbProduct.Text.Substring(0, 6);
            ProductToUpdate = Market.GetProductById(ProductId);

            if (ProductToUpdate != null)
            {
                txtProductName.Text = ProductToUpdate.Name;
                txtProductPrice.Text = ProductToUpdate.Price.ToString();
                cbProductHasDiscount.Checked = ProductToUpdate.HasDiscount ? true : false;
                txtProductDiscountPercent.Text = ProductToUpdate.DiscountPercent.ToString();
                txtProductCount.Text = ProductToUpdate.Count.ToString();
                UpdateCategoryDropdown();
                // Default select product category
                foreach (var item in cmbProductCategoryId.Items)
                {
                    if(item.ToString().Substring(0, 4) == ProductToUpdate.CategoryId)
                    {
                        cmbProductCategoryId.SelectedItem = item;
                    }
                }
                pnlEdit.Visible = true;
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            UpdateProductDropdown();
        }
        private void UpdateProductDropdown()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Text = "";

            foreach (var product in Market.GetProducts())
            {
                cmbProduct.Items.Add(product.Id + " - " + product.Name);
            }
        }
        private void UpdateCategoryDropdown()
        {
            cmbProductCategoryId.Items.Clear();
            cmbProductCategoryId.Text = "";

            foreach (var category in Market.GetCategories())
            {
                cmbProductCategoryId.Items.Add(category.Id + " - " + category.Name);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string ProductName = txtProductName.Text.Trim();
            string ProductPrice = txtProductPrice.Text.Trim();
            bool ProductHasDiscount = cbProductHasDiscount.Checked;
            string ProductDiscountPercent = txtProductDiscountPercent.Text.Trim();
            string ProductCount = txtProductCount.Text.Trim();
            string ProductCategory = cmbProductCategoryId.Text.Trim().Substring(0, 4);
            if (ProductName == string.Empty)
            {
                MessageBox.Show("Product Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ProductPrice == string.Empty)
            {
                MessageBox.Show("Product Price is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                float price = Convert.ToSingle(ProductPrice);
            }
            catch (Exception)
            {
                MessageBox.Show("Product price is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ProductHasDiscount)
            {
                if (ProductDiscountPercent == string.Empty)
                {
                    MessageBox.Show("Product Has Discount is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    float DiscountPercent = Convert.ToSingle(ProductDiscountPercent);
                }
                catch (Exception)
                {
                    MessageBox.Show("Product Discount Percent is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (ProductCount == string.Empty)
            {
                MessageBox.Show("Product Count is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                float count = Convert.ToSingle(ProductCount);
            }
            catch (Exception)
            {
                MessageBox.Show("Product count is incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ProductCategory == string.Empty)
            {
                MessageBox.Show("Product Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation is OK, update product
            ProductToUpdate.Name = ProductName;
            ProductToUpdate.Price = Convert.ToSingle(ProductPrice);
            ProductToUpdate.HasDiscount = ProductHasDiscount;
            ProductToUpdate.DiscountPercent = Convert.ToSingle(ProductDiscountPercent);
            ProductToUpdate.Count = Convert.ToSingle(ProductCount);
            ProductToUpdate.CategoryId = ProductCategory;
            DialogResult result = MessageBox.Show("Product was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
    }
}
