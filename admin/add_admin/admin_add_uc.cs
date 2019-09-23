using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admin_add_uc : UserControl
    {
        public static admin_add_uc _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public admin_add_uc()
        {
            InitializeComponent();
        }

        public static admin_add_uc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new admin_add_uc();
                }

                return _instance;
            }
        }

        private void admin_add_uc_Load(object sender, EventArgs e)
        {
        }

        private void admin_info_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnaboutus_Click(object sender, EventArgs e)
        {
            knowus use = new knowus();
            use.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ol = new Login();
            ol.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contactus cse = new contactus();
            cse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            knowus use = new knowus();
            use.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ol = new Login();
            ol.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactus cse = new contactus();
            cse.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ol = new Login();
            ol.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void loginaccountbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ilogin = new Login();
            ilogin.Show();
        }

        private void password_hide_visible_Click(object sender, EventArgs e)
        {
            if (passwordtxt.PasswordChar == '*')
            {
                passwordtxt.PasswordChar = '\0';
            }
            else if (passwordtxt.PasswordChar == '\0')
            {
                passwordtxt.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ol = new Login();
            ol.Show();
        }

        private void re_password_hide_visible_Click(object sender, EventArgs e)
        {
            if (retypepasswordtxt.PasswordChar == '*')
            {
                retypepasswordtxt.PasswordChar = '\0';
            }
            else if (retypepasswordtxt.PasswordChar == '\0')
            {
                retypepasswordtxt.PasswordChar = '*';
            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (termscheckbox.Checked == true)
            {
                if (fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != ""
                    && passwordtxt.Text == retypepasswordtxt.Text && addresstxt.Text != "" && mobiletxt.Text != "")
                {
                    con.Open();
                    Program.adminregfname = emailtxt.Text;
                    SqlDataAdapter sda = new SqlDataAdapter("insert into users_tbl(u_fname,u_lname,u_email,u_password,u_retypepassword,u_address,u_mobile) values('" + fnametxt.Text + "','" + lnametxt.Text + "','" + emailtxt.Text + "','" + passwordtxt.Text + "','" + retypepasswordtxt.Text + "','" + addresstxt.Text + "','" + mobiletxt.Text + "')", con);
                    sda.SelectCommand.ExecuteNonQuery();

                    con.Close();
                    //to call second user controls
                    UserControl2 seconds = new UserControl2();
                    this.Hide();
                    this.Parent.Controls.Add(seconds);
                }
                else if (fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != ""
                   && passwordtxt.Text != retypepasswordtxt.Text && addresstxt.Text != "" && mobiletxt.Text != "")
                {
                    MessageBox.Show("Password Do match, Please check it");
                    passwordtxt.Text = "";
                    retypepasswordtxt.Text = "";
                }
                else if (fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == ""
                   && addresstxt.Text == "" && mobiletxt.Text == "")
                {
                    MessageBox.Show("Plese Please Enter all field to Create ur account ");
                }
            }
            if (termscheckbox.Checked == false)
            {
                if (fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != ""
                   && passwordtxt.Text == retypepasswordtxt.Text && addresstxt.Text != "" && mobiletxt.Text != "")
                {
                    MessageBox.Show("Plese Check the Terms & Conditions");
                }
                else if (fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != ""
                   && passwordtxt.Text != retypepasswordtxt.Text && addresstxt.Text != "" && mobiletxt.Text != "")
                {
                    MessageBox.Show("Plese Check the Terms & Conditions & Password Do NOt Match");
                    passwordtxt.Text = "";
                    retypepasswordtxt.Text = "";
                }
                else if (fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == ""
                   && addresstxt.Text == "" && mobiletxt.Text == "")
                {
                    MessageBox.Show("Plese Check Terms and Condtions & Enter all field to Create ur account ");
                }
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            login_uc icu = new login_uc();
            this.Hide();
            this.Parent.Controls.Add(icu);
        }
    }
}