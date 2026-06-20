using System;

namespace hospital_management_system
{
    public class Doctor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Department { get; set; }
        public string Room { get; set; }

        // Parameterless constructor required for XML serialization
        public Doctor() { }

        public Doctor(string id, string name, string specialty, string department, string room)
        {
            Id = id;
            Name = name;
            Specialty = specialty;
            Department = department;
            Room = room;
        }
    }
}
