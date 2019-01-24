using System;

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
        
        //todo list Enrollments
    }
}