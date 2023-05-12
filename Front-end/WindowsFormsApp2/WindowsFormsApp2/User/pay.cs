using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    public partial class Pay : Form
    {
        private int userId;
        private int courseId;
        private int coursePrice;
        public Pay()
        {
            InitializeComponent();
        }
        public Pay(int userId, int courseId, int coursePrice)
        {
            InitializeComponent();
            this.userId = userId;
            this.courseId = courseId;
            this.coursePrice = coursePrice;
            totalTextBox.Text = this.coursePrice.ToString();
            totalTextBox.Enabled = false;
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
        private bool isValidCreditCardNumber(string creditCardNumber)
        {
            // Remove all non-digit characters
            string digitsOnly = Regex.Replace(creditCardNumber, "[^0-9]", "");

            // Check if the number has a valid length
            if (digitsOnly.Length < 13 || digitsOnly.Length > 16)
            {
                return false;
            }

            // Calculate the check digit using the Luhn algorithm
            int sum = 0;
            bool isAlternate = false;
            for (int i = digitsOnly.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(digitsOnly[i].ToString());

                if (isAlternate)
                {
                    digit *= 2;

                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                isAlternate = !isAlternate;
            }

            return sum % 10 == 0;
        }

        private bool validateCreditCard()
        {
            string creditCardNumber = cardNumberTextBox.Text;
            DateTime expirationDate = expirarionDateTimePicker.Value.Date;
            int cvv = int.Parse(cvvTextBox.Text);

            /* if (!isValidCreditCardNumber(creditCardNumber))
             {
                 MessageBox.Show("Invalid credit card number");
                 return false;
             }
            */

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
                bool updated = usersServices.updateCourseStatus(this.userId, this.courseId, "enrolled");
                if (updated)
                {
                    MessageBox.Show("Payment successfully!");
                }
            }
        }
    }
}
