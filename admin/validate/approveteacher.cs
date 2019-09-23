using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class approveteacher : UserControl
    {
        private static approveteacher _instance;

        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public approveteacher()
        {
            InitializeComponent();
        }

        public static approveteacher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new approveteacher();
                }
                return _instance;
            }
        }

        public void load()
        {
            con.Open();
            SqlCommand sda = new SqlCommand("select t_ssn,t_fname,t_lname,t_email,t_dname,t_address,t_mobile from dummyteachers_tbl", con);
            sda.ExecuteNonQuery();
            SqlDataAdapter sdaa = new SqlDataAdapter(sda);
            DataTable dt = new DataTable();
            sdaa.Fill(dt);
            approveteachersdatgrid.DataSource = dt;
            con.Close();
        }

        private void admin_student_clear_btn_Click(object sender, EventArgs e)
        {
            load();
        }

        private void approve_Click(object sender, EventArgs e)
        {
            con.Open();
            string fetch = "select * from dummyteachers_tbl where t_ssn='" + Program.dummyteacherusn + "' ";
            SqlCommand sfetch = new SqlCommand(fetch, con);
            SqlDataReader fr = sfetch.ExecuteReader();
            fr.Read();
            Program.dummyteacherusn = fr["t_ssn"].ToString();
            Program.dummyteacherfname = fr["t_fname"].ToString();
            Program.dummyteacherlname = fr["t_lname"].ToString();
            Program.dummyteacheremail = fr["t_email"].ToString();
            Program.dummyteacherpassword = fr["t_password"].ToString();
            Program.dummyteacherrepassword = fr["t_retypepassword"].ToString();
            Program.dummyteacherdname = fr["t_dname"].ToString();
            Program.dummyteacheraddress = fr["t_address"].ToString();
            Program.dummyteachermobile = fr["t_mobile"].ToString();

            con.Close();

            con.Open();
            string inst = "insert into teachers_tbl(t_ssn,t_fname,t_lname,t_email,t_password,t_retypepassword,t_dname,t_address,t_mobile) values('" + Program.dummyteacherusn + "','" + Program.dummyteacherfname + "','" + Program.dummyteacherlname + "','" + Program.dummyteacheremail + "','" + Program.dummyteacherpassword + "','" + Program.dummyteacherrepassword + "','" + Program.dummyteacherdname + "','" + Program.dummyteacheraddress + "','" + Program.dummyteachermobile + "')";
            SqlCommand sinst = new SqlCommand(inst, con);
            sinst.ExecuteNonQuery();
            con.Close();

            con.Open();
            string delt = "delete  from dummyteachers_tbl where t_ssn='" + Program.dummyteacherusn + "'";
            SqlCommand sdelt = new SqlCommand(delt, con);
            sdelt.ExecuteNonQuery();
            con.Close();
            load();
            //  MessageBox.Show("Student Login Permitted for" + Program.dummystdfname);
            //send message to reigstered users
            con.Open();
            SqlCommand sda = new SqlCommand("select * from teachers_tbl where t_ssn='" + Program.dummyteacherusn + "'", con);
            SqlDataAdapter mda = new SqlDataAdapter(sda);
            DataTable dt0 = new DataTable();
            mda.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                string result;
                string apiKey = "raLZZ05OIyA-xUFIOZJvelTl5vDRVEFMKa2BNc3OsL";   //api key
                string numbers = dt0.Rows[0]["t_mobile"].ToString(); // in a comma seperated list
                string message = "Hi " + dt0.Rows[0]["t_fname"].ToString() + " Your Email is: " + dt0.Rows[0]["t_email"].ToString() + "is activated " + "  Welcome to SDIT E-Learning";
                //string send = "SDITEL";

                string url = "https://api.textlocal.in/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=";
                //refer to parameters to complete correct url string

                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

                objRequest.Method = "POST";
                objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());
                    myWriter.Write(url);
                }
                catch (Exception ex)
                {
                    // return e.Message;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    myWriter.Close();
                }

                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }
                //return result;
                //MessageBox.Show(result);
                MessageBox.Show("Teacher Login Permitted for  " + dt0.Rows[0]["t_fname"].ToString() + "Activation Message Sent");
                con.Close();
            }
        }

        private void approveteacher_Load(object sender, EventArgs e)
        {
            load();
        }

        private void approveteachersdatgrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.dummyteacherusn = approveteachersdatgrid.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}