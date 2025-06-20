
namespace Restaurant_Management_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labUsername = new Label();
            txtUsername = new TextBox();
            labPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labUsername
            // 
            labUsername.AutoSize = true;
            labUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labUsername.Location = new Point(30, 206);
            labUsername.Name = "labUsername";
            labUsername.Size = new Size(81, 20);
            labUsername.TabIndex = 0;
            labUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 229);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(254, 43);
            txtUsername.TabIndex = 1;
            // 
            // labPass
            // 
            labPass.AutoSize = true;
            labPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labPass.Location = new Point(30, 287);
            labPass.Name = "labPass";
            labPass.Size = new Size(77, 20);
            labPass.TabIndex = 2;
            labPass.Text = "Password";
            labPass.Click += labPass_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(30, 310);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(254, 43);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(149, 152, 64);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(36, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(204, 88, 3);
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(182, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 44);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 173);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(204, 88, 3);
            pictureBox1.Image = Properties.Resources.Welcomee;
            pictureBox1.Location = new Point(-165, -65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(664, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 450);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(labPass);
            Controls.Add(txtUsername);
            Controls.Add(labUsername);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void labPass_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labUsername;
        private TextBox txtUsername;
        private Label labPass;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}