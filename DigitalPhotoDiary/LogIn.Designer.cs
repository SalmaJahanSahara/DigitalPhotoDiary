
namespace DigitalPhotoDiary
{
    partial class LogIn
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
            this.logInGroupBox = new System.Windows.Forms.GroupBox();
            this.backLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logInGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInGroupBox
            // 
            this.logInGroupBox.Controls.Add(this.label1);
            this.logInGroupBox.Controls.Add(this.backLoginButton);
            this.logInGroupBox.Controls.Add(this.backButton);
            this.logInGroupBox.Controls.Add(this.logInButton);
            this.logInGroupBox.Controls.Add(this.passwordTextBox);
            this.logInGroupBox.Controls.Add(this.password);
            this.logInGroupBox.Controls.Add(this.usernameTextBox);
            this.logInGroupBox.Controls.Add(this.username);
            this.logInGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInGroupBox.Location = new System.Drawing.Point(12, 25);
            this.logInGroupBox.Name = "logInGroupBox";
            this.logInGroupBox.Size = new System.Drawing.Size(437, 284);
            this.logInGroupBox.TabIndex = 3;
            this.logInGroupBox.TabStop = false;
            this.logInGroupBox.Text = "Log In";
            // 
            // backLoginButton
            // 
            this.backLoginButton.Location = new System.Drawing.Point(23, 232);
            this.backLoginButton.Name = "backLoginButton";
            this.backLoginButton.Size = new System.Drawing.Size(122, 30);
            this.backLoginButton.TabIndex = 26;
            this.backLoginButton.Text = "Back";
            this.backLoginButton.UseVisualStyleBackColor = true;
            this.backLoginButton.Click += new System.EventHandler(this.backLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(147, 540);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(155, 30);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(186, 232);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(229, 30);
            this.logInButton.TabIndex = 18;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(186, 183);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(229, 31);
            this.passwordTextBox.TabIndex = 5;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(19, 186);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 21);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(186, 146);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(229, 31);
            this.usernameTextBox.TabIndex = 3;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(19, 149);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(92, 21);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Digital Photo Diary";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 343);
            this.Controls.Add(this.logInGroupBox);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.logInGroupBox.ResumeLayout(false);
            this.logInGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox logInGroupBox;
        public System.Windows.Forms.Button backLoginButton;
        public System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Button logInButton;
        public System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
    }
}