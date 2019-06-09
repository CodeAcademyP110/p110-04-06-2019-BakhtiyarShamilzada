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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            foreach (var category in Market.GetCategories())
            {
                cmbProductCategoryId.Items.Add(category.Id + " - " + category.Name);
            }
            cmbProductCategoryId.SelectedIndex = 0;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            string ProductName = txtProductName.Text.Trim();
            string ProductPrice = txtProductPrice.Text.Trim();
            bool ProductHasDiscount = cbProductHasDiscount.Checked;
            string ProductDiscountPercent = txtProductDiscountPercent.Text.Trim();
            string ProductCount = txtProductCount.Text.Trim();
            string ProductCategory = cmbProductCategoryId.Text.Trim().Substring(0, 4);
            if(ProductName == string.Empty)
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
            Market.AddProduct(new Product
            {
                Name = ProductName,
                HasDiscount = ProductHasDiscount,
                Price = Convert.ToSingle(ProductPrice),
                DiscountPercent = ProductHasDiscount ? Convert.ToSingle(ProductDiscountPercent): 0,
                Count = Convert.ToSingle(ProductCount),
                CategoryId = ProductCategory
            });
            DialogResult result = MessageBox.Show("Product was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
    }
}
