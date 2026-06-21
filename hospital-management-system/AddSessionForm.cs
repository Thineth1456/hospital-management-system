using System;
using System.Windows.Forms;
using System.Drawing;

namespace hospital_management_system
{
    public partial class AddSessionForm : Form
    {
        private string _doctorId;
        public Session CreatedSession { get; private set; }

        public AddSessionForm(Doctor doctor)
        {
            InitializeComponent();
            _doctorId = doctor.Id;
            lblDoctorName.Text = "Doctor: " + doctor.Name;
            txtRoom.Text = doctor.Room;

            // Set Form styling to match premium dark theme
            this.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.ForeColor = Color.FromArgb(241, 245, 249); // Slate 100

            // Apply style overrides to DateTimePicker
            dtpDate.CalendarMonthBackground = Color.FromArgb(30, 41, 59);
            dtpDate.CalendarTitleBackColor = Color.FromArgb(15, 23, 42);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                MessageBox.Show("Please enter a room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string startTime = cmbStart.SelectedItem?.ToString() ?? "09:00 AM";
            string endTime = cmbEnd.SelectedItem?.ToString() ?? "12:00 PM";

            CreatedSession = new Session(
                "S" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                _doctorId,
                dtpDate.Value.Date,
                startTime,
                endTime,
                txtRoom.Text.Trim(),
                (int)numPatients.Value
            );

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
