namespace sditelearning
{
    partial class settingsadmin
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
            this.adminnewsheaderpanel = new System.Windows.Forms.Panel();
            this.newslabel = new System.Windows.Forms.Label();
            this.newpasswordtxt = new System.Windows.Forms.TextBox();
            this.oldpasswordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.retypenewpasswordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.updatepasswordbtn = new System.Windows.Forms.Button();
            this.password_hide_visible = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminnewsheaderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminnewsheaderpanel
            // 
            this.adminnewsheaderpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminnewsheaderpanel.Controls.Add(this.newslabel);
            this.adminnewsheaderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminnewsheaderpanel.Location = new System.Drawing.Point(0, 0);
            this.adminnewsheaderpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminnewsheaderpanel.Name = "adminnewsheaderpanel";
            this.adminnewsheaderpanel.Size = new System.Drawing.Size(1200, 76);
            this.adminnewsheaderpanel.TabIndex = 27;
            this.adminnewsheaderpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminnewsheaderpanel_Paint);
            // 
            // newslabel
            // 
            this.newslabel.AutoSize = true;
            this.newslabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newslabel.Location = new System.Drawing.Point(20, 18);
            this.newslabel.Name = "newslabel";
            this.newslabel.Size = new System.Drawing.Size(104, 30);
            this.newslabel.TabIndex = 25;
            this.newslabel.Text = "Settings";
            // 
            // newpasswordtxt
            // 
            this.newpasswordtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.newpasswordtxt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordtxt.Location = new System.Drawing.Point(424, 320);
            this.newpasswordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newpasswordtxt.Name = "newpasswordtxt";
            this.newpasswordtxt.PasswordChar = '*';
            this.newpasswordtxt.Size = new System.Drawing.Size(400, 34);
            this.newpasswordtxt.TabIndex = 32;
            // 
            // oldpasswordtxt
            // 
            this.oldpasswordtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oldpasswordtxt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpasswordtxt.Location = new System.Drawing.Point(424, 246);
            this.oldpasswordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldpasswordtxt.Name = "oldpasswordtxt";
            this.oldpasswordtxt.PasswordChar = '*';
            this.oldpasswordtxt.Size = new System.Drawing.Size(400, 34);
            this.oldpasswordtxt.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "New password";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Change Settings";
            // 
            // retypenewpasswordtxt
            // 
            this.retypenewpasswordtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retypenewpasswordtxt.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypenewpasswordtxt.Location = new System.Drawing.Point(424, 389);
            this.retypenewpasswordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retypenewpasswordtxt.Name = "retypenewpasswordtxt";
            this.retypenewpasswordtxt.PasswordChar = '*';
            this.retypenewpasswordtxt.Size = new System.Drawing.Size(400, 34);
            this.retypenewpasswordtxt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Retype new password";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelbtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(688, 502);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(136, 46);
            this.cancelbtn.TabIndex = 35;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // updatepasswordbtn
            // 
            this.updatepasswordbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updatepasswordbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatepasswordbtn.FlatAppearance.BorderSize = 0;
            this.updatepasswordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatepasswordbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepasswordbtn.ForeColor = System.Drawing.Color.White;
            this.updatepasswordbtn.Location = new System.Drawing.Point(424, 502);
            this.updatepasswordbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updatepasswordbtn.Name = "updatepasswordbtn";
            this.updatepasswordbtn.Size = new System.Drawing.Size(193, 46);
            this.updatepasswordbtn.TabIndex = 35;
            this.updatepasswordbtn.Text = "Update Password";
            this.updatepasswordbtn.UseVisualStyleBackColor = false;
            this.updatepasswordbtn.Click += new System.EventHandler(this.updatepasswordbtn_Click);
            // 
            // password_hide_visible
            // 
            this.password_hide_visible.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_hide_visible.BackColor = System.Drawing.Color.White;
            this.password_hide_visible.BackgroundImage = global::sditelearning.Properties.Resources.Eye_25px1;
            this.password_hide_visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_hide_visible.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.password_hide_visible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_hide_visible.ForeColor = System.Drawing.Color.White;
            this.password_hide_visible.Location = new System.Drawing.Point(789, 322);
            this.password_hide_visible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_hide_visible.Name = "password_hide_visible";
            this.password_hide_visible.Size = new System.Drawing.Size(30, 30);
            this.password_hide_visible.TabIndex = 93;
            this.password_hide_visible.UseVisualStyleBackColor = false;
            this.password_hide_visible.MouseLeave += new System.EventHandler(this.password_hide_visible_MouseLeave);
            this.password_hide_visible.MouseHover += new System.EventHandler(this.password_hide_visible_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::sditelearning.Properties.Resources.Eye_25px1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(790, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 93;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // settingsadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_hide_visible);
            this.Controls.Add(this.updatepasswordbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.retypenewpasswordtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newpasswordtxt);
            this.Controls.Add(this.oldpasswordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminnewsheaderpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "settingsadmin";
            this.Size = new System.Drawing.Size(1200, 720);
            this.Load += new System.EventHandler(this.settingsadmin_Load);
            this.adminnewsheaderpanel.ResumeLayout(false);
            this.adminnewsheaderpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminnewsheaderpanel;
        private System.Windows.Forms.Label newslabel;
        private System.Windows.Forms.TextBox newpasswordtxt;
        private System.Windows.Forms.TextBox oldpasswordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox retypenewpasswordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button updatepasswordbtn;
        private System.Windows.Forms.Button password_hide_visible;
        private System.Windows.Forms.Button button1;
    }
}
