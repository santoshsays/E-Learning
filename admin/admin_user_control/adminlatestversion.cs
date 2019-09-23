using System;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class adminlatestversion : UserControl
    {
        private static adminlatestversion _instance;

        public adminlatestversion()
        {
            InitializeComponent();
        }

        public static adminlatestversion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new adminlatestversion();
                }

                return _instance;
            }
        }

        private void adminlatestversion_Load(object sender, EventArgs e)
        {
        }

        private void adminnewsheaderpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void adminupdatebtn_Click(object sender, EventArgs e)
        {
            updatedialog objupdate = new updatedialog();
            objupdate.Show();
        }
    }
}