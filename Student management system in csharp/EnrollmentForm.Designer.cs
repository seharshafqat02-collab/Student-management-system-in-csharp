namespace StudentManagementSystem.Forms
{
    partial class EnrollmentForm
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
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Enrollment Form";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(940, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Student Roll No
            this.lblRollNo.Text = "Student Roll No:";
            this.lblRollNo.Location = new System.Drawing.Point(20, 70);
            this.lblRollNo.Size = new System.Drawing.Size(130, 25);
            this.txtRollNo.Location = new System.Drawing.Point(160, 67);
            this.txtRollNo.Size = new System.Drawing.Size(130, 25);

            // Course Code
            this.lblCourseCode.Text = "Course Code:";
            this.lblCourseCode.Location = new System.Drawing.Point(20, 115);
            this.lblCourseCode.Size = new System.Drawing.Size(130, 25);
            this.txtCourseCode.Location = new System.Drawing.Point(160, 112);
            this.txtCourseCode.Size = new System.Drawing.Size(130, 25);

            // Grade
            this.lblGrade.Text = "Grade:";
            this.lblGrade.Location = new System.Drawing.Point(20, 160);
            this.lblGrade.Size = new System.Drawing.Size(130, 25);
            this.txtGrade.Location = new System.Drawing.Point(160, 157);
            this.txtGrade.Size = new System.Drawing.Size(130, 25);

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(20, 210);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(145, 210);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(270, 210);
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // DataGridView
            this.dgvEnrollments.Location = new System.Drawing.Point(20, 270);
            this.dgvEnrollments.Size = new System.Drawing.Size(940, 330);
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellClick);

            // Form settings
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRollNo);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvEnrollments);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvEnrollments;
    }
}