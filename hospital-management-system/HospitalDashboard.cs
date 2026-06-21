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

            // 🚀 ඇප් එක ඕපන් වෙද්දීම කෙළින්ම Overview Form එක පැනල් එක ඇතුළට ලෝඩ් කරනවා
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

                // 🎛️ බටන්ස් ක්ලික් කරද්දී වෙනස් වන ලොජික් එක
                if (clickedButton.Name == "btnOverview" || txt.Contains("Dashboard Overview"))
                {
                    LoadOverviewForm(); // 🏠 ආයෙත් Overview එක එබුවොත් ඒක පැනල් එකට ලෝඩ් වෙනවා
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

                // 📄 🆕 මෙන්න මෙතන තිබ්බ තාවකාලික ShowPlaceholder එක අයින් කරලා කෙළින්ම DoctorHub එක ලෝඩ් කරන මෙතඩ් එක කෝල් කලා:
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

        // 🔄 Overview Form එක Dashboard එක ඇතුළේ පෙන්වන මෙතඩ් එක
        private void LoadOverviewForm()
        {
            pnlMainDisplay.Controls.Clear();
            lblSubTitle.Text = "Dashboard Overview";

            Overview frmOverview = new Overview();
            frmOverview.TopLevel = false;            // TopLevel Window එකක් නෙවෙයි කියලා කියනවා
            frmOverview.FormBorderStyle = FormBorderStyle.None; // බෝඩර්ස් අයින් කරනවා
            frmOverview.Dock = DockStyle.Fill;       // පැනල් එකේ සයිස් එකටම සෙට් කරනවා

            pnlMainDisplay.Controls.Add(frmOverview);
            frmOverview.Show();
        }

        // 🔄 🆕 DoctorHub Form එක Dashboard එක ඇතුළට ඔබ්බවා පෙන්වන අලුත් මෙතඩ් එක
        private void LoadDoctorHubForm()
        {
            // 1. පැනල් එකේ දැනට පේන්න තියෙන දේවල් (Overview හෝ වෙනත් ඒවා) ඔක්කොම අයින් කරනවා
            pnlMainDisplay.Controls.Clear();
            lblSubTitle.Text = "Prescription Report";

            // 2. DoctorHub ෆෝම් එකේ අලුත් Object එකක් ක්‍රියේට් කරනවා
            DoctorHub frmDoctorHub = new DoctorHub();

            // 3. ⚠️ Form එකක් Panel එකක් ඇතුළට බස්සන්න අනිවාර්යයෙන්ම මේ ටික ඕනේ:
            frmDoctorHub.TopLevel = false;                  // සැබෑ Window එකක් නෙවෙයි කියලා කියනවා
            frmDoctorHub.FormBorderStyle = FormBorderStyle.None; // ඉහළ තියෙන Close/Minimize බෝඩර්ස් අයින් කරනවා
            frmDoctorHub.Dock = DockStyle.Fill;             // මැද තියෙන පැනල් එකේ සයිස් එකටම Fit කරනවා

            // 4. පැනල් එකේ Controls ලයිස්තුවට මේ ෆෝම් එක එකතු කරලා පෙන්වනවා
            pnlMainDisplay.Controls.Add(frmDoctorHub);
            frmDoctorHub.Show();
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
