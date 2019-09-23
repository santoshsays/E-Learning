namespace sditelearning
{
    partial class help
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
            this.adminheader = new System.Windows.Forms.Panel();
            this.appleclose = new System.Windows.Forms.Button();
            this.applemin = new System.Windows.Forms.Button();
            this.applemax = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminheader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminheader
            // 
            this.adminheader.BackColor = System.Drawing.Color.Teal;
            this.adminheader.Controls.Add(this.appleclose);
            this.adminheader.Controls.Add(this.applemin);
            this.adminheader.Controls.Add(this.applemax);
            this.adminheader.Controls.Add(this.label3);
            this.adminheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminheader.Location = new System.Drawing.Point(0, 0);
            this.adminheader.Name = "adminheader";
            this.adminheader.Size = new System.Drawing.Size(1182, 40);
            this.adminheader.TabIndex = 11;
            // 
            // appleclose
            // 
            this.appleclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appleclose.BackColor = System.Drawing.Color.Red;
            this.appleclose.FlatAppearance.BorderSize = 0;
            this.appleclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appleclose.ForeColor = System.Drawing.Color.White;
            this.appleclose.Location = new System.Drawing.Point(1149, 9);
            this.appleclose.Name = "appleclose";
            this.appleclose.Size = new System.Drawing.Size(25, 25);
            this.appleclose.TabIndex = 14;
            this.appleclose.UseVisualStyleBackColor = false;
            this.appleclose.Click += new System.EventHandler(this.appleclose_Click);
            // 
            // applemin
            // 
            this.applemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applemin.BackColor = System.Drawing.Color.Gold;
            this.applemin.FlatAppearance.BorderSize = 0;
            this.applemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applemin.ForeColor = System.Drawing.Color.White;
            this.applemin.Location = new System.Drawing.Point(1118, 9);
            this.applemin.Name = "applemin";
            this.applemin.Size = new System.Drawing.Size(25, 25);
            this.applemin.TabIndex = 15;
            this.applemin.UseVisualStyleBackColor = false;
            this.applemin.Click += new System.EventHandler(this.applemin_Click);
            // 
            // applemax
            // 
            this.applemax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applemax.BackColor = System.Drawing.Color.LimeGreen;
            this.applemax.FlatAppearance.BorderSize = 0;
            this.applemax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applemax.ForeColor = System.Drawing.Color.White;
            this.applemax.Location = new System.Drawing.Point(1083, 9);
            this.applemax.Name = "applemax";
            this.applemax.Size = new System.Drawing.Size(25, 25);
            this.applemax.TabIndex = 16;
            this.applemax.UseVisualStyleBackColor = false;
            this.applemax.Click += new System.EventHandler(this.applemax_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "SDIT E-Learning";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.appleclose;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.applemax;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.applemin;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Location = new System.Drawing.Point(426, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 37);
            this.panel1.TabIndex = 13;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 4);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(416, 33);
            this.bunifuMaterialTextbox1.TabIndex = 14;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::sditelearning.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "help";
            this.adminheader.ResumeLayout(false);
            this.adminheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminheader;
        private System.Windows.Forms.Button appleclose;
        private System.Windows.Forms.Button applemin;
        private System.Windows.Forms.Button applemax;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}