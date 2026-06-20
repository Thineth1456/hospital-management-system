using System;

namespace hospital_management_system
{
    public class Session
    {
        public string Id { get; set; }
        public string DoctorId { get; set; }
        public DateTime SessionDate { get; set; }
        public string StartTime { get; set; } // e.g., "09:00 AM" or "14:30"
        public string EndTime { get; set; }   // e.g., "12:00 PM" or "17:00"
        public string Room { get; set; }
        public int MaxPatients { get; set; }

        // Parameterless constructor required for XML serialization
        public Session() { }

        public Session(string id, string doctorId, DateTime date, string startTime, string endTime, string room, int maxPatients)
        {
            Id = id;
            DoctorId = doctorId;
            SessionDate = date;
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
            MaxPatients = maxPatients;
        }
    }
}
