namespace StudentManagementSystem.Forms
{
    partial class CourseForm
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Course Form";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(940, 35);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Course Code
            this.lblCode.Text = "Course Code:";
            this.lblCode.Location = new System.Drawing.Point(20, 70);
            this.lblCode.Size = new System.Drawing.Size(110, 25);
            this.txtCode.Location = new System.Drawing.Point(140, 67);
            this.txtCode.Size = new System.Drawing.Size(150, 25);

            // Course Name
            this.lblName.Text = "Course Name:";
            this.lblName.Location = new System.Drawing.Point(20, 115);
            this.lblName.Size = new System.Drawing.Size(110, 25);
            this.txtName.Location = new System.Drawing.Point(140, 112);
            this.txtName.Size = new System.Drawing.Size(150, 25);

            // Credit Hours
            this.lblCredits.Text = "Credit Hours:";
            this.lblCredits.Location = new System.Drawing.Point(20, 160);
            this.lblCredits.Size = new System.Drawing.Size(110, 25);
            this.txtCredits.Location = new System.Drawing.Point(140, 157);
            this.txtCredits.Size = new System.Drawing.Size(150, 25);

            // CRUD Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(20, 210);
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(145, 210);
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(270, 210);
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(395, 210);
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // DataGridView
            this.dgvCourses.Location = new System.Drawing.Point(20, 270);
            this.dgvCourses.Size = new System.Drawing.Size(940, 330);
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);

            // Form settings
            this.ClientSize = new System.Drawing.Size(980, 630);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvCourses);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Course Form";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}