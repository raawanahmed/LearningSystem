using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class UserBoughtCourses : Form
    {
        private int userId;
        CourseData[] userBoughtCourses;
        public UserBoughtCourses(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            userBoughtCoursesGridView.ReadOnly = true;
        }
        private void onUserBoughtCoursesFormLoad(object sender, EventArgs e)
        {
            GridViewData();
        }
        public void GridViewData()
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            // get courses with status bought
            userBoughtCourses = usersServices.getBoughtCoursesForUser(this.userId);
            userBoughtCoursesGridView.Columns.Clear();
            userBoughtCoursesGridView.DataSource = userBoughtCourses;
            DataGridViewButtonColumn enrollToTheCourse = new DataGridViewButtonColumn();
            enrollToTheCourse.HeaderText = "Enroll to the Course";
            enrollToTheCourse.Name = "Enroll";
            enrollToTheCourse.Text = "Enroll";
            enrollToTheCourse.UseColumnTextForButtonValue = true;
            userBoughtCoursesGridView.Columns.Add(enrollToTheCourse);

        }
        private void userBoughtCoursesGridViewContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
                UserCoursesData userCourseData = new UserCoursesData();
                userCourseData.UserId = this.userId;
                userCourseData.CourseId = userBoughtCourses[e.RowIndex].Id;
                userCourseData.CourseStatus = "enrolled";
                bool updated = usersServices.updateCourseStatus(userCourseData);
                GridViewData();
                MessageBox.Show("You have enrolled to the course successfully!");
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
