using System.Windows.Forms;
using System.Drawing;

namespace HMS
{
    partial class Form3
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
            panel1 = new Panel();
            search_id = new TextBox();
            details = new DataGridView();
            label8 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)details).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, registationToolStripMenuItem, patientListToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 28);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel1.Controls.Add(search_id);
            panel1.Controls.Add(details);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.FromArgb(241, 245, 249);
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 672);
            panel1.TabIndex = 3;
            // 
            // search_id
            // 
            search_id.Location = new Point(611, 94);
            search_id.Name = "search_id";
            search_id.Size = new Size(214, 29);
            search_id.TabIndex = 25;
            // 
            // details
            // 
            details.BackgroundColor = SystemColors.ButtonShadow;
            details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            details.Location = new Point(233, 156);
            details.Name = "details";
            details.RowHeadersWidth = 51;
            details.Size = new Size(778, 431);
            details.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(402, 95);
            label8.Name = "label8";
            label8.Size = new Size(154, 28);
            label8.TabIndex = 23;
            label8.Text = "Enter Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(445, 18);
            label2.Name = "label2";
            label2.Size = new Size(300, 48);
            label2.TabIndex = 6;
            label2.Text = "PATIENT DETAILS";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1300, 700);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(241, 245, 249);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System - Doctor Sessions Dashboard";
            FormClosing += Form3_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)details).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem registationToolStripMenuItem;
        private ToolStripMenuItem patientListToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private DataGridView details;
        private Label label8;
        private TextBox search_id;
    }
}