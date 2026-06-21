using System;

namespace hospital_management_system
{
    public class Appointment
    {
        public string Id { get; set; }
        public string SessionId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public int AppointmentNumber { get; set; }
        public DateTime BookingTime { get; set; }

        public Appointment() { }

        public Appointment(string id, string sessionId, string patientId, string patientName, int appointmentNumber, DateTime bookingTime)
        {
            Id = id;
            SessionId = sessionId;
            PatientId = patientId;
            PatientName = patientName;
            AppointmentNumber = appointmentNumber;
            BookingTime = bookingTime;
        }
    }
}
