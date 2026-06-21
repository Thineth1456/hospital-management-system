using System.Windows.Forms;
using System.Drawing;

namespace hospital_management_system
{
    partial class PlaceAppointmentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlDoctorSession;
        private Label lblDoctor;
        private Label lblSessionTime;
        private Label lblRoom;
        
        private Panel pnlPatientSearch;
        private Label lblSearchTitle;
        private Label lblPatientId;
        private TextBox txtPatientId;
        private Button btnSearch;
        private Label lblSearchResultStatus;
        
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Label lblPatientAge;
        private TextBox txtPatientAge;
        private Label lblPatientGender;
        private ComboBox cmbPatientGender;
        private Label lblPatientContact;
        private TextBox txtPatientContact;
        private Label lblPatientNotice;

        private Panel pnlAppointmentInfo;
        private Label lblAppointmentNoTitle;
        private Label lblAppointmentNo;

        private Button btnConfirm;
        private Button btnCancel;

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
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.pnlDoctorSession = new Panel();
            this.lblDoctor = new Label();
            this.lblSessionTime = new Label();
            this.lblRoom = new Label();
            
            this.pnlPatientSearch = new Panel();
            this.lblSearchTitle = new Label();
            this.lblPatientId = new Label();
            this.txtPatientId = new TextBox();
            this.btnSearch = new Button();
            this.lblSearchResultStatus = new Label();
            
            this.lblPatientName = new Label();
            this.txtPatientName = new TextBox();
            this.lblPatientAge = new Label();
            this.txtPatientAge = new TextBox();
            this.lblPatientGender = new Label();
            this.cmbPatientGender = new ComboBox();
            this.lblPatientContact = new Label();
            this.txtPatientContact = new TextBox();
            this.lblPatientNotice = new Label();

            this.pnlAppointmentInfo = new Panel();
            this.lblAppointmentNoTitle = new Label();
            this.lblAppointmentNo = new Label();

            this.btnConfirm = new Button();
            this.btnCancel = new Button();

            this.pnlDoctorSession.SuspendLayout();
            this.pnlPatientSearch.SuspendLayout();
            this.pnlAppointmentInfo.SuspendLayout();
            this.SuspendLayout();

            // Form styling
            this.ClientSize = new Size(520, 680);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Place Patient Appointment";
            this.BackColor = Color.FromArgb(15, 23, 42); // Slate 900
            this.ForeColor = Color.FromArgb(241, 245, 249); // Slate 100
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // lblTitle
            this.lblTitle.Text = "PLACE APPOINTMENT";
            this.lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(59, 130, 246); // Modern Blue
            this.lblTitle.Location = new Point(25, 20);
            this.lblTitle.Size = new Size(470, 32);
            this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblSubtitle
            this.lblSubtitle.Text = "Search for a patient and confirm their appointment details below.";
            this.lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184); // Slate 400
            this.lblSubtitle.Location = new Point(25, 52);
            this.lblSubtitle.Size = new Size(470, 20);

            // pnlDoctorSession
            this.pnlDoctorSession.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.pnlDoctorSession.Location = new Point(25, 80);
            this.pnlDoctorSession.Size = new Size(470, 95);
            this.pnlDoctorSession.Controls.Add(this.lblDoctor);
            this.pnlDoctorSession.Controls.Add(this.lblSessionTime);
            this.pnlDoctorSession.Controls.Add(this.lblRoom);

            // lblDoctor
            this.lblDoctor.Text = "Doctor: Loading Name...";
            this.lblDoctor.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.lblDoctor.ForeColor = Color.White;
            this.lblDoctor.Location = new Point(15, 12);
            this.lblDoctor.Size = new Size(440, 22);

            // lblSessionTime
            this.lblSessionTime.Text = "Date & Time: Loading Slot...";
            this.lblSessionTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            this.lblSessionTime.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblSessionTime.Location = new Point(15, 38);
            this.lblSessionTime.Size = new Size(440, 18);

            // lblRoom
            this.lblRoom.Text = "Location: Loading Room...";
            this.lblRoom.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            this.lblRoom.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblRoom.Location = new Point(15, 60);
            this.lblRoom.Size = new Size(440, 18);

            // pnlPatientSearch
            this.pnlPatientSearch.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.pnlPatientSearch.Location = new Point(25, 190);
            this.pnlPatientSearch.Size = new Size(470, 310);
            this.pnlPatientSearch.Controls.Add(this.lblSearchTitle);
            this.pnlPatientSearch.Controls.Add(this.lblPatientId);
            this.pnlPatientSearch.Controls.Add(this.txtPatientId);
            this.pnlPatientSearch.Controls.Add(this.btnSearch);
            this.pnlPatientSearch.Controls.Add(this.lblSearchResultStatus);
            this.pnlPatientSearch.Controls.Add(this.lblPatientName);
            this.pnlPatientSearch.Controls.Add(this.txtPatientName);
            this.pnlPatientSearch.Controls.Add(this.lblPatientAge);
            this.pnlPatientSearch.Controls.Add(this.txtPatientAge);
            this.pnlPatientSearch.Controls.Add(this.lblPatientGender);
            this.pnlPatientSearch.Controls.Add(this.cmbPatientGender);
            this.pnlPatientSearch.Controls.Add(this.lblPatientContact);
            this.pnlPatientSearch.Controls.Add(this.txtPatientContact);
            this.pnlPatientSearch.Controls.Add(this.lblPatientNotice);

            // lblSearchTitle
            this.lblSearchTitle.Text = "PATIENT INFORMATION";
            this.lblSearchTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.lblSearchTitle.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblSearchTitle.Location = new Point(15, 10);
            this.lblSearchTitle.Size = new Size(440, 15);

            // lblPatientId
            this.lblPatientId.Text = "Search Patient ID";
            this.lblPatientId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPatientId.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblPatientId.Location = new Point(15, 30);
            this.lblPatientId.Size = new Size(150, 18);

            // txtPatientId
            this.txtPatientId.BackColor = Color.FromArgb(15, 23, 42); // Darker input
            this.txtPatientId.ForeColor = Color.White;
            this.txtPatientId.Font = new Font("Segoe UI", 10F);
            this.txtPatientId.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientId.Location = new Point(15, 50);
            this.txtPatientId.Size = new Size(290, 25);

            // btnSearch
            this.btnSearch.Text = "Search ID";
            this.btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSearch.BackColor = Color.FromArgb(59, 130, 246); // Blue
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new Point(315, 49);
            this.btnSearch.Size = new Size(140, 27);
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // lblSearchResultStatus
            this.lblSearchResultStatus.Text = "Enter an ID (e.g. P101) to search, or register a new patient.";
            this.lblSearchResultStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            this.lblSearchResultStatus.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblSearchResultStatus.Location = new Point(15, 82);
            this.lblSearchResultStatus.Size = new Size(440, 18);

            // lblPatientName
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPatientName.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblPatientName.Location = new Point(15, 110);
            this.lblPatientName.Size = new Size(210, 18);

            // txtPatientName
            this.txtPatientName.BackColor = Color.FromArgb(15, 23, 42);
            this.txtPatientName.ForeColor = Color.White;
            this.txtPatientName.Font = new Font("Segoe UI", 10F);
            this.txtPatientName.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientName.Location = new Point(15, 130);
            this.txtPatientName.Size = new Size(210, 25);

            // lblPatientAge
            this.lblPatientAge.Text = "Age";
            this.lblPatientAge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPatientAge.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblPatientAge.Location = new Point(240, 110);
            this.lblPatientAge.Size = new Size(80, 18);

            // txtPatientAge
            this.txtPatientAge.BackColor = Color.FromArgb(15, 23, 42);
            this.txtPatientAge.ForeColor = Color.White;
            this.txtPatientAge.Font = new Font("Segoe UI", 10F);
            this.txtPatientAge.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientAge.Location = new Point(240, 130);
            this.txtPatientAge.Size = new Size(80, 25);

            // lblPatientGender
            this.lblPatientGender.Text = "Gender";
            this.lblPatientGender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPatientGender.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblPatientGender.Location = new Point(335, 110);
            this.lblPatientGender.Size = new Size(120, 18);

            // cmbPatientGender
            this.cmbPatientGender.BackColor = Color.FromArgb(15, 23, 42);
            this.cmbPatientGender.ForeColor = Color.White;
            this.cmbPatientGender.Font = new Font("Segoe UI", 9.5F);
            this.cmbPatientGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPatientGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cmbPatientGender.SelectedIndex = 0;
            this.cmbPatientGender.Location = new Point(335, 130);
            this.cmbPatientGender.Size = new Size(120, 25);

            // lblPatientContact
            this.lblPatientContact.Text = "Contact / Telephone Number";
            this.lblPatientContact.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblPatientContact.ForeColor = Color.FromArgb(191, 203, 219);
            this.lblPatientContact.Location = new Point(15, 170);
            this.lblPatientContact.Size = new Size(440, 18);

            // txtPatientContact
            this.txtPatientContact.BackColor = Color.FromArgb(15, 23, 42);
            this.txtPatientContact.ForeColor = Color.White;
            this.txtPatientContact.Font = new Font("Segoe UI", 10F);
            this.txtPatientContact.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientContact.Location = new Point(15, 190);
            this.txtPatientContact.Size = new Size(440, 25);

            // lblPatientNotice
            this.lblPatientNotice.Text = "* If the patient is not in the system, you can type their information above to automatically register them on confirmation.";
            this.lblPatientNotice.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            this.lblPatientNotice.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblPatientNotice.Location = new Point(15, 230);
            this.lblPatientNotice.Size = new Size(440, 65);

            // pnlAppointmentInfo
            this.pnlAppointmentInfo.BackColor = Color.FromArgb(30, 41, 59); // Slate 800
            this.pnlAppointmentInfo.Location = new Point(25, 515);
            this.pnlAppointmentInfo.Size = new Size(470, 75);
            this.pnlAppointmentInfo.Controls.Add(this.lblAppointmentNoTitle);
            this.pnlAppointmentInfo.Controls.Add(this.lblAppointmentNo);

            // lblAppointmentNoTitle
            this.lblAppointmentNoTitle.Text = "APPOINTMENT NUMBER FOR SESSION:";
            this.lblAppointmentNoTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblAppointmentNoTitle.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblAppointmentNoTitle.Location = new Point(15, 25);
            this.lblAppointmentNoTitle.Size = new Size(280, 25);
            this.lblAppointmentNoTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblAppointmentNo
            this.lblAppointmentNo.Text = "#0";
            this.lblAppointmentNo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblAppointmentNo.ForeColor = Color.FromArgb(16, 185, 129); // Emerald Green
            this.lblAppointmentNo.Location = new Point(290, 8);
            this.lblAppointmentNo.Size = new Size(165, 55);
            this.lblAppointmentNo.TextAlign = ContentAlignment.MiddleRight;

            // btnConfirm
            this.btnConfirm.Text = "Confirm Appointment";
            this.btnConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnConfirm.BackColor = Color.FromArgb(16, 185, 129); // Green
            this.btnConfirm.ForeColor = Color.White;
            this.btnConfirm.FlatStyle = FlatStyle.Flat;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Location = new Point(275, 610);
            this.btnConfirm.Size = new Size(220, 40);
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.BackColor = Color.FromArgb(71, 85, 105); // Gray-Blue
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new Point(25, 610);
            this.btnCancel.Size = new Size(220, 40);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add Controls to Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlDoctorSession);
            this.Controls.Add(this.pnlPatientSearch);
            this.Controls.Add(this.pnlAppointmentInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            this.pnlDoctorSession.ResumeLayout(false);
            this.pnlPatientSearch.ResumeLayout(false);
            this.pnlPatientSearch.PerformLayout();
            this.pnlAppointmentInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
