using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStudent.Models
{
    public class Student
    {
        [Key] public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public List<Mark> Marks { get; set; }
        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Gender = Gender.Male;
            this.Status = Status.Actived;
        }
    }

    public enum Gender
    {
        Male = 1,
        Female = 0,
        Other = 2
    }

    public enum Status
    {
        Actived = 1,
        Deactived = 0
    }
}
