using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class dashboardadmin : UserControl
    {
        private static dashboardadmin _instance;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public dashboardadmin()
        {
            InitializeComponent();
        }

        public static dashboardadmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new dashboardadmin();
                }

                return _instance;
            }
        }

        private void dashboardadmin_Load(object sender, EventArgs e)
        {
            footerbarpaneltimer.Start();
            timetimer.Start();
            eventstimer.Start();

            // newscount stored procedure
            con.Open();
            SqlCommand nwbda = new SqlCommand("exec shownewscount", con);
            nwbda.ExecuteNonQuery();
            SqlDataReader rd = nwbda.ExecuteReader();
            rd.Read();
            newslbl.Text = rd[""].ToString();
            con.Close();

            //teachers count stored procedure
            con.Open();
            SqlCommand twbda = new SqlCommand("exec showteacherscount", con);
            twbda.ExecuteNonQuery();
            SqlDataReader tr = twbda.ExecuteReader();
            tr.Read();
            teacherlblcount.Text = tr[""].ToString();
            con.Close();

            //students count stored procedure
            con.Open();
            SqlCommand swbda = new SqlCommand("exec showstudentscount", con);
            swbda.ExecuteNonQuery();
            SqlDataReader sr = swbda.ExecuteReader();
            sr.Read();
            lblcount.Text = sr[""].ToString();
            con.Close();

            //subject count stored procedure
            con.Open();
            SqlCommand sswbda = new SqlCommand("exec showsubjectcount", con);
            sswbda.ExecuteNonQuery();
            SqlDataReader srr = sswbda.ExecuteReader();
            srr.Read();
            sublblcount.Text = srr[""].ToString();
            con.Close();
        }

        private void eventstimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox7.Visible == true)
            {
                bunifuTransition1.ShowSync(pictureBox7);
                bunifuTransition1.HideSync(pictureBox7);
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                bunifuTransition2.ShowSync(pictureBox8);
                bunifuTransition2.HideSync(pictureBox8);
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                bunifuTransition3.ShowSync(pictureBox9);
                bunifuTransition3.HideSync(pictureBox9);
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                bunifuTransition4.ShowSync(pictureBox10);
                bunifuTransition4.HideSync(pictureBox10);
                pictureBox10.Visible = false;
                pictureBox7.Visible = true;
            }
        }

        private void footerbarpaneltimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void studentdashpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm");
            lblseconds.Text = DateTime.Now.ToString("ss");
            lblday.Text = DateTime.Now.ToString("dddd");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblseconds.Location = new Point(lbltime.Location.X + lbltime.Width - 5, lblseconds.Location.Y);
        }
    }
}