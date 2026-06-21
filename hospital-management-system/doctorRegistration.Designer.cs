using System.Drawing;
using System.Windows.Forms;

namespace HMS
{
    partial class doctor_registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dfemale = new System.Windows.Forms.RadioButton();
            this.dmale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.d_clear = new System.Windows.Forms.Button();
            this.d_save = new System.Windows.Forms.Button();
            this.d_name = new System.Windows.Forms.TextBox();
            this.d_id = new System.Windows.Forms.TextBox();
            this.special = new System.Windows.Forms.TextBox();
            this.d_phone = new System.Windows.Forms.TextBox();
            this.d_mail = new System.Windows.Forms.TextBox();
            this.d_home = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "DOCTOR REGISTRATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(162, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(162, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speialization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(162, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Home Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(162, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact Number";
            // 
            // dfemale
            // 
            this.dfemale.AutoSize = true;
            this.dfemale.BackColor = System.Drawing.Color.Transparent;
            this.dfemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfemale.ForeColor = System.Drawing.Color.White;
            this.dfemale.Location = new System.Drawing.Point(489, 252);
            this.dfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dfemale.Name = "dfemale";
            this.dfemale.Size = new System.Drawing.Size(100, 32);
            this.dfemale.TabIndex = 21;
            this.dfemale.TabStop = true;
            this.dfemale.Text = "Female";
            this.dfemale.UseVisualStyleBackColor = false;
            // 
            // dmale
            // 
            this.dmale.AutoSize = true;
            this.dmale.BackColor = System.Drawing.Color.Transparent;
            this.dmale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmale.ForeColor = System.Drawing.Color.White;
            this.dmale.Location = new System.Drawing.Point(355, 250);
            this.dmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dmale.Name = "dmale";
            this.dmale.Size = new System.Drawing.Size(80, 32);
            this.dmale.TabIndex = 20;
            this.dmale.TabStop = true;
            this.dmale.Text = "Male";
            this.dmale.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(162, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // d_clear
            // 
            this.d_clear.BackColor = System.Drawing.Color.Black;
            this.d_clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_clear.ForeColor = System.Drawing.Color.White;
            this.d_clear.Location = new System.Drawing.Point(573, 438);
            this.d_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_clear.Name = "d_clear";
            this.d_clear.Size = new System.Drawing.Size(161, 41);
            this.d_clear.TabIndex = 27;
            this.d_clear.Text = "Clear";
            this.d_clear.UseVisualStyleBackColor = false;
            // 
            // d_save
            // 
            this.d_save.BackColor = System.Drawing.Color.Black;
            this.d_save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_save.ForeColor = System.Drawing.Color.White;
            this.d_save.Location = new System.Drawing.Point(313, 438);
            this.d_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_save.Name = "d_save";
            this.d_save.Size = new System.Drawing.Size(161, 41);
            this.d_save.TabIndex = 26;
            this.d_save.Text = "Save";
            this.d_save.UseVisualStyleBackColor = false;
            // 
            // d_name
            // 
            this.d_name.Location = new System.Drawing.Point(355, 132);
            this.d_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_name.Name = "d_name";
            this.d_name.Size = new System.Drawing.Size(465, 22);
            this.d_name.TabIndex = 28;
            // 
            // d_id
            // 
            this.d_id.Location = new System.Drawing.Point(355, 173);
            this.d_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_id.Name = "d_id";
            this.d_id.Size = new System.Drawing.Size(465, 22);
            this.d_id.TabIndex = 29;
            // 
            // special
            // 
            this.special.Location = new System.Drawing.Point(355, 214);
            this.special.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(465, 22);
            this.special.TabIndex = 30;
            // 
            // d_phone
            // 
            this.d_phone.Location = new System.Drawing.Point(355, 288);
            this.d_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_phone.Name = "d_phone";
            this.d_phone.Size = new System.Drawing.Size(465, 22);
            this.d_phone.TabIndex = 31;
            // 
            // d_mail
            // 
            this.d_mail.Location = new System.Drawing.Point(355, 332);
            this.d_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_mail.Name = "d_mail";
            this.d_mail.Size = new System.Drawing.Size(465, 22);
            this.d_mail.TabIndex = 32;
            // 
            // d_home
            // 
            this.d_home.Location = new System.Drawing.Point(355, 370);
            this.d_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_home.Name = "d_home";
            this.d_home.Size = new System.Drawing.Size(465, 22);
            this.d_home.TabIndex = 33;
            // 
            // doctor_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(943, 533);
            this.Controls.Add(this.d_home);
            this.Controls.Add(this.d_mail);
            this.Controls.Add(this.d_phone);
            this.Controls.Add(this.special);
            this.Controls.Add(this.d_id);
            this.Controls.Add(this.d_name);
            this.Controls.Add(this.d_clear);
            this.Controls.Add(this.d_save);
            this.Controls.Add(this.dfemale);
            this.Controls.Add(this.dmale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "doctor_registration";
            this.Text = "Speialization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private RadioButton dfemale;
        private RadioButton dmale;
        private Label label8;
        private Button d_clear;
        private Button d_save;
        private TextBox d_name;
        private TextBox d_id;
        private TextBox d_phone;
        private TextBox d_mail;
        private TextBox special;
        private TextBox d_home;
    }
}