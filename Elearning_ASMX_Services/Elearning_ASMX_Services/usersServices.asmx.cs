using Elearning_ASMX_Services.DataModels;
using System.Data.SqlClient;
using System.Web.Services;

namespace Elearning_ASMX_Services
{
    /// <summary>
    /// Summary description for usersServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class usersServices : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertUser(UserData user)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into UsersTable (firstName, lastName, userName, email, password) values (@FirstName, @LastName, @UserName, @Email, @Password)", conn);
            SqlParameter p1 = new SqlParameter("@FirstName", user.FirstName);
            SqlParameter p2 = new SqlParameter("@LastName", user.LastName);
            SqlParameter p3 = new SqlParameter("@UserName", user.UserName);
            SqlParameter p4 = new SqlParameter("@Email", user.Email);
            SqlParameter p5 = new SqlParameter("@Password", user.Password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        [WebMethod]
        public UserData GetUserByUsername(string username)
        {
            // Query database for user by username
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = string.Format("SELECT * FROM UsersTable WHERE Username = '{0}'", username);
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserData user = new UserData();
                    user.Id = reader.GetInt32(0);
                    user.FirstName = reader.GetString(1);
                    user.LastName = reader.GetString(2);
                    user.UserName = reader.GetString(3);
                    user.Email = reader.GetString(4);
                    user.Password = reader.GetString(5);
                    return user;
                }
            }
            return null;
        }
    }
}
