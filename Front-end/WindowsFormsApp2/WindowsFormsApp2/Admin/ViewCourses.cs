using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2.Admin
{
    public partial class ViewCourses : Form
    {
        CourseData[] courses;
        public ViewCourses()
        {
            InitializeComponent();
        }

        private void onViewCoursesFormLoad(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            courses = adminServices.getAllCourses();
            GridViewData(courses);
        }
        public void GridViewData(CourseData[] courses)
        {

            allCoursesGridView.DataSource = courses;

            DataGridViewButtonColumn editCourseBtn = new DataGridViewButtonColumn();
            editCourseBtn.HeaderText = "Edit Course";
            editCourseBtn.Name = "Edit Course";
            editCourseBtn.Text = "Edit Course";
            editCourseBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(editCourseBtn);


            DataGridViewButtonColumn deleteCourseBtn = new DataGridViewButtonColumn();
            deleteCourseBtn.HeaderText = "Delete Course";
            deleteCourseBtn.Name = "Delete Course";
            deleteCourseBtn.Text = "Delete Course";
            deleteCourseBtn.UseColumnTextForButtonValue = true;
            allCoursesGridView.Columns.Add(deleteCourseBtn);

        }

        private void onHomePageBtn(object sender, EventArgs e)
        {
            AdminHomePage admin = new AdminHomePage();
            admin.Show();
            this.Hide();
        }

        private void allCoursesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCourse editCourse;
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();

            if (e.ColumnIndex == 7)
            {
                // edit course details
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        editCourse = new EditCourse(courses[i]);
                        editCourse.Show();
                        this.Hide();
                        break;
                    }
                }

            }
            else if (e.ColumnIndex == 8)
            {
                // delete course from database
                for (int i = 0; i < courses.Length; i++)
                {
                    if (e.RowIndex == i)
                    {
                        // there is an error in passing the selected id
                        adminServices.deleteCourse(courses[i].Id);
                        MessageBox.Show("Course Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                MessageBox.Show("Course has been deleted successfully!");
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
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
