using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class UserEnrolledCourses : Form
    {
        private int userId;
        CourseData[] coursesForUser;
        public UserEnrolledCourses()
        {
            InitializeComponent();
            allCoursesGridView.ReadOnly = true;
        }
        public UserEnrolledCourses(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            allCoursesGridView.ReadOnly = true;
        }
        private void onUserCoursesFormLoad(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            coursesForUser = usersServices.getEnrolledCoursesForUser(this.userId);
            GridViewData(coursesForUser);
            // allCoursesGridView.DataSource = coursesForUser;
        }
        public void GridViewData(CourseData[] courses)
        {
            allCoursesGridView.DataSource = courses;
            DataGridViewButtonColumn addRatingAndComments = new DataGridViewButtonColumn();
            addRatingAndComments.HeaderText = "Add rating and comment To Course";
            addRatingAndComments.Name = "Add rating and comment To Course";
            addRatingAndComments.Text = "Add rating and comment To Course";
            addRatingAndComments.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(addRatingAndComments);

        }
        private void allUserCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddRatingsAndCommentsToCourse courseView;
            if (e.ColumnIndex == 7)
            {
                for (int i = 0; i < coursesForUser.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        courseView = new AddRatingsAndCommentsToCourse(coursesForUser[i], this.userId);
                        courseView.Show();
                        break;
                    }
                }
            }
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        private void onBackBtn(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage(this.userId);
            userHomePage.Show();
            this.Hide();
        }
    }
}
