using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class UserCourses : Form
    {
        private int userId;
        CourseData[] coursesForUser;
        public UserCourses()
        {
            InitializeComponent();
            allCoursesGridView.ReadOnly = true;
        }
        public UserCourses(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            textBox1.Text = this.userId.ToString();
            allCoursesGridView.ReadOnly = true;
        }
        private void onUserCoursesFormLoad(object sender, EventArgs e)
        {

            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            coursesForUser = usersServices.getEnrolledCoursesForUser(this.userId);
            allCoursesGridView.DataSource = coursesForUser;
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
