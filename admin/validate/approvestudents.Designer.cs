namespace sditelearning
{
    partial class approvestudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.approve = new System.Windows.Forms.Button();
            this.approvestudentdatagird = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.adminnewsheaderpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_student_clear_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.approvestudentdatagird)).BeginInit();
            this.adminnewsheaderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // approve
            // 
            this.approve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.approve.BackColor = System.Drawing.Color.Teal;
            this.approve.FlatAppearance.BorderSize = 0;
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Location = new System.Drawing.Point(936, 188);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(187, 45);
            this.approve.TabIndex = 60;
            this.approve.Text = "Validate Student";
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // approvestudentdatagird
            // 
            this.approvestudentdatagird.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.approvestudentdatagird.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.approvestudentdatagird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approvestudentdatagird.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.approvestudentdatagird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.approvestudentdatagird.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approvestudentdatagird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.approvestudentdatagird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvestudentdatagird.DoubleBuffered = true;
            this.approvestudentdatagird.EnableHeadersVisualStyles = false;
            this.approvestudentdatagird.HeaderBgColor = System.Drawing.SystemColors.Highlight;
            this.approvestudentdatagird.HeaderForeColor = System.Drawing.Color.White;
            this.approvestudentdatagird.Location = new System.Drawing.Point(83, 258);
            this.approvestudentdatagird.Name = "approvestudentdatagird";
            this.approvestudentdatagird.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.approvestudentdatagird.RowTemplate.Height = 24;
            this.approvestudentdatagird.Size = new System.Drawing.Size(1040, 303);
            this.approvestudentdatagird.TabIndex = 58;
            this.approvestudentdatagird.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.approvestudentdatagird_MouseDoubleClick);
            // 
            // adminnewsheaderpanel
            // 
            this.adminnewsheaderpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminnewsheaderpanel.Controls.Add(this.label1);
            this.adminnewsheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminnewsheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.adminnewsheaderpanel.Name = "adminnewsheaderpanel";
            this.adminnewsheaderpanel.Size = new System.Drawing.Size(1200, 70);
            this.adminnewsheaderpanel.TabIndex = 62;
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
            // admin_student_clear_btn
            // 
            this.admin_student_clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.admin_student_clear_btn.BackColor = System.Drawing.Color.Crimson;
            this.admin_student_clear_btn.FlatAppearance.BorderSize = 0;
            this.admin_student_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_student_clear_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_student_clear_btn.ForeColor = System.Drawing.Color.White;
            this.admin_student_clear_btn.Location = new System.Drawing.Point(706, 188);
            this.admin_student_clear_btn.Name = "admin_student_clear_btn";
            this.admin_student_clear_btn.Size = new System.Drawing.Size(215, 45);
            this.admin_student_clear_btn.TabIndex = 61;
            this.admin_student_clear_btn.Text = "Waitng for Approval";
            this.admin_student_clear_btn.UseVisualStyleBackColor = false;
            this.admin_student_clear_btn.Click += new System.EventHandler(this.admin_student_clear_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 30);
            this.label3.TabIndex = 63;
            this.label3.Text = "List of Student Waiting for approval ";
            // 
            // approvestudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminnewsheaderpanel);
            this.Controls.Add(this.admin_student_clear_btn);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.approvestudentdatagird);
            this.Name = "approvestudents";
            this.Size = new System.Drawing.Size(1200, 820);
            this.Load += new System.EventHandler(this.approvestudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.approvestudentdatagird)).EndInit();
            this.adminnewsheaderpanel.ResumeLayout(false);
            this.adminnewsheaderpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button approve;
        private Bunifu.Framework.UI.BunifuCustomDataGrid approvestudentdatagird;
        private System.Windows.Forms.Panel adminnewsheaderpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin_student_clear_btn;
        private System.Windows.Forms.Label label3;
    }
}
