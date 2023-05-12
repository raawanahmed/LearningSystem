using System;
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
            userServicesReference.usersServicesSoapClient usersServices = new userServicesReference.usersServicesSoapClient();
            coursesInCart = usersServices.getCoursesInCart(this.userId);
            GridViewData(coursesInCart);
        }
        public void GridViewData(CourseData[] courses)
        {

            coursesInCartGridView.DataSource = courses;
            // enroll into course update the course status to enrolled
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
                for (int i = 0; i < coursesInCart.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        payForCourse = new Pay(this.userId, coursesInCart[i].Id, "enrolled");
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
                        usersServices.removeCourseFromCart(this.userId, coursesInCart[i].Id);
                        break;
                    }
                }
                MessageBox.Show("Course removed from cart successfully!");
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
