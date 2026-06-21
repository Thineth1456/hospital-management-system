namespace HMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            registationToolStripMenuItem = new ToolStripMenuItem();
            patientListToolStripMenuItem = new ToolStripMenuItem();
            registerBtn = new Button();
            p_list = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 139);
            label1.Name = "label1";
            label1.Size = new Size(603, 48);
            label1.TabIndex = 1;
            label1.Text = "PATIENT REGISTRATION RECEPTION";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, registationToolStripMenuItem, patientListToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 28);
            menuStrip1.TabIndex = 1;
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
            // registerBtn
            // 
            registerBtn.BackColor = Color.Black;
            registerBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(474, 259);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(216, 79);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "REGISTRATION";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // p_list
            // 
            p_list.BackColor = Color.Black;
            p_list.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p_list.ForeColor = Color.White;
            p_list.Location = new Point(474, 430);
            p_list.Name = "p_list";
            p_list.Size = new Size(216, 79);
            p_list.TabIndex = 3;
            p_list.Text = "PATIENT LIST";
            p_list.UseVisualStyleBackColor = false;
            p_list.Click += p_list_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.FromArgb(241, 245, 249);
            panel1.Location = new Point(590, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 21);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1300, 700);
            Controls.Add(panel1);
            Controls.Add(p_list);
            Controls.Add(registerBtn);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(241, 245, 249);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System - Doctor Sessions Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem registationToolStripMenuItem;
        private ToolStripMenuItem patientListToolStripMenuItem;
        private Button registerBtn;
        private Button p_list;
        private Panel panel1;
    }
}
