using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admincontact : UserControl
    {
        private static admincontact _instance;

        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public admincontact()
        {
            InitializeComponent();
        }

        public static admincontact Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new admincontact();
                }
                return _instance;
            }
        }

        private void admincontact_Load(object sender, EventArgs e)
        {
            con.Open();
            string view_query = "select * from contactus_tbl";
            SqlDataAdapter sda1 = new SqlDataAdapter(view_query, con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            message_admin_datagrid.DataSource = dt;
            con.Close();
        }

      

        private void message_admin_datagrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = message_admin_datagrid.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.ForeColor = Color.Black;
            textBox2.Text = message_admin_datagrid.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.ForeColor = Color.Black;
            textBox3.Text = message_admin_datagrid.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.ForeColor = Color.Black;
            textBox4.Text = message_admin_datagrid.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.ForeColor = Color.Black;
            textBox5.Text = message_admin_datagrid.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox1.Text = "Sender Name";
            textBox1.ForeColor = Color.Silver;
            textBox2.Text = "";
            textBox2.Text = "Email Address";
            textBox2.ForeColor = Color.Silver;
            textBox3.Text = "";
            textBox3.Text = "Phone Number";
            textBox3.ForeColor = Color.Silver;
            textBox4.Text = "";
            textBox4.Text = "Subject";
            textBox4.ForeColor = Color.Silver;
            textBox5.Text = "";
            textBox5.Text = "Message For Admin";
            textBox5.ForeColor = Color.Silver;
        }
        private void tclearmessage_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Sender Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Sender Name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == " Email Address")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Email Address";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Phone Number")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Phone Number";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Subject")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Subject";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Message For Admin")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Message For Admin";
                textBox5.ForeColor = Color.Silver;
            }
        }
    }
}