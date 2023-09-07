namespace LMS.APP.Views.Staff
{
    partial class AddStaff
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
            this.pnBodyAddStaff = new System.Windows.Forms.Panel();
            this.btnStaffCancel = new System.Windows.Forms.Button();
            this.hideStaffID = new System.Windows.Forms.Label();
            this.btnStaffCreateAccount = new System.Windows.Forms.Button();
            this.txtstaffemail = new System.Windows.Forms.TextBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pnTitleAddStaff = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBodyAddStaff.SuspendLayout();
            this.pnTitleAddStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBodyAddStaff
            // 
            this.pnBodyAddStaff.BackColor = System.Drawing.Color.White;
            this.pnBodyAddStaff.Controls.Add(this.btnStaffCancel);
            this.pnBodyAddStaff.Controls.Add(this.hideStaffID);
            this.pnBodyAddStaff.Controls.Add(this.btnStaffCreateAccount);
            this.pnBodyAddStaff.Controls.Add(this.txtstaffemail);
            this.pnBodyAddStaff.Controls.Add(this.txtStaffPassword);
            this.pnBodyAddStaff.Controls.Add(this.txtStaffAddress);
            this.pnBodyAddStaff.Controls.Add(this.txtStaffPhone);
            this.pnBodyAddStaff.Controls.Add(this.txtStaffName);
            this.pnBodyAddStaff.Controls.Add(this.rdoFemale);
            this.pnBodyAddStaff.Controls.Add(this.rdoMale);
            this.pnBodyAddStaff.Controls.Add(this.lblEmail);
            this.pnBodyAddStaff.Controls.Add(this.lblPassword);
            this.pnBodyAddStaff.Controls.Add(this.lblPhone);
            this.pnBodyAddStaff.Controls.Add(this.lblGender);
            this.pnBodyAddStaff.Controls.Add(this.lblAddress);
            this.pnBodyAddStaff.Controls.Add(this.lblname);
            this.pnBodyAddStaff.Controls.Add(this.pnTitleAddStaff);
            this.pnBodyAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBodyAddStaff.Location = new System.Drawing.Point(0, 0);
            this.pnBodyAddStaff.Name = "pnBodyAddStaff";
            this.pnBodyAddStaff.Size = new System.Drawing.Size(1200, 800);
            this.pnBodyAddStaff.TabIndex = 0;
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.BackColor = System.Drawing.Color.Red;
            this.btnStaffCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCancel.ForeColor = System.Drawing.Color.White;
            this.btnStaffCancel.Location = new System.Drawing.Point(745, 434);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.Size = new System.Drawing.Size(130, 35);
            this.btnStaffCancel.TabIndex = 22;
            this.btnStaffCancel.Text = "Cancel";
            this.btnStaffCancel.UseVisualStyleBackColor = false;
            this.btnStaffCancel.Click += new System.EventHandler(this.btnStaffCancel_Click);
            // 
            // hideStaffID
            // 
            this.hideStaffID.AutoSize = true;
            this.hideStaffID.Location = new System.Drawing.Point(545, 74);
            this.hideStaffID.Name = "hideStaffID";
            this.hideStaffID.Size = new System.Drawing.Size(0, 17);
            this.hideStaffID.TabIndex = 21;
            // 
            // btnStaffCreateAccount
            // 
            this.btnStaffCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnStaffCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnStaffCreateAccount.Location = new System.Drawing.Point(548, 434);
            this.btnStaffCreateAccount.Name = "btnStaffCreateAccount";
            this.btnStaffCreateAccount.Size = new System.Drawing.Size(130, 35);
            this.btnStaffCreateAccount.TabIndex = 19;
            this.btnStaffCreateAccount.Text = "Create Account";
            this.btnStaffCreateAccount.UseVisualStyleBackColor = false;
            this.btnStaffCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtstaffemail
            // 
            this.txtstaffemail.BackColor = System.Drawing.Color.White;
            this.txtstaffemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaffemail.Location = new System.Drawing.Point(548, 166);
            this.txtstaffemail.Name = "txtstaffemail";
            this.txtstaffemail.Size = new System.Drawing.Size(328, 23);
            this.txtstaffemail.TabIndex = 18;
            this.txtstaffemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtstaffemail_Validating);
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.BackColor = System.Drawing.Color.White;
            this.txtStaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPassword.Location = new System.Drawing.Point(548, 213);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.PasswordChar = '*';
            this.txtStaffPassword.Size = new System.Drawing.Size(328, 23);
            this.txtStaffPassword.TabIndex = 17;
            this.txtStaffPassword.UseSystemPasswordChar = true;
            this.txtStaffPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtstaffemail_Validating);
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.BackColor = System.Drawing.Color.White;
            this.txtStaffAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAddress.Location = new System.Drawing.Point(548, 343);
            this.txtStaffAddress.Multiline = true;
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(327, 69);
            this.txtStaffAddress.TabIndex = 16;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.BackColor = System.Drawing.Color.White;
            this.txtStaffPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPhone.Location = new System.Drawing.Point(548, 253);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(328, 23);
            this.txtStaffPhone.TabIndex = 12;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BackColor = System.Drawing.Color.White;
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(547, 119);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(328, 23);
            this.txtStaffName.TabIndex = 11;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(696, 298);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(72, 21);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(547, 298);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(56, 21);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(407, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(407, 213);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(407, 253);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(407, 298);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(407, 343);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(407, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // pnTitleAddStaff
            // 
            this.pnTitleAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.pnTitleAddStaff.Controls.Add(this.label1);
            this.pnTitleAddStaff.Location = new System.Drawing.Point(0, 0);
            this.pnTitleAddStaff.Name = "pnTitleAddStaff";
            this.pnTitleAddStaff.Size = new System.Drawing.Size(1200, 49);
            this.pnTitleAddStaff.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Staff";
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.pnBodyAddStaff);
            this.Name = "AddStaff";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.pnBodyAddStaff.ResumeLayout(false);
            this.pnBodyAddStaff.PerformLayout();
            this.pnTitleAddStaff.ResumeLayout(false);
            this.pnTitleAddStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBodyAddStaff;
        private System.Windows.Forms.Panel pnTitleAddStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStaffCreateAccount;
        private System.Windows.Forms.TextBox txtstaffemail;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblname;
//        private LibraryManagementSystemDBDataSetTableAdapters.staffsTableAdapter staffsTableAdapter;
        private System.Windows.Forms.Label hideStaffID;
        private System.Windows.Forms.Button btnStaffCancel;
    }
}
