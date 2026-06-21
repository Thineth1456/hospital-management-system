using System;

namespace hospital_management_system
{
    public class Patient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }

        public Patient() { }

        public Patient(string id, string name, string age, string gender, string contact, string email = "", string address = "", string birthday = "")
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Contact = contact;
            Email = email;
            Address = address;
            Birthday = birthday;
        }
    }
}
