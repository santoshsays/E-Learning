using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class studentadmin : UserControl

    {
        private static studentadmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public studentadmin()
        {
            InitializeComponent();
        }

        public static studentadmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new studentadmin();
                }

                return _instance;
            }
        }

        private void admin_student_add_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
                && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != "" && passwordtxt.Text == retypepasswordtxt.Text)
            {
                con.Open();
                string insert_query = "insert into student_tbl(s_usn,s_fname,s_lname,s_email,s_password,s_retypepassword,s_dname,s_address,s_mobile) values('" + usntxt.Text + "','" + fnametxt.Text + "','" + lnametxt.Text + "','" + emailtxt.Text + "','" + passwordtxt.Text + "','" + retypepasswordtxt.Text + "','" + departmentbtn.Text + "','" + addresstxt.Text + "','" + mobiletxt.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(insert_query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                string view_query = "select s_usn, s_fname, s_lname, s_email, s_password, s_retypepassword, s_dname, s_address, s_mobile from student_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminstudentdatagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != "" && addresstxt.Text != ""
                 && mobiletxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != "" && passwordtxt.Text != retypepasswordtxt.Text)
            {
                MessageBox.Show("Both Password should match !");
            }
            else if (usntxt.Text == "" && fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && departmentbtn.Text == "" && addresstxt.Text == ""
                 && mobiletxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                MessageBox.Show("Please Enter the Student Informations to be Inserted!");
            }
        }

        private void admin_student_clear_btn_Click(object sender, EventArgs e)
        {
            adminstudentsearchtxt.Text = "";
            usntxt.Text = "";
            fnametxt.Text = "";
            lnametxt.Text = "";
            emailtxt.Text = "";
            passwordtxt.Text = "";
            retypepasswordtxt.Text = "";
            departmentbtn.Text = "";
            addresstxt.Text = "";
            mobiletxt.Text = "";
        }

        private void admin_student_delete_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
               && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                con.Open();
                string delete_query = "delete from student_tbl where s_usn ='" + usntxt.Text + "'";
                SqlDataAdapter d_sda = new SqlDataAdapter(delete_query, con);
                d_sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select s_usn,s_fname,s_lname,s_email,s_dname,s_address,s_mobile from student_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminstudentdatagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (usntxt.Text == "" && fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && departmentbtn.Text == ""
             && addresstxt.Text == "" && mobiletxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                MessageBox.Show("Double click to add the informations to Delete");
            }
        }

        private void admin_student_refresh_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select s_usn,s_fname,s_lname,s_email,s_dname,s_address,s_mobile from student_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            clear();
            con.Close();
        }

        private void admin_student_search_bydept_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select s_usn,s_fname,s_lname,s_email,s_password,s_retypepassword,s_dname,s_address,s_mobile from student_tbl where s_dname = '" + departmentbtn.Text + "'";

            SqlCommand scmd = new SqlCommand(search_query, con);
            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {
            }
            else
            {
                usntxt.Text = "";
                fnametxt.Text = "";
                lnametxt.Text = "";
                emailtxt.Text = "";
                passwordtxt.Text = "";
                retypepasswordtxt.Text = "";
                departmentbtn.Text = "";
                addresstxt.Text = "";
                mobiletxt.Text = "";
                MessageBox.Show("No Student found in Department '" + departmentbtn.Text + "'  !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select s_usn,s_fname,s_lname,s_email,s_dname,s_address,s_mobile from student_tbl where s_dname = '" + departmentbtn.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            con.Close();
        }

        private void admin_student_search_Click(object sender, EventArgs e)
        {
            con.Open();

            string search_query = "select s_usn, s_fname, s_lname, s_email, s_password, s_retypepassword, s_dname, s_address, s_mobile from student_tbl where s_fname= '" + adminstudentsearchtxt.Text + "'";
            SqlCommand scmd = new SqlCommand(search_query, con);
            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {
                usntxt.Text = (dr["s_usn"].ToString());
                fnametxt.Text = (dr["s_fname"].ToString());
                lnametxt.Text = (dr["s_lname"].ToString());
                emailtxt.Text = (dr["s_email"].ToString());
                passwordtxt.Text = (dr["s_password"].ToString());
                retypepasswordtxt.Text = (dr["s_retypepassword"].ToString());
                departmentbtn.Text = (dr["s_dname"].ToString());
                addresstxt.Text = (dr["s_address"].ToString());
                mobiletxt.Text = (dr["s_mobile"].ToString());
            }
            else
            {
                usntxt.Text = "";
                fnametxt.Text = "";
                lnametxt.Text = "";
                emailtxt.Text = "";
                passwordtxt.Text = "";
                retypepasswordtxt.Text = "";
                departmentbtn.Text = "";
                addresstxt.Text = "";
                mobiletxt.Text = "";
                MessageBox.Show("No Student match with Name '" + adminstudentsearchtxt.Text + "' !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select s_usn, s_fname, s_lname, s_email, s_password, s_retypepassword, s_dname, s_address, s_mobile from student_tbl where s_fname= '" + adminstudentsearchtxt.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            con.Close();
        }

        private void admin_student_search_image_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query = "select s_usn,s_fname,s_lname,s_email,s_password,s_retypepassword,s_dname,s_address,s_mobile from student_tbl where s_usn= '" + adminstudentsearchtxt.Text + "'";
            SqlCommand scmd = new SqlCommand(search_query, con);
            SqlDataReader dr = scmd.ExecuteReader();
            if (dr.Read())
            {
                usntxt.Text = (dr["s_usn"].ToString());
                fnametxt.Text = (dr["s_fname"].ToString());
                lnametxt.Text = (dr["s_lname"].ToString());
                emailtxt.Text = (dr["s_email"].ToString());
                passwordtxt.Text = (dr["s_password"].ToString());
                retypepasswordtxt.Text = (dr["s_retypepassword"].ToString());
                departmentbtn.Text = (dr["s_dname"].ToString());
                addresstxt.Text = (dr["s_address"].ToString());
                mobiletxt.Text = (dr["s_mobile"].ToString());
            }
            else
            {
                usntxt.Text = "";
                fnametxt.Text = "";
                lnametxt.Text = "";
                emailtxt.Text = "";
                passwordtxt.Text = "";
                retypepasswordtxt.Text = "";
                departmentbtn.Text = "";
                addresstxt.Text = "";
                mobiletxt.Text = "";
                MessageBox.Show("No Students match with  USN '" + adminstudentsearchtxt.Text + "'  !");
            }
            con.Close();

            con.Open();
            string search_query_s = "select s_usn, s_fname, s_lname, s_email, s_password, s_retypepassword, s_dname, s_address, s_mobile from student_tbl where s_usn= '" + adminstudentsearchtxt.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            con.Close();
        }

        private void admin_student_update_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
              && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")

            {
                con.Open();
                string update_query = "update  student_tbl set s_fname='" + fnametxt.Text + "',s_lname='" + lnametxt.Text + "',s_email='" + emailtxt.Text + "',s_password='" + passwordtxt.Text + "',s_retypepassword='" + retypepasswordtxt.Text + "',s_dname ='" + departmentbtn.Text + "',s_address='" + addresstxt.Text + "',s_mobile='" + mobiletxt.Text + "' where s_usn ='" + usntxt.Text + "'";
                SqlDataAdapter usda = new SqlDataAdapter(update_query, con);
                usda.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                string view_query = "select s_usn, s_fname, s_lname, s_email, s_dname, s_address, s_mobile  from student_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminstudentdatagrid.DataSource = dt;
                clear();
                con.Close();
            }
            else if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
             && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != "")
            {
                MessageBox.Show("You are not allowed to  update password");
                passwordtxt.Text = "";
                retypepasswordtxt.Text = "";
            }
            else if (usntxt.Text == "" && fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && departmentbtn.Text == "" && addresstxt.Text == ""
                 && mobiletxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                MessageBox.Show("Double Click on Student Datagrid Informations to be Updated !");
            }
        }

        private void admin_student_view_btn_Click(object sender, EventArgs e)
        {
            admin_student_view objadmin_student_view = new admin_student_view();
            objadmin_student_view.Show();
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminstudentdatagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            usntxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            fnametxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            lnametxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[2].Value.ToString();
            emailtxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            // passwordtxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            // retypepasswordtxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[6].Value.ToString();
            departmentbtn.Text = adminstudentdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            addresstxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            mobiletxt.Text = adminstudentdatagrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void adminstudentsearchtxt_Enter(object sender, EventArgs e)
        {
            if (adminstudentsearchtxt.Text == "Search By USN .Name")
            {
                adminstudentsearchtxt.Text = "";
                adminstudentsearchtxt.ForeColor = Color.Black;
            }
        }

        private void adminstudentsearchtxt_Leave(object sender, EventArgs e)
        {
            if (adminstudentsearchtxt.Text == "")
            {
                adminstudentsearchtxt.Text = "Search By USN .Name";
                adminstudentsearchtxt.ForeColor = Color.Black;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            retypepasswordtxt.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            retypepasswordtxt.PasswordChar = '*';
        }

        private void clear()
        {
            usntxt.Text = "";
            fnametxt.Text = "";
            lnametxt.Text = "";
            emailtxt.Text = "";
            passwordtxt.Text = "";
            retypepasswordtxt.Text = "";
            departmentbtn.Text = "";
            addresstxt.Text = "";
            mobiletxt.Text = "";
        }

        private void password_hide_visible_MouseHover(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '\0';
        }

        private void password_hide_visible_MouseLeave(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '*';
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select s_usn,s_fname,s_lname,s_email,s_dname,s_address,s_mobile from student_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            clear();
            con.Close();
        }

        private void studentadmin_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select s_usn, s_fname, s_lname, s_email,s_dname, s_address, s_mobile from student_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminstudentdatagrid.DataSource = dt;
            con.Close();
        }
    }
}