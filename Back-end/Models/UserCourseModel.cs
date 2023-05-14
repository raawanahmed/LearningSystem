using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_end.Models
{
    public class UserCourseModel
    {
        public int Id { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public int CourseId { get; set; } = 0;
        public float CourseRatingScore { get; set; } = 0;
        public string CourseComments { get; set; } = "";
        public string CourseStatus { get; set; } = "";

    }
}