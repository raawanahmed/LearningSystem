using System;
using System.Windows.Forms;
using WindowsFormsApp2.Admin;

namespace WindowsFormsApp2
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void onAddCourseBtn(object sender, EventArgs e)
        {
            Addcourse addcourse = new Addcourse();
            addcourse.Show();
            this.Hide();
        }

        private void onViewCoursesBtn(object sender, EventArgs e)
        {
            ViewCourses viewAllCourses = new ViewCourses();
            viewAllCourses.Show();
            this.Hide();
        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
