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

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            //obj.DeleteCourse(int.Parse(textBox1.Text));
            //MessageBox.Show("Course Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
