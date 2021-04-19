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
    public partial class ExistingEvent : Form
    {
        public string eventName;
        public string username;
        public ExistingEvent()
        {
            InitializeComponent();
            fillComboBox();
        }
        HomeWindow homeWindow;

        public ExistingEvent(HomeWindow homeWindow)
        {   
            InitializeComponent();
            this.homeWindow = homeWindow;
            username = homeWindow.username;
            fillComboBox();
            //MessageBox.Show("Existing " + username);
        }
        PictureEvents pictureEvents;
        public ExistingEvent(PictureEvents pictureEvents)
        {   
            InitializeComponent();
            this.pictureEvents = pictureEvents;
            username = pictureEvents.username;
            fillComboBox();
            //MessageBox.Show("Existing " + username);
        }

        private void ExistingEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backExixtingEventButton_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Hide();
            homeWindow.Show();
        }

        private void existingEventButton_Click(object sender, EventArgs e)
        {
            eventName = existingEventComboBox.Text;
            if (existingEventComboBox.Text == "")
            {
                MessageBox.Show("Event name is empty");
            }
            else
            {
                eventName = existingEventComboBox.Text;
                PictureEvents pictureEvents = new PictureEvents(this);
                this.Hide();
                pictureEvents.Show();
            }
        }

        private void existingEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventName = existingEventComboBox.Text;
        }
        public void fillComboBox()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            string sql = "SELECT * from Events Where Username ='" + username + "'";
            
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            try
            {
                while (reader.Read())
                {
                    eventName = reader.GetString(1);
                    existingEventComboBox.Items.Add(eventName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close(); 
        }
    }
}
