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

namespace PMP
{
    public partial class staff_form : Form
    {
        staff_acount staff_account = new staff_acount();
        main main = new main();

        public staff_form()
        {
            InitializeComponent();
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 14, FontStyle.Bold);
            deactivate_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 14, FontStyle.Bold);
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
            staff_account_controltab();
            deact_controltab();
            admin_controltab();
        }
        private void staff_account_controltab()
        {
            search.Text = "Search Staff";
            search.ForeColor = Color.Gray;
            search.Enabled = true;
            datagrid.Enabled = true;
            button_panel.Enabled = true;
            add_panel.Visible = false;
            add_firstname.Text = "";
            add_lastname.Text = "";
            add_sex.Text = "-------SELECT GENDER--------";
            add_age.Text = "";
            add_contactnumber.Text = "";
            add_username.Text = "";
            add_password.Text = "";
            add_birthdate.Text = DateTime.Now.ToString();
            datagrid.DataSource = staff_account.staff_select();
            datagrid.CurrentCell = null;
        }
        private void disable()
        {
            datagrid.Enabled = false;
            search.Enabled = false;
            button_panel.Enabled = false;
            add_panel.Visible = true;
            datagrid.CurrentCell = null;
        }
        private void refresh()
        {
            datagrid.DataSource = staff_account.staff_select();
            datagrid.CurrentCell = null;
        }

        private void datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid.CurrentCell = null;
            datagrid.ClearSelection();
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
            if (search.Text == "Search Staff")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Staff";
                search.ForeColor = Color.Gray;
                refresh();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "Search Staff")
            {
                refresh();
            }
            else
            {
                main.search = search.Text;
                DataTable dt = staff_account.staff_search();
                datagrid.DataSource = dt;

                if (main.staff_tmp == 1)
                {
                    datagrid.CurrentCell = null;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            staff_account_controltab();
        }

        private void add_Click(object sender, EventArgs e)
        {
            staff_account_controltab();
            disable();
            add_label.Text = "CREATE STAFF ACCOUNT";
            add_firstname.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                main.firstname = datagrid.SelectedRows[0].Cells[0].Value.ToString();
                main.lastname = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch
            {
                main.firstname = "";
            }
            if (main.firstname == "")
            {
                MessageBox.Show("SELECT STAFF ACCOUNT TO UPDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    main.con.Open();
                    string sql = "select FirstName,LastName,Sex,Age,BirthDate,ContactNumber,Username,Password from Staff_account Where FirstName = '" + main.firstname + "' and LastName = '" + main.lastname + "'";
                    SqlCommand cmd = new SqlCommand(sql, main.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        add_firstname.Text = (dr["FirstName"].ToString());
                        add_lastname.Text = (dr["LastName"].ToString());
                        add_sex.Text = (dr["Sex"].ToString());
                        add_age.Text = (dr["Age"].ToString());
                        add_birthdate.Text = (dr["BirthDate"].ToString());
                        add_contactnumber.Text = (dr["ContactNumber"].ToString());
                        add_username.Text = (dr["Username"].ToString());
                        add_password.Text = (dr["Password"].ToString());
                        main.tmp_username = add_username.Text;
                        main.update_firstname = add_firstname.Text;
                        main.update_lastname = add_lastname.Text;
                    }
                    main.con.Close();
                }
                catch
                {
                }
                disable();
                add_label.Text = "UPDATE STAFF ACCOUNT";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                main.firstname = datagrid.SelectedRows[0].Cells[0].Value.ToString();
                main.lastname = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult message = MessageBox.Show( "Are you sure you want to DEACTIVATE account of " + main.firstname + " " + main.lastname + " ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    main.select_string = "Update Staff_account set Status = 'DEACTIVATE' where FirstName = '" + main.firstname + "' and LastName = '" + main.lastname + "'";
                    sales_class sales_class = new sales_class();
                    sales_class.medicine_add();
                    MessageBox.Show("STAFF ACCOUNT TO DEACTIVATED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            catch
            {
                MessageBox.Show("SELECT STAFF ACCOUNT TO DEACTIVATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            main.firstname = add_firstname.Text;
            main.lastname = add_lastname.Text;
            main.age = add_age.Text;
            main.birthdate = add_birthdate.Text;
            main.contactnumber = add_contactnumber.Text;
            main.username = add_username.Text;
            main.password = add_password.Text;
            main.sex = add_sex.Text;

            if (add_label.Text == "CREATE STAFF ACCOUNT")
            {
                if (add_firstname.Text == "" || add_sex.Text == "-------SELECT GENDER--------" || add_lastname.Text == "" || add_contactnumber.Text == "" || add_age.Text == "" || add_username.Text == "" || add_password.Text == "")
                {
                    MessageBox.Show("INCOMPLETE DATA TO SAVE STAFF ACCOUNT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (add_birthdate.Text == DateTime.Now.ToShortDateString())
                    {
                        MessageBox.Show("INVALID BIRTHDATE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        staff_account.staff_staff_name();
                        if (main.staff_tmp == 1)
                        {
                            main.staff_username();
                            if (main.staff_tmp == 1)
                            {
                                main.createaccount();
                                staff_account_controltab();
                                refresh();
                            }
                        }
                    }
                }
            }
            else
            {
                if (main.firstname == main.update_firstname && main.lastname == main.update_lastname)
                {
                    if (main.tmp_username == main.username)
                    {
                        staff_account.staff_update();
                        staff_account_controltab();
                        refresh();
                    }
                    else
                    {
                        main.staff_username();
                        if (main.staff_tmp == 1)
                        {
                            staff_account.staff_update();
                            staff_account_controltab();
                            refresh();
                        }
                    }
                }
                else
                {
                    staff_account.staff_staff_name();
                    if (main.staff_tmp == 1)
                    {
                        if (main.tmp_username == main.username)
                        {
                            staff_account.staff_update();
                            staff_account_controltab();
                            refresh();
                        }
                        else
                        {
                            main.staff_username();
                            if (main.staff_tmp == 1)
                            {
                                staff_account.staff_update();
                                staff_account_controltab();
                                refresh();
                            }
                        }
                    }
                }
            }
        }

        private void add_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void add_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void add_sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void add_contactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void add_birthdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void add_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void add_birthdate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var today = DateTime.Today;
                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (add_birthdate.Value.Year * 100 + add_birthdate.Value.Month) * 100 + add_birthdate.Value.Day;
                add_age.Text = (a - b) / 10000 + "";
            }
            catch
            { }
        }

        private void deact_controltab()
        {
            deact_refresh();
            deactivate_search.Text = "Search Staff";
            deactivate_search.ForeColor = Color.Gray;
        }

        private void deact_refresh()
        {
            deactivate_datagrid.DataSource = staff_account.deact_select();
            deactivate_datagrid.CurrentCell = null;
        }

        private void deactivate_search_Enter(object sender, EventArgs e)
        {
            if (deactivate_search.Text == "Search Staff")
            {
                deactivate_search.Text = "";
                deactivate_search.ForeColor = Color.Black;
            }
        }

        private void deactivate_search_Leave(object sender, EventArgs e)
        {
            if (deactivate_search.Text == "")
            {
                deactivate_search.Text = "Search Staff";
                deactivate_search.ForeColor = Color.Gray;
                deact_refresh();
            }
        }

        private void deactivate_search_TextChanged(object sender, EventArgs e)
        {
            if (deactivate_search.Text == "Search Staff")
            {
                deact_refresh();
            }
            else
            {
                main.search = deactivate_search.Text;
                DataTable dt = staff_account.deact_search();
                deactivate_datagrid.DataSource = dt;

                if (main.staff_tmp == 1)
                {
                    deactivate_datagrid.CurrentCell = null;
                }
            }
        }

        private void deactivate_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in deactivate_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void admin_controltab()
        {
            main.con.Open();
            string sql = "Select Username,Password from Admin_account";
            SqlCommand cmd = new SqlCommand(sql, main.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                admin_username.Text = dr["Username"].ToString();
                admin_password.Text = dr["Password"].ToString();
                main.con.Close();
            }
            else 
            {
                main.con.Close();
            }
        }

        private void admin_update_Click(object sender, EventArgs e)
        {
            main.username = admin_username.Text;
            main.password = admin_password.Text;
            sales_class sales_class = new sales_class();
            main.select_string = "Update Admin_account Set Username = '"+main.username+"', Password = '"+main.password+"'";
            sales_class.medicine_add();
            MessageBox.Show("ADMIN ACCOUNT SUCCESSFULLY UPDATED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
