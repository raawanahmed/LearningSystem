using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2
{
    public partial class Addcourse : Form
    {
        HelperFunctionsForAdmin helperFunctionsForAdmin = new HelperFunctionsForAdmin();
        public Addcourse()
        {
            InitializeComponent();
        }
        private void onAddCourseBtn(object sender, EventArgs e)
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
            courseData.CourseGenre = courseGenre.Text;
            courseData.CreatedAt = DateTime.Now;
            if (helperFunctionsForAdmin.validateCourseData(courseData))
            {
                adminServices.addCourse(courseData);
                MessageBox.Show("Course Add successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
