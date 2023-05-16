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
            GridViewData();
        }
        public void GridViewData()
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            courses = adminServices.getAllCourses();
            // clear columns first before reloading it
            allCoursesGridView.Columns.Clear();
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
                editCourse = new EditCourse(courses[e.RowIndex]);
                editCourse.Show();
                this.Hide();

            }
            else if (e.ColumnIndex == 8)
            {
                // delete course from database
                adminServices.deleteCourse(courses[e.RowIndex].Id);
                MessageBox.Show("Course Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewData();
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
