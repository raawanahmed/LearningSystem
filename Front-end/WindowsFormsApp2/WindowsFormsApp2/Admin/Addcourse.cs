using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Addcourse : Form
    {
        public Addcourse()
        {
            InitializeComponent();
        }

        private void onHomePageBtn(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void onAddCourseBtn(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            obj.AddCourses(courseNameTextBox.Text, descriptionTextBox.Text, int.Parse(priceTextBox.Text));
            MessageBox.Show("Course Add successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
