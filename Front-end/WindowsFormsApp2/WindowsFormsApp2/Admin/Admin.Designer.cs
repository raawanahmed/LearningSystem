namespace WindowsFormsApp2
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.addCourse = new System.Windows.Forms.Button();
            this.viewCourses = new System.Windows.Forms.Button();
            this.editCourse = new System.Windows.Forms.Button();
            this.deleteCourses = new System.Windows.Forms.Button();
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
            this.addCourse.Location = new System.Drawing.Point(88, 62);
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
            this.viewCourses.Location = new System.Drawing.Point(393, 71);
            this.viewCourses.Margin = new System.Windows.Forms.Padding(4);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(234, 71);
            this.viewCourses.TabIndex = 22;
            this.viewCourses.Text = "View Courses";
            this.viewCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewCourses.UseVisualStyleBackColor = false;
            this.viewCourses.Click += new System.EventHandler(this.onViewCoursesBtn);
            // 
            // editCourse
            // 
            this.editCourse.BackColor = System.Drawing.Color.Transparent;
            this.editCourse.FlatAppearance.BorderSize = 0;
            this.editCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCourse.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourse.ForeColor = System.Drawing.Color.White;
            this.editCourse.Image = ((System.Drawing.Image)(resources.GetObject("editCourse.Image")));
            this.editCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCourse.Location = new System.Drawing.Point(88, 275);
            this.editCourse.Margin = new System.Windows.Forms.Padding(4);
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(211, 71);
            this.editCourse.TabIndex = 23;
            this.editCourse.Text = "Edit Course";
            this.editCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editCourse.UseVisualStyleBackColor = false;
            this.editCourse.Click += new System.EventHandler(this.onEditCourse);
            // 
            // deleteCourses
            // 
            this.deleteCourses.BackColor = System.Drawing.Color.Transparent;
            this.deleteCourses.FlatAppearance.BorderSize = 0;
            this.deleteCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCourses.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourses.ForeColor = System.Drawing.Color.White;
            this.deleteCourses.Image = ((System.Drawing.Image)(resources.GetObject("deleteCourses.Image")));
            this.deleteCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCourses.Location = new System.Drawing.Point(393, 268);
            this.deleteCourses.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCourses.Name = "deleteCourses";
            this.deleteCourses.Size = new System.Drawing.Size(265, 85);
            this.deleteCourses.TabIndex = 24;
            this.deleteCourses.Text = "Delete Courses";
            this.deleteCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteCourses.UseVisualStyleBackColor = false;
            this.deleteCourses.Click += new System.EventHandler(this.onDeleteCourses);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCourses);
            this.Controls.Add(this.editCourse);
            this.Controls.Add(this.viewCourses);
            this.Controls.Add(this.addCourse);
            this.Name = "Admin";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addCourse;
        private System.Windows.Forms.Button viewCourses;
        private System.Windows.Forms.Button editCourse;
        private System.Windows.Forms.Button deleteCourses;
    }
}