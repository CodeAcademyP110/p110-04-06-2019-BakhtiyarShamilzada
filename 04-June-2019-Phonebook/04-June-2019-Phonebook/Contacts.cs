﻿using System;
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
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            dgwContacts.DataSource = Phone.GetContacts();
        }
    }
}
