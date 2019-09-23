using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class newsaddadmin : UserControl
    {
        private static newsaddadmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public newsaddadmin()
        {
            InitializeComponent();
            user_combox_Load();
        }

        public static newsaddadmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new newsaddadmin();
                }

                return _instance;
            }
        }

        public void setRed()
        {
            adminnewsdatebtn.BackColor = Color.Red;
            adminnewsforbtn.BackColor = Color.Red;
            teacher_news_search_bydate.BackColor = Color.Red;
            teacher_news_search_byfor.BackColor = Color.Red;
        }

        private void admin_news_add_btn_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            if (adminnewsidtextbox.Text != "" && adminnewstitletextbox.Text != "" && adminnewsdesctextbox.Text != "" && adminnewsforbtn.Text != "")
            {
                con.Open();
                string insert_query = "insert into newss_tbl(n_id,n_title,n_description,n_date,n_for,n_by) values('" + adminnewsidtextbox.Text + "','" + adminnewstitletextbox.Text + "','" + adminnewsdesctextbox.Text + "','" + adminnewsdatebtn.Value + "','" + adminnewsforbtn.Text + "','" + adminnewsbytxtbox.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(insert_query, con);
                sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select * from newss_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminnewsdatagrid.DataSource = dt;
                clear();
                con.Close();
            }

            //}
            //catch (Exception)
            else
            {
                MessageBox.Show("Please fill all the data to Add News");
            }
        }

        private void admin_news_clear_btn_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void admin_news_delete_btn_Click_1(object sender, EventArgs e)
        {
            // try
            // {
            if (adminnewsidtextbox.Text != "" && adminnewstitletextbox.Text != "" && adminnewsdesctextbox.Text != "" && adminnewsforbtn.Text != "" && adminnewsbytxtbox.Text == userlbl.Text)
            {
                con.Open();
                string delete_query = "delete from newss_tbl where n_id ='" + adminnewsidtextbox.Text + "' and n_by='" + Program.username + "'";
                SqlDataAdapter d_sda = new SqlDataAdapter(delete_query, con);
                d_sda.SelectCommand.ExecuteNonQuery();

                con.Close();

                con.Open();
                string view_query = "select * from newss_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminnewsdatagrid.DataSource = dt;

                clear();
                MessageBox.Show("Data Deleted Successfully !");
                con.Close();
            }

            //}
            //catch (Exception)
            else if (userlbl.Text != adminnewsbytxtbox.Text)
            {
                MessageBox.Show("You are not permitted to Delete other admins message");
                clear();
            }
            else
            {
                MessageBox.Show("Double Click the Datagrid and Load to Delete");
            }
        }

        private void admin_news_refresh_btn_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void admin_news_search_Click_1(object sender, EventArgs e)
        {
            if (adminnewssearchtxt.Text != "")
            {
                con.Open();
                string search_query = "select * from newss_tbl where n_title='" + adminnewssearchtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(search_query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    adminnewsidtextbox.Text = (dr["n_id"].ToString());
                    adminnewstitletextbox.Text = (dr["n_title"].ToString());
                    adminnewsdesctextbox.Text = (dr["n_description"].ToString());
                    adminnewsdatebtn.Value = Convert.ToDateTime(dr["n_date"]);
                    adminnewsforbtn.Text = (dr["n_for"].ToString());
                    adminnewsbytxtbox.Text = (dr["n_by"].ToString());
                }
                else
                {
                    adminnewssearchtxt.Text = "";
                    adminnewsidtextbox.Text = "";
                    adminnewstitletextbox.Text = "";
                    adminnewsdesctextbox.Text = "";

                    MessageBox.Show("No News Found !");
                    refresh();
                }
                con.Close();
                con.Open();
                string search_query_s = "select * from newss_tbl where n_title='" + adminnewssearchtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminnewsdatagrid.DataSource = dt;
                con.Close();
            }
            else if (adminnewssearchtxt.Text == "")
            {
                MessageBox.Show("Please Enter the valid  name to search");
            }
        }

        private void admin_news_search_image_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (adminnewssearchtxt.Text != "")
            {
                con.Open();
                string search_query = "select * from newss_tbl where n_id=" + int.Parse(adminnewssearchtxt.Text);
                SqlCommand cmd = new SqlCommand(search_query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    adminnewsidtextbox.Text = (dr["n_id"].ToString());
                    adminnewstitletextbox.Text = (dr["n_title"].ToString());
                    adminnewsdesctextbox.Text = (dr["n_description"].ToString());
                    adminnewsdatebtn.Value = Convert.ToDateTime(dr["n_date"]);
                    adminnewsforbtn.Text = (dr["n_for"].ToString());
                    adminnewsbytxtbox.Text = (dr["n_by"].ToString());
                }
                else
                {
                    adminnewssearchtxt.Text = "";
                    adminnewsidtextbox.Text = "";
                    adminnewstitletextbox.Text = "";
                    adminnewsdesctextbox.Text = "";

                    MessageBox.Show("No News Found !");
                    refresh();
                }
                con.Close();
                con.Open();
                string search_query_s = "select * from newss_tbl where n_id=" + int.Parse(adminnewssearchtxt.Text);
                SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminnewsdatagrid.DataSource = dt;
                con.Close();
            }
            else if (adminnewssearchtxt.Text == "")
            {
                MessageBox.Show("Please Enter the valid input to search");
            }

            // }
            //catch (Exception)
            {
                //  MessageBox.Show("Please Enter the valid input to search");
            }
        }

        private void admin_news_update_btn_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            if (adminnewsidtextbox.Text != "" && adminnewstitletextbox.Text != "" && adminnewsdesctextbox.Text != "" && adminnewsforbtn.Text != "" && adminnewsbytxtbox.Text == userlbl.Text)

            {
                con.Open();
                string update_query = "update  newss_tbl set n_id='" + adminnewsidtextbox.Text + "', n_title='" + adminnewstitletextbox.Text + "',n_description='" + adminnewsdesctextbox.Text + "',n_date='" + adminnewsdatebtn.Value + "',n_for='" + adminnewsforbtn.Text + "',n_by='" + adminnewsbytxtbox.Text + "' where n_id ='" + adminnewsidtextbox.Text + "' and n_by ='" + Program.username + "'";
                SqlDataAdapter usda = new SqlDataAdapter(update_query, con);
                usda.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                string view_query = "select * from newss_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminnewsdatagrid.DataSource = dt;
                clear();
                MessageBox.Show("Data Updated Successfully !");
                con.Close();
            }
            //}
            //catch (Exception)
            else if (userlbl.Text != adminnewsbytxtbox.Text)
            {
                MessageBox.Show("You are not permitted to update other admins message");
                clear();
            }
            else
            {
                MessageBox.Show("Double Click the DataGrid and Load to Update");
            }
        }

        private void admin_news_view_btn_Click_1(object sender, EventArgs e)
        {
            admin_news_view objadmin_news_view = new admin_news_view();
            objadmin_news_view.Show();
        }

        private void adminnewsdatagrid_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            adminnewsidtextbox.Text = adminnewsdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            adminnewstitletextbox.Text = adminnewsdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            adminnewsdesctextbox.Text = adminnewsdatagrid.SelectedRows[0].Cells[2].Value.ToString();
            // adminnewsdatebtn.Value = Convert.ToDateTime(adminnewsdatebtn);
            adminnewsdatebtn.Value = Convert.ToDateTime(adminnewsdatagrid.SelectedRows[0].Cells[3].Value);

            adminnewsforbtn.Text = adminnewsdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            adminnewsbytxtbox.Text = adminnewsdatagrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminnewsidtextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void adminnewssearchtxt_Enter(object sender, EventArgs e)
        {
            if (adminnewssearchtxt.Text == "Search By News Id .TItle")
            {
                adminnewssearchtxt.Text = "";
                adminnewssearchtxt.ForeColor = Color.Black;
            }
        }

        private void adminnewssearchtxt_Leave(object sender, EventArgs e)
        {
            if (adminnewssearchtxt.Text == "")
            {
                adminnewssearchtxt.Text = "Search By News Id .TItle";
                adminnewssearchtxt.ForeColor = Color.Silver;
            }
        }

        private void clear()
        {
            adminnewsidtextbox.Text = "";
            adminnewstitletextbox.Text = " ";
            adminnewsdesctextbox.Text = " ";

            adminnewsdatebtn.Value = DateTime.Now;
            adminnewsforbtn.Text = "";
            adminnewsbytxtbox.Text = userlbl.Text;
            adminnewssearchtxt.Text = "";
            adminnewssearchtxt.Text = "Search By News Id .TItle";
            adminnewssearchtxt.ForeColor = Color.Silver;
        }

        private void newsaddadmin_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ds = new SqlDataAdapter("select u_fname from users_tbl where u_fname='" + Program.username + "'", con);
            DataTable ldt = new DataTable();
            ds.Fill(ldt);
            userlbl.Text = ldt.Rows[0]["u_fname"].ToString();

            string view_query = "select * from newss_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminnewsdatagrid.DataSource = dt;

            con.Close();
        }

        private void refresh()
        {
            con.Open();
            string view_query = "select * from newss_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminnewsdatagrid.DataSource = dt;

            con.Close();
            clear();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void teacher_news_search_bydate_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select *  from newss_tbl where n_date='" + adminnewsdatebtn.Value + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminnewsdatagrid.DataSource = dt;
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                adminnewsidtextbox.Text = "";
                adminnewstitletextbox.Text = "";

                adminnewsdesctextbox.Text = "";
                adminnewsdatebtn.Value = DateTime.Now;
                adminnewsforbtn.Text = "";
                MessageBox.Show("No news for '" + adminnewsdatebtn.Value + "'");
                refresh();
            }
            con.Close();
        }

        private void teacher_news_search_byfor_Click_1(object sender, EventArgs e)
        {
            if (adminnewsforbtn.Text != "")
            {
                con.Open();
                string search_query = "select * from newss_tbl where n_for='" + adminnewsforbtn.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(search_query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminnewsdatagrid.DataSource = dt;
                con.Close();

                con.Open();
                SqlCommand cmd = new SqlCommand(search_query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //do nothing
                }
                else
                {
                    adminnewsidtextbox.Text = "";
                    adminnewstitletextbox.Text = "";

                    adminnewsdesctextbox.Text = "";
                    adminnewsdatebtn.Value = DateTime.Now;
                    MessageBox.Show("No news for '" + adminnewsforbtn.Text + "'");
                    refresh();
                }
                con.Close();
            }
            else if (adminnewsforbtn.Text == "")
            {
                MessageBox.Show("Please Enter valid News Information");
            }
        }

        private void user_combox_Load()   //to retrive the user fname from database
        {
            con.Open();
            string sql_query = "select u_id, u_fname from users_tbl where  u_email='" + Program.adminEmail + "'";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter da = new SqlDataAdapter(sql_query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            adminnewsbytxtbox.DataSource = ds.Tables[0];
            adminnewsbytxtbox.DisplayMember = "u_fname";
            adminnewsbytxtbox.ValueMember = "u_id";
            adminnewsbytxtbox.Enabled = true;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}