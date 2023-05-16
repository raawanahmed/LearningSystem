namespace WindowsFormsApp2
{
    partial class EditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourse));
            this.homePage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.courseGenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courseInstructorNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.coursePriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.Transparent;
            this.homePage.FlatAppearance.BorderSize = 0;
            this.homePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePage.ForeColor = System.Drawing.Color.White;
            this.homePage.Image = ((System.Drawing.Image)(resources.GetObject("homePage.Image")));
            this.homePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homePage.Location = new System.Drawing.Point(375, 64);
            this.homePage.Margin = new System.Windows.Forms.Padding(4);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(246, 54);
            this.homePage.TabIndex = 24;
            this.homePage.Text = "Home Page";
            this.homePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homePage.UseVisualStyleBackColor = false;
            this.homePage.Click += new System.EventHandler(this.onHomePageBtn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(342, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 71);
            this.button2.TabIndex = 25;
            this.button2.Text = "Edit Course";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onEditCourseBtn);
            // 
            // courseGenreTextBox
            // 
            this.courseGenreTextBox.Location = new System.Drawing.Point(177, 416);
            this.courseGenreTextBox.Name = "courseGenreTextBox";
            this.courseGenreTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseGenreTextBox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(87, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 31);
            this.label5.TabIndex = 39;
            this.label5.Text = "Genre:";
            // 
            // courseInstructorNameTextBox
            // 
            this.courseInstructorNameTextBox.Location = new System.Drawing.Point(289, 340);
            this.courseInstructorNameTextBox.Name = "courseInstructorNameTextBox";
            this.courseInstructorNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseInstructorNameTextBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(548, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(87, 333);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 31);
            this.label7.TabIndex = 36;
            this.label7.Text = "Instructor Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(548, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 31);
            this.label8.TabIndex = 35;
            this.label8.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(87, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Course Name:";
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(270, 256);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseNameTextBox.TabIndex = 31;
            // 
            // courseDescriptionTextBox
            // 
            this.courseDescriptionTextBox.Location = new System.Drawing.Point(729, 261);
            this.courseDescriptionTextBox.Name = "courseDescriptionTextBox";
            this.courseDescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseDescriptionTextBox.TabIndex = 32;
            // 
            // coursePriceTextBox
            // 
            this.coursePriceTextBox.Location = new System.Drawing.Point(628, 340);
            this.coursePriceTextBox.Name = "coursePriceTextBox";
            this.coursePriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.coursePriceTextBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(300, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Courses IDs:";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(450, 181);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseIdTextBox.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(822, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 61);
            this.button3.TabIndex = 44;
            this.button3.Text = "Logout";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onLogoutBtn);
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
            this.button1.Location = new System.Drawing.Point(9, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 43;
            this.button1.Text = "Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onBackBtn);
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 568);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseGenreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseInstructorNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseDescriptionTextBox);
            this.Controls.Add(this.coursePriceTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.homePage);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.onEditCourseFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox courseGenreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox courseInstructorNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.TextBox courseDescriptionTextBox;
        private System.Windows.Forms.TextBox coursePriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}