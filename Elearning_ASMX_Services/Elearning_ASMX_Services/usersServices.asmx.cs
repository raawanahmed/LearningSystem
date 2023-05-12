using Elearning_ASMX_Services.DataModels;
using System.Collections.Generic;
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
        public void updateUserData(int userId, UserData user)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = string.Format("UPDATE UsersTable SET firstName=@FirstName, lastName=@LastName, userName=@UserName, email=@Email, password=@Password WHERE id = {0}", userId);
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public UserData GetUserById(int userId)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = string.Format("SELECT * FROM UsersTable WHERE id = {0}", userId);
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

        [WebMethod]
        public CourseData[] getAllCourses()
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM CoursesTable";
            List<CourseData> courses = new List<CourseData>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CourseData course = new CourseData();
                    course.Id = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    course.CourseDescription = reader.GetString(2);
                    course.CoursePrice = reader.GetInt32(3);
                    course.CourseInstructor = reader.GetString(4);
                    course.CourseGenre = reader.GetString(5);
                    course.CreatedAt = reader.GetDateTime(6);
                    courses.Add(course);
                }
            }
            return courses.ToArray();
        }

        [WebMethod]
        public CourseData[] getAllCoursesForUser()
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM CoursesTable";
            List<CourseData> courses = new List<CourseData>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CourseData course = new CourseData();
                    course.Id = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    course.CourseDescription = reader.GetString(2);
                    course.CoursePrice = reader.GetInt32(3);
                    course.CourseInstructor = reader.GetString(4);
                    course.CourseGenre = reader.GetString(5);
                    course.CreatedAt = reader.GetDateTime(6);
                    courses.Add(course);
                }
            }
            return courses.ToArray();
        }

        [WebMethod]
        public UserCoursesData[] getCourseDetails(int courseId)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM UserCoursesTable WHERE courseId = @courseId";
            List<UserCoursesData> courseDetailsOfAllUsers = new List<UserCoursesData>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@courseId", courseId); // add parameter to command
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserCoursesData courseDetails = new UserCoursesData();
                    courseDetails.CourseId = reader.GetInt32(1);
                    courseDetails.UserId = reader.GetInt32(2);

                    if (!reader.IsDBNull(3)) // check if CourseRatingScore is not null
                    {
                        courseDetails.CourseRatingScore = (float)reader.GetDouble(3);
                    }

                    if (!reader.IsDBNull(4)) // check if CourseComments is not null
                    {
                        courseDetails.CourseComments = reader.GetString(4);
                    }

                    if (!reader.IsDBNull(5)) // check if CourseStatus is not null
                    {
                        courseDetails.CourseStatus = reader.GetString(5);
                    }

                    courseDetailsOfAllUsers.Add(courseDetails);
                }
            }
            return courseDetailsOfAllUsers.ToArray();
        }

        public int[] getAllCoursesIDsForUser(int userId)
        {
            // helper function
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM UserCoursesTable WHERE userId = @userId AND courseStatus = 'enrolled'";
            List<int> coursesIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId); // set parameter value
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    coursesIDs.Add(reader.GetInt32(1));
                }
            }
            return coursesIDs.ToArray();
        }


        [WebMethod]
        public CourseData[] getEnrolledCoursesForUser(int userId)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            int[] courseIds = getAllCoursesIDsForUser(userId);
            if (courseIds.Length == 0)
            {
                return new CourseData[0]; // return empty array if no course IDs found
            }
            string query = "SELECT * FROM CoursesTable WHERE Id IN (" + string.Join(",", courseIds) + ")";
            List<CourseData> courses = new List<CourseData>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CourseData course = new CourseData();
                    course.Id = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    course.CourseDescription = reader.GetString(2);
                    course.CoursePrice = reader.GetInt32(3);
                    course.CourseInstructor = reader.GetString(4);
                    course.CourseGenre = reader.GetString(5);
                    course.CreatedAt = reader.GetDateTime(6);
                    courses.Add(course);
                }
            }
            return courses.ToArray();
        }


        public int[] getAllCoursesInCartForUser(int userId)
        {
            // helper function
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM UserCoursesTable WHERE userId = @userId  AND courseStatus = 'in cart'";
            List<int> coursesIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    coursesIDs.Add(reader.GetInt32(1));
                }
            }
            return coursesIDs.ToArray();
        }

        [WebMethod]
        public CourseData[] getCoursesInCart(int userId)
        {
            // get courses with status inCart 
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            int[] courseIds = getAllCoursesInCartForUser(userId);
            if (courseIds.Length == 0)
            {
                return new CourseData[0]; // return empty array if no course IDs found
            }
            string query = "SELECT * FROM CoursesTable WHERE id IN (" + string.Join(",", courseIds) + ")";
            List<CourseData> courses = new List<CourseData>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CourseData course = new CourseData();
                    course.Id = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    course.CourseDescription = reader.GetString(2);
                    course.CoursePrice = reader.GetInt32(3);
                    course.CourseInstructor = reader.GetString(4);
                    course.CourseGenre = reader.GetString(5);
                    course.CreatedAt = reader.GetDateTime(6);
                    courses.Add(course);
                }
            }
            return courses.ToArray();
        }

        [WebMethod]
        public void addUserToCourseWithStatus(int userId, int courseId, string courseStatus)
        {
            // Check if user is already enrolled in the course
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT * FROM UserCoursesTable WHERE userId = @userId AND courseId = @courseId) " +
                                             "INSERT INTO UserCoursesTable (courseId, userId, courseStatus) VALUES (@courseId, @userId, @courseStatus)", conn);
            SqlParameter p1 = new SqlParameter("@courseId", courseId);
            SqlParameter p2 = new SqlParameter("@userId", userId);
            SqlParameter p3 = new SqlParameter("@courseStatus", courseStatus);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        [WebMethod]
        public void addRatingScoreToCourse(float courseRatingScore, int userId, int courseId)
        {
            // edit in rating score in row of userId
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "UPDATE UserCoursesTable SET courseRatingScore = @courseRatingScore WHERE userId = @userId AND courseId = @courseId";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@courseRatingScore", courseRatingScore);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        [WebMethod]
        public void addCommentToCourse(string courseComments, int userId, int courseId)
        {
            // edit in comment score in row of userId
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "UPDATE UserCoursesTable SET courseComments = @courseComments WHERE userId = @userId AND courseId = @courseId";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@courseComments", courseComments);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        [WebMethod]
        public bool updateCourseStatus(int userId, int courseId, string courseStatus)
        {
            // edit in course status to incart
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "UPDATE UserCoursesTable SET courseStatus = @courseStatus WHERE userId = @userId AND courseId = @courseId";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@courseId", courseId);
                command.Parameters.AddWithValue("@courseStatus", courseStatus);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return (rowsAffected > 0); // returns true if at least one row was updated
            }
        }

        [WebMethod]
        public void removeCourseFromCart(int userId, int courseId)
        {
            // remove the course from user's cart
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "DELETE FROM UserCoursesTable WHERE userId = @userId AND courseId = @courseId";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@courseId", courseId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
