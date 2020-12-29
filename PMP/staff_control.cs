using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace PMP
{
    public partial class staff_control : Form
    {
        sales_class sales_class = new sales_class();
        medicine_inventory_class medicine_inventory_class = new medicine_inventory_class();

        public staff_control()
        {
            InitializeComponent();
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            datagrid_inquiry.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void staff_control_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            main.month = DateTime.Now.Month;
            main.year = DateTime.Now.Year;
            medicine_inventory_class.medicine_expired();
            search_medicine.Focus();
            main.transaction_id = "";
            discount_label.Text = "DISCOUNT";
            main.discount_percentage = 0;
            select_medicine();
            try
            {
                main.con.Open();
                string sql = "Select FirstName,LastName From Staff_account Where Username = '" + main.username + "' and Password = '" + main.password + "'";
                SqlCommand cmd = new SqlCommand(sql, main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    main.firstname = (dr["FirstName"].ToString());
                    main.lastname = (dr["LastName"].ToString());
                    staffname.Text = "STAFFNAME: " + main.firstname + " " + main.lastname;
                    main.staffname = main.firstname + " " + main.lastname;
                    staffname.Text = staffname.Text.ToUpper();
                }
                main.con.Close();
            }
            catch
            {
            } 
            try
            {
                main.con.Open();
                string sql = "select VAT from Vat Where ID = '1'";
                SqlCommand cmd = new SqlCommand(sql, main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (double.Parse(dr["VAT"].ToString()) != 0.00)
                    {
                        main.vat_percentage = double.Parse(dr["VAT"].ToString());
                        main.vat = main.vat_percentage * 100;
                        vat_label.Text = "VAT " + int.Parse(main.vat.ToString()) + "%";
                        vat_label.BackColor = Color.FromArgb(0, 106, 113);
                        vat.BackColor = Color.FromArgb(0, 106, 113);
                    }
                    else
                    {
                        main.vat_percentage = 0;
                        vat_label.Text = "VAT " + main.vat_percentage + "%";
                        vat_label.BackColor = Color.Gray;
                        vat.BackColor = Color.Gray;
                    }
                }
                main.con.Close();
            }
            catch
            {
            }
            
        }

        private void signout_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Hide();
        }

        private void staff_control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (main.on_off == 0)
                {
                    search_mode.Text = "Medicine Code";
                    search_medicine.Text = "";
                    search_medicine.Focus();
                    searchby();
                }
            }
            else if (e.KeyCode == Keys.F12)
            {
                if (main.on_off == 0)
                {
                    search_mode.Text = "Medicine Name";
                    search_medicine.Text = "";
                    search_medicine.Focus();
                    searchby();
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                if (main.on_off == 0)
                {
                    new_transaction_method();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (main.on_off == 0)
                {
                    cancel_transaction_method();
                }
            }
            else if (e.KeyCode == Keys.F10)
            {
                if (main.on_off == 0)
                {
                    void_method();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (main.on_off == 0)
                {
                    search_medicine.Text = "";
                    medicine_clear();
                    discount_method();
                }
            }
            else if(e.KeyCode == Keys.F3)
            {
                if (main.on_off == 0)
                {
                    medicine_inquiry_method();
                }
            }
            else if (e.KeyCode == Keys.F7)
            {
                if (main.inquiry_on == 1)
                {
                    close_inquiry_method();
                }
            }
            else if (e.KeyCode == Keys.F9)
            {
                if (main.transaction_id == "")
                {
                    login_form login = new login_form();
                    login.Show();
                    this.Hide();
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (main.on_off == 0)
                {
                    payment_method();
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                if (main.inquiry_on == 1)
                {
                    if (datagrid_inquiry.CurrentCell == null)
                    {
                        MessageBox.Show("NO MEDICINE SELECTED", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        inquiry_quantity.Visible = true;
                        inquiry_quantity.Text = "1";
                        inquiry_quantity.Focus();
                    }
                }
            }
        }

        private void medicine_search()
        {
            try
            {
                main.con.Open();
                SqlCommand cmd = new SqlCommand("Select MedicineName From Medicine", main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr.GetString(0));
                }
                search_medicine.AutoCompleteCustomSource = collection;
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
                search_medicine.AutoCompleteCustomSource = collection;
                main.con.Close();
            }
            catch
            {
            }
        }

        private void searchby()
        {
            if (search_mode.Text == "Medicine Name")
            {
                medicine_search();
                search_medicine.CharacterCasing = CharacterCasing.Normal;
            }
            else
            {
                code_search();
                search_medicine.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void search_medicine_Enter(object sender, EventArgs e)
        {
            searchby();
        }

        private void search_mode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                prescription.Text = "";
                quantity.Visible = false;
            }
        }

        private void medicine_clear()
        {
            stock_code.Text = "";
            stock_medicinename.Text = "";
            stock_brandcategory.Text = "";
            stock_brandname.Text = "";
            stock_expirationdate.Text = "";
            stock_dosage.Text = "";
            stock_price.Text = "";
        }

        private void search_medicine_TextChanged(object sender, EventArgs e)
        {
            datagrid.CurrentCell = null;
            medicinename_method(search_medicine.Text);
            try
            {
                main.code = search_medicine.Text;
                main.medicinename = search_medicine.Text;
                main.con.Open();
                string sql = "Select Code,MedicineName,BrandCategory,BrandName,ExpirationDate,Dosage,Stocks,Price,Prescription From Medicine Where Code = '" + main.code + "' OR MedicineName = '" + main.medicinename + "'";
                SqlCommand cmd = new SqlCommand(sql, main.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["ExpirationDate"].ToString() == "Expired")
                    {
                        medicine_clear();
                    }
                    else
                    {
                        if (dr["Stocks"].ToString() == "Out Of Stock" || (dr["Stocks"].ToString() != "Out Of Stock" && int.Parse(dr["Stocks"].ToString()) <= 5))
                        {
                            medicine_clear();
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
                            prescription.Text = ("DOCTOR PRESCRIPTION IS " + dr["Prescription"].ToString());
                        }  
                    }
                }
                main.con.Close();
            }
            catch
            {
                quantity.Visible = false;
                stock_code.Text = "";
                stock_medicinename.Text = "";
                stock_brandcategory.Text = "";
                stock_brandname.Text = "";
                stock_expirationdate.Text = "";
                stock_dosage.Text = "";
                stock_price.Text = "";
                prescription.Text = "";
            }
        }

        private void search_medicine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (main.transaction_id == "")
                {
                    main.on_off = 0;
                    MessageBox.Show("PRESS F1 OR CLICK NEW TRANSACTION BUTTON TO ADD NEW TRANSACTION", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    main.on_off = 1;
                    if (stock_code.Text == "")
                    {
                        main.on_off = 0;
                        MessageBox.Show("INVALID MEDICINE", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        main.on_off = 1;
                        quantity.Visible = true;
                        quantity.Focus();
                    }
                }
            }
        }

        private void transaction_number()
        {
            transaction_id.Text = "TRANSACTION ID: " + main.transaction_id;
            signout.Enabled = false;
        }

        private void new_transaction_method()
        {
            main.inquiry_on = 0;
            main.type_of_customer = "REGULAR";
            discount_label.Text = "DISCOUNT";
            main.customer_name = "";
            main.id_number = "";
            main.discount_percentage = 0;
            search_medicine.Focus();
            select_medicine();
            main.select_string = "select Max(TransactionID) From Sales";
            sales_class.transaction_number();
            if (main.code_string == "")
            {
                main.code_string = "0";
                main.transaction_id = DateTime.Now.Year.ToString() + String.Format("{0:D6}", int.Parse(main.code_string) + 1);
                transaction_number();
            }
            else
            {
                main.transaction_id = String.Format("{0:D6}", int.Parse(main.code_string) + 1);
                transaction_number();
            }
        }

        private void new_transaction_Click(object sender, EventArgs e)
        {
            new_transaction_method();
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void select_medicine()
        {
            main.select_string = "Select MedicineName AS 'Medicine Name',Dosage,Quantity,TotalAmount AS 'Total Amount' From Sold_medicine Where TransactionID = '"+main.transaction_id+"'";
            datagrid.DataSource = sales_class.select();
            datagrid.CurrentCell = null;
            datagrid.Columns[0].Width = 327;
            datagrid.Columns[1].Width = 280;
            datagrid.Columns[2].Width = 82;
        }

        private void computation()
        {
            try
            {
                main.select_string = "Select SUM(TotalAmount) From Sold_medicine Where TransactionID = '" + main.transaction_id + "'";
                sales_class.transaction_number();
                main.final_total = double.Parse(main.code_string);
                total.Text = main.final_total.ToString("0,0.00");
                main.discount_amount = main.discount_percentage * main.final_total;
                discount.Text = main.discount_amount.ToString("0,0.00");
                main.subtotal_amount = main.final_total - main.discount_amount;
                subtotal.Text = main.subtotal_amount.ToString("0,0.00");
                main.vat_amount = main.vat_percentage * main.subtotal_amount;
                vat.Text = main.vat_amount.ToString("0,0.00");
                main.total_due_amount = main.subtotal_amount + main.vat_amount;
                total_due.Text = main.total_due_amount.ToString("0,0.00");
                total_label.Text = main.total_due_amount.ToString("0,0.00");
            }
            catch
            {
                string value = "0.00";
                total_label.Text = value;
                total.Text = value;
                discount.Text = value;
                subtotal.Text = value;
                vat.Text = value;
                total_due.Text = value;
            }
        }

        private void add_medicine()
        {
            main.select_string = "Select Stocks From Medicine Where Code = '" + main.code + "'";
            sales_class.transaction_number();
            main.new_stock = int.Parse(main.code_string);
            main.new_stock = main.new_stock - int.Parse(quantity.Text);
            main.stock = main.new_stock.ToString();
            main.select_string = "Update Medicine Set Stocks = '" + main.stock + "' Where Code = '" + main.code + "'";
            sales_class.medicine_add();
            select_medicine();
            computation();
            quantity.Text = "1";
            quantity.Visible = false;
            medicine_clear();
            search_medicine.Text = "";
            search_medicine.Focus();
        }

        private void quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main.on_off = 0;
                main.code = stock_code.Text;
                main.medicinename = stock_medicinename.Text;
                main.dosage = stock_dosage.Text;
                main.quantity = int.Parse(quantity.Text);
                main.date = date.Text;
                main.total_amount = main.quantity * double.Parse(stock_price.Text);
                main.select_string = "Select Stocks From Medicine Where Code = '"+main.code+"'";
                sales_class.transaction_number();
                if (main.quantity == 0 || int.Parse(main.code_string) < main.quantity)
                {
                    MessageBox.Show("INVALID QUANTITY", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    main.select_string = "Select Count(*) From Sold_medicine Where TransactionID = '"+main.transaction_id+"' and MedicineName = '"+main.medicinename+"' and Dosage = '"+main.dosage+"'";
                    sales_class.medicine_order();
                    if (main.tmp == 1)
                    {
                        main.select_string = "Select Quantity From Sold_medicine Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.transaction_number();
                        main.quantity = main.quantity + int.Parse(main.code_string);
                        main.total_amount = main.quantity * double.Parse(stock_price.Text);
                        main.select_string = "Update Sold_medicine Set Quantity = '" + main.quantity + "',TotalAmount = '"+main.total_amount+"' Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.medicine_add();
                        add_medicine();
                        medicine_inventory_class.medicine_out_of_stock();
                    }
                    else
                    {
                        main.select_string = "Insert Into Sold_medicine(TransactionID,Date,MedicineName,Quantity,TotalAmount,Dosage,StaffName) values('" + main.transaction_id + "','" + main.date + "','" + main.medicinename + "','" + main.quantity + "','" + main.total_amount + "','" + main.dosage + "','" + main.staffname + "')";
                        sales_class.medicine_add();
                        add_medicine();
                        medicine_inventory_class.medicine_out_of_stock();
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                quantity.Visible = false;
                medicine_clear();
                quantity.Text = "1";
                search_medicine.Text = "";
                search_medicine.Focus();
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

        private void transaction_compute_clear()
        {
            string value = "0.00";
            total_label.Text = value;
            total.Text = value;
            discount.Text = value;
            subtotal.Text = value;
            vat.Text = value;
            total_due.Text = value;
            quantity.Visible = false;
            signout.Enabled = true;
            main.transaction_id = "";
            main.discount_percentage = 0;
            medicine_clear();
            search_medicine.Text = "";
            transaction_id.Text = "TRANSACTION ID: ";
            select_medicine();
            password_panel.Visible = false;
            void_medicine_panel.Visible = false;
        }
        private void medicine_order_cancel()
        {
            var rows = datagrid.Rows.Count.ToString();
            for (int i = 0; i < int.Parse(rows); i++)
            {
                main.select_string = "Select Stocks From Medicine Where MedicineName = '" + datagrid.Rows[i].Cells[0].Value.ToString() + "' and Dosage = '" + datagrid.Rows[i].Cells[1].Value.ToString() + "'";
                sales_class.transaction_number();
                if (main.code_string == "Out Of Stock")
                {
                    main.code_string = "0";
                }
                int stocks = int.Parse(main.code_string) + int.Parse(datagrid.Rows[i].Cells[2].Value.ToString());
                main.select_string = "Update Medicine Set Stocks = '" + stocks + "' Where MedicineName = '" + datagrid.Rows[i].Cells[0].Value.ToString() + "' and Dosage = '" + datagrid.Rows[i].Cells[1].Value.ToString() + "'";
                sales_class.medicine_add();
            }
            main.select_string = "Delete From Sold_medicine Where TransactionID = '" + main.transaction_id + "'";
            sales_class.medicine_add();
        }
        private void cancel_transaction_method()
        {
            discount_label.Text = "DISCOUNT";
            medicine_order_cancel();
            transaction_compute_clear();
        }
        private void cancel_transaction_Click(object sender, EventArgs e)
        {
            cancel_transaction_method();
        }
        private void void_method()
        {
            if (main.transaction_id == "")
            {
                main.on_off = 0;
                MessageBox.Show("PRESS F1 OR CLICK NEW TRANSACTION BUTTON TO ADD NEW TRANSACTION", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    main.medicinename = datagrid.SelectedRows[0].Cells[0].Value.ToString();
                    main.dosage = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                    if (main.medicinename == "")
                    {
                        main.on_off = 0;
                        password_panel.Visible = false;
                        MessageBox.Show("SELECT MEDICINE TO VOID", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        main.on_off = 1;
                        password_panel.Visible = true;
                        password.Text = "";
                        password.Focus();

                    }
                }
                catch
                {
                    MessageBox.Show("SELECT MEDICINE TO VOID", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }
        private void void_medicine_Click(object sender, EventArgs e)
        {
            void_method();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                main.select_string = "Select Count(*) From Admin_account Where Password = '"+password.Text+"'";
                sales_class.medicine_order();
                if (main.tmp == 1)
                {
                    password_panel.Visible = false;
                    void_medicine_panel.Visible = true;
                    void_quantity_deduct.Text = "";
                    void_medicinename.Text = main.medicinename;
                    void_dosage.Text = main.dosage;
                    void_current_quantity.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
                    void_quantity_deduct.Focus();
                    search_medicine.Text = "";
                    medicine_clear();
                }
                else
                {
                    main.on_off = 1;
                    MessageBox.Show("INCORRECT PASSWORD", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                datagrid.CurrentCell = null;
                password_panel.Visible = false;
                search_medicine.Text = "";
                search_medicine.Focus();
            }
        }

        private void return_stock()
        {
            main.select_string = "Select Stocks From Medicine Where MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
            sales_class.transaction_number();
            main.new_stock = int.Parse(main.code_string);
            if (main.f8 == 1)
            {
                main.new_stock = main.new_stock + int.Parse(void_current_quantity.Text);
            }
            else
            {
                main.new_stock = main.new_stock + int.Parse(void_quantity_deduct.Text);
            }
            main.stock = main.new_stock.ToString();
            main.select_string = "Update Medicine Set Stocks = '" + main.stock + "' Where MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
            sales_class.medicine_add();
        }
        private void remove_medicine()
        {
            main.medicinename = void_medicinename.Text;
            main.dosage = void_dosage.Text;
            main.select_string = "Delete From Sold_medicine Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
            sales_class.medicine_add();
            return_stock();
            select_medicine();
            computation();
            search_medicine.Focus();
        }
        private void void_quantity_deduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main.f8 = 0;
                try
                {
                    main.quantity = int.Parse(void_quantity_deduct.Text);
                }
                catch
                { }
                if (main.quantity == 0 || int.Parse(void_current_quantity.Text) < main.quantity)
                {
                    MessageBox.Show("INVALID QUANTITY", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    main.on_off = 0;
                    search_medicine.Focus();
                    main.medicinename = void_medicinename.Text;
                    main.dosage = void_dosage.Text;
                    main.quantity = int.Parse(void_current_quantity.Text) - int.Parse(void_quantity_deduct.Text);
                    if (main.quantity == 0)
                    {
                        main.f8 = 1;
                        remove_medicine();
                        void_medicine_panel.Visible = false;
                        search_medicine.Focus();
                    }
                    else
                    {
                        main.select_string = "Select Price From Medicine Where MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.transaction_number();
                        main.total_amount = main.quantity * double.Parse(main.code_string);
                        main.select_string = "Update Sold_medicine Set Quantity = '" + main.quantity + "',TotalAmount = '" + main.total_amount + "' Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.medicine_add();
                        return_stock();
                        select_medicine();
                        computation();
                        void_medicine_panel.Visible = false;
                        search_medicine.Focus();
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                void_medicine_panel.Visible = false;
                datagrid.CurrentCell = null;
                search_medicine.Focus();
            }
            else if (e.KeyCode == Keys.F8)
            {
                main.on_off = 0;
                main.f8 = 1;
                remove_medicine();
                void_medicine_panel.Visible = false;
                search_medicine.Focus();
            }
        }

        private void void_quantity_deduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void discount_method()
        {
            if (main.transaction_id == "")
            {
                main.on_off = 0;
                MessageBox.Show("PRESS F1 OR CLICK NEW TRANSACTION BUTTON TO ADD NEW TRANSACTION", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                main.on_off = 1;
                discount_panel.Visible = true;
                type_customer.Text = "SENIOR";
                customer_name.Text = "";
                id_number.Text = "";
                customer_name.Focus();
                compute_discount();
            }
        }
        private void discount_button_Click(object sender, EventArgs e)
        {
            discount_method();
        }

        private void customer_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void type_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void compute_discount()
        {
            main.type_of_customer = type_customer.Text;
            main.select_string = "Select DISCOUNT From Discount Where CUSTOMER = '"+ main.type_of_customer +"'";
            sales_class.transaction_number();
            discount_percentage.Text = double.Parse(main.code_string) * 100 + "%";
            main.discount_percentage = double.Parse(main.code_string);
        }
        private void type_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            compute_discount();
            customer_name.Focus();
        }

        private void customer_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main.customer_name = customer_name.Text;
                id_number.Focus();
            }
            else if (e.KeyCode == Keys.F11)
            {
                type_customer.Text = "SENIOR";
                compute_discount();
                customer_name.Focus();
            }
            else if (e.KeyCode == Keys.F12)
            {
                type_customer.Text = "PWD";
                compute_discount();
                customer_name.Focus();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                discount_panel.Visible = false;
                search_medicine.Focus();
            }
        }

        private void id_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main.on_off = 0;
                main.type_of_customer = type_customer.Text;
                main.customer_name = customer_name.Text;
                main.id_number = id_number.Text;
                discount_panel.Visible = false;
                computation();
                discount_label.Text = "DISCOUNT " +discount_percentage.Text;
                search_medicine.Focus();
            }
            else if (e.KeyCode == Keys.F11)
            {
                type_customer.Text = "SENIOR";
                compute_discount();
                id_number.Focus();
            }
            else if (e.KeyCode == Keys.F12)
            {
                type_customer.Text = "PWD";
                compute_discount();
                id_number.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                discount_panel.Visible = false;
                search_medicine.Focus();
            }
        }
        private void close_inquiry_method()
        {
            inquiry_panel.Visible = false;
            inquiry_quantity.Visible = false;
            search_medicine.Text = "";
            search_medicine.Focus();
            main.on_off = 0;
            main.inquiry_on = 0;
        }

        private void medicine_inquiry_method()
        {
            if (main.transaction_id == "")
            {
                main.on_off = 0;
                MessageBox.Show("PRESS F1 OR CLICK NEW TRANSACTION BUTTON TO ADD NEW TRANSACTION", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                medicine_clear();
                main.on_off = 1;
                main.inquiry_on = 1;
                inquiry_panel.Visible = true;
                search.Text = "";
                search.Focus();
                main.select_string = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock' and Stocks > 5 order by Code asc";
                datagrid_inquiry.DataSource = sales_class.select();
                datagrid_inquiry.CurrentCell = null;
                datagrid_inquiry.Columns[0].Width = 100;
                datagrid_inquiry.Columns[1].Width = 230;
                datagrid_inquiry.Columns[2].Width = 160;
                datagrid_inquiry.Columns[3].Width = 230;
                datagrid_inquiry.Columns[4].Width = 200;
            } 
        }
        private void medicine_inquiry_Click(object sender, EventArgs e)
        {
            medicine_inquiry_method();
        }

        private void inquiry_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void datagrid_inquiry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid_inquiry.ClearSelection();
            datagrid_inquiry.CurrentCell = null;
        }

        private void datagrid_inquiry_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in datagrid_inquiry.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                main.select_string = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock' and Stocks > 5 order by Code asc";
                datagrid_inquiry.DataSource = sales_class.select();
                datagrid_inquiry.CurrentCell = null;
            }
            else
            {
                main.select_string = "Update Medicine set Stocks = '0' Where Stocks = 'Out Of Stock'";
                sales_class.medicine_add();
                main.search = search.Text;
                DataTable dt = sales_class.medicine_search();
                datagrid_inquiry.DataSource = dt;
                if (main.tmp_brandname == 1)
                {
                    datagrid.CurrentCell = null;
                }
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            search.Text = "";
            main.select_string = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock' and Stocks > 5 order by Code asc";
            datagrid_inquiry.DataSource = sales_class.select();
            datagrid_inquiry.CurrentCell = null;
        }

        private void datagrid_inquiry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                search.Text = "";
                main.select_string = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock' and Stocks > 5 order by Code asc";
                datagrid_inquiry.DataSource = sales_class.select();
                datagrid_inquiry.ClearSelection();
                datagrid_inquiry.CurrentCell = null;
                search.Focus();
            }
        }

        private void add_medicine_inquiry()
        {
            main.select_string = "Select Stocks From Medicine Where Code = '" + main.code + "'";
            sales_class.transaction_number();
            main.new_stock = int.Parse(main.code_string);
            main.new_stock = main.new_stock - int.Parse(inquiry_quantity.Text);
            main.stock = main.new_stock.ToString();
            main.select_string = "Update Medicine Set Stocks = '" + main.stock + "' Where Code = '" + main.code + "'";
            sales_class.medicine_add();
            select_medicine();
            computation();
            inquiry_quantity.Text = "1";
            inquiry_quantity.Visible = false;
            datagrid_inquiry.CurrentCell = null;
            search.Text = "";
            search.Focus();
        }

        private void inquiry_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main.code = datagrid_inquiry.SelectedRows[0].Cells[0].Value.ToString();
                main.medicinename = datagrid_inquiry.SelectedRows[0].Cells[1].Value.ToString();
                main.dosage = datagrid_inquiry.SelectedRows[0].Cells[4].Value.ToString();
                main.quantity = int.Parse(inquiry_quantity.Text);
                main.date = date.Text;
                main.total_amount = main.quantity * double.Parse(datagrid_inquiry.SelectedRows[0].Cells[6].Value.ToString());
                main.select_string = "Select Stocks From Medicine Where Code = '" + main.code + "'";
                sales_class.transaction_number();
                if (main.quantity == 0 || int.Parse(main.code_string) < main.quantity)
                {
                    MessageBox.Show("INVALID QUANTITY", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    main.select_string = "Select Count(*) From Sold_medicine Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                    sales_class.medicine_order();
                    if (main.tmp == 1)
                    {
                        main.select_string = "Select Quantity From Sold_medicine Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.transaction_number();
                        main.quantity = main.quantity + int.Parse(main.code_string);
                        main.total_amount = main.quantity * double.Parse(datagrid_inquiry.SelectedRows[0].Cells[6].Value.ToString());
                        main.select_string = "Update Sold_medicine Set Quantity = '" + main.quantity + "',TotalAmount = '" + main.total_amount + "' Where TransactionID = '" + main.transaction_id + "' and MedicineName = '" + main.medicinename + "' and Dosage = '" + main.dosage + "'";
                        sales_class.medicine_add();
                        add_medicine_inquiry();
                        medicine_inventory_class.medicine_out_of_stock();
                    }
                    else
                    {
                        main.select_string = "Insert Into Sold_medicine(TransactionID,Date,MedicineName,Quantity,TotalAmount,Dosage,StaffName) values('" + main.transaction_id + "','" + main.date + "','" + main.medicinename + "','" + main.quantity + "','" + main.total_amount + "','" + main.dosage + "','" + main.staffname + "')";
                        sales_class.medicine_add();
                        add_medicine_inquiry();
                        medicine_inventory_class.medicine_out_of_stock();
                    }
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                inquiry_quantity.Visible = false;
                datagrid_inquiry.CurrentCell = null;
                inquiry_quantity.Text = "1";
                search.Text = "";
                search.Focus();
            }
        }

        private void payment_method()
        {
            if (total_label.Text == "0.00")
            {
                MessageBox.Show("MEDICINE ORDER IS EMPTY", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.on_off = 1;
                payment_panel.Visible = true;
                payment_cash.Text = "0.00";
                payment_cash.Focus();
                payment_total.Text = total_label.Text;
                medicine_clear();
                search_medicine.Text = "";
            }
        }
         
        private void payment_Click(object sender, EventArgs e)
        {
            payment_method();
        }

        private void payment_cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && payment_cash.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void payment_data()
        {
            main.discount_amount = double.Parse(discount.Text);
            main.payment_total = double.Parse(payment_total.Text);
            main.payment_cash = double.Parse(payment_cash.Text);
            main.payment_change = double.Parse(payment_change.Text);
        }

        private void payment_cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                if (double.Parse(payment_cash.Text) < double.Parse(payment_total.Text) || payment_cash.Text == "")
                {
                    main.on_off = 1;
                    MessageBox.Show("INVALID CASH", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    payment_cash.Text = "";
                    payment_cash.Focus();
                }
                else
                {
                    main.on_off = 0;
                    payment_data();
                    main.select_string = "Insert Into Sales(TransactionID,Date,TotalAmount,Discount,Cash,Change,StaffName,TypeOfCustomer,IDnumber) values('" + main.transaction_id + "','" + main.date + "','" + main.payment_total + "','" + main.discount_amount + "','" + main.payment_cash + "','" + main.payment_change + "','" + main.staffname + "','" + main.type_of_customer + "','" + main.id_number + "')";
                    sales_class.medicine_add();
                    crystalreport.receipt_report report = new crystalreport.receipt_report();
                    (report.ReportDefinition.ReportObjects["discount"] as TextObject).Text = main.discount_amount.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["subtotal"] as TextObject).Text = main.subtotal_amount.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["vat"] as TextObject).Text = main.vat_amount.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["totaldue"] as TextObject).Text = main.total_due_amount.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["cash"] as TextObject).Text = main.payment_cash.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["change"] as TextObject).Text = main.payment_change.ToString("0,0.00");
                    (report.ReportDefinition.ReportObjects["transaction_id"] as TextObject).Text = main.transaction_id;
                    (report.ReportDefinition.ReportObjects["staffname"] as TextObject).Text = main.staffname;
                    if (main.type_of_customer == "REGULAR")
                    {
                        (report.ReportDefinition.ReportObjects["customer_label"] as TextObject).Text = "";
                        (report.ReportDefinition.ReportObjects["customer"] as TextObject).Text = "";
                        (report.ReportDefinition.ReportObjects["id_label"] as TextObject).Text = "";
                        (report.ReportDefinition.ReportObjects["id_number"] as TextObject).Text = "";
                    }
                    else
                    {
                        (report.ReportDefinition.ReportObjects["customer_label"] as TextObject).Text = "CUSTOMER:";
                        (report.ReportDefinition.ReportObjects["customer"] as TextObject).Text = main.customer_name;
                        (report.ReportDefinition.ReportObjects["id_label"] as TextObject).Text = "ID NUMBER:";
                        (report.ReportDefinition.ReportObjects["id_number"] as TextObject).Text = main.id_number;
                    }
                    string sql = "Select Quantity,MedicineName,TotalAmount From Sold_medicine Where TransactionID = '"+main.transaction_id+"'";
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                    adapter.Fill(ds, "Sold_medicine");
                    report.SetDataSource(ds.Tables["Sold_medicine"]);
                    report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    report.PrintToPrinter(1, false, 0, 0);
                    payment_panel.Visible = false;
                    search_medicine.Text = "";
                    search_medicine.Focus();
                    transaction_compute_clear();
                }
                }
                catch
                {
                    MessageBox.Show("INVALID CASH", "MESSSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                main.on_off = 0;
                payment_panel.Visible = false;
                search_medicine.Text = "";
                search_medicine.Focus();
            }
        }

        private void payment_cash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                payment_data();
                double change = main.payment_cash - main.payment_total;
                if (main.payment_cash < main.payment_total || payment_cash.Text == "")
                {
                    payment_change.Text = "0.00";
                }
                else
                {
                    payment_change.Text = change.ToString("0,0.00");
                }
            }
            catch
            { 
            }
        }

        private void datagrid_inquiry_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                main.select_string = "Select Prescription From Medicine Where Code = '" + datagrid_inquiry.SelectedRows[0].Cells[0].Value.ToString() + "'";
                sales_class.transaction_number();
                inquiry_prescription.Text = "DOCTOR PRESCRIPTION IS " + main.code_string;

            }
            catch
            {
                inquiry_prescription.Text = "";
            }
        }
    }
}
