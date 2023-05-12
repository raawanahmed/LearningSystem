using System;
using System.Windows.Forms;
using WindowsFormsApp2.User;
using WindowsFormsApp2.userServicesReference;


namespace WindowsFormsApp2
{
    public partial class ViewAllCourses : Form
    {

        CourseData[] courses;
        public ViewAllCourses()
        {
            InitializeComponent();
            allCoursesGridView.ReadOnly = true;
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
            viewCourseDetailsBtn.HeaderText = "ViewCourseDetails";
            viewCourseDetailsBtn.Name = "ViewCourseDetails";
            viewCourseDetailsBtn.Text = "View Course Details";
            viewCourseDetailsBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(viewCourseDetailsBtn);


            DataGridViewButtonColumn addToCartBtn = new DataGridViewButtonColumn();
            addToCartBtn.HeaderText = "AddToCart";
            addToCartBtn.Name = "AddToCart";
            addToCartBtn.Text = "Add To Cart";
            addToCartBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(addToCartBtn);

        }

        private void allCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewCourseDetails courseView;

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
            if (e.ColumnIndex == 8)
            {
                // add course to cart 
                // todo add check to database add course if the course is not already added
                MessageBox.Show("Save");
            }
        }

        private void onSearchTextChange(object sender, EventArgs e)
        {

        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }
    }
}

