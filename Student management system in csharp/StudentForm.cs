using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class StudentForm : Form
    {
        private int selectedStudentID = 0;
        private string currentRole;

        public StudentForm(string role)
        {
            InitializeComponent();
            currentRole = role;
        }

        // Load form
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();

            // Viewer role cannot modify data
            if (currentRole == "Viewer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Load all students into grid
        private void LoadStudents()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT StudentID, RollNo, FullName, Email, Phone, Department, Semester, CGPA FROM Students WHERE IsDeleted=0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvStudents.DataSource = dt;
                    dgvStudents.Columns["StudentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error");
            }
        }

        // Add new student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRollNo.Text == "" || txtName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Roll No, Name and Email are required.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Students (RollNo, FullName, Email, Phone, Department, Semester, CGPA) VALUES (@r,@n,@e,@ph,@d,@s,@c)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@r", txtRollNo.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@d", txtDept.Text);
                    cmd.Parameters.AddWithValue("@s", txtSem.Text == "" ? 0 : Convert.ToInt32(txtSem.Text));
                    cmd.Parameters.AddWithValue("@c", txtCGPA.Text == "" ? (decimal)0.0 : Convert.ToDecimal(txtCGPA.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added!", "Success");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Update student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student first.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE Students SET RollNo=@r, FullName=@n, Email=@e, Phone=@ph, Department=@d, Semester=@s, CGPA=@c WHERE StudentID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@r", txtRollNo.Text);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@d", txtDept.Text);
                    cmd.Parameters.AddWithValue("@s", txtSem.Text == "" ? 0 : Convert.ToInt32(txtSem.Text));
                    cmd.Parameters.AddWithValue("@c", txtCGPA.Text == "" ? (decimal)0.0 : Convert.ToDecimal(txtCGPA.Text));
                    cmd.Parameters.AddWithValue("@id", selectedStudentID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student updated!", "Success");
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
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student first.", "Warning");
                return;
            }

            DialogResult res = MessageBox.Show("Delete this student?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = "UPDATE Students SET IsDeleted=1 WHERE StudentID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedStudentID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student deleted!", "Success");
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT StudentID, RollNo, FullName, Email, Phone, Department, Semester, CGPA FROM Students WHERE IsDeleted=0 AND (FullName LIKE @k OR RollNo LIKE @k)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@k", "%" + txtSearch.Text + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvStudents.DataSource = dt;
                    dgvStudents.Columns["StudentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Row click - fill fields
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtRollNo.Text = row.Cells["RollNo"].Value.ToString();
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtDept.Text = row.Cells["Department"].Value?.ToString();
                txtSem.Text = row.Cells["Semester"].Value.ToString();
                txtCGPA.Text = row.Cells["CGPA"].Value.ToString();
            }
        }

        // Clear all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedStudentID = 0;
            txtRollNo.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtDept.Text = "";
            txtSem.Text = "";
            txtCGPA.Text = "";
            txtSearch.Text = "";
            LoadStudents();
        }
    }
}