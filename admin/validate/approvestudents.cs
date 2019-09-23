using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class approvestudents : UserControl
    {
        private static approvestudents _instance;

        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public approvestudents()
        {
            InitializeComponent();
        }

        public static approvestudents Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new approvestudents();
                }

                return _instance;
            }
        }

        public void load()
        {
            con.Open();
            SqlCommand sda = new SqlCommand("select s_usn,s_fname,s_lname,s_email,s_dname,s_address,s_mobile from dummystudents_tbl", con);
            sda.ExecuteNonQuery();
            SqlDataAdapter sdaa = new SqlDataAdapter(sda);
            DataTable dt = new DataTable();
            sdaa.Fill(dt);
            approvestudentdatagird.DataSource = dt;
            con.Close();
        }

        private void admin_student_clear_btn_Click(object sender, EventArgs e)
        {
            load();
        }

        private void approve_Click(object sender, EventArgs e)
        {
            con.Open();
            string fetch = "select * from dummystudents_tbl where s_usn='" + Program.dummystdusn + "' ";
            SqlCommand sfetch = new SqlCommand(fetch, con);
            SqlDataReader fr = sfetch.ExecuteReader();
            fr.Read();
            Program.dummystdusn = fr["s_usn"].ToString();
            Program.dummystdfname = fr["s_fname"].ToString();
            Program.dummystdlname = fr["s_lname"].ToString();
            Program.dummystdemail = fr["s_email"].ToString();
            Program.dummystdpassword = fr["s_password"].ToString();
            Program.dummystdrepassword = fr["s_retypepassword"].ToString();
            Program.dummystddname = fr["s_dname"].ToString();
            Program.dummystdaddress = fr["s_address"].ToString();
            Program.dummystdmobile = fr["s_mobile"].ToString();

            con.Close();

            con.Open();
            string inst = "insert into student_tbl(s_usn,s_fname,s_lname,s_email,s_password,s_retypepassword,s_dname,s_address,s_mobile) values('" + Program.dummystdusn + "','" + Program.dummystdfname + "','" + Program.dummystdlname + "','" + Program.dummystdemail + "','" + Program.dummystdpassword + "','" + Program.dummystdrepassword + "','" + Program.dummystddname + "','" + Program.dummystdaddress + "','" + Program.dummystdmobile + "')";
            SqlCommand sinst = new SqlCommand(inst, con);
            sinst.ExecuteNonQuery();
            con.Close();

            con.Open();
            string delt = "delete  from dummystudents_tbl where s_usn='" + Program.dummystdusn + "'";
            SqlCommand sdelt = new SqlCommand(delt, con);
            sdelt.ExecuteNonQuery();
            con.Close();
            load();
            //  MessageBox.Show("Student Login Permitted for" + Program.dummystdfname);
            //send message to reigstered users
            con.Open();
            SqlCommand sda = new SqlCommand("select * from student_tbl where s_usn='" + Program.dummystdusn + "'", con);
            SqlDataAdapter mda = new SqlDataAdapter(sda);
            DataTable dt0 = new DataTable();
            mda.Fill(dt0);
            if (dt0.Rows.Count > 0)
            {
                string result;
                string apiKey = "raLZZ05OIyA-xUFIOZJvelTl5vDRVEFMKa2BNc3OsL";   //api key
                string numbers = dt0.Rows[0]["s_mobile"].ToString(); // in a comma seperated list
                string message = "Hi " + dt0.Rows[0]["s_fname"].ToString() + " Your Email is: " + dt0.Rows[0]["s_email"].ToString() + "is activated " + "  Welcome to SDIT E-Learning";
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
                MessageBox.Show("Student Login Permitted for" + dt0.Rows[0]["s_fname"].ToString() + "Activation Message Sent");
                con.Close();
            }
        }

        private void approvestudentdatagird_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.dummystdusn = approvestudentdatagird.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void approvestudents_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}