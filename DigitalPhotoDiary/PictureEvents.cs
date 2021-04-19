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
    public partial class PictureEvents : Form
    {
        public string username;
        public int arr;
        public string pictureId;
        public string eventName;
        public string[] pictureStoryArray = new string[100];
        public string[] importanceArray = new string[100];
        public string[] createdDateArray = new string[100];
        public string[] modifyDateArray = new string[100];
        public string[] pictureIdArray = new string[100];
        public List<Image> LoadedImages { get; set; }

        public PictureEvents()
        {
            InitializeComponent();
        }
        //AddPhotos addPhotos;
        public PictureEvents(AddPhotos addPhotos)
        {
            InitializeComponent();
            this.username = addPhotos.username;
            this.eventName = addPhotos.eventName;
        }
        //PictureEvents pictureEvents;
       /* public PictureEvents(PictureEvents pictureEvets)
        {
            InitializeComponent();
            this.username = pictureEvents.username;
            this.eventName = pictureEvents.eventName;
        }*/
        ExistingEvent existingEvent;
        public PictureEvents(ExistingEvent existingEvent)
        {
            InitializeComponent();
            this.existingEvent = existingEvent;
            this.username = existingEvent.username;
            this.eventName = existingEvent.existingEventComboBox.Text;
        }
        ModifyPictures modifyPictures;
        public PictureEvents( ModifyPictures modifyPictures)
        {
            InitializeComponent();
            this.modifyPictures = modifyPictures;
            this.username = modifyPictures.username;
            this.eventName = modifyPictures.eventName;
        }

        private void PictureEvents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PictureEvents_Load(object sender, EventArgs e)
        {
            eventNameLabel.Text = eventName;
            LoadImagesFromFolder();
            ImageList images = new ImageList();
            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }
            pictureEventsListView.LargeImageList = images;
            for (int itemIndex = 1; itemIndex <= LoadedImages.Count; itemIndex++)
                pictureEventsListView.Items.Add(new ListViewItem($"Image {itemIndex}", itemIndex - 1));
        }
        private void LoadImagesFromFolder()
        {
            LoadedImages = new List<Image>(); // List for images
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            string sql = "SELECT * from Pictures Where EventName='" + eventName + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    var tempLocation = reader["PictureLocation"].ToString();
                    var tempImage = Image.FromFile(tempLocation);
                    LoadedImages.Add(tempImage);

                    pictureStoryArray[arr] = reader["PictureStory"].ToString();
                    importanceArray[arr] = reader["Importance"].ToString();
                    createdDateArray[arr] = reader["CreatedDate"].ToString();
                    modifyDateArray[arr] = reader["ModifiedDate"].ToString();
                    pictureIdArray[arr] = reader["PictureId"].ToString();
                    //MessageBox.Show(pictureStoryArray[arr]);
                    arr++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureEventsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureEventsListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = pictureEventsListView.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                peImportanceLabel.Text = importanceArray[selectedIndex];
                peCreatedDateLabel.Text = createdDateArray[selectedIndex];
                peModifiedDateLabel.Text = modifyDateArray[selectedIndex];
                if (peModifiedDateLabel.Text == "")
                {
                    modifiedDateLabel.Visible = false;
                }
                pictureStoryLabel.Text = pictureStoryArray[selectedIndex];
                eventNamePictureBox.Image = selectedImg;
            }
        }

        private void pictureEventsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (pictureEventsListView.SelectedIndices.Count > 0)
            {
                int selectedIndex = pictureEventsListView.SelectedIndices[0];
                Image selectedImg = LoadedImages[selectedIndex];
                eventNamePictureBox.Image = selectedImg;
                pictureStoryLabel.Text = pictureStoryArray[selectedIndex];
                pictureId = pictureIdArray[selectedIndex];
                
            }
        }

        private void backExixtingEventButton_Click(object sender, EventArgs e)
        {
            ExistingEvent existingEvent = new ExistingEvent(this);
            this.Hide();
            existingEvent.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPhotos addPhotos = new AddPhotos(this);
            this.Hide();
            addPhotos.Show();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifyPictures modifyPictures = new ModifyPictures(this);
            this.Hide();
            modifyPictures.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "DELETE FROM Pictures WHERE PictureID='" + pictureId.ToString() + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Picture Deleted");

                //PictureEvents pictureEvents = new PictureEvents(this);
                connection.Close(); 
                ExistingEvent existingEvent = new ExistingEvent(this);
                this.Hide();
                existingEvent.Show();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
