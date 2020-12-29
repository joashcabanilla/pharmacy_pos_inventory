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
    class staff_acount : main
    {
        public DataTable staff_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'ACTIVATE' order by FirstName asc";
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
                    cmd.CommandText = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'ACTIVATE' order by FirstName asc";
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

        public DataTable staff_search()
        {

            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'ACTIVATE' order by FirstName asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                con.Close();

                staff_tmp = 1;
                return dt;
            }
            else
            {
                staff_tmp = 0;
                con.Open();
                string sql = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account WHERE Status = 'ACTIVATE' and (FirstName LIKE '%" + search + "%' OR LastName LIKE '%" + search + "%'  OR Sex LIKE '%" + search + "%' OR Age LIKE '%" + search + "%' OR BirthDate LIKE '%" + search + "%'  OR ContactNumber LIKE '%" + search + "%')";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }

        public void staff_delete()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From Staff_account  Where FirstName = '" + firstname + "' and LastName = '" + lastname + "'";
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

        public DataTable staff_staff_name()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Staff_account WHERE FirstName ='" + firstname + "' and LastName = '" + lastname + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    staff_tmp = 0;
                    MessageBox.Show("YOUR NAME IS ALREADY REGISTERED", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    staff_tmp = 1;

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

        public void staff_update()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Staff_account Set FirstName = '" + firstname + "',LastName = '" + lastname + "',BirthDate = '" + birthdate + "',Sex = '" + sex + "',Age = '" + age + "',ContactNumber = '" + contactnumber + "',Username = '" + username + "',Password = '" + password + "' Where FirstName = '" + update_firstname + "' and LastName = '" + update_lastname + "' and Age = '" + age + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("STAFF ACCOUNT SUCCESSFULLY SAVED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable deact_select()
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'DEACTIVATE' order by FirstName asc";
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
                    cmd.CommandText = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'DEACTIVATE' order by FirstName asc";
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

        public DataTable deact_search()
        {
            DataTable dt = new DataTable();

            if (search == String.Empty)
            {
                string sql = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account Where Status = 'DEACTIVATE' order by FirstName asc";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                con.Close();

                staff_tmp = 1;
                return dt;
            }
            else
            {
                staff_tmp = 0;
                con.Open();
                string sql = "Select FirstName AS 'First Name',LastName AS 'Last Name', BirthDate AS 'Birth Date',Age,Sex,ContactNumber AS 'Contact Number' From Staff_account WHERE Status = 'DEACTIVATE' and (FirstName LIKE '%" + search + "%' OR LastName LIKE '%" + search + "%'  OR Sex LIKE '%" + search + "%' OR Age LIKE '%" + search + "%' OR BirthDate LIKE '%" + search + "%'  OR ContactNumber LIKE '%" + search + "%')";
                //Creating cmd using sql and con
                SqlCommand cmd = new SqlCommand(sql, con);
                //Creating Sql DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                return dt;
            }
        }
    }
}
