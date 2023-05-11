using Elearning_WCF_Services.DataModels;
using System.ServiceModel;

namespace Elearning_WCF_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IadminServices" in both code and config file together.
    [ServiceContract]
    public interface IadminServices
    {
        [OperationContract]
        void addCourse(CourseData course);

        [OperationContract]
        void editCourse(int courseId, CourseData course);

        [OperationContract]
        void deleteCourse(int courseId);

        [OperationContract]
        CourseData[] getAllCourses();

        [OperationContract]
        CourseData getCourseData(int courseId);
        [OperationContract]
        int[] getAllCoursesIDs();

    }
}
