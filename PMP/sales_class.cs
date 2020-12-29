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

namespace PMP
{
    public class sales_class : main
    {
        public DataTable select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = select_string;
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = select_string;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return dt;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable transaction_number()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = select_string;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                code_string = dt.Rows[0][0] + "";
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public void medicine_add()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = select_string;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();

            }
            finally
            {
                con.Close();

            }
        }

        public DataTable medicine_order()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = select_string;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    tmp = 1;
                }
                else
                {
                    tmp = 0;

                }
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public DataTable medicine_search()
        {
            DataTable dt = new DataTable();
            try
            {
                if (search == String.Empty)
                {
                    string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock' and Stocks > 5 order by Code asc";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    con.Close();

                    tmp_brandname = 1;
                    return dt;
                }
                else
                {
                    tmp_brandname = 0;
                    con.Open();
                    string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where ExpirationDate <> 'Expired' and Stocks <> 'Out Of Stock'  and Stocks > 5 and (MedicineName LIKE '%" + search + "%' OR Code LIKE '%" + search + "%')";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();

                    return dt;
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public DataTable deactivate_search()
        {
            DataTable dt = new DataTable();
            try
            {
                if (search == String.Empty)
                {
                    string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage from Medicine Where Status = 'DEACTIVATE' order by Code asc";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    con.Close();

                    tmp_brandname = 1;
                    return dt;
                }
                else
                {
                    tmp_brandname = 0;
                    con.Open();
                    string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage from Medicine Where Status = 'DEACTIVATE' and (MedicineName LIKE '%" + search + "%' OR Code LIKE '%" + search + "%')";
                    //Creating cmd using sql and con
                    SqlCommand cmd = new SqlCommand(sql, con);
                    //Creating Sql DataAdapter using cmd
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();

                    return dt;
                }
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }
    }
}
