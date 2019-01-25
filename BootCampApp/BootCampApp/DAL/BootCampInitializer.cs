using BootCampApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;//

namespace BootCampApp.DAL
{
    public class BootCampInitializer :DropCreateDatabaseIfModelChanges<BootCampDbContext>
    {
        protected override void Seed(BootCampDbContext context)
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Peri",
                    LastName = "Papadoulos",
                    EnrollmentDate = DateTime.Parse("2018-09-01")
                },
                new Student
                {
                    FirstName = "Nick",
                    LastName = "Galis",
                    EnrollmentDate = DateTime.Parse("2016-09-11")
                },
                new Student
                {
                    FirstName = "Victoras",
                    LastName = "Klonaridis",
                    EnrollmentDate = DateTime.Parse("2018-09-01")
                },
                new Student
                {
                    FirstName = "Michael",
                    LastName = "Schumacher",
                    EnrollmentDate = DateTime.Parse("2018-10-05")
                },
                new Student
                {
                    FirstName = "Theodora",
                    LastName = "Antoniou",
                    EnrollmentDate = DateTime.Parse("2018-10-01")
                },
                new Student
                {
                    FirstName = "Bill",
                    LastName = "Gates",
                    EnrollmentDate = DateTime.Parse("2018-11-01")
                },
                new Student
                {
                    FirstName = "Periklis",
                    LastName = "Papadopoulos",
                    EnrollmentDate = DateTime.Parse("2018-12-01")
                }
            };

            students.ForEach(s => context.Students.Add(s)); //Convert each data to records 
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course
                {
                    CourseID = 1050,
                    Title = "OOP",
                    Hours = 851
                },
                new Course
                {
                    CourseID = 1060,
                    Title = "C#",
                    Hours = 905
                },
                new Course
                {
                    CourseID = 1070,
                    Title = "JavaScript",
                    Hours = 987
                },
                new Course
                {
                    CourseID = 1080,
                    Title = ".NET",
                    Hours = 3
                },
                new Course
                {
                    CourseID = 1090,
                    Title = "MVC",
                    Hours = 81
                },
                new Course
                {
                    CourseID = 1100,
                    Title = "Python",
                    Hours = 99
                },
                new Course
                {
                    CourseID = 1120,
                    Title = "BootStrap",
                    Hours = 21
                }
            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment
                {
                    StudentID = 1,
                    CourseID = 1050,
                    Grade = Grade.A
                },
                new Enrollment
                {
                    StudentID = 1,
                    CourseID = 1060,
                    Grade = Grade.B
                },
                new Enrollment
                {
                    StudentID = 1,
                    CourseID = 1070,
                    Grade = Grade.A
                },
                new Enrollment
                {
                    StudentID = 2,
                    CourseID = 1050,
                    Grade = Grade.E
                },
                new Enrollment
                {   StudentID = 2,
                    CourseID = 1070,
                    Grade = Grade.F
                },
                new Enrollment
                {
                    StudentID = 3,
                    CourseID = 1050,
                    Grade = Grade.C
                },
                new Enrollment
                {
                    StudentID = 2,
                    CourseID = 1090,
                    Grade = Grade.B
                },
                new Enrollment
                {
                    StudentID = 3,
                    CourseID = 1070,
                    Grade = Grade.D
                },
                new Enrollment
                {
                    StudentID = 4,
                    CourseID = 1050
                },
                new Enrollment
                {
                    StudentID = 4,
                    CourseID = 1070,
                    Grade = Grade.C
                },
                new Enrollment
                {
                    StudentID = 4,
                    CourseID = 1090,
                    Grade = Grade.F
                }
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}