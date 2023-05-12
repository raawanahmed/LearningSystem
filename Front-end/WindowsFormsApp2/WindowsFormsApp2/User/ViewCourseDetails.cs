using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{

    public partial class ViewCourseDetails : Form
    {

        // List<CourseDetails> coursesDetails = new List<CourseDetails>();
        private int userId;
        public ViewCourseDetails(CourseData course, int userId)
        {

            InitializeComponent();
            viewCourseGridView.ReadOnly = true;
            Viewdetails(course.Id);
            this.userId = userId;
        }
        public void Viewdetails(int courseId)
        {
            UserCoursesData[] detailsOfCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            detailsOfCourse = usersServices.getCourseDetails(courseId);
            viewCourseGridView.DataSource = detailsOfCourse;

        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage login_Page = new LoginPage();
            login_Page.Show();
            this.Hide();
        }

        private void onBackBtn(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllCourses viewAllCourses = new ViewAllCourses(this.userId);
            viewAllCourses.ShowDialog();
            this.Close();
        }

        private void onAddRateToCourseBtn(object sender, EventArgs e)
        {
            // todo
        }
        private void onAddCommentToCourseBtn(object sender, EventArgs e)
        {
            // todo
        }
    }
}