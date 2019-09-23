using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admin_news_view : Form
    {
        public const int HT_CAPTION = 0X2;
        public const int WM_NCLBUTTONDOWN = 0XA1;
        private const int cCaption = 32;
        private const int cGrip = 16;
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");

        public admin_news_view()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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

        private void admin_news_log_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from news_log where n_by ='" + Program.username + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            admin_subject_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_news_search_Click(object sender, EventArgs e)
        {
            if (view_search.Text != "")
            {
                con.Open();
                string search_query = "select * from news_log  where n_title='" + view_search.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(search_query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                admin_subject_view_datagrid.DataSource = dt;
                con.Close();
            }
            else if (view_search.Text == "")
            {
                MessageBox.Show("Please enter the news title to be searched");
            }
        }

        private void admin_news_view_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from news_log where n_by ='" + Program.username + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            admin_subject_view_datagrid.DataSource = dt;
            con.Close();
        }

        private void admin_subject_view_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void admin_view_search_id_Click(object sender, EventArgs e)
        {
            if (view_search.Text != "")
            {
                con.Open();
                string search_query = "select * from news_log where  n_id=" + int.Parse(view_search.Text);

                SqlDataAdapter da = new SqlDataAdapter(search_query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                admin_subject_view_datagrid.DataSource = dt;
                con.Close();
            }
            else if (view_search.Text == "")
            {
                MessageBox.Show("Please enter the news id to be searched");
            }
        }

        private void all_view_log_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from news_log ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            admin_subject_view_datagrid.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            view_search.Text = "";
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

        private void ref_btn_Click(object sender, EventArgs e)
        {
            refresh();
            view_search.Text = "Search By News Id .TItle";
            view_search.ForeColor = Color.Silver;
        }

        private void refresh()
        {
            con.Open();
            string search_query = "select *  from news_log where n_by='" + Program.username + "'";
            SqlDataAdapter da = new SqlDataAdapter(search_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            admin_subject_view_datagrid.DataSource = dt;
            con.Close();

            clear();
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

        private void view_news_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            view_search.Text = "Search By News Id .TItle";
            view_search.ForeColor = Color.Silver;
        }

        private void view_search_Enter(object sender, EventArgs e)
        {
            if (view_search.Text == "Search By News Id .TItle")
            {
                view_search.Text = "";
                view_search.ForeColor = Color.Black;
            }
        }

        private void view_search_Leave(object sender, EventArgs e)
        {
        }
    }
}