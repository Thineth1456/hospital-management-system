using System;
using System.Drawing;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class PlaceAppointmentForm : Form
    {
        private Session _session;
        private Doctor _doctor;
        private Patient _currentPatient = null;
        private int _nextAppointmentNo = 1;

        public PlaceAppointmentForm(Session session, Doctor doctor)
        {
            InitializeComponent();

            _session = session;
            _doctor = doctor;

            // Load details
            lblDoctor.Text = $"Doctor: {doctor.Name} | {doctor.Specialty}";
            lblSessionTime.Text = $"Date & Time: {session.SessionDate:yyyy-MM-dd} | {session.StartTime} - {session.EndTime}";
            lblRoom.Text = $"Location: {session.Room}";

            // Calculate next appointment number for this session
            _nextAppointmentNo = DataManager.GetNextAppointmentNumber(_session.Id);
            lblAppointmentNo.Text = "#" + _nextAppointmentNo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtPatientId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter a Patient ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient p = DataManager.GetPatientById(id);
            if (p != null)
            {
                _currentPatient = p;
                txtPatientName.Text = p.Name;
                txtPatientAge.Text = p.Age;
                txtPatientContact.Text = p.Contact;

                int genderIndex = cmbPatientGender.Items.IndexOf(p.Gender);
                if (genderIndex >= 0)
                {
                    cmbPatientGender.SelectedIndex = genderIndex;
                }

                lblSearchResultStatus.Text = $"Found: {p.Name} in records.";
                lblSearchResultStatus.ForeColor = Color.FromArgb(16, 185, 129); // Emerald Green
            }
            else
            {
                _currentPatient = null;
                txtPatientName.Clear();
                txtPatientAge.Clear();
                txtPatientContact.Clear();
                cmbPatientGender.SelectedIndex = 0;

                lblSearchResultStatus.Text = $"Patient not found. Fill fields below to register as ID '{id.ToUpper()}'.";
                lblSearchResultStatus.ForeColor = Color.FromArgb(239, 68, 68); // Red
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string patientId = txtPatientId.Text.Trim().ToUpper();
            string name = txtPatientName.Text.Trim();
            string age = txtPatientAge.Text.Trim();
            string gender = cmbPatientGender.SelectedItem?.ToString() ?? "Male";
            string contact = txtPatientContact.Text.Trim();

            if (string.IsNullOrEmpty(patientId))
            {
                MessageBox.Show("Please enter or search a Patient ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the patient's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Register patient if not already in system
            if (_currentPatient == null)
            {
                Patient p = DataManager.GetPatientById(patientId);
                if (p == null)
                {
                    p = new Patient(patientId, name, age, gender, contact);
                    DataManager.AddPatient(p);
                }
                _currentPatient = p;
            }
            else
            {
                // Update patient details if changed
                _currentPatient.Name = name;
                _currentPatient.Age = age;
                _currentPatient.Gender = gender;
                _currentPatient.Contact = contact;
                DataManager.SaveData(); // Save updates
            }

            // Create and save appointment
            string appointmentId = "A" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
            Appointment app = new Appointment(
                appointmentId,
                _session.Id,
                _currentPatient.Id,
                _currentPatient.Name,
                _nextAppointmentNo,
                DateTime.Now
            );

            DataManager.AddAppointment(app);

            MessageBox.Show($"Appointment successfully placed!\nPatient: {name}\nAppointment No: #{_nextAppointmentNo}", 
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
