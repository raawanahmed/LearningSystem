using System;
using System.Security.Cryptography;
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
        public bool Islogin = false;
        public bool IsAdmin = false;
        private void onLoginBtn(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (username == "admin" && password == "Admin123")
            {
                IsAdmin = true;
            }
            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Authenticate user
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (IsAdmin)
                {
                    Islogin = true;
                    AdminHomePage adminHomePage = new AdminHomePage();
                    adminHomePage.Show();
                    this.Hide();
                }
                else
                {
                    Islogin = true;
                    UserHomePage userHomePage = new UserHomePage(user.Id);
                    userHomePage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public static bool VerifyPassword(string password, string hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hash);

            // Get the salt value from the hash
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Compute the hash of the password with the retrieved salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hashToCheck = pbkdf2.GetBytes(20);

            // Compare the computed hash with the stored hash
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hashToCheck[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}