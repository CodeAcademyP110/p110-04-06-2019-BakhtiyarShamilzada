using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_June_2019_Phonebook
{
    public partial class SearchByName : Form
    {
        private Contact ContactToSearch = null;
        public SearchByName()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            if (firstname == string.Empty)
            {
                MessageBox.Show("First Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ContactToSearch = Phone.GetContactByName(firstname);

            if (ContactToSearch != null)
            {
                MessageBox.Show(ContactToSearch.FirstName + " " + ContactToSearch.LastName + " " + ContactToSearch.Number);
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
