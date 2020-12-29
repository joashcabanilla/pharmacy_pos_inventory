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
using CrystalDecisions.CrystalReports.Engine;

namespace PMP
{
    public partial class maintenance_form : Form
    {
        maintenance_class maintenance_class = new maintenance_class();

        public maintenance_form()
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

        private void brand_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Focus();
            search.Text = "Search Brand Name";
            search.ForeColor = Color.Gray;
            comboBox1.Text = "ALL BRAND";
            if (brand_category.Text == "ALL BRAND")
            {
                datagrid.DataSource = maintenance_class.brandname_select();
                datagrid.CurrentCell = null;
            }
            else if (brand_category.Text == "BRANDED")
            {
                datagrid.DataSource = maintenance_class.branded_select();
                datagrid.CurrentCell = null;
            }
            else if (brand_category.Text == "GENERIC")
            {
                datagrid.DataSource = maintenance_class.generic_select();
                datagrid.CurrentCell = null;
            }
        }
        private void brandname_controltab()
        {
            datagrid.DataSource = maintenance_class.brandname_select();
            datagrid.CurrentCell = null;
            search.Text = "Search Brand Name";
            search.ForeColor = Color.Gray;
            brand_category.Text = "ALL BRAND";
            add_panel.Visible = false;
            brandname.Text = "";
            add_brand_category.Text = "-------SELECT BRAND--------";
            datagrid.Enabled = true;
            search.Enabled = true;
            brand_category.Enabled = true;
            button_panel.Enabled = true;
            comboBox1.Enabled = true;
            print.Enabled = true;
            comboBox1.Text = "ALL BRAND";
        }

        private void menu_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
                brandname_controltab();
                medicine_controltab();
                dosage_controltab();
                discount_controltab();
                vat_controltab();
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "Search Brand Name")
            {
                datagrid.DataSource = maintenance_class.brandname_select();
                datagrid.CurrentCell = null;
                
            }
            else
            {
                main.search = search.Text;
                DataTable dt = maintenance_class.brandname_search();
                datagrid.DataSource = dt;
                if (main.tmp_brandname == 1)
                {
                    datagrid.CurrentCell = null;
                }
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search Brand Name")
            {
                brand_category.Text = "ALL BRAND";
                comboBox1.Text = "ALL BRAND";
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Brand Name";
                search.ForeColor = Color.Gray;
                brand_category.Text = "ALL BRAND";
                datagrid.DataSource = maintenance_class.brandname_select();
                datagrid.CurrentCell = null;
                
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            medicine_label.Text = "ADD BRAND NAME";
            add_update();
            brandname.Focus();
        }

        private void add_update()
        {
            comboBox1.Text = "ALL BRAND";
            search.Text = "Search Brand Name";
            search.ForeColor = Color.Gray;
            brand_category.Text = "ALL BRAND";
            add_panel.Visible = true;
            datagrid.DataSource = maintenance_class.brandname_select();
            datagrid.CurrentCell = null;
            
            datagrid.Enabled = false;
            search.Enabled = false;
            brand_category.Enabled = false;
            button_panel.Enabled = false;
            print.Enabled = false;
            comboBox1.Enabled = false;
            
        }

        private void save_method()
        {
            add_panel.Visible = false;
            brandname.Text = "";
            add_brand_category.Text = "-------SELECT BRAND--------";
            datagrid.DataSource = maintenance_class.brandname_select();
            datagrid.CurrentCell = null;
            comboBox1.Text = "ALL BRAND";
            datagrid.Enabled = true;
            search.Enabled = true;
            brand_category.Enabled = true;
            button_panel.Enabled = true;
            print.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            save_method();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                brandname.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                add_brand_category.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                brandname.Text = "";
            }

            if (brandname.Text == "")
            {
                MessageBox.Show("SELECT BRAND NAME TO UPDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.brandname = brandname.Text;
                medicine_label.Text = "UPDATE BRAND NAME";
                add_update();
                brandname.Focus();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                brandname.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                brandname.Text = "";
            }

            if (brandname.Text == "")
            {
                MessageBox.Show("SELECT BRAND NAME TO DELETE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    main.brandname = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                    main.brandcategory = datagrid.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE THIS BRAND NAME?", "DELETE BRAND NAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        maintenance_class.delete_brandname();
                        search.Text = "Search Brand Name";
                        search.ForeColor = Color.Gray;
                        brand_category.Text = "ALL BRAND";
                        comboBox1.Text = "ALL BRAND";
                        datagrid.DataSource = maintenance_class.brandname_select();
                        datagrid.CurrentCell = null;
                        
                    }
                }
                catch
                { 
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (add_brand_category.Text == "-------SELECT BRAND--------")
            {
                MessageBox.Show("SELECT BRAND CATEGORY", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.new_brandname = brandname.Text;
                main.brandcategory = add_brand_category.Text;

                if (medicine_label.Text == "ADD BRAND NAME")
                {
                    if (brandname.Text == "")
                    {
                        MessageBox.Show("ENTER BRAND NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        maintenance_class.add_brandname();
                        save_method();
                    }
                }
                else
                {
                    maintenance_class.update_brandname();
                    save_method();
                }
            }
        }

        private void add_brand_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandname.Focus();
        }

        private void add_brand_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void print_Click(object sender, EventArgs e)
        {
            crystalreport.brand_list_report brand_list = new crystalreport.brand_list_report();

            if (comboBox1.Text == "ALL BRAND")
            {
                string sql = "select * From Brand_list";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Brand_list");
                brand_list.SetDataSource(ds.Tables["Brand_list"]);
            }
            else if (comboBox1.Text == "BRANDED")
            {
                string sql = "select * From Brand_list where BrandCategory = 'BRANDED'";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Brand_list");
                brand_list.SetDataSource(ds.Tables["Brand_list"]);
            }
            else if (comboBox1.Text == "GENERIC")
            {
                string sql = "select * From Brand_list where BrandCategory = 'GENERIC'";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
                adapter.Fill(ds, "Brand_list");
                brand_list.SetDataSource(ds.Tables["Brand_list"]);  
            }

            brand_list.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            brand_list.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            brand_list.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("BRAND LIST SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Text = "ALL BRAND";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Focus();
        }

        //MEDICINE TAB------------------------------------------------------------------------------------------------------------------------------------------------
        private void medicine_controltab()
        {
            medicine_datagrid.DataSource = maintenance_class.medicine_select();
            medicine_datagrid.CurrentCell = null;
            medicine_search.Text = "Search Medicine Name";
            medicine_search.ForeColor = Color.Gray;
            medicine_add_panel.Visible = false;
            medicine_name.Text = "";
            medicine_datagrid.Enabled = true;
            medicine_search.Enabled = true;
            medicine_button_panel.Enabled = true;
            medicine_print.Enabled = true;
        }

        private void medicine_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            medicine_datagrid.ClearSelection();
            medicine_datagrid.CurrentCell = null;
        }

        private void medicine_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in medicine_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void medicine_search_Enter(object sender, EventArgs e)
        {
            if (medicine_search.Text == "Search Medicine Name")
            {
                medicine_search.Text = "";
                medicine_search.ForeColor = Color.Black;
            }
        }

        private void medicine_search_Leave(object sender, EventArgs e)
        {
            if (medicine_search.Text == "")
            {
                medicine_search.Text = "Search Medicine Name";
                medicine_search.ForeColor = Color.Gray;
            }
        }

        private void medicine_search_TextChanged(object sender, EventArgs e)
        {
            if (medicine_search.Text == "Search Medicine Name")
            {
                medicine_datagrid.DataSource = maintenance_class.medicine_select();
                medicine_datagrid.CurrentCell = null;

            }
            else
            {
                main.search = medicine_search.Text;
                DataTable dt = maintenance_class.medicine_search();
                medicine_datagrid.DataSource = dt;
                if (main.tmp_brandname == 1)
                {
                    medicine_datagrid.CurrentCell = null;
                }
            }
        }
        private void add_medicine()
        {
            medicine_search.Text = "Search Medicine Name";
            medicine_search.ForeColor = Color.Gray;
            medicine_button_panel.Enabled = false;
            medicine_add_panel.Visible = true;
            medicine_search.Enabled = false;
            medicine_datagrid.Enabled = false;
            medicine_print.Enabled = false;
            medicine_datagrid.DataSource = maintenance_class.medicine_select();
            medicine_datagrid.CurrentCell = null;
        }

        private void save_medicine()
        {
            medicine_search.Text = "Search Medicine Name";
            medicine_search.ForeColor = Color.Gray;
            medicine_button_panel.Enabled = true;
            medicine_add_panel.Visible = false;
            medicine_search.Enabled = true;
            medicine_datagrid.Enabled = true;
            medicine_print.Enabled = true;
            medicine_datagrid.DataSource = maintenance_class.medicine_select();
            medicine_datagrid.CurrentCell = null;
            medicine_name.Text = "";
        }

        private void medicine_close_Click(object sender, EventArgs e)
        {
            save_medicine();
        }

        private void medicine_update_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_name.Text = medicine_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                medicine_name.Text = "";
            }

            if (medicine_name.Text == "")
            {
                MessageBox.Show("SELECT MEDICINE NAME TO UPDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.medicinename = medicine_name.Text;
                medicine_add_label.Text = "UPDATE MEDICINE NAME";
                add_medicine();
                medicine_name.Focus();
            }
        }

        private void medicine_delete_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_name.Text = medicine_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                medicine_name.Text = "";
            }

            if (medicine_name.Text == "")
            {
                MessageBox.Show("SELECT MEDICINE NAME TO DELETE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    main.medicinename = medicine_datagrid.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE THIS MEDICINE NAME?", "DELETE MEDICINE NAME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        maintenance_class.delete_medicine();
                        save_medicine();
                    }
                }
                catch
                {
                }
            }
        }

        private void medicine_save_Click(object sender, EventArgs e)
        {
            if (medicine_name.Text == "")
            {
                MessageBox.Show("ENTER MEDICINE NAME", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.new_medicinename = medicine_name.Text;
                
               if (medicine_add_label.Text == "ADD MEDICINE NAME")
                {
                    maintenance_class.add_medicine();
                    save_medicine();
                }
                else
                {
                    maintenance_class.update_medicine();
                    save_medicine();
                }
            }
        }

        private void medicine_add_Click(object sender, EventArgs e)
        {
            medicine_add_label.Text = "ADD MEDICINE NAME";
            add_medicine();
            medicine_name.Focus();
        }

        private void medicine_print_Click(object sender, EventArgs e)
        {
            crystalreport.medicine_list_report report = new crystalreport.medicine_list_report();
            string sql = "select * From Medicine_list order by MedicineName asc";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
            adapter.Fill(ds, "Medicine_list");
            report.SetDataSource(ds.Tables["Medicine_list"]);  
            report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("MEDICINE LIST SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //DOSAGE--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void dosage_controltab()
        {
            dosage_datagrid.DataSource = maintenance_class.dosage_select();
            dosage_datagrid.CurrentCell = null;
            dosage_search.Text = "Search Dosage";
            dosage_search.ForeColor = Color.Gray;
            dosage_add_panel.Visible = false;
            dosage.Text = "";
            dosage_datagrid.Enabled = true;
            dosage_search.Enabled = true;
            dosage_button_panel.Enabled = true;
            dosage_print.Enabled = true;
        }

        private void dosage_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dosage_datagrid.ClearSelection();
            dosage_datagrid.CurrentCell = null;
        }

        private void dosage_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dosage_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dosage_search_Enter(object sender, EventArgs e)
        {
            if (dosage_search.Text == "Search Dosage")
            {
                dosage_search.Text = "";
                dosage_search.ForeColor = Color.Black;
            }
        }

        private void dosage_search_Leave(object sender, EventArgs e)
        {
            if (dosage_search.Text == "")
            {
                dosage_search.Text = "Search Dosage";
                dosage_search.ForeColor = Color.Gray;
            }
        }

        private void dosage_search_TextChanged(object sender, EventArgs e)
        {
            if (dosage_search.Text == "Search Dosage")
            {
                dosage_datagrid.DataSource = maintenance_class.dosage_select();
                dosage_datagrid.CurrentCell = null;

            }
            else
            {
                main.search = dosage_search.Text;
                DataTable dt = maintenance_class.dosage_search();
                dosage_datagrid.DataSource = dt;
                if (main.tmp_brandname == 1)
                {
                    dosage_datagrid.CurrentCell = null;
                }
            }
        }

        private void add_dosage()
        {
            dosage_add_panel.Visible = true;
            dosage_search.Text = "Search Dosage";
            dosage_search.ForeColor = Color.Gray;
            dosage_button_panel.Enabled = false;
            dosage_search.Enabled = false;
            dosage_datagrid.Enabled = false;
            dosage_print.Enabled = false;
            dosage_datagrid.DataSource = maintenance_class.dosage_select();
            dosage_datagrid.CurrentCell = null;
        }

        private void save_dosage()
        {
            dosage_search.Text = "Search Dosage";
            dosage_search.ForeColor = Color.Gray;
            dosage_button_panel.Enabled = true;
            dosage_add_panel.Visible = false;
            dosage_search.Enabled = true;
            dosage_datagrid.Enabled = true;
            dosage_print.Enabled = true;
            dosage_datagrid.DataSource = maintenance_class.dosage_select();
            dosage_datagrid.CurrentCell = null;
            dosage.Text = "";
        }

        private void dosage_close_Click(object sender, EventArgs e)
        {
            save_dosage();
        }

        private void dosage_update_Click(object sender, EventArgs e)
        {
            try
            {
                dosage.Text = dosage_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                dosage.Text = "";
            }

            if (dosage.Text == "")
            {
                MessageBox.Show("SELECT DOSAGE TO UPDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.dosage = dosage.Text;
                dosage_add_label.Text = "UPDATE DOSAGE";
                add_dosage();
                dosage.Focus();
            }
        }

        private void dosage_delete_Click(object sender, EventArgs e)
        {
            try
            {
                dosage.Text = dosage_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                dosage.Text = "";
            }

            if (dosage.Text == "")
            {
                MessageBox.Show("SELECT DOSAGE TO DELETE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    main.dosage = dosage_datagrid.SelectedRows[0].Cells[0].Value.ToString();

                    DialogResult message = MessageBox.Show("ARE YOU SURE YOU WANT TO PERMANENTLY DELETE THIS DOSAGE?", "DELETE DOSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        maintenance_class.delete_dosage();
                        save_dosage();
                    }
                }
                catch
                {
                }
            }
        }

        private void dosage_save_Click(object sender, EventArgs e)
        {
            if (dosage.Text == "")
            {
                MessageBox.Show("ENTER DOSAGE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.new_dosage = dosage.Text;

                if (dosage_add_label.Text == "ADD DOSAGE")
                {
                    maintenance_class.add_dosage();
                    save_dosage();
                }
                else
                {
                    maintenance_class.update_dosage();
                    save_dosage();
                }
            }
        }

        private void dosage_add_Click(object sender, EventArgs e)
        {
            dosage_add_label.Text = "ADD DOSAGE";
            add_dosage();
            dosage.Focus();
        }

        private void dosage_print_Click(object sender, EventArgs e)
        {
            crystalreport.dosage_list report = new crystalreport.dosage_list();
            string sql = "select * From Dosage_list order by Dosage asc";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
            adapter.Fill(ds, "Dosage_list");
            report.SetDataSource(ds.Tables["Dosage_list"]);
            report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("DOSAGE LIST SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //DISCOUNT----------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void discount_controltab()
        {
            discount.Focus();
            discount.Text = "";
            discount_combobox.Text = "SENIOR";
            discount_datagrid.DataSource = maintenance_class.discount_select();
            discount_datagrid.CurrentCell = null;
        }
        private void vat_controltab()
        {
            vat_percentage.Focus();
            vat_percentage.Text = "";
            vat_datagrid.DataSource = maintenance_class.vat_select();
            vat_datagrid.CurrentCell = null;
        }

        private void discount_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in discount_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void discount_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            discount_datagrid.ClearSelection();
            discount_datagrid.CurrentCell = null;
        }

        private void update_discount_Click(object sender, EventArgs e)
        {
            if (discount.Text == "")
            {
                MessageBox.Show("ENTER DISCOUNT PERCENTAGE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.discount = double.Parse(discount.Text);
                main.customer = discount_combobox.Text;
                maintenance_class.update_discount();
                discount.Text = "";
                discount_datagrid.DataSource = maintenance_class.discount_select();
                discount_datagrid.CurrentCell = null;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && discount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void discount_combobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void discount_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            discount.Focus();
        }

        private void brand_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void vat_update_Click(object sender, EventArgs e)
        {
            if (vat_percentage.Text == "")
            {
                MessageBox.Show("ENTER VAT PERCENTAGE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                main.vat = double.Parse(vat_percentage.Text);
                maintenance_class.update_vat();
                vat_percentage.Text = "";
                vat_datagrid.DataSource = maintenance_class.vat_select();
                vat_datagrid.CurrentCell = null;
            }
        }

        private void vat_percentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && vat_percentage.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void vat_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            vat_datagrid.ClearSelection();
            vat_datagrid.CurrentCell = null;
        }

        private void vat_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in vat_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
