using System;
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

        public void GridViewData(CourseData[] courses)
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

        }

        private void allCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewCourseDetails courseView;
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();

            if (e.ColumnIndex == 7)
            {
                // view course details
                if (searchTextBox.Text == "")
                {
                    for (int i = 0; i < courses.Length; i++)
                    {
                        if (e.RowIndex == i)
                        {
                            courseView = new ViewCourseDetails(courses[i]);
                            courseView.Show();
                            this.Hide();
                            break;
                        }
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
                        searchTextBox.Text = this.userId.ToString();
                        usersServices.addCourseToCart(this.userId, courses[i].Id);
                        break;
                    }
                }
                MessageBox.Show("Course Added to cart successfully!");
            }
        }

        private void onSearchTextChange(object sender, EventArgs e)
        {

        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void onBackBtn(object sender, EventArgs e)
        {
            UserHomePage userHomePage = new UserHomePage();
            userHomePage.Show();
            this.Hide();
        }

        private void onViewCartBtn(object sender, EventArgs e)
        {
            CartOfCourses cartOfCourses = new CartOfCourses();
            cartOfCourses.Show();
            this.Hide();
        }
    }
}

