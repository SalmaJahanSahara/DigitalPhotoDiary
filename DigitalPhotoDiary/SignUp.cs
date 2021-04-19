using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPhotoDiary
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked) { submitButton.Enabled = true; }
            else { submitButton.Enabled = false; }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("User Name can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else if (confirmpasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm Password can not be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a Date of Birth");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (BloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select Blood Group");
            }

            else
            {
                if (passwordTextBox.Text != confirmpasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }
                else
                {
                    string gender = "";
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                    connection.Open();
                    string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('" + nameTextBox.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "','" + emailTextBox.Text + "','" + dateOfBirthDateTimePicker.Text + "','" + gender + "','" + BloodGroupComboBox.Text + "')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User added");
                        DigitalPhotoDiary digitalPhotoDiary = new DigitalPhotoDiary();
                        this.Hide();
                        digitalPhotoDiary.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error!!!");
                    }
                    connection.Close();
                }
            }
        }

        private void backSignupButton_Click(object sender, EventArgs e)
        {
            DigitalPhotoDiary digitalPhotoDiary = new DigitalPhotoDiary();
            this.Hide();
            digitalPhotoDiary.Show();
        }
    }
}
