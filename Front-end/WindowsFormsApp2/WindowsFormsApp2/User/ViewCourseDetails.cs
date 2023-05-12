using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{

    public partial class ViewCourseDetails : Form
    {
        private int userId;
        public ViewCourseDetails(CourseData course, int userId)
        {

            InitializeComponent();
            viewCourseGridView.ReadOnly = true;
            Viewdetails(course.Id);
            this.userId = userId;
        }
        /*public void Viewdetails(int courseId)
        {
            UserCoursesData[] detailsOfCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            detailsOfCourse = usersServices.getCourseDetails(courseId);
            viewCourseGridView.DataSource = detailsOfCourse;
        }*/
        public void Viewdetails(int courseId)
        {
            UserCoursesData[] detailsOfCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            detailsOfCourse = usersServices.getCourseDetails(courseId);

            viewCourseGridView.AutoGenerateColumns = false;
            viewCourseGridView.Columns.Clear();

            /*DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn();
            userIdColumn.DataPropertyName = "UserId";
            userIdColumn.HeaderText = "User ID";
            viewCourseGridView.Columns.Add(userIdColumn);*/

            DataGridViewTextBoxColumn ratingColumn = new DataGridViewTextBoxColumn();
            ratingColumn.DataPropertyName = "CourseRatingScore";
            ratingColumn.HeaderText = "Rating Scores";
            viewCourseGridView.Columns.Add(ratingColumn);

            DataGridViewTextBoxColumn commentsColumn = new DataGridViewTextBoxColumn();
            commentsColumn.DataPropertyName = "CourseComments";
            commentsColumn.HeaderText = "Course Comments";
            viewCourseGridView.Columns.Add(commentsColumn);

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