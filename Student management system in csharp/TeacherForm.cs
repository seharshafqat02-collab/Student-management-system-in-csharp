using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class TeacherForm : Form
    {
        private int selectedTeacherID = 0;
        private string currentRole;

        public TeacherForm(string role)
        {
            InitializeComponent();
            currentRole = role;
        }

        // Load form
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();

            // Viewer cannot modify data
            if (currentRole == "Viewer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // Load all teachers into grid
        private void LoadTeachers()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT TeacherID, FullName, Email, Phone, Department FROM Teachers WHERE IsDeleted=0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvTeachers.DataSource = dt;
                    dgvTeachers.Columns["TeacherID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading teachers: " + ex.Message, "Error");
            }
        }

        // Add new teacher
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Name and Email are required.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO Teachers (FullName, Email, Phone, Department) VALUES (@n,@e,@ph,@d)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@d", txtDept.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher added!", "Success");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Update teacher
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTeacherID == 0)
            {
                MessageBox.Show("Please select a teacher first.", "Warning");
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE Teachers SET FullName=@n, Email=@e, Phone=@ph, Department=@d WHERE TeacherID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@d", txtDept.Text);
                    cmd.Parameters.AddWithValue("@id", selectedTeacherID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated!", "Success");
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
            if (selectedTeacherID == 0)
            {
                MessageBox.Show("Please select a teacher first.", "Warning");
                return;
            }

            DialogResult res = MessageBox.Show("Delete this teacher?", "Confirm", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        string query = "UPDATE Teachers SET IsDeleted=1 WHERE TeacherID=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedTeacherID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Teacher deleted!", "Success");
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
                    string query = "SELECT TeacherID, FullName, Email, Phone, Department FROM Teachers WHERE IsDeleted=0 AND (FullName LIKE @k OR Department LIKE @k)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@k", "%" + txtSearch.Text + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvTeachers.DataSource = dt;
                    dgvTeachers.Columns["TeacherID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Row click - fill fields
        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                selectedTeacherID = Convert.ToInt32(row.Cells["TeacherID"].Value);
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtDept.Text = row.Cells["Department"].Value?.ToString();
            }
        }

        // Clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedTeacherID = 0;
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtDept.Text = "";
            txtSearch.Text = "";
            LoadTeachers();
        }
    }
}