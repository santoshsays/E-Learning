using sditelearning.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admindashboard : Form
    {
        public const int HT_CAPTION = 0X2;
        public const int WM_NCLBUTTONDOWN = 0XA1;
        private Choices clist1 = new Choices();
        private SqlConnection con = new SqlConnection("Data Source=SANTOSH\\SQLEXPRESS01;Initial Catalog=elearn;Integrated Security=True");
        private bool isCollapased;
        private bool issCollapased;
        private int PanelWidth;
        private PromptBuilder pBuilder = new PromptBuilder();
        private SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        private SpeechSynthesizer ss = new SpeechSynthesizer();

        public admindashboard()
        {
            InitializeComponent();
            PanelWidth = leftpanel.Width;
            isCollapased = false;
        }

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void adminbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(admininformation.Instance))
            {
                dashboardcontrolpanel.Controls.Add(admininformation.Instance);
                admininformation.Instance.Dock = DockStyle.Fill;
                admininformation.Instance.BringToFront();
            }
            else
            {
                admininformation.Instance.BringToFront();
            }
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            adminbtn.Text = Program.username;
            if (!dashboardcontrolpanel.Controls.Contains(dashboardadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(dashboardadmin.Instance);
                dashboardadmin.Instance.Dock = DockStyle.Fill;
                dashboardadmin.Instance.BringToFront();
            }
            else
            {
                dashboardadmin.Instance.BringToFront();
            }
        }

        private void adminheader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void adminheader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void appleclose_Click(object sender, EventArgs e)
        {
            adminclosemessgeboc oadm = new adminclosemessgeboc();
            oadm.Show();
        }

        private void applemax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void applemin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void assignmentbtn_Click(object sender, EventArgs e)
        {
        }

        private void black_Click(object sender, EventArgs e)
        {
            leftpanel.BackColor = Color.Black;
            sliderbtn.BackColor = Color.Black;
            userpanel.BackColor = Color.Black;
            label3.ForeColor = Color.Black;
            panelside.BackColor = Color.Black;
            droppanelside.BackColor = Color.Black;
            bunifuImageButton1.BackColor = Color.Black;
        }

        private void black_MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Black;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void black_MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Black;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            leftpanel.BackColor = Color.Blue;
            sliderbtn.BackColor = Color.Blue;
            userpanel.BackColor = Color.Blue;
            label3.ForeColor = Color.Blue;
            panelside.BackColor = Color.Blue;
            droppanelside.BackColor = Color.Blue;
            bunifuImageButton1.BackColor = Color.Blue;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(dashboardadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(dashboardadmin.Instance);
                dashboardadmin.Instance.Dock = DockStyle.Fill;
                dashboardadmin.Instance.BringToFront();
            }
            else
            {
                dashboardadmin.Instance.BringToFront();
            }
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
        }

        private void bunifuTileButton()
        {
            leftpanel.BackColor = Color.Red;
            sliderbtn.BackColor = Color.Red;
            userpanel.BackColor = Color.Red;
            label3.ForeColor = Color.Red;
            panelside.BackColor = Color.Red;
            droppanelside.BackColor = Color.Red;
            bunifuImageButton1.BackColor = Color.Red;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuTileButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(approvestudents.Instance))
            {
                dashboardcontrolpanel.Controls.Add(approvestudents.Instance);
                approvestudents.Instance.Dock = DockStyle.Fill;
                approvestudents.Instance.BringToFront();
            }
            else
            {
                approvestudents.Instance.BringToFront();
            }
            if (button1.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(button1);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(approveteacher.Instance))
            {
                dashboardcontrolpanel.Controls.Add(approveteacher.Instance);
                approveteacher.Instance.Dock = DockStyle.Fill;
                approveteacher.Instance.BringToFront();
            }
            else
            {
                approveteacher.Instance.BringToFront();
            }
            if (button2.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(button2);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(button2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void contactbtns_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(admincontact.Instance))
            {
                dashboardcontrolpanel.Controls.Add(admincontact.Instance);
                admincontact.Instance.Dock = DockStyle.Fill;
                admincontact.Instance.BringToFront();
            }
            else
            {
                admincontact.Instance.BringToFront();
            }
            if (contactbtns.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(contactbtns);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(contactbtns);
            }
        }

        private void crimson_Click(object sender, EventArgs e)
        {
            leftpanel.BackColor = Color.Crimson;
            sliderbtn.BackColor = Color.Crimson;
            userpanel.BackColor = Color.Crimson;
            label3.ForeColor = Color.Crimson;
            panelside.BackColor = Color.Crimson;
            droppanelside.BackColor = Color.Crimson;
            bunifuImageButton1.BackColor = Color.Crimson;
        }

        private void crimson_MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Crimson;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void crimson_MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Crimson;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(dashboardadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(dashboardadmin.Instance);
                dashboardadmin.Instance.Dock = DockStyle.Fill;
                dashboardadmin.Instance.BringToFront();
            }
            else
            {
                dashboardadmin.Instance.BringToFront();
            }

            if (dashboardbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(dashboardbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(dashboardbtn);
            }
        }

        private void dashboardcontrolpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dashboardcontrolpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dropdowntimer_Tick(object sender, EventArgs e)
        {
            if (issCollapased)
            {
                settingsbtn.Image = Resources.Collapse_Arrow_35px;
                panelDropdown.Height += 10;
                if (panelDropdown.Size == panelDropdown.MaximumSize)
                {
                    dropdowntimer.Stop();
                    issCollapased = false;
                }
            }
            else
            {
                settingsbtn.Image = Resources.Expand_Arrow_35px;
                panelDropdown.Height -= 10;
                if (panelDropdown.Size == panelDropdown.MinimumSize)
                {
                    dropdowntimer.Stop();
                    issCollapased = true;
                }
            }
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(adminfeedback.Instance))
            {
                dashboardcontrolpanel.Controls.Add(adminfeedback.Instance);
                adminfeedback.Instance.Dock = DockStyle.Fill;
                adminfeedback.Instance.BringToFront();
            }
            else
            {
                adminfeedback.Instance.BringToFront();
            }
            if (feedbackbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                teal_MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveDropDownPanl(feedbackbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveDropDownPanl(feedbackbtn);
            }
        }

        private void gensettingsbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(settingsadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(settingsadmin.Instance);
                settingsadmin.Instance.Dock = DockStyle.Fill;
                settingsadmin.Instance.BringToFront();
            }
            else
            {
                settingsadmin.Instance.BringToFront();
            }
            if (gensettingsbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                teal_MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveDropDownPanl(gensettingsbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveDropDownPanl(gensettingsbtn);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void leftpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            //Login objlogin = new Login();
            this.Hide();
            //objlogin.Show();
        }

        private void messagebtns_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(adminmessage.Instance))
            {
                dashboardcontrolpanel.Controls.Add(adminmessage.Instance);
                adminmessage.Instance.Dock = DockStyle.Fill;
                adminmessage.Instance.BringToFront();
            }
            else
            {
                adminmessage.Instance.BringToFront();
            }
            if (messagebtns.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(messagebtns);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(messagebtns);
            }
        }

        private void MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Blue;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Blue;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void newsbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(newsaddadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(newsaddadmin.Instance);
                newsaddadmin.Instance.Dock = DockStyle.Fill;
                newsaddadmin.Instance.BringToFront();
            }
            else
            {
                newsaddadmin.Instance.BringToFront();
            }

            if (newsbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(newsbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(newsbtn);
            }
        }

        private void orange_Click(object sender, EventArgs e)
        {
            leftpanel.BackColor = Color.Orange;
            sliderbtn.BackColor = Color.Orange;
            userpanel.BackColor = Color.Orange;
            label3.ForeColor = Color.Orange;
            panelside.BackColor = Color.Orange;
            droppanelside.BackColor = Color.Orange;
            bunifuImageButton1.BackColor = Color.Orange;
        }

        private void orange_MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Orange;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void orange_MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Orange;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void Red_MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Red;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void Red_MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Red;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            dropdowntimer.Start();
            if (settingsbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                teal_MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveDropDownPanl(settingsbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveDropDownPanl(settingsbtn);
            }
        }

        private void sliderbtn_Click(object sender, EventArgs e)
        {
            ttimer.Start();
        }

        private void sliderbtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            PromptBuilder pBuilder = new PromptBuilder();
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            SpeechSynthesizer ss = new SpeechSynthesizer();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from users_tbl where u_email='" + Program.adminEmail + "'", con);
            DataTable dt0 = new DataTable();
            sda.Fill(dt0);
            switch (e.Result.Text.ToString())
            {
                case "HI":
                    ss.SpeakAsync("Hello sir ");
                    break;

                case "Good Morning":
                    string a1 = "Good Morning" + dt0.Rows[0]["u_fname"].ToString();
                    ss.SpeakAsync(a1);
                    break;

                case "Good Afternoon":
                    string a2 = "Good Afternoon" + dt0.Rows[0]["u_fname"].ToString();
                    ss.SpeakAsync(a2);
                    break;

                case "Hey Cortana":
                    string a3 = "Hi how can I help you " + dt0.Rows[0]["u_fname"].ToString();
                    ss.SpeakAsync(a3);
                    break;

                case "How are you ":

                    ss.SpeakAsync("Feeling Good How about you ");
                    break;

                case "I am fine ":

                    ss.SpeakAsync("Good to hear that  ");
                    break;

                case "How are doing ":

                    ss.SpeakAsync("I am feeling good and I am getting better ");
                    break;

                case "what is current time ":

                    ss.SpeakAsync("The currrent time in INDIA is" + DateTime.Now.ToLongTimeString());
                    break;

                case "close":
                    Application.Exit();
                    break;
                    //textBox.Text += e.Result.Text.ToString() + Environment.NewLine;
            }
            con.Close();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(studentadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(studentadmin.Instance);
                studentadmin.Instance.Dock = DockStyle.Fill;
                studentadmin.Instance.BringToFront();
            }
            else
            {
                studentadmin.Instance.BringToFront();
            }

            if (studentbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(studentbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(studentbtn);
            }
        }

        //testing
        // testing puprose
        private void subjectbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(subjectaddadmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(subjectaddadmin.Instance);
                subjectaddadmin.Instance.Dock = DockStyle.Fill;
                subjectaddadmin.Instance.BringToFront();
            }
            else
            {
                subjectaddadmin.Instance.BringToFront();
            }
            if (subjectbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(subjectbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(subjectbtn);
            }
        }

        private void teacherbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(teacheradmin.Instance))
            {
                dashboardcontrolpanel.Controls.Add(teacheradmin.Instance);
                teacheradmin.Instance.Dock = DockStyle.Fill;
                teacheradmin.Instance.BringToFront();
            }
            else
            {
                teacheradmin.Instance.BringToFront();
            }

            if (teacherbtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                Teal_MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveSidePanel(teacherbtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveSidePanel(teacherbtn);
            }
        }

        private void teal_Click_1(object sender, EventArgs e)
        {
            leftpanel.BackColor = Color.Teal;
            sliderbtn.BackColor = Color.Teal;
            userpanel.BackColor = Color.Teal;
            label3.ForeColor = Color.Teal;
            panelside.BackColor = Color.Teal;
            droppanelside.BackColor = Color.Teal;
            bunifuImageButton1.BackColor = Color.Teal;
        }

        private void teal_MoveDropDownPanl(Control butn)
        {
            droppanelside.BackColor = Color.White;
            panelside.BackColor = Color.Teal;
            droppanelside.Top = butn.Top;
            droppanelside.Height = butn.Height;
        }

        private void Teal_MoveSidePanel(Control btn)
        {
            droppanelside.BackColor = Color.Teal;
            panelside.BackColor = Color.White;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void themebtn_Click(object sender, EventArgs e)
        {
            if (dashboardcontrolpanel.Controls.Contains(dashboardadmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(newsaddadmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(teacheradmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(studentadmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(subjectaddadmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(settingsadmin.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(adminfeedback.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(admininformation.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(adminlatestversion.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(adminmessage.Instance) ||
                    dashboardcontrolpanel.Controls.Contains(admincontact.Instance) ||
                     dashboardcontrolpanel.Controls.Contains(approvestudents.Instance) ||
                      dashboardcontrolpanel.Controls.Contains(approveteacher.Instance))
            {
                dashboardcontrolpanel.Controls.Remove(dashboardadmin.Instance);
                dashboardcontrolpanel.Controls.Remove(newsaddadmin.Instance);
                dashboardcontrolpanel.Controls.Remove(teacheradmin.Instance);
                dashboardcontrolpanel.Controls.Remove(studentadmin.Instance);
                dashboardcontrolpanel.Controls.Remove(subjectaddadmin.Instance);
                dashboardcontrolpanel.Controls.Remove(settingsadmin.Instance);
                dashboardcontrolpanel.Controls.Remove(adminfeedback.Instance);
                dashboardcontrolpanel.Controls.Remove(admininformation.Instance);
                dashboardcontrolpanel.Controls.Remove(adminlatestversion.Instance);
                dashboardcontrolpanel.Controls.Remove(adminmessage.Instance);
                dashboardcontrolpanel.Controls.Remove(admincontact.Instance);
                dashboardcontrolpanel.Controls.Remove(approvestudents.Instance);
                dashboardcontrolpanel.Controls.Remove(approveteacher.Instance);
                dashboardcontrolpanel.Dock = DockStyle.Fill;
                dashboardcontrolpanel.BringToFront();
            }
            if (themebtn.Enabled == true && leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Red)
            {
                Red_MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Teal)
            {
                teal_MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Orange)
            {
                orange_MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Blue)
            {
                MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Black)
            {
                black_MoveDropDownPanl(themebtn);
            }
            else if (leftpanel.BackColor == Color.Crimson)
            {
                crimson_MoveDropDownPanl(themebtn);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void ttimer_Tick(object sender, EventArgs e)
        {
            if (isCollapased)
            {
                leftpanel.Width = leftpanel.Width + 10;
                if (leftpanel.Width >= PanelWidth)
                {
                    ttimer.Stop();
                    isCollapased = false;
                    this.Refresh();
                }
            }
            else
            {
                leftpanel.Width = leftpanel.Width - 10;
                if (leftpanel.Width <= 50)
                {
                    ttimer.Stop();
                    isCollapased = true;
                    this.Refresh();
                }
            }
        }

        private void userpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void userpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void versionbtn_Click(object sender, EventArgs e)
        {
            if (!dashboardcontrolpanel.Controls.Contains(adminlatestversion.Instance))
            {
                dashboardcontrolpanel.Controls.Add(adminlatestversion.Instance);
                adminlatestversion.Instance.Dock = DockStyle.Fill;
                adminlatestversion.Instance.BringToFront();
            }
            else
            {
                adminlatestversion.Instance.BringToFront();
            }
        }
    }
}