using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class adminmessage : UserControl
    {
        private static adminmessage _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public adminmessage()
        {
            InitializeComponent();
        }

        public static adminmessage Instance
        {     //creating instance of user control
            get
            {
                if (_instance == null)
                {
                    _instance = new adminmessage();
                }

                return _instance;
            }
        }

        private void adminmessage_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select * from message_tbl where m_for='Admin'";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            message_admin_datagrid.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select * from message_tbl where m_date ='" + smsgdatebtn.Value + "' and m_f0r='Admin'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                smsgtextbox.Text = "";
                smsgdesctxtbox.Text = "";
                smsgdatebtn.Value = DateTime.Now;
                smsgforbtn.Text = "";
                //sdepartmentbtn.Text = "";

                MessageBox.Show("No message found for '" + smsgdatebtn.Value + "'");
            }
            con.Close();

            con.Open();
            string search_query_s = "select * from message_tbl where m_date ='" + smsgdatebtn.Value + "' and m_for='Admin'";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            message_admin_datagrid.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select * from message_tbl where m_by ='" + smsgbtn.Text + "' and m_for='Admin'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                smsgtextbox.Text = "";
                smsgdesctxtbox.Text = "";
                smsgdatebtn.Value = DateTime.Now;
                smsgforbtn.Text = "";
                // sdepartmentbtn.Text = "";

                MessageBox.Show("No message found for '" + smsgbtn.Text + "'");
            }
            con.Close();

            con.Open();
            string search_query_s = "select * from message_tbl where m_by='" + smsgbtn.Text + "'and m_for='Admin'";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            message_admin_datagrid.DataSource = dt;
            con.Close();
        }

        private void clear()
        {
            smsgtextbox.Text = "";
            smsgdesctxtbox.Text = "";
            smsgdatebtn.Value = DateTime.Now;
            smsgforbtn.Text = "";
            //sdepartmentbtn.Text = "";
            smsgbtn.Text = "";
        }

        private void message_student_datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            smsgtextbox.Text = message_admin_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            smsgdesctxtbox.Text = message_admin_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            smsgdatebtn.Value = Convert.ToDateTime(message_admin_datagrid.SelectedRows[0].Cells[3].Value);
            smsgforbtn.Text = message_admin_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            // sdepartmentbtn.Text = message_admin_datagrid.SelectedRows[0].Cells[5].Value.ToString();
            smsgbtn.Text = message_admin_datagrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void sclearmessage_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void srefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select * from message_tbl where m_for='Admin'";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            message_admin_datagrid.DataSource = dt;
            con.Close();
            clear();
        }
    }
}