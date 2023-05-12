using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    public partial class UserHomePage : Form
    {
        public int UserId { get; set; }
        public UserHomePage()
        {
            InitializeComponent();
        }
        public UserHomePage(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
            textBox1.Text = this.UserId.ToString();
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage login_Page = new LoginPage();
            login_Page.Show();
            this.Hide();
        }

        private void onViewMyCoursesBtn(object sender, EventArgs e)
        {
            UserCourses userCourses = new UserCourses(this.UserId);
            userCourses.Show();
            this.Hide();
        }

        private void onViewAllCoursesBtn(object sender, EventArgs e)
        {
            ViewAllCourses viewAllCourses = new ViewAllCourses(this.UserId);
            viewAllCourses.Show();
            this.Hide();
        }

        private void onViewMyCartBtn(object sender, EventArgs e)
        {
            CartOfCourses cartOfCourses = new CartOfCourses(this.UserId);
            cartOfCourses.Show();
            this.Hide();
        }

        private void onViewMyAccountBtn(object sender, EventArgs e)
        {
            UserAccount myaccount = new UserAccount(this.UserId);
            myaccount.Show();
            this.Hide();
        }
    }
}
