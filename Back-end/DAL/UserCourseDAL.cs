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

        public void addUserCourse(UserCourseModel userCourse){


        }


        public UserCourseModel[] getUserCourseWithSpecificStatus(int userId, string courseStatus) 
        {
            string query = "SELECT * FROM UserCoursesTable WHERE userId = @userId AND courseStatus = @courseStatus";



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