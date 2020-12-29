namespace PMP
{
    partial class sales_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_form));
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.sales_tab = new System.Windows.Forms.TabPage();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.print = new System.Windows.Forms.Button();
            this.total_sales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transaction_number = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.annually = new System.Windows.Forms.Button();
            this.monthly = new System.Windows.Forms.Button();
            this.weekly = new System.Windows.Forms.Button();
            this.daily = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.date_panel = new System.Windows.Forms.Panel();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.sold_tab = new System.Windows.Forms.TabPage();
            this.sold_print = new System.Windows.Forms.Button();
            this.sold_total_sales = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sold_number = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sold_datagrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sold_annually = new System.Windows.Forms.Button();
            this.sold_monthly = new System.Windows.Forms.Button();
            this.sold_weekly = new System.Windows.Forms.Button();
            this.sold_daily = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sold_date_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.sold_date_from = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.menu_tab.SuspendLayout();
            this.sales_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.date_panel.SuspendLayout();
            this.sold_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sold_datagrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_tab
            // 
            this.menu_tab.Controls.Add(this.sales_tab);
            this.menu_tab.Controls.Add(this.sold_tab);
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
            // sales_tab
            // 
            this.sales_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.sales_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sales_tab.Controls.Add(this.datagrid);
            this.sales_tab.Controls.Add(this.print);
            this.sales_tab.Controls.Add(this.total_sales);
            this.sales_tab.Controls.Add(this.label4);
            this.sales_tab.Controls.Add(this.transaction_number);
            this.sales_tab.Controls.Add(this.label9);
            this.sales_tab.Controls.Add(this.panel1);
            this.sales_tab.Controls.Add(this.label28);
            this.sales_tab.Controls.Add(this.date_panel);
            this.sales_tab.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.sales_tab.Location = new System.Drawing.Point(4, 42);
            this.sales_tab.Margin = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.sales_tab.Name = "sales_tab";
            this.sales_tab.Padding = new System.Windows.Forms.Padding(12, 17, 12, 17);
            this.sales_tab.Size = new System.Drawing.Size(1357, 634);
            this.sales_tab.TabIndex = 0;
            this.sales_tab.Text = "SALES REPORT";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeight = 35;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(20, 150);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.RowTemplate.Height = 35;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(1320, 410);
            this.datagrid.TabIndex = 119;
            this.datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellDoubleClick);
            this.datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_DataBindingComplete);
            // 
            // print
            // 
            this.print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.print.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.print.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Location = new System.Drawing.Point(833, 575);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(180, 35);
            this.print.TabIndex = 118;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // total_sales
            // 
            this.total_sales.BackColor = System.Drawing.Color.Transparent;
            this.total_sales.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_sales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.total_sales.Location = new System.Drawing.Point(626, 578);
            this.total_sales.Name = "total_sales";
            this.total_sales.Size = new System.Drawing.Size(180, 30);
            this.total_sales.TabIndex = 116;
            this.total_sales.Text = "0";
            this.total_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(491, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 117;
            this.label4.Text = "Total Sales:";
            // 
            // transaction_number
            // 
            this.transaction_number.BackColor = System.Drawing.Color.Transparent;
            this.transaction_number.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_number.ForeColor = System.Drawing.SystemColors.WindowText;
            this.transaction_number.Location = new System.Drawing.Point(282, 578);
            this.transaction_number.Name = "transaction_number";
            this.transaction_number.Size = new System.Drawing.Size(165, 30);
            this.transaction_number.TabIndex = 114;
            this.transaction_number.Text = "0";
            this.transaction_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label9.Location = new System.Drawing.Point(19, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 29);
            this.label9.TabIndex = 115;
            this.label9.Text = "Number Of Transaction:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.annually);
            this.panel1.Controls.Add(this.monthly);
            this.panel1.Controls.Add(this.weekly);
            this.panel1.Controls.Add(this.daily);
            this.panel1.Location = new System.Drawing.Point(717, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 110);
            this.panel1.TabIndex = 112;
            // 
            // annually
            // 
            this.annually.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.annually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.annually.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.annually.FlatAppearance.BorderSize = 0;
            this.annually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.annually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annually.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.7F, System.Drawing.FontStyle.Bold);
            this.annually.Image = global::PMP.Properties.Resources.annually;
            this.annually.Location = new System.Drawing.Point(468, 5);
            this.annually.Name = "annually";
            this.annually.Size = new System.Drawing.Size(135, 95);
            this.annually.TabIndex = 114;
            this.annually.Text = "ANNUALLY SALES";
            this.annually.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.annually.UseVisualStyleBackColor = false;
            this.annually.Click += new System.EventHandler(this.anually_Click);
            // 
            // monthly
            // 
            this.monthly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.monthly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.monthly.FlatAppearance.BorderSize = 0;
            this.monthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthly.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.monthly.Image = global::PMP.Properties.Resources.monthly;
            this.monthly.Location = new System.Drawing.Point(318, 5);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(135, 95);
            this.monthly.TabIndex = 113;
            this.monthly.Text = "MONTHLY SALES";
            this.monthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.monthly.UseVisualStyleBackColor = false;
            this.monthly.Click += new System.EventHandler(this.monthly_Click);
            // 
            // weekly
            // 
            this.weekly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.weekly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.weekly.FlatAppearance.BorderSize = 0;
            this.weekly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.weekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekly.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.weekly.Image = global::PMP.Properties.Resources.weekly;
            this.weekly.Location = new System.Drawing.Point(168, 5);
            this.weekly.Name = "weekly";
            this.weekly.Size = new System.Drawing.Size(135, 95);
            this.weekly.TabIndex = 112;
            this.weekly.Text = "WEEKLY SALES";
            this.weekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.weekly.UseVisualStyleBackColor = false;
            this.weekly.Click += new System.EventHandler(this.weekly_Click);
            // 
            // daily
            // 
            this.daily.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.daily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.daily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.daily.FlatAppearance.BorderSize = 0;
            this.daily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daily.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.daily.Image = global::PMP.Properties.Resources.daily;
            this.daily.Location = new System.Drawing.Point(18, 5);
            this.daily.Name = "daily";
            this.daily.Size = new System.Drawing.Size(135, 95);
            this.daily.TabIndex = 111;
            this.daily.Text = "DAILY SALES";
            this.daily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.daily.UseVisualStyleBackColor = false;
            this.daily.Click += new System.EventHandler(this.daily_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label28.Location = new System.Drawing.Point(28, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(160, 29);
            this.label28.TabIndex = 110;
            this.label28.Text = "SELECT DATE";
            // 
            // date_panel
            // 
            this.date_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_panel.Controls.Add(this.date_to);
            this.date_panel.Controls.Add(this.label1);
            this.date_panel.Controls.Add(this.date_from);
            this.date_panel.Controls.Add(this.label3);
            this.date_panel.Location = new System.Drawing.Point(20, 42);
            this.date_panel.Name = "date_panel";
            this.date_panel.Size = new System.Drawing.Size(681, 77);
            this.date_panel.TabIndex = 109;
            // 
            // date_to
            // 
            this.date_to.CustomFormat = "";
            this.date_to.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_to.Location = new System.Drawing.Point(405, 24);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(252, 30);
            this.date_to.TabIndex = 98;
            this.date_to.ValueChanged += new System.EventHandler(this.date_to_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(360, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "TO:";
            // 
            // date_from
            // 
            this.date_from.CustomFormat = "dd/M/yyyy";
            this.date_from.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_from.Location = new System.Drawing.Point(87, 24);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(252, 30);
            this.date_from.TabIndex = 96;
            this.date_from.ValueChanged += new System.EventHandler(this.date_from_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "FROM:";
            // 
            // sold_tab
            // 
            this.sold_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.sold_tab.Controls.Add(this.sold_print);
            this.sold_tab.Controls.Add(this.sold_total_sales);
            this.sold_tab.Controls.Add(this.label8);
            this.sold_tab.Controls.Add(this.sold_number);
            this.sold_tab.Controls.Add(this.label11);
            this.sold_tab.Controls.Add(this.sold_datagrid);
            this.sold_tab.Controls.Add(this.panel3);
            this.sold_tab.Controls.Add(this.label2);
            this.sold_tab.Controls.Add(this.panel2);
            this.sold_tab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.sold_tab.Location = new System.Drawing.Point(4, 42);
            this.sold_tab.Name = "sold_tab";
            this.sold_tab.Size = new System.Drawing.Size(1357, 634);
            this.sold_tab.TabIndex = 1;
            this.sold_tab.Text = "MEDICINE SOLD";
            // 
            // sold_print
            // 
            this.sold_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sold_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.sold_print.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.sold_print.FlatAppearance.BorderSize = 0;
            this.sold_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sold_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sold_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sold_print.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_print.ForeColor = System.Drawing.Color.White;
            this.sold_print.Location = new System.Drawing.Point(833, 575);
            this.sold_print.Name = "sold_print";
            this.sold_print.Size = new System.Drawing.Size(180, 35);
            this.sold_print.TabIndex = 125;
            this.sold_print.Text = "PRINT";
            this.sold_print.UseVisualStyleBackColor = false;
            this.sold_print.Click += new System.EventHandler(this.sold_print_Click);
            // 
            // sold_total_sales
            // 
            this.sold_total_sales.BackColor = System.Drawing.Color.Transparent;
            this.sold_total_sales.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_total_sales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sold_total_sales.Location = new System.Drawing.Point(626, 578);
            this.sold_total_sales.Name = "sold_total_sales";
            this.sold_total_sales.Size = new System.Drawing.Size(180, 30);
            this.sold_total_sales.TabIndex = 123;
            this.sold_total_sales.Text = "0";
            this.sold_total_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label8.Location = new System.Drawing.Point(491, 577);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 29);
            this.label8.TabIndex = 124;
            this.label8.Text = "Total Sales:";
            // 
            // sold_number
            // 
            this.sold_number.BackColor = System.Drawing.Color.Transparent;
            this.sold_number.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_number.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sold_number.Location = new System.Drawing.Point(310, 578);
            this.sold_number.Name = "sold_number";
            this.sold_number.Size = new System.Drawing.Size(165, 30);
            this.sold_number.TabIndex = 121;
            this.sold_number.Text = "0";
            this.sold_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label11.Location = new System.Drawing.Point(19, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(289, 29);
            this.label11.TabIndex = 122;
            this.label11.Text = "Number Of Medicine Sold:";
            // 
            // sold_datagrid
            // 
            this.sold_datagrid.AllowUserToAddRows = false;
            this.sold_datagrid.AllowUserToDeleteRows = false;
            this.sold_datagrid.AllowUserToResizeColumns = false;
            this.sold_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.sold_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.sold_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sold_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.sold_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sold_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sold_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.sold_datagrid.ColumnHeadersHeight = 40;
            this.sold_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(152)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sold_datagrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.sold_datagrid.EnableHeadersVisualStyles = false;
            this.sold_datagrid.GridColor = System.Drawing.Color.White;
            this.sold_datagrid.Location = new System.Drawing.Point(20, 150);
            this.sold_datagrid.MultiSelect = false;
            this.sold_datagrid.Name = "sold_datagrid";
            this.sold_datagrid.ReadOnly = true;
            this.sold_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sold_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.sold_datagrid.RowHeadersVisible = false;
            this.sold_datagrid.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.sold_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.sold_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.sold_datagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.sold_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_datagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.sold_datagrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.sold_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(206)))), ((int)(((byte)(193)))));
            this.sold_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sold_datagrid.RowTemplate.Height = 40;
            this.sold_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sold_datagrid.Size = new System.Drawing.Size(1320, 410);
            this.sold_datagrid.TabIndex = 120;
            this.sold_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sold_datagrid_CellDoubleClick);
            this.sold_datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.sold_datagrid_DataBindingComplete);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sold_annually);
            this.panel3.Controls.Add(this.sold_monthly);
            this.panel3.Controls.Add(this.sold_weekly);
            this.panel3.Controls.Add(this.sold_daily);
            this.panel3.Location = new System.Drawing.Point(717, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 110);
            this.panel3.TabIndex = 113;
            // 
            // sold_annually
            // 
            this.sold_annually.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sold_annually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.sold_annually.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.sold_annually.FlatAppearance.BorderSize = 0;
            this.sold_annually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.sold_annually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sold_annually.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.7F, System.Drawing.FontStyle.Bold);
            this.sold_annually.Image = global::PMP.Properties.Resources.annually;
            this.sold_annually.Location = new System.Drawing.Point(468, 5);
            this.sold_annually.Name = "sold_annually";
            this.sold_annually.Size = new System.Drawing.Size(135, 95);
            this.sold_annually.TabIndex = 114;
            this.sold_annually.Text = "ANNUALLY SALES";
            this.sold_annually.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sold_annually.UseVisualStyleBackColor = false;
            this.sold_annually.Click += new System.EventHandler(this.sold_annually_Click);
            // 
            // sold_monthly
            // 
            this.sold_monthly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sold_monthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.sold_monthly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.sold_monthly.FlatAppearance.BorderSize = 0;
            this.sold_monthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.sold_monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sold_monthly.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.sold_monthly.Image = global::PMP.Properties.Resources.monthly;
            this.sold_monthly.Location = new System.Drawing.Point(318, 5);
            this.sold_monthly.Name = "sold_monthly";
            this.sold_monthly.Size = new System.Drawing.Size(135, 95);
            this.sold_monthly.TabIndex = 113;
            this.sold_monthly.Text = "MONTHLY SALES";
            this.sold_monthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sold_monthly.UseVisualStyleBackColor = false;
            this.sold_monthly.Click += new System.EventHandler(this.sold_monthly_Click);
            // 
            // sold_weekly
            // 
            this.sold_weekly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sold_weekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.sold_weekly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.sold_weekly.FlatAppearance.BorderSize = 0;
            this.sold_weekly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.sold_weekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sold_weekly.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.sold_weekly.Image = global::PMP.Properties.Resources.weekly;
            this.sold_weekly.Location = new System.Drawing.Point(168, 5);
            this.sold_weekly.Name = "sold_weekly";
            this.sold_weekly.Size = new System.Drawing.Size(135, 95);
            this.sold_weekly.TabIndex = 112;
            this.sold_weekly.Text = "WEEKLY SALES";
            this.sold_weekly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sold_weekly.UseVisualStyleBackColor = false;
            this.sold_weekly.Click += new System.EventHandler(this.sold_weekly_Click);
            // 
            // sold_daily
            // 
            this.sold_daily.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sold_daily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(221)))));
            this.sold_daily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(206)))), ((int)(((byte)(197)))));
            this.sold_daily.FlatAppearance.BorderSize = 0;
            this.sold_daily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.sold_daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sold_daily.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.sold_daily.Image = global::PMP.Properties.Resources.daily;
            this.sold_daily.Location = new System.Drawing.Point(18, 5);
            this.sold_daily.Name = "sold_daily";
            this.sold_daily.Size = new System.Drawing.Size(135, 95);
            this.sold_daily.TabIndex = 111;
            this.sold_daily.Text = "DAILY SALES";
            this.sold_daily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sold_daily.UseVisualStyleBackColor = false;
            this.sold_daily.Click += new System.EventHandler(this.sold_daily_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "SELECT DATE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sold_date_to);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.sold_date_from);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(20, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 77);
            this.panel2.TabIndex = 111;
            // 
            // sold_date_to
            // 
            this.sold_date_to.CustomFormat = "";
            this.sold_date_to.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.sold_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sold_date_to.Location = new System.Drawing.Point(405, 24);
            this.sold_date_to.Name = "sold_date_to";
            this.sold_date_to.Size = new System.Drawing.Size(252, 30);
            this.sold_date_to.TabIndex = 98;
            this.sold_date_to.ValueChanged += new System.EventHandler(this.sold_date_to_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(360, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "TO:";
            // 
            // sold_date_from
            // 
            this.sold_date_from.CustomFormat = "dd/M/yyyy";
            this.sold_date_from.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.sold_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sold_date_from.Location = new System.Drawing.Point(87, 24);
            this.sold_date_from.Name = "sold_date_from";
            this.sold_date_from.Size = new System.Drawing.Size(252, 30);
            this.sold_date_from.TabIndex = 96;
            this.sold_date_from.ValueChanged += new System.EventHandler(this.sold_date_from_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "FROM:";
            // 
            // sales_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1365, 680);
            this.Controls.Add(this.menu_tab);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sales_form";
            this.Text = "sales_form";
            this.menu_tab.ResumeLayout(false);
            this.sales_tab.ResumeLayout(false);
            this.sales_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.date_panel.ResumeLayout(false);
            this.date_panel.PerformLayout();
            this.sold_tab.ResumeLayout(false);
            this.sold_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sold_datagrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl menu_tab;
        public System.Windows.Forms.TabPage sales_tab;
        private System.Windows.Forms.TabPage sold_tab;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel date_panel;
        public System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label transaction_number;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label total_sales;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button print;
        public System.Windows.Forms.Button daily;
        public System.Windows.Forms.Button annually;
        public System.Windows.Forms.Button monthly;
        public System.Windows.Forms.Button weekly;
        public System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker sold_date_to;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker sold_date_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button sold_annually;
        public System.Windows.Forms.Button sold_monthly;
        public System.Windows.Forms.Button sold_weekly;
        public System.Windows.Forms.Button sold_daily;
        public System.Windows.Forms.DataGridView sold_datagrid;
        public System.Windows.Forms.Button sold_print;
        public System.Windows.Forms.Label sold_total_sales;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label sold_number;
        private System.Windows.Forms.Label label11;
    }
}