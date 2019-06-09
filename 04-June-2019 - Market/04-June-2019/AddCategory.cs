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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text.Trim();
            if(CategoryName == string.Empty)
            {
                MessageBox.Show("Category Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Market.AddCategory(new Category
            {
                Name = CategoryName
            });
            ResetAddCategoryControls();
            DialogResult result = MessageBox.Show("Category was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
        private void ResetAddCategoryControls()
        {
            txtCategoryName.Text = "";
        }

    }
}
