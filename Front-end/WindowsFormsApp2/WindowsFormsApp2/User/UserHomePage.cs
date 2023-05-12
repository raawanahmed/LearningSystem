using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }

        private void onViewMyCoursesBtn(object sender, EventArgs e)
        {
            UserCourses userCourses = new UserCourses();
            userCourses.Show();
            this.Hide();

        }

        private void onViewAllCoursesBtn(object sender, EventArgs e)
        {
            ViewAllCourses viewAllCourses = new ViewAllCourses();
            viewAllCourses.Show();
            this.Hide();
        }

        private void onViewMyCartBtn(object sender, EventArgs e)
        {
            CartOfCourses cartOfCourses = new CartOfCourses();
            cartOfCourses.Show();
            this.Hide();
        }

        private void onViewMyAccountBtn(object sender, EventArgs e)
        {
            UserAccount myaccount = new UserAccount();
            myaccount.Show();
            this.Hide();
        }
    }
}
