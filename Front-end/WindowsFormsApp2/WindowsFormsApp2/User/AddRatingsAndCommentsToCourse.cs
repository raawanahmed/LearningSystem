using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{

    public partial class AddRatingsAndCommentsToCourse : Form
    {
        private int userId;
        private int courseId;
        public AddRatingsAndCommentsToCourse(CourseData course, int userId)
        {

            InitializeComponent();
            viewCourseGridView.ReadOnly = true;
            Viewdetails(course.Id);
            this.userId = userId;
            this.courseId = course.Id;
            courseDetailsLabel.Text = course.CourseDescription.ToString();
        }
        public void Viewdetails(int courseId)
        {
            UserCoursesData[] detailsOfCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            detailsOfCourse = usersServices.getCourseDetails(courseId);

            viewCourseGridView.AutoGenerateColumns = false;
            viewCourseGridView.Columns.Clear();
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
        private void onAddRateToCourseBtn(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            if (float.TryParse(rateTextBox.Text, out float rate))
            {
                if (rate >= 0 && rate <= 10)
                {
                    UserCoursesData userCourseData = new UserCoursesData();
                    userCourseData.UserId = this.userId;
                    userCourseData.CourseId = this.courseId;
                    userCourseData.CourseRatingScore = rate;
                    usersServices.addRatingScoreToCourse(userCourseData);
                    MessageBox.Show("Rating added to course successfully.");
                    Viewdetails(courseId); // Reload the data
                }
                else
                {
                    MessageBox.Show("Please enter a number between 0 and 10 for the rating.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the rating.");
            }
        }
        private void onAddCommentToCourseBtn(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            string comment = commentTextBox.Text;
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Comment cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserCoursesData userCourseData = new UserCoursesData();
            userCourseData.UserId = this.userId;
            userCourseData.CourseId = this.courseId;
            userCourseData.CourseComments = comment;
            usersServices.addCommentToCourse(userCourseData);
            MessageBox.Show("Comment added to course successfully.");
            Viewdetails(courseId); // Reload the data
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void onBackBtn(object sender, EventArgs e)
        {
            this.Hide();
            UserEnrolledCourses userEnrolledCourses = new UserEnrolledCourses(this.userId);
            userEnrolledCourses.ShowDialog();
        }

    }
}