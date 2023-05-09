using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    
    public partial class CourseView : Form
    {
        bool Islogin;
       

        List<CourseDetails> coursesDetails= new List<CourseDetails>(); 

         
        public CourseView(bool islogin,string CourseName)
        {
          
            InitializeComponent();
           
            this.Islogin = islogin;
            Viewdetails(CourseName);
        }

        public CourseView()
        {

        }


        private void CourseView_Load(object sender, EventArgs e)
        {
          
           
           
            if (Islogin == true)
            {
                this.button2.Visible = false;
                this.comboBox1.Visible = true;

            }
            else
            {
                this.button2.Visible = true;
                this.comboBox1.Visible = false;

            }

        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Login_page login_Page = new Login_page();
            if (comboBox1.SelectedIndex == 0)
            {
                Myaccount myaccount = new Myaccount();
                myaccount.Show();
                this.Hide();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                login_Page.Hide();
                this.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_page login_Page = new Login_page();
            login_Page.Show();
            this.Hide();
        }

        public void Viewdetails( string CourseName)
        {
            List<CourseDetails> course= new List<CourseDetails>();

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
            for (int i=0;i<coursesDetails.Count;i++)
            {
                
                if (CourseName == coursesDetails[i].CourseName)
                {
                    course.Add(coursesDetails[i]);

                    dataGridView1.DataSource = course;
                }
            }

            
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