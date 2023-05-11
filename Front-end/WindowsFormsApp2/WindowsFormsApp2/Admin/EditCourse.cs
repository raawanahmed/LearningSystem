using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2
{
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }
        private void onHomePageBtn(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
        private bool validateCourseData(CourseData course)
        {
            bool tmam = true;
            if (course == null)
            {
                MessageBox.Show("Please fill all the fields.");
                tmam = false;
            }
            else if (course.CourseName.Length == 0)
            {
                MessageBox.Show("Please enter the course name.");
                tmam = false;
            }
            else if (course.CourseDescription.Length == 0)
            {
                MessageBox.Show("Please enter the course description.");
                tmam = false;
            }
            else if (course.CoursePrice == 0)
            {
                MessageBox.Show("Please enter the course price.");
                tmam = false;
            }
            else if (course.CourseGenre.Length == 0)
            {
                MessageBox.Show("Please enter the course genre.");
                tmam = false;
            }
            return tmam ? true : false;
        }
        private void onEditCourseBtn(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            CourseData courseData = new CourseData();
            courseData.CourseName = courseNameTextBox.Text;
            courseData.CourseDescription = courseDescriptionTextBox.Text;
            courseData.CoursePrice = int.Parse(coursePriceTextBox.Text);
            courseData.CourseInstructor = courseInstructorNameTextBox.Text;
            courseData.CourseGenre = courseGenre.Text;
            courseData.CreatedAt = DateTime.Now;
            if (validateCourseData(courseData))
            {
                // there is an error while passing selected course id
                adminServices.editCourse(int.Parse(coursesIDsComboBox.SelectedItem.ToString()), courseData);
                MessageBox.Show("Course Edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void onEditCourseFormLoad(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            int[] coursesIDs = adminServices.getAllCoursesIDs();
            for (int i = 0; i < coursesIDs.Length; i++)
            {
                coursesIDsComboBox.Items.Add(coursesIDs[i]);
            }
        }

        private void onSelectCourseId(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            // there is an error here
            CourseData course = adminServices.getCourseData(int.Parse(coursesIDsComboBox.SelectedItem.ToString()));
            courseNameTextBox.Text = course.CourseName;
            courseDescriptionTextBox.Text = course.CourseDescription;
            coursePriceTextBox.Text = course.CoursePrice.ToString();
            courseInstructorNameTextBox.Text = course.CourseGenre;
            courseInstructorNameTextBox.Text = course.CourseInstructor;
        }
    }
}
