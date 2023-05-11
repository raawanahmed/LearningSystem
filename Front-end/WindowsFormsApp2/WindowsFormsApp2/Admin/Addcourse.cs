using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2
{
    public partial class Addcourse : Form
    {
        public Addcourse()
        {
            InitializeComponent();
        }

        private void onHomePageBtn(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
        private bool validateCourseData(CourseData course)
        {
            bool tmam = true;
            if (course == null)
            {
                MessageBox.Show("Please fill all the fields.");
                tmam = false;
            }
            else if (course.CourseName.Length == 0)
            {
                MessageBox.Show("Please enter the course name.");
                tmam = false;
            }
            else if (course.CourseDescription.Length == 0)
            {
                MessageBox.Show("Please enter the course description.");
                tmam = false;
            }
            else if (course.CoursePrice == 0)
            {
                MessageBox.Show("Please enter the course price.");
                tmam = false;
            }
            else if (course.CourseGenre.Length == 0)
            {
                MessageBox.Show("Please enter the course genre.");
                tmam = false;
            }
            return tmam ? true : false;
        }

        private void onAddCourseBtn(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            CourseData courseData = new CourseData();
            courseData.CourseName = courseNameTextBox.Text;
            courseData.CourseDescription = courseDescriptionTextBox.Text;
            courseData.CoursePrice = int.Parse(coursePriceTextBox.Text);
            courseData.CourseInstructor = courseInstructorNameTextBox.Text;
            courseData.CourseGenre = courseGenre.Text;
            courseData.CreatedAt = DateTime.Now;
            if (validateCourseData(courseData))
            {
                adminServices.addCourse(courseData);
                MessageBox.Show("Course Add successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
