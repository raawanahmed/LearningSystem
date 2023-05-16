using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        HelperFunctionsForUser helperFunctions = new HelperFunctionsForUser();
        public Register()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.PasswordChar = '*';
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
            user.Password = passwordTextBox.Text;
            string comfirmPassword = confirmPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(comfirmPassword) ||
                string.IsNullOrWhiteSpace(user.FirstName) ||
                string.IsNullOrWhiteSpace(user.LastName))
            {
                allFieldsAlertLabel.Text = "Please fill in all fields";
                return;
            }

            // Check if email is valid
            if (!helperFunctions.isValidEmail(user.Email))
            {
                emailAlertLabel.Text = "Please enter a valid email address";
                return;
            }

            // Check if Password is valid
            if (!helperFunctions.isValidPassword(user.Password))
            {
                passwordAlertLabel.Text = "Please enter a valid password ";
                return;
            }

            // Check if password and confirm password match
            if (user.Password != comfirmPassword)
            {
                confirmPasswordAlertLabel.Text = "Passwords do not match";
                return;
            }

            // All validation and verification passed, so proceed with signup
            SignupUser(user);
            MessageBox.Show("Signup successful!");
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        private void SignupUser(UserData user)
        {
            // Add code here to store user information in database or perform other actions
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            usersServices.insertUser(user);
        }
    }
}