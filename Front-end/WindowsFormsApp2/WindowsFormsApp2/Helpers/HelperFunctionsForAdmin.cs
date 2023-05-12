using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2.Helpers
{
    internal class HelperFunctionsForAdmin
    {
        public bool validateCourseData(CourseData course, string coursePrice)
        {
            bool tmam = true;

            if (string.IsNullOrEmpty(course.CourseName))
            {
                MessageBox.Show("Please enter the course name.");
                tmam = false;
            }
            else if (string.IsNullOrEmpty(course.CourseDescription))
            {
                MessageBox.Show("Please enter the course description.");
                tmam = false;
            }
            else if (!int.TryParse(coursePrice, out int price))
            {
                // there is a problem here
                MessageBox.Show("Please enter valid course price.");
                tmam = false;
            }
            else if (string.IsNullOrEmpty(course.CourseGenre))
            {
                MessageBox.Show("Please enter the course genre.");
                tmam = false;
            }
            return tmam ? true : false;
        }
    }
}
