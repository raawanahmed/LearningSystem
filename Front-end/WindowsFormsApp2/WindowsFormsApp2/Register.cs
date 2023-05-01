using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";

            string username = textBox1.Text;
            string Email = textBox2.Text;
            string password = textBox3.Text;
            string comfirmPassword = textBox4.Text;

            if (string.IsNullOrWhiteSpace(username) ||
       string.IsNullOrWhiteSpace(Email) ||
       string.IsNullOrWhiteSpace(password) ||
       string.IsNullOrWhiteSpace(comfirmPassword))
            {
                label6.Text = "Please fill in all fields";
                label6.ForeColor =Color.Red;
                label6.Font = new Font("Arial", 13);
                return;
            }

            // Check if email is valid
            if (!IsValidEmail(Email))
            {
                label7.Text = "Please enter a valid email address";
                label7.ForeColor = Color.Red;
                label7.Font = new Font("Arial", 13);
                return;
            }

            // Check if Password is valid
            if (!ValidPassword(password))
            {
                label9.Text = "Please enter a valid password ";
                label9.ForeColor = Color.Red;
                label9.Font = new Font("Arial", 13);
                return;
            }

            // Check if password and confirm password match
            if (password != comfirmPassword)
            {
                label8.Text = "Passwords do not match";
                label8.ForeColor = Color.Red;
                label8.Font = new Font("Arial", 13);
                return;
            }

            // All validation and verification passed, so proceed with signup
            SignupUser(username, Email, password);
             MessageBox.Show( "Signup successful!");
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


        private void SignupUser(string firstName, string email, string password)
        {
            // Add code here to store user information in database or perform other actions
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private bool ValidPassword( string password) {

        
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


