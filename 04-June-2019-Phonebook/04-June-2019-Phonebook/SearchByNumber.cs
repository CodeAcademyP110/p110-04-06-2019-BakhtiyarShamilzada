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
    public partial class SearchByNumber : Form
    {
        private Contact ContactToSearch = null;
        public SearchByNumber()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text.Trim();
            if (number == string.Empty)
            {
                MessageBox.Show("Number is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ContactToSearch = Phone.GetContactByNumber(number);

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
