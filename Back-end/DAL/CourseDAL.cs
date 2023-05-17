using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_end.DAL
{
    public class CourseDAL
    {

        public void addCourse(CourseModel course)
        {

            string query = "insert into CoursesTable (courseName, courseDescription, coursePrice, courseInstructor, courseGenre, createdAt) values (@CourseName, @CourseDescription, @CoursePrice, @CourseInstructor, @CourseGenre, @CreatedAt)";
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
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
                Database.connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void editCourse(int courseId, CourseModel course)
        {
            string query = "UPDATE CoursesTable SET courseName = @courseName, courseDescription = @courseDescription, coursePrice = @coursePrice, courseInstructor = @courseInstructor, courseGenre = @courseGenre WHERE id = @courseId";

            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@courseName", course.CourseName);
                cmd.Parameters.AddWithValue("@courseDescription", course.CourseDescription);
                cmd.Parameters.AddWithValue("@coursePrice", course.CoursePrice);
                cmd.Parameters.AddWithValue("@courseInstructor", course.CourseInstructor);
                cmd.Parameters.AddWithValue("@courseGenre", course.CourseGenre);
                cmd.Parameters.AddWithValue("@courseId", courseId);

                Database.connection.Open();
                cmd.ExecuteNonQuery();

            }

        }

        public void deleteCourse(int courseId)
        {
            string query = "DELETE FROM CoursesTable WHERE id = @courseId";

            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);

                cmd.Parameters.AddWithValue("@courseId", courseId);

                Database.connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public CourseModel getCourse(int courseId)
        {
            string query = "SELECT * FROM CoursesTable WHERE id = @courseId";
            using (Database.connection)
            {
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                Database.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CourseModel course = new CourseModel();
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

        public CourseModel[] getAllCourses()
        {
            string query = "SELECT * FROM CoursesTable";
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

        public int[] getAllCoursesIDs()
        {
            CourseModel[] courses = getAllCourses();
            List<int> coursesIDs = new List<int>();
            foreach (CourseModel course in courses)
            {
                coursesIDs.Add(course.Id);
            }
            return coursesIDs.ToArray();
        }

    }
}