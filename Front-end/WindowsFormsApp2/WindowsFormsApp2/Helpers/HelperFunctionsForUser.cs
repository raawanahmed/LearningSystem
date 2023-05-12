using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2.Helpers
{
    internal class HelperFunctionsForUser
    {
        public bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Email is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool isValidPassword(string password)
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
        public bool isValidNames(string firstName, string lastName, string userName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("UserName cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
