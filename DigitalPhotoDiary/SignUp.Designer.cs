
namespace DigitalPhotoDiary
{
    partial class SignUp
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
            this.signupGroupBox = new System.Windows.Forms.GroupBox();
            this.backSignupButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.termsCheckBox = new System.Windows.Forms.CheckBox();
            this.BloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroup = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.confirmpasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signupGroupBox
            // 
            this.signupGroupBox.Controls.Add(this.backSignupButton);
            this.signupGroupBox.Controls.Add(this.submitButton);
            this.signupGroupBox.Controls.Add(this.termsCheckBox);
            this.signupGroupBox.Controls.Add(this.BloodGroupComboBox);
            this.signupGroupBox.Controls.Add(this.bloodGroup);
            this.signupGroupBox.Controls.Add(this.femaleRadioButton);
            this.signupGroupBox.Controls.Add(this.maleRadioButton);
            this.signupGroupBox.Controls.Add(this.gender);
            this.signupGroupBox.Controls.Add(this.dateOfBirthDateTimePicker);
            this.signupGroupBox.Controls.Add(this.dateOfBirth);
            this.signupGroupBox.Controls.Add(this.emailTextBox);
            this.signupGroupBox.Controls.Add(this.email);
            this.signupGroupBox.Controls.Add(this.confirmpasswordTextBox);
            this.signupGroupBox.Controls.Add(this.confirmPassword);
            this.signupGroupBox.Controls.Add(this.passwordTextBox);
            this.signupGroupBox.Controls.Add(this.password);
            this.signupGroupBox.Controls.Add(this.usernameTextBox);
            this.signupGroupBox.Controls.Add(this.username);
            this.signupGroupBox.Controls.Add(this.nameTextBox);
            this.signupGroupBox.Controls.Add(this.name);
            this.signupGroupBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupGroupBox.Location = new System.Drawing.Point(42, 12);
            this.signupGroupBox.Name = "signupGroupBox";
            this.signupGroupBox.Size = new System.Drawing.Size(434, 509);
            this.signupGroupBox.TabIndex = 2;
            this.signupGroupBox.TabStop = false;
            this.signupGroupBox.Text = "Sign Up";
            // 
            // backSignupButton
            // 
            this.backSignupButton.Location = new System.Drawing.Point(146, 459);
            this.backSignupButton.Name = "backSignupButton";
            this.backSignupButton.Size = new System.Drawing.Size(155, 30);
            this.backSignupButton.TabIndex = 25;
            this.backSignupButton.Text = "Back";
            this.backSignupButton.UseVisualStyleBackColor = true;
            this.backSignupButton.Click += new System.EventHandler(this.backSignupButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(146, 408);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(155, 30);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // termsCheckBox
            // 
            this.termsCheckBox.AutoSize = true;
            this.termsCheckBox.Location = new System.Drawing.Point(66, 367);
            this.termsCheckBox.Name = "termsCheckBox";
            this.termsCheckBox.Size = new System.Drawing.Size(319, 25);
            this.termsCheckBox.TabIndex = 17;
            this.termsCheckBox.Text = "I agree all the terms and conditions";
            this.termsCheckBox.UseVisualStyleBackColor = true;
            this.termsCheckBox.CheckedChanged += new System.EventHandler(this.termsCheckBox_CheckedChanged);
            // 
            // BloodGroupComboBox
            // 
            this.BloodGroupComboBox.FormattingEnabled = true;
            this.BloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodGroupComboBox.Location = new System.Drawing.Point(184, 320);
            this.BloodGroupComboBox.Name = "BloodGroupComboBox";
            this.BloodGroupComboBox.Size = new System.Drawing.Size(229, 29);
            this.BloodGroupComboBox.TabIndex = 16;
            // 
            // bloodGroup
            // 
            this.bloodGroup.AutoSize = true;
            this.bloodGroup.Location = new System.Drawing.Point(18, 320);
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.Size = new System.Drawing.Size(115, 21);
            this.bloodGroup.TabIndex = 15;
            this.bloodGroup.Text = "Blood Group";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(322, 284);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(91, 25);
            this.femaleRadioButton.TabIndex = 14;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(184, 282);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(73, 25);
            this.maleRadioButton.TabIndex = 13;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(17, 284);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(69, 21);
            this.gender.TabIndex = 12;
            this.gender.Text = "Gender";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(184, 236);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(229, 31);
            this.dateOfBirthDateTimePicker.TabIndex = 11;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2021, 4, 13, 0, 0, 0, 0);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Location = new System.Drawing.Point(17, 236);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(117, 21);
            this.dateOfBirth.TabIndex = 10;
            this.dateOfBirth.Text = "Date of Birth";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(184, 191);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(229, 31);
            this.emailTextBox.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(17, 194);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 21);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // confirmpasswordTextBox
            // 
            this.confirmpasswordTextBox.Location = new System.Drawing.Point(184, 153);
            this.confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            this.confirmpasswordTextBox.PasswordChar = '*';
            this.confirmpasswordTextBox.Size = new System.Drawing.Size(229, 31);
            this.confirmpasswordTextBox.TabIndex = 7;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(17, 156);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(161, 21);
            this.confirmPassword.TabIndex = 6;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(184, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(229, 31);
            this.passwordTextBox.TabIndex = 5;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(17, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 21);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(184, 75);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(229, 31);
            this.usernameTextBox.TabIndex = 3;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(17, 78);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(92, 21);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(184, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(229, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(17, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 21);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(132, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "Digital Photo Diary";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupGroupBox);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.signupGroupBox.ResumeLayout(false);
            this.signupGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox signupGroupBox;
        public System.Windows.Forms.Button backSignupButton;
        public System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox termsCheckBox;
        public System.Windows.Forms.ComboBox BloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroup;
        public System.Windows.Forms.RadioButton femaleRadioButton;
        public System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label gender;
        public System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.Label dateOfBirth;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox confirmpasswordTextBox;
        private System.Windows.Forms.Label confirmPassword;
        public System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label username;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
    }
}