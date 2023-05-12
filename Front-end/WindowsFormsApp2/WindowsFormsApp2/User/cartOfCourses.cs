using System;
using System.Windows.Forms;
using WindowsFormsApp2.userServicesReference;

namespace WindowsFormsApp2.User
{
    public partial class CartOfCourses : Form
    {

        CourseData[] courses;
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
        private void onCartOfCoursesFormLoad(object sender, EventArgs e)
        {
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            CourseData[] coursesInCart = usersServices.getCoursesInCart(this.userId);
            GridViewData(coursesInCart);
        }
        public void GridViewData(CourseData[] courses)
        {

            coursesInCartGridView.DataSource = courses;

            DataGridViewButtonColumn enrollInCourseBtn = new DataGridViewButtonColumn();
            enrollInCourseBtn.HeaderText = "Enroll in the course";
            enrollInCourseBtn.Name = "Enroll in the course";
            enrollInCourseBtn.Text = "Enroll in the course";
            enrollInCourseBtn.UseColumnTextForButtonValue = true;
            coursesInCartGridView.Columns.Add(enrollInCourseBtn);

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
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        payForCourse = new Pay(this.userId, courses[i].Id, "enrolled");
                        payForCourse.Show();
                        this.Hide();
                        break;
                    }
                }

            }
            else if (e.ColumnIndex == 8)
            {
                // enroll for course -> pay for it
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        usersServices.removeCourseFromCart(this.userId, courses[i].Id);
                        break;
                    }
                }

            }
        }
    }
}
