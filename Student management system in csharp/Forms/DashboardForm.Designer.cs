namespace StudentManagementSystem.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Student Management System";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Students button
            this.btnStudents.Text = "Students";
            this.btnStudents.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.btnStudents.Location = new System.Drawing.Point(150, 80);
            this.btnStudents.Size = new System.Drawing.Size(300, 50);
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);

            // Courses button
            this.btnCourses.Text = "Courses";
            this.btnCourses.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.btnCourses.Location = new System.Drawing.Point(150, 145);
            this.btnCourses.Size = new System.Drawing.Size(300, 50);
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);

            // Teachers button
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.btnTeachers.Location = new System.Drawing.Point(150, 210);
            this.btnTeachers.Size = new System.Drawing.Size(300, 50);
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);

            // Enrollments button
            this.btnEnrollments.Text = "Enrollments";
            this.btnEnrollments.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.btnEnrollments.Location = new System.Drawing.Point(150, 275);
            this.btnEnrollments.Size = new System.Drawing.Size(300, 50);
            this.btnEnrollments.Click += new System.EventHandler(this.btnEnrollments_Click);

            // Logout bottom right
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9);
            this.btnLogout.Location = new System.Drawing.Point(430, 350);
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnEnrollments);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnEnrollments;
        private System.Windows.Forms.Button btnLogout;
    }
}