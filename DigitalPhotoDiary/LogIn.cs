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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("User Name can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {

                if (passwordTextBox.Text != passwordTextBox.Text && usernameTextBox.Text != usernameTextBox.Text)
                {
                    MessageBox.Show("Wrong Information !!!");
                }
                else
                {
                    // Code for next step
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                    connection.Open();
                    string sql = "SELECT * FROM Users WHERE Username = '" + usernameTextBox.Text + "'and password = '" + passwordTextBox.Text + "'";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        usernameTextBox.Text = reader["Username"].ToString();
                        passwordTextBox.Text = reader["Password"].ToString();

                        //MessageBox.Show("Welcome " + usernameTextBox.Text);

                        HomeWindow homePage = new HomeWindow(this);
                        this.Hide();
                        homePage.Show();

                    }
                    else
                    {
                        MessageBox.Show("Wrong Information !!!");
                        usernameTextBox.Text = passwordTextBox.Text = "";
                    }
                    connection.Close();
                }
            }

        }

        private void backLoginButton_Click(object sender, EventArgs e)
        {
            DigitalPhotoDiary digitalPhotoDiary = new DigitalPhotoDiary();
            this.Hide();
            digitalPhotoDiary.Show();
        }
    }
}
