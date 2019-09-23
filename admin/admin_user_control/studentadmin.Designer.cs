namespace sditelearning
{
    partial class studentadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminnewsheaderpanel = new System.Windows.Forms.Panel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.admin_student_search_image = new Bunifu.Framework.UI.BunifuImageButton();
            this.admin_student_search = new System.Windows.Forms.Button();
            this.adminstudentsearchtxt = new System.Windows.Forms.TextBox();
            this.admin_student_search_bydept_btn = new System.Windows.Forms.Button();
            this.adminstudentdatagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.retypepasswordtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mobiletxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.admin_student_delete_btn = new System.Windows.Forms.Button();
            this.admin_student_update_btn = new System.Windows.Forms.Button();
            this.admin_student_clear_btn = new System.Windows.Forms.Button();
            this.admin_student_add_btn = new System.Windows.Forms.Button();
            this.departmentbtn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usntxt = new System.Windows.Forms.TextBox();
            this.admin_student_refresh_btn = new System.Windows.Forms.Button();
            this.admin_student_view_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.password_hide_visible = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminnewsheaderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_student_search_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminstudentdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Students";
            // 
            // adminnewsheaderpanel
            // 
            this.adminnewsheaderpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminnewsheaderpanel.Controls.Add(this.refreshbtn);
            this.adminnewsheaderpanel.Controls.Add(this.admin_student_search_image);
            this.adminnewsheaderpanel.Controls.Add(this.admin_student_search);
            this.adminnewsheaderpanel.Controls.Add(this.adminstudentsearchtxt);
            this.adminnewsheaderpanel.Controls.Add(this.label1);
            this.adminnewsheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminnewsheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.adminnewsheaderpanel.Name = "adminnewsheaderpanel";
            this.adminnewsheaderpanel.Size = new System.Drawing.Size(1200, 70);
            this.adminnewsheaderpanel.TabIndex = 29;
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
            this.refreshbtn.Location = new System.Drawing.Point(1113, 15);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(35, 35);
            this.refreshbtn.TabIndex = 110;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // admin_student_search_image
            // 
            this.admin_student_search_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_student_search_image.BackColor = System.Drawing.Color.Blue;
            this.admin_student_search_image.Image = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_student_search_image.ImageActive = null;
            this.admin_student_search_image.Location = new System.Drawing.Point(669, 16);
            this.admin_student_search_image.Name = "admin_student_search_image";
            this.admin_student_search_image.Size = new System.Drawing.Size(36, 35);
            this.admin_student_search_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin_student_search_image.TabIndex = 54;
            this.admin_student_search_image.TabStop = false;
            this.admin_student_search_image.Zoom = 10;
            this.admin_student_search_image.Click += new System.EventHandler(this.admin_student_search_image_Click);
            // 
            // admin_student_search
            // 
            this.admin_student_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_student_search.BackColor = System.Drawing.Color.Blue;
            this.admin_student_search.FlatAppearance.BorderSize = 0;
            this.admin_student_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_search.ForeColor = System.Drawing.Color.White;
            this.admin_student_search.Location = new System.Drawing.Point(931, 16);
            this.admin_student_search.Name = "admin_student_search";
            this.admin_student_search.Size = new System.Drawing.Size(176, 35);
            this.admin_student_search.TabIndex = 53;
            this.admin_student_search.Text = "By Student Name";
            this.admin_student_search.UseVisualStyleBackColor = false;
            this.admin_student_search.Click += new System.EventHandler(this.admin_student_search_Click);
            // 
            // adminstudentsearchtxt
            // 
            this.adminstudentsearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminstudentsearchtxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminstudentsearchtxt.ForeColor = System.Drawing.Color.Silver;
            this.adminstudentsearchtxt.Location = new System.Drawing.Point(705, 16);
            this.adminstudentsearchtxt.Name = "adminstudentsearchtxt";
            this.adminstudentsearchtxt.Size = new System.Drawing.Size(220, 34);
            this.adminstudentsearchtxt.TabIndex = 52;
            this.adminstudentsearchtxt.Text = "Search By USN .Name";
            this.adminstudentsearchtxt.Enter += new System.EventHandler(this.adminstudentsearchtxt_Enter);
            this.adminstudentsearchtxt.Leave += new System.EventHandler(this.adminstudentsearchtxt_Leave);
            // 
            // admin_student_search_bydept_btn
            // 
            this.admin_student_search_bydept_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_student_search_bydept_btn.BackColor = System.Drawing.Color.Blue;
            this.admin_student_search_bydept_btn.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_student_search_bydept_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_student_search_bydept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_search_bydept_btn.Location = new System.Drawing.Point(1064, 206);
            this.admin_student_search_bydept_btn.Name = "admin_student_search_bydept_btn";
            this.admin_student_search_bydept_btn.Size = new System.Drawing.Size(41, 41);
            this.admin_student_search_bydept_btn.TabIndex = 91;
            this.admin_student_search_bydept_btn.UseVisualStyleBackColor = false;
            this.admin_student_search_bydept_btn.Click += new System.EventHandler(this.admin_student_search_bydept_btn_Click);
            // 
            // adminstudentdatagrid
            // 
            this.adminstudentdatagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminstudentdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adminstudentdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminstudentdatagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.adminstudentdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminstudentdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminstudentdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminstudentdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminstudentdatagrid.DoubleBuffered = true;
            this.adminstudentdatagrid.EnableHeadersVisualStyles = false;
            this.adminstudentdatagrid.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.adminstudentdatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.adminstudentdatagrid.Location = new System.Drawing.Point(67, 450);
            this.adminstudentdatagrid.Name = "adminstudentdatagrid";
            this.adminstudentdatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adminstudentdatagrid.RowTemplate.Height = 24;
            this.adminstudentdatagrid.Size = new System.Drawing.Size(1040, 198);
            this.adminstudentdatagrid.TabIndex = 28;
            this.adminstudentdatagrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.adminstudentdatagrid_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "List of Student";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Re-Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Lname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fname";
            // 
            // lnametxt
            // 
            this.lnametxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.Location = new System.Drawing.Point(299, 138);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(203, 36);
            this.lnametxt.TabIndex = 34;
            // 
            // retypepasswordtxt
            // 
            this.retypepasswordtxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepasswordtxt.Location = new System.Drawing.Point(67, 361);
            this.retypepasswordtxt.Name = "retypepasswordtxt";
            this.retypepasswordtxt.PasswordChar = '*';
            this.retypepasswordtxt.Size = new System.Drawing.Size(433, 36);
            this.retypepasswordtxt.TabIndex = 35;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(67, 285);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(433, 36);
            this.passwordtxt.TabIndex = 36;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(69, 211);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(433, 36);
            this.emailtxt.TabIndex = 37;
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(67, 138);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(203, 36);
            this.fnametxt.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(668, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 23);
            this.label12.TabIndex = 47;
            this.label12.Text = "Mobile-no";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(668, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 48;
            this.label11.Text = "Address";
            // 
            // mobiletxt
            // 
            this.mobiletxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobiletxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobiletxt.Location = new System.Drawing.Point(674, 361);
            this.mobiletxt.Name = "mobiletxt";
            this.mobiletxt.Size = new System.Drawing.Size(433, 36);
            this.mobiletxt.TabIndex = 45;
            // 
            // addresstxt
            // 
            this.addresstxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addresstxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(672, 285);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(433, 36);
            this.addresstxt.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Add Student";
            // 
            // admin_student_delete_btn
            // 
            this.admin_student_delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_delete_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_student_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_delete_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_delete_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_delete_btn.Location = new System.Drawing.Point(427, 683);
            this.admin_student_delete_btn.Name = "admin_student_delete_btn";
            this.admin_student_delete_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_student_delete_btn.TabIndex = 59;
            this.admin_student_delete_btn.Text = "Delete";
            this.admin_student_delete_btn.UseVisualStyleBackColor = false;
            this.admin_student_delete_btn.Click += new System.EventHandler(this.admin_student_delete_btn_Click);
            // 
            // admin_student_update_btn
            // 
            this.admin_student_update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_update_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.admin_student_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_update_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_update_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_update_btn.Location = new System.Drawing.Point(252, 682);
            this.admin_student_update_btn.Name = "admin_student_update_btn";
            this.admin_student_update_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_student_update_btn.TabIndex = 58;
            this.admin_student_update_btn.Text = "Update";
            this.admin_student_update_btn.UseVisualStyleBackColor = false;
            this.admin_student_update_btn.Click += new System.EventHandler(this.admin_student_update_btn_Click);
            // 
            // admin_student_clear_btn
            // 
            this.admin_student_clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_clear_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_student_clear_btn.FlatAppearance.BorderSize = 0;
            this.admin_student_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_clear_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_clear_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_clear_btn.Location = new System.Drawing.Point(957, 682);
            this.admin_student_clear_btn.Name = "admin_student_clear_btn";
            this.admin_student_clear_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_student_clear_btn.TabIndex = 57;
            this.admin_student_clear_btn.Text = "Clear";
            this.admin_student_clear_btn.UseVisualStyleBackColor = false;
            this.admin_student_clear_btn.Click += new System.EventHandler(this.admin_student_clear_btn_Click);
            // 
            // admin_student_add_btn
            // 
            this.admin_student_add_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_add_btn.BackColor = System.Drawing.Color.Teal;
            this.admin_student_add_btn.FlatAppearance.BorderSize = 0;
            this.admin_student_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_add_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_add_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_add_btn.Location = new System.Drawing.Point(64, 682);
            this.admin_student_add_btn.Name = "admin_student_add_btn";
            this.admin_student_add_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_student_add_btn.TabIndex = 56;
            this.admin_student_add_btn.Text = "Add Student";
            this.admin_student_add_btn.UseVisualStyleBackColor = false;
            this.admin_student_add_btn.Click += new System.EventHandler(this.admin_student_add_btn_Click);
            // 
            // departmentbtn
            // 
            this.departmentbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentbtn.BackColor = System.Drawing.Color.Blue;
            this.departmentbtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentbtn.ForeColor = System.Drawing.Color.White;
            this.departmentbtn.FormattingEnabled = true;
            this.departmentbtn.Items.AddRange(new object[] {
            "Civil Engineering",
            "Computer Science",
            "Information Science",
            "Electronics  Eng",
            "Mechanical Eng"});
            this.departmentbtn.Location = new System.Drawing.Point(672, 206);
            this.departmentbtn.Name = "departmentbtn";
            this.departmentbtn.Size = new System.Drawing.Size(386, 41);
            this.departmentbtn.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Student ID";
            // 
            // usntxt
            // 
            this.usntxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usntxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usntxt.Location = new System.Drawing.Point(672, 127);
            this.usntxt.Name = "usntxt";
            this.usntxt.Size = new System.Drawing.Size(435, 36);
            this.usntxt.TabIndex = 34;
            // 
            // admin_student_refresh_btn
            // 
            this.admin_student_refresh_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_refresh_btn.BackColor = System.Drawing.Color.Teal;
            this.admin_student_refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_refresh_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_refresh_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_refresh_btn.Location = new System.Drawing.Point(787, 683);
            this.admin_student_refresh_btn.Name = "admin_student_refresh_btn";
            this.admin_student_refresh_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_student_refresh_btn.TabIndex = 89;
            this.admin_student_refresh_btn.Text = "Refresh";
            this.admin_student_refresh_btn.UseVisualStyleBackColor = false;
            this.admin_student_refresh_btn.Click += new System.EventHandler(this.admin_student_refresh_btn_Click);
            // 
            // admin_student_view_btn
            // 
            this.admin_student_view_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_view_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.admin_student_view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_view_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_view_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_view_btn.Location = new System.Drawing.Point(605, 682);
            this.admin_student_view_btn.Margin = new System.Windows.Forms.Padding(4);
            this.admin_student_view_btn.Name = "admin_student_view_btn";
            this.admin_student_view_btn.Size = new System.Drawing.Size(151, 46);
            this.admin_student_view_btn.TabIndex = 88;
            this.admin_student_view_btn.Text = "View Log";
            this.admin_student_view_btn.UseVisualStyleBackColor = false;
            this.admin_student_view_btn.Click += new System.EventHandler(this.admin_student_view_btn_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(670, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 91;
            this.label10.Text = "Department";
            // 
            // password_hide_visible
            // 
            this.password_hide_visible.BackColor = System.Drawing.Color.White;
            this.password_hide_visible.BackgroundImage = global::sditelearning.Properties.Resources.Eye_25px1;
            this.password_hide_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_hide_visible.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_hide_visible.ForeColor = System.Drawing.Color.White;
            this.password_hide_visible.Location = new System.Drawing.Point(464, 287);
            this.password_hide_visible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_hide_visible.Name = "password_hide_visible";
            this.password_hide_visible.Size = new System.Drawing.Size(33, 33);
            this.password_hide_visible.TabIndex = 92;
            this.password_hide_visible.UseVisualStyleBackColor = false;
            this.password_hide_visible.MouseLeave += new System.EventHandler(this.password_hide_visible_MouseLeave);
            this.password_hide_visible.MouseHover += new System.EventHandler(this.password_hide_visible_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::sditelearning.Properties.Resources.Eye_25px1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(462, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 93;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // studentadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_hide_visible);
            this.Controls.Add(this.admin_student_search_bydept_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.admin_student_refresh_btn);
            this.Controls.Add(this.admin_student_view_btn);
            this.Controls.Add(this.departmentbtn);
            this.Controls.Add(this.admin_student_delete_btn);
            this.Controls.Add(this.admin_student_update_btn);
            this.Controls.Add(this.admin_student_clear_btn);
            this.Controls.Add(this.admin_student_add_btn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mobiletxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usntxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.retypepasswordtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminnewsheaderpanel);
            this.Controls.Add(this.adminstudentdatagrid);
            this.Name = "studentadmin";
            this.Size = new System.Drawing.Size(1200, 820);
            this.Load += new System.EventHandler(this.studentadmin_Load);
            this.adminnewsheaderpanel.ResumeLayout(false);
            this.adminnewsheaderpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_student_search_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminstudentdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminnewsheaderpanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid adminstudentdatagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.TextBox retypepasswordtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mobiletxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button admin_student_delete_btn;
        private System.Windows.Forms.Button admin_student_update_btn;
        private System.Windows.Forms.Button admin_student_clear_btn;
        private System.Windows.Forms.Button admin_student_add_btn;
        private System.Windows.Forms.ComboBox departmentbtn;
        private Bunifu.Framework.UI.BunifuImageButton admin_student_search_image;
        private System.Windows.Forms.Button admin_student_search;
        private System.Windows.Forms.TextBox adminstudentsearchtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usntxt;
        private System.Windows.Forms.Button admin_student_search_bydept_btn;
        private System.Windows.Forms.Button admin_student_refresh_btn;
        private System.Windows.Forms.Button admin_student_view_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button password_hide_visible;
        private System.Windows.Forms.Button button1;
    }
}
