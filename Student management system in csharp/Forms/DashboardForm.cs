using System;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class DashboardForm : Form
    {
        private string currentUser;
        private string currentRole;

        public DashboardForm(string username, string role)
        {
            InitializeComponent();
            currentUser = username;
            currentRole = role;
        }

        // Form load
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Dashboard loaded
        }

        // Open Students form
        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm(currentRole);
            sf.Show();
        }

        // Open Courses form
        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm cf = new CourseForm(currentRole);
            cf.Show();
        }

        // Open Teachers form
        private void btnTeachers_Click(object sender, EventArgs e)
        {
            TeacherForm tf = new TeacherForm(currentRole);
            tf.Show();
        }

        // Open Enrollments form
        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            EnrollmentForm ef = new EnrollmentForm(currentRole);
            ef.Show();
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}