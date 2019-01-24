namespace BootCampApp.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Grade? Grade { get; set; } //nullable property

        //TODO Student, Course
    }
}