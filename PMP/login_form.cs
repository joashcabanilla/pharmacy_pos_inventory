using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace PMP
{
    public partial class login_form : Form
    {
        main main = new main();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nTopRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public login_form()
        {
            InitializeComponent();
            login_panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, login_panel.Width, login_panel.Height, 30, 30));
            login_button.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, login_button.Width, login_button.Height, 30, 30));
            login.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, login.Width, login.Height, 30, 30));
            exit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, exit.Width, exit.Height, 30, 30));
            cancel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cancel.Width, cancel.Height, 30, 30));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            logo2.Visible = true;
            logo.Visible = false;
            login_panel.Visible = true;
            login_button.Enabled = false;
            exit.Enabled = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            login_button.Enabled = true;
            exit.Enabled = true;
            username.Text = "Username";
            username.ForeColor = Color.Gray;
            password.Text = "Password";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;
            login_panel.Visible = false;
            logo2.Visible = false;
            logo.Visible = true;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = null;
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = null;
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            if (show_password.Checked == false)
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("EXIT PHARMACY MANAGEMENT PROCESS SYSTEM?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_method()
        {
            main.username = username.Text;
            main.password = password.Text;

            main.adminlogin();
            if (main.login == "admin")
            {
                admin_control admin_control = new admin_control();
                admin_control.Show();
                this.Hide();
            }
            else if(main.login == "staff")
            {
                staff_control staff_control = new staff_control();
                staff_control.Show();
                this.Hide();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login_method();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_method();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_method();
            }
        }
    }
}
