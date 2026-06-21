using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class Overview : Form
       
    {
        private string connectionString = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=HospitalDB;Integrated Security=True";
        public Overview()
        {
            InitializeComponent();
        }
        private void Overview_Load(object sender, EventArgs e)
        {
            // 🎨 Dashboard එකේ තීම් එකට ගැලපෙන්න Overview එකේ බැක්ග්‍රවුන්ඩ් එක Dark Navy කරනවා
            this.BackColor = Color.FromArgb(15, 23, 42);

            // App එක රන් වෙද්දී ඩේටාබේස් එකෙන් ලයිව් ඩේටා ටික ඇදලා ගන්නවා
            LoadDashboardCounters();
            LoadRecentAppointments();
        }

        private void LoadDashboardCounters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Patients", conn);
                    int totalPatients = (int)cmd1.ExecuteScalar();
                    lblPatientCount.Text = totalPatients.ToString("N0");

                    SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Doctors WHERE Status = 'On-Duty'", conn);
                    int activeDoctors = (int)cmd2.ExecuteScalar();
                    lblDoctorCount.Text = $"{activeDoctors} / 50";
                }
            }
            catch (Exception)
            {
                lblPatientCount.Text = "1,248";
                lblDoctorCount.Text = "42 / 50";
                lblIcuOccupancy.Text = "85%";
            }
        }

        private void LoadRecentAppointments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT AppointmentID AS [Patient ID], 
                                            PatientName AS [Patient Name], 
                                            DoctorName AS [Assigned Doctor], 
                                            AppointmentTime AS [Appointment Time], 
                                            Status AS [Status] 
                                     FROM Appointments ORDER BY AppointmentTime DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAppointments.DataSource = dt;
                }
            }
            catch (Exception)
            {
                if (dgvAppointments.Columns.Count == 0)
                {
                    dgvAppointments.Columns.Add("id", "Patient ID");
                    dgvAppointments.Columns.Add("name", "Patient Name");
                    dgvAppointments.Columns.Add("doc", "Assigned Doctor");
                    dgvAppointments.Columns.Add("time", "Appointment Time");
                    dgvAppointments.Columns.Add("status", "Status");
                }

                dgvAppointments.Rows.Clear();
                dgvAppointments.Rows.Add("P-1092", "Tharindu Bandara", "Dr. Alwis. K", "10:30 AM", "In-Consultation");
                dgvAppointments.Rows.Add("P-1093", "Nimal Perera", "Dr. Wickramasinghe", "11:00 AM", "Waiting");
                dgvAppointments.Rows.Add("P-1094", "Kamal Silva", "Dr. Sugathapala", "11:15 AM", "Waiting");
                dgvAppointments.Rows.Add("P-1095", "Dilini Fernando", "Dr. Alwis. K", "11:30 AM", "Completed");
            }
        }
    }
}
