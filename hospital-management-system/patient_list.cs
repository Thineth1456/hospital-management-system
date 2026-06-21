using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide(); // Hide the current form
        }

        private void registationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 regForm = new Form2();
            regForm.Show();
            this.Hide(); // Hide the current form
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
