using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class adminfeedback : UserControl
    {
        private static adminfeedback _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public adminfeedback()
        {
            InitializeComponent();
        }

        public static adminfeedback Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new adminfeedback();
                }

                return _instance;
            }
        }

        private void admin_feedback_clear_btn_Click(object sender, EventArgs e)
        {
            femailtxt.Text = "";
            ftitletxt.Text = "";
            fdesctxt.Text = "";
            fbytbtn.Text = "";
            fratingbtn.Text = "";
        }

        private void admin_feedback_datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            femailtxt.Text = admin_feedback_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            ftitletxt.Text = admin_feedback_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            fdesctxt.Text = admin_feedback_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            fbytbtn.Text = admin_feedback_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            fratingbtn.Text = admin_feedback_datagrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void admin_feedback_refresh_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            admin_feedback_datagrid.DataSource = dt;
            con.Close();
            clear();
        }

        private void adminfeedback_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            admin_feedback_datagrid.DataSource = dt;
            con.Close();
        }

        private void clear()
        {
            femailtxt.Text = "";
            ftitletxt.Text = "";
            fdesctxt.Text = "";
            fbytbtn.Text = "";
            fratingbtn.Text = "";
        }

        private void fby_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl where f_by='" + fbytbtn.Text + "'";

            SqlCommand scmd = new SqlCommand(search_query, con);
            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {
            }
            else
            {
                femailtxt.Text = "";
                ftitletxt.Text = "";
                fdesctxt.Text = "";
                fbytbtn.Text = "";
                fratingbtn.Text = "";
                MessageBox.Show("No feedback found by '" + fbytbtn.Text + "'  !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl where f_by='" + fbytbtn.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_feedback_datagrid.DataSource = dt;
            con.Close();
        }

        private void frating_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl where f_rating='" + fratingbtn.Text + "'";

            SqlCommand scmd = new SqlCommand(search_query, con);
            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {
            }
            else
            {
                femailtxt.Text = "";
                ftitletxt.Text = "";
                fdesctxt.Text = "";
                fbytbtn.Text = "";
                fratingbtn.Text = "";
                MessageBox.Show("No feedback found for '" + fratingbtn.Text + "'  !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select f_id,f_email,f_title,f_desc,f_by,f_rating from feedback_tbl where f_rating='" + fratingbtn.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_feedback_datagrid.DataSource = dt;
            con.Close();
        }
    }
}