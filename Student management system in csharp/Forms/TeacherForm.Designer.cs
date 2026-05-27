namespace StudentManagementSystem.Forms
{
    partial class TeacherForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Teacher Form";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(940, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Row 1 - Full Name
            this.lblName.Text = "Full Name:";
            this.lblName.Location = new System.Drawing.Point(20, 70);
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.txtName.Location = new System.Drawing.Point(130, 67);
            this.txtName.Size = new System.Drawing.Size(250, 25);

            // Row 2 - Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 115);
            this.lblEmail.Size = new System.Drawing.Size(100, 25);
            this.txtEmail.Location = new System.Drawing.Point(130, 112);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);

            // Row 3 - Phone
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(20, 160);
            this.lblPhone.Size = new System.Drawing.Size(100, 25);
            this.txtPhone.Location = new System.Drawing.Point(130, 157);
            this.txtPhone.Size = new System.Drawing.Size(250, 25);

            // Row 4 - Department
            this.lblDept.Text = "Department:";
            this.lblDept.Location = new System.Drawing.Point(20, 205);
            this.lblDept.Size = new System.Drawing.Size(100, 25);
            this.txtDept.Location = new System.Drawing.Point(130, 202);
            this.txtDept.Size = new System.Drawing.Size(250, 25);

            // CRUD Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(20, 255);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(145, 255);
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(270, 255);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(395, 255);
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Search
            this.txtSearch.Location = new System.Drawing.Point(20, 310);
            this.txtSearch.Size = new System.Drawing.Size(280, 25);

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(310, 307);
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // DataGridView
            this.dgvTeachers.Location = new System.Drawing.Point(20, 355);
            this.dgvTeachers.Size = new System.Drawing.Size(940, 280);
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);

            // Form settings
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvTeachers);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Teacher Form";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTeachers;
    }
}