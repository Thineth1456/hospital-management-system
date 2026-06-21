namespace hospital_management_system
{
    partial class DoctorHub
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grpPatientInfo = new System.Windows.Forms.GroupBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.txtPrescription = new System.Windows.Forms.TextBox();
            this.btnSaveAndPrint = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.grpPatientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59))))); // Slate Header
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblSubTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(896, 120);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(29, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 46);
            this.lblTitle.Text = "Medical Record Entry & Form";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubTitle.Location = new System.Drawing.Point(32, 73);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(421, 23);
            this.lblSubTitle.Text = "Hospital Management System - Digital Prescription PDF";
            // 
            // grpPatientInfo
            // 
            this.grpPatientInfo.Controls.Add(this.lblPatientID);
            this.grpPatientInfo.Controls.Add(this.txtPatientID);
            this.grpPatientInfo.Controls.Add(this.lblPatientName);
            this.grpPatientInfo.Controls.Add(this.txtPatientName);
            this.grpPatientInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpPatientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248))))); // Sky Blue Accent
            this.grpPatientInfo.Location = new System.Drawing.Point(37, 153);
            this.grpPatientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPatientInfo.Name = "grpPatientInfo";
            this.grpPatientInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPatientInfo.Size = new System.Drawing.Size(823, 133);
            this.grpPatientInfo.TabIndex = 1;
            this.grpPatientInfo.TabStop = false;
            this.grpPatientInfo.Text = "Patient Information";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPatientID.ForeColor = System.Drawing.Color.White;
            this.lblPatientID.Location = new System.Drawing.Point(23, 53);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(97, 25);
            this.lblPatientID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientID.ForeColor = System.Drawing.Color.White;
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPatientID.Location = new System.Drawing.Point(126, 49);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(205, 32);
            this.txtPatientID.TabIndex = 1;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Location = new System.Drawing.Point(377, 53);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(129, 25);
            this.lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.ForeColor = System.Drawing.Color.White;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPatientName.Location = new System.Drawing.Point(503, 49);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(297, 32);
            this.txtPatientName.TabIndex = 3;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiagnosis.ForeColor = System.Drawing.Color.White;
            this.lblDiagnosis.Location = new System.Drawing.Point(37, 313);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(179, 28);
            this.lblDiagnosis.Text = "Clinical Diagnosis";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnosis.ForeColor = System.Drawing.Color.White;
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiagnosis.Location = new System.Drawing.Point(37, 353);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnosis.Size = new System.Drawing.Size(822, 105);
            this.txtDiagnosis.TabIndex = 3;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrescription.ForeColor = System.Drawing.Color.White;
            this.lblPrescription.Location = new System.Drawing.Point(37, 487);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(257, 28);
            this.lblPrescription.Text = "Rx (Prescribed Medicines)";
            // 
            // txtPrescription
            // 
            this.txtPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrescription.ForeColor = System.Drawing.Color.White;
            this.txtPrescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrescription.Location = new System.Drawing.Point(37, 527);
            this.txtPrescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrescription.Multiline = true;
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrescription.Size = new System.Drawing.Size(822, 212);
            this.txtPrescription.TabIndex = 5;
            // 
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233))))); // Vibrant Cyan/Blue
            this.btnSaveAndPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndPrint.FlatAppearance.BorderSize = 0;
            this.btnSaveAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveAndPrint.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndPrint.Location = new System.Drawing.Point(574, 767);
            this.btnSaveAndPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(286, 60);
            this.btnSaveAndPrint.TabIndex = 6;
            this.btnSaveAndPrint.Text = "💾 Save & Generate PDF";
            this.btnSaveAndPrint.UseVisualStyleBackColor = false;
            this.btnSaveAndPrint.Click += new System.EventHandler(this.BtnSaveAndPrint_Click); // Capital B සාදා ඇත
            // 
            // DoctorHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42))))); // Premium Midnight Black
            this.ClientSize = new System.Drawing.Size(896, 855);
            this.Controls.Add(this.btnSaveAndPrint);
            this.Controls.Add(this.txtPrescription);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.grpPatientInfo);
            this.Controls.Add(this.pnlTopBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoctorHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMS - Medical Record Entry";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.grpPatientInfo.ResumeLayout(false);
            this.grpPatientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // 🛡️ UI Controls Declarations
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox grpPatientInfo;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.Button btnSaveAndPrint;
    }
}
