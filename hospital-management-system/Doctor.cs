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
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        // Parameterless constructor required for XML serialization
        public Doctor() { }

        public Doctor(string id, string name, string specialty, string department, string room, string contact = "", string email = "", string address = "", string gender = "")
        {
            Id = id;
            Name = name;
            Specialty = specialty;
            Department = department;
            Room = room;
            Contact = contact;
            Email = email;
            Address = address;
            Gender = gender;
        }
    }
}
