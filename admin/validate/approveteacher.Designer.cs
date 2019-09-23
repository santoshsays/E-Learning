namespace sditelearning
{
    partial class approveteacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.approve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.approveteachersdatgrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.admin_student_clear_btn = new System.Windows.Forms.Button();
            this.adminnewsheaderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approveteachersdatgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adminnewsheaderpanel
            // 
            this.adminnewsheaderpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminnewsheaderpanel.Controls.Add(this.label1);
            this.adminnewsheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminnewsheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.adminnewsheaderpanel.Name = "adminnewsheaderpanel";
            this.adminnewsheaderpanel.Size = new System.Drawing.Size(1200, 70);
            this.adminnewsheaderpanel.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Teachers";
            // 
            // approve
            // 
            this.approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.approve.BackColor = System.Drawing.Color.Teal;
            this.approve.FlatAppearance.BorderSize = 0;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Location = new System.Drawing.Point(917, 223);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(206, 45);
            this.approve.TabIndex = 65;
            this.approve.Text = "Validate Teachers";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 30);
            this.label2.TabIndex = 64;
            this.label2.Text = "List of Teachers Waiting For Approval";
            // 
            // approveteachersdatgrid
            // 
            this.approveteachersdatgrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.approveteachersdatgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.approveteachersdatgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approveteachersdatgrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.approveteachersdatgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.approveteachersdatgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approveteachersdatgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.approveteachersdatgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approveteachersdatgrid.DoubleBuffered = true;
            this.approveteachersdatgrid.EnableHeadersVisualStyles = false;
            this.approveteachersdatgrid.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.approveteachersdatgrid.HeaderForeColor = System.Drawing.Color.White;
            this.approveteachersdatgrid.Location = new System.Drawing.Point(83, 302);
            this.approveteachersdatgrid.Name = "approveteachersdatgrid";
            this.approveteachersdatgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.approveteachersdatgrid.RowTemplate.Height = 24;
            this.approveteachersdatgrid.Size = new System.Drawing.Size(1040, 303);
            this.approveteachersdatgrid.TabIndex = 63;
            this.approveteachersdatgrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.approveteachersdatgrid_MouseDoubleClick);
            // 
            // admin_student_clear_btn
            // 
            this.admin_student_clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_clear_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_student_clear_btn.FlatAppearance.BorderSize = 0;
            this.admin_student_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_clear_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_clear_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_clear_btn.Location = new System.Drawing.Point(684, 223);
            this.admin_student_clear_btn.Name = "admin_student_clear_btn";
            this.admin_student_clear_btn.Size = new System.Drawing.Size(215, 45);
            this.admin_student_clear_btn.TabIndex = 68;
            this.admin_student_clear_btn.Text = "Waitng for Approval";
            this.admin_student_clear_btn.UseVisualStyleBackColor = false;
            this.admin_student_clear_btn.Click += new System.EventHandler(this.admin_student_clear_btn_Click);
            // 
            // approveteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.admin_student_clear_btn);
            this.Controls.Add(this.adminnewsheaderpanel);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.approveteachersdatgrid);
            this.Name = "approveteacher";
            this.Size = new System.Drawing.Size(1200, 820);
            this.Load += new System.EventHandler(this.approveteacher_Load);
            this.adminnewsheaderpanel.ResumeLayout(false);
            this.adminnewsheaderpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approveteachersdatgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminnewsheaderpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid approveteachersdatgrid;
        private System.Windows.Forms.Button admin_student_clear_btn;
    }
}
