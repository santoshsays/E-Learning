using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admininformation : UserControl
    {
        public static admininformation _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");
        private string imageLocation = "";

        public admininformation()
        {
            InitializeComponent();
        }

        public static admininformation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new admininformation();
                }

                return _instance;
            }
        }

        private void addresstxt_Enter(object sender, EventArgs e)
        {
            addresstxt.Text = "";
        }

        private void admin_cancel_btn_Click(object sender, EventArgs e)
        {
            fnametxt.ForeColor = Color.Black;
            lnametxt.ForeColor = Color.Black;
            emailtxt.ForeColor = Color.Black;
            addresstxt.ForeColor = Color.Black;
            mobiletxt.ForeColor = Color.Black;

            con.Open();
            string search_query = "select * from users_tbl where u_email='" + Program.adminEmail + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fnametxt.Text = (dr["u_fname"].ToString());
                lnametxt.Text = (dr["u_lname"].ToString());
                emailtxt.Text = (dr["u_email"].ToString());
                addresstxt.Text = (dr["u_address"].ToString());
                mobiletxt.Text = (dr["u_mobile"].ToString());
            }

            con.Close();
            edit_here_panel.Visible = true;
            update_here_panel.Visible = false;
        }

        private void admin_image_show_Click(object sender, EventArgs e)
        {
        }

        private void admin_image_uploader_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "jpg files(*.jpg) |*.jpg | PNG files(*.png) |*.png|All files(*.*) | *.*"
            };
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.CheckFileExists)
                {
                    con.Open();
                    string CorrectFilename = System.IO.Path.GetFileName(dialog.FileName);
                    SqlCommand cmd = new SqlCommand("update users_tbl set  u_image ='\\UploadedFiles\\adminImages\\" + CorrectFilename + "' where  u_email='" + Program.adminEmail + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                    System.IO.File.Copy(dialog.FileName, paths + "\\UploadedFiles\\adminImages\\" + CorrectFilename);

                    imageLocation = dialog.FileName;
                    admin_image_show.ImageLocation = imageLocation;
                }
            }
        }

        private void admin_info_edit_toclear_Click(object sender, EventArgs e)
        {
            fnametxt.ForeColor = Color.DarkGray;
            lnametxt.ForeColor = Color.DarkGray;
            emailtxt.ForeColor = Color.DarkGray;
            addresstxt.ForeColor = Color.DarkGray;
            mobiletxt.ForeColor = Color.DarkGray;

            edit_here_panel.Visible = false;
            update_here_panel.Visible = true;
        }

        private void admin_info_header_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminedit_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string update_query = "update  users_tbl set u_fname='" + fnametxt.Text + "',u_lname='" + lnametxt.Text + "',u_email='" + emailtxt.Text + "',u_address='" + addresstxt.Text + "',u_mobile='" + mobiletxt.Text + "'where u_email='" + Program.adminEmail + "'";
            SqlDataAdapter usda = new SqlDataAdapter(update_query, con);
            usda.SelectCommand.ExecuteNonQuery();
            con.Close();

            con.Open();
            string search_query = "select * from users_tbl where u_email='" + Program.adminEmail + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fnametxt.Text = (dr["u_fname"].ToString());
                lnametxt.Text = (dr["u_lname"].ToString());
                emailtxt.Text = (dr["u_email"].ToString());
                addresstxt.Text = (dr["u_address"].ToString());
                mobiletxt.Text = (dr["u_mobile"].ToString());
                // admin_image_show.Image = (dr["image"].T);
            }

            con.Close();
            MessageBox.Show("Data Updated Successfully !");
            update_here_panel.Visible = false;
            edit_here_panel.Visible = true;
        }

        private void admininformation_Load(object sender, EventArgs e)

        {
            edit_here_panel.Visible = true;
            update_here_panel.Visible = false;
            string img_path = "";
            con.Open();
            string search_query = "select * from users_tbl where u_email='" + Program.adminEmail + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            {
                fnametxt.Text = (dr["u_fname"].ToString());
                lnametxt.Text = (dr["u_lname"].ToString());
                emailtxt.Text = (dr["u_email"].ToString());
                addresstxt.Text = (dr["u_address"].ToString());
                mobiletxt.Text = (dr["u_mobile"].ToString());
                img_path = dr["u_image"].ToString();
            }

            con.Close();
            if (img_path != "")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                admin_image_show.Image = Image.FromFile(paths + img_path);
            }
        }

        private void edit_here_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void emailtxt_Enter(object sender, EventArgs e)
        {
            emailtxt.Text = "";
        }

        private void fnametxt_Enter(object sender, EventArgs e)
        {
            fnametxt.Text = "";
        }

        private void lnametxt_Enter(object sender, EventArgs e)
        {
            lnametxt.Text = "";
        }

        private void mobiletxt_Enter(object sender, EventArgs e)
        {
            mobiletxt.Text = "";
        }
    }
}