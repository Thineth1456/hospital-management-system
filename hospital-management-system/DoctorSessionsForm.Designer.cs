using System.Windows.Forms;
using System.Drawing;

namespace hospital_management_system
{
    partial class DoctorSessionsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;
        private FlowLayoutPanel flowDoctors;
        private Panel pnlRight;
        private Panel pnlStats;
        private Label lblStatsTitle;
        private Label lblTotalDoctors;
        private Label lblTotalSessions;
        private Label lblDoctorTitle;
        private Label lblDoctorSpecialty;
        private DataGridView dgvSessions;
        private Label lblNoSessions;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new Panel();
            this.lblHeaderTitle = new Label();
            this.lblHeaderSubtitle = new Label();
            this.btnLogout = new Button();
            this.flowDoctors = new FlowLayoutPanel();
            this.pnlRight = new Panel();
            this.pnlStats = new Panel();
            this.lblStatsTitle = new Label();
            this.lblTotalDoctors = new Label();
            this.lblTotalSessions = new Label();
            this.lblDoctorTitle = new Label();
            this.lblDoctorSpecialty = new Label();
            this.dgvSessions = new DataGridView();
            this.lblNoSessions = new Label();
            
            this.pnlHeader.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();

            // DoctorSessionsForm
            this.ClientSize = new Size(1300, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System - Doctor Sessions Dashboard";
            this.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.ForeColor = Color.FromArgb(241, 245, 249); // Slate 100
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // pnlHeader
            this.pnlHeader.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;

            // lblHeaderTitle
            this.lblHeaderTitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = Color.FromArgb(59, 130, 246); // Modern Blue
            this.lblHeaderTitle.Location = new Point(20, 15);
            this.lblHeaderTitle.Size = new Size(500, 30);

            // lblHeaderSubtitle
            this.lblHeaderSubtitle.Text = "Doctor Schedule & Sessions Dashboard";
            this.lblHeaderSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblHeaderSubtitle.ForeColor = Color.FromArgb(148, 163, 184); // Slate 400
            this.lblHeaderSubtitle.Location = new Point(20, 45);
            this.lblHeaderSubtitle.Size = new Size(500, 20);

            // btnLogout
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnLogout.BackColor = Color.FromArgb(239, 68, 68); // Red
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Location = new Point(1060, 20);
            this.btnLogout.Size = new Size(100, 40);
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // flowDoctors
            this.flowDoctors.Dock = DockStyle.Left;
            this.flowDoctors.Width = 550;
            this.flowDoctors.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.flowDoctors.AutoScroll = true;
            this.flowDoctors.Padding = new Padding(15);

            // pnlRight
            this.pnlRight.Dock = DockStyle.Fill;
            this.pnlRight.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.pnlRight.Padding = new Padding(25);
            this.pnlRight.Controls.Add(this.pnlStats);
            this.pnlRight.Controls.Add(this.lblDoctorTitle);
            this.pnlRight.Controls.Add(this.lblDoctorSpecialty);
            this.pnlRight.Controls.Add(this.dgvSessions);
            this.pnlRight.Controls.Add(this.lblNoSessions);

            // pnlStats
            this.pnlStats.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.pnlStats.Height = 100;
            this.pnlStats.Location = new Point(25, 25);
            this.pnlStats.Width = 560;
            this.pnlStats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.pnlStats.Controls.Add(this.lblStatsTitle);
            this.pnlStats.Controls.Add(this.lblTotalDoctors);
            this.pnlStats.Controls.Add(this.lblTotalSessions);

            // lblStatsTitle
            this.lblStatsTitle.Text = "SYSTEM OVERVIEW";
            this.lblStatsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblStatsTitle.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblStatsTitle.Location = new Point(15, 10);
            this.lblStatsTitle.Size = new Size(200, 20);

            // lblTotalDoctors
            this.lblTotalDoctors.Text = "Total Doctors: 0";
            this.lblTotalDoctors.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTotalDoctors.ForeColor = Color.FromArgb(59, 130, 246); // Blue
            this.lblTotalDoctors.Location = new Point(15, 40);
            this.lblTotalDoctors.Size = new Size(240, 45);

            // lblTotalSessions
            this.lblTotalSessions.Text = "Active Sessions: 0";
            this.lblTotalSessions.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTotalSessions.ForeColor = Color.FromArgb(16, 185, 129); // Emerald Green
            this.lblTotalSessions.Location = new Point(280, 40);
            this.lblTotalSessions.Size = new Size(260, 45);

            // lblDoctorTitle
            this.lblDoctorTitle.Text = "Select a Doctor";
            this.lblDoctorTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblDoctorTitle.ForeColor = Color.White;
            this.lblDoctorTitle.Location = new Point(25, 150);
            this.lblDoctorTitle.Size = new Size(560, 35);
            this.lblDoctorTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblDoctorSpecialty
            this.lblDoctorSpecialty.Text = "Choose a doctor from the list to view or schedule sessions.";
            this.lblDoctorSpecialty.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDoctorSpecialty.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblDoctorSpecialty.Location = new Point(25, 185);
            this.lblDoctorSpecialty.Size = new Size(560, 25);
            this.lblDoctorSpecialty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // dgvSessions
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.BackgroundColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.dgvSessions.BorderStyle = BorderStyle.None;
            this.dgvSessions.ColumnHeadersHeight = 35;
            this.dgvSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSessions.Location = new Point(25, 230);
            this.dgvSessions.Size = new Size(550, 420);
            this.dgvSessions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.GridColor = Color.FromArgb(51, 65, 85); // Slate 700

            // Apply modern styles to DataGridView
            this.dgvSessions.EnableHeadersVisualStyles = false;
            this.dgvSessions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(71, 85, 105); // Slate 600
            this.dgvSessions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvSessions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvSessions.DefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.dgvSessions.DefaultCellStyle.ForeColor = Color.FromArgb(241, 245, 249);
            this.dgvSessions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246); // Blue
            this.dgvSessions.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvSessions.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            this.dgvSessions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42); // Slate 900

            // lblNoSessions
            this.lblNoSessions.Text = "No sessions scheduled for this doctor.";
            this.lblNoSessions.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            this.lblNoSessions.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblNoSessions.Location = new Point(25, 270);
            this.lblNoSessions.Size = new Size(550, 100);
            this.lblNoSessions.TextAlign = ContentAlignment.MiddleCenter;
            this.lblNoSessions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.lblNoSessions.Visible = false;

            // Load and layout
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.flowDoctors);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
