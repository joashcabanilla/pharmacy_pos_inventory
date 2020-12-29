using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;

namespace PMP
{
    public partial class admin_control : Form
    {
        main main = new main();
        medicine_inventory medicine_form = new medicine_inventory();
        medicine_inventory_class medicine_inventory_class = new medicine_inventory_class();
        staff_form staff_form = new staff_form();
        sales_form sales_form = new sales_form();
        maintenance_form maintenance_form = new maintenance_form();
        maintenance_class maintenance_class = new maintenance_class();
        staff_acount staff_account_class = new staff_acount();
        sales_class sales_class = new sales_class();

        public admin_control()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void admin_control_Load(object sender, EventArgs e)
        {
            menu_panel.Width = 0;
            this.KeyPreview = true;
            medicine_form_load();
            
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            if(menu_button.Text == "MENU")
            {
                menu_panel.Width = 217;
                logo.BackColor = Color.FromArgb(158, 206, 197);
                menu_logo.BackColor = Color.FromArgb(158, 206, 197);
                menu_button.BackColor = Color.FromArgb(158, 206, 197);
                menu_button.Text = "BACK";
                form_panel.Enabled = false;
                medicine_inventory.Enabled = true;
                staff_account.Enabled = true;
                sales.Enabled = true;
                logout.Enabled = true;
                menu_panel.Enabled = true;
            }
            else
            {

                menu_panel.Width = 0;
                logo.BackColor = Color.FromArgb(255, 255, 221);
                menu_logo.BackColor = Color.FromArgb(255, 255, 221);
                menu_button.BackColor = Color.FromArgb(255, 255, 221);
                menu_button.Text = "MENU";
                form_panel.Enabled = true;
            }
        }

        private void admin_control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (menu_button.Text == "MENU")
                {
                    menu_panel.Width = 217;
                    logo.BackColor = Color.FromArgb(158, 206, 197);
                    menu_logo.BackColor = Color.FromArgb(158, 206, 197);
                    menu_button.BackColor = Color.FromArgb(158, 206, 197);
                    menu_button.Text = "BACK";
                    form_panel.Enabled = false;
                    medicine_inventory.Enabled = true;
                    staff_account.Enabled = true;
                    sales.Enabled = true;
                    logout.Enabled = true;
                    menu_panel.Enabled = true;
                }
                else
                {

                    menu_panel.Width = 0;
                    logo.BackColor = Color.FromArgb(255, 255, 221);
                    menu_logo.BackColor = Color.FromArgb(255, 255, 221);
                    menu_button.BackColor = Color.FromArgb(255, 255, 221);
                    menu_button.Text = "MENU";
                    form_panel.Enabled = true;
                }
            }
        }

        private void medicine_inventory_Click(object sender, EventArgs e)
        {
            menu_hide();
            medicine_form_load();
        }

        private void medicine_form_load()
        {
            this.medicine_form.menu_tab.SelectedIndex = 0;
            label_form.Text = "MEDICINE INVENTORY";
            form_panel.Controls.Clear();
            medicine_form.TopLevel = false;
            medicine_form.Dock = DockStyle.Fill;
            form_panel.Controls.Add(medicine_form);
            medicine_form.Show();

            main.month = DateTime.Now.Month;
            main.year = DateTime.Now.Year;
            medicine_inventory_class.medicine_out_of_stock();
            medicine_inventory_class.medicine_expired();
            this.medicine_form.datagrid.DataSource = medicine_inventory_class.medicine_select();
            this.medicine_form.datagrid.CurrentCell = null;
            medicine_inventory_clear();

            main.select_string = "Select Count(*) from Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE'";
            sales_class.transaction_number();
            if (int.Parse(main.code_string) != 0)
            {
                try
            {
                main.sex = "";
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select Code,MedicineName From Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE'", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    main.sex += dr["Code"].ToString() + " " + dr["MedicineName"].ToString() + Environment.NewLine;
                }
                main.con.Close();
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.notification;
                popup.TitleColor = Color.Black;
                popup.TitleFont = new System.Drawing.Font("Arial", 12);
                popup.ContentFont = new System.Drawing.Font("Tahoma", 10F);
                popup.Size = new Size(400, 200);
                popup.ShowGrip = false;
                popup.HeaderHeight = 20;
                popup.TitlePadding = new Padding(3);
                popup.ContentPadding = new Padding(3);
                popup.ImagePadding = new Padding(8);
                popup.AnimationDuration = 1000;
                popup.AnimationInterval = 1;
                popup.HeaderColor = Color.FromArgb(252, 164, 2);
                popup.Scroll = true;
                popup.TitleText = "EXPIRED MEDICINE";
                popup.ContentText = main.sex;
                popup.Popup();
            }
            catch
            {
            }
            }
            main.select_string = "Select Count(*) from Medicine Where Stocks = 'Out Of Stock'";
            sales_class.transaction_number();
            if (int.Parse(main.code_string) != 0)
            {
                try
                {
                    main.sex = "";
                    main.con.Open();
                    SqlCommand cmd = new SqlCommand("Select Code,MedicineName From Medicine Where Stocks = 'Out Of Stock'", main.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        main.sex += dr["Code"].ToString() + " " + dr["MedicineName"].ToString() + Environment.NewLine;
                    }
                    main.con.Close();
                    PopupNotifier popup1 = new PopupNotifier();
                    popup1.Image = Properties.Resources.notification;
                    popup1.TitleColor = Color.Black;
                    popup1.TitleFont = new System.Drawing.Font("Arial", 12);
                    popup1.ContentFont = new System.Drawing.Font("Tahoma", 10F);
                    popup1.Size = new Size(400, 200);
                    popup1.ShowGrip = false;
                    popup1.HeaderHeight = 20;
                    popup1.TitlePadding = new Padding(3);
                    popup1.ContentPadding = new Padding(3);
                    popup1.ImagePadding = new Padding(8);
                    popup1.AnimationDuration = 1000;
                    popup1.AnimationInterval = 1;
                    popup1.HeaderColor = Color.FromArgb(252, 164, 2);
                    popup1.Scroll = true;
                    popup1.TitleText = "OUT OF STOCK MEDICINE";
                    popup1.ContentText = main.sex;
                    popup1.Popup();
                }
                catch
                {
                }
            }
            main.select_string = "Select Count(*) from Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5";
            sales_class.transaction_number();
            if (int.Parse(main.code_string) != 0)
            {
                try
                {
                    main.sex = "";
                    main.con.Open();
                    SqlCommand cmd = new SqlCommand("Select Code,MedicineName From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5", main.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        main.sex += dr["Code"].ToString() + " " + dr["MedicineName"].ToString() + Environment.NewLine;
                    }
                    main.con.Close();
                    PopupNotifier popup2 = new PopupNotifier();
                    popup2.Image = Properties.Resources.notification;
                    popup2.TitleColor = Color.Black;
                    popup2.TitleFont = new System.Drawing.Font("Arial", 12);
                    popup2.ContentFont = new System.Drawing.Font("Tahoma", 10F);
                    popup2.Size = new Size(400, 200);
                    popup2.ShowGrip = false;
                    popup2.HeaderHeight = 20;
                    popup2.TitlePadding = new Padding(3);
                    popup2.ContentPadding = new Padding(3);
                    popup2.ImagePadding = new Padding(8);
                    popup2.AnimationDuration = 1000;
                    popup2.AnimationInterval = 1;
                    popup2.HeaderColor = Color.FromArgb(252, 164, 2);
                    popup2.Scroll = true;
                    popup2.TitleText = "LOW IN STOCK MEDICINE";
                    popup2.ContentText = main.sex;
                    popup2.Popup();
                }
                catch
                {
                }
            }
        }

        private void staff_account_Click(object sender, EventArgs e)
        {
            menu_hide();
            label_form.Text = "MANAGE ACCOUNT";
            form_panel.Controls.Clear();
            staff_form.TopLevel = false;
            staff_form.Dock = DockStyle.Fill;
            form_panel.Controls.Add(staff_form);
            staff_form.Show();

            this.staff_form.menu_tab.SelectedIndex = 0;
            this.staff_form.datagrid.DataSource = staff_account_class.staff_select();
            this.staff_form.datagrid.CurrentCell = null;
            staff_account_clear();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            menu_hide();
            label_form.Text = "SALES RECORD";
            form_panel.Controls.Clear();
            sales_form.TopLevel = false;
            sales_form.Dock = DockStyle.Fill;
            form_panel.Controls.Add(sales_form);
            sales_form.Show();

            sales_clear();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();
        }

        private void menu_hide()
        {
            menu_panel.Width = 0;
            logo.BackColor = Color.FromArgb(255, 255, 221);
            menu_logo.BackColor = Color.FromArgb(255, 255, 221);
            menu_button.BackColor = Color.FromArgb(255, 255, 221);
            menu_button.Text = "MENU";
            form_panel.Enabled = true;
        }

        private void maintenance_Click(object sender, EventArgs e)
        {
            menu_hide();
            this.maintenance_form.menu_tab.SelectedIndex = 0;
            label_form.Text = "MAINTENANCE";
            form_panel.Controls.Clear();
            maintenance_form.TopLevel = false;
            maintenance_form.Dock = DockStyle.Fill;
            form_panel.Controls.Add(maintenance_form);
            maintenance_form.Show();

            this.maintenance_form.datagrid.DataSource = maintenance_class.brandname_select();
            this.maintenance_form.datagrid.CurrentCell = null;
            maintenance_clear();
        }

        private void maintenance_clear()
        {
            this.maintenance_form.search.Text = "Search Brand Name";
            this.maintenance_form.search.ForeColor = Color.Gray;
            this.maintenance_form.brand_category.Text = "ALL BRAND";
            this.maintenance_form.add_panel.Visible = false;
            this.maintenance_form.brandname.Text = "";
            this.maintenance_form.add_brand_category.Text = "-------SELECT BRAND--------";
            this.maintenance_form.datagrid.Enabled = true;
            this.maintenance_form.search.Enabled = true;
            this.maintenance_form.brand_category.Enabled = true;
            this.maintenance_form.button_panel.Enabled = true;
            this.maintenance_form.print.Enabled = true;
            this.maintenance_form.comboBox1.Enabled = true;
            this.maintenance_form.comboBox1.Text = "ALL BRAND";
        }

        private void medicine_inventory_clear()
        {
            this.medicine_form.datagrid.Enabled = true;
            this.medicine_form.search.Text = "Search Medicine";
            this.medicine_form.search.ForeColor = Color.Gray;
            this.medicine_form.search.Enabled = true;
            this.medicine_form.button_panel.Enabled = true;
            this.medicine_form.print.Enabled = true;
            this.medicine_form.brand_category.Enabled = true;
            this.medicine_form.add_panel.Visible = false;
            this.medicine_form.code.Text = "";
            this.medicine_form.brand_category.Text = "-------SELECT BRAND--------";
            this.medicine_form.category.Enabled = true;
            this.medicine_form.medicinename.Text = "";
            this.medicine_form.brandname.Text = "";
            this.medicine_form.expiration_date.Text = DateTime.Now.ToString();
            this.medicine_form.dosage.Text = "";
            this.medicine_form.stock.Text = "";
            this.medicine_form.price.Text = "";
            this.medicine_form.category.Text = "ALL BRAND";
            this.medicine_form.doctor_prescription.Text = "REQUIRED";
            this.medicine_form.deactivate_panel.Visible = false;
        }

        private void staff_account_clear()
        {
            this.staff_form.search.Text = "Search Staff";
            this.staff_form.search.ForeColor = Color.Gray;
            this.staff_form.button_panel.Enabled = true;
            this.staff_form.add_panel.Visible = false;
            this.staff_form.datagrid.Enabled = true;
        }

        private void sales_clear()
        {
            try
            {
                this.sales_form.date_from.Text = DateTime.Now.ToString();
                this.sales_form.date_to.Text = DateTime.Now.ToString();
                this.sales_form.daily.BackColor = Color.FromArgb(249, 247, 147);
                this.sales_form.weekly.BackColor = Color.FromArgb(255, 255, 221);
                this.sales_form.monthly.BackColor = Color.FromArgb(255, 255, 221);
                this.sales_form.annually.BackColor = Color.FromArgb(255, 255, 221);
                this.sales_form.menu_tab.SelectedIndex = 0;
                main.date = DateTime.Now.ToShortDateString();
                main.select_string = "Select TransactionID AS 'Transaction ID',TotalAmount AS 'Total Amount',Discount,Cash,Change,Date,StaffName AS 'Staff Name' From Sales Where Date = '" + main.date + "' order by TransactionID asc";
                this.sales_form.datagrid.DataSource = sales_class.select();
                this.sales_form.datagrid.CurrentCell = null;
                main.select_string = "Select Count(*) From Sales Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                this.sales_form.transaction_number.Text = main.code_string;
                main.select_string = "Select Sum(TotalAmount) From Sales Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                double total1 = double.Parse(main.code_string);
                string total = string.Format("{0:N}", total1);
                this.sales_form.total_sales.Text = total;
                this.sales_form.datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
                this.sales_form.sold_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
                main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date = '" + main.date + "' order by TransactionID asc";
                main.report_name = "DAILY SALES REPORT";
            }
            catch
            {
                this.sales_form.transaction_number.Text = "0";
                this.sales_form.total_sales.Text = "0";
                this.sales_form.datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
                this.sales_form.sold_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
            }
        }
    }
}
