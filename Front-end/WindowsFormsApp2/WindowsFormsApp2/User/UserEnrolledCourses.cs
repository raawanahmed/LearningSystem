﻿using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class UserEnrolledCourses : Form
    {
        private int userId;
        CourseData[] coursesForUser;
        public UserEnrolledCourses(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            allCoursesGridView.ReadOnly = true;

        }
        private void onUserCoursesFormLoad(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            coursesForUser = usersServices.getEnrolledCoursesForUser(this.userId);
            GridViewData(coursesForUser);
            // allCoursesGridView.DataSource = coursesForUser;
        }
        public void GridViewData(CourseData[] courses)
        {
            allCoursesGridView.DataSource = courses;
            DataGridViewButtonColumn addRatingAndComments = new DataGridViewButtonColumn();
            addRatingAndComments.HeaderText = "Add rating and comment To Course";
            addRatingAndComments.Name = "Add";
            addRatingAndComments.Text = "Add";
            addRatingAndComments.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(addRatingAndComments);

        }
        private void allUserCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddRatingsAndCommentsToCourse courseView;
            if (e.ColumnIndex == 7)
            {
                courseView = new AddRatingsAndCommentsToCourse(coursesForUser[e.RowIndex], this.userId);
                courseView.Show();
                this.Hide();
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
