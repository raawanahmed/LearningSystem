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
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            courses = usersServices.getAllCoursesForUser();
            GridViewData(courses);
        }

        /* public void GridViewData(CourseData[] courses)
         {

             allCoursesGridView.DataSource = courses;

             DataGridViewButtonColumn viewCourseDetailsBtn = new DataGridViewButtonColumn();
             viewCourseDetailsBtn.HeaderText = "View Course Details";
             viewCourseDetailsBtn.Name = "View Course Details";
             viewCourseDetailsBtn.Text = "View Course Details";
             viewCourseDetailsBtn.UseColumnTextForButtonValue = true;
             allCoursesGridView.Columns.Add(viewCourseDetailsBtn);


             DataGridViewButtonColumn addToCartBtn = new DataGridViewButtonColumn();
             addToCartBtn.HeaderText = "Add To Cart";
             addToCartBtn.Name = "Add To Cart";
             addToCartBtn.Text = "Add To Cart";
             addToCartBtn.UseColumnTextForButtonValue = true;
             allCoursesGridView.Columns.Add(addToCartBtn);

         }*/
        private void GridViewData(CourseData[] courses)
        {
            // Filter courses based on search text
            string search = searchTextBox.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                courses = courses.Where(c => c.CourseName.ToLower().Contains(search)).ToArray();
            }

            // Bind filtered courses to grid view
            allCoursesGridView.DataSource = courses;

            DataGridViewButtonColumn viewCourseDetailsBtn = new DataGridViewButtonColumn();
            viewCourseDetailsBtn.HeaderText = "View Course Details";
            viewCourseDetailsBtn.Name = "View Course Details";
            viewCourseDetailsBtn.Text = "View Course Details";
            viewCourseDetailsBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(viewCourseDetailsBtn);

            DataGridViewButtonColumn addToCartBtn = new DataGridViewButtonColumn();
            addToCartBtn.HeaderText = "Add To Cart";
            addToCartBtn.Name = "Add To Cart";
            addToCartBtn.Text = "Add To Cart";
            addToCartBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(addToCartBtn);
        }

        private void onSearchTextChange(object sender, EventArgs e)
        {
            GridViewData(courses);
        }


        private void allCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            // AddRatingsAndCommentsToCourse courseView;
            ViewCourseRatingsAndComments courseView;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();

            if (e.ColumnIndex == 7)
            {
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        courseView = new ViewCourseRatingsAndComments(courses[i], this.userId);
                        courseView.Show();
                        this.Hide();
                        break;
                    }
                }
            }
            else if (e.ColumnIndex == 8)
            {
                // add course to cart 
                // todo add check to database add course if the course is not already added
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        // this function check if user is already has a relation with this course before, if not it will insert it
                        bool isAdded = usersServices.addUserToCourseWithStatus(this.userId, courses[i].Id, "in cart");
                        if (isAdded)
                        {
                            MessageBox.Show("Course Added to cart successfully!");
                        }
                        else
                        {
                            MessageBox.Show("You are already enrolled in the course or the course already in the cart");
                        }
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

        private void onViewCartBtn(object sender, EventArgs e)
        {
            CartOfCourses cartOfCourses = new CartOfCourses(this.userId);
            cartOfCourses.Show();
            this.Hide();
        }
    }
}

