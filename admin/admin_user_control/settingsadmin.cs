using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class settingsadmin : UserControl
    {
        private static settingsadmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public settingsadmin()
        {
            InitializeComponent();
        }

        public static settingsadmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new settingsadmin();
                }

                return _instance;
            }
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            retypenewpasswordtxt.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            retypenewpasswordtxt.PasswordChar = '*';
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            oldpasswordtxt.Text = "";
            newpasswordtxt.Text = "";
            retypenewpasswordtxt.Text = "";
        }

        private void password_hide_visible_MouseHover(object sender, EventArgs e)
        {
            newpasswordtxt.PasswordChar = '\0';
        }

        private void password_hide_visible_MouseLeave(object sender, EventArgs e)
        {
            newpasswordtxt.PasswordChar = '*';
        }

        private void settingsadmin_Load(object sender, EventArgs e)
        {
        }

        private void updatepasswordbtn_Click(object sender, EventArgs e)
        {
            if (oldpasswordtxt.Text == "" | newpasswordtxt.Text == "" | retypenewpasswordtxt.Text == "")
            {
                MessageBox.Show("Please Enter the valid old password ");
                oldpasswordtxt.Text = "";
                newpasswordtxt.Text = "";
                retypenewpasswordtxt.Text = "";
            }
            if (newpasswordtxt.Text != retypenewpasswordtxt.Text)
            {
                MessageBox.Show("New password do not match! ");
                newpasswordtxt.Text = "";
                retypenewpasswordtxt.Text = "";
            }
            else if (newpasswordtxt.Text == retypenewpasswordtxt.Text)
            {
                con.Open();
                string view_query = "select u_password from users_tbl where u_email='" + Program.adminEmail + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                con.Close();
                if (oldpasswordtxt.Text == dt.Rows[0]["u_password"].ToString())
                {
                    con.Open();
                    SqlCommand nwbda1 = new SqlCommand("exec updateadminpass @email = '" + Program.adminEmail + "', @old='" + oldpasswordtxt.Text + "',@new ='" + newpasswordtxt.Text + "'", con);
                    nwbda1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password Updated Succesfully !");
                    oldpasswordtxt.Text = "";
                    newpasswordtxt.Text = "";
                    retypenewpasswordtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Old password do not match !");
                    oldpasswordtxt.Text = "";
                    newpasswordtxt.Text = "";
                    retypenewpasswordtxt.Text = "";
                }
            }
        }
    }
}