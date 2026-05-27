namespace StudentManagementSystem.Forms
{
    partial class LoginForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form title label
            this.lblTitle.Text = "Student Management System";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 30);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Username label
            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(80, 100);
            this.lblUsername.Size = new System.Drawing.Size(80, 20);

            // Username textbox
            this.txtUsername.Location = new System.Drawing.Point(180, 97);
            this.txtUsername.Size = new System.Drawing.Size(200, 22);

            // Password label
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(80, 140);
            this.lblPassword.Size = new System.Drawing.Size(80, 20);

            // Password textbox - hidden characters
            this.txtPassword.Location = new System.Drawing.Point(180, 137);
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.PasswordChar = '*';

            // Login button
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(180, 180);
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}