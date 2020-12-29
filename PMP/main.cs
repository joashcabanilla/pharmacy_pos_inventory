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
   public class main
    {
        private static string con_string = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;
        public static SqlConnection con = new SqlConnection(con_string);

        public static string username, password, login, search, brandname, brandcategory, new_brandname, medicinename, new_medicinename, dosage,new_dosage,customer;
        public static string code_string,code,expirationdate,stock,price_string,codenumber,datereceived,total_stock_received,medicine_stock,report_name;
        public static string firstname, lastname, sex, age, birthdate, contactnumber, tmp_username, update_firstname, update_lastname,select_string,date,reason;
        public static int code_int,new_stock,tmp_code,expired,low_in_stocks,out_of_stocks,staff_tmp,quantity;
        public static int tmp_brandname,month,year,tmp,on_off,f8,inquiry_on;
        public static double price,discount_amount,subtotal_amount,vat_amount,total_due_amount,final_total;
        public static double vat_percentage, total_amount, discount_percentage, payment_total, payment_cash, payment_change, discount, vat;
        public static DateTime firstday,lastday;
        public static string staffname,transaction_id,type_of_customer,customer_name,id_number,doctor_prescription;

        public DataTable adminlogin()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Admin_account WHERE Username ='" + username + "' and Password = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    login = "admin";
                }
                else
                {
                    DataTable dt1 = new DataTable();
                    string sql1 = "Select Count(*) From Staff_account WHERE Username ='" + username + "' and Password = '" + password + "' and Status = 'ACTIVATE'";
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                    adapter1.Fill(dt1);

                    if ("" + dt1.Rows[0][0] == "1")
                    {
                        login = "staff";
                    }
                    else
                    {
                        login = "";
                        MessageBox.Show("USERNAME/PASSWORD IS INCORRECT. PLEASE TRY AGAIN!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        public DataTable staff_username()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select Count(*) From Staff_account WHERE Username ='" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                if ("" + dt.Rows[0][0] == "1")
                {
                    staff_tmp = 0;
                    MessageBox.Show("USERNAME ALREADY EXIST", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void createaccount()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Staff_account(FirstName,LastName,Birthdate,Age,Sex,ContactNumber,Username,Password,Status) values('" + firstname + "','" + lastname + "','" + birthdate + "','" + age + "','" + sex + "','" + contactnumber + "','" + username + "','" + password + "','ACTIVATE')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("STAFF ACCOUNT SUCCESSFULLY CREATED");
                staff_tmp = 1;
            }
            catch
            {
                MessageBox.Show("UNEXPECTED ERROR IN DATABASE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                staff_tmp = 1;
            }
            finally
            {
                con.Close();
                staff_tmp = 1;
            }
        }   
    }
}
