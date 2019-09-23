using System;
using System.Windows.Forms;

namespace sditelearning
{
    public partial class admintheme : UserControl
    {
        public static admintheme _instance;

        public admintheme()
        {
            InitializeComponent();
        }

        public static admintheme Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new admintheme();
                }

                return _instance;
            }
        }

        private void admintheme_Load(object sender, EventArgs e)
        {
        }

        private void redthemebtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}