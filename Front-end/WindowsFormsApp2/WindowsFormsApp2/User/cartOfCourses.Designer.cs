namespace WindowsFormsApp2.User
{
    partial class cartOfCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cartOfCourses));
            this.label3 = new System.Windows.Forms.Label();
            this.homePage = new System.Windows.Forms.Button();
            this.listOfCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(218, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 45);
            this.label3.TabIndex = 27;
            this.label3.Text = "List of courses in the cart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.homePage.Location = new System.Drawing.Point(21, 13);
            this.homePage.Margin = new System.Windows.Forms.Padding(4);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(218, 47);
            this.homePage.TabIndex = 26;
            this.homePage.Text = "Home Page";
            this.homePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homePage.UseVisualStyleBackColor = false;
            // 
            // listOfCourses
            // 
            this.listOfCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.listOfCourses.HideSelection = false;
            this.listOfCourses.Location = new System.Drawing.Point(21, 196);
            this.listOfCourses.Name = "listOfCourses";
            this.listOfCourses.Size = new System.Drawing.Size(831, 301);
            this.listOfCourses.TabIndex = 25;
            this.listOfCourses.UseCompatibleStateImageBehavior = false;
            this.listOfCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Id";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course Description";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course Price";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Course Instructor";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Course Genre";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Coruse Created At";
            this.columnHeader9.Width = 150;
            // 
            // cartOfCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.listOfCourses);
            this.Name = "cartOfCourses";
            this.Text = "cartOfCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homePage;
        private System.Windows.Forms.ListView listOfCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}