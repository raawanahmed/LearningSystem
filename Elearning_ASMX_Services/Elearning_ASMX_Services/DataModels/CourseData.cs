using System;

namespace Elearning_ASMX_Services.DataModels
{
    public class CourseData
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