using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admin_student_view : Form
    {
        public const int HT_CAPTION = 0X2;
        public const int WM_NCLBUTTONDOWN = 0XA1;
        private const int cCaption = 32;
        private const int cGrip = 16;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public admin_student_view()
        {
            InitializeComponent();
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void admin_student_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query_s = "select * from student_log where s_fname= '" + view_search.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_student_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_student_view_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void admin_student_view_datagrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void admin_student_view_Load(object sender, EventArgs e)
        {
            con.Open();
            string search_query_s = "select * from student_log";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_student_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void appleclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applemax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void applemin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void reresh_view_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query_s = "select * from student_log";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_student_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void view_Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_header_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void view_header_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void view_refresh_studnt_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query_s = "select * from student_log";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_student_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void view_search_Enter(object sender, EventArgs e)
        {
            if (view_search.Text == "Search By USN. Name")
            {
                view_search.Text = "";
                view_search.ForeColor = Color.Black;
            }
        }

        private void view_search_Leave(object sender, EventArgs e)
        {
            if (view_search.Text == "")
            {
                view_search.Text = "Search By USN. Name";
                view_search.ForeColor = Color.Silver;
            }
        }

        private void view_search_TextChanged(object sender, EventArgs e)
        {
        }

        private void view_search_usn_Click(object sender, EventArgs e)
        {
            con.Open();
            string search_query_s = "select * from student_log where s_usn= '" + view_search.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(search_query_s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_student_view_datagrid.DataSource = dt;
            con.Close();
        }
    }
}