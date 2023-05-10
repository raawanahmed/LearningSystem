using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            // obj.EditCourse(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
            // MessageBox.Show("Course Edit successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
