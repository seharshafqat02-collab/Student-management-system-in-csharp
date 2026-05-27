using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class EnrollmentForm : Form
    {
        private int selectedEnrollmentID = 0;
        private string currentRole;

        public EnrollmentForm(string role)
        {
            InitializeComponent();
            currentRole = role;
        }

        // Load form
        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadEnrollments();

            // Viewer cannot modify data
            if (currentRole == "Viewer")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Load all enrollments into grid
        private void LoadEnrollments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // Join students and courses to show names
                    string query = @"SELECT e.EnrollmentID, s.RollNo, c.CourseCode, 
                                    e.Grade, e.EnrollmentDate 
                                    FROM Enrollments e
                                    JOIN Students s ON e.StudentID = s.StudentID
                                    JOIN Courses c ON e.CourseID = c.CourseID
                                    WHERE e.IsDeleted=0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvEnrollments.DataSource = dt;
                    dgvEnrollments.Columns["EnrollmentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading enrollments: " + ex.Message, "Error");
            }
        }

        // Add enrollment
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "" || txtCourseCode.Text == "")
            {
                MessageBox.Show("Roll No and Course Code are required.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // Get StudentID from RollNo
                    MySqlCommand cmd1 = new MySqlCommand(
                        "SELECT StudentID FROM Students WHERE RollNo=@r AND IsDeleted=0", conn);
                    cmd1.Parameters.AddWithValue("@r", txtRollNo.Text);
                    object studentObj = cmd1.ExecuteScalar();

                    if (studentObj == null)
                    {
                        MessageBox.Show("Student Roll No not found!", "Error");
                        return;
                    }

                    // Get CourseID from CourseCode
                    MySqlCommand cmd2 = new MySqlCommand(
                        "SELECT CourseID FROM Courses WHERE CourseCode=@c AND IsDeleted=0", conn);
                    cmd2.Parameters.AddWithValue("@c", txtCourseCode.Text);
                    object courseObj = cmd2.ExecuteScalar();

                    if (courseObj == null)
                    {
                        MessageBox.Show("Course Code not found!", "Error");
                        return;
                    }

                    // Insert enrollment
                    string query = "INSERT INTO Enrollments (StudentID, CourseID, Grade, EnrollmentDate) VALUES (@s,@c,@g,@d)";
                    MySqlCommand cmd3 = new MySqlCommand(query, conn);
                    cmd3.Parameters.AddWithValue("@s", Convert.ToInt32(studentObj));
                    cmd3.Parameters.AddWithValue("@c", Convert.ToInt32(courseObj));
                    cmd3.Parameters.AddWithValue("@g", txtGrade.Text);
                    cmd3.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Enrollment added!", "Success");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Delete enrollment
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0)
            {
                MessageBox.Show("Please select an enrollment first.", "Warning");
                return;
            }

            DialogResult res = MessageBox.Show("Delete this enrollment?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = "UPDATE Enrollments SET IsDeleted=1 WHERE EnrollmentID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedEnrollmentID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enrollment deleted!", "Success");
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
        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
                selectedEnrollmentID = Convert.ToInt32(row.Cells["EnrollmentID"].Value);
                txtRollNo.Text = row.Cells["RollNo"].Value.ToString();
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtGrade.Text = row.Cells["Grade"].Value?.ToString();
            }
        }

        // Clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedEnrollmentID = 0;
            txtRollNo.Text = "";
            txtCourseCode.Text = "";
            txtGrade.Text = "";
            LoadEnrollments();
        }
    }
}