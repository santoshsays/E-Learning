using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class teacheradmin : UserControl
    {
        private static teacheradmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public teacheradmin()
        {
            InitializeComponent();
        }

        public static teacheradmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new teacheradmin();
                }

                return _instance;
            }
        }

        private void admin_subject_view_btn_Click(object sender, EventArgs e)
        {
            admin_teacher_view objadmin_teacher_veiw = new admin_teacher_view();
            objadmin_teacher_veiw.Show();
        }

        private void admin_teacher_refresh_btn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void admin_teacher_search_bydept_btn_Click(object sender, EventArgs e)
        {
            if (departmentbtn.Text != "")
            {
                con.Open();
                string search_query = "select t_ssn,t_fname,t_lname,t_email,t_password,t_retypepassword,t_dname,t_address,t_mobile from teachers_tbl where t_dname = '" + departmentbtn.Text + "'";

                SqlCommand scmd = new SqlCommand(search_query, con);
                SqlDataReader dr = scmd.ExecuteReader();
                if (dr.Read())
                {
                    //do nothing
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
                    MessageBox.Show("No Teachers found !");
                    refresh();
                }

                con.Close();
                con.Open();
                string search_query_s = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl where t_dname = '" + departmentbtn.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminteachersdatagrid.DataSource = dt;
                con.Close();
            }
            else if (departmentbtn.Text == "")
            {
                MessageBox.Show("Please Enter the valid Deparmtment to be Searched");
            }
        }

        private void admin_teachers_add_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
                && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text != "" && retypepasswordtxt.Text != "" && passwordtxt.Text == retypepasswordtxt.Text)
            {
                con.Open();
                string insert_query = "insert into teachers_tbl(t_ssn,t_fname,t_lname,t_email,t_password,t_retypepassword,t_dname,t_address,t_mobile) values('" + usntxt.Text + "','" + fnametxt.Text + "','" + lnametxt.Text + "','" + emailtxt.Text + "','" + passwordtxt.Text + "','" + retypepasswordtxt.Text + "','" + departmentbtn.Text + "','" + addresstxt.Text + "','" + mobiletxt.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(insert_query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                string view_query = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl ";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminteachersdatagrid.DataSource = dt;
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
                MessageBox.Show("Please Enter the Teachers Informations to be Inserted!");
            }
        }

        private void admin_teachers_clear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void admin_teachers_delete_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
              && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                con.Open();
                string delete_query = "delete from teachers_tbl where t_ssn ='" + usntxt.Text + "'";
                SqlDataAdapter d_sda = new SqlDataAdapter(delete_query, con);
                d_sda.SelectCommand.ExecuteNonQuery();

                string view_query = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminteachersdatagrid.DataSource = dt;

                clear();
                con.Close();
            }
            else if (usntxt.Text == "" && fnametxt.Text == "" && lnametxt.Text == "" && emailtxt.Text == "" && departmentbtn.Text == ""
              && addresstxt.Text == "" && mobiletxt.Text == "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")
            {
                MessageBox.Show("Double click to add the informations to Delete");
            }
        }

        private void admin_teachers_search_Click(object sender, EventArgs e)
        {
            if (adminteachersearchtxt.Text != "")
            {
                con.Open();
                string search_query = "select t_ssn,t_fname,t_lname,t_email,t_password,t_retypepassword,t_dname,t_address,t_mobile from teachers_tbl where t_fname= '" + adminteachersearchtxt.Text + "'";
                string search_query_s = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl where t_fname= '" + adminteachersearchtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminteachersdatagrid.DataSource = dt;
                con.Close();

                con.Open();
                SqlCommand scmd = new SqlCommand(search_query, con);
                SqlDataReader dr = scmd.ExecuteReader();
                if (dr.Read())
                {
                    usntxt.Text = (dr["t_ssn"].ToString());
                    fnametxt.Text = (dr["t_fname"].ToString());
                    lnametxt.Text = (dr["t_lname"].ToString());
                    emailtxt.Text = (dr["t_email"].ToString());
                    passwordtxt.Text = (dr["t_password"].ToString());
                    retypepasswordtxt.Text = (dr["t_retypepassword"].ToString());
                    departmentbtn.Text = (dr["t_dname"].ToString());
                    addresstxt.Text = (dr["t_address"].ToString());
                    mobiletxt.Text = (dr["t_mobile"].ToString());
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
                    MessageBox.Show("No Teachers found !");
                    refresh();
                }
                con.Close();
            }
            else if (adminteachersearchtxt.Text == "")
            {
                MessageBox.Show("Please Enter the Teachers Name to be searched");
            }
        }

        private void admin_teachers_search_images_Click(object sender, EventArgs e)
        {
            if (adminteachersearchtxt.Text != "")
            {
                con.Open();
                string search_query = "select t_ssn,t_fname,t_lname,t_email,t_password,t_retypepassword,t_dname,t_address,t_mobile from teachers_tbl where t_ssn= '" + adminteachersearchtxt.Text + "'";

                SqlCommand scmd = new SqlCommand(search_query, con);
                SqlDataReader dr = scmd.ExecuteReader();
                if (dr.Read())
                {
                    usntxt.Text = (dr["t_ssn"].ToString());
                    fnametxt.Text = (dr["t_fname"].ToString());
                    lnametxt.Text = (dr["t_lname"].ToString());
                    emailtxt.Text = (dr["t_email"].ToString());
                    passwordtxt.Text = (dr["t_password"].ToString());
                    retypepasswordtxt.Text = (dr["t_retypepassword"].ToString());
                    departmentbtn.Text = (dr["t_dname"].ToString());
                    addresstxt.Text = (dr["t_address"].ToString());
                    mobiletxt.Text = (dr["t_mobile"].ToString());
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
                    MessageBox.Show("No Teachers Found !");
                    refresh();
                }
                con.Close();
                con.Open();
                string search_query_s = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl where t_ssn= '" + adminteachersearchtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                adminteachersdatagrid.DataSource = dt;
                con.Close();
            }
            else if (adminteachersearchtxt.Text == "")
            {
                MessageBox.Show("Please Enter the Teachers SSN to be searched");
            }
        }

        private void admin_teachers_update_btn_Click(object sender, EventArgs e)
        {
            if (usntxt.Text != "" && fnametxt.Text != "" && lnametxt.Text != "" && emailtxt.Text != "" && departmentbtn.Text != ""
              && addresstxt.Text != "" && mobiletxt.Text != "" && passwordtxt.Text == "" && retypepasswordtxt.Text == "")

            {
                con.Open();
                string update_query = "update  teachers_tbl set t_fname='" + fnametxt.Text + "',t_lname='" + lnametxt.Text + "',t_email='" + emailtxt.Text + "',t_dname ='" + departmentbtn.Text + "',t_address='" + addresstxt.Text + "',t_mobile='" + mobiletxt.Text + "' where t_ssn ='" + usntxt.Text + "'";
                SqlDataAdapter usda = new SqlDataAdapter(update_query, con);
                usda.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                string view_query = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
                DataTable dt = new DataTable();
                sda1.Fill(dt);
                adminteachersdatagrid.DataSource = dt;
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
                MessageBox.Show("Double Click on Teachers Datagrid Informations to be Updated !");
            }
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminteachersdatagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            usntxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            fnametxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            lnametxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[2].Value.ToString();
            emailtxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            // passwordtxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            // retypepasswordtxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[6].Value.ToString();
            departmentbtn.Text = adminteachersdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            addresstxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            mobiletxt.Text = adminteachersdatagrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void adminteachersearchtxt_Enter(object sender, EventArgs e)
        {
            if (adminteachersearchtxt.Text == "Search By SSN . Name")
            {
                adminteachersearchtxt.Text = ""
; adminteachersearchtxt.ForeColor = Color.Black;
            }
        }

        private void adminteachersearchtxt_Leave(object sender, EventArgs e)
        {
            if (adminteachersearchtxt.Text == "")
            {
                adminteachersearchtxt.Text = "Search By SSN . Name";
                adminteachersearchtxt.ForeColor = Color.Silver;
            }
        }

        private void adminteachersearchtxt_TextChanged(object sender, EventArgs e)
        {
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
            adminteachersearchtxt.Text = "";
            adminteachersearchtxt.Text = "Search By SSN . Name";
            adminteachersearchtxt.ForeColor = Color.Silver;
        }

        private void departmentbtn_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void password_hide_visible_MouseHover(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '\0';
        }

        private void password_hide_visible_MouseLeave(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = '*';
        }

        private void refresh()
        {
            con.Open();
            string view_query = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminteachersdatagrid.DataSource = dt;
            clear();
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void teacheradmin_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from teachers_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            adminteachersdatagrid.DataSource = dt;
            con.Close();
        }
    }
}