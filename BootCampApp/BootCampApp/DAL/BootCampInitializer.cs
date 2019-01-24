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
        }
    }
}