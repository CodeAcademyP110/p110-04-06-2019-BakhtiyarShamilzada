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
    public partial class DeleteContact : Form
    {
        public DeleteContact()
        {
            InitializeComponent();
        }

        private void DeleteContact_Load(object sender, EventArgs e)
        {
            UpdateContactDropdown();
        }
        private void UpdateContactDropdown()
        {
            cmbContact.Items.Clear();
            cmbContact.Text = "";
            foreach (var contact in Phone.GetContacts())
            {
                cmbContact.Items.Add(contact.Id + " - " + contact.FirstName + " " + contact.LastName);
            }
        }

        private void CmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteContact.Visible = true;
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete contact ?", "Confirmaton", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string selectContactId = cmbContact.Text.Substring(0, 4);
                if (Phone.DeleteContactById(selectContactId))
                {
                    UpdateContactDropdown();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
