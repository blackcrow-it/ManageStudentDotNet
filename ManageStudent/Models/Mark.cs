using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStudent.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectRollNumber { get; set; }
        public int SubjectMark { get; set; }
        public Student Student { get; set; }
    }
}
