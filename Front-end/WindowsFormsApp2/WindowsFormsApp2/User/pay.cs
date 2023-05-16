using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class Pay : Form
    {
        private int userId;
        private int courseId;
        private int coursePrice;
        public Pay(int userId, int courseId, int coursePrice)
        {
            InitializeComponent();
            this.userId = userId;
            this.courseId = courseId;
            this.coursePrice = coursePrice;
            totalTextBox.Text = this.coursePrice.ToString();
            totalTextBox.Enabled = false;
        }
        private bool validateCreditCard()
        {
            string creditCardNumber = cardNumberTextBox.Text;
            DateTime expirationDate = expirarionDateTimePicker.Value.Date;
            int cvv = int.Parse(cvvTextBox.Text);
            if (creditCardNumber.Length != 16)
            {
                MessageBox.Show("Invalid credit card number");
                return false;
            }
            if (expirationDate < DateTime.Now.Date)
            {
                MessageBox.Show("Credit card has expired");
                return false;
            }

            if (cvv.ToString().Length != 3)
            {
                MessageBox.Show("Invalid CVV");
                return false;
            }

            return true;
        }

        private void onPayToEnrollCourseBtn(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            if (validateCreditCard())
            {
                UserCoursesData userCourseData = new UserCoursesData();
                userCourseData.UserId = this.userId;
                userCourseData.CourseId = this.courseId;
                userCourseData.CourseStatus = "bought";
                bool updated = usersServices.updateCourseStatus(userCourseData);
                if (updated)
                {
                    MessageBox.Show("Payment successfully!");
                    UserBoughtCourses userBoughtCourses = new UserBoughtCourses(this.userId);
                    userBoughtCourses.Show();
                    this.Hide();
                }
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
            CartOfCourses cartOfCourses = new CartOfCourses(this.userId);
            cartOfCourses.Show();
            this.Hide();
        }
    }
}
