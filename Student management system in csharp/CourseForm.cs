using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class CourseForm : Form
    {
        private int selectedCourseID = 0;
        private string currentRole;

        public CourseForm(string role)
        {
            InitializeComponent();
            currentRole = role;
        }

        // Load form
        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();

            // Viewer cannot modify data
            if (currentRole == "Viewer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Load all courses into grid
        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT CourseID, CourseCode, CourseName, CreditHours FROM Courses WHERE IsDeleted=0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvCourses.DataSource = dt;
                    dgvCourses.Columns["CourseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error");
            }
        }

        // Add new course
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Course Code and Name are required.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Courses (CourseCode, CourseName, CreditHours) VALUES (@c,@n,@cr)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@c", txtCode.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@cr", txtCredits.Text == "" ? 3 : Convert.ToInt32(txtCredits.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course added!", "Success");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Update course
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course first.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE Courses SET CourseCode=@c, CourseName=@n, CreditHours=@cr WHERE CourseID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@c", txtCode.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@cr", txtCredits.Text == "" ? 3 : Convert.ToInt32(txtCredits.Text));
                    cmd.Parameters.AddWithValue("@id", selectedCourseID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course updated!", "Success");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Soft delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course first.", "Warning");
                return;
            }

            DialogResult res = MessageBox.Show("Delete this course?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = "UPDATE Courses SET IsDeleted=1 WHERE CourseID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedCourseID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course deleted!", "Success");
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Row click - fill fields
        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                selectedCourseID = Convert.ToInt32(row.Cells["CourseID"].Value);
                txtCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtName.Text = row.Cells["CourseName"].Value.ToString();
                txtCredits.Text = row.Cells["CreditHours"].Value.ToString();
            }
        }

        // Clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedCourseID = 0;
            txtCode.Text = "";
            txtName.Text = "";
            txtCredits.Text = "";
            LoadCourses();
        }
    }
}