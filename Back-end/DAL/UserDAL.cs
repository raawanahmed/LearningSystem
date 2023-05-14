using Back_end.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back_end.DAL
{
    public class UserDAL
    {

        public void createUser(UserModel user){
            Database.connection.Open();
            string query = "insert into UsersTable (firstName, lastName, userName, email, password) values (@FirstName, @LastName, @UserName, @Email, @Password)";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlParameter p1 = new SqlParameter("@FirstName", user.FirstName);
            SqlParameter p2 = new SqlParameter("@LastName", user.LastName);
            SqlParameter p3 = new SqlParameter("@UserName", user.UserName);
            SqlParameter p4 = new SqlParameter("@Email", user.Email);
            SqlParameter p5 = new SqlParameter("@Password", user.Password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.ExecuteNonQuery();
            Database.connection.Close();
        }

        //No need to send ID it's fine to only send user obj
        public void updateUser(int userId, UserModel user){
            Database.connection.Open();
            string query = string.Format("UPDATE UsersTable SET firstName=@FirstName, lastName=@LastName, userName=@UserName, email=@Email, password=@Password WHERE id = {0}", userId);
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.ExecuteNonQuery();
            Database.connection.Close();
        }

        public UserModel getUserById(int userId){
            Database.connection.Open();
            string query = string.Format("SELECT * FROM UsersTable WHERE id = {0}", userId);
            SqlCommand command = new SqlCommand(query, Database.connection);
            SqlDataReader reader = command.ExecuteReader();
            Database.connection.Close();
            if (reader.Read())
            {
                UserModel user = new UserModel();
                user.Id = reader.GetInt32(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader.GetString(2);
                user.UserName = reader.GetString(3);
                user.Email = reader.GetString(4);
                user.Password = reader.GetString(5);
                return user;
            }
            return null;
        }

        public UserModel getUserByUsername(string userName)
        {
            Database.connection.Open();
            string query = string.Format("SELECT * FROM UsersTable WHERE Username = {0}", userName);
            SqlCommand command = new SqlCommand(query, Database.connection);
            SqlDataReader reader = command.ExecuteReader();
            Database.connection.Close();
            if (reader.Read())
            {
                UserModel user = new UserModel();
                user.Id = reader.GetInt32(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader.GetString(2);
                user.UserName = reader.GetString(3);
                user.Email = reader.GetString(4);
                user.Password = reader.GetString(5);
                return user;
            }
            return null;
        }

    }
}