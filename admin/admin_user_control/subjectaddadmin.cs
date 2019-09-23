using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class subjectaddadmin : UserControl
    {
        private static subjectaddadmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");
        private DataTable dt;

        public subjectaddadmin()
        {
            InitializeComponent();
            combobox_load();
        }

        public static subjectaddadmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new subjectaddadmin();
                }

                return _instance;
            }
        }

        private void admin_subject_add_btn_Click(object sender, EventArgs e)
        {
            if (adminsubjectidtxtbox.Text != "" && adminsubjecttitletxtbox.Text != "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text != "" && adminsubjectsemester.Text != "")
            {
                con.Open();
                string insert_query = "insert into subject_tbl(subject_id,subject_title,subject_teacher,subject_department,subject_semester) values('" + adminsubjectidtxtbox.Text + "','" + adminsubjecttitletxtbox.Text + "','" + adminsubteacherbtn.Text + "','" + adminsubjectdeptbtn.Text + "','" + adminsubjectsemester.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(insert_query, con);
                sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                admin_subject_datagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (adminsubjectidtxtbox.Text == "" && adminsubjecttitletxtbox.Text == "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text == "" && adminsubjectsemester.Text == "")
            {
                MessageBox.Show("Please Enter the Subject Information to be inserted !");
            }
        }

        private void admin_subject_clear_btn_Click(object sender, EventArgs e)
        {
            adminsubjectsearchtxt.Text = "";
            adminsubjectidtxtbox.Text = "";
            adminsubjecttitletxtbox.Text = "";
            adminsubteacherbtn.Text = "";
            adminsubjectdeptbtn.Text = "";
            adminsubjectsemester.Text = "";
        }

        private void admin_subject_datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            adminsubjectidtxtbox.Text = admin_subject_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            adminsubjecttitletxtbox.Text = admin_subject_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            adminsubteacherbtn.Text = admin_subject_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            adminsubjectdeptbtn.Text = admin_subject_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            adminsubjectsemester.Text = admin_subject_datagrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void admin_subject_delete_btn_Click(object sender, EventArgs e)
        {
            if (adminsubjectidtxtbox.Text != "" && adminsubjecttitletxtbox.Text != "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text != "" && adminsubjectsemester.Text != "")
            {
                con.Open();
                string delete_query = "delete from subject_tbl where subject_id ='" + adminsubjectidtxtbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(delete_query, con);
                sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                admin_subject_datagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (adminsubjectidtxtbox.Text == "" && adminsubjecttitletxtbox.Text == "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text == "" && adminsubjectsemester.Text == "")
            {
                MessageBox.Show("Double Click on the Data to load and Delete !");
            }
        }

        private void admin_subject_list_view_Click(object sender, EventArgs e)
        {
            admin_subject_view obj_admin_subject_list_view = new admin_subject_view();
            obj_admin_subject_list_view.Show();
        }

        private void admin_subject_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
            clear();
        }

        private void admin_subject_search_bydept_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_department='" + adminsubjectdeptbtn.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //adminsubjectidtxtbox.Text = (dr["subject_id"].ToString());
                //adminsubjecttitletxtbox.Text = (dr["subject_title"].ToString());
                //adminsubteacherbtn.Text = (dr["subject_teacher"].ToString());
                //adminsubjectdeptbtn.Text = (dr["subject_department"].ToString());
                //adminsubjectsemester.Text = (dr["subject_semester"].ToString());
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                //adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject for '" + adminsubjectdeptbtn.Text + "'");
            }
            con.Close();
        }

        private void admin_subject_search_bydept_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_department='" + adminsubjectdeptbtn.Text + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                //adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject for '" + adminsubjectdeptbtn.Text + "'");
            }
            con.Close();

            con.Open();
            string search_query_s = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_department='" + adminsubjectdeptbtn.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_search_bysemseter_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_semester='" + adminsubjectsemester.Text + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                // adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject for  '" + adminsubjectsemester.Text + "' Students");
            }
            con.Close();
            con.Open();
            string search_query_s = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_semester='" + adminsubjectsemester.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_search_byteacher_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester  from subject_tbl where subject_teacher='" + adminsubteacherbtn.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //adminsubjectidtxtbox.Text = (dr["subject_id"].ToString());
                //adminsubjecttitletxtbox.Text = (dr["subject_title"].ToString());
                //adminsubteacherbtn.Text = (dr["subject_teacher"].ToString());
                //adminsubjectdeptbtn.Text = (dr["subject_department"].ToString());
                //adminsubjectsemester.Text = (dr["subject_semester"].ToString());
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                // adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject for '" + adminsubteacherbtn.Text + "'");
            }
            con.Close();
        }

        private void admin_subject_search_byteacher_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester  from subject_tbl where subject_teacher='" + adminsubteacherbtn.Text + "'";

            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //do nothing
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                // adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject for '" + adminsubteacherbtn.Text + "'");
            }
            con.Close();
            con.Open();
            string search_query_s = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester  from subject_tbl where subject_teacher='" + adminsubteacherbtn.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_title ='" + adminsubjectsearchtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminsubjectidtxtbox.Text = (dr["subject_id"].ToString());
                adminsubjecttitletxtbox.Text = (dr["subject_title"].ToString());
                adminsubteacherbtn.Text = (dr["subject_teacher"].ToString());
                adminsubjectdeptbtn.Text = (dr["subject_department"].ToString());
                adminsubjectsemester.Text = (dr["subject_semester"].ToString());
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject Found !");
            }
            con.Close();
            con.Open();
            string search_query_s = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_title ='" + adminsubjectsearchtxt.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_search_image_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_id=" + int.Parse(adminsubjectsearchtxt.Text);
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                adminsubjectidtxtbox.Text = (dr["subject_id"].ToString());
                adminsubjecttitletxtbox.Text = (dr["subject_title"].ToString());
                adminsubteacherbtn.Text = (dr["subject_teacher"].ToString());
                adminsubjectdeptbtn.Text = (dr["subject_department"].ToString());
                adminsubjectsemester.Text = (dr["subject_semester"].ToString());
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject Found !");
            }
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_search_image_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_id=" + int.Parse(adminsubjectsearchtxt.Text);
            SqlCommand cmd = new SqlCommand(search_query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                adminsubjectidtxtbox.Text = (dr["subject_id"].ToString());
                adminsubjecttitletxtbox.Text = (dr["subject_title"].ToString());
                adminsubteacherbtn.Text = (dr["subject_teacher"].ToString());
                adminsubjectdeptbtn.Text = (dr["subject_department"].ToString());
                adminsubjectsemester.Text = (dr["subject_semester"].ToString());
            }
            else
            {
                adminsubjectidtxtbox.Text = "";
                adminsubjecttitletxtbox.Text = "";
                adminsubteacherbtn.Text = "";
                adminsubjectdeptbtn.Text = "";
                adminsubjectsemester.Text = "";
                MessageBox.Show("No Subject Found !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl where subject_id=" + int.Parse(adminsubjectsearchtxt.Text);

            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_update_btn_Click(object sender, EventArgs e)
        {
            if (adminsubjectidtxtbox.Text != "" && adminsubjecttitletxtbox.Text != "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text != "" && adminsubjectsemester.Text != "")
            {
                con.Open();
                string update_query = "update subject_tbl set subject_id='" + adminsubjectidtxtbox.Text + "',subject_title='" + adminsubjecttitletxtbox.Text + "',subject_teacher='" + adminsubteacherbtn.Text + "',subject_department='" + adminsubjectdeptbtn.Text + "',subject_semester='" + adminsubjectsemester.Text + "'where subject_id='" + adminsubjectidtxtbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(update_query, con);
                sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                admin_subject_datagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (adminsubjectidtxtbox.Text == "" && adminsubjecttitletxtbox.Text == "" && adminsubteacherbtn.Text != ""
                && adminsubjectdeptbtn.Text == "" && adminsubjectsemester.Text == "")
            {
                MessageBox.Show("Double click the Data to load and Update !");
            }
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminsubjectdeptbtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            if (adminsubjectdeptbtn.Text == "Civil Engineering")
            {
                string civil = "select t_ssn,t_fname from teachers_tbl where t_dname='Civil Engineering'";
                SqlCommand ccivil = new SqlCommand(civil, con);
                SqlDataAdapter scivil = new SqlDataAdapter(civil, con);
                DataSet ds = new DataSet();
                scivil.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                ccivil.ExecuteNonQuery();
            }
            if (adminsubjectdeptbtn.Text == "Computer Science")
            {
                string comp = "select t_ssn,t_fname from teachers_tbl where t_dname='Computer Science'";
                SqlCommand ccomp = new SqlCommand(comp, con);
                SqlDataAdapter scivil = new SqlDataAdapter(comp, con);
                DataSet ds = new DataSet();
                scivil.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                ccomp.ExecuteNonQuery();
            }
            if (adminsubjectdeptbtn.Text == "Computer Science")
            {
                string comp = "select t_ssn,t_fname from teachers_tbl where t_dname='Computer Science'";
                SqlCommand ccomp = new SqlCommand(comp, con);
                SqlDataAdapter scomp = new SqlDataAdapter(comp, con);
                DataSet ds = new DataSet();
                scomp.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                ccomp.ExecuteNonQuery();
            }
            if (adminsubjectdeptbtn.Text == "Information Science")
            {
                string info = "select t_ssn,t_fname from teachers_tbl where t_dname='Information Science'";
                SqlCommand cinfo = new SqlCommand(info, con);
                SqlDataAdapter sinfo = new SqlDataAdapter(info, con);
                DataSet ds = new DataSet();
                sinfo.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                cinfo.ExecuteNonQuery();
            }
            if (adminsubjectdeptbtn.Text == "Electronics  Eng")
            {
                string ele = "select t_ssn,t_fname from teachers_tbl where t_dname='Electronics  Eng'";
                SqlCommand cele = new SqlCommand(ele, con);
                SqlDataAdapter sele = new SqlDataAdapter(ele, con);
                DataSet ds = new DataSet();
                sele.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                cele.ExecuteNonQuery();
            }
            if (adminsubjectdeptbtn.Text == "Mechanical Eng")
            {
                string mech = "select t_ssn,t_fname from teachers_tbl where t_dname='Mechanical Eng'";
                SqlCommand cmech = new SqlCommand(mech, con);
                SqlDataAdapter smech = new SqlDataAdapter(mech, con);
                DataSet ds = new DataSet();
                smech.Fill(ds);
                adminsubteacherbtn.DataSource = ds.Tables[0];
                adminsubteacherbtn.DisplayMember = "t_fname";
                adminsubteacherbtn.ValueMember = "t_ssn";
                adminsubteacherbtn.Enabled = true;
                cmech.ExecuteNonQuery();
            }
            con.Close();
        }

        private void adminsubjectsearchtxt_Enter(object sender, EventArgs e)
        {
            if (adminsubjectsearchtxt.Text == "Search By Id. Title")
            {
                adminsubjectsearchtxt.Text = "";
                adminsubjectsearchtxt.ForeColor = Color.Black;
            }
        }

        private void adminsubjectsearchtxt_Leave(object sender, EventArgs e)
        {
            if (adminsubjectsearchtxt.Text == "")
            {
                adminsubjectsearchtxt.Text = "Search By Id. Title";
                adminsubjectsearchtxt.ForeColor = Color.Silver;
            }
        }

        private void clear()
        {
            adminsubjectidtxtbox.Text = "";
            adminsubjecttitletxtbox.Text = "";
            adminsubteacherbtn.Text = "";
            adminsubjectdeptbtn.Text = "";
            adminsubjectsemester.Text = "";
        }

        private void combobox_load()
        {
            con.Open();
            string sql_query = "Select t_ssn,t_fname from teachers_tbl";
            SqlCommand cmd = new SqlCommand(sql_query, con);
            SqlDataAdapter da = new SqlDataAdapter(sql_query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            adminsubteacherbtn.DataSource = ds.Tables[0];
            adminsubteacherbtn.DisplayMember = "t_fname";
            adminsubteacherbtn.ValueMember = "t_ssn";
            adminsubteacherbtn.Enabled = true;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
            clear();
        }

        private void subjectaddadmin_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select subject_id,subject_title,subject_teacher,subject_department,subject_semester from subject_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            dt = new DataTable();
            sda1.Fill(dt);
            admin_subject_datagrid.DataSource = dt;
            con.Close();
        }
    }
}