using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

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

            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "Admin" && password == "Admin")
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
            // Retrieve user from database by username
            UserInfo user = GetUserByUsername(username);
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

        private UserInfo GetUserByUsername(string username)
        {
            // Query database for user by username
            string connectionString = "Data Source=DESKTOP-PUEEIEJ\\MSSQLSERVER01;Initial Catalog=Users_Info;Integrated Security=True";
            string query = string.Format("SELECT * FROM Users WHERE Username = '{0}'", username);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserInfo user = new UserInfo();
                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    return user;
                }
            }

            return null;
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

public class UserInfo
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}