using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_end.DAL
{
    public class UserCourseDAL
    {

        public bool addUserCourse(UserCourseModel userCourse){

            string query = "IF NOT EXISTS (SELECT * FROM UserCoursesTable WHERE userId = @userId AND courseId = @courseId)" + "INSERT INTO UserCoursesTable (courseId, userId, courseStatus) VALUES (@courseId, @userId, @courseStatus)";
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@userId", userCourse.UserId);
                cmd.Parameters.AddWithValue("@courseId", userCourse.CourseId);
                cmd.Parameters.AddWithValue("@courseStatus", userCourse.CourseStatus);
                Database.connection.Open();
                return (cmd.ExecuteNonQuery()>0);
            }
        }

        public bool updateUserCourse(UserCourseModel userCourse)
        {
            UserCourseModel oldUserCourse = getUserCourse(userCourse.CourseId);
            string query = "UPDATE UserCoursesTable SET courseRatingScore = @courseRatingScore, courseComments = @courseComments, courseStatus = @courseStatus WHERE userId = @userId AND courseId = @courseId";
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@userId", userCourse.UserId);
                cmd.Parameters.AddWithValue("@courseId", userCourse.CourseId);
                cmd.Parameters.AddWithValue("@courseStatus", (userCourse.CourseStatus != null) ? userCourse.CourseStatus : oldUserCourse.CourseStatus);
                cmd.Parameters.AddWithValue("@courseRatingScore", (userCourse.CourseRatingScore!=0)?userCourse.CourseRatingScore:oldUserCourse.CourseRatingScore);
                cmd.Parameters.AddWithValue("@courseComments", (userCourse.CourseComments != null) ? userCourse.CourseComments : oldUserCourse.CourseComments);
                Database.connection.Open();
                return (cmd.ExecuteNonQuery() > 0);
            }

        }

        public void deleteUserCourse(UserCourseModel userCourse)
        {
            string query = "DELETE FROM UserCoursesTable WHERE userId = @userId AND courseId = @courseId";
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@userId", userCourse.UserId);
                cmd.Parameters.AddWithValue("@courseId", userCourse.CourseId);
                Database.connection.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public UserCourseModel getUserCourse(int courseId)
        {
            string query = string.Format("SELECT * FROM UserCoursesTable WHERE courseId = '{0}'", courseId);
            UserCourseModel userCourse = new UserCourseModel();
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                Database.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userCourse.CourseId = reader.GetInt32(1);
                    userCourse.UserId = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) userCourse.CourseRatingScore = (float)reader.GetDouble(3);
                    if (!reader.IsDBNull(4)) userCourse.CourseComments = reader.GetString(4);
                    if (!reader.IsDBNull(5)) userCourse.CourseStatus = reader.GetString(5);
                }
            }
            return userCourse;
        }

        public UserCourseModel[] getCourseDetails(int courseId)
        {
            string query = string.Format("SELECT * FROM UserCoursesTable WHERE courseId = '{0}'", courseId);
            List<UserCourseModel> courseDetailsOfAllUsers = new List<UserCourseModel>();

            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                Database.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserCourseModel userCourse = new UserCourseModel();
                    userCourse.CourseId = reader.GetInt32(1);
                    userCourse.UserId = reader.GetInt32(2);
                    if (!reader.IsDBNull(3)) userCourse.CourseRatingScore = (float)reader.GetDouble(3);
                    if (!reader.IsDBNull(4)) userCourse.CourseComments = reader.GetString(4);
                    if (!reader.IsDBNull(5)) userCourse.CourseStatus = reader.GetString(5);
                    courseDetailsOfAllUsers.Add(userCourse);
                }

            }
            return courseDetailsOfAllUsers.ToArray();
        }

        public CourseModel[] getCoursesWithSpecificStatus(int userId, string courseStatus) 
        {
            int[] userCourseIds = getUserCoursesIdsWithSpecificStatus(userId, courseStatus);
            string query = "SELECT * FROM CoursesTable WHERE Id IN (" + string.Join(",", userCourseIds) + ")";
            List<CourseModel> courses = new List<CourseModel>();
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                Database.connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CourseModel course = new CourseModel();
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

        public int[] getUserCoursesIdsWithSpecificStatus(int userId, string courseStatus)
        {
            string query = "SELECT * FROM UserCoursesTable WHERE userId = @userId AND courseStatus = @courseStatus";
            List<int> userCoursesIDs = new List<int>();

            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@courseStatus", courseStatus);
                Database.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userCoursesIDs.Add(reader.GetInt32(1));
                }
            }
            return userCoursesIDs.ToArray();
        }

        public UserCourseModel[] getAllUserCourses(string userId)
        {
            string query = string.Format("SELECT * FROM UserCoursesTable WHERE Username = '{0}'", userId);
            List <UserCourseModel> userCourses = new List<UserCourseModel>();
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                Database.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserCourseModel userCourse = new UserCourseModel();
                    userCourse.CourseId = reader.GetInt32(1);
                    userCourse.UserId = reader.GetInt32(2);
                    if (!reader.IsDBNull(3))  userCourse.CourseRatingScore = (float)reader.GetDouble(3);
                    if (!reader.IsDBNull(4))  userCourse.CourseComments = reader.GetString(4);
                    if (!reader.IsDBNull(5))  userCourse.CourseStatus = reader.GetString(5);
                    
                    userCourses.Add(userCourse);
                }
            }
            return userCourses.ToArray();
        }




    }
}