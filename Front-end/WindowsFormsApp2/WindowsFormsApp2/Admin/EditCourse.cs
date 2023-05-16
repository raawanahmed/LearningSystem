using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2
{
    public partial class EditCourse : Form
    {
        CourseData courseToBeEdited;
        HelperFunctionsForAdmin helperFunctionsForAdmin = new HelperFunctionsForAdmin();
        public EditCourse(CourseData course)
        {
            InitializeComponent();
            this.courseToBeEdited = course;
        }

        private void onEditCourseBtn(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            CourseData courseData = new CourseData();
            courseData.CourseName = courseNameTextBox.Text;
            courseData.CourseDescription = courseDescriptionTextBox.Text;
            try
            {
                courseData.CoursePrice = int.Parse(coursePriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid course price.");
                return;
            }
            courseData.CourseInstructor = courseInstructorNameTextBox.Text;
            courseData.CourseGenre = courseGenreTextBox.Text;
            courseData.CreatedAt = DateTime.Now;
            if (helperFunctionsForAdmin.validateCourseData(courseData))
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
        private void onHomePageBtn(object sender, EventArgs e)
        {
            AdminHomePage admin = new AdminHomePage();
            admin.Show();
            this.Hide();
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
