using System.Windows.Forms;
using System.Drawing;

namespace HMS
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_bday = new System.Windows.Forms.TextBox();
            this.male_button = new System.Windows.Forms.RadioButton();
            this.female_button = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p_mail = new System.Windows.Forms.TextBox();
            this.p_contact = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.p_home = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.registationToolStripMenuItem,
            this.patientListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // registationToolStripMenuItem
            // 
            this.registationToolStripMenuItem.Name = "registationToolStripMenuItem";
            this.registationToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.registationToolStripMenuItem.Text = "Registration";
            // 
            // patientListToolStripMenuItem
            // 
            this.patientListToolStripMenuItem.Name = "patientListToolStripMenuItem";
            this.patientListToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.patientListToolStripMenuItem.Text = "Patient List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(398, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "PATIENT REGISTRATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(269, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(269, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth";
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(462, 171);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(465, 29);
            this.p_name.TabIndex = 10;
            // 
            // p_bday
            // 
            this.p_bday.Location = new System.Drawing.Point(462, 267);
            this.p_bday.Name = "p_bday";
            this.p_bday.Size = new System.Drawing.Size(465, 29);
            this.p_bday.TabIndex = 11;
            // 
            // male_button
            // 
            this.male_button.AutoSize = true;
            this.male_button.BackColor = System.Drawing.Color.Transparent;
            this.male_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_button.ForeColor = System.Drawing.Color.White;
            this.male_button.Location = new System.Drawing.Point(462, 311);
            this.male_button.Name = "male_button";
            this.male_button.Size = new System.Drawing.Size(80, 32);
            this.male_button.TabIndex = 12;
            this.male_button.TabStop = true;
            this.male_button.Text = "Male";
            this.male_button.UseVisualStyleBackColor = false;
            // 
            // female_button
            // 
            this.female_button.AutoSize = true;
            this.female_button.BackColor = System.Drawing.Color.Transparent;
            this.female_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_button.ForeColor = System.Drawing.Color.White;
            this.female_button.Location = new System.Drawing.Point(596, 313);
            this.female_button.Name = "female_button";
            this.female_button.Size = new System.Drawing.Size(100, 32);
            this.female_button.TabIndex = 13;
            this.female_button.TabStop = true;
            this.female_button.Text = "Female";
            this.female_button.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(269, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Home Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(269, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email Address";
            // 
            // p_mail
            // 
            this.p_mail.Location = new System.Drawing.Point(462, 413);
            this.p_mail.Name = "p_mail";
            this.p_mail.Size = new System.Drawing.Size(465, 29);
            this.p_mail.TabIndex = 16;
            // 
            // p_contact
            // 
            this.p_contact.Location = new System.Drawing.Point(462, 359);
            this.p_contact.Name = "p_contact";
            this.p_contact.Size = new System.Drawing.Size(465, 29);
            this.p_contact.TabIndex = 17;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(338, 526);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(161, 51);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Black;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(766, 526);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(161, 51);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(269, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Patient ID";
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(462, 222);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(465, 29);
            this.p_id.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.p_home);
            this.panel1.Controls.Add(this.p_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.p_contact);
            this.panel1.Controls.Add(this.p_mail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.female_button);
            this.panel1.Controls.Add(this.male_button);
            this.panel1.Controls.Add(this.p_bday);
            this.panel1.Controls.Add(this.p_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 672);
            this.panel1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Black;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(561, 526);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(161, 51);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // p_home
            // 
            this.p_home.Location = new System.Drawing.Point(462, 462);
            this.p_home.Name = "p_home";
            this.p_home.Size = new System.Drawing.Size(465, 29);
            this.p_home.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System - Doctor Sessions Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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