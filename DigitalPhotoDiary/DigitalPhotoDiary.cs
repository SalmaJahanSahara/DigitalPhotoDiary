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
    public partial class DigitalPhotoDiary : Form
    {
        public DigitalPhotoDiary()
        {
            InitializeComponent();
        }

        private void DigitalPhotoDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }
    }
}
