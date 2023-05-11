using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
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
                    Admin f2 = new Admin();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    Islogin = true;
                    Home home = new Home(Islogin);
                    home.Show();
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
            UserData user = new UserData();
            user = usersServices.GetUserByUsername(username);
            if (user == null)
            {
                return false;
            }
            // Verify password
            if (password == user.Password)
            {
                return true;
            }
            // User is authenticated
            return false;
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
        private void onSignupBtn(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}