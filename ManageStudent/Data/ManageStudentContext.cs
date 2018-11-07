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
            modelBuilder.Entity<Student>()
                .HasMany<Mark>(s => s.Marks)
                .WithOne(m => m.Student)
                .HasForeignKey(x => x.StudentRollNumber)
                .OnDelete(DeleteBehavior.Cascade);
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
                FirstName = "Hai",
                LastName = "Ngoc",
                Email = "quanghungleo@gmail.com"
            },
            new Student()
            {
                RollNumber = "A00003",
                FirstName = "Van",
                LastName = "Vien",
                Email = "quanghungleo@gmail.com"
            }
            );

            modelBuilder.Entity<Mark>().HasData(new Mark()
                {
                    Id = 1,
                    SubjectName = "Java",
                    StudentRollNumber = "A00001",
                    SubjectMark = 24
                },
                new Mark()
                {
                    Id = 2,
                    SubjectName = "C#",
                    StudentRollNumber = "A00001",
                    SubjectMark = 23
                },
                new Mark()
                {
                    Id = 3,
                    SubjectName = "Python",
                    StudentRollNumber = "A00001",
                    SubjectMark = 27
                }

            );
        }

        public DbSet<ManageStudent.Models.Student> Student { get; set; }
        public DbSet<ManageStudent.Models.Mark> Mark { get; set; }
    }
}
