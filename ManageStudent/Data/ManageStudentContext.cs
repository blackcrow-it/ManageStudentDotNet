using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManageStudent.Models
{
    public class ManageStudentContext : DbContext
    {
        public ManageStudentContext(DbContextOptions<ManageStudentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                RollNumber = "A00001",
                FirstName = "Hung",
                LastName = "Nguyen",
                Email = "quanghungleo@gmail.com"
            },
            new Student()
            {
                RollNumber = "A00002",
                FirstName = "Hung",
                LastName = "Nguyen",
                Email = "quanghungleo@gmail.com"
            },
            new Student()
            {
                RollNumber = "A00003",
                FirstName = "Hung",
                LastName = "Nguyen",
                Email = "quanghungleo@gmail.com"
            }
            );

            modelBuilder.Entity<Mark>().HasData(new Mark()
                {
                    Id = 1,
                    SubjectName = "Java",
                    SubjectRollNumber = "A00001",
                    SubjectMark = 24
                },
                new Mark()
                {
                    Id = 2,
                    SubjectName = "C#",
                    SubjectRollNumber = "A00001",
                    SubjectMark = 23
                },
                new Mark()
                {
                    Id = 3,
                    SubjectName = "Python",
                    SubjectRollNumber = "A00001",
                    SubjectMark = 27
                }

            );
        }

        public DbSet<ManageStudent.Models.Student> Student { get; set; }
        public DbSet<ManageStudent.Models.Mark> Mark { get; set; }
    }
}
