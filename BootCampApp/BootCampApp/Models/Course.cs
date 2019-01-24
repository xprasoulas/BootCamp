using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;//

namespace BootCampApp.Models
{
    public class Course
    {
        [DatabaseGenerated[DatabaseGeneratedOption.None]]//non auto increment property
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }

        //TODO List Enrollments
    }
}