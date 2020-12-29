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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using Tulpep.NotificationWindow;

namespace PMP
{
    public partial class medicine_inventory : Form
    {
        medicine_inventory_class medicine_inventory_class = new medicine_inventory_class();
        maintenance_class maintenance_class = new maintenance_class();
        sales_class sales_class = new sales_class();

        public medicine_inventory()
        {
            InitializeComponent();
        }

        private void menu_tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == this.menu_tab.SelectedIndex)
            {
                TabPage page = menu_tab.TabPages[e.Index];
                e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);
                Rectangle paddedBounds = e.Bounds;
                int yoffset = (e.State == DrawItemState.Selected) ? -2 : 1;
                paddedBounds.Offset(1, yoffset);
                TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
            }
            else
            {
                TabPage page = menu_tab.TabPages[e.Index];
                Rectangle paddedBounds = e.Bounds;
                int yoffset = (e.State == DrawItemState.Selected) ? -2 : 1;
                paddedBounds.Offset(1, yoffset);
                TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
            }
        }

        private void menu_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicine_list_controltab();
            medicine_stock_controltab();
            stockIn_history_controltab();
            stock_adjustment_controltab();
            deactivate_controltab();
        }
        private void medicine_list_controltab()
        {
            main.month = DateTime.Now.Month;
            main.year = DateTime.Now.Year;
            medicine_inventory_class.medicine_out_of_stock();
            medicine_inventory_class.medicine_expired();
            search.Text = "Search Medicine";
            search.ForeColor = Color.Gray;
            button_panel.Enabled = true;
            add_panel.Visible = false;
            code.Text = "";
            brand_category.Text = "-------SELECT BRAND--------";
            medicinename.Text = "";
            brandname.Text = "";
            expiration_date.Text = DateTime.Now.ToString();
            dosage.Text = "";
            stock.Text = "5";
            price.Text = "";
            category.Text = "ALL BRAND";
            doctor_prescription.Text = "REQUIRED";
            datagrid.DataSource = medicine_inventory_class.medicine_select();
            datagrid.CurrentCell = null;
            search.Enabled = true;
            category.Enabled = true;
            datagrid.Enabled = true;
            button_panel.Enabled = true;
            add_panel.Visible = false;
            print.Enabled = true;
            expiration_date.Enabled = true;
            stock.Enabled = true;

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

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid.ClearSelection();
            datagrid.CurrentCell = null;
        }

        private void datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Medicine")
            {
                category.Text = "ALL BRAND";
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Medicine";
                search.ForeColor = Color.Gray;
                category.Text = "ALL BRAND";
                datagrid.DataSource = medicine_inventory_class.medicine_select();
                datagrid.CurrentCell = null;

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "Search Medicine")
            {
                datagrid.DataSource = medicine_inventory_class.medicine_select();
                datagrid.CurrentCell = null;

            }
            else
            {
                main.search = search.Text;
                DataTable dt = medicine_inventory_class.medicine_search();
                datagrid.DataSource = dt;
                if (main.tmp_brandname == 1)
                {
                    datagrid.CurrentCell = null;
                }
            }
        }

        private void add_disable()
        {
            medicine_list_controltab();
            search.Enabled = false;
            category.Enabled = false;
            datagrid.Enabled = false;
            button_panel.Enabled = false;
            print.Enabled = false;
            add_panel.Visible = true;
            medicine_search();
            brandname_search();
            dosage_search();
        }
        private void add_Click(object sender, EventArgs e)
        {
            add_disable();
            brand_category.Focus();
            medicine_label.Text = "ADD MEDICINE";
            medicine_inventory_class.code_number();
            string str = main.code_string;
            char[] seperator = { '-' };
            string[] strarr = null;
            strarr = str.Split(seperator);
            main.code_int = int.Parse(strarr[1]);
            main.code_int = main.code_int + 1;
            code.Text = "M" + String.Format("{0:D6}", main.code_int);
        }

        private void close_Click(object sender, EventArgs e)
        {
            medicine_list_controltab();
        }

        private void category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            print.Focus();
        }

        private void brand_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void brand_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicinename.Focus();
        }

        private void medicinename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void brandname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && price.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void medicine_search()
        {
            try
            {
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select MedicineName From Medicine_list", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                medicinename.AutoCompleteCustomSource = collection;
                code_medicinename.AutoCompleteCustomSource = collection;
                main.con.Close();
            }
            catch
            {
            }
        }

        private void code_search()
        {
            try
            {
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select Code From Medicine", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                code_medicinename.AutoCompleteCustomSource = collection;
                main.con.Close();
            }
            catch
            {
            }
        }

        private void brandname_search()
        {
            try
            {
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select BrandName From Brand_list", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                brandname.AutoCompleteCustomSource = collection;
                main.con.Close();
            }
            catch
            {
            }
        }

        private void dosage_search()
        {
            try
            {
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select Dosage From Dosage_list", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                dosage.AutoCompleteCustomSource = collection;
                main.con.Close();
            }
            catch
            {
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            medicine_label.Text = "UPDATE MEDICINE";
            try
            {
                main.code = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                main.code = "";
            }

            if (main.code == "")
            {
                MessageBox.Show("SELECT MEDICINE TO UPDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.con.Open();
                string sql = "Select Code,MedicineName,BrandCategory,BrandName,ExpirationDate,Dosage,Stocks,Price,Prescription From Medicine Where Code = '" + main.code + "'";
                SqlCommand cmd = new SqlCommand(sql, main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["ExpirationDate"].ToString() == "Expired")
                    {
                        MessageBox.Show("THIS MEDICINE IS ALREADY EXPIRED", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        main.expired = 0;
                    }
                    else
                    {
                        main.expired = 1;
                        code.Text = (dr["Code"].ToString());
                        medicinename.Text = (dr["MedicineName"].ToString());
                        brand_category.Text = (dr["BrandCategory"].ToString());
                        brandname.Text = (dr["BrandName"].ToString());
                        expiration_date.Text = (dr["ExpirationDate"].ToString());
                        dosage.Text = (dr["Dosage"].ToString());
                        stock.Text = (dr["Stocks"].ToString());
                        price.Text = (dr["Price"].ToString());
                        doctor_prescription.Text = (dr["Prescription"].ToString());
                    }
                }
                main.con.Close();
                if (main.expired == 1)
                {
                    search.Text = "Search Medicine";
                    search.ForeColor = Color.Gray;
                    search.Enabled = false;
                    category.Text = "ALL BRAND";
                    datagrid.DataSource = medicine_inventory_class.medicine_select();
                    datagrid.CurrentCell = null;
                    category.Enabled = false;
                    datagrid.Enabled = false;
                    button_panel.Enabled = false;
                    print.Enabled = false;
                    add_panel.Visible = true;
                    medicine_search();
                    brandname_search();
                    dosage_search();
                    expiration_date.Enabled = false;
                    stock.Enabled = false;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {                
                main.code = datagrid.SelectedRows[0].Cells[0].Value.ToString();
                main.medicinename = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                sales_class sales_class = new sales_class();
                main.select_string = "Select ExpirationDate From Medicine Where Code = '"+main.code+"'";
                sales_class.transaction_number();
                if (main.code_string == "Expired")
                {
                    deactivate_panel.Visible = true;
                    status_code.Text = main.code;
                    status_medicinename.Text = main.medicinename;
                    search.Text = "Search Medicine";
                    search.ForeColor = Color.Gray;
                    search.Enabled = false;
                    category.Text = "ALL BRAND";
                    datagrid.DataSource = medicine_inventory_class.medicine_select();
                    datagrid.CurrentCell = null;
                    category.Enabled = false;
                    datagrid.Enabled = false;
                    button_panel.Enabled = false;
                    print.Enabled = false;
                    add_panel.Visible = false;
                    medicine_search();
                    brandname_search();
                    dosage_search();
                    expiration_date.Enabled = false;
                    stock.Enabled = false;
                }
                else
                {
                    MessageBox.Show("THIS MEDICINE IS NOT EXPIRED", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("SELECT MEDICINE TO PULL OUT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                main.code = code.Text;
                main.brandcategory = brand_category.Text;
                main.medicinename = medicinename.Text;
                main.brandname = brandname.Text;
                main.expirationdate = expiration_date.Text;
                main.dosage = dosage.Text;
                main.stock = stock.Text;
                main.price_string = string.Format("{0:0.00}", price.Text);
                main.month = expiration_date.Value.Month;
                main.year = expiration_date.Value.Year;
                main.codenumber = "M-" + String.Format("{0:D6}", main.code_int);
                main.doctor_prescription = doctor_prescription.Text;
            }
            catch
            { }
            if (brand_category.Text == "-------SELECT BRAND--------" || brandname.Text == "" || medicinename.Text == "" || dosage.Text == "" || stock.Text == "" ||price.Text == "")
            {
                MessageBox.Show("INCOMPLETE DATA TO ADD/UPDATE MEDICINE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (expiration_date.Text == DateTime.Now.Month + "/" + DateTime.Now.Year)
                {
                    MessageBox.Show("SET EXPIRATION DATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (medicine_label.Text == "UPDATE MEDICINE")
                    {
                        medicine_inventory_class.medicine_update();
                        medicine_list_controltab();
                    }
                    else
                    {
                        sales_class sales = new sales_class();
                        main.select_string = "Select Count(*) From Medicine where MedicineName = '"+main.medicinename+"' and BrandCategory = '"+main.brandcategory+"' and BrandName = '"+main.brandname+"' and ExpirationDate = '"+main.expirationdate+"' and Dosage = '"+main.dosage+"'";
                        sales.medicine_order();
                        if (main.tmp == 1)
                        {
                            MessageBox.Show("MEDICINE ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            medicine_inventory_class.medicine_add();
                            medicine_list_controltab();
                        }
                    }
                }
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            crystalreport.medicine_report report = new crystalreport.medicine_report();
            if (category.Text == "ALL BRAND")
            {
                string sql = "select * From Medicine order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                report.SetDataSource(ds.Tables["Medicine"]);
            }
            else if (category.Text == "BRANDED")
            {
                string sql = "select * From Medicine where BrandCategory = 'BRANDED' order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                report.SetDataSource(ds.Tables["Medicine"]);
            }
            else if (category.Text == "GENERIC")
            {
                string sql = "select * From Medicine where BrandCategory = 'GENERIC' order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                report.SetDataSource(ds.Tables["Medicine"]);
            }

            report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("MEDICINE REPORT LIST SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            category.Text = "ALL BRAND";
        }

        //STOCK IN ENTRY--------------------------------------------------------------------------------------------------------------------------------------------------

        private void medicine_stock_controltab()
        {
            total_received_stock.Text = "0";
            date_received.Text = DateTime.Now.ToString();
            main.datereceived = date_received.Text;
            stock_search.Text = "Medicine Name";
            code_medicinename.Text = "";
            stock_stock.Text = "Enter Stock";
            stock_stock.ForeColor = Color.Gray;
            stock_code.Text = "";
            stock_medicinename.Text = "";
            stock_brandcategory.Text = "";
            stock_brandname.Text = "";
            stock_dosage.Text = "";
            stock_expirationdate.Text = "";
            stock_price.Text = "";
            stock_datagrid.DataSource = null;
            stock_datagrid.CurrentCell = null;
            stock_save.Enabled = false;
            stock_remove.Enabled = false;
        }

        private void searchby()
        {
            if (stock_search.Text == "Medicine Name")
            {
                medicine_search();
                code_medicinename.CharacterCasing = CharacterCasing.Normal;
            }
            else
            {
                code_search();
                code_medicinename.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void stock_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchby();
            code_medicinename.Text = "";
            stock_stock.Text = "Enter Stock";
            stock_stock.ForeColor = Color.Gray;
            stock_code.Text = "";
            stock_medicinename.Text = "";
            stock_brandcategory.Text = "";
            stock_brandname.Text = "";
            stock_dosage.Text = "";
            stock_expirationdate.Text = "";
            stock_price.Text = "";
            code_medicinename.Focus();
        }

        private void stock_stock_Enter(object sender, EventArgs e)
        {
            if (stock_stock.Text == "Enter Stock")
            {
                stock_stock.Text = "";
                stock_stock.ForeColor = Color.Black;
            }
        }

        private void stock_stock_Leave(object sender, EventArgs e)
        {
            if (stock_stock.Text == "")
            {
                stock_stock.Text = "Enter Stock";
                stock_stock.ForeColor = Color.Gray;
            }
        }

        private void stock_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void code_medicinename_Enter(object sender, EventArgs e)
        {
            searchby();
        }

        private void stock_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stock_datagrid.ClearSelection();
            stock_datagrid.CurrentCell = null;
        }

        private void stock_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in stock_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void medicinename_method(string medicine)
        {
            if (medicine == "")
            {
                stock_code.Text = "";
                stock_medicinename.Text = "";
                stock_brandcategory.Text = "";
                stock_brandname.Text = "";
                stock_expirationdate.Text = "";
                stock_dosage.Text = "";
                stock_price.Text = "";
            }
        }

        private void code_medicinename_TextChanged(object sender, EventArgs e)
        {
            medicinename_method(code_medicinename.Text);
            try
            {
                main.code = code_medicinename.Text;
                main.medicinename = code_medicinename.Text;
                main.con.Open();
                string sql = "Select Code,MedicineName,BrandCategory,BrandName,ExpirationDate,Dosage,Stocks,Price From Medicine Where Code = '"+ main.code +"' OR MedicineName = '"+ main.medicinename +"'";
                SqlCommand cmd = new SqlCommand(sql, main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["ExpirationDate"].ToString() == "Expired")
                    {
                        stock_code.Text = "";
                        stock_medicinename.Text = "";
                        stock_brandcategory.Text = "";
                        stock_brandname.Text = "";
                        stock_expirationdate.Text = "";
                        stock_dosage.Text = "";
                        stock_price.Text = "";
                    }
                    else
                    {
                        stock_code.Text = (dr["Code"].ToString());
                        stock_medicinename.Text = (dr["MedicineName"].ToString());
                        stock_brandcategory.Text = (dr["BrandCategory"].ToString());
                        stock_brandname.Text = (dr["BrandName"].ToString());
                        stock_expirationdate.Text = (dr["ExpirationDate"].ToString());
                        stock_dosage.Text = (dr["Dosage"].ToString());
                        stock_price.Text = (dr["Price"].ToString());
                    }
                }
                main.con.Close();
            }
            catch
            {
                stock_code.Text = "";
                stock_medicinename.Text = "";
                stock_brandcategory.Text = "";
                stock_brandname.Text = "";
                stock_expirationdate.Text = "";
                stock_dosage.Text = "";
                stock_price.Text = "";
            }
        }

        private void stock_add_Click(object sender, EventArgs e)
        {
            if (stock_code.Text == "")
            {
                MessageBox.Show("INVALID MEDICINE INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (stock_stock.Text == "Enter Stock" || stock_stock.Text == "")
                {
                    MessageBox.Show("ENTER STOCK VALUE", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    stock_save.Enabled = true;
                    stock_remove.Enabled = true;
                    main.code = stock_code.Text;
                    main.medicinename = stock_medicinename.Text;
                    main.brandcategory = stock_brandcategory.Text;
                    main.brandname = stock_brandname.Text;
                    main.expirationdate = stock_expirationdate.Text;
                    main.dosage = stock_dosage.Text;
                    main.price_string = stock_price.Text;
                    main.datereceived = date_received.Text;
                    main.stock = stock_stock.Text;
                    medicine_inventory_class.stock_medicine();
                    main.new_stock = int.Parse(main.stock) + int.Parse(main.medicine_stock);
                    medicine_inventory_class.stock_update();
                    medicine_inventory_class.StockIn();
                    if (main.tmp_code == 1)
                    {
                        medicine_inventory_class.StockIn_select();
                        medicine_inventory_class.stockIn_update();
                    }
                    else
                    {
                        medicine_inventory_class.stock_add();
                    }
                    stock_datagrid.DataSource = medicine_inventory_class.stock_select();
                    stock_datagrid.CurrentCell = null;
                    medicine_inventory_class.total_stock();
                    total_received_stock.Text = main.total_stock_received;
                    code_medicinename.Text = "";
                    stock_stock.Text = "Enter Stock";
                    stock_stock.ForeColor = Color.Gray;
                    stock_code.Text = "";
                    stock_medicinename.Text = "";
                    stock_brandcategory.Text = "";
                    stock_brandname.Text = "";
                    stock_dosage.Text = "";
                    stock_expirationdate.Text = "";
                    stock_price.Text = "";
                }
            }
              
        }

        private void stock_remove_Click(object sender, EventArgs e)
        {
            try
            {
                main.code = stock_datagrid.SelectedRows[0].Cells[0].Value.ToString();
                main.stock = stock_datagrid.SelectedRows[0].Cells[5].Value.ToString();
                medicine_inventory_class.stock_medicine();
                main.new_stock = int.Parse(main.medicine_stock) - int.Parse(main.stock);
                medicine_inventory_class.stock_update();
                medicine_inventory_class.stock_delete();
                stock_datagrid.DataSource = medicine_inventory_class.stock_select();
                stock_datagrid.CurrentCell = null;
            }
            catch
            { 
            }

        }

        private void stock_save_Click(object sender, EventArgs e)
        {
            medicine_stock_controltab();
            MessageBox.Show("STOCK IN MEDICINE SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //STOCK IN HISTORY-----------------------------------------------------------------------------------------------------------------------------------------
        private void stockIn_history_controltab()
        {
            stock_history_datereceived.Text = DateTime.Now.ToString();
            main.datereceived = stock_history_datereceived.Text;
            stock_history_datagrid.DataSource = medicine_inventory_class.stock_history_select();
            medicine_inventory_class.total_stock();
            stock_history_total.Text = main.total_stock_received;
            stock_history_datagrid.CurrentCell = null;
        }

        private void stock_history_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in stock_history_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void stock_history_print_Click(object sender, EventArgs e)
        {
            crystalreport.StockIn_report report = new crystalreport.StockIn_report();
            string sql = "select * From StockIn where DateReceived = '" + main.datereceived + "' Order by Code asc";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
            adapter.Fill(ds, "StockIn");
            report.SetDataSource(ds.Tables["StockIn"]);
            report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("STOCK IN MEDICINE REPORT SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stock_history_datereceived_ValueChanged(object sender, EventArgs e)
        {
            main.datereceived = stock_history_datereceived.Text;
            stock_history_datagrid.DataSource = medicine_inventory_class.stock_history_select();
            medicine_inventory_class.total_stock();
            stock_history_total.Text = main.total_stock_received;
        }
        
        //STOCK ADJUSTMENT---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void stock_adjustment_controltab()
        {
            status_status.Text = "Total Stocks Per Medicine";
            status_search.Text = "Search Medicine";
            status_search.ForeColor = Color.Gray;
            status_datagrid.DataSource = medicine_inventory_class.status_total_stock_select();
            status_datagrid.CurrentCell = null;
            medicine_inventory_class.status_expired();
            medicine_inventory_class.status_low_in_stocks();
            medicine_inventory_class.status_out_of_stocks();
            status_expired.Text = main.expired.ToString();
            status_low_in_stocks.Text = main.low_in_stocks.ToString();
            status_out_of_stocks.Text = main.out_of_stocks.ToString();
            status_medicine_expired.Enabled = false;
        }

        private void status_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            status_datagrid.ClearSelection();
            status_datagrid.CurrentCell = null;
        }

        private void status_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in status_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void status_select()
        {
            if (status_status.Text == "Total Stocks Per Medicine")
            {
                status_datagrid.DataSource = medicine_inventory_class.status_total_stock_select();
                status_datagrid.CurrentCell = null;
                status_medicine_expired.Enabled = false;
            }
            else if (status_status.Text == "Low in Stocks")
            {
                status_datagrid.DataSource = medicine_inventory_class.status_low_in_stocks_select();
                status_datagrid.CurrentCell = null;
                status_medicine_expired.Enabled = false;
            }
            else if (status_status.Text == "Out of Stocks")
            {
                status_datagrid.DataSource = medicine_inventory_class.status_out_of_stocks_select();
                status_datagrid.CurrentCell = null;
                status_medicine_expired.Enabled = false;
            }
            else if (status_status.Text == "Expired")
            {
                status_datagrid.DataSource = medicine_inventory_class.status_expired_select();
                status_datagrid.CurrentCell = null;
                status_medicine_expired.Enabled = true;
            }
            else if (status_status.Text == "Not Expired")
            {
                status_datagrid.DataSource = medicine_inventory_class.status_not_expired_select();
                status_datagrid.CurrentCell = null;
                status_medicine_expired.Enabled = false;
            }
        }

        private void status_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            status_print.Focus();
            status_select();
            status_search.Text = "Search Medicine";
            status_search.ForeColor = Color.Gray;
        }

        private void status_search_Enter(object sender, EventArgs e)
        {
            if (status_search.Text == "Search Medicine")
            {
                status_search.Text = "";
                status_search.ForeColor = Color.Black;
            }
        }

        private void status_search_Leave(object sender, EventArgs e)
        {
            if (status_search.Text == "")
            {
                status_search.Text = "Search Medicine";
                status_search.ForeColor = Color.Gray;
                status_select();
            }
        }

        private void status_search_TextChanged(object sender, EventArgs e)
        {
                main.search = status_search.Text;
                if (status_status.Text == "Total Stocks Per Medicine")
                {
                    status_datagrid.DataSource = medicine_inventory_class.total_stock_search();
                    status_datagrid.CurrentCell = null;
                }
                else if (status_status.Text == "Low in Stocks")
                {
                    try
                    {
                        status_datagrid.DataSource = medicine_inventory_class.low_stocks_search();
                        status_datagrid.CurrentCell = null;
                    }
                    catch
                    { 
                    }
                }
                else if (status_status.Text == "Out of Stocks")
                {
                    status_datagrid.DataSource = medicine_inventory_class.out_stocks_search();
                    status_datagrid.CurrentCell = null;
                }
                else if (status_status.Text == "Expired")
                {
                    status_datagrid.DataSource = medicine_inventory_class.expired_search();
                    status_datagrid.CurrentCell = null;
                }
                else if (status_status.Text == "Not Expired")
                {
                    status_datagrid.DataSource = medicine_inventory_class.not_expired_search();
                    status_datagrid.CurrentCell = null;
                }
        }

        private void status_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void status_remove_Click(object sender, EventArgs e)
        {
            try
            {
                main.code = status_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                main.code = "";
            }

            if (main.code == "")
            {
                MessageBox.Show("PLEASE SELECT MEDICINE TO REMOVE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO PERMANENTLY REMOVE THIS EXPIRED MEDICINE?", "REMOVE EXPIRED MEDICINE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    medicine_inventory_class.remove_expired();
                    medicine_inventory_class.status_expired();
                    status_expired.Text = main.expired.ToString();
                    status_select();
                    medicine_inventory_class.status_expired();
                    medicine_inventory_class.status_low_in_stocks();
                    medicine_inventory_class.status_out_of_stocks();
                    status_expired.Text = main.expired.ToString();
                    status_low_in_stocks.Text = main.low_in_stocks.ToString();
                    status_out_of_stocks.Text = main.out_of_stocks.ToString();
                }
            }
        }

        private void status_remove_all_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO PERMANENTLY REMOVE ALL EXPIRED MEDICINE?", "REMOVE ALL EXPIRED MEDICINE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                medicine_inventory_class.remove_all_expired();
                medicine_inventory_class.status_expired();
                status_expired.Text = main.expired.ToString();
                status_select();
                medicine_inventory_class.status_expired();
                medicine_inventory_class.status_low_in_stocks();
                medicine_inventory_class.status_out_of_stocks();
                status_expired.Text = main.expired.ToString();
                status_low_in_stocks.Text = main.low_in_stocks.ToString();
                status_out_of_stocks.Text = main.out_of_stocks.ToString();
            }
        }

        private void status_print_Click(object sender, EventArgs e)
        {
            crystalreport.stock_report stock_report = new crystalreport.stock_report();
            crystalreport.expiration_report expiration_report = new crystalreport.expiration_report();
            if (status_status.Text == "Total Stocks Per Medicine")
            {
                (stock_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = "TOTAL STOCKS PER MEDICINE REPORT";
                string sql = "select * From Medicine Order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                stock_report.SetDataSource(ds.Tables["Medicine"]);
                stock_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                stock_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                stock_report.PrintToPrinter(1, false, 0, 0);
                MessageBox.Show("TOTAL STOCKS PER MEDICINE SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status_status.Text == "Low in Stocks")
            {
                (stock_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = "MEDICINE LOW IN STOCK REPORT";
                string sql = "select * From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 Order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                stock_report.SetDataSource(ds.Tables["Medicine"]);
                stock_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                stock_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                stock_report.PrintToPrinter(1, false, 0, 0);
                MessageBox.Show("MEDICINE LOW IN STOCK SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status_status.Text == "Out of Stocks")
            {
                (stock_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = "MEDICINE OUT OF STOCK REPORT";
                string sql = "select * From Medicine Where Stocks = 'Out Of Stock' Order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                stock_report.SetDataSource(ds.Tables["Medicine"]);
                stock_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                stock_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                stock_report.PrintToPrinter(1, false, 0, 0);
                MessageBox.Show("MEDICINE OUT OF STOCK SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status_status.Text == "Expired")
            {
                (expiration_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = "MEDICINE EXPIRED REPORT";
                string sql = "select * From Medicine Where ExpirationDate = 'Expired' order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                expiration_report.SetDataSource(ds.Tables["Medicine"]);
                expiration_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                expiration_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                expiration_report.PrintToPrinter(1, false, 0, 0);
                MessageBox.Show("MEDICINE EXPIRED SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (status_status.Text == "Not Expired")
            {
                (expiration_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = "MEDICINE NOT EXPIRED REPORT";
                string sql = "select * From Medicine Where ExpirationDate <> 'Expired' order by Code asc";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Medicine");
                expiration_report.SetDataSource(ds.Tables["Medicine"]);
                expiration_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                expiration_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                expiration_report.PrintToPrinter(1, false, 0, 0);
                MessageBox.Show("MEDICINE NOT EXPIRED SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void status_reason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void close_deactivate_Click(object sender, EventArgs e)
        {
            medicine_list_controltab();
            deactivate_panel.Visible = false;
        }

        private void deactivate_Click(object sender, EventArgs e)
        {
            sales_class sales_class = new sales_class();
            main.select_string = "Update Medicine Set Status = 'DEACTIVATE' Where Code = '"+ main.code+"'";
            sales_class.medicine_add();
            deactivate_panel.Visible = false;
            medicine_list_controltab();
            MessageBox.Show("SUCCESSFULLY MOVE TO PULL OUT MEDICINE EXPIRED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
//DEACTIVATE TAB-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void deactivate_controltab()
        {
            sales_class sales_class = new sales_class();
            main.select_string = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage from Medicine Where Status = 'DEACTIVATE' order by Code asc";
            datagrid_deactivate.DataSource = sales_class.select();
            datagrid_deactivate.CurrentCell = null;
            search_deactivate.Text = "Search Medicine";
            search_deactivate.ForeColor = Color.Gray;
        }

        private void datagrid_deactivate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid_deactivate.ClearSelection();
            datagrid_deactivate.CurrentCell = null;
        }

        private void datagrid_deactivate_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in datagrid_deactivate.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void search_deactivate_Enter(object sender, EventArgs e)
        {
            if (search_deactivate.Text == "Search Medicine")
            {
                search_deactivate.Text = "";
                search_deactivate.ForeColor = Color.Black;
            }
        }

        private void search_deactivate_Leave(object sender, EventArgs e)
        {
            if (search_deactivate.Text == "")
            {
                search_deactivate.Text = "Search Medicine";
                search_deactivate.ForeColor = Color.Gray;
            }
        }

        private void search_deactivate_TextChanged(object sender, EventArgs e)
        {
            sales_class sales_class = new sales_class();
            main.search = search_deactivate.Text;
            datagrid_deactivate.DataSource = sales_class.deactivate_search();
        }
    }
}
