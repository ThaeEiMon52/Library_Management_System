using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Services.User;
using LMS.Entities.User;
using System.Text.RegularExpressions;
using System.Deployment.Internal;
using LMS.APP.Views.FrmMenu;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace LMS.APP.Views.User
{
    public partial class UCUser : UserControl
    {
       
        public string ID
        { set { hdUserID.Text = value; } }
        UserService userService = new UserService();
      //  UserList userList = new UserList();
        public UCUser()
        {
            InitializeComponent();
          
        }

        private void UCUser_Load_1(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }
       

         private void BindData()
          {
              if (!String.IsNullOrEmpty(hdUserID.Text))
              {
               DataTable dt = userService.Get(Convert.ToInt32(hdUserID.Text));
               
                if (dt.Rows.Count > 0)
                  {
                  
                    txtName.Text = dt.Rows[0]["name"].ToString();
                    
                    string nrcNumber = dt.Rows[0]["nrc"].ToString();

                    // Extract the state number (the first two characters)
                    string stateNum = nrcNumber.Substring(0, 1);

                    // Extract the township (the characters between the '/' and '(')
                    int townShipStartIndex = nrcNumber.IndexOf('/') + 1;
                    int townShipEndIndex = nrcNumber.IndexOf('(') - 1;
                    string townShip = nrcNumber.Substring(townShipStartIndex, townShipEndIndex - townShipStartIndex + 1);

                    // Extract the town one char (the character between '(' and ')')
                    int townOneCharStartIndex = nrcNumber.IndexOf('(') + 1;
                    int townOneCharEndIndex = nrcNumber.IndexOf(')') - 1;
                    string townOneChar = nrcNumber.Substring(townOneCharStartIndex, townOneCharEndIndex - townOneCharStartIndex + 1);

                    // Extract the NRC number (the characters after the ')')
                    string nrcNum = nrcNumber.Substring(nrcNumber.IndexOf(')') + 1);

                    // Populate the ComboBox controls with the data
                    cboStateNumber.Text = stateNum;
                    cboTownship.Text = townShip;
                    cboOneChar.Text = townOneChar;
                    txtNrcnumber.Text = nrcNum;
                    txtPhone.Text = dt.Rows[0]["phone"].ToString();
                      txtEmail.Text = dt.Rows[0]["email"].ToString();
                      rtxtaddress.Text = dt.Rows[0]["address"].ToString();

                  }
              }
          }
        private void BtnControl()
        {
            if (String.IsNullOrEmpty(hdUserID.Text))
            {
                btnCreateAcc.Text = "Create Account";
            }
            else
            {
                btnCreateAcc.Text = "Update Account";
            }
        }
        

        //Add or Update
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
           
            AddorUpdate();
        }

        private void AddorUpdate()
        {

         
            //Check Information Required!!

            //Validate Name syntax
            if ((txtName.Text == "") || (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")))
            {
                txtName.BackColor = Color.LightPink;
                MessageBox.Show("Please provide valid Name !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
           
            //Validate  Nrc Syntax
            else if((txtNrcnumber.Text == "") || (!Regex.IsMatch(txtNrcnumber.Text, @"\d{6}")))
            {
                txtNrcnumber.BackColor = Color.LightPink;
                MessageBox.Show(" Please provide valid Nrc Number!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNrcnumber.Focus();
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
                UserService userService = new UserService();
                UserEntity userEntity = CreateData();
                bool success = false;

               if (String.IsNullOrEmpty(hdUserID.Text))
               {

                    success = userService.Insert(userEntity);
                    if (success)
                    {
                        MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                    }
               }

               else
                {
                   success = userService.Update(userEntity);

                    if (success)
                    {
                        MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                    }
                }
                this.Controls.Clear();
              //  this.Controls.Add(userList);
            }
        }

        private UserEntity CreateData()
        {
            UserEntity userEntity = new UserEntity();

            //Combine comboxes for Nrc
            string StateNum = cboStateNumber.SelectedItem.ToString();
            string TownShip = cboTownship.SelectedItem.ToString();
            string townOnechar = cboOneChar.SelectedItem.ToString();
            string NrcNum = txtNrcnumber.Text;
            string nrcNumber = StateNum + "/" + TownShip + "(" + townOnechar + ")" + NrcNum;

            if (!String.IsNullOrEmpty(hdUserID.Text))
            {
                userEntity.UserID = Convert.ToInt32(hdUserID.Text);
            }
            userEntity.UserName = txtName.Text;
            userEntity.UserNRC = nrcNumber;
            userEntity.UserPhone = txtPhone.Text;
            userEntity.UserEmail = txtEmail.Text;
            userEntity.UserAddress = rtxtaddress.Text;
            userEntity.UserGender = rdoMale.Checked ? 'M' : 'F';

            return userEntity;
        }





        //After focusing text color change
        private void txtboxName(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtboxNrc(object sender, EventArgs e)
       {
            txtNrcnumber.BackColor = Color.White;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Visible = false;
        }


        //Select index change stage number
        private void cboStagenum_SelectedIndex(object sender, EventArgs e)
        {
            cboTownship.Items.Clear(); // Clear any previously added items
            string StateNum = cboStateNumber.SelectedItem.ToString(); // Get the selected item in comboBox1
            switch (StateNum)
            {
               case "1":
                    cboTownship.Items.AddRange(new object[] {
                       "BAMANA",
                       "HAPANA",
                       "MANYANA",
                       "MAKATA",
                       "MAKANA"
            });
               break;
               case "2":
                    cboTownship.Items.AddRange(new object[] {
                        "BALAKHA",
                        "LAKANA",
                        "PHASANA",
                        "MASANA",
                        "YATANA",


            });
               break;
               case "3":
                    cboTownship.Items.AddRange(new object[] {
                       "KASAKA",
                       "KADANA",
                       "MAWATA",
                       "PHAAHNA",
                       "BAAHNA"
            });
               break;
               case "4":
                    cboTownship.Items.AddRange(new object[] {
                     "HAKHANA",
                     "HTATALA",
                     "TAZZNA",
                     "TATANA"
            }); ;
              break;
              case "5":
                     cboTownship.Items.AddRange(new object[] {
                     "BAMANA",
                     "DAPAYA",
                     "KHAOUNA",
                     "BATALA"
            });
              break;
              case "6":
                    cboTownship.Items.AddRange(new object[] {
                     "KATHANA",
                     "HTAWANA",
                     "KATHANA",
                     "LALANA"

            });
              break;
                case "7":
                    cboTownship.Items.AddRange(new object[] {
                     "DAOUNA",
                     "AHTANA",
                     "KAPAKA",
                     "AHPHANA"

            });
                break;
                case "8":
                    cboTownship.Items.AddRange(new object[] {
                     "HTALANA",
                     "GAGANA",
                     "SAPAWA"

            });
                break;
                case "9":
                    cboTownship.Items.AddRange(new object[] {
                     "PAMANA",
                     "LAWANA",
                     "KHAMASA",
                     "MALANA"
            });
                break;
                case "10":
                    cboTownship.Items.AddRange(new object[] {
                     "MALAMA",
                     "KAHTANA",
                     "MADANA",
                     "THAHTANA"

            });
                break;
                case "11":
                    cboTownship.Items.AddRange(new object[] {
                     "KAPHANA",
                     "YABANA",
                     "YATHATA",
                     "AALANA"

            });
                break;
                case "12":
                    cboTownship.Items.AddRange(new object[] {
                     "OUKAMA",
                     "LATHAYA",
                     "MABANA",
                     "AHSANA",
                     "MAYAKA"

            });
                    break;
                case "13":
                    cboTownship.Items.AddRange(new object[] {
                     "KATATA",
                     "HAPANA",
                     "KAHANA",
                     "LAKANA"

            });
                    break;
                case "14":
                    cboTownship.Items.AddRange(new object[] {
                     "DADAYA",
                     "KANANA",
                     "KAKHANA",
                     "MAAHPA"

            });
                    break;
            }
        }

        
    }
}
