using System;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class master_uc : UserControl
    {
        private static master_uc _instance;

        public master_uc()
        {
            InitializeComponent();
        }

        public static master_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new master_uc();
                }

                return _instance;
            }
        }

        private void mcancel_Click(object sender, EventArgs e)
        {
            login_uc imc = new login_uc();
            this.Hide();
            this.Parent.Controls.Add(imc);
        }

        private void msubmit_Click(object sender, EventArgs e)
        {
            if (mtextBox.Text != "" && mtextBox.Text == "SDIT@2018!@$")
            {
                admin_add_uc ocb = new admin_add_uc();
                this.Hide();
                this.Parent.Controls.Add(ocb);
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

        private void password_hide_visible_MouseHover(object sender, EventArgs e)
        {
            mtextBox.PasswordChar = '\0';
        }

        private void password_hide_visible_MouseLeave(object sender, EventArgs e)
        {
            mtextBox.PasswordChar = '*';
        }
    }
}