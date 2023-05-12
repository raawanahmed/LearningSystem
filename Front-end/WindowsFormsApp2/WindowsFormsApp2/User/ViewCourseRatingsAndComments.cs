using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class ViewCourseRatingsAndComments : Form
    {
        private int userId;
        private int courseId;
        public ViewCourseRatingsAndComments(CourseData course, int userId)
        {

            InitializeComponent();
            viewCourseGridView.ReadOnly = true;
            Viewdetails(course.Id);
            this.userId = userId;
            this.courseId = course.Id;
        }
        public void Viewdetails(int courseId)
        {
            UserCoursesData[] detailsOfCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            detailsOfCourse = usersServices.getCourseDetails(courseId);

            viewCourseGridView.AutoGenerateColumns = false;
            viewCourseGridView.DataSource = detailsOfCourse;
            DataGridViewTextBoxColumn ratingColumn = new DataGridViewTextBoxColumn();
            ratingColumn.DataPropertyName = "CourseRatingScore";
            ratingColumn.HeaderText = "Rating Scores";
            viewCourseGridView.Columns.Add(ratingColumn);

            DataGridViewTextBoxColumn commentsColumn = new DataGridViewTextBoxColumn();
            commentsColumn.DataPropertyName = "CourseComments";
            commentsColumn.HeaderText = "Course Comments";
            viewCourseGridView.Columns.Add(commentsColumn);

        }
        private void onBackBtn(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllCourses viewAllCourses = new ViewAllCourses(this.userId);
            viewAllCourses.ShowDialog();
            this.Close();
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage login_Page = new LoginPage();
            login_Page.Show();
            this.Hide();
        }
    }
}
