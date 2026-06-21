using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System.IO;

namespace hospital_management_system
{
    public partial class DoctorHub : Form
    {
        public DoctorHub()
        {
            InitializeComponent();
            // 🎨 Dashboard එකේ තීම් එකට මැච් වෙන්න BackColor එක Dark Navy කරනවා
            this.BackColor = Color.FromArgb(15, 23, 42);

            // 💡 🆕 පැනල් එක ඇතුළේ Form එක ලොකු වැඩි නම් Scrollbars එන්න මේක මෙතනට දාන්න:
            this.AutoScroll = true;

        }

        private void BtnSaveAndPrint_Click(object sender, EventArgs e)
        {
            // 👤 Session එකෙන් Doctor ගේ විස්තර ගන්නවා
            string doctorID = hospital_management_system.Form1.LoggedInUserID;
            string doctorName = hospital_management_system.Form1.LoggedInUserName;

            // UI එකෙන් Data ගන්නවා
            string patientID = txtPatientID.Text.Trim();
            string patientName = txtPatientName.Text.Trim();
            string diagnosis = txtDiagnosis.Text.Trim();
            string prescriptionText = txtPrescription.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(patientID) || string.IsNullOrEmpty(patientName) ||
                string.IsNullOrEmpty(diagnosis) || string.IsNullOrEmpty(prescriptionText))
            {
                MessageBox.Show("Please enter patient details, clinical diagnosis, and prescribed medicines.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                
                string localConnectionString = "Server=localhost;Database=hms_db;Uid=root;Pwd=;";

                using (MySqlConnection conn = new MySqlConnection(localConnectionString))
                {
                    // 🎯 Table name එක 'medicalrecords' ලෙස නිවැරදි කලා
                    string sqlQuery = "INSERT INTO medicalrecord (PatientID, DoctorID, Diagnosis, Prescription, Date) " +
                                      "VALUES (@pID, @dID, @diag, @pres, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@pID", patientID);
                        cmd.Parameters.AddWithValue("@dID", string.IsNullOrEmpty(doctorID) ? "DOC01" : doctorID); 
                        cmd.Parameters.AddWithValue("@diag", diagnosis);
                        cmd.Parameters.AddWithValue("@pres", prescriptionText);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery(); // 💾 Database එකට සේව් වෙනවා
                            
                            // 🎯 මෙන්න මේකයි මඟඇරිලා තිබ්බේ! ඩේටාබේස් සේව් වුණාම පල්ලෙහා තියෙන PDF Method එක Call කරනවා:
                            GeneratePrescriptionPDF(patientID, patientName, string.IsNullOrEmpty(doctorName) ? "Dr. Kamal Perera" : doctorName, diagnosis, prescriptionText);
                            
                            ClearFormFields(); // Form එක clear කරනවා
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
            

        // 🎨 4.Generating a professional-grade PDF document using iTextSharp
        private void GeneratePrescriptionPDF(string pID, string pName, string docName, string diag, string medicines)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HMS_Prescriptions");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = $"Prescription_{pID}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(folderPath, fileName);

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 36, 36, 36, 36);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 22, iTextSharp.text.Font.BOLD, new BaseColor(0, 26, 156)); 
                iTextSharp.text.Font subTitleFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.ITALIC, BaseColor.DARK_GRAY);
                iTextSharp.text.Font sectionHeaderFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD, new BaseColor(0, 26, 156));
                iTextSharp.text.Font boldBodyFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font regularBodyFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // --- 🏥 HEADER SECTION  ---
                Paragraph hospitalTitle = new Paragraph("HOSPITAL MANAGEMENT SYSTEM (HMS)", titleFont);
                hospitalTitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(hospitalTitle);

                Paragraph hospitalSub = new Paragraph("Faculty of Science, University of Kelaniya, Sri Lanka\nTel: +94 11 290 3903 | Email: info@hms.kln.ac.lk", subTitleFont);
                hospitalSub.Alignment = Element.ALIGN_CENTER;
                hospitalSub.SpacingAfter = 15f;
                doc.Add(hospitalSub);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(2f, 100f, new BaseColor(0, 26, 156), Element.ALIGN_CENTER, -1)));
                line.SpacingAfter = 20f;
                doc.Add(line);

                // --- 👤 METADATA BLOCK  ---
                PdfPTable metaTable = new PdfPTable(2);
                metaTable.WidthPercentage = 100;
                metaTable.SetWidths(new float[] { 50f, 50f });

                PdfPCell patientCell = new PdfPCell();
                patientCell.Border = PdfPCell.NO_BORDER;
                patientCell.AddElement(new Paragraph($"Patient ID: {pID}", boldBodyFont));
                patientCell.AddElement(new Paragraph($"Patient Name: {pName}", regularBodyFont));
                patientCell.AddElement(new Paragraph($"Date: {DateTime.Now:yyyy-MM-dd (hh:mm tt)}", regularBodyFont));
                metaTable.AddCell(patientCell);

                PdfPCell doctorCell = new PdfPCell();
                doctorCell.Border = PdfPCell.NO_BORDER;
                doctorCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                doctorCell.AddElement(new Paragraph($"Consultant: {docName}", boldBodyFont));
                doctorCell.AddElement(new Paragraph("Department: General Clinical Medicine", regularBodyFont));
                metaTable.AddCell(doctorCell);

                metaTable.SpacingAfter = 25f;
                doc.Add(metaTable);

                // --- 🔍 DIAGNOSIS SECTION  ---
                Paragraph diagHeader = new Paragraph("CLINICAL DIAGNOSIS", sectionHeaderFont);
                diagHeader.SpacingAfter = 5f;
                doc.Add(diagHeader);

                Paragraph diagContent = new Paragraph(diag, regularBodyFont);
                diagContent.SpacingAfter = 25f;
                doc.Add(diagContent);

                // --- 💊 PRESCRIPTION MEDICINES TABLE  ---
                Paragraph rxHeader = new Paragraph("Rx (Prescribed Medicines)", sectionHeaderFont);
                rxHeader.SpacingAfter = 10f;
                doc.Add(rxHeader);

                PdfPTable medTable = new PdfPTable(1);
                medTable.WidthPercentage = 100;

                PdfPCell headerCell = new PdfPCell(new Phrase("Medication Details & Dosage Instructions", new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                headerCell.BackgroundColor = new BaseColor(0, 26, 156);
                headerCell.Padding = 8f;
                headerCell.HorizontalAlignment = Element.ALIGN_LEFT;
                medTable.AddCell(headerCell);

                string[] medLines = medicines.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string med in medLines)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(med, regularBodyFont));
                    cell.Padding = 8f;
                    cell.BorderColor = BaseColor.LIGHT_GRAY;
                    medTable.AddCell(cell);
                }

                medTable.SpacingAfter = 60f;
                doc.Add(medTable);

                // --- ✍️ FOOTER SECTION  ---
                PdfPTable footerTable = new PdfPTable(1);
                footerTable.WidthPercentage = 100;

                PdfPCell signCell = new PdfPCell();
                signCell.Border = PdfPCell.NO_BORDER;
                signCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                signCell.AddElement(new Paragraph("\n\n__________________________", boldBodyFont));
                Paragraph signText = new Paragraph("Authorized Signature & Stamp", subTitleFont);
                signText.Alignment = Element.ALIGN_RIGHT;
                signCell.AddElement(signText);

                footerTable.AddCell(signCell);
                doc.Add(footerTable);

                // Success Message
                MessageBox.Show($"Prescription successfully saved to database and digital PDF report generated!\n\nPath: {filePath}",
                                "HMS Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the PDF report: " + ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close(); 
            }
        }

        private void ClearFormFields()
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtDiagnosis.Clear();
            txtPrescription.Clear();
        }
    }
}