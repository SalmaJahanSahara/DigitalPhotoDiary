using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPhotoDiary
{
    public partial class HomeWindow : Form
    {
        public string username;
        public HomeWindow()
        {
            InitializeComponent();
        }
        public HomeWindow(LogIn logIn)
        {
            InitializeComponent();
            this.username = logIn.usernameTextBox.Text;
            MessageBox.Show("Welcome " +username);
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backHomePageButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEvent newEvent = new NewEvent(this);
            this.Hide();
            newEvent.Show();
        }

        private void existingEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingEvent existingEvent = new ExistingEvent(this);
            this.Hide();
            existingEvent.Show();
        }
    }
}
