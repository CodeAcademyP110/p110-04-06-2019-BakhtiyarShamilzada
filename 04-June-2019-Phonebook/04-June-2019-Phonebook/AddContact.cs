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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lasttname = txtLastName.Text.Trim();
            string number = txtNumber.Text.Trim();
            if (firstname == string.Empty)
            {
                MessageBox.Show("First Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lasttname == string.Empty)
            {
                MessageBox.Show("Last Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (number == string.Empty)
            {
                MessageBox.Show("Number is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Phone.AddContact(new Contact
            {
                FirstName = firstname,
                LastName = lasttname,
                Number = number
            });
            //ResetAddCategoryControls();
            DialogResult result = MessageBox.Show("Contact was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
    }
}
