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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = Market.GetProducts();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Categories().ShowDialog();
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.FormClosed += UpdateDatagridWhenFormClosed;
            addProduct.ShowDialog();
        }
        private void UpdateDatagridWhenFormClosed(object sender, EventArgs e)
        {
            dgwProducts.DataSource = null;
            dgwProducts.DataSource = Market.GetProducts();
        }
        private void CategoryAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
        }

        private void CategoryUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateCategory().ShowDialog();
        }

        private void CategoryDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteCategory().ShowDialog();
        }

        private void ProductDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct();
            deleteProduct.FormClosed += UpdateDatagridWhenFormClosed;
            deleteProduct.ShowDialog();
        }

        private void ProductUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.FormClosed += UpdateDatagridWhenFormClosed;
            updateProduct.ShowDialog();
        }
    }
}
