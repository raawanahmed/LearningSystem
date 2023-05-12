namespace Elearning_ASMX_Services.DataModels
{
    public class UserCoursesData
    {
        public int Id { get; set; } = 0;
        public int CourseId { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public string CourseRatingScore { get; set; } = "";
        public string CourseComments { get; set; } = "";
        public string CourseStatus { get; set; } = "";

    }
}