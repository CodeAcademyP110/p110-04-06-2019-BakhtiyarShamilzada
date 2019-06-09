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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {
            UpdateCategoryDropdown();
           
        }
        private void UpdateCategoryDropdown()
        {
            cmbProductCategory.Items.Clear();
            cmbProductCategory.Text = "";

            foreach (var category in Market.GetCategories())
            {
                cmbProductCategory.Items.Add(category.Id + " - " + category.Name);
            }
        }

        private void CmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCategory.Visible = true;
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete category", "Confirmaton", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string selectCategoryId = cmbProductCategory.Text.Substring(0, 4);
                if(Market.DeleteCategoryById(selectCategoryId))
                {
                    UpdateCategoryDropdown();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
