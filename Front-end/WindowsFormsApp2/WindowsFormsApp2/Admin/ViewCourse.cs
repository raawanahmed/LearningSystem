using System;
using System.Windows.Forms;
using WindowsFormsApp2.adminServicesReference;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void onLoadViewCoursesForm(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();

            CourseData[] courses = adminServices.getAllCourses();
            foreach (CourseData course in courses)
            {
                ListViewItem item = new ListViewItem(course.CourseName);
                item.SubItems.Add(course.Id.ToString());
                item.SubItems.Add(course.CourseDescription);
                item.SubItems.Add(course.CoursePrice.ToString());
                item.SubItems.Add(course.CourseInstructor);
                item.SubItems.Add(course.CourseGenre);
                item.SubItems.Add(course.CreatedAt.ToString());
                listOfCourses.Items.Add(item);
                /* Button editButton = new Button();
                 editButton.Text = "Edit";
                 editButton.Tag = course.Id;
                 editButton.Click += new EventHandler(editCourseBtn);
                 item.SubItems.Add("");
                 listOfCourses.Items.Add(item);
                 listOfCourses.Controls.Add(editButton);
                */
            }
        }
        private void onHomePageBtn(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
        private void editCourseBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int courseId = (int)button.Tag;
            EditCourse editCourse = new EditCourse();
            editCourse.ShowDialog();
            this.Hide();
        }
    }
}
