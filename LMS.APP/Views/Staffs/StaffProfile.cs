using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Entities.Staff;
using LMS.Services.Staffs;

namespace LMS.APP.Views.Staff
{
    public partial class StaffProfile : UserControl
    {
        public string ID
        { set { hdStaffID.Text = value; } }
       StaffService staffService = new StaffService();
       //StaffList staffList = new StaffList();

        char gender;
        byte[] imgbyte;
        public StaffProfile()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            ProfileUpdate();
        }
      
        private void ProfileUpdate()
        {

            //Check Information Required!!

            //Validate Name syntax
            if ((txtName.Text == "") || (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")))
            {
                txtName.BackColor = Color.LightPink;
                MessageBox.Show("Please provide valid Name !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }

         

            //Validate  Phone Syntax
            else if ((txtPhone.Text == "") || (!Regex.IsMatch(txtPhone.Text, @"^[0][1-9]\d{9}$")))
            {
                txtPhone.BackColor = Color.LightPink;
                MessageBox.Show("Please provide valid Phone Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            //Validate  Email Syntax
            else if ((txtEmail.Text == "") || (!Regex.IsMatch(txtEmail.Text, "^([0-9a-zA-Z]([-\\,\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$")))
            {
                txtEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please provide valid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }

            //Validate  Address Syntax
            else if (rtxtaddress.Text == "")
            {
                rtxtaddress.BackColor = Color.LightPink;
                MessageBox.Show("Address is Required!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtaddress.Focus();
            }
            else
            {
                StaffService staffService = new StaffService();
                StaffEntity staffEntity = UpdateData();
                bool success = false;

                if (String.IsNullOrEmpty(hdStaffID.Text))
                {

                    success = staffService.Update(staffEntity);
                    if (success)
                    {
                        MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Staff not foung", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Controls.Clear();
              //  this.Controls.Add(staffList);
            }
        }

        private StaffEntity UpdateData()
        {
           StaffEntity staffEntity = new StaffEntity();

            //Get the image from the picture box
            Image image = pbimgProfile.Image;

            //Convert the image to byte array

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                imgbyte = ms.ToArray();
            }



            if (!String.IsNullOrEmpty(hdStaffID.Text))
            {
                staffEntity.staff_id = Convert.ToInt32(hdStaffID.Text);
            }
            staffEntity.name = txtName.Text;
            staffEntity.email = txtEmail.Text;
           
            staffEntity.phone = txtPhone.Text;

          

            staffEntity.address = rtxtaddress.Text;
            staffEntity.gender = rdoMale.Checked ? 'M' : 'F';

            return staffEntity;
        }


        //After focusing text color change
        private void txtboxName(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

       

        private void txtboxPhone(object sender, EventArgs e)
        {
            txtPhone.BackColor = Color.White;
        }

        private void txtboxEmail(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void txtboxAddress(object sender, EventArgs e)
        {
            rtxtaddress.BackColor = Color.White;
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {
            BindData();
            
        }

        private void BindData()
        {
            if (!String.IsNullOrEmpty(hdStaffID.Text))
            {
                DataTable dt = staffService.Get(Convert.ToInt32(hdStaffID.Text));

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    txtEmail.Text = dt.Rows[0]["email"].ToString();
                   
                    txtPhone.Text = dt.Rows[0]["phone"].ToString();
                    imgbyte = (byte[])dt.Rows[0]["Photo"];
                    MemoryStream ms = new MemoryStream(imgbyte);
                    pbimgProfile.Image = Image.FromStream(ms);

                    rtxtaddress.Text = dt.Rows[0]["address"].ToString();


                }
            }
        }
     
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Image files( *.jpg;*.png;*.bmp) | *.jpg;*.png;.*bmp";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                pbimgProfile.Image = Image.FromFile(opd.FileName);
                pbimgProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
