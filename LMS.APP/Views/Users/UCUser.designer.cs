namespace LMS.APP.Views.User
{
    partial class UCUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtaddress = new System.Windows.Forms.RichTextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtNrcnumber = new System.Windows.Forms.TextBox();
            this.lblNrc = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdduser = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnttladduser = new System.Windows.Forms.Panel();
            this.cboStateNumber = new System.Windows.Forms.ComboBox();
            this.cboTownship = new System.Windows.Forms.ComboBox();
            this.cboOneChar = new System.Windows.Forms.ComboBox();
            this.lblBackslash = new System.Windows.Forms.Label();
            this.hdUserID = new System.Windows.Forms.Label();
            this.pnttladduser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(760, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 31);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.Location = new System.Drawing.Point(577, 431);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(134, 31);
            this.btnCreateAcc.TabIndex = 33;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(663, 276);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(71, 20);
            this.rdoFemale.TabIndex = 32;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(446, 313);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address";
            // 
            // rtxtaddress
            // 
            this.rtxtaddress.Location = new System.Drawing.Point(577, 313);
            this.rtxtaddress.Name = "rtxtaddress";
            this.rtxtaddress.Size = new System.Drawing.Size(326, 96);
            this.rtxtaddress.TabIndex = 30;
            this.rtxtaddress.Text = "";
            this.rtxtaddress.TextChanged += new System.EventHandler(this.txtboxAddress);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(577, 276);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(55, 20);
            this.rdoMale.TabIndex = 29;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtNrcnumber
            // 
            this.txtNrcnumber.Location = new System.Drawing.Point(806, 158);
            this.txtNrcnumber.Name = "txtNrcnumber";
            this.txtNrcnumber.Size = new System.Drawing.Size(97, 20);
            this.txtNrcnumber.TabIndex = 28;
            this.txtNrcnumber.TextChanged += new System.EventHandler(this.txtboxNrc);
            // 
            // lblNrc
            // 
            this.lblNrc.AutoSize = true;
            this.lblNrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrc.Location = new System.Drawing.Point(446, 163);
            this.lblNrc.Name = "lblNrc";
            this.lblNrc.Size = new System.Drawing.Size(39, 16);
            this.lblNrc.TabIndex = 27;
            this.lblNrc.Text = "NRC";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(577, 199);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(326, 20);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtboxPhone);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(446, 199);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 16);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(577, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 20);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtboxEmail);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(446, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(577, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 20);
            this.txtName.TabIndex = 21;
            this.txtName.TextChanged += new System.EventHandler(this.txtboxName);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(446, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // lblAdduser
            // 
            this.lblAdduser.AutoSize = true;
            this.lblAdduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdduser.ForeColor = System.Drawing.Color.White;
            this.lblAdduser.Location = new System.Drawing.Point(628, 9);
            this.lblAdduser.Name = "lblAdduser";
            this.lblAdduser.Size = new System.Drawing.Size(121, 25);
            this.lblAdduser.TabIndex = 0;
            this.lblAdduser.Text = "Add Users";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(446, 276);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 16);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender";
            // 
            // pnttladduser
            // 
            this.pnttladduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.pnttladduser.Controls.Add(this.lblAdduser);
            this.pnttladduser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnttladduser.Location = new System.Drawing.Point(0, 0);
            this.pnttladduser.Name = "pnttladduser";
            this.pnttladduser.Size = new System.Drawing.Size(1200, 48);
            this.pnttladduser.TabIndex = 19;
            // 
            // cboStateNumber
            // 
            this.cboStateNumber.FormattingEnabled = true;
            this.cboStateNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cboStateNumber.Location = new System.Drawing.Point(577, 159);
            this.cboStateNumber.Name = "cboStateNumber";
            this.cboStateNumber.Size = new System.Drawing.Size(42, 21);
            this.cboStateNumber.TabIndex = 36;
            this.cboStateNumber.SelectedIndexChanged += new System.EventHandler(this.cboStagenum_SelectedIndex);
            // 
            // cboTownship
            // 
            this.cboTownship.FormattingEnabled = true;
            this.cboTownship.Location = new System.Drawing.Point(646, 159);
            this.cboTownship.Name = "cboTownship";
            this.cboTownship.Size = new System.Drawing.Size(92, 21);
            this.cboTownship.TabIndex = 37;
            // 
            // cboOneChar
            // 
            this.cboOneChar.FormattingEnabled = true;
            this.cboOneChar.Items.AddRange(new object[] {
            "N",
            "P",
            "E",
            "C",
            "AC",
            "NC"});
            this.cboOneChar.Location = new System.Drawing.Point(744, 157);
            this.cboOneChar.Name = "cboOneChar";
            this.cboOneChar.Size = new System.Drawing.Size(56, 21);
            this.cboOneChar.TabIndex = 38;
            // 
            // lblBackslash
            // 
            this.lblBackslash.AutoSize = true;
            this.lblBackslash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackslash.Location = new System.Drawing.Point(625, 158);
            this.lblBackslash.Name = "lblBackslash";
            this.lblBackslash.Size = new System.Drawing.Size(15, 24);
            this.lblBackslash.TabIndex = 39;
            this.lblBackslash.Text = "/";
            // 
            // hdUserID
            // 
            this.hdUserID.AutoSize = true;
            this.hdUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hdUserID.Location = new System.Drawing.Point(574, 75);
            this.hdUserID.Name = "hdUserID";
            this.hdUserID.Size = new System.Drawing.Size(0, 16);
            this.hdUserID.TabIndex = 40;
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdUserID);
            this.Controls.Add(this.lblBackslash);
            this.Controls.Add(this.cboOneChar);
            this.Controls.Add(this.cboTownship);
            this.Controls.Add(this.cboStateNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rtxtaddress);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtNrcnumber);
            this.Controls.Add(this.lblNrc);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.pnttladduser);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1200, 496);
            this.Load += new System.EventHandler(this.UCUser_Load_1);
            this.pnttladduser.ResumeLayout(false);
            this.pnttladduser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtaddress;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtNrcnumber;
        private System.Windows.Forms.Label lblNrc;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdduser;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel pnttladduser;
        private System.Windows.Forms.Label lblBackslash;
        private System.Windows.Forms.ComboBox cboOneChar;
        private System.Windows.Forms.ComboBox cboTownship;
        private System.Windows.Forms.ComboBox cboStateNumber;
        private System.Windows.Forms.Label hdUserID;
    }
}
