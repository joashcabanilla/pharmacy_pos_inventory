namespace PMP
{
    partial class staff_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff_form));
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.staff_account_tab = new System.Windows.Forms.TabPage();
            this.add_panel = new System.Windows.Forms.Panel();
            this.add_age = new System.Windows.Forms.Label();
            this.add_birthdate = new System.Windows.Forms.DateTimePicker();
            this.add_password = new System.Windows.Forms.TextBox();
            this.add_contactnumber = new System.Windows.Forms.TextBox();
            this.add_username = new System.Windows.Forms.TextBox();
            this.add_lastname = new System.Windows.Forms.TextBox();
            this.add_firstname = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.add_sex = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.add_label = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_panel = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.deactivated_account = new System.Windows.Forms.TabPage();
            this.deactivate_datagrid = new System.Windows.Forms.DataGridView();
            this.deactivate_search = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.admin_account_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_password = new System.Windows.Forms.TextBox();
            this.admin_username = new System.Windows.Forms.TextBox();
            this.admin_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menu_tab.SuspendLayout();
            this.staff_account_tab.SuspendLayout();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.button_panel.SuspendLayout();
            this.deactivated_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deactivate_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.admin_account_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_tab
            // 
            this.menu_tab.Controls.Add(this.staff_account_tab);
            this.menu_tab.Controls.Add(this.deactivated_account);
            this.menu_tab.Controls.Add(this.admin_account_tab);
            this.menu_tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.menu_tab.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.menu_tab.Location = new System.Drawing.Point(0, 0);
            this.menu_tab.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.menu_tab.Name = "menu_tab";
            this.menu_tab.SelectedIndex = 0;
            this.menu_tab.Size = new System.Drawing.Size(1365, 680);
            this.menu_tab.TabIndex = 1;
            this.menu_tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menu_tab_DrawItem);
            this.menu_tab.SelectedIndexChanged += new System.EventHandler(this.menu_tab_SelectedIndexChanged);
            // 
            // staff_account_tab
            // 
            this.staff_account_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.staff_account_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staff_account_tab.Controls.Add(this.add_panel);
            this.staff_account_tab.Controls.Add(this.datagrid);
            this.staff_account_tab.Controls.Add(this.search);
            this.staff_account_tab.Controls.Add(this.pictureBox1);
            this.staff_account_tab.Controls.Add(this.button_panel);
            this.staff_account_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.staff_account_tab.Location = new System.Drawing.Point(4, 42);
            this.staff_account_tab.Name = "staff_account_tab";
            this.staff_account_tab.Size = new System.Drawing.Size(1357, 634);
            this.staff_account_tab.TabIndex = 0;
            this.staff_account_tab.Text = "STAFF ACCOUNT";
            // 
            // add_panel
            // 
            this.add_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_panel.Controls.Add(this.add_age);
            this.add_panel.Controls.Add(this.add_birthdate);
            this.add_panel.Controls.Add(this.add_password);
            this.add_panel.Controls.Add(this.add_contactnumber);
            this.add_panel.Controls.Add(this.add_username);
            this.add_panel.Controls.Add(this.add_lastname);
            this.add_panel.Controls.Add(this.add_firstname);
            this.add_panel.Controls.Add(this.close);
            this.add_panel.Controls.Add(this.add_sex);
            this.add_panel.Controls.Add(this.save);
            this.add_panel.Controls.Add(this.label19);
            this.add_panel.Controls.Add(this.label21);
            this.add_panel.Controls.Add(this.label23);
            this.add_panel.Controls.Add(this.label25);
            this.add_panel.Controls.Add(this.label15);
            this.add_panel.Controls.Add(this.label17);
            this.add_panel.Controls.Add(this.label13);
            this.add_panel.Controls.Add(this.label11);
            this.add_panel.Controls.Add(this.add_label);
            this.add_panel.Location = new System.Drawing.Point(409, 102);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(635, 435);
            this.add_panel.TabIndex = 79;
            this.add_panel.Visible = false;
            // 
            // add_age
            // 
            this.add_age.BackColor = System.Drawing.SystemColors.Window;
            this.add_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_age.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_age.ForeColor = System.Drawing.SystemColors.WindowText;
            this.add_age.Location = new System.Drawing.Point(326, 187);
            this.add_age.Name = "add_age";
            this.add_age.Size = new System.Drawing.Size(280, 30);
            this.add_age.TabIndex = 85;
            // 
            // add_birthdate
            // 
            this.add_birthdate.CustomFormat = "";
            this.add_birthdate.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.add_birthdate.Location = new System.Drawing.Point(30, 257);
            this.add_birthdate.Name = "add_birthdate";
            this.add_birthdate.Size = new System.Drawing.Size(280, 30);
            this.add_birthdate.TabIndex = 79;
            this.add_birthdate.ValueChanged += new System.EventHandler(this.add_birthdate_ValueChanged);
            this.add_birthdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_birthdate_KeyPress);
            // 
            // add_password
            // 
            this.add_password.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_password.Location = new System.Drawing.Point(326, 325);
            this.add_password.Name = "add_password";
            this.add_password.Size = new System.Drawing.Size(280, 30);
            this.add_password.TabIndex = 82;
            this.add_password.UseSystemPasswordChar = true;
            // 
            // add_contactnumber
            // 
            this.add_contactnumber.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_contactnumber.Location = new System.Drawing.Point(326, 257);
            this.add_contactnumber.Name = "add_contactnumber";
            this.add_contactnumber.Size = new System.Drawing.Size(280, 30);
            this.add_contactnumber.TabIndex = 80;
            this.add_contactnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_contactnumber_KeyPress);
            // 
            // add_username
            // 
            this.add_username.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_username.Location = new System.Drawing.Point(30, 325);
            this.add_username.Name = "add_username";
            this.add_username.Size = new System.Drawing.Size(280, 30);
            this.add_username.TabIndex = 81;
            this.add_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_username_KeyPress);
            // 
            // add_lastname
            // 
            this.add_lastname.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_lastname.Location = new System.Drawing.Point(326, 118);
            this.add_lastname.Name = "add_lastname";
            this.add_lastname.Size = new System.Drawing.Size(280, 30);
            this.add_lastname.TabIndex = 76;
            this.add_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_lastname_KeyPress);
            // 
            // add_firstname
            // 
            this.add_firstname.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.add_firstname.Location = new System.Drawing.Point(30, 118);
            this.add_firstname.Name = "add_firstname";
            this.add_firstname.Size = new System.Drawing.Size(280, 30);
            this.add_firstname.TabIndex = 75;
            this.add_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_firstname_KeyPress);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Image = global::PMP.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(580, 4);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(50, 50);
            this.close.TabIndex = 74;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // add_sex
            // 
            this.add_sex.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_sex.FormattingEnabled = true;
            this.add_sex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.add_sex.Location = new System.Drawing.Point(30, 186);
            this.add_sex.Name = "add_sex";
            this.add_sex.Size = new System.Drawing.Size(280, 31);
            this.add_sex.TabIndex = 77;
            this.add_sex.Text = "-------SELECT GENDER--------";
            this.add_sex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_sex_KeyPress);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(176, 376);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(285, 40);
            this.save.TabIndex = 83;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label19.Location = new System.Drawing.Point(326, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 25);
            this.label19.TabIndex = 69;
            this.label19.Text = "Password:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label21.Location = new System.Drawing.Point(30, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 25);
            this.label21.TabIndex = 67;
            this.label21.Text = "Username:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label23.Location = new System.Drawing.Point(326, 229);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(169, 25);
            this.label23.TabIndex = 65;
            this.label23.Text = "Contact Number:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label25.Location = new System.Drawing.Point(30, 229);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 25);
            this.label25.TabIndex = 63;
            this.label25.Text = "Birthdate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label15.Location = new System.Drawing.Point(326, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 25);
            this.label15.TabIndex = 61;
            this.label15.Text = "Age:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label17.Location = new System.Drawing.Point(326, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 25);
            this.label17.TabIndex = 59;
            this.label17.Text = "Last Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label13.Location = new System.Drawing.Point(30, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 57;
            this.label13.Text = "Sex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label11.Location = new System.Drawing.Point(30, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 55;
            this.label11.Text = "First Name:";
            // 
            // add_label
            // 
            this.add_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.add_label.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.add_label.Location = new System.Drawing.Point(-2, -1);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(635, 62);
            this.add_label.TabIndex = 0;
            this.add_label.Text = "ADD STAFF ACCOUNT";
            this.add_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeight = 35;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(20, 60);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(92)))), ((int)(((byte)(60)))));
            this.datagrid.RowTemplate.Height = 35;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(1320, 550);
            this.datagrid.TabIndex = 78;
            this.datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellDoubleClick);
            this.datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_DataBindingComplete);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.Gray;
            this.search.Location = new System.Drawing.Point(53, 24);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(925, 30);
            this.search.TabIndex = 76;
            this.search.Text = "Search Staff";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMP.Properties.Resources.icons8_search_24;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.delete);
            this.button_panel.Controls.Add(this.update);
            this.button_panel.Controls.Add(this.add);
            this.button_panel.Location = new System.Drawing.Point(983, 10);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(357, 60);
            this.button_panel.TabIndex = 77;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.delete.Location = new System.Drawing.Point(210, 14);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 30);
            this.delete.TabIndex = 50;
            this.delete.Text = "DEACTIVATE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.update.Location = new System.Drawing.Point(110, 14);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(90, 30);
            this.update.TabIndex = 49;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.add.Location = new System.Drawing.Point(10, 14);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 30);
            this.add.TabIndex = 48;
            this.add.Text = "CREATE";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // deactivated_account
            // 
            this.deactivated_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.deactivated_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deactivated_account.Controls.Add(this.deactivate_datagrid);
            this.deactivated_account.Controls.Add(this.deactivate_search);
            this.deactivated_account.Controls.Add(this.pictureBox2);
            this.deactivated_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.deactivated_account.Location = new System.Drawing.Point(4, 42);
            this.deactivated_account.Name = "deactivated_account";
            this.deactivated_account.Size = new System.Drawing.Size(1357, 634);
            this.deactivated_account.TabIndex = 1;
            this.deactivated_account.Text = "STAFF ACCOUNT DEACTIVATED";
            // 
            // deactivate_datagrid
            // 
            this.deactivate_datagrid.AllowUserToAddRows = false;
            this.deactivate_datagrid.AllowUserToDeleteRows = false;
            this.deactivate_datagrid.AllowUserToResizeColumns = false;
            this.deactivate_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.deactivate_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.deactivate_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deactivate_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.deactivate_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deactivate_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deactivate_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.deactivate_datagrid.ColumnHeadersHeight = 35;
            this.deactivate_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deactivate_datagrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.deactivate_datagrid.EnableHeadersVisualStyles = false;
            this.deactivate_datagrid.GridColor = System.Drawing.Color.White;
            this.deactivate_datagrid.Location = new System.Drawing.Point(20, 60);
            this.deactivate_datagrid.MultiSelect = false;
            this.deactivate_datagrid.Name = "deactivate_datagrid";
            this.deactivate_datagrid.ReadOnly = true;
            this.deactivate_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deactivate_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.deactivate_datagrid.RowHeadersVisible = false;
            this.deactivate_datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.deactivate_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.deactivate_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.deactivate_datagrid.RowTemplate.Height = 35;
            this.deactivate_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deactivate_datagrid.Size = new System.Drawing.Size(1320, 550);
            this.deactivate_datagrid.TabIndex = 79;
            this.deactivate_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.deactivate_datagrid_DataBindingComplete);
            // 
            // deactivate_search
            // 
            this.deactivate_search.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivate_search.ForeColor = System.Drawing.Color.Gray;
            this.deactivate_search.Location = new System.Drawing.Point(53, 24);
            this.deactivate_search.Multiline = true;
            this.deactivate_search.Name = "deactivate_search";
            this.deactivate_search.Size = new System.Drawing.Size(1287, 30);
            this.deactivate_search.TabIndex = 78;
            this.deactivate_search.Text = "Search Staff";
            this.deactivate_search.TextChanged += new System.EventHandler(this.deactivate_search_TextChanged);
            this.deactivate_search.Enter += new System.EventHandler(this.deactivate_search_Enter);
            this.deactivate_search.Leave += new System.EventHandler(this.deactivate_search_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PMP.Properties.Resources.icons8_search_24;
            this.pictureBox2.Location = new System.Drawing.Point(24, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // admin_account_tab
            // 
            this.admin_account_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.admin_account_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_account_tab.Controls.Add(this.panel1);
            this.admin_account_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.admin_account_tab.Location = new System.Drawing.Point(4, 42);
            this.admin_account_tab.Name = "admin_account_tab";
            this.admin_account_tab.Size = new System.Drawing.Size(1357, 634);
            this.admin_account_tab.TabIndex = 2;
            this.admin_account_tab.Text = "ADMIN ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.admin_password);
            this.panel1.Controls.Add(this.admin_username);
            this.panel1.Controls.Add(this.admin_update);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(57, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 206);
            this.panel1.TabIndex = 80;
            // 
            // admin_password
            // 
            this.admin_password.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.admin_password.Location = new System.Drawing.Point(326, 103);
            this.admin_password.Name = "admin_password";
            this.admin_password.Size = new System.Drawing.Size(280, 30);
            this.admin_password.TabIndex = 82;
            this.admin_password.UseSystemPasswordChar = true;
            // 
            // admin_username
            // 
            this.admin_username.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.admin_username.Location = new System.Drawing.Point(30, 103);
            this.admin_username.Name = "admin_username";
            this.admin_username.Size = new System.Drawing.Size(280, 30);
            this.admin_username.TabIndex = 81;
            // 
            // admin_update
            // 
            this.admin_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.admin_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.admin_update.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.admin_update.FlatAppearance.BorderSize = 0;
            this.admin_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.admin_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.admin_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_update.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_update.ForeColor = System.Drawing.Color.White;
            this.admin_update.Location = new System.Drawing.Point(176, 153);
            this.admin_update.Name = "admin_update";
            this.admin_update.Size = new System.Drawing.Size(285, 40);
            this.admin_update.TabIndex = 83;
            this.admin_update.Text = "UPDATE";
            this.admin_update.UseVisualStyleBackColor = false;
            this.admin_update.Click += new System.EventHandler(this.admin_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(326, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Username:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.label10.Location = new System.Drawing.Point(-2, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(635, 62);
            this.label10.TabIndex = 0;
            this.label10.Text = "ADMIN ACCOUNT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staff_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1365, 680);
            this.Controls.Add(this.menu_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "staff_form";
            this.Text = "staff_form";
            this.menu_tab.ResumeLayout(false);
            this.staff_account_tab.ResumeLayout(false);
            this.staff_account_tab.PerformLayout();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.button_panel.ResumeLayout(false);
            this.deactivated_account.ResumeLayout(false);
            this.deactivated_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deactivate_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.admin_account_tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage staff_account_tab;
        public System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel button_panel;
        public System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button update;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.DataGridView datagrid;
        public System.Windows.Forms.Panel add_panel;
        public System.Windows.Forms.DateTimePicker add_birthdate;
        public System.Windows.Forms.TextBox add_password;
        public System.Windows.Forms.TextBox add_contactnumber;
        public System.Windows.Forms.TextBox add_username;
        public System.Windows.Forms.TextBox add_lastname;
        public System.Windows.Forms.TextBox add_firstname;
        private System.Windows.Forms.Button close;
        public System.Windows.Forms.ComboBox add_sex;
        public System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label add_label;
        public System.Windows.Forms.Label add_age;
        private System.Windows.Forms.TabPage deactivated_account;
        public System.Windows.Forms.TextBox deactivate_search;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView deactivate_datagrid;
        private System.Windows.Forms.TabPage admin_account_tab;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox admin_password;
        public System.Windows.Forms.TextBox admin_username;
        public System.Windows.Forms.Button admin_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;


    }
}