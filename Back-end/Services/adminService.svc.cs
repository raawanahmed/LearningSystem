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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "adminService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select adminService.svc or adminService.svc.cs at the Solution Explorer and start debugging.
    public class adminService : IadminService
    {
        private readonly CourseDAL _courseDAL;

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
