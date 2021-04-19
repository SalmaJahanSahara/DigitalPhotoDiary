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
    public partial class NewEvent : Form
    {   
        public string username;
        public NewEvent()
        {
            InitializeComponent();
        }
        public NewEvent(HomeWindow homeWindow)
        {
            InitializeComponent();
            this.username = homeWindow.username;
            //MessageBox.Show("Hi " +username);
        }
        //createEventDateTimePicker



        private void NewEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backNewEventButton_Click(object sender, EventArgs e)
        {
            HomeWindow homePage = new HomeWindow();
            this.Hide();
            homePage.Show();
        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO Events(EventName, Username, EventCreated) VALUES('" + newEventTextBox.Text + "', '" +username+ "', '" + createEventDateTimePicker.Text+ "')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                //newEventTextBox = createTextBox.Text;

                MessageBox.Show(newEventTextBox.Text + " Event has created successfully!");

                HomeWindow homeWindow = new HomeWindow();
                this.Hide();
                homeWindow.Show();

            }
            else
            {
                MessageBox.Show("Error");
            }
            connection.Close();
            //MessageBox.Show(createEventDateTimePicker.Text);
        }
    }
}
