using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class aboutus : Form
    {
        public const int HT_CAPTION = 0X2;

        public const int WM_NCLBUTTONDOWN = 0XA1;
        private const int CS_DropShadow = 0x00020000;

        public aboutus()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        private void headerbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void headerbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void mithunpanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}