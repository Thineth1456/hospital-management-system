using System;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Firstly connect each form with button and menu strip item
        private void registerBtn_Click(object sender, EventArgs e)
        {
            Form2 regForm = new Form2();
            regForm.Show();
            this.Hide();// Hide the current form (Form1) when opening Form2
        }

        private void p_list_Click(object sender, EventArgs e)
        {
            Form3 listForm = new Form3();
            listForm.Show();
            this.Hide(); // Hide the current form (Form1) when opening Form3
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 regForm = new Form2();
            regForm.Show();
            this.Hide(); // Hide the current form (Form1) when opening Form2
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 listForm = new Form3();
            listForm.Show();
            this.Hide(); // Hide the current form (Form1) when opening Form3
        }

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            var dashboard = new hospital_management_system.DoctorSessionsForm();
            dashboard.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var patientRegi = new HMS.Form2();
            patientRegi.Show();
            this.Hide();
        }

        private void p_list_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new hospital_management_system.Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
