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
    public partial class sales_form : Form
    {
        sales_class sales_class = new sales_class();
        crystalreport.transaction_report report = new crystalreport.transaction_report();
        crystalreport.Sold_medicine_report sold_report = new crystalreport.Sold_medicine_report();

        public sales_form()
        {
            InitializeComponent();
            datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
            sold_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 16, FontStyle.Bold);
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

        private void resetdate()
        {
            date_from.Text = DateTime.Now.ToString();
            date_to.Text = DateTime.Now.ToString();
        }
        private void sold_resetdate()
        {
            sold_date_from.Text = DateTime.Now.ToString();
            sold_date_to.Text = DateTime.Now.ToString();
        }
        private void backcolor()
        {
            daily.BackColor = Color.FromArgb(255, 255, 221);
            weekly.BackColor = Color.FromArgb(255, 255, 221);
            monthly.BackColor = Color.FromArgb(255, 255, 221);
            annually.BackColor = Color.FromArgb(255, 255, 221);
        }
        private void sold_backcolor()
        {
            sold_daily.BackColor = Color.FromArgb(255, 255, 221);
            sold_weekly.BackColor = Color.FromArgb(255, 255, 221);
            sold_monthly.BackColor = Color.FromArgb(255, 255, 221);
            sold_annually.BackColor = Color.FromArgb(255, 255, 221);
        }
        private void sales_record(DateTime firstday, DateTime lastday)
        {
            try
            {
                main.select_string = "Select TransactionID AS 'Transaction ID',TotalAmount AS 'Total Amount',Discount,Cash,Change,Date,StaffName AS 'Staff Name' From Sales Where Date BETWEEN '" + firstday.ToShortDateString() + "' AND '" + lastday.ToShortDateString() + "' order by TransactionID asc";
                datagrid.DataSource = sales_class.select();
                datagrid.CurrentCell = null;
                main.select_string = "Select Count(*) From Sales Where Date BETWEEN '" + firstday.ToShortDateString() + "' AND '" + lastday.ToShortDateString() + "'";
                sales_class.transaction_number();
                transaction_number.Text = main.code_string;
                main.select_string = "Select Sum(TotalAmount) From Sales Where Date BETWEEN '" + firstday.ToShortDateString() + "' AND '" + lastday.ToShortDateString() + "'";
                sales_class.transaction_number();
                double total1 = double.Parse(main.code_string);
                string total = string.Format("{0:N}", total1);
                total_sales.Text = total;
            }
            catch
            {
                transaction_number.Text = "0";
                total_sales.Text = "0";
            }   
        }

        private void sales_controltab()
        {
            try
            {
                date_from.Text = DateTime.Now.ToString();
                date_to.Text = DateTime.Now.ToString();
                backcolor();
                daily.BackColor = Color.FromArgb(249, 247, 147);
                main.date = DateTime.Now.ToShortDateString();
                main.select_string = "Select TransactionID AS 'Transaction ID',TotalAmount AS 'Total Amount',Discount,Cash,Change,Date,StaffName AS 'Staff Name' From Sales Where Date = '" + main.date + "' order by TransactionID asc";
                datagrid.DataSource = sales_class.select();
                datagrid.CurrentCell = null;
                main.select_string = "Select Count(*) From Sales Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                transaction_number.Text = main.code_string;
                main.select_string = "Select Sum(TotalAmount) From Sales Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                double total1 = double.Parse(main.code_string);
                string total = string.Format("{0:N}", total1);
                total_sales.Text = total;
                main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date = '" + main.date + "' order by TransactionID asc";
                main.report_name = "DAILY SALES REPORT";
            }
            catch
            {
                transaction_number.Text = "0";
                total_sales.Text = "0";
            }
        }

        private void daily_Click(object sender, EventArgs e)
        {
            sales_controltab();
            main.firstday = DateTime.Parse(date_from.Text);
            main.lastday = DateTime.Parse(date_to.Text);
            main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date = '" + main.date + "' order by TransactionID asc";
            main.report_name = "DAILY SALES REPORT";
        }

        private void checkdate()
        {
            if (date_from.Text == DateTime.Now.ToShortDateString() && date_to.Text == DateTime.Now.ToShortDateString())
            {
                backcolor();
                daily.BackColor = Color.FromArgb(249, 247, 147);
                sales_controltab();
                main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date = '" + main.date + "' order by TransactionID asc";
                main.report_name = "DAILY SALES REPORT";
            }
            else
            {
                backcolor();
                sales_record(DateTime.Parse(date_from.Text),DateTime.Parse(date_to.Text));
                main.firstday = DateTime.Parse(date_from.Text);
                main.lastday = DateTime.Parse(date_to.Text);
                main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' order by TransactionID asc";
                main.report_name = "SALES REPORT   " + date_from.Text + " - " + date_to.Text;
            }
        }

        private void weekly_Click(object sender, EventArgs e)
        {
            resetdate();
            backcolor();
            weekly.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var lastday = firstday.AddDays(6);
            sales_record(firstday, lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' order by TransactionID asc";
            main.report_name = "WEEKLY SALES REPORT";
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            resetdate();
            backcolor();
            monthly.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
            var lastday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            sales_record(firstday, lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' order by TransactionID asc";
            main.report_name = "MONTHLY SALES REPORT";
        }

        private void anually_Click(object sender, EventArgs e)
        {
            resetdate();
            backcolor();
            annually.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = new DateTime(DateTime.Now.Year, 1, 1);
            var lastday = new DateTime(DateTime.Now.Year, 12, 31);
            sales_record(firstday,lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select TransactionID,TotalAmount,Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sales Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' order by TransactionID asc";
            main.report_name = "ANNUALLY SALES REPORT";
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            checkdate();

        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            checkdate();
        }

        private void menu_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            sales_controltab();
            sold_controltab();
        }

        private void print_Click(object sender, EventArgs e)
        {
            (report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = main.report_name;
            string sql = main.select_string;
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
            adapter.Fill(ds, "Sales");
            report.SetDataSource(ds.Tables["Sales"]);
            report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("TRANSACTION SALES REPORT SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
//SOLD MEDICINE---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void sold_controltab()
        {
            try
            {
                sold_date_from.Text = DateTime.Now.ToString();
                sold_date_to.Text = DateTime.Now.ToString();
                sold_backcolor();
                sold_daily.BackColor = Color.FromArgb(249, 247, 147);
                main.date = DateTime.Now.ToShortDateString();
                main.select_string = "Select MedicineName AS 'Medicine Name',Dosage,Quantity,TotalAmount AS 'Total Amount',Date,StaffName AS 'Staff Name' From Sold_medicine Where Date = '" + main.date + "' order by Date asc";
                sold_datagrid.DataSource = sales_class.select();
                sold_datagrid.CurrentCell = null;
                sold_datagrid.Columns[0].Width = 300;
                sold_datagrid.Columns[1].Width = 270;
                main.select_string = "Select Count(*) From Sold_medicine Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                sold_number.Text = main.code_string;
                main.select_string = "Select Sum(TotalAmount) From Sold_medicine Where Date = '" + main.date + "'";
                sales_class.transaction_number();
                double total1 = double.Parse(main.code_string);
                string total = string.Format("{0:N}", total1);
                sold_total_sales.Text = total;
                main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date = '" + main.date + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
                main.report_name = "DAILY MEDICINE SOLD REPORT";
            }
            catch
            {
                sold_number.Text = "0";
                sold_total_sales.Text = "0";
            }
        }

        private void sold_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sold_datagrid.ClearSelection();
            sold_datagrid.CurrentCell = null;
        }

        private void sold_datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in sold_datagrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void sold_record(DateTime sold_firstday, DateTime sold_lastday)
        {
            try
            {
                main.select_string = "Select MedicineName AS 'Medicine Name',Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'Total Amount',Date,StaffName AS 'Staff Name' From Sold_medicine Where Date BETWEEN '" + sold_firstday.ToShortDateString() + "' AND '" + sold_lastday.ToShortDateString() + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
                sold_datagrid.DataSource = sales_class.select();
                sold_datagrid.CurrentCell = null;
                main.select_string = "Select SUM(Quantity) From Sold_medicine Where Date BETWEEN '" + sold_firstday.ToShortDateString() + "' AND '" + sold_lastday.ToShortDateString() + "'";
                sales_class.transaction_number();
                sold_number.Text = main.code_string;
                main.select_string = "Select Sum(TotalAmount) From Sold_medicine Where Date BETWEEN '" + sold_firstday.ToShortDateString() + "' AND '" + sold_lastday.ToShortDateString() + "'";
                sales_class.transaction_number();
                double total1 = double.Parse(main.code_string);
                string total = string.Format("{0:N}", total1);
                sold_total_sales.Text = total;
            }
            catch
            {
                sold_number.Text = "0";
                sold_total_sales.Text = "0";
            }
        }

        private void sold_daily_Click(object sender, EventArgs e)
        {
            sold_controltab();
            main.firstday = DateTime.Parse(sold_date_from.Text);
            main.lastday = DateTime.Parse(sold_date_to.Text);
            main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date = '" + main.date + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
            main.report_name = "DAILY MEDICINE SOLD REPORT";
        }

        private void sold_checkdate()
        {
            if (sold_date_from.Text == DateTime.Now.ToShortDateString() && sold_date_to.Text == DateTime.Now.ToShortDateString())
            {
                sold_backcolor();
                sold_daily.BackColor = Color.FromArgb(249, 247, 147);
                sold_controltab();
                main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date = '" + main.date + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
                main.report_name = "DAILY MEDICINE SOLD REPORT";
            }
            else
            {
                sold_backcolor();
                sold_record(DateTime.Parse(sold_date_from.Text), DateTime.Parse(sold_date_to.Text));
                main.firstday = DateTime.Parse(sold_date_from.Text);
                main.lastday = DateTime.Parse(sold_date_to.Text);
                main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
                main.report_name = "MEDICINE SOLD REPORT   " + sold_date_from.Text + " - " + sold_date_to.Text;
            }
        }

        private void sold_weekly_Click(object sender, EventArgs e)
        {
            sold_resetdate();
            sold_backcolor();
            sold_weekly.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var lastday = firstday.AddDays(6);
            sold_record(firstday, lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
            main.report_name = "WEEKLY MEDICINE SOLD REPORT";
        }

        private void sold_monthly_Click(object sender, EventArgs e)
        {
            sold_resetdate();
            sold_backcolor();
            sold_monthly.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            sold_record(firstday, lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
            main.report_name = "MONTHLY MEDICINE SOLD REPORT";
        }

        private void sold_annually_Click(object sender, EventArgs e)
        {
            sold_resetdate();
            sold_backcolor();
            sold_annually.BackColor = Color.FromArgb(249, 247, 147);
            var firstday = new DateTime(DateTime.Now.Year, 1, 1);
            var lastday = new DateTime(DateTime.Now.Year, 12, 31);
            sold_record(firstday, lastday);
            main.firstday = firstday;
            main.lastday = lastday;
            main.select_string = "select MedicineName,Dosage,SUM(Quantity) AS 'Quantity',SUM(TotalAmount) AS 'TotalAmount',Format(Date,'MM/dd/yyyy') AS 'Date',StaffName From Sold_medicine Where Date BETWEEN '" + main.firstday.ToShortDateString() + "' AND '" + main.lastday.ToShortDateString() + "' group by MedicineName,Dosage,Date,StaffName order by Date asc";
            main.report_name = "ANNUALLY MEDICINE SOLD REPORT";
        }

        private void sold_date_from_ValueChanged(object sender, EventArgs e)
        {
            sold_checkdate();
        }

        private void sold_date_to_ValueChanged(object sender, EventArgs e)
        {
            sold_checkdate();
        }

        private void sold_print_Click(object sender, EventArgs e)
        {
            (sold_report.ReportDefinition.ReportObjects["report_name"] as TextObject).Text = main.report_name;
            string sql = main.select_string;
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, main.con);
            adapter.Fill(ds, "Sold_medicine");
            sold_report.SetDataSource(ds.Tables["Sold_medicine"]);
            sold_report.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            sold_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
            sold_report.PrintToPrinter(1, false, 0, 0);
            MessageBox.Show("MEDICINE SOLD REPORT SUCCESSFULLY PRINTED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
