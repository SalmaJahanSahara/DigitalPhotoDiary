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
    public partial class ModifyPictures : Form
    {
        public string username;
        public string eventName;
        public string pictureId;
        public string pictureStory;
        public string importance;
        public string pictureLocation;
        public ModifyPictures()
        {
            InitializeComponent();
        }
        PictureEvents pictureEvents;
        public ModifyPictures(PictureEvents pictureEvents)
        {
            InitializeComponent();
            this.pictureEvents = pictureEvents;
            eventName = pictureEvents.eventName;
            username = pictureEvents.username;
            pictureId = pictureEvents.pictureId;
            importance = pictureEvents.peImportanceLabel.Text;
        }

        private void ModifyPictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backExixtingEventButton_Click(object sender, EventArgs e)
        {
            PictureEvents pictureEvents = new PictureEvents(this);
            this.Hide();
            pictureEvents.Show();
        }

        private void ModifyPictures_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "SELECT * from Pictures Where PictureId='" +Convert.ToInt32( pictureId) + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    addPhotosPictureBox.ImageLocation=reader["PictureLocation"].ToString();
                    eventNameLabel.Text= reader["EventName"].ToString();
                    selectPictureLabel.Text = reader["PictureLocation"].ToString();
                    pictureStoryTextBox.Text = reader["PictureStory"].ToString();
                    importance = reader["Importance"].ToString();
                    if (importance == "High")
                    {
                        highRadioButton.Checked = true;
                        importanceLabel.Text = "High";
                    }
                    else if (importance == "Moderate")
                    {
                        moderateRadioButton.Checked = true;
                        importanceLabel.Text = "Moderate";
                    }
                    else if (importance == "Less Important")
                    {
                        lessImportantRadioButton.Checked = true;
                        importanceLabel.Text = "Less Important";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database can not be accessed");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (highRadioButton.Checked)
                {
                    
                    importanceLabel.Text = "High";
                }
                else if (moderateRadioButton.Checked)
                {
                     
                    importanceLabel.Text = "Moderate";
                }
                else if (lessImportantRadioButton.Checked)
                {
                     
                    importanceLabel.Text = "Less Important";
                }
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "UPDATE Pictures SET PictureStory='" + pictureStoryTextBox.Text + "', Importance='" + importanceLabel.Text + "',ModifiedDate='" + modifyDateTimePicker.Value +
                    "',PictureLocation='" + selectPictureLabel.Text + "'Where PictureId='" + Convert.ToInt32( pictureId )+ "'";

                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    addPhotosPictureBox.ImageLocation = reader["PictureLocation"].ToString();
                    eventNameLabel.Text = reader["EventName"].ToString();
                    selectPictureLabel.Text = reader["PictureLocation"].ToString();
                    pictureStoryTextBox.Text = reader["PictureStory"].ToString();
                    importance = reader["Importance"].ToString();
                    if (importance == "High")
                    {
                        highRadioButton.Checked = true;

                    }
                    else if (importance == "Moderate")
                    {
                        moderateRadioButton.Checked = true;

                    }
                    else if (importance == "Less Important")
                    {
                        lessImportantRadioButton.Checked = true;

                    }

                }
                MessageBox.Show("Your picture is modified");
                PictureEvents pictureEvents = new PictureEvents(this);
                this.Hide();
                pictureEvents.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database can not be accessed");
            }
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            selectPictureLabel.Text = openFileDialog1.FileName;
            addPhotosPictureBox.ImageLocation = openFileDialog1.FileName;
        }
    }
}
