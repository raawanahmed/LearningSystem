using System;
using System.Windows.Forms;
using WindowsFormsApp2.User;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class LoginPage : Form
    {
        UserData user = new UserData();
        public LoginPage()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }
        private void onLoginBtn(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username == "admin" && password == "Admin123")
            {
                AdminHomePage adminHomePage = new AdminHomePage();
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminHomePage.Show();
                this.Hide();
                return;
            }
            // Authenticate user
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserHomePage userHomePage = new UserHomePage(user.Id);
                userHomePage.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool AuthenticateUser(string username, string password)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            user = usersServices.getUserByUsername(username);
            if (user == null)
            {
                return false;
            }
            if (password == user.Password)
            {
                return true;
            }
            return false;
        }
        private void onSignupBtn(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}