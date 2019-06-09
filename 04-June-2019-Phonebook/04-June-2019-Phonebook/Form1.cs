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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            new Contacts().ShowDialog();
            pnlRunner.Top = pictureBox1.Top;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            new AddContact().ShowDialog();
            pnlRunner.Top = pictureBox2.Top;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            new UpdateContact().ShowDialog();
            pnlRunner.Top = pictureBox4.Top;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            new DeleteContact().ShowDialog();
            pnlRunner.Top = pictureBox3.Top;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            new SearchByName().ShowDialog();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            new SearchByNumber().ShowDialog();
        }
    }
}
