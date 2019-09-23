using System;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void appleclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applemax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void applemin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}