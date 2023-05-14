using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_end.Models
{
    public class CourseModel
    {
        public int Id { get; set; } = 0;
        public string CourseName { get; set; } = "";
        public string CourseDescription { get; set; } = "";
        public int CoursePrice { get; set; } = 0;
        public string CourseInstructor { get; set; } = "";
        public string CourseGenre { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}