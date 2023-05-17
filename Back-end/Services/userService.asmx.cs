using Back_end.DAL;
using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Back_end.Services
{
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class userService : System.Web.Services.WebService
    {
        private readonly UserDAL _userDAL = new UserDAL();
        private readonly UserCourseDAL _userCourseDAL = new UserCourseDAL();
        private readonly CourseDAL _courseDAL = new CourseDAL();

        [WebMethod]
        public void insertUser(UserModel user)
        {
            _userDAL.createUser(user);
        }

        [WebMethod]
        public void updateUserData(UserModel user)
        {
            _userDAL.updateUser(user);
        }

        [WebMethod]
        public UserModel getUserById(int userId)
        {
            return _userDAL.getUserById(userId);
        }

        [WebMethod]
        public UserModel getUserByUsername(string username)
        {
            return _userDAL.getUserByUsername(username);
        }

        [WebMethod]
        public bool addCourseToUserWithStatus(UserCourseModel userCourse)
        {
            return _userCourseDAL.addUserCourse(userCourse);
        }

        [WebMethod]
        public bool updateCourseStatus(UserCourseModel userCourse)
        {
            return _userCourseDAL.updateUserCourse(userCourse);
        }

        [WebMethod]
        public void addRatingScoreToCourse(UserCourseModel userCourse)
        {
            _userCourseDAL.updateUserCourse(userCourse);
        }


        [WebMethod]
        public void addCommentToCourse(UserCourseModel userCourse)
        {
            _userCourseDAL.updateUserCourse(userCourse);
        }


        [WebMethod]
        public void removeCourseFromCart(UserCourseModel userCourse)
        {
            _userCourseDAL.deleteUserCourse(userCourse);
        }

        [WebMethod]
        public UserCourseModel[] getCourseDetails(int courseId)
        {
            return _userCourseDAL.getCourseDetails(courseId);
        }

        [WebMethod]
        public CourseModel[] getCoursesInCart(int userId)
        {
            return _userCourseDAL.getCoursesWithSpecificStatus(userId, "in cart");
        }


        [WebMethod]
        public CourseModel[] getEnrolledCoursesForUser(int userId)
        {
            return _userCourseDAL.getCoursesWithSpecificStatus(userId, "enrolled");
        }

        [WebMethod]
        public CourseModel[] getBoughtCoursesForUser(int userId)
        {
            return _userCourseDAL.getCoursesWithSpecificStatus(userId, "bought");
        }


        [WebMethod]
        public CourseModel[] getAllCoursesForUser()
        {
            return _courseDAL.getAllCourses();
        }



    }
}
