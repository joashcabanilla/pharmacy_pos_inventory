namespace PMP
{
    partial class admin_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_control));
            this.label_form = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.form_panel = new System.Windows.Forms.Panel();
            this.menu_logo = new System.Windows.Forms.Panel();
            this.menu_button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.maintenance = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.staff_account = new System.Windows.Forms.Button();
            this.medicine_inventory = new System.Windows.Forms.Button();
            this.menu_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_form
            // 
            this.label_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.label_form.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label_form.Location = new System.Drawing.Point(0, 0);
            this.label_form.Name = "label_form";
            this.label_form.Size = new System.Drawing.Size(1261, 90);
            this.label_form.TabIndex = 2;
            this.label_form.Text = "ADMIN DATABASE";
            this.label_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.time.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.time.Location = new System.Drawing.Point(1013, 48);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(198, 24);
            this.time.TabIndex = 31;
            this.time.Text = "TIME";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.date.Location = new System.Drawing.Point(1013, 19);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(198, 24);
            this.date.TabIndex = 30;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // form_panel
            // 
            this.form_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.form_panel.Location = new System.Drawing.Point(0, 90);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(1260, 610);
            this.form_panel.TabIndex = 33;
            // 
            // menu_logo
            // 
            this.menu_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.menu_logo.Controls.Add(this.menu_button);
            this.menu_logo.Controls.Add(this.logo);
            this.menu_logo.Location = new System.Drawing.Point(0, 0);
            this.menu_logo.Name = "menu_logo";
            this.menu_logo.Size = new System.Drawing.Size(217, 90);
            this.menu_logo.TabIndex = 34;
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.menu_button.FlatAppearance.BorderSize = 0;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25F, System.Drawing.FontStyle.Bold);
            this.menu_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.menu_button.Image = global::PMP.Properties.Resources.menu;
            this.menu_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_button.Location = new System.Drawing.Point(88, 0);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(125, 90);
            this.menu_button.TabIndex = 34;
            this.menu_button.Text = "MENU";
            this.menu_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.logo.Image = global::PMP.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(5, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(80, 80);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 33;
            this.logo.TabStop = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.menu_panel.Controls.Add(this.maintenance);
            this.menu_panel.Controls.Add(this.logout);
            this.menu_panel.Controls.Add(this.sales);
            this.menu_panel.Controls.Add(this.staff_account);
            this.menu_panel.Controls.Add(this.medicine_inventory);
            this.menu_panel.Location = new System.Drawing.Point(0, 90);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(217, 478);
            this.menu_panel.TabIndex = 36;
            // 
            // maintenance
            // 
            this.maintenance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.maintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.maintenance.FlatAppearance.BorderSize = 0;
            this.maintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maintenance.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.maintenance.Image = global::PMP.Properties.Resources.maintenance_icon;
            this.maintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintenance.Location = new System.Drawing.Point(9, 282);
            this.maintenance.Name = "maintenance";
            this.maintenance.Size = new System.Drawing.Size(200, 92);
            this.maintenance.TabIndex = 33;
            this.maintenance.Text = "Maintenance";
            this.maintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.maintenance.UseVisualStyleBackColor = false;
            this.maintenance.Click += new System.EventHandler(this.maintenance_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.logout.Image = global::PMP.Properties.Resources.icon_logout;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(9, 375);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(200, 92);
            this.logout.TabIndex = 32;
            this.logout.Text = "  LOGOUT";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // sales
            // 
            this.sales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.sales.FlatAppearance.BorderSize = 0;
            this.sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.sales.Image = global::PMP.Properties.Resources.icon_transaction;
            this.sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales.Location = new System.Drawing.Point(9, 189);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(200, 92);
            this.sales.TabIndex = 31;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // staff_account
            // 
            this.staff_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.staff_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.staff_account.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.staff_account.FlatAppearance.BorderSize = 0;
            this.staff_account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.staff_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_account.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.staff_account.Image = global::PMP.Properties.Resources.icon_staff;
            this.staff_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_account.Location = new System.Drawing.Point(9, 96);
            this.staff_account.Name = "staff_account";
            this.staff_account.Size = new System.Drawing.Size(200, 92);
            this.staff_account.TabIndex = 30;
            this.staff_account.Text = "Manage Account";
            this.staff_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staff_account.UseVisualStyleBackColor = false;
            this.staff_account.Click += new System.EventHandler(this.staff_account_Click);
            // 
            // medicine_inventory
            // 
            this.medicine_inventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicine_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.medicine_inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.medicine_inventory.FlatAppearance.BorderSize = 0;
            this.medicine_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.medicine_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicine_inventory.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.medicine_inventory.Image = global::PMP.Properties.Resources.icon_medicine;
            this.medicine_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicine_inventory.Location = new System.Drawing.Point(9, 3);
            this.medicine_inventory.Name = "medicine_inventory";
            this.medicine_inventory.Size = new System.Drawing.Size(200, 92);
            this.medicine_inventory.TabIndex = 3;
            this.medicine_inventory.Text = "Medicine Inventory";
            this.medicine_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.medicine_inventory.UseVisualStyleBackColor = false;
            this.medicine_inventory.Click += new System.EventHandler(this.medicine_inventory_Click);
            // 
            // admin_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1260, 700);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.menu_logo);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label_form);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_control";
            this.Text = "admin_control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_control_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.admin_control_KeyDown);
            this.menu_logo.ResumeLayout(false);
            this.menu_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_form;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Panel menu_logo;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button staff_account;
        private System.Windows.Forms.Button medicine_inventory;
        private System.Windows.Forms.Button maintenance;
    }
}