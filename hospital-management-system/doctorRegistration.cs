using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using hospital_management_system;

namespace HMS
{
    public partial class doctor_registration : Form
    {
        //I will Add data base connection and operations here for doctor registration
        public doctor_registration()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(doctor_registration_FormClosing);
            
            // Wire click events that are unwired in designer
            this.d_save.Click += new EventHandler(this.d_save_Click);
            this.d_clear.Click += new EventHandler(this.d_clear_Click);
        }

        private void doctor_registration_Load(object sender, EventArgs e)
        {

        }

        private void doctor_registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void d_save_Click(object sender, EventArgs e)
        {
            string name = d_name.Text.Trim();
            string id = d_id.Text.Trim();
            string specialization = special.Text.Trim();
            string contact = d_phone.Text.Trim();
            string email = d_mail.Text.Trim();
            string address = d_home.Text.Trim();
            string gender = dfemale.Checked ? "Female" : "Male";

            //Verify ID and Name fields are not empty before saving
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please fill in both Name and ID fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string dept = specialization.Contains("Department") || specialization.Contains("Clinic") ? specialization : specialization + " Department";
                string room = "Room " + new Random().Next(101, 499);

                var doctor = new Doctor(id, name, specialization, dept, room, contact, email, address, gender);
                DataManager.AddDoctor(doctor);

                MessageBox.Show($"Doctor '{name}' successfully registered!", "Doctor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); // Clear input fields after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //clear button click event handler to clear all input fields
        private void ClearFields()
        {
            d_name.Clear();
            d_id.Clear();
            special.Clear();
            d_phone.Clear();
            d_mail.Clear();
            d_home.Clear();
            dfemale.Checked = true;
            d_name.Focus(); // Set focus to the name field after clearing)
        }

        private void d_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}