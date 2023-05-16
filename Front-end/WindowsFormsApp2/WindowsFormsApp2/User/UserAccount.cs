using System;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;
using WindowsFormsApp2.User;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class UserAccount : Form
    {
        private int userId;
        HelperFunctionsForUser helperFunctions = new HelperFunctionsForUser();
        public UserAccount(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void onUserAccountFormLoad(object sender, EventArgs e)
        {
            // load user data
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            UserData userData = usersServices.getUserById(userId);
            firstNameTextBox.Text = userData.FirstName;
            lastNameTextBox.Text = userData.LastName;
            userNameTextBox.Text = userData.UserName;
            emailTextBox.Text = userData.Email;
            passwordTeaxtBox.Text = userData.Password;
        }
        private bool isValid(string firstName, string lastName, string userName, string email, string password)
        {

            bool checkNames = helperFunctions.isValidNames(firstName, lastName, userName);
            bool validPass = helperFunctions.isValidPassword(password);
            bool validEmail = helperFunctions.isValidEmail(email);
            return checkNames && validEmail && validPass;
        }

        private void onEditBtn(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            UserData userData = new UserData();
            userData.FirstName = firstNameTextBox.Text;
            userData.LastName = lastNameTextBox.Text;
            userData.UserName = userNameTextBox.Text;
            userData.Email = emailTextBox.Text;
            userData.Password = passwordTeaxtBox.Text;
            if (isValid(userData.FirstName, userData.LastName, userData.UserName, userData.Email, userData.Password))
            {
                usersServices.updateUserData(this.userId, userData);
                MessageBox.Show("User Edited successfully!");
            }
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();

        }
        private void onBackBtn(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage(this.userId);
            userHomePage.Show();
            this.Hide();
        }

    }
}
