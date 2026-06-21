using System.Windows.Forms;
using System.Drawing;

namespace hospital_management_system
{
    partial class AddSessionForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDoctorName;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblStartTime;
        private ComboBox cmbStart;
        private Label lblEndTime;
        private ComboBox cmbEnd;
        private Label lblRoom;
        private TextBox txtRoom;
        private Label lblPatients;
        private NumericUpDown numPatients;
        private Button btnSave;
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
            this.lblDoctorName = new Label();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.lblStartTime = new Label();
            this.cmbStart = new ComboBox();
            this.lblEndTime = new Label();
            this.cmbEnd = new ComboBox();
            this.lblRoom = new Label();
            this.txtRoom = new TextBox();
            this.lblPatients = new Label();
            this.numPatients = new NumericUpDown();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPatients)).BeginInit();
            this.SuspendLayout();

            // Form styling
            this.ClientSize = new Size(420, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Add New Session";

            // lblTitle
            this.lblTitle.Text = "Schedule Session";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(16, 185, 129); // Emerald Green
            this.lblTitle.Location = new Point(25, 20);
            this.lblTitle.Size = new Size(370, 35);
            this.lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            // lblDoctorName
            this.lblDoctorName.Text = "Doctor: Dr. Olivia Bennett";
            this.lblDoctorName.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            this.lblDoctorName.ForeColor = Color.FromArgb(148, 163, 184); // Slate 400
            this.lblDoctorName.Location = new Point(25, 55);
            this.lblDoctorName.Size = new Size(370, 25);

            // lblDate
            this.lblDate.Text = "Session Date";
            this.lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblDate.Location = new Point(25, 95);
            this.lblDate.Size = new Size(370, 20);

            // dtpDate
            this.dtpDate.Font = new Font("Segoe UI", 10F);
            this.dtpDate.Format = DateTimePickerFormat.Short;
            this.dtpDate.Location = new Point(25, 120);
            this.dtpDate.Size = new Size(370, 30);

            // lblStartTime
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblStartTime.Location = new Point(25, 165);
            this.lblStartTime.Size = new Size(170, 20);

            // cmbStart
            this.cmbStart.Font = new Font("Segoe UI", 10F);
            this.cmbStart.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStart.Items.AddRange(new object[] {
                "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM",
                "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "01:00 PM", "01:30 PM",
                "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM",
                "05:00 PM"
            });
            this.cmbStart.SelectedIndex = 2; // Default 09:00 AM
            this.cmbStart.Location = new Point(25, 190);
            this.cmbStart.Size = new Size(170, 30);

            // lblEndTime
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblEndTime.Location = new Point(225, 165);
            this.lblEndTime.Size = new Size(170, 20);

            // cmbEnd
            this.cmbEnd.Font = new Font("Segoe UI", 10F);
            this.cmbEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEnd.Items.AddRange(new object[] {
                "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM",
                "12:00 PM", "12:30 PM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM",
                "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM",
                "06:00 PM", "06:30 PM", "07:00 PM"
            });
            this.cmbEnd.SelectedIndex = 4; // Default 11:00 AM or 12:00 PM (idx 6)
            this.cmbEnd.SelectedIndex = 6; // Default 12:00 PM
            this.cmbEnd.Location = new Point(225, 190);
            this.cmbEnd.Size = new Size(170, 30);

            // lblRoom
            this.lblRoom.Text = "Room / Clinic Number";
            this.lblRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRoom.Location = new Point(25, 235);
            this.lblRoom.Size = new Size(370, 20);

            // txtRoom
            this.txtRoom.Font = new Font("Segoe UI", 10F);
            this.txtRoom.Location = new Point(25, 260);
            this.txtRoom.Size = new Size(370, 30);
            this.txtRoom.BackColor = Color.FromArgb(30, 41, 59);
            this.txtRoom.ForeColor = Color.White;
            this.txtRoom.BorderStyle = BorderStyle.FixedSingle;

            // lblPatients
            this.lblPatients.Text = "Max Patients Limit";
            this.lblPatients.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblPatients.Location = new Point(25, 305);
            this.lblPatients.Size = new Size(370, 20);

            // numPatients
            this.numPatients.Font = new Font("Segoe UI", 10F);
            this.numPatients.Location = new Point(25, 330);
            this.numPatients.Size = new Size(370, 30);
            this.numPatients.Minimum = 1;
            this.numPatients.Maximum = 100;
            this.numPatients.Value = 15;
            this.numPatients.BackColor = Color.FromArgb(30, 41, 59);
            this.numPatients.ForeColor = Color.White;

            // btnSave
            this.btnSave.Text = "Save Session";
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.BackColor = Color.FromArgb(16, 185, 129); // Emerald Green
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new Point(225, 415);
            this.btnSave.Size = new Size(170, 40);
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.BackColor = Color.FromArgb(71, 85, 105); // Gray-Blue
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new Point(25, 415);
            this.btnCancel.Size = new Size(170, 40);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.cmbStart);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cmbEnd);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblPatients);
            this.Controls.Add(this.numPatients);
            this.Controls.Add(this.btnSave); 
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
