using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace hospital_management_system
{
    public class HospitalData
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Session> Sessions { get; set; } = new List<Session>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }

    public static class DataManager
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hospital_data.xml");
        private static HospitalData _data = new HospitalData();

        static DataManager()
        {
            LoadData();
        }

        public static List<Doctor> GetDoctors()
        {
            return _data.Doctors;
        }

        public static List<Session> GetSessions()
        {
            return _data.Sessions;
        }

        public static List<Session> GetSessionsForDoctor(string doctorId)
        {
            return _data.Sessions
                .Where(s => s.DoctorId == doctorId)
                .OrderBy(s => s.SessionDate)
                .ThenBy(s => s.StartTime)
                .ToList();
        }

        public static void AddSession(Session session)
        {
            _data.Sessions.Add(session);
            SaveData();
        }

        public static bool DeleteSession(string sessionId)
        {
            var session = _data.Sessions.FirstOrDefault(s => s.Id == sessionId);
            if (session != null)
            {
                _data.Sessions.Remove(session);
                SaveData();
                return true;
            }
            return false;
        }

        public static List<Patient> GetPatients()
        {
            return _data.Patients;
        }

        public static List<Appointment> GetAppointments()
        {
            return _data.Appointments;
        }

        public static Patient GetPatientById(string id)
        {
            return _data.Patients.FirstOrDefault(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static List<Appointment> GetAppointmentsForSession(string sessionId)
        {
            return _data.Appointments.Where(a => a.SessionId == sessionId).ToList();
        }

        public static int GetNextAppointmentNumber(string sessionId)
        {
            var appointments = GetAppointmentsForSession(sessionId);
            return appointments.Count > 0 ? appointments.Max(a => a.AppointmentNumber) + 1 : 1;
        }

        public static void AddAppointment(Appointment appointment)
        {
            _data.Appointments.Add(appointment);
            SaveData();
        }

        public static void AddPatient(Patient patient)
        {
            _data.Patients.Add(patient);
            SaveData();
        }

        public static void LoadData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(HospitalData));
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        _data = (HospitalData)serializer.Deserialize(reader);
                    }
                }
                else
                {
                    InitializeMockData();
                    SaveData();
                }
            }
            catch (Exception)
            {
                InitializeMockData();
            }
        }

        public static void SaveData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(HospitalData));
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    serializer.Serialize(writer, _data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        private static void InitializeMockData()
        {
            _data = new HospitalData();

            // Add mock Doctors
            _data.Doctors.Add(new Doctor("1", "Dr. Olivia Bennett", "Cardiologist", "Cardiology Department", "Room 401"));
            _data.Doctors.Add(new Doctor("2", "Dr. Alexander Wright", "Pediatrician", "Pediatrics Clinic", "Room 102"));
            _data.Doctors.Add(new Doctor("3", "Dr. Sophia Martinez", "Neurologist", "Neurology Lab", "Room 305"));
            _data.Doctors.Add(new Doctor("4", "Dr. Marcus Vance", "Orthopedic Surgeon", "Orthopedics Unit", "Room 211"));

            // Add mock Patients
            _data.Patients.Add(new Patient("P101", "Emma Watson", "28", "Female", "077-1234567"));
            _data.Patients.Add(new Patient("P102", "John Doe", "45", "Male", "071-7654321"));
            _data.Patients.Add(new Patient("P103", "Sarah Connor", "35", "Female", "075-9876543"));

            // Add mock Sessions (using current date/upcoming days)
            DateTime today = DateTime.Today;
            _data.Sessions.Add(new Session("S101", "1", today, "09:00 AM", "12:00 PM", "Room 401", 15));
            _data.Sessions.Add(new Session("S102", "1", today.AddDays(1), "02:00 PM", "05:00 PM", "Room 401", 12));
            _data.Sessions.Add(new Session("S103", "2", today, "10:00 AM", "01:00 PM", "Room 102", 20));
            _data.Sessions.Add(new Session("S104", "3", today.AddDays(2), "11:00 AM", "02:00 PM", "Room 305", 10));
            _data.Sessions.Add(new Session("S105", "4", today.AddDays(1), "08:30 AM", "11:30 AM", "Room 211", 8));
        }
    }
}
