namespace PMP
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.exit = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.exit.Location = new System.Drawing.Point(636, 503);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(350, 50);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.login_button.Location = new System.Drawing.Point(26, 503);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(350, 50);
            this.login_button.TabIndex = 10;
            this.login_button.Text = "Click Here to Login ";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::PMP.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(273, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(500, 500);
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logo2.Image = global::PMP.Properties.Resources.logo;
            this.logo2.Location = new System.Drawing.Point(142, 6);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(500, 500);
            this.logo2.TabIndex = 13;
            this.logo2.TabStop = false;
            this.logo2.Visible = false;
            // 
            // login_panel
            // 
            this.login_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.login_panel.Controls.Add(this.cancel);
            this.login_panel.Controls.Add(this.login);
            this.login_panel.Controls.Add(this.show_password);
            this.login_panel.Controls.Add(this.pictureBox2);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.time);
            this.login_panel.Controls.Add(this.date);
            this.login_panel.Controls.Add(this.pictureBox3);
            this.login_panel.Controls.Add(this.password);
            this.login_panel.Controls.Add(this.username);
            this.login_panel.Location = new System.Drawing.Point(407, 89);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(399, 315);
            this.login_panel.TabIndex = 14;
            this.login_panel.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(241, 250);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 37);
            this.cancel.TabIndex = 31;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(78, 250);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(97, 37);
            this.login.TabIndex = 20;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // show_password
            // 
            this.show_password.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_password.AutoSize = true;
            this.show_password.BackColor = System.Drawing.Color.Transparent;
            this.show_password.FlatAppearance.BorderSize = 0;
            this.show_password.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.show_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.show_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_password.Image = global::PMP.Properties.Resources.icons8_eye_20__1_;
            this.show_password.Location = new System.Drawing.Point(342, 183);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(26, 26);
            this.show_password.TabIndex = 25;
            this.show_password.UseVisualStyleBackColor = false;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PMP.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(43, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "PMP LOGIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(215, 84);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(63, 24);
            this.time.TabIndex = 27;
            this.time.Text = "TIME";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(77, 84);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(65, 24);
            this.date.TabIndex = 26;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PMP.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(43, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(78, 181);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(263, 29);
            this.password.TabIndex = 22;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.username.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(78, 138);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(263, 29);
            this.username.TabIndex = 21;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1014, 588);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.Text = "Login_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button login_button;
        public System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.PictureBox logo2;
        public System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Timer timer;
    }
}

