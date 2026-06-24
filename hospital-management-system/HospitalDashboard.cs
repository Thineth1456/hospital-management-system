using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class HospitalDashboard : Form
    {
        public HospitalDashboard()
        {
            InitializeComponent();
        }
        private void HospitalDashboard_Load(object sender, EventArgs e)
        {
            UpdateLiveDateTime();

            LoadOverviewForm();
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateLiveDateTime();
        }

        private void UpdateLiveDateTime()
        {
            lblDateTime.Text = "⏰ " + DateTime.Now.ToString("hh:mm:ss tt") + "  |  📅 " + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (!(sender is Button clickedButton)) return;

            try
            {
                // Indicator Setup
                pnlNavIndicator.Visible = true;
                pnlNavIndicator.Height = clickedButton.Height;
                pnlNavIndicator.Top = clickedButton.Top;

                ResetButtonStyles();
                clickedButton.BackColor = Color.FromArgb(51, 65, 85);
                clickedButton.ForeColor = Color.FromArgb(56, 189, 248);

                string txt = clickedButton.Text.Trim();
                if (txt.Contains("Dashboard Overview")) lblSubTitle.Text = "Dashboard Overview";
                else if (txt.Contains("Patient")) lblSubTitle.Text = "Patient Registration";
                else if (txt.Contains("Doctor Registration")) lblSubTitle.Text = "Doctor Registration";
                else if (txt.Contains("Dashboard")) lblSubTitle.Text = "Doctor Dashboard";
                else if (txt.Contains("Prescription")) lblSubTitle.Text = "Prescription Report";
                else lblSubTitle.Text = txt;

                if (clickedButton.Name == "btnOverview" || txt.Contains("Dashboard Overview"))
                {
                    LoadOverviewForm();
                }
                else if (clickedButton == btnPatientReg) {
                    ShowPlaceholder("Patient Registration Engine");
                    var setDashboard = new HMS.Form2();
                    setDashboard.TopLevel = false;
                    setDashboard.FormBorderStyle = FormBorderStyle.None;
                    setDashboard.Dock = DockStyle.Fill;
                    pnlMainDisplay.Controls.Clear();
                    pnlMainDisplay.Controls.Add(setDashboard);
                    setDashboard.Show();

                }
                else if (clickedButton == btnDocReg) {
                    ShowPlaceholder("Doctor Management Directory");
                    var setDashboard = new HMS.doctor_registration();
                    setDashboard.TopLevel = false;
                    setDashboard.FormBorderStyle = FormBorderStyle.None;
                    setDashboard.Dock = DockStyle.Fill;
                    pnlMainDisplay.Controls.Clear();
                    pnlMainDisplay.Controls.Add(setDashboard);
                    setDashboard.Show();


                }
                else if (clickedButton == btnDocDashboard) {
                    ShowPlaceholder("Live Doctor Hub Console");
                    var setDashboard = new hospital_management_system.DoctorSessionsForm();
                    setDashboard.TopLevel = false;
                    setDashboard.FormBorderStyle = FormBorderStyle.None;
                    setDashboard.Dock = DockStyle.Fill;
                    pnlMainDisplay.Controls.Clear();
                    pnlMainDisplay.Controls.Add(setDashboard);
                    setDashboard.Show();
                } 

                else if (clickedButton == btnPrescription)
                {
                    LoadDoctorHubForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Navigation Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButtonStyles()
        {
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(148, 163, 184);
                }
            }
        }

        private void LoadOverviewForm()
        {
            pnlMainDisplay.Controls.Clear();
            lblSubTitle.Text = "Dashboard Overview";

            Overview frmOverview = new Overview();
            frmOverview.TopLevel = false;
            frmOverview.FormBorderStyle = FormBorderStyle.None;
            frmOverview.Dock = DockStyle.Fill;

            pnlMainDisplay.Controls.Add(frmOverview);
            frmOverview.Show();
        }

        private void LoadDoctorHubForm()
        {
            pnlMainDisplay.Controls.Clear();
            lblSubTitle.Text = "Prescription Report";

            DoctorHub frmDoctorHub = new DoctorHub();

            frmDoctorHub.TopLevel = false;
            frmDoctorHub.FormBorderStyle = FormBorderStyle.None;
            frmDoctorHub.Dock = DockStyle.Fill;

            pnlMainDisplay.Controls.Add(frmDoctorHub);
            frmDoctorHub.Show();
            pnlMainDisplay.Controls.Add(frmDoctorHub);
            frmDoctorHub.Show();
        }

        public void LoadPatientRegistrationForm()
        {
            pnlMainDisplay.Controls.Clear();
            lblSubTitle.Text = "Patient Registration";

            // Setup Navigation Indicator and styling for Patient Registration button
            pnlNavIndicator.Visible = true;
            pnlNavIndicator.Height = btnPatientReg.Height;
            pnlNavIndicator.Top = btnPatientReg.Top;

            ResetButtonStyles();
            btnPatientReg.BackColor = Color.FromArgb(51, 65, 85);
            btnPatientReg.ForeColor = Color.FromArgb(56, 189, 248);

            var setDashboard = new HMS.Form2();
            setDashboard.TopLevel = false;
            setDashboard.FormBorderStyle = FormBorderStyle.None;
            setDashboard.Dock = DockStyle.Fill;
            
            pnlMainDisplay.Controls.Add(setDashboard);
            setDashboard.Show();
        }

        private void ShowPlaceholder(string sectionName)
        {
            pnlMainDisplay.Controls.Clear();
            Label lbl = new Label { Text = "🚀 " + sectionName + " Module Active.", ForeColor = Color.FromArgb(148, 163, 184), Font = new Font("Segoe UI", 14), AutoSize = true, Location = new Point(30, 30) };
            pnlMainDisplay.Controls.Add(lbl);
        }

        private void pnlMainDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
