using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }

        private void onHomePageBtn(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void onDeleteCourseBtn(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            // there is an error in passing the selected id
            adminServices.deleteCourse(int.Parse(coursesIDsComboBox.SelectedItem.ToString()));
            MessageBox.Show("Course Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void onDeleteCourseFormLoad(object sender, EventArgs e)
        {
            adminServicesReference.IadminServicesClient adminServices = new adminServicesReference.IadminServicesClient();
            int[] coursesIDs = adminServices.getAllCoursesIDs();
            for (int i = 0; i < coursesIDs.Length; i++)
            {
                coursesIDsComboBox.Items.Add(coursesIDs[i]);
            }
        }
    }
}
