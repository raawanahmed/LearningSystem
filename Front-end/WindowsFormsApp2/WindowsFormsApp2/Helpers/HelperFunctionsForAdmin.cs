using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2.Helpers
{
    internal class HelperFunctionsForAdmin
    {
        public bool validateCourseData(CourseData course)
        {
            bool tmam = true;
            if (course == null)
            {
                MessageBox.Show("Please fill all the fields.");
                tmam = false;
            }
            else if (string.IsNullOrEmpty(course.CourseName))
            {
                MessageBox.Show("Please enter the course name.");
                tmam = false;
            }
            else if (string.IsNullOrEmpty(course.CourseDescription))
            {
                MessageBox.Show("Please enter the course description.");
                tmam = false;
            }
            else if (course.CoursePrice <= 0)
            {
                MessageBox.Show("Please enter the course price.");
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
