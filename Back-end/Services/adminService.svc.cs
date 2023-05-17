using Back_end.DAL;
using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Back_end.Services
{

    public class adminService : IadminService
    {
        private readonly CourseDAL _courseDAL = new CourseDAL();

        public void addCourse(CourseModel course)
        {
            _courseDAL.addCourse(course);
        }

        public void editCourse(int courseId, CourseModel course)
        {
            _courseDAL.editCourse(courseId, course);
        }

        public void deleteCourse(int courseId)
        {
            _courseDAL.deleteCourse(courseId);
        }

        public CourseModel[] getAllCourses()
        {
            return _courseDAL.getAllCourses();
        }

        public int[] getAllCoursesIDs()
        {
            return _courseDAL.getAllCoursesIDs();
        }

        public CourseModel getCourseData(int courseId)
        {
            return _courseDAL.getCourse(courseId);
        }
    }
}
