using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hospital_management_system
{
    public partial class DoctorSessionsForm : Form
    {
        private Doctor _selectedDoctor = null;

        public DoctorSessionsForm()
        {
            InitializeComponent();
            this.Load += DoctorSessionsForm_Load;
            dgvSessions.CellContentClick += dgvSessions_CellContentClick;
        }

        private void DoctorSessionsForm_Load(object sender, EventArgs e)
        {
            RefreshStats();
            PopulateDoctorsList();
            
            // If doctors exist, select the first one by default
            var doctors = DataManager.GetDoctors();
            if (doctors.Count > 0)
            {
                ViewSessionsForDoctor(doctors[0]);
            }
        }

        private void RefreshStats()
        {
            lblTotalDoctors.Text = "Total Doctors: " + DataManager.GetDoctors().Count;
            lblTotalSessions.Text = "Active Sessions: " + DataManager.GetSessions().Count;
        }

        private void PopulateDoctorsList()
        {
            flowDoctors.Controls.Clear();
            var doctors = DataManager.GetDoctors();

            foreach (var doc in doctors)
            {
                // Create Doctor Bar Card
                Panel card = new Panel
                {
                    Size = new Size(500, 130),
                    BackColor = Color.FromArgb(30, 41, 59), // Slate 800
                    Margin = new Padding(0, 0, 0, 15)
                };

                // Initials Circular Badge
                Label lblBadge = new Label
                {
                    Text = GetInitials(doc.Name),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    Size = new Size(42, 42),
                    Location = new Point(15, 15),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                // Make the badge circular via Custom Paint
                lblBadge.Paint += (s, pe) =>
                {
                    pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (var brush = new SolidBrush(Color.FromArgb(71, 85, 105))) // Slate 600
                    {
                        pe.Graphics.FillEllipse(brush, 0, 0, lblBadge.Width - 1, lblBadge.Height - 1);
                    }
                    TextRenderer.DrawText(pe.Graphics, lblBadge.Text, lblBadge.Font,
                        new Rectangle(0, 0, lblBadge.Width, lblBadge.Height),
                        Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                };

                // Doctor Name
                Label lblName = new Label
                {
                    Text = doc.Name,
                    Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(241, 245, 249), // Slate 100
                    Location = new Point(70, 12),
                    Size = new Size(410, 22),
                    AutoEllipsis = true
                };

                // Specialty & Department
                Label lblSpecialty = new Label
                {
                    Text = doc.Specialty + " | " + doc.Department,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(148, 163, 184), // Slate 400
                    Location = new Point(70, 36),
                    Size = new Size(410, 18),
                    AutoEllipsis = true
                };

                // Room Info
                Label lblRoom = new Label
                {
                    Text = "Default Location: " + doc.Room,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                    ForeColor = Color.FromArgb(100, 116, 139), // Slate 500
                    Location = new Point(70, 54),
                    Size = new Size(410, 18),
                    AutoEllipsis = true
                };

                // Action Buttons
                Button btnView = CreateFlatButton("View Sessions", Color.FromArgb(59, 130, 246), new Point(70, 80));
                Button btnAdd = CreateFlatButton("Add Session", Color.FromArgb(16, 185, 129), new Point(205, 80));
                Button btnDelete = CreateFlatButton("Delete Session", Color.FromArgb(239, 68, 68), new Point(340, 80));

                // Bind events
                Doctor targetDoc = doc; // local copy for closure
                btnView.Click += (s, e) => ViewSessionsForDoctor(targetDoc);
                btnAdd.Click += (s, e) => AddSessionForDoctor(targetDoc);
                btnDelete.Click += (s, e) => DeleteSessionForDoctor(targetDoc);

                // Add controls to Card
                card.Controls.Add(lblBadge);
                card.Controls.Add(lblName);
                card.Controls.Add(lblSpecialty);
                card.Controls.Add(lblRoom);
                card.Controls.Add(btnView);
                card.Controls.Add(btnAdd);
                card.Controls.Add(btnDelete);

                // Add Card to Flow Panel
                flowDoctors.Controls.Add(card);
            }
        }

        private Button CreateFlatButton(string text, Color backColor, Point location)
        {
            Button btn = new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Size = new Size(125, 32),
                Location = location,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "DR";
            string clean = name.Replace("Dr.", "").Trim();
            var parts = clean.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return "DR";
            if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private void ViewSessionsForDoctor(Doctor doctor)
        {
            _selectedDoctor = doctor;
            lblDoctorTitle.Text = "Schedule for " + doctor.Name;
            lblDoctorSpecialty.Text = doctor.Specialty + " | " + doctor.Department + " | Location: " + doctor.Room;

            BindSessionsGrid();
        }

        private void BindSessionsGrid()
        {
            if (_selectedDoctor == null) return;

            var sessions = DataManager.GetSessionsForDoctor(_selectedDoctor.Id);

            dgvSessions.Columns.Clear();
            dgvSessions.AutoGenerateColumns = false;

            if (sessions.Count == 0)
            {
                dgvSessions.Visible = false;
                lblNoSessions.Visible = true;
            }
            else
            {
                dgvSessions.Visible = true;
                lblNoSessions.Visible = false;

                // Columns configuration
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Session ID", Width = 90 });
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SessionDateFormatted", HeaderText = "Date", Width = 110 });
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartTime", HeaderText = "Start", Width = 90 });
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EndTime", HeaderText = "End", Width = 90 });
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Room", HeaderText = "Room", Width = 80 });
                dgvSessions.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaxPatients", HeaderText = "Limit", Width = 70 });
                dgvSessions.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "PlaceAppointment",
                    HeaderText = "Place Appointment",
                    Text = "New Apt.",
                    UseColumnTextForButtonValue = true,
                    Width = 150,
                    FlatStyle = FlatStyle.Flat,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = Color.FromArgb(16, 185, 129),
                        ForeColor = Color.White,
                        SelectionBackColor = Color.FromArgb(16, 185, 129),
                        SelectionForeColor = Color.White,
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                });

                // Map list
                var displayList = sessions.Select(s => new {
                    s.Id,
                    s.DoctorId,
                    SessionDateFormatted = s.SessionDate.ToString("yyyy-MM-dd"),
                    s.StartTime,
                    s.EndTime,
                    s.Room,
                    s.MaxPatients
                }).ToList();

                dgvSessions.DataSource = displayList;
            }
        }

        private void AddSessionForDoctor(Doctor doctor)
        {
            // Auto select the doctor first
            ViewSessionsForDoctor(doctor);

            using (var form = new AddSessionForm(doctor))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    DataManager.AddSession(form.CreatedSession);
                    RefreshStats();
                    BindSessionsGrid();
                    MessageBox.Show("Session successfully scheduled!", "Session Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteSessionForDoctor(Doctor doctor)
        {
            // Auto select the doctor first
            ViewSessionsForDoctor(doctor);

            if (dgvSessions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session row from the table on the right to delete.",
                    "No Session Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvSessions.SelectedRows[0];
            // The first column is Session ID
            string sessionId = selectedRow.Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(sessionId)) return;

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to cancel session {sessionId} for {doctor.Name}?",
                "Confirm Session Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (DataManager.DeleteSession(sessionId))
                {
                    RefreshStats();
                    BindSessionsGrid();
                    MessageBox.Show("Session successfully deleted/cancelled.", "Session Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = null;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Form1)
                {
                    loginForm = (Form1)openForm;
                    break;
                }
            }

            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                loginForm = new Form1();
                loginForm.Show();
            }

            this.Close();
        }

        private void dgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSessions.Columns[e.ColumnIndex].Name == "PlaceAppointment")
            {
                var sessionId = dgvSessions.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(sessionId) && _selectedDoctor != null)
                {
                    var session = DataManager.GetSessions().Find(s => s.Id == sessionId);
                    if (session != null)
                    {
                        using (var form = new PlaceAppointmentForm(session, _selectedDoctor))
                        {
                            form.ShowDialog(this);
                        }
                    }
                }
            }
        }

        private void dgvSessions_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
