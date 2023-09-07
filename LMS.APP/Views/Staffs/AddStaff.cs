using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Services.Staff;
using LMS.Entities.Staff;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using LMS.Entities.Users;

namespace LMS.APP.Views.Staff
{
    public partial class AddStaff : UserControl
    {
        public string ID
        { set { hideStaffID.Text = value; } }


        ViewStaff viewStaff = new ViewStaff();
        StaffService staffService = new StaffService();

        private string rdogender;
        public AddStaff()
        {
            InitializeComponent();
        }
        private void AddStaff_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }


        private void BindData()
        {
            if (!String.IsNullOrEmpty(hideStaffID.Text))
            {
                DataTable dt = staffService.Get(Convert.ToInt32(hideStaffID.Text));


                if (dt.Rows.Count > 0)
                {
                    txtStaffName.Text = dt.Rows[0]["name"].ToString();
                    txtstaffemail.Text = dt.Rows[0]["email"].ToString();
                    txtStaffPassword.Text = dt.Rows[0]["password"].ToString();
                    txtStaffPhone.Text = dt.Rows[0]["phone"].ToString();


                    string gender = dt.Rows[0]["gender"].ToString();
                    if (rdoMale.Checked)
                    {
                        gender = rdoMale.Text;
                    }
                    else
                    {
                        gender = rdoFemale.Text;
                    }

                    txtStaffAddress.Text = dt.Rows[0]["address"].ToString();


                }
            }

        }
        private void BtnControl()
        {
            if (String.IsNullOrEmpty(hideStaffID.Text))
            {
                btnStaffCreateAccount.Text = "Create Account";
         
            }
            else
            {
                btnStaffCreateAccount.Text = "Update Account";
            }
        }

        private void CourseADDorUpdate()
        {
            StaffService staffService = new StaffService();
            StaffEntity staffEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hideStaffID.Text))
            {
                success = staffService.Insert(staffEntity);
                if (success)
                {
                    MessageBox.Show("Save Successful.", "Success", MessageBoxButtons.OK);
                }

            }
            else
            {
                success = staffService.Update(staffEntity);
                if (success)
                {
                    MessageBox.Show("Update Successful.", "Success", MessageBoxButtons.OK);
                }

            }

            this.Controls.Clear();
            this.Controls.Add(viewStaff);

        }

        private StaffEntity CreateData()
        {
            StaffEntity staffEntity = new StaffEntity();
            if (!String.IsNullOrEmpty(hideStaffID.Text))
            {
                staffEntity.staff_id = Convert.ToInt32(hideStaffID.Text);
            }

            staffEntity.name = txtStaffName.Text;
            staffEntity.email = txtstaffemail.Text;
            staffEntity.password = txtStaffPassword.Text;
            staffEntity.phone = txtStaffPhone.Text;
            staffEntity.gender = rdoMale.Checked ? 'M' : 'F';

            staffEntity.address = txtStaffAddress.Text;


            return staffEntity;
        }

        //click Create Account button
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                CourseADDorUpdate();
            }
        }


        //cancel button
        private void btnStaffCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Visible = false;

        }


        //Empty textbox validation
        private bool Validation()
        {

            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("Please Enter your Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
              
                txtStaffName.Focus();

                return false;
            }
            else if (string.IsNullOrEmpty(txtstaffemail.Text))
            {
                MessageBox.Show("Please Enter your Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
                txtstaffemail.Focus();

                return false;

            }
            else if (string.IsNullOrEmpty(txtStaffPassword.Text))
            {
                MessageBox.Show("Please Enter Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
                txtStaffPassword.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(txtStaffPhone.Text))
            {
                MessageBox.Show("Please Enter PhoneNumber!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
                txtStaffPassword.Focus();
                return false;
            }
            // Assuming you have three RadioButton controls named rbMale, rbFemale, and rbOther

            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                // No gender option is selected
                MessageBox.Show("Please Select A Gender.");
                return false;
            }
        

            else { return true; }
        }





        //Validation Syntax for textbox

        private void txtStaffName_Validating(object sender, CancelEventArgs e)
        {
            
                // Define a regular expression pattern for valid names (only letters and spaces)
                string pattern = @"^[a-zA-Z\s]+$";

                // Get the text entered in the name field
                string name = txtStaffName.Text;

                // Test if the name matches the pattern
                if (!Regex.IsMatch(name, pattern))
                {
                    // Display an error message and cancel the event to prevent the form from being submitted
                    MessageBox.Show("Please Enter A Valid Name (letters and spaces only).", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStaffName.Focus();
                e.Cancel = true;
                }
          
        }

        private void txtstaffemail_Validating(object sender, CancelEventArgs e)
        {
                // Define a regular expression pattern for valid email addresses
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Get the text entered in the email field
                string email =txtstaffemail.Text;

                // Test if the email matches the pattern
                if (!Regex.IsMatch(email, pattern))
                {
                    // Display an error message and cancel the event to prevent the form from being submitted
                    MessageBox.Show("Please Enter A Valid Email Address.", "Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstaffemail.Focus();
                    e.Cancel = true;
                }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // Define a regular expression pattern for valid passwords
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            // Get the text entered in the password field
            string password = txtStaffPassword.Text;

            // Test if the password matches the pattern
            if (!Regex.IsMatch(password, pattern))
            {
                // Display an error message and cancel the event to prevent the form from being submitted
                MessageBox.Show("Please Enter A Valid Password.\n\nPassword Must Contain At Least:\n- 8 Characters\n- 1 Uppercase Letter\n- 1 Lowercase Letter\n- 1 Digit\n- 1 Special Character (@$!%*?&)", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStaffPassword.Focus();
                e.Cancel = true;
            }
        }

        private void txtStaffPhone_Validating(object sender, CancelEventArgs e)
        {
            // Define a regular expression pattern for valid phone numbers
            string pattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";

            // Get the text entered in the phone number field
            string phoneNumber = txtStaffPhone.Text;

            // Test if the phone number matches the pattern
            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                // Display an error message and cancel the event to prevent the form from being submitted
                MessageBox.Show("Please Enter A Valid Phone Number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStaffPhone.Focus();
                e.Cancel = true;
            }
        }

        private void txtStaffAddress_Validating(object sender, CancelEventArgs e)
        {
            // Define a regular expression pattern for valid addresses
            string pattern = @"^\d+\s[A-z]+\s[A-z]+";

            // Get the text entered in the address field
            string address = txtStaffAddress.Text;

            // Test if the address matches the pattern
            if (!Regex.IsMatch(address, pattern))
            {
                // Display an error message and cancel the event to prevent the form from being submitted
                MessageBox.Show("Please Enter A Valid Address.", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        
    }
}
