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
            this.btnOverview = new System.Windows.Forms.Button(); // 🆕 Overview බටන් එක Declare කිරීම
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
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
            this.pnlSidebar.Controls.Add(this.btnOverview); // 🆕 පැනල් එකට බටන් එක ඇතුළත් කිරීම
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.pnlNavIndicator.Location = new System.Drawing.Point(0, 120);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(6, 50);
            this.pnlNavIndicator.TabIndex = 1;
            this.pnlNavIndicator.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 30);
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
            this.btnPatientReg.Location = new System.Drawing.Point(6, 120);
            this.btnPatientReg.Name = "btnPatientReg";
            this.btnPatientReg.Size = new System.Drawing.Size(254, 50);
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
            this.btnDocReg.Location = new System.Drawing.Point(6, 180);
            this.btnDocReg.Name = "btnDocReg";
            this.btnDocReg.Size = new System.Drawing.Size(254, 50);
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
            this.btnDocDashboard.Location = new System.Drawing.Point(6, 240);
            this.btnDocDashboard.Name = "btnDocDashboard";
            this.btnDocDashboard.Size = new System.Drawing.Size(254, 50);
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
            this.btnPrescription.Location = new System.Drawing.Point(6, 300);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(254, 50);
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
            this.btnOverview.Location = new System.Drawing.Point(6, 380); // 💡 අනිත් බටන් වලට වඩා පල්ලෙහායින් සෙට් කර ඇත
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(254, 50);
            this.btnOverview.TabIndex = 7;
            this.btnOverview.Text = "   🏠  Dashboard Overview";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(260, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(940, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblDateTime.Location = new System.Drawing.Point(640, 28);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(275, 25);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "⏰ 00:00:00 PM  |  📅 2026-01-01";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(25, 23);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(217, 30);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Dashboard Overview";
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMainDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainDisplay.Location = new System.Drawing.Point(260, 80);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(940, 640);
            this.pnlMainDisplay.TabIndex = 2;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // HospitalDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlMainDisplay);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
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
    }
}