using System;
using System.Windows.Forms;

namespace WindowsFormsApp2.User
{
    public partial class Pay : Form
    {
        private int userId;
        private int courseId;
        private string status;
        public Pay()
        {
            InitializeComponent();
        }
        public Pay(int userId, int courseId, string status)
        {
            InitializeComponent();
            this.userId = userId;
            this.courseId = courseId;
            this.status = status;
        }
        private void onLogoutBtn(object sender, EventArgs e)
        {

        }

        private void onBackBtn(object sender, EventArgs e)
        {

        }
    }
}
