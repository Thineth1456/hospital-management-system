namespace hospital_management_system
{
    partial class Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblPatientCount = new System.Windows.Forms.Label();
            this.lblCard1Footer = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblDoctorCount = new System.Windows.Forms.Label();
            this.lblCard2Footer = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblIcuOccupancy = new System.Windows.Forms.Label();
            this.lblCard3Footer = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlLine3 = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCard1.Controls.Add(this.lblPatientCount);
            this.pnlCard1.Controls.Add(this.lblCard1Footer);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Controls.Add(this.pnlLine1);
            this.pnlCard1.Location = new System.Drawing.Point(30, 30);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(270, 140);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblPatientCount
            // 
            this.lblPatientCount.AutoSize = true;
            this.lblPatientCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPatientCount.ForeColor = System.Drawing.Color.White;
            this.lblPatientCount.Location = new System.Drawing.Point(15, 45);
            this.lblPatientCount.Text = "1,248";
            // 
            // lblCard1Footer
            // 
            this.lblCard1Footer.AutoSize = true;
            this.lblCard1Footer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCard1Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.lblCard1Footer.Location = new System.Drawing.Point(15, 105);
            this.lblCard1Footer.Text = "Active Inpatients";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCard1Title.Location = new System.Drawing.Point(15, 20);
            this.lblCard1Title.Text = "👥 Total Patients";
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 0);
            this.pnlLine1.Size = new System.Drawing.Size(270, 4);
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCard2.Controls.Add(this.lblDoctorCount);
            this.pnlCard2.Controls.Add(this.lblCard2Footer);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Controls.Add(this.pnlLine2);
            this.pnlCard2.Location = new System.Drawing.Point(330, 30);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(270, 140);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblDoctorCount
            // 
            this.lblDoctorCount.AutoSize = true;
            this.lblDoctorCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDoctorCount.ForeColor = System.Drawing.Color.White;
            this.lblDoctorCount.Location = new System.Drawing.Point(15, 45);
            this.lblDoctorCount.Text = "42 / 50";
            // 
            // lblCard2Footer
            // 
            this.lblCard2Footer.AutoSize = true;
            this.lblCard2Footer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCard2Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblCard2Footer.Location = new System.Drawing.Point(15, 105);
            this.lblCard2Footer.Text = "Available Staff";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCard2Title.Location = new System.Drawing.Point(15, 20);
            this.lblCard2Title.Text = "🩺 Doctors On Duty";
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine2.Location = new System.Drawing.Point(0, 0);
            this.pnlLine2.Size = new System.Drawing.Size(270, 4);
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCard3.Controls.Add(this.lblIcuOccupancy);
            this.pnlCard3.Controls.Add(this.lblCard3Footer);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Controls.Add(this.pnlLine3);
            this.pnlCard3.Location = new System.Drawing.Point(630, 30);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(270, 140);
            this.pnlCard3.TabIndex = 1;
            // 
            // lblIcuOccupancy
            // 
            this.lblIcuOccupancy.AutoSize = true;
            this.lblIcuOccupancy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblIcuOccupancy.ForeColor = System.Drawing.Color.White;
            this.lblIcuOccupancy.Location = new System.Drawing.Point(15, 45);
            this.lblIcuOccupancy.Text = "85%";
            // 
            // lblCard3Footer
            // 
            this.lblCard3Footer.AutoSize = true;
            this.lblCard3Footer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCard3Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblCard3Footer.Location = new System.Drawing.Point(15, 105);
            this.lblCard3Footer.Text = "12 Beds Available";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCard3Title.Location = new System.Drawing.Point(15, 20);
            this.lblCard3Title.Text = "🛏️ ICU Bed Occupancy";
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlLine3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine3.Location = new System.Drawing.Point(0, 0);
            this.pnlLine3.Size = new System.Drawing.Size(270, 4);
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.White;
            this.lblTableTitle.Location = new System.Drawing.Point(30, 210);
            this.lblTableTitle.Text = "📅 Recent Patient Appointments (Real-time Live)";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ForeColor = System.Drawing.Color.Black;
            this.dgvAppointments.Location = new System.Drawing.Point(30, 250);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.Size = new System.Drawing.Size(870, 350);
            this.dgvAppointments.TabIndex = 3;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(940, 640);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label lblCard1Footer;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblDoctorCount;
        private System.Windows.Forms.Label lblCard2Footer;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblIcuOccupancy;
        private System.Windows.Forms.Label lblCard3Footer;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel pnlLine3;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}