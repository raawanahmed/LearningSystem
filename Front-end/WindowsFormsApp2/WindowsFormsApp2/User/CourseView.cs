using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{

    public partial class CourseView : Form
    {
        bool Islogin;


        List<CourseDetails> coursesDetails = new List<CourseDetails>();


        public CourseView(bool islogin, string CourseName)
        {

            InitializeComponent();
            this.Islogin = islogin;
            Viewdetails(CourseName);
        }

        private void onCourseViewFormLoad(object sender, EventArgs e)
        {

        }
        public void Viewdetails(string CourseName)
        {
            List<CourseDetails> course = new List<CourseDetails>();

            CourseDetails course1 = new CourseDetails
            {
                CourseName = "Course A",
                Instructor = "John Doe",
                Price = 99.99M,
                Rating = 4.5M,
                Description = "Learn C# programming language",
                CreatedAt = DateTime.Now
            };
            coursesDetails.Add(course1);

            CourseDetails course2 = new CourseDetails
            {
                CourseName = "Course B",
                Instructor = "John Doe",
                Price = 99.99M,
                Rating = 4.5M,
                Description = "Learn C# programming language",
                CreatedAt = DateTime.Now
            };
            coursesDetails.Add(course2);

            CourseDetails course3 = new CourseDetails
            {
                CourseName = "Course C",
                Instructor = "John Doe",
                Price = 99.99M,
                Rating = 4.5M,
                Description = "Learn C# programming language",
                CreatedAt = DateTime.Now
            };

            coursesDetails.Add(course3);
            for (int i = 0; i < coursesDetails.Count; i++)
            {

                if (CourseName == coursesDetails[i].CourseName)
                {
                    course.Add(coursesDetails[i]);

                    dataGridView1.DataSource = course;
                }
            }
        }

        private void onLogoutBtn(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }
    }
}

public class CourseDetails
{
    public string CourseName { get; set; }
    public string Instructor { get; set; }
    public decimal Price { get; set; }
    public decimal Rating { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}