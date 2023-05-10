using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();

            // List<string> columns = new List<string>();

            // columns = obj.Viewcourse(int.Parse(textBox1.Text));

            // ListViewItem listView = new ListViewItem(columns[0]);

            // listView.SubItems.Add(columns[1]);
            //  listView.SubItems.Add(columns[2]);
            // listView1.Items.Add(listView);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
