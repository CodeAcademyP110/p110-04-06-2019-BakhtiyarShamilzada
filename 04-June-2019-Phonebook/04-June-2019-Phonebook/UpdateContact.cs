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
    public partial class UpdateContact : Form
    {
        private Contact ContactToUpdate = null;
        public UpdateContact()
        {
            InitializeComponent();
        }

        private void UpdateContact_Load(object sender, EventArgs e)
        {
            UpdateContactDropdown();
        }
        private void UpdateContactDropdown()
        {
            foreach (var contact in Phone.GetContacts())
            {
                cmbContact.Items.Add(contact.Id + " - " + contact.FirstName + " " + contact.LastName);
            }
        }

        private void CmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ContactId = cmbContact.Text.Substring(0, 4);
            ContactToUpdate = Phone.GetContactById(ContactId);

            if (ContactToUpdate != null)
            {
                txtFirstName.Text = ContactToUpdate.FirstName;
                txtLastName.Text = ContactToUpdate.LastName;
                txtNumber.Text = ContactToUpdate.Number;
                pnlEdit.Visible = true;
            }
        }

        private void BtnUpdateContact_Click(object sender, EventArgs e)
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

            // Validation is OK, Update Contact
            ContactToUpdate.FirstName = firstname;
            ContactToUpdate.LastName = lasttname;
            ContactToUpdate.Number = number;
            DialogResult result = MessageBox.Show("Contact was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result != 0)
            {
                Close();
            }
        }
    }
}
