using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    public partial class CartOfCourses : Form
    {
        public CartOfCourses()
        {
            InitializeComponent();
        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();

        }

        private void onBackBtn(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage();
            userHomePage.Show();
            this.Hide();
        }
    }
}
