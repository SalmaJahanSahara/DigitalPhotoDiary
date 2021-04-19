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
   
    public partial class AddPhotos : Form
    { 
        public string username;
        public string eventName;
        public AddPhotos()
        {
            InitializeComponent();
        }
        PictureEvents pictureEvents;
        public AddPhotos(PictureEvents pictureEvents)
        {
            InitializeComponent();
            this.pictureEvents = pictureEvents;
            this.username = pictureEvents.username;
            this.eventName = pictureEvents.eventName;
        }

        private void AddPhotos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backExixtingEventButton_Click(object sender, EventArgs e)
        {
            PictureEvents pictureEvents = new PictureEvents(this);
            this.Hide();
            pictureEvents.Show();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            selectPictureLabel.Text = openFileDialog1.FileName;
            addPhotosPictureBox.ImageLocation = openFileDialog1.FileName;
         
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (highRadioButton.Checked || lessImportantRadioButton.Checked || moderateRadioButton.Checked)
            {
                if (highRadioButton.Checked)
                    importanceLabel.Text = "High";
                else if (lessImportantRadioButton.Checked)
                    importanceLabel.Text = "Less Important";
                else
                    importanceLabel.Text = "Moderate";


                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO Pictures(EventName, Username, PictureLocation, CreatedDate,  PictureStory, Importance) " +
                    "VALUES('" + eventName + "','"+username+ "','" +selectPictureLabel.Text+"','" + aPdateTimePicker.Value + "','"+pictureStoryTextBox.Text+"','"+ importanceLabel.Text + "')";
                //MessageBox.Show("SQL: " + sql);
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Picture added to Event: " + eventName);
                    PictureEvents pictureEvents = new PictureEvents(this);
                    this.Hide();
                    pictureEvents.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            else
            { 
                MessageBox.Show("Select Importance Level"); 
            }
        }

        private void AddPhotos_Load(object sender, EventArgs e)
        {
            eventNameLabel.Text = eventName;
        }
    }
}
