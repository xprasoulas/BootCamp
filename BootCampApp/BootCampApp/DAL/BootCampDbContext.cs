using BootCampApp.Models;//
using System;
using System.Collections.Generic;
using System.Data.Entity; //
using System.Linq;
using System.Web;

namespace BootCampApp.DAL
{
    public class BootCampDbContext : DbContext
    {
        public BootCampDbContext() : base("BootCampContext")
        { }

        // Fill it with the table that we want to create
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}