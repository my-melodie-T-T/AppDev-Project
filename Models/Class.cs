using System;

namespace MVC_Project.Models
{
    public class StudentModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public DateOnly dateOfBirth { get; set; }
    }
}

