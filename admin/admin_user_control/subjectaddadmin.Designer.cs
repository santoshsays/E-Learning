namespace sditelearning
{
    partial class subjectaddadmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminnewsheaderpanel = new System.Windows.Forms.Panel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.admin_subject_search = new System.Windows.Forms.Button();
            this.admin_subject_search_image = new System.Windows.Forms.Button();
            this.adminsubjectsearchtxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adminsubjecttitletxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.admin_subject_add_btn = new System.Windows.Forms.Button();
            this.admin_subject_clear_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.adminsubjectidtxtbox = new System.Windows.Forms.TextBox();
            this.admin_subject_update_btn = new System.Windows.Forms.Button();
            this.admin_subject_delete_btn = new System.Windows.Forms.Button();
            this.admin_subject_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.adminsubjectdeptbtn = new System.Windows.Forms.ComboBox();
            this.adminsubteacherbtn = new System.Windows.Forms.ComboBox();
            this.adminsubjectsemester = new System.Windows.Forms.ComboBox();
            this.admin_subject_list_view = new System.Windows.Forms.Button();
            this.admin_subject_refresh = new System.Windows.Forms.Button();
            this.admin_subject_search_bysemseter = new System.Windows.Forms.Button();
            this.admin_subject_search_bydept = new System.Windows.Forms.Button();
            this.admin_subject_search_byteacher = new System.Windows.Forms.Button();
            this.adminnewsheaderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_subject_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adminnewsheaderpanel
            // 
            this.adminnewsheaderpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminnewsheaderpanel.Controls.Add(this.refreshbtn);
            this.adminnewsheaderpanel.Controls.Add(this.admin_subject_search);
            this.adminnewsheaderpanel.Controls.Add(this.admin_subject_search_image);
            this.adminnewsheaderpanel.Controls.Add(this.adminsubjectsearchtxt);
            this.adminnewsheaderpanel.Controls.Add(this.label);
            this.adminnewsheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminnewsheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.adminnewsheaderpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminnewsheaderpanel.Name = "adminnewsheaderpanel";
            this.adminnewsheaderpanel.Size = new System.Drawing.Size(1200, 66);
            this.adminnewsheaderpanel.TabIndex = 38;
            this.adminnewsheaderpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminnewsheaderpanel_Paint);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbtn.BackColor = System.Drawing.Color.Blue;
            this.refreshbtn.BackgroundImage = global::sditelearning.Properties.Resources.Refresh_35px_13;
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Location = new System.Drawing.Point(1147, 15);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(35, 35);
            this.refreshbtn.TabIndex = 111;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // admin_subject_search
            // 
            this.admin_subject_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search.BackColor = System.Drawing.Color.Blue;
            this.admin_subject_search.FlatAppearance.BorderSize = 0;
            this.admin_subject_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search.Location = new System.Drawing.Point(1008, 14);
            this.admin_subject_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_search.Name = "admin_subject_search";
            this.admin_subject_search.Size = new System.Drawing.Size(133, 37);
            this.admin_subject_search.TabIndex = 53;
            this.admin_subject_search.Text = "By Subject Title";
            this.admin_subject_search.UseVisualStyleBackColor = false;
            this.admin_subject_search.Click += new System.EventHandler(this.admin_subject_search_Click);
            // 
            // admin_subject_search_image
            // 
            this.admin_subject_search_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search_image.BackColor = System.Drawing.Color.Blue;
            this.admin_subject_search_image.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_subject_search_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_subject_search_image.FlatAppearance.BorderSize = 0;
            this.admin_subject_search_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search_image.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search_image.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search_image.Location = new System.Drawing.Point(726, 13);
            this.admin_subject_search_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_search_image.Name = "admin_subject_search_image";
            this.admin_subject_search_image.Size = new System.Drawing.Size(38, 39);
            this.admin_subject_search_image.TabIndex = 76;
            this.admin_subject_search_image.UseVisualStyleBackColor = false;
            this.admin_subject_search_image.Click += new System.EventHandler(this.admin_subject_search_image_Click_1);
            // 
            // adminsubjectsearchtxt
            // 
            this.adminsubjectsearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminsubjectsearchtxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubjectsearchtxt.ForeColor = System.Drawing.Color.Silver;
            this.adminsubjectsearchtxt.Location = new System.Drawing.Point(764, 13);
            this.adminsubjectsearchtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubjectsearchtxt.Name = "adminsubjectsearchtxt";
            this.adminsubjectsearchtxt.Size = new System.Drawing.Size(239, 38);
            this.adminsubjectsearchtxt.TabIndex = 52;
            this.adminsubjectsearchtxt.Text = "Search By Id. Title";
            this.adminsubjectsearchtxt.Enter += new System.EventHandler(this.adminsubjectsearchtxt_Enter);
            this.adminsubjectsearchtxt.Leave += new System.EventHandler(this.adminsubjectsearchtxt_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 30);
            this.label.TabIndex = 25;
            this.label.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Add Subject";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "List of Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Subject Title";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sub Teacher";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Department";
            // 
            // adminsubjecttitletxtbox
            // 
            this.adminsubjecttitletxtbox.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubjecttitletxtbox.Location = new System.Drawing.Point(187, 251);
            this.adminsubjecttitletxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubjecttitletxtbox.Name = "adminsubjecttitletxtbox";
            this.adminsubjecttitletxtbox.Size = new System.Drawing.Size(308, 34);
            this.adminsubjecttitletxtbox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(656, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Semester";
            // 
            // admin_subject_add_btn
            // 
            this.admin_subject_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_add_btn.BackColor = System.Drawing.Color.Teal;
            this.admin_subject_add_btn.FlatAppearance.BorderSize = 0;
            this.admin_subject_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_add_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_add_btn.ForeColor = System.Drawing.Color.White;
            this.admin_subject_add_btn.Location = new System.Drawing.Point(156, 661);
            this.admin_subject_add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_add_btn.Name = "admin_subject_add_btn";
            this.admin_subject_add_btn.Size = new System.Drawing.Size(149, 46);
            this.admin_subject_add_btn.TabIndex = 36;
            this.admin_subject_add_btn.Text = "Add Subject";
            this.admin_subject_add_btn.UseVisualStyleBackColor = false;
            this.admin_subject_add_btn.Click += new System.EventHandler(this.admin_subject_add_btn_Click);
            // 
            // admin_subject_clear_btn
            // 
            this.admin_subject_clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_clear_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_subject_clear_btn.FlatAppearance.BorderSize = 0;
            this.admin_subject_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_clear_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_clear_btn.ForeColor = System.Drawing.Color.White;
            this.admin_subject_clear_btn.Location = new System.Drawing.Point(987, 661);
            this.admin_subject_clear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_clear_btn.Name = "admin_subject_clear_btn";
            this.admin_subject_clear_btn.Size = new System.Drawing.Size(149, 46);
            this.admin_subject_clear_btn.TabIndex = 37;
            this.admin_subject_clear_btn.Text = "Clear";
            this.admin_subject_clear_btn.UseVisualStyleBackColor = false;
            this.admin_subject_clear_btn.Click += new System.EventHandler(this.admin_subject_clear_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Subject id";
            // 
            // adminsubjectidtxtbox
            // 
            this.adminsubjectidtxtbox.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubjectidtxtbox.Location = new System.Drawing.Point(187, 159);
            this.adminsubjectidtxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubjectidtxtbox.Name = "adminsubjectidtxtbox";
            this.adminsubjectidtxtbox.Size = new System.Drawing.Size(308, 34);
            this.adminsubjectidtxtbox.TabIndex = 40;
            // 
            // admin_subject_update_btn
            // 
            this.admin_subject_update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_update_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.admin_subject_update_btn.FlatAppearance.BorderSize = 0;
            this.admin_subject_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_update_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_update_btn.ForeColor = System.Drawing.Color.White;
            this.admin_subject_update_btn.Location = new System.Drawing.Point(322, 661);
            this.admin_subject_update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_update_btn.Name = "admin_subject_update_btn";
            this.admin_subject_update_btn.Size = new System.Drawing.Size(150, 46);
            this.admin_subject_update_btn.TabIndex = 43;
            this.admin_subject_update_btn.Text = "Update";
            this.admin_subject_update_btn.UseVisualStyleBackColor = false;
            this.admin_subject_update_btn.Click += new System.EventHandler(this.admin_subject_update_btn_Click);
            // 
            // admin_subject_delete_btn
            // 
            this.admin_subject_delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_subject_delete_btn.FlatAppearance.BorderSize = 0;
            this.admin_subject_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_delete_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_delete_btn.ForeColor = System.Drawing.Color.White;
            this.admin_subject_delete_btn.Location = new System.Drawing.Point(491, 661);
            this.admin_subject_delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_delete_btn.Name = "admin_subject_delete_btn";
            this.admin_subject_delete_btn.Size = new System.Drawing.Size(150, 46);
            this.admin_subject_delete_btn.TabIndex = 43;
            this.admin_subject_delete_btn.Text = "Delete";
            this.admin_subject_delete_btn.UseVisualStyleBackColor = false;
            this.admin_subject_delete_btn.Click += new System.EventHandler(this.admin_subject_delete_btn_Click);
            // 
            // admin_subject_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.admin_subject_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.admin_subject_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.admin_subject_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_subject_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_subject_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.admin_subject_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_subject_datagrid.DoubleBuffered = true;
            this.admin_subject_datagrid.EnableHeadersVisualStyles = false;
            this.admin_subject_datagrid.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.admin_subject_datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.admin_subject_datagrid.Location = new System.Drawing.Point(156, 374);
            this.admin_subject_datagrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_datagrid.Name = "admin_subject_datagrid";
            this.admin_subject_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_subject_datagrid.RowTemplate.Height = 24;
            this.admin_subject_datagrid.Size = new System.Drawing.Size(980, 271);
            this.admin_subject_datagrid.TabIndex = 44;
            this.admin_subject_datagrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.admin_subject_datagrid_MouseDoubleClick);
            // 
            // adminsubjectdeptbtn
            // 
            this.adminsubjectdeptbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminsubjectdeptbtn.BackColor = System.Drawing.Color.Blue;
            this.adminsubjectdeptbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubjectdeptbtn.ForeColor = System.Drawing.Color.White;
            this.adminsubjectdeptbtn.FormattingEnabled = true;
            this.adminsubjectdeptbtn.Items.AddRange(new object[] {
            "Civil Engineering",
            "Computer Science",
            "Information Science",
            "Electronics  Eng",
            "Mechanical Eng"});
            this.adminsubjectdeptbtn.Location = new System.Drawing.Point(781, 121);
            this.adminsubjectdeptbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubjectdeptbtn.Name = "adminsubjectdeptbtn";
            this.adminsubjectdeptbtn.Size = new System.Drawing.Size(312, 41);
            this.adminsubjectdeptbtn.TabIndex = 64;
            this.adminsubjectdeptbtn.SelectedIndexChanged += new System.EventHandler(this.adminsubjectdeptbtn_SelectedIndexChanged);
            // 
            // adminsubteacherbtn
            // 
            this.adminsubteacherbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminsubteacherbtn.BackColor = System.Drawing.Color.Blue;
            this.adminsubteacherbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubteacherbtn.ForeColor = System.Drawing.Color.White;
            this.adminsubteacherbtn.FormattingEnabled = true;
            this.adminsubteacherbtn.Location = new System.Drawing.Point(781, 206);
            this.adminsubteacherbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubteacherbtn.Name = "adminsubteacherbtn";
            this.adminsubteacherbtn.Size = new System.Drawing.Size(312, 41);
            this.adminsubteacherbtn.TabIndex = 64;
            // 
            // adminsubjectsemester
            // 
            this.adminsubjectsemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminsubjectsemester.BackColor = System.Drawing.Color.Blue;
            this.adminsubjectsemester.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminsubjectsemester.ForeColor = System.Drawing.Color.White;
            this.adminsubjectsemester.FormattingEnabled = true;
            this.adminsubjectsemester.Items.AddRange(new object[] {
            "1st  Semester",
            "2nd Semester",
            "3rd  Semester",
            "4th Semester",
            "5th Semester",
            "6th Semester",
            "7th Semester",
            "8th Semester"});
            this.adminsubjectsemester.Location = new System.Drawing.Point(781, 302);
            this.adminsubjectsemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminsubjectsemester.Name = "adminsubjectsemester";
            this.adminsubjectsemester.Size = new System.Drawing.Size(312, 41);
            this.adminsubjectsemester.TabIndex = 64;
            // 
            // admin_subject_list_view
            // 
            this.admin_subject_list_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_list_view.BackColor = System.Drawing.SystemColors.Highlight;
            this.admin_subject_list_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_list_view.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_list_view.ForeColor = System.Drawing.Color.White;
            this.admin_subject_list_view.Location = new System.Drawing.Point(660, 662);
            this.admin_subject_list_view.Margin = new System.Windows.Forms.Padding(4);
            this.admin_subject_list_view.Name = "admin_subject_list_view";
            this.admin_subject_list_view.Size = new System.Drawing.Size(151, 46);
            this.admin_subject_list_view.TabIndex = 66;
            this.admin_subject_list_view.Text = "View Subject";
            this.admin_subject_list_view.UseVisualStyleBackColor = false;
            this.admin_subject_list_view.Click += new System.EventHandler(this.admin_subject_list_view_Click);
            // 
            // admin_subject_refresh
            // 
            this.admin_subject_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_subject_refresh.BackColor = System.Drawing.Color.Teal;
            this.admin_subject_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_refresh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_refresh.ForeColor = System.Drawing.Color.White;
            this.admin_subject_refresh.Location = new System.Drawing.Point(821, 662);
            this.admin_subject_refresh.Name = "admin_subject_refresh";
            this.admin_subject_refresh.Size = new System.Drawing.Size(150, 45);
            this.admin_subject_refresh.TabIndex = 67;
            this.admin_subject_refresh.Text = "Refresh";
            this.admin_subject_refresh.UseVisualStyleBackColor = false;
            this.admin_subject_refresh.Click += new System.EventHandler(this.admin_subject_refresh_Click);
            // 
            // admin_subject_search_bysemseter
            // 
            this.admin_subject_search_bysemseter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search_bysemseter.BackColor = System.Drawing.Color.Blue;
            this.admin_subject_search_bysemseter.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_subject_search_bysemseter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_subject_search_bysemseter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search_bysemseter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search_bysemseter.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search_bysemseter.Location = new System.Drawing.Point(1094, 299);
            this.admin_subject_search_bysemseter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_search_bysemseter.Name = "admin_subject_search_bysemseter";
            this.admin_subject_search_bysemseter.Size = new System.Drawing.Size(44, 44);
            this.admin_subject_search_bysemseter.TabIndex = 76;
            this.admin_subject_search_bysemseter.UseVisualStyleBackColor = false;
            this.admin_subject_search_bysemseter.Click += new System.EventHandler(this.admin_subject_search_bysemseter_Click_1);
            // 
            // admin_subject_search_bydept
            // 
            this.admin_subject_search_bydept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search_bydept.BackColor = System.Drawing.Color.Blue;
            this.admin_subject_search_bydept.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_subject_search_bydept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_subject_search_bydept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search_bydept.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search_bydept.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search_bydept.Location = new System.Drawing.Point(1094, 120);
            this.admin_subject_search_bydept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_search_bydept.Name = "admin_subject_search_bydept";
            this.admin_subject_search_bydept.Size = new System.Drawing.Size(44, 44);
            this.admin_subject_search_bydept.TabIndex = 76;
            this.admin_subject_search_bydept.UseVisualStyleBackColor = false;
            this.admin_subject_search_bydept.Click += new System.EventHandler(this.admin_subject_search_bydept_Click_1);
            // 
            // admin_subject_search_byteacher
            // 
            this.admin_subject_search_byteacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search_byteacher.BackColor = System.Drawing.Color.Blue;
            this.admin_subject_search_byteacher.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_subject_search_byteacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_subject_search_byteacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search_byteacher.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search_byteacher.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search_byteacher.Location = new System.Drawing.Point(1094, 204);
            this.admin_subject_search_byteacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_subject_search_byteacher.Name = "admin_subject_search_byteacher";
            this.admin_subject_search_byteacher.Size = new System.Drawing.Size(44, 44);
            this.admin_subject_search_byteacher.TabIndex = 76;
            this.admin_subject_search_byteacher.UseVisualStyleBackColor = false;
            this.admin_subject_search_byteacher.Click += new System.EventHandler(this.admin_subject_search_byteacher_Click_1);
            // 
            // subjectaddadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.admin_subject_search_bysemseter);
            this.Controls.Add(this.admin_subject_search_bydept);
            this.Controls.Add(this.admin_subject_search_byteacher);
            this.Controls.Add(this.admin_subject_refresh);
            this.Controls.Add(this.admin_subject_list_view);
            this.Controls.Add(this.adminsubjectsemester);
            this.Controls.Add(this.adminsubteacherbtn);
            this.Controls.Add(this.adminsubjectdeptbtn);
            this.Controls.Add(this.admin_subject_datagrid);
            this.Controls.Add(this.admin_subject_delete_btn);
            this.Controls.Add(this.admin_subject_update_btn);
            this.Controls.Add(this.adminsubjectidtxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminnewsheaderpanel);
            this.Controls.Add(this.admin_subject_clear_btn);
            this.Controls.Add(this.admin_subject_add_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adminsubjecttitletxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "subjectaddadmin";
            this.Size = new System.Drawing.Size(1200, 820);
            this.Load += new System.EventHandler(this.subjectaddadmin_Load);
            this.adminnewsheaderpanel.ResumeLayout(false);
            this.adminnewsheaderpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_subject_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminnewsheaderpanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button admin_subject_search;
        private System.Windows.Forms.TextBox adminsubjectsearchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adminsubjecttitletxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button admin_subject_add_btn;
        private System.Windows.Forms.Button admin_subject_clear_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminsubjectidtxtbox;
        private System.Windows.Forms.Button admin_subject_update_btn;
        private System.Windows.Forms.Button admin_subject_delete_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid admin_subject_datagrid;
        private System.Windows.Forms.ComboBox adminsubjectdeptbtn;
        private System.Windows.Forms.ComboBox adminsubteacherbtn;
        private System.Windows.Forms.ComboBox adminsubjectsemester;
        private System.Windows.Forms.Button admin_subject_list_view;
        private System.Windows.Forms.Button admin_subject_refresh;
        private System.Windows.Forms.Button admin_subject_search_byteacher;
        private System.Windows.Forms.Button admin_subject_search_bydept;
        private System.Windows.Forms.Button admin_subject_search_image;
        private System.Windows.Forms.Button admin_subject_search_bysemseter;
        private System.Windows.Forms.Button refreshbtn;
    }
}
