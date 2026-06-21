using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Linq;

namespace hospital_management_system
{
    public static class DataManager
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["HMSConnectionString"]?.ConnectionString 
            ?? @"Data Source=localhost;Initial Catalog=HospitalManagementDB;Integrated Security=True;TrustServerCertificate=True";

        // Helper to get a database connection
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static List<Doctor> GetDoctors()
        {
            var list = new List<Doctor>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT Id, Name, Specialty, Department, Room, Contact, Email, Address, Gender FROM Doctors", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Doctor(
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Specialty"].ToString(),
                            reader["Department"].ToString(),
                            reader["Room"].ToString(),
                            reader["Contact"]?.ToString() ?? "",
                            reader["Email"]?.ToString() ?? "",
                            reader["Address"]?.ToString() ?? "",
                            reader["Gender"]?.ToString() ?? ""
                        ));
                    }
                }
            }
            return list;
        }

        public static void AddDoctor(Doctor doc)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO Doctors (Id, Name, Specialty, Department, Room, Contact, Email, Address, Gender) " +
                "VALUES (@Id, @Name, @Specialty, @Department, @Room, @Contact, @Email, @Address, @Gender)", conn))
            {
                cmd.Parameters.AddWithValue("@Id", doc.Id);
                cmd.Parameters.AddWithValue("@Name", doc.Name);
                cmd.Parameters.AddWithValue("@Specialty", doc.Specialty);
                cmd.Parameters.AddWithValue("@Department", doc.Department);
                cmd.Parameters.AddWithValue("@Room", doc.Room);
                cmd.Parameters.AddWithValue("@Contact", (object)doc.Contact ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)doc.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)doc.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", (object)doc.Gender ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Session> GetSessions()
        {
            var list = new List<Session>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT Id, DoctorId, SessionDate, StartTime, EndTime, Room, MaxPatients FROM Sessions", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Session(
                            reader["Id"].ToString(),
                            reader["DoctorId"].ToString(),
                            Convert.ToDateTime(reader["SessionDate"]),
                            reader["StartTime"].ToString(),
                            reader["EndTime"].ToString(),
                            reader["Room"].ToString(),
                            Convert.ToInt32(reader["MaxPatients"])
                        ));
                    }
                }
            }
            return list;
        }

        public static List<Session> GetSessionsForDoctor(string doctorId)
        {
            var list = new List<Session>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT Id, DoctorId, SessionDate, StartTime, EndTime, Room, MaxPatients " +
                "FROM Sessions WHERE DoctorId = @DocId " +
                "ORDER BY SessionDate, StartTime", conn))
            {
                cmd.Parameters.AddWithValue("@DocId", doctorId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Session(
                            reader["Id"].ToString(),
                            reader["DoctorId"].ToString(),
                            Convert.ToDateTime(reader["SessionDate"]),
                            reader["StartTime"].ToString(),
                            reader["EndTime"].ToString(),
                            reader["Room"].ToString(),
                            Convert.ToInt32(reader["MaxPatients"])
                        ));
                    }
                }
            }
            return list;
        }

        public static void AddSession(Session session)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO Sessions (Id, DoctorId, SessionDate, StartTime, EndTime, Room, MaxPatients) " +
                "VALUES (@Id, @DoctorId, @SessionDate, @StartTime, @EndTime, @Room, @MaxPatients)", conn))
            {
                cmd.Parameters.AddWithValue("@Id", session.Id);
                cmd.Parameters.AddWithValue("@DoctorId", session.DoctorId);
                cmd.Parameters.AddWithValue("@SessionDate", session.SessionDate.Date);
                cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
                cmd.Parameters.AddWithValue("@Room", session.Room);
                cmd.Parameters.AddWithValue("@MaxPatients", session.MaxPatients);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static bool DeleteSession(string sessionId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM Sessions WHERE Id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", sessionId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public static List<Patient> GetPatients()
        {
            var list = new List<Patient>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT Id, Name, Age, Gender, Contact, Email, Address, Birthday FROM Patients", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Patient(
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Age"]?.ToString() ?? "",
                            reader["Gender"].ToString(),
                            reader["Contact"].ToString(),
                            reader["Email"]?.ToString() ?? "",
                            reader["Address"]?.ToString() ?? "",
                            reader["Birthday"]?.ToString() ?? ""
                        ));
                    }
                }
            }
            return list;
        }

        public static List<Appointment> GetAppointments()
        {
            var list = new List<Appointment>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT a.Id, a.SessionId, a.PatientId, p.Name AS PatientName, a.AppointmentNumber, a.BookingTime " +
                "FROM Appointments a JOIN Patients p ON a.PatientId = p.Id", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment(
                            reader["Id"].ToString(),
                            reader["SessionId"].ToString(),
                            reader["PatientId"].ToString(),
                            reader["PatientName"].ToString(),
                            Convert.ToInt32(reader["AppointmentNumber"]),
                            Convert.ToDateTime(reader["BookingTime"])
                        ));
                    }
                }
            }
            return list;
        }

        public static Patient GetPatientById(string id)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT Id, Name, Age, Gender, Contact, Email, Address, Birthday FROM Patients " +
                "WHERE Id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient(
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Age"]?.ToString() ?? "",
                            reader["Gender"].ToString(),
                            reader["Contact"].ToString(),
                            reader["Email"]?.ToString() ?? "",
                            reader["Address"]?.ToString() ?? "",
                            reader["Birthday"]?.ToString() ?? ""
                        );
                    }
                }
            }
            return null;
        }

        public static Patient GetPatientByContact(string contact)
        {
            if (string.IsNullOrEmpty(contact)) return null;
            string cleanSearch = contact.Replace("-", "").Replace(" ", "").Trim();

            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT Id, Name, Age, Gender, Contact, Email, Address, Birthday FROM Patients " +
                "WHERE REPLACE(REPLACE(Contact, '-', ''), ' ', '') = @Contact", conn))
            {
                cmd.Parameters.AddWithValue("@Contact", cleanSearch);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient(
                            reader["Id"].ToString(),
                            reader["Name"].ToString(),
                            reader["Age"]?.ToString() ?? "",
                            reader["Gender"].ToString(),
                            reader["Contact"].ToString(),
                            reader["Email"]?.ToString() ?? "",
                            reader["Address"]?.ToString() ?? "",
                            reader["Birthday"]?.ToString() ?? ""
                        );
                    }
                }
            }
            return null;
        }

        public static List<Appointment> GetAppointmentsForSession(string sessionId)
        {
            var list = new List<Appointment>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT a.Id, a.SessionId, a.PatientId, p.Name AS PatientName, a.AppointmentNumber, a.BookingTime " +
                "FROM Appointments a JOIN Patients p ON a.PatientId = p.Id " +
                "WHERE a.SessionId = @SessionId", conn))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment(
                            reader["Id"].ToString(),
                            reader["SessionId"].ToString(),
                            reader["PatientId"].ToString(),
                            reader["PatientName"].ToString(),
                            Convert.ToInt32(reader["AppointmentNumber"]),
                            Convert.ToDateTime(reader["BookingTime"])
                        ));
                    }
                }
            }
            return list;
        }

        public static int GetNextAppointmentNumber(string sessionId)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT COALESCE(MAX(AppointmentNumber), 0) + 1 FROM Appointments " +
                "WHERE SessionId = @SessionId", conn))
            {
                cmd.Parameters.AddWithValue("@SessionId", sessionId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void AddAppointment(Appointment appointment)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO Appointments (Id, SessionId, PatientId, AppointmentNumber, BookingTime) " +
                "VALUES (@Id, @SessionId, @PatientId, @AppointmentNumber, @BookingTime)", conn))
            {
                cmd.Parameters.AddWithValue("@Id", appointment.Id);
                cmd.Parameters.AddWithValue("@SessionId", appointment.SessionId);
                cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                cmd.Parameters.AddWithValue("@AppointmentNumber", appointment.AppointmentNumber);
                cmd.Parameters.AddWithValue("@BookingTime", appointment.BookingTime);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddPatient(Patient patient)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO Patients (Id, Name, Age, Gender, Contact, Email, Address, Birthday) " +
                "VALUES (@Id, @Name, @Age, @Gender, @Contact, @Email, @Address, @Birthday)", conn))
            {
                cmd.Parameters.AddWithValue("@Id", patient.Id);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", (object)patient.Age ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Contact", patient.Contact);
                cmd.Parameters.AddWithValue("@Email", (object)patient.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)patient.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Birthday", (object)patient.Birthday ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdatePatient(Patient patient)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "UPDATE Patients SET Name = @Name, Age = @Age, Gender = @Gender, Contact = @Contact, " +
                "Email = @Email, Address = @Address, Birthday = @Birthday " +
                "WHERE Id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("@Id", patient.Id);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Age", (object)patient.Age ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Contact", patient.Contact);
                cmd.Parameters.AddWithValue("@Email", (object)patient.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)patient.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Birthday", (object)patient.Birthday ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
