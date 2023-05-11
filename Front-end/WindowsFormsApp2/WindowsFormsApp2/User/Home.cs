using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp2.User;

namespace WindowsFormsApp2
{
    public partial class Home : Form
    {


        List<Course> filteredList;
        List<Course> courses;

        bool Islogin;

        public Home(bool islogin)
        {
            Islogin = islogin;
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        public void GridViewData(List<Course> courses)
        {

            dataGridView1.DataSource = courses;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "ViewItems";
            btn.Name = "ViewItems";
            btn.Text = "View";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "SaveItems";
            btn2.Name = "SaveItems";
            btn2.Text = "Save";
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseView courseView;

            if (e.ColumnIndex == 4)
            {
                if (textBox1.Text == "")
                {
                    for (int i = 0; i < 3; i++)
                    {

                        if (e.RowIndex == i)
                        {
                            courseView = new CourseView(Islogin, courses[i].CourseName);

                            courseView.Show();
                            this.Hide();
                            break;
                        }

                    }
                }
                else
                {

                    for (int i = 0; i < filteredList.Count; i++)
                    {
                        if (e.RowIndex == i)
                        {

                            courseView = new CourseView(Islogin, filteredList[i].CourseName);
                            courseView.Show();
                            this.Hide();
                            break;
                        }
                    }
                }

            }
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Save");
            }
        }

        private void onSearchTextChange(object sender, EventArgs e)
        {

            filteredList = new List<Course>();
            string searchText = textBox1.Text;
            dataGridView1.Columns.Clear();
            foreach (Course course in courses)
            {
                if (course.CourseName.Contains(searchText))
                {
                    filteredList.Add(course);
                }
            }

            GridViewData(filteredList);


        }

        private void Home_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            courses = new List<Course>{
                 new Course { CourseName = "Course A", Instructor = "John Doe", Price = 99.99M, Rating = 4 },
                 new Course { CourseName = "Course B", Instructor = "Jane Smith", Price = 149.99M, Rating = 5 },
                 new Course { CourseName = "Course C", Instructor = "Bob Johnson", Price = 199.99M, Rating = 3 }
                          };
            GridViewData(courses);

        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }
    }
}

public class Course
{
    public string CourseName { get; set; }
    public string Instructor { get; set; }
    public decimal Price { get; set; }
    public int Rating { get; set; }


}

