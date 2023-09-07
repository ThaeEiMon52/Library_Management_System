namespace LMS.APP.Views.LoginForm
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.whitepanel = new System.Windows.Forms.Panel();
            this.imgpanel4 = new System.Windows.Forms.Panel();
            this.imgpanel3 = new System.Windows.Forms.Panel();
            this.imgpanel2 = new System.Windows.Forms.Panel();
            this.imgpanel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.whitepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // whitepanel
            // 
            this.whitepanel.BackColor = System.Drawing.Color.White;
            this.whitepanel.Controls.Add(this.imgpanel4);
            this.whitepanel.Controls.Add(this.imgpanel3);
            this.whitepanel.Controls.Add(this.imgpanel2);
            this.whitepanel.Controls.Add(this.imgpanel1);
            this.whitepanel.Controls.Add(this.btnLogin);
            this.whitepanel.Controls.Add(this.lblPassword);
            this.whitepanel.Controls.Add(this.lblEmail);
            this.whitepanel.Controls.Add(this.txtLoginPassword);
            this.whitepanel.Controls.Add(this.txtLoginEmail);
            this.whitepanel.Location = new System.Drawing.Point(62, 75);
            this.whitepanel.Name = "whitepanel";
            this.whitepanel.Size = new System.Drawing.Size(860, 410);
            this.whitepanel.TabIndex = 1;
            // 
            // imgpanel4
            // 
            this.imgpanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgpanel4.BackgroundImage")));
            this.imgpanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgpanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgpanel4.Location = new System.Drawing.Point(767, 231);
            this.imgpanel4.Name = "imgpanel4";
            this.imgpanel4.Size = new System.Drawing.Size(29, 23);
            this.imgpanel4.TabIndex = 8;
            // 
            // imgpanel3
            // 
            this.imgpanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgpanel3.BackgroundImage")));
            this.imgpanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgpanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgpanel3.Location = new System.Drawing.Point(767, 150);
            this.imgpanel3.Name = "imgpanel3";
            this.imgpanel3.Size = new System.Drawing.Size(29, 25);
            this.imgpanel3.TabIndex = 7;
            // 
            // imgpanel2
            // 
            this.imgpanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgpanel2.BackgroundImage")));
            this.imgpanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgpanel2.Location = new System.Drawing.Point(544, 3);
            this.imgpanel2.Name = "imgpanel2";
            this.imgpanel2.Size = new System.Drawing.Size(200, 100);
            this.imgpanel2.TabIndex = 6;
            // 
            // imgpanel1
            // 
            this.imgpanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgpanel1.BackgroundImage")));
            this.imgpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgpanel1.Location = new System.Drawing.Point(107, 119);
            this.imgpanel1.Name = "imgpanel1";
            this.imgpanel1.Size = new System.Drawing.Size(261, 166);
            this.imgpanel1.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(541, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(538, 211);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(541, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(541, 231);
            this.txtLoginPassword.Multiline = true;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(255, 23);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginEmail.Location = new System.Drawing.Point(541, 150);
            this.txtLoginEmail.Multiline = true;
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(255, 25);
            this.txtLoginEmail.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.whitepanel);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.whitepanel.ResumeLayout(false);
            this.whitepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel whitepanel;
        private System.Windows.Forms.Panel imgpanel4;
        private System.Windows.Forms.Panel imgpanel3;
        private System.Windows.Forms.Panel imgpanel2;
        private System.Windows.Forms.Panel imgpanel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginEmail;
    }
}