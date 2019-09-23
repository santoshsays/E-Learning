namespace sditelearning
{
    partial class admin_subject_view
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_subject_view));
            this.admin_subject_view_datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_subject_view_cancel_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view_subject_refresh = new System.Windows.Forms.Button();
            this.view_header_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.appleclose = new System.Windows.Forms.Button();
            this.applemin = new System.Windows.Forms.Button();
            this.applemax = new System.Windows.Forms.Button();
            this.admin_view_search_id = new System.Windows.Forms.Button();
            this.refreshbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label = new System.Windows.Forms.Label();
            this.admin_subject_search = new System.Windows.Forms.Button();
            this.view_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.admin_subject_view_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.view_header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_subject_view_datagrid
            // 
            this.admin_subject_view_datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.admin_subject_view_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.admin_subject_view_datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.admin_subject_view_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.admin_subject_view_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_subject_view_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.admin_subject_view_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_subject_view_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_subject_view_datagrid.DoubleBuffered = true;
            this.admin_subject_view_datagrid.EnableHeadersVisualStyles = false;
            this.admin_subject_view_datagrid.HeaderBgColor = System.Drawing.Color.Blue;
            this.admin_subject_view_datagrid.HeaderForeColor = System.Drawing.Color.White;
            this.admin_subject_view_datagrid.Location = new System.Drawing.Point(0, 0);
            this.admin_subject_view_datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.admin_subject_view_datagrid.Name = "admin_subject_view_datagrid";
            this.admin_subject_view_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.admin_subject_view_datagrid.Size = new System.Drawing.Size(1180, 445);
            this.admin_subject_view_datagrid.TabIndex = 0;
            this.admin_subject_view_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admin_subject_view_datagrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Log of Subject Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 62);
            this.panel1.TabIndex = 41;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // admin_subject_view_cancel_btn
            // 
            this.admin_subject_view_cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_subject_view_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_view_cancel_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_view_cancel_btn.ForeColor = System.Drawing.Color.White;
            this.admin_subject_view_cancel_btn.Location = new System.Drawing.Point(1008, 12);
            this.admin_subject_view_cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.admin_subject_view_cancel_btn.Name = "admin_subject_view_cancel_btn";
            this.admin_subject_view_cancel_btn.Size = new System.Drawing.Size(150, 45);
            this.admin_subject_view_cancel_btn.TabIndex = 42;
            this.admin_subject_view_cancel_btn.Text = "Cancel";
            this.admin_subject_view_cancel_btn.UseVisualStyleBackColor = false;
            this.admin_subject_view_cancel_btn.Click += new System.EventHandler(this.admin_subject_view_cancel_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.view_subject_refresh);
            this.panel2.Controls.Add(this.admin_subject_view_cancel_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 69);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // view_subject_refresh
            // 
            this.view_subject_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.view_subject_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_subject_refresh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_subject_refresh.ForeColor = System.Drawing.Color.White;
            this.view_subject_refresh.Location = new System.Drawing.Point(834, 12);
            this.view_subject_refresh.Name = "view_subject_refresh";
            this.view_subject_refresh.Size = new System.Drawing.Size(150, 45);
            this.view_subject_refresh.TabIndex = 68;
            this.view_subject_refresh.Text = "Refresh";
            this.view_subject_refresh.UseVisualStyleBackColor = false;
            this.view_subject_refresh.Click += new System.EventHandler(this.view_subject_refresh_Click);
            // 
            // view_header_panel
            // 
            this.view_header_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_header_panel.BackgroundImage")));
            this.view_header_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_header_panel.Controls.Add(this.appleclose);
            this.view_header_panel.Controls.Add(this.applemin);
            this.view_header_panel.Controls.Add(this.applemax);
            this.view_header_panel.Controls.Add(this.admin_view_search_id);
            this.view_header_panel.Controls.Add(this.panel1);
            this.view_header_panel.Controls.Add(this.refreshbtn);
            this.view_header_panel.Controls.Add(this.label);
            this.view_header_panel.Controls.Add(this.admin_subject_search);
            this.view_header_panel.Controls.Add(this.view_search);
            this.view_header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_header_panel.ForeColor = System.Drawing.Color.Transparent;
            this.view_header_panel.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.view_header_panel.GradientBottomRight = System.Drawing.Color.MediumSpringGreen;
            this.view_header_panel.GradientTopLeft = System.Drawing.Color.DarkSlateGray;
            this.view_header_panel.GradientTopRight = System.Drawing.Color.Aqua;
            this.view_header_panel.Location = new System.Drawing.Point(0, 0);
            this.view_header_panel.Margin = new System.Windows.Forms.Padding(4);
            this.view_header_panel.Name = "view_header_panel";
            this.view_header_panel.Quality = 10;
            this.view_header_panel.Size = new System.Drawing.Size(1180, 142);
            this.view_header_panel.TabIndex = 40;
            this.view_header_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            this.view_header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.view_header_panel_MouseDown);
            // 
            // appleclose
            // 
            this.appleclose.BackColor = System.Drawing.Color.Red;
            this.appleclose.FlatAppearance.BorderSize = 0;
            this.appleclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appleclose.ForeColor = System.Drawing.Color.White;
            this.appleclose.Location = new System.Drawing.Point(16, 12);
            this.appleclose.Name = "appleclose";
            this.appleclose.Size = new System.Drawing.Size(25, 25);
            this.appleclose.TabIndex = 61;
            this.appleclose.UseVisualStyleBackColor = false;
            this.appleclose.Click += new System.EventHandler(this.appleclose_Click);
            // 
            // applemin
            // 
            this.applemin.BackColor = System.Drawing.Color.Gold;
            this.applemin.FlatAppearance.BorderSize = 0;
            this.applemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applemin.ForeColor = System.Drawing.Color.White;
            this.applemin.Location = new System.Drawing.Point(47, 12);
            this.applemin.Name = "applemin";
            this.applemin.Size = new System.Drawing.Size(25, 25);
            this.applemin.TabIndex = 62;
            this.applemin.UseVisualStyleBackColor = false;
            this.applemin.Click += new System.EventHandler(this.applemin_Click);
            // 
            // applemax
            // 
            this.applemax.BackColor = System.Drawing.Color.LimeGreen;
            this.applemax.FlatAppearance.BorderSize = 0;
            this.applemax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applemax.ForeColor = System.Drawing.Color.White;
            this.applemax.Location = new System.Drawing.Point(78, 12);
            this.applemax.Name = "applemax";
            this.applemax.Size = new System.Drawing.Size(25, 25);
            this.applemax.TabIndex = 63;
            this.applemax.UseVisualStyleBackColor = false;
            this.applemax.Click += new System.EventHandler(this.applemax_Click);
            // 
            // admin_view_search_id
            // 
            this.admin_view_search_id.BackColor = System.Drawing.Color.Crimson;
            this.admin_view_search_id.BackgroundImage = global::sditelearning.Properties.Resources.Search_60px;
            this.admin_view_search_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_view_search_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_view_search_id.ForeColor = System.Drawing.Color.Black;
            this.admin_view_search_id.Location = new System.Drawing.Point(679, 35);
            this.admin_view_search_id.Name = "admin_view_search_id";
            this.admin_view_search_id.Size = new System.Drawing.Size(36, 36);
            this.admin_view_search_id.TabIndex = 57;
            this.admin_view_search_id.UseVisualStyleBackColor = false;
            this.admin_view_search_id.Click += new System.EventHandler(this.admin_view_search_id_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshbtn.Image = global::sditelearning.Properties.Resources.Refresh_35px_12;
            this.refreshbtn.ImageActive = null;
            this.refreshbtn.Location = new System.Drawing.Point(1114, 35);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(38, 38);
            this.refreshbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshbtn.TabIndex = 44;
            this.refreshbtn.TabStop = false;
            this.refreshbtn.Zoom = 10;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(11, 48);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 28);
            this.label.TabIndex = 25;
            this.label.Text = "Subject";
            // 
            // admin_subject_search
            // 
            this.admin_subject_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_subject_search.BackColor = System.Drawing.Color.Crimson;
            this.admin_subject_search.FlatAppearance.BorderSize = 0;
            this.admin_subject_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_subject_search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_subject_search.ForeColor = System.Drawing.Color.White;
            this.admin_subject_search.Location = new System.Drawing.Point(967, 35);
            this.admin_subject_search.Margin = new System.Windows.Forms.Padding(2);
            this.admin_subject_search.Name = "admin_subject_search";
            this.admin_subject_search.Size = new System.Drawing.Size(142, 38);
            this.admin_subject_search.TabIndex = 53;
            this.admin_subject_search.Text = "By Subject Title";
            this.admin_subject_search.UseVisualStyleBackColor = false;
            this.admin_subject_search.Click += new System.EventHandler(this.admin_subject_search_Click);
            // 
            // view_search
            // 
            this.view_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_search.ForeColor = System.Drawing.Color.Silver;
            this.view_search.Location = new System.Drawing.Point(714, 35);
            this.view_search.Margin = new System.Windows.Forms.Padding(2);
            this.view_search.Name = "view_search";
            this.view_search.Size = new System.Drawing.Size(249, 38);
            this.view_search.TabIndex = 52;
            this.view_search.Text = "Search By Id. Title";
            this.view_search.Enter += new System.EventHandler(this.view_search_Enter);
            this.view_search.Leave += new System.EventHandler(this.view_search_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.admin_subject_view_datagrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 445);
            this.panel3.TabIndex = 44;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.appleclose;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.applemin;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.applemax;
            // 
            // admin_subject_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.view_header_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_subject_view";
            this.Text = "admin_subject_view";
            this.Load += new System.EventHandler(this.admin_subject_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_subject_view_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.view_header_panel.ResumeLayout(false);
            this.view_header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid admin_subject_view_datagrid;
        private System.Windows.Forms.Button admin_subject_search;
        private System.Windows.Forms.TextBox view_search;
        private System.Windows.Forms.Label label;
        private Bunifu.Framework.UI.BunifuGradientPanel view_header_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_subject_view_cancel_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button view_subject_refresh;
        private Bunifu.Framework.UI.BunifuImageButton refreshbtn;
        private System.Windows.Forms.Button admin_view_search_id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button appleclose;
        private System.Windows.Forms.Button applemin;
        private System.Windows.Forms.Button applemax;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}