﻿using Back_end.DAL;
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

        [WebMethod]
        public void insertUser(UserModel user)
        {
            _userDAL.createUser(user);
        }

        [WebMethod]
        public void updateUserData(int userId, UserModel user)
        {
            _userDAL.updateUser(userId, user);
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
        
    }
}
