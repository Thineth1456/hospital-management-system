using System;

namespace hospital_management_system
{
    partial class HospitalDashboard
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
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPatientReg = new System.Windows.Forms.Button();
            this.btnDocReg = new System.Windows.Forms.Button();
            this.btnDocDashboard = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSidebar.Controls.Add(this.pnlNavIndicator);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Controls.Add(this.btnPatientReg);
            this.pnlSidebar.Controls.Add(this.btnDocReg);
            this.pnlSidebar.Controls.Add(this.btnDocDashboard);
            this.pnlSidebar.Controls.Add(this.btnPrescription);
            this.pnlSidebar.Controls.Add(this.btnOverview);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(347, 886);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.pnlNavIndicator.Location = new System.Drawing.Point(0, 148);
            this.pnlNavIndicator.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(8, 62);
            this.pnlNavIndicator.TabIndex = 1;
            this.pnlNavIndicator.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "🏥 CarePlus Hospital";
            // 
            // btnPatientReg
            // 
            this.btnPatientReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientReg.FlatAppearance.BorderSize = 0;
            this.btnPatientReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientReg.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnPatientReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnPatientReg.Location = new System.Drawing.Point(8, 148);
            this.btnPatientReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientReg.Name = "btnPatientReg";
            this.btnPatientReg.Size = new System.Drawing.Size(339, 62);
            this.btnPatientReg.TabIndex = 3;
            this.btnPatientReg.Text = "   👤  Patient Registration";
            this.btnPatientReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientReg.UseVisualStyleBackColor = true;
            this.btnPatientReg.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnDocReg
            // 
            this.btnDocReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocReg.FlatAppearance.BorderSize = 0;
            this.btnDocReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocReg.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDocReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnDocReg.Location = new System.Drawing.Point(8, 222);
            this.btnDocReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocReg.Name = "btnDocReg";
            this.btnDocReg.Size = new System.Drawing.Size(339, 62);
            this.btnDocReg.TabIndex = 4;
            this.btnDocReg.Text = "   🩺  Doctor Registration";
            this.btnDocReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocReg.UseVisualStyleBackColor = true;
            this.btnDocReg.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnDocDashboard
            // 
            this.btnDocDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocDashboard.FlatAppearance.BorderSize = 0;
            this.btnDocDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnDocDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnDocDashboard.Location = new System.Drawing.Point(8, 295);
            this.btnDocDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocDashboard.Name = "btnDocDashboard";
            this.btnDocDashboard.Size = new System.Drawing.Size(339, 62);
            this.btnDocDashboard.TabIndex = 5;
            this.btnDocDashboard.Text = "   📊  Doctor Dashboard";
            this.btnDocDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocDashboard.UseVisualStyleBackColor = true;
            this.btnDocDashboard.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescription.FlatAppearance.BorderSize = 0;
            this.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnPrescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnPrescription.Location = new System.Drawing.Point(8, 369);
            this.btnPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(339, 62);
            this.btnPrescription.TabIndex = 6;
            this.btnPrescription.Text = "   📄  Prescription Report";
            this.btnPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnOverview.Location = new System.Drawing.Point(8, 468);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(339, 62);
            this.btnOverview.TabIndex = 7;
            this.btnOverview.Text = "   🏠  Dashboard Overview";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(347, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1253, 98);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblDateTime.Location = new System.Drawing.Point(853, 34);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(367, 31);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "⏰ 00:00:00 PM  |  📅 2026-01-01";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 28);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(286, 37);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Dashboard Overview";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainDisplay.Location = new System.Drawing.Point(347, 98);
            this.pnlMainDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(1253, 788);
            this.pnlMainDisplay.TabIndex = 2;
            this.pnlMainDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainDisplay_Paint);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(804, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HospitalDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1600, 886);
            this.Controls.Add(this.pnlMainDisplay);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HospitalDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarePlus Hospital Management System";
            this.Load += new System.EventHandler(this.HospitalDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPatientReg;
        private System.Windows.Forms.Button btnDocReg;
        private System.Windows.Forms.Button btnDocDashboard;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnOverview; // 🆕 Global Variable එකක් විදිහට එකතු කර ඇත
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlMainDisplay;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Button btnLogout;
    }
}