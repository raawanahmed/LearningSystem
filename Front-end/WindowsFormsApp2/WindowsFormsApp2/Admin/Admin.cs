using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 veiw = new Form2();
            veiw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcourse addcourse = new Addcourse();
            addcourse.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditCourse edit = new EditCourse();
            edit.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCourse delete = new DeleteCourse();
            delete.Show();
            this.Hide();
        }
    }
}
