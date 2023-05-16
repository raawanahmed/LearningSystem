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
            buyCourseBtn.Name = "Buy";
            buyCourseBtn.Text = "Buy";
            buyCourseBtn.UseColumnTextForButtonValue = true;
            coursesInCartGridView.Columns.Add(buyCourseBtn);

            // remove from cart
            DataGridViewButtonColumn removeCourseFromCartBtn = new DataGridViewButtonColumn();
            removeCourseFromCartBtn.HeaderText = "Remove course From Cart";
            removeCourseFromCartBtn.Name = "Remove";
            removeCourseFromCartBtn.Text = "Remove";
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
                payForCourse = new Pay(this.userId, coursesInCart[e.RowIndex].Id, coursesInCart[e.RowIndex].CoursePrice);
                payForCourse.Show();
                this.Hide();
            }
            else if (e.ColumnIndex == 8)
            {
                // remove course from cart
                UserCoursesData userCourseData = new UserCoursesData();
                userCourseData.UserId = this.userId;
                userCourseData.CourseId = coursesInCart[e.RowIndex].Id;
                usersServices.removeCourseFromCart(userCourseData);
                GridViewData();
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
