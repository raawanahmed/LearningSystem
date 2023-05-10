using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void goToLoginForm(object sender, EventArgs e)
        {
            Login_page loginPage = new Login_page();
            loginPage.Show();
            this.Hide();
        }

        private void goTosignupForm(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
