using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.User;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2
{
    public partial class ViewAllCourses : Form
    {

        CourseData[] courses;
        private int userId;
        public ViewAllCourses()
        {
            InitializeComponent();
            allCoursesGridView.ReadOnly = true;
        }
        public ViewAllCourses(int userId)
        {
            InitializeComponent();
            allCoursesGridView.ReadOnly = true;
            this.userId = userId;
        }

        private void onViewAllCoursesFormLoad(object sender, EventArgs e)
        {
            GridViewData();
        }
        private void GridViewData()
        {
            // Filter courses based on search text
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            courses = usersServices.getAllCoursesForUser();
            allCoursesGridView.Columns.Clear();
            string search = searchTextBox.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                courses = courses.Where(c => c.CourseName.ToLower().Contains(search)).ToArray();
            }

            // Bind filtered courses to grid view
            allCoursesGridView.DataSource = courses;

            DataGridViewButtonColumn viewCourseDetailsBtn = new DataGridViewButtonColumn();
            viewCourseDetailsBtn.HeaderText = "View Course Ratings";
            viewCourseDetailsBtn.Name = "View";
            viewCourseDetailsBtn.Text = "View";
            viewCourseDetailsBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(viewCourseDetailsBtn);

            DataGridViewButtonColumn addToCartBtn = new DataGridViewButtonColumn();
            addToCartBtn.HeaderText = "Add To Cart";
            addToCartBtn.Name = "Add";
            addToCartBtn.Text = "Add";
            addToCartBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(addToCartBtn);
        }

        private void onSearchTextChange(object sender, EventArgs e)
        {
            GridViewData();
        }

        private void allCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            // AddRatingsAndCommentsToCourse courseView;
            ViewCourseRatingsAndComments courseView;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();

            if (e.ColumnIndex == 7)
            {
                courseView = new ViewCourseRatingsAndComments(courses[e.RowIndex], this.userId);
                courseView.Show();
                this.Hide();

            }
            else if (e.ColumnIndex == 8)
            {
                // add course to cart 
                // this function check if user is already has a relation with this course before, if not it will insert it
                UserCoursesData userCourseData = new UserCoursesData();
                userCourseData.UserId = this.userId;
                userCourseData.CourseId = courses[e.RowIndex].Id;
                userCourseData.CourseStatus = "in cart";
                bool isAdded = usersServices.addUserToCourseWithStatus(userCourseData);
                if (isAdded)
                {
                    MessageBox.Show("Course Added to cart successfully!");
                }
                else
                {
                    MessageBox.Show("You are already enrolled in the course or the course already in the cart");
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

        private void onViewCartBtn(object sender, EventArgs e)
        {
            CartOfCourses cartOfCourses = new CartOfCourses(this.userId);
            cartOfCourses.Show();
            this.Hide();
        }
    }
}

