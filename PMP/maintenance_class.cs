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
    public class maintenance_class : main
    {
        //brandname method--------------------------------------------------------------------------------------------------------------------------------
        public DataTable brandname_select()
        {

            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list order by BrandCategory asc";
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
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list order by BrandCategory asc";
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

        public DataTable branded_select()
        {

            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list Where BrandCategory = 'BRANDED' order by BrandCategory asc";
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
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list Where BrandCategory = 'BRANDED' order by BrandCategory asc";
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

        public DataTable generic_select()
        {

            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list Where BrandCategory = 'GENERIC' order by BrandCategory asc";
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
                    cmd.CommandText = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list Where BrandCategory = 'GENERIC' order by BrandCategory asc";
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

        public DataTable brandname_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list order by BrandCategory asc";
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
                string sql = "select BrandCategory AS 'Brand Category', BrandName AS 'Brand Name' From Brand_list WHERE BrandName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public void delete_brandname()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From Brand_list Where BrandName = '"+ brandname +"'";
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

        public void add_brandname()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Brand_list(BrandName,BrandCategory) values('"+new_brandname+"','"+brandcategory+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("BRAND NAME SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void update_brandname()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Brand_list set BrandName = '"+new_brandname+"', BrandCategory = '"+brandcategory+"' Where BrandName = '"+brandname+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("BRAND NAME SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //medicine method----------------------------------------------------------------------------------------------------------------------------------
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
                    cmd.CommandText = "select MedicineName AS 'Medicine Name' From Medicine_list order by MedicineName asc";
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
                    cmd.CommandText = "select * From Medicine_list order by MedicineName asc";
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
                string sql = "select MedicineName AS 'Medicine Name' From Medicine_list order by MedicineName asc";
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
                string sql = "select MedicineName AS 'Medicine Name' From Medicine_list WHERE MedicineName LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public void delete_medicine()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From Medicine_list Where MedicineName = '" + medicinename + "'";
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

        public void update_medicine()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Medicine_list set MedicineName = '" + new_medicinename + "' Where MedicineName = '" + medicinename + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("MEDICINE NAME SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void add_medicine()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Medicine_list(MedicineName) values('"+ new_medicinename +"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("MEDICINE NAME SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //dosage method------------------------------------------------------------------------------------------------------------------------------------
        public DataTable dosage_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Dosage_list order by Dosage asc";
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
                    cmd.CommandText = "select * from Dosage_list order by Dosage asc";
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

        public DataTable dosage_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "select * from Dosage_list order by Dosage asc";
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
                string sql = "select * from Dosage_list WHERE Dosage LIKE '%" + search + "%'";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public void delete_dosage()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From Dosage_list Where Dosage = '" + dosage + "'";
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

        public void update_dosage()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Dosage_list set Dosage = '" + new_dosage + "' Where Dosage = '" + dosage + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("DOSAGE SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void add_dosage()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Dosage_list(Dosage) values('" + new_dosage + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("DOSAGE SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //discount----------------------------------------------------------------------------------------------------------------------------------------------
        public DataTable discount_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select CUSTOMER,DISCOUNT AS 'DISCOUNT PERCENTAGE' from Discount order by CUSTOMER asc";
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
                    cmd.CommandText = "select CUSTOMER,DISCOUNT AS 'DISCOUNT PERCENTAGE' from Discount order by CUSTOMER asc";
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
        
        public void update_discount()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Discount set DISCOUNT = '" + discount + "' Where CUSTOMER = '" + customer + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("DISCOUNT SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //vat---------------------------------------------------------------------------------------------------------------------------------------------------
        public DataTable vat_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select VAT AS 'VAT PERCENTAGE' From Vat";
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
                    cmd.CommandText = "select VAT AS 'VAT PERCENTAGE' From Vat";
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

        public void update_vat()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Vat set VAT = '" + vat + "' Where ID = 1";
                cmd.ExecuteNonQuery();
                MessageBox.Show("VAT SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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