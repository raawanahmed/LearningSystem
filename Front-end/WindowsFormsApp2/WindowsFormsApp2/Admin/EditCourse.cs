using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2
{
    public partial class EditCourse : Form
    {
        CourseData courseToBeEdited;
        public EditCourse()
        {
            InitializeComponent();
        }
        public EditCourse(CourseData course)
        {
            InitializeComponent();
            this.courseToBeEdited = course;
        }
        private void onHomePageBtn(object sender, EventArgs e)
        {
            AdminHomePage admin = new AdminHomePage();
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
        private void onEditCourseBtn(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            CourseData courseData = new CourseData();
            courseData.CourseName = courseNameTextBox.Text;
            courseData.CourseDescription = courseDescriptionTextBox.Text;
            courseData.CoursePrice = int.Parse(coursePriceTextBox.Text);
            courseData.CourseInstructor = courseInstructorNameTextBox.Text;
            courseData.CourseGenre = courseGenreTextBox.Text;
            courseData.CreatedAt = DateTime.Now;
            if (validateCourseData(courseData))
            {
                adminServices.editCourse(this.courseToBeEdited.Id, courseData);
                MessageBox.Show("Course Edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void onEditCourseFormLoad(object sender, EventArgs e)
        {
            courseIdTextBox.Text = this.courseToBeEdited.Id.ToString();
            courseNameTextBox.Text = this.courseToBeEdited.CourseName;
            courseDescriptionTextBox.Text = this.courseToBeEdited.CourseDescription;
            coursePriceTextBox.Text = this.courseToBeEdited.CoursePrice.ToString();
            courseInstructorNameTextBox.Text = this.courseToBeEdited.CourseGenre;
            courseInstructorNameTextBox.Text = this.courseToBeEdited.CourseInstructor;
            courseGenreTextBox.Text = this.courseToBeEdited.CourseGenre;
        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        private void onBackBtn(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
