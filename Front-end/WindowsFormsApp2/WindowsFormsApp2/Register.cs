using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void onSignupBtn(object sender, EventArgs e)
        {
            allFieldsAlertLabel.Text = " ";
            emailAlertLabel.Text = " ";
            confirmPasswordAlertLabel.Text = " ";
            passwordAlertLabel.Text = " ";
            UserData user = new UserData();
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.UserName = userNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.Password = passwordTeaxtBox.Text;
            string comfirmPassword = comfirmPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(comfirmPassword) ||
                string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.LastName))
            {
                allFieldsAlertLabel.Text = "Please fill in all fields";
                allFieldsAlertLabel.ForeColor = Color.Red;
                allFieldsAlertLabel.Font = new Font("Arial", 13);
                return;
            }

            // Check if email is valid
            if (!IsValidEmail(user.Email))
            {
                emailAlertLabel.Text = "Please enter a valid email address";
                emailAlertLabel.ForeColor = Color.Red;
                emailAlertLabel.Font = new Font("Arial", 13);
                return;
            }

            // Check if Password is valid
            if (!ValidPassword(user.Password))
            {
                passwordAlertLabel.Text = "Please enter a valid password ";
                passwordAlertLabel.ForeColor = Color.Red;
                passwordAlertLabel.Font = new Font("Arial", 13);
                return;
            }

            // Check if password and confirm password match
            if (user.Password != comfirmPassword)
            {
                confirmPasswordAlertLabel.Text = "Passwords do not match";
                confirmPasswordAlertLabel.ForeColor = Color.Red;
                confirmPasswordAlertLabel.Font = new Font("Arial", 13);
                return;
            }

            // All validation and verification passed, so proceed with signup
            SignupUser(user);
            MessageBox.Show("Signup successful!");
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void SignupUser(UserData user)
        {
            // Add code here to store user information in database or perform other actions
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            usersServices.insertUser(user);
        }

        private bool ValidPassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.");
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password must contain at least one lowercase letter.");
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one digit.");
                return false;
            }
            return true;
        }
    }
}