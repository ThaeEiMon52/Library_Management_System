using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.APP.Views.FrmMenu;
using LMS.Services.login;
using LMS.Entities.Login;
namespace LMS.APP.Views.LoginForm
{
    public partial class Login : Form
    {
        LoginService loginService = new LoginService();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                return;
            }
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();
            DataTable dt = loginService.Login(email);
            if(dt.Rows.Count > 0 )
            {
                DataRow row = dt.Rows[0];
                int staffRole = (bool)row["role"] ? 1 : 0;
                int staffID = (int)row["staff_id"];
                string staffPassword = (string)row["password"];

                // Check if the password is correct
                if (password == staffPassword)
                {
                    MessageBox.Show($"Login successful!");

                    // Store the user ID and role in the application session
                    LoginEntity.staff_id = staffID;
                    LoginEntity.role = staffRole;
                    

                    FormMenu Menu = new FormMenu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                // If the query did not return a result, the user does not exist
                MessageBox.Show("Email does not exist");
            }
        }

        public bool ValidateInput()
        {
            // Check if email is null or empty
            if (string.IsNullOrEmpty(txtLoginEmail.Text))
            {
                MessageBox.Show("Email is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if email format is valid
            if (!Regex.IsMatch(txtLoginEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if password is null or empty
            if (string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Password is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if password is at least 6 characters long
            if (txtLoginPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // If everything checks out, return true
            return true;
        }


    }
}

