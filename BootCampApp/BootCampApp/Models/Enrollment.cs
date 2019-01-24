namespace BootCampApp.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Grade? Grade { get; set; } //nullable property- attribute for class

        //
        public virtual Student Student { get; set; } //1-1 Relation = 1 enrollment have 1 student
        public virtual Course Course { get; set; } // for One Class 1-1 Relation = 1 enrollment have 1 class
    }
}