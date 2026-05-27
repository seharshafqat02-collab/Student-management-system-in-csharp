namespace StudentManagementSystem.Forms
{
    partial class StudentForm
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
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.lblCGPA = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtCGPA = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Student Form";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(960, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Row 1 - Roll No and Full Name
            this.lblRollNo.Text = "Roll No:";
            this.lblRollNo.Location = new System.Drawing.Point(20, 70);
            this.lblRollNo.Size = new System.Drawing.Size(80, 25);
            this.txtRollNo.Location = new System.Drawing.Point(110, 67);
            this.txtRollNo.Size = new System.Drawing.Size(180, 25);

            this.lblName.Text = "Full Name:";
            this.lblName.Location = new System.Drawing.Point(330, 70);
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.txtName.Location = new System.Drawing.Point(430, 67);
            this.txtName.Size = new System.Drawing.Size(220, 25);

            // Row 2 - Email and Phone
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 115);
            this.lblEmail.Size = new System.Drawing.Size(80, 25);
            this.txtEmail.Location = new System.Drawing.Point(110, 112);
            this.txtEmail.Size = new System.Drawing.Size(180, 25);

            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(330, 115);
            this.lblPhone.Size = new System.Drawing.Size(90, 25);
            this.txtPhone.Location = new System.Drawing.Point(430, 112);
            this.txtPhone.Size = new System.Drawing.Size(220, 25);

            // Row 3 - Department and Semester
            this.lblDept.Text = "Department:";
            this.lblDept.Location = new System.Drawing.Point(20, 160);
            this.lblDept.Size = new System.Drawing.Size(90, 25);
            this.txtDept.Location = new System.Drawing.Point(110, 157);
            this.txtDept.Size = new System.Drawing.Size(180, 25);

            this.lblSem.Text = "Semester:";
            this.lblSem.Location = new System.Drawing.Point(330, 160);
            this.lblSem.Size = new System.Drawing.Size(90, 25);
            this.txtSem.Location = new System.Drawing.Point(430, 157);
            this.txtSem.Size = new System.Drawing.Size(220, 25);

            // Row 4 - CGPA
            this.lblCGPA.Text = "CGPA:";
            this.lblCGPA.Location = new System.Drawing.Point(20, 205);
            this.lblCGPA.Size = new System.Drawing.Size(80, 25);
            this.txtCGPA.Location = new System.Drawing.Point(110, 202);
            this.txtCGPA.Size = new System.Drawing.Size(180, 25);

            // CRUD Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(20, 250);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(145, 250);
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(270, 250);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(395, 250);
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Search bar
            this.txtSearch.Location = new System.Drawing.Point(20, 305);
            this.txtSearch.Size = new System.Drawing.Size(280, 25);

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(310, 302);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // DataGridView
            this.dgvStudents.Location = new System.Drawing.Point(20, 350);
            this.dgvStudents.Size = new System.Drawing.Size(940, 300);
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.lblCGPA);
            this.Controls.Add(this.txtCGPA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStudents);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.Label lblCGPA;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtCGPA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}