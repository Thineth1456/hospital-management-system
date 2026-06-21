namespace HMS
{
    partial class patient_registration_final
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            registationToolStripMenuItem = new ToolStripMenuItem();
            patientListToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            p_name = new TextBox();
            p_bday = new TextBox();
            male_button = new RadioButton();
            female_button = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            p_mail = new TextBox();
            p_contact = new TextBox();
            save = new Button();
            clear = new Button();
            label8 = new Label();
            p_id = new TextBox();
            panel1 = new Panel();
            buttonUpdate = new Button();
            p_home = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, registationToolStripMenuItem, patientListToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1611, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // registationToolStripMenuItem
            // 
            registationToolStripMenuItem.Name = "registationToolStripMenuItem";
            registationToolStripMenuItem.Size = new Size(103, 24);
            registationToolStripMenuItem.Text = "Registration";
            registationToolStripMenuItem.Click += registationToolStripMenuItem_Click;
            // 
            // patientListToolStripMenuItem
            // 
            patientListToolStripMenuItem.Name = "patientListToolStripMenuItem";
            patientListToolStripMenuItem.Size = new Size(94, 24);
            patientListToolStripMenuItem.Text = "Patient List";
            patientListToolStripMenuItem.Click += patientListToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(582, 72);
            label2.Name = "label2";
            label2.Size = new Size(410, 48);
            label2.TabIndex = 5;
            label2.Text = "PATIENT REGISTRATION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(453, 195);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 6;
            label1.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(453, 382);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 7;
            label3.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(453, 336);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(453, 290);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth";
            // 
            // p_name
            // 
            p_name.Location = new Point(646, 194);
            p_name.Name = "p_name";
            p_name.Size = new Size(465, 29);
            p_name.TabIndex = 10;
            // 
            // p_bday
            // 
            p_bday.Location = new Point(646, 290);
            p_bday.Name = "p_bday";
            p_bday.Size = new Size(465, 29);
            p_bday.TabIndex = 11;
            // 
            // male_button
            // 
            male_button.AutoSize = true;
            male_button.BackColor = Color.Transparent;
            male_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            male_button.ForeColor = Color.White;
            male_button.Location = new Point(646, 334);
            male_button.Name = "male_button";
            male_button.Size = new Size(80, 32);
            male_button.TabIndex = 12;
            male_button.TabStop = true;
            male_button.Text = "Male";
            male_button.UseVisualStyleBackColor = false;
            // 
            // female_button
            // 
            female_button.AutoSize = true;
            female_button.BackColor = Color.Transparent;
            female_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            female_button.ForeColor = Color.White;
            female_button.Location = new Point(780, 336);
            female_button.Name = "female_button";
            female_button.Size = new Size(100, 32);
            female_button.TabIndex = 13;
            female_button.TabStop = true;
            female_button.Text = "Female";
            female_button.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(453, 485);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 14;
            label6.Text = "Home Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(453, 436);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 15;
            label7.Text = "Email Address";
            // 
            // p_mail
            // 
            p_mail.Location = new Point(646, 436);
            p_mail.Name = "p_mail";
            p_mail.Size = new Size(465, 29);
            p_mail.TabIndex = 16;
            // 
            // p_contact
            // 
            p_contact.Location = new Point(646, 382);
            p_contact.Name = "p_contact";
            p_contact.Size = new Size(465, 29);
            p_contact.TabIndex = 17;
            // 
            // save
            // 
            save.BackColor = Color.Black;
            save.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.ForeColor = Color.White;
            save.Location = new Point(522, 549);
            save.Name = "save";
            save.Size = new Size(161, 51);
            save.TabIndex = 19;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Black;
            clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.White;
            clear.Location = new Point(950, 549);
            clear.Name = "clear";
            clear.Size = new Size(161, 51);
            clear.TabIndex = 20;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(453, 245);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 22;
            label8.Text = "Patient ID";
            // 
            // p_id
            // 
            p_id.Location = new Point(646, 245);
            p_id.Name = "p_id";
            p_id.Size = new Size(465, 29);
            p_id.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(p_home);
            panel1.Controls.Add(p_id);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(clear);
            panel1.Controls.Add(save);
            panel1.Controls.Add(p_contact);
            panel1.Controls.Add(p_mail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(female_button);
            panel1.Controls.Add(male_button);
            panel1.Controls.Add(p_bday);
            panel1.Controls.Add(p_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(64, 0, 64);
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 830);
            panel1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Black;
            buttonUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(745, 549);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(161, 51);
            buttonUpdate.TabIndex = 25;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // p_home
            // 
            p_home.Location = new Point(646, 485);
            p_home.Name = "p_home";
            p_home.Size = new Size(465, 29);
            p_home.TabIndex = 24;
            // 
            // patient_registration
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1611, 858);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(241, 245, 249);
            Name = "patient_registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System - Doctor Sessions Dashboard";
            FormClosing += Form2_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem registationToolStripMenuItem;
        private ToolStripMenuItem patientListToolStripMenuItem;
        private TextBox p_home;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox p_name;
        private TextBox p_bday;
        private RadioButton male_button;
        private RadioButton female_button;
        private Label label6;
        private Label label7;
        private TextBox p_mail;
        private TextBox p_contact;
        private Button save;
        private Button clear;
        private Label label8;
        private TextBox p_id;
        private Panel panel1;

        private Button buttonUpdate;
    }
}