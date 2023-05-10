using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void onAddCourseBtn(object sender, EventArgs e)
        {
            Addcourse addcourse = new Addcourse();
            addcourse.Show();
            this.Hide();

        }

        private void onViewCoursesBtn(object sender, EventArgs e)
        {
            Form2 veiw = new Form2();
            veiw.Show();
            this.Hide();
        }

        private void onEditCourse(object sender, EventArgs e)
        {
            EditCourse edit = new EditCourse();
            edit.Show();
            this.Hide();
        }

        private void onDeleteCourses(object sender, EventArgs e)
        {
            DeleteCourse delete = new DeleteCourse();
            delete.Show();
            this.Hide();
        }
    }
}
