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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
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

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteProduct.Visible = true;
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete product", "Confirmaton", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string selectProductId = cmbProduct.Text.Substring(0, 6);
                if (Market.DeleteProductById(selectProductId))
                {
                    UpdateProductDropdown();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
