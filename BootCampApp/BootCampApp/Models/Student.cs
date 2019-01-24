using System;
using System.Collections.Generic;//

namespace BootCampApp.Models
{   /// <summary>
    ///  A student can enroll in Many Classes
    ///  A class has many students
    /// </summary>
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        //1 students has MANY enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}