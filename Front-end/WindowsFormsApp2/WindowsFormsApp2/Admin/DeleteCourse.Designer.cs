namespace WindowsFormsApp2
{
    partial class DeleteCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCourse));
            this.coursesIDsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.Button();
            this.deleteCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursesIDsComboBox
            // 
            this.coursesIDsComboBox.FormattingEnabled = true;
            this.coursesIDsComboBox.Location = new System.Drawing.Point(382, 138);
            this.coursesIDsComboBox.Name = "coursesIDsComboBox";
            this.coursesIDsComboBox.Size = new System.Drawing.Size(121, 24);
            this.coursesIDsComboBox.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(231, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Courses IDs:";
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
            this.homePage.Location = new System.Drawing.Point(13, 13);
            this.homePage.Margin = new System.Windows.Forms.Padding(4);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(233, 54);
            this.homePage.TabIndex = 43;
            this.homePage.Text = "Home Page";
            this.homePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homePage.UseVisualStyleBackColor = false;
            this.homePage.Click += new System.EventHandler(this.onHomePageBtn);
            // 
            // deleteCourses
            // 
            this.deleteCourses.BackColor = System.Drawing.Color.Transparent;
            this.deleteCourses.FlatAppearance.BorderSize = 0;
            this.deleteCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourses.ForeColor = System.Drawing.Color.White;
            this.deleteCourses.Image = ((System.Drawing.Image)(resources.GetObject("deleteCourses.Image")));
            this.deleteCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCourses.Location = new System.Drawing.Point(271, 191);
            this.deleteCourses.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCourses.Name = "deleteCourses";
            this.deleteCourses.Size = new System.Drawing.Size(192, 38);
            this.deleteCourses.TabIndex = 46;
            this.deleteCourses.Text = "Delete Course";
            this.deleteCourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteCourses.UseVisualStyleBackColor = false;
            this.deleteCourses.Click += new System.EventHandler(this.onDeleteCourseBtn);
            // 
            // DeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteCourses);
            this.Controls.Add(this.coursesIDsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePage);
            this.Name = "DeleteCourse";
            this.Text = "DeleteCourse";
            this.Load += new System.EventHandler(this.onDeleteCourseFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox coursesIDsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.Button deleteCourses;
    }
}