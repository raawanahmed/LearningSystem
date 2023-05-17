using Back_end.DAL;
using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Back_end.Services
{

    [ServiceContract]
    public interface IadminService
    {
        [OperationContract (IsOneWay = true)]
        void addCourse(CourseModel course);

        [OperationContract (IsOneWay = true)]
        void editCourse(int courseId, CourseModel course);

        [OperationContract (IsOneWay = true)]
        void deleteCourse(int courseId);

        [OperationContract]
        CourseModel[] getAllCourses();

        [OperationContract]
        CourseModel getCourseData(int courseId);

        [OperationContract]
        int[] getAllCoursesIDs();
    }
}
