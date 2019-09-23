using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class UserControl2 : UserControl
    {
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public UserControl2()
        {
            InitializeComponent();
        }

        private void admin_welcome_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void loginaccountbtn_Click(object sender, EventArgs e)
        {
            login_uc icut = new login_uc();
            this.Hide();
            this.Parent.Controls.Add(icut);
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select u_fname from users_tbl where u_email='" + Program.adminregfname + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            userlblcount.Text = dt.Rows[0]["u_fname"].ToString();
            con.Close();
        }
    }
}