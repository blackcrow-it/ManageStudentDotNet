﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ManageStudent.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string StudentRollNumber { get; set; }
        public int SubjectMark { get; set; }
        [ForeignKey("StudentRollNumber")]
        public Student Student { get; set; }
    }
}
