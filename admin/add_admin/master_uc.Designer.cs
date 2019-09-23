namespace sditelearning
{
    partial class master_uc
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.password_hide_visible = new System.Windows.Forms.Button();
            this.mcancel = new System.Windows.Forms.Button();
            this.msubmit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainpanel.Controls.Add(this.password_hide_visible);
            this.mainpanel.Controls.Add(this.mcancel);
            this.mainpanel.Controls.Add(this.msubmit);
            this.mainpanel.Controls.Add(this.panel6);
            this.mainpanel.Controls.Add(this.mtextBox);
            this.mainpanel.Controls.Add(this.label3);
            this.mainpanel.Location = new System.Drawing.Point(532, 187);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(664, 393);
            this.mainpanel.TabIndex = 3;
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
            this.password_hide_visible.Location = new System.Drawing.Point(420, 197);
            this.password_hide_visible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_hide_visible.Name = "password_hide_visible";
            this.password_hide_visible.Size = new System.Drawing.Size(28, 27);
            this.password_hide_visible.TabIndex = 25;
            this.password_hide_visible.UseVisualStyleBackColor = false;
            this.password_hide_visible.MouseLeave += new System.EventHandler(this.password_hide_visible_MouseLeave);
            this.password_hide_visible.MouseHover += new System.EventHandler(this.password_hide_visible_MouseHover);
            // 
            // mcancel
            // 
            this.mcancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mcancel.BackColor = System.Drawing.Color.Crimson;
            this.mcancel.FlatAppearance.BorderSize = 0;
            this.mcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcancel.ForeColor = System.Drawing.Color.White;
            this.mcancel.Location = new System.Drawing.Point(469, 310);
            this.mcancel.Name = "mcancel";
            this.mcancel.Size = new System.Drawing.Size(133, 38);
            this.mcancel.TabIndex = 3;
            this.mcancel.Text = "Cancel";
            this.mcancel.UseVisualStyleBackColor = false;
            this.mcancel.Click += new System.EventHandler(this.mcancel_Click);
            // 
            // msubmit
            // 
            this.msubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msubmit.BackColor = System.Drawing.Color.Teal;
            this.msubmit.FlatAppearance.BorderSize = 0;
            this.msubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msubmit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msubmit.ForeColor = System.Drawing.Color.White;
            this.msubmit.Location = new System.Drawing.Point(322, 310);
            this.msubmit.Name = "msubmit";
            this.msubmit.Size = new System.Drawing.Size(133, 38);
            this.msubmit.TabIndex = 3;
            this.msubmit.Text = "Submit";
            this.msubmit.UseVisualStyleBackColor = false;
            this.msubmit.Click += new System.EventHandler(this.msubmit_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(664, 84);
            this.panel6.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Do You want to add a New Admin ?";
            // 
            // mtextBox
            // 
            this.mtextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.mtextBox.Location = new System.Drawing.Point(92, 194);
            this.mtextBox.Name = "mtextBox";
            this.mtextBox.Size = new System.Drawing.Size(363, 38);
            this.mtextBox.TabIndex = 0;
            this.mtextBox.Text = "Password";
            this.mtextBox.Enter += new System.EventHandler(this.mtextBox_Enter);
            this.mtextBox.Leave += new System.EventHandler(this.mtextBox_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Master Password";
            // 
            // master_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainpanel);
            this.Name = "master_uc";
            this.Size = new System.Drawing.Size(1620, 760);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button password_hide_visible;
        private System.Windows.Forms.Button mcancel;
        private System.Windows.Forms.Button msubmit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mtextBox;
        private System.Windows.Forms.Label label3;
    }
}
