﻿using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class CartOfCourses : Form
    {

        CourseData[] coursesInCart;
        private int userId;
        public CartOfCourses()
        {
            InitializeComponent();
            coursesInCartGridView.ReadOnly = true;
        }
        public CartOfCourses(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            coursesInCartGridView.ReadOnly = true;
        }
        private void onCartOfCoursesFormLoad(object sender, EventArgs e)
        {
            //userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            //coursesInCart = usersServices.getCoursesInCart(this.userId);
            GridViewData();
        }
        public void GridViewData()
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            coursesInCart = usersServices.getCoursesInCart(this.userId);
            coursesInCartGridView.Columns.Clear();
            coursesInCartGridView.DataSource = coursesInCart;
            // enroll into course update the course status to enrolled
            DataGridViewButtonColumn buyCourseBtn = new DataGridViewButtonColumn();
            buyCourseBtn.HeaderText = "Buy the course";
            buyCourseBtn.Name = "Buy the course";
            buyCourseBtn.Text = "Buy the course";
            buyCourseBtn.UseColumnTextForButtonValue = true;
            coursesInCartGridView.Columns.Add(buyCourseBtn);

            // remove from cart
            DataGridViewButtonColumn removeCourseFromCartBtn = new DataGridViewButtonColumn();
            removeCourseFromCartBtn.HeaderText = "Remove course From Cart";
            removeCourseFromCartBtn.Name = "Remove course From Cart";
            removeCourseFromCartBtn.Text = "Remove course From Cart";
            removeCourseFromCartBtn.UseColumnTextForButtonValue = true;
            coursesInCartGridView.Columns.Add(removeCourseFromCartBtn);

        }

        private void coursesInCartGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pay payForCourse;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();

            if (e.ColumnIndex == 7)
            {
                // enroll for course -> pay for it
                for (int i = 0; i < coursesInCart.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        payForCourse = new Pay(this.userId, coursesInCart[i].Id, coursesInCart[i].CoursePrice);
                        payForCourse.Show();
                        this.Hide();
                        break;
                    }
                }

            }
            else if (e.ColumnIndex == 8)
            {
                // remove course from cart
                for (int i = 0; i < coursesInCart.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        UserCoursesData userCourseData = new UserCoursesData();
                        userCourseData.UserId = this.userId;
                        userCourseData.CourseId = coursesInCart[i].Id;
                        usersServices.removeCourseFromCart(userCourseData);
                        GridViewData();
                        MessageBox.Show("Course removed from cart successfully!");
                        break;
                    }
                }

            }
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
        private void onBackBtn(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage(this.userId);
            userHomePage.Show();
            this.Hide();
        }
    }
}
