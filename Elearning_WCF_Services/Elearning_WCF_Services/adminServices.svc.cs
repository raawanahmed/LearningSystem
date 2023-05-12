using Elearning_WCF_Services.DataModels;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Elearning_WCF_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "adminServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select adminServices.svc or adminServices.svc.cs at the Solution Explorer and start debugging.
    public class adminServices : IadminServices
    {
        public void addCourse(CourseData course)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into CoursesTable (courseName, courseDescription, coursePrice, courseInstructor, courseGenre, createdAt) values (@CourseName, @CourseDescription, @CoursePrice, @CourseInstructor, @CourseGenre, @CreatedAt)", conn);
            SqlParameter p1 = new SqlParameter("@CourseName", course.CourseName);
            SqlParameter p2 = new SqlParameter("@CourseDescription", course.CourseDescription);
            SqlParameter p3 = new SqlParameter("@CoursePrice", course.CoursePrice);
            SqlParameter p4 = new SqlParameter("@CourseInstructor", course.CourseInstructor);
            SqlParameter p5 = new SqlParameter("@CourseGenre", course.CourseGenre);
            SqlParameter p6 = new SqlParameter("@CreatedAt", course.CreatedAt);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteCourse(int courseId)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "DELETE FROM CoursesTable WHERE id = @courseId";
            // Create a new SqlConnection object inside a using block to ensure it is disposed of correctly when finished
            using (SqlConnection connection = new SqlConnection(conn))
            {
                // Create a new SqlCommand object with the query and connection
                SqlCommand command = new SqlCommand(query, connection);

                // Add the courseId parameter to the SqlCommand object
                command.Parameters.AddWithValue("@courseId", courseId);

                // Open the connection to the database
                connection.Open();

                // Execute the command to delete the row
                command.ExecuteNonQuery();
                // The connection will automatically be closed and disposed of when the using block is exited
            }
        }

        public void editCourse(int courseId, CourseData course)
        {
            // check this function
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "UPDATE CoursesTable SET courseName = @courseName, courseDescription = @courseDescription, coursePrice = @coursePrice, courseInstructor = @courseInstructor, courseGenre = @courseGenre WHERE id = @courseId";

            // Create a new SqlConnection object inside a using block to ensure it is disposed of correctly when finished
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@courseName", course.CourseName);
                command.Parameters.AddWithValue("@courseDescription", course.CourseDescription);
                command.Parameters.AddWithValue("@coursePrice", course.CoursePrice);
                command.Parameters.AddWithValue("@courseInstructor", course.CourseInstructor);
                command.Parameters.AddWithValue("@courseGenre", course.CourseGenre);
                command.Parameters.AddWithValue("@courseId", courseId);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
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

        public int[] getAllCoursesIDs()
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM CoursesTable";
            List<int> coursesIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    coursesIDs.Add(reader.GetInt32(0));
                }
            }

            return coursesIDs.ToArray();
        }

        public CourseData getCourseData(int courseId)
        {
            string conn = "Data Source=.;Initial Catalog=ElearningSystem;Integrated Security=True";
            string query = "SELECT * FROM CoursesTable WHERE id = @courseId";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CourseData course = new CourseData();
                    course.Id = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    course.CourseDescription = reader.GetString(2);
                    course.CoursePrice = reader.GetInt32(3);
                    course.CourseInstructor = reader.GetString(4);
                    course.CourseGenre = reader.GetString(5);
                    course.CreatedAt = reader.GetDateTime(6);
                    return course;
                }
            }
            return null;
        }
    }
}
