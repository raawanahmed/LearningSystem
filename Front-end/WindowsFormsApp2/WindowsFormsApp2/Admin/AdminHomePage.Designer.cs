namespace WindowsFormsApp2
{
    partial class AdminHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            this.addCourse = new System.Windows.Forms.Button();
            this.viewCourses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCourse
            // 
            this.addCourse.BackColor = System.Drawing.Color.Transparent;
            this.addCourse.FlatAppearance.BorderSize = 0;
            this.addCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourse.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourse.ForeColor = System.Drawing.Color.White;
            this.addCourse.Image = ((System.Drawing.Image)(resources.GetObject("addCourse.Image")));
            this.addCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCourse.Location = new System.Drawing.Point(122, 270);
            this.addCourse.Margin = new System.Windows.Forms.Padding(4);
            this.addCourse.Name = "addCourse";
            this.addCourse.Size = new System.Drawing.Size(211, 71);
            this.addCourse.TabIndex = 21;
            this.addCourse.Text = "Add Course";
            this.addCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCourse.UseVisualStyleBackColor = false;
            this.addCourse.Click += new System.EventHandler(this.onAddCourseBtn);
            // 
            // viewCourses
            // 
            this.viewCourses.BackColor = System.Drawing.Color.Transparent;
            this.viewCourses.FlatAppearance.BorderSize = 0;
            this.viewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCourses.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCourses.ForeColor = System.Drawing.Color.White;
            this.viewCourses.Image = ((System.Drawing.Image)(resources.GetObject("viewCourses.Image")));
            this.viewCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewCourses.Location = new System.Drawing.Point(427, 279);
            this.viewCourses.Margin = new System.Windows.Forms.Padding(4);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(234, 71);
            this.viewCourses.TabIndex = 22;
            this.viewCourses.Text = "View Courses";
            this.viewCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewCourses.UseVisualStyleBackColor = false;
            this.viewCourses.Click += new System.EventHandler(this.onViewCoursesBtn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(641, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 47;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onLogoutBtn);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewCourses);
            this.Controls.Add(this.addCourse);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button viewCourses;
        private System.Windows.Forms.Button button1;
    }
}