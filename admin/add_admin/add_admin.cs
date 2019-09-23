using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class add_admin : Form
    {
        public const int HT_CAPTION = 0X2;

        public const int WM_NCLBUTTONDOWN = 0XA1;

        public add_admin()
        {
            InitializeComponent();
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            if (!load_panel.Controls.Contains(knowus_uc.Instance))
            {
                load_panel.Controls.Add(knowus_uc.Instance);
                knowus_uc.Instance.Dock = DockStyle.Fill;
                knowus_uc.Instance.BringToFront();
            }
            else
            {
                knowus_uc.Instance.BringToFront();
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            if (!load_panel.Controls.Contains(login_uc.Instance))
            {
                load_panel.Controls.Add(login_uc.Instance);
                login_uc.Instance.Dock = DockStyle.Fill;
                login_uc.Instance.BringToFront();
            }
            else
            {
                login_uc.Instance.BringToFront();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //Login olmyn = new Login();
            // olmyn.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (!load_panel.Controls.Contains(terms_uc.Instance))
            {
                load_panel.Controls.Add(terms_uc.Instance);
                terms_uc.Instance.Dock = DockStyle.Fill;
                terms_uc.Instance.BringToFront();
            }
            else
            {
                terms_uc.Instance.BringToFront();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (!load_panel.Controls.Contains(aboutus_ucc.Instance))
            {
                load_panel.Controls.Add(aboutus_ucc.Instance);
                aboutus_ucc.Instance.Dock = DockStyle.Fill;
                aboutus_ucc.Instance.BringToFront();
            }
            else
            {
                aboutus_ucc.Instance.BringToFront();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (!load_panel.Controls.Contains(contactus_uc.Instance))
            {
                load_panel.Controls.Add(contactus_uc.Instance);
                contactus_uc.Instance.Dock = DockStyle.Fill;
                contactus_uc.Instance.BringToFront();
            }
            else
            {
                contactus_uc.Instance.BringToFront();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.csoys.wordpress.com");
        }

        private void mcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void msubmit_Click(object sender, EventArgs e)
        {
            if (mtextBox.Text != "" && mtextBox.Text == "SDIT@2018!@$")
            {
                if (!load_panel.Controls.Contains(admin_add_uc.Instance))
                {
                    load_panel.Controls.Add(admin_add_uc.Instance);
                    admin_add_uc.Instance.Dock = DockStyle.Fill;
                    admin_add_uc.Instance.BringToFront();
                }
                else
                {
                    admin_add_uc.Instance.BringToFront();
                }
                mainpanel.Visible = false;
            }
            else if (mtextBox.Text == "" && mtextBox.Text != "SDIT@2018!@$")
            {
                loginmesgbox olmns = new loginmesgbox();
                olmns.Show();
            }
        }

        private void mtextBox_Enter(object sender, EventArgs e)
        {
            if (mtextBox.Text == "Password")
            {
                mtextBox.Text = "";
                mtextBox.PasswordChar = '*';
                mtextBox.ForeColor = Color.Teal;
            }
        }

        private void mtextBox_Leave(object sender, EventArgs e)
        {
            if (mtextBox.Text == "")
            {
                mtextBox.PasswordChar = '\0';
                mtextBox.Text = "Password";
                mtextBox.ForeColor = Color.DarkGray;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void password_hide_visible_MouseHover(object sender, EventArgs e)
        {
            mtextBox.PasswordChar = '\0';
        }

        private void password_hide_visible_MouseLeave(object sender, EventArgs e)
        {
            mtextBox.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}