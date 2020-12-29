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
    public class medicine_inventory_class : main
    {
       //medicine inventory------------------------------------------------------------------------------------------------------------------
        public DataTable medicine_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where Status = 'ACTIVATE' order by Code asc";
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

        public DataTable medicine_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine Where Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Stocks AS 'Stock', Price From Medicine WHERE Status = 'ACTIVATE' and MedicineName LIKE '%" + search + "%' OR Code LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public DataTable code_number()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select MAX(CodeNumber) From Medicine";
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

        public void medicine_delete()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From Medicine Where Code = '" + code + "'";
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

        public void medicine_update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Medicine set BrandCategory = '"+ brandcategory +"', MedicineName = '"+ medicinename +"', BrandName = '"+ brandname +"', Dosage = '"+ dosage +"', Price = '"+ price_string +"',Prescription = '"+ doctor_prescription +"' Where Code = '"+ code +"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("MEDICINE SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void medicine_add()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Medicine(Code,MedicineName,BrandCategory,BrandName,ExpirationDate,Dosage,Stocks,Price,Month,CodeNumber,Year,Prescription,Status) values('" + code + "','" + medicinename + "','" + brandcategory + "','" + brandname + "','" + expirationdate + "','"+ dosage +"','"+ stock +"','"+ price_string +"','"+ month +"','"+ codenumber +"','"+ year +"','"+ doctor_prescription +"','ACTIVATE')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("MEDICINE SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable medicine_expired()
        {
            DataTable dt = new DataTable();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    string sql = "Update Medicine SET ExpirationDate = 'Expired' Where Month <= " + month + " and Year <= " + year + " or Month > " + month + " and Year < " + year + "";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
                else
                {
                    string sql = "Update Medicine SET ExpirationDate = 'Expired' Where Month <= " + month + " and Year <= " + year + " or Month > " + month + " and Year < " + year + "";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
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

        public DataTable medicine_out_of_stock()
        {
            DataTable dt = new DataTable();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    string sql = "Update Medicine SET Stocks = 'Out Of Stock' Where Stocks = '0'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    con.Open();
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
                else
                {
                    string sql = "Update Medicine SET Stocks = 'Out Of Stock' Where Stocks = '0'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
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

        //Medicine Stock In-------------------------------------------------------------------------------------------------------------------------
        public DataTable stock_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category',BrandName AS 'Brand Name',Dosage,Stock From StockIn where DateReceived = '"+datereceived+"' Order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category',BrandName AS 'Brand Name',Dosage,Stock From StockIn where DateReceived = '" + datereceived + "' Order by Code asc";
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

        public void stock_add()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into StockIn(Code,MedicineName,BrandCategory,BrandName,ExpirationDate,Dosage,Stock,Price,DateReceived) values('" + code + "','" + medicinename + "','" + brandcategory + "','" + brandname + "','" + expirationdate + "','" + dosage + "','" + stock + "','" + price_string + "','" + datereceived + "')";
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

        public DataTable total_stock()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select SUM(Stock) From StockIn Where DateReceived = '"+ datereceived +"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                total_stock_received = dt.Rows[0][0] + "";
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public void stock_update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Medicine set Stocks = '"+ new_stock +"' Where Code = '"+code+"'";
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

        public DataTable stock_medicine()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Stocks From Medicine Where Code = '"+ code +"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "Out Of Stock")
                {
                    medicine_stock = 0 + "";
                }
                else
                {
                    medicine_stock = dt.Rows[0][0] + "";
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

        public void stock_delete()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From StockIn Where Code = '" + code + "' and DateReceived = '"+ datereceived +"'";
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

        public DataTable StockIn()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From StockIn Where Code = '" + code + "' and DateReceived = '" + datereceived + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    tmp_code = 1;
                }
                else
                {
                    tmp_code = 0;
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

        public DataTable StockIn_select()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Stock From StockIn Where Code = '" + code + "' and DateReceived = '" + datereceived + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                medicine_stock = dt.Rows[0][0] + "";
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }
        
        public void stockIn_update()
        {
            try
            {
                stock = int.Parse(stock) + int.Parse(medicine_stock) + "";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update StockIn set Stock = '" + stock + "' Where Code = '" + code + "' and DateReceived = '" + datereceived + "'";
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

       //STOCK IN HISTORY------------------------------------------------------------------------------------------------------------------------------------
        public DataTable stock_history_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category',BrandName AS 'Brand Name',Dosage,Stock,DateReceived AS 'Date Received' From StockIn where DateReceived = '" + datereceived + "' Order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category',BrandName AS 'Brand Name',Dosage,Stock,DateReceived AS 'Date Received' From StockIn where DateReceived = '" + datereceived + "' Order by Code asc";
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

        //MEDICINE STOCK STATUS------------------------------------------------------------------------------------------------------------------------------
        public DataTable status_total_stock_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Status = 'ACTIVATE' order by Code asc";
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

        public DataTable status_expired()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                main.expired = int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public DataTable status_low_in_stocks()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 and Status = 'ACTIVATE'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                main.low_in_stocks = int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public DataTable status_out_of_stocks()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Medicine Where Stocks = 'Out Of Stock' and Status = 'ACTIVATE'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                main.out_of_stocks = int.Parse(dt.Rows[0][0].ToString());
                con.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public DataTable status_expired_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate = 'Expired' order by Code asc";
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

        public DataTable status_not_expired_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate <> 'Expired' and Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate <> 'Expired' order by Code asc";
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

        public DataTable status_low_in_stocks_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 and Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 order by Code asc";
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

        public DataTable status_out_of_stocks_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks = 'Out Of Stock' and Status = 'ACTIVATE' order by Code asc";
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
                    cmd.CommandText = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks = 'Out Of Stock' order by Code asc";
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

        public DataTable total_stock_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine WHERE MedicineName LIKE '%" + search + "%' OR Code LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public DataTable expired_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate = 'Expired' and Status = 'ACTIVATE' and MedicineName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public DataTable low_stocks_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 and Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks <> 'Out Of Stock' and Stocks <= 5 and Status = 'ACTIVATE' and MedicineName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
        }

        public DataTable out_stocks_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks = 'Out Of Stock' and Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,Stocks AS 'Stock' From Medicine Where Stocks = 'Out Of Stock' and Status = 'ACTIVATE' and MedicineName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public DataTable not_expired_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate <> 'Expired' and Status = 'ACTIVATE' order by Code asc";
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
                string sql = "Select Code,MedicineName AS 'Medicine Name',BrandCategory AS 'Brand Category', BrandName AS 'Brand Name', Dosage,Price,ExpirationDate AS 'Expiration Date' From Medicine Where ExpirationDate <> 'Expired' and Status = 'ACTIVATE' and MedicineName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public void remove_expired()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Medicine set Status = 'DEACTIVATE' Where Code = '" + code + "'";
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

        public void remove_all_expired()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Medicine set Status = 'DEACTIVATE' Where ExpirationDate = 'Expired'";
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
    }
}
