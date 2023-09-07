namespace LMS.APP.Views.FrmMenu
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.PnUC = new System.Windows.Forms.Panel();
            this.FormmenuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnUC
            // 
            this.PnUC.Location = new System.Drawing.Point(0, 54);
            this.PnUC.Name = "PnUC";
            this.PnUC.Size = new System.Drawing.Size(1200, 800);
            this.PnUC.TabIndex = 3;
            // 
            // FormmenuStrip
            // 
            this.FormmenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(12)))));
            this.FormmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.rentBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.rentalHistoryToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.FormmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FormmenuStrip.Name = "FormmenuStrip";
            this.FormmenuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.FormmenuStrip.Size = new System.Drawing.Size(1184, 54);
            this.FormmenuStrip.TabIndex = 2;
            this.FormmenuStrip.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(12)))));
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUsersToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.viewStaffToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.userMenu_DropDownClick);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.addUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addUsersToolStripMenuItem.Image")));
            this.addUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.addUsersToolStripMenuItem.Text = "Add Users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.viewUsersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.viewUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewUsersToolStripMenuItem.Image")));
            this.viewUsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.addStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addStaffToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStaffToolStripMenuItem.Image")));
            this.addStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            this.addStaffToolStripMenuItem.Visible = false;
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // viewStaffToolStripMenuItem
            // 
            this.viewStaffToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.viewStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.viewStaffToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStaffToolStripMenuItem.Image")));
            this.viewStaffToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            this.viewStaffToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.viewStaffToolStripMenuItem.Text = "View Staff";
            this.viewStaffToolStripMenuItem.Visible = false;
            this.viewStaffToolStripMenuItem.Click += new System.EventHandler(this.viewStaffToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(94, 54);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BookMenu_DropDownClick);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.addBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBooksToolStripMenuItem.Image")));
            this.addBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.viewBooksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.viewBooksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBooksToolStripMenuItem.Image")));
            this.viewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(170, 36);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            // 
            // rentBookToolStripMenuItem
            // 
            this.rentBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.rentBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentBookToolStripMenuItem.Image")));
            this.rentBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rentBookToolStripMenuItem.Name = "rentBookToolStripMenuItem";
            this.rentBookToolStripMenuItem.Size = new System.Drawing.Size(124, 54);
            this.rentBookToolStripMenuItem.Text = "Rent Book";
            this.rentBookToolStripMenuItem.Click += new System.EventHandler(this.rentBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.returnBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBookToolStripMenuItem.Image")));
            this.returnBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(139, 54);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // rentalHistoryToolStripMenuItem
            // 
            this.rentalHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.rentalHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentalHistoryToolStripMenuItem.Image")));
            this.rentalHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rentalHistoryToolStripMenuItem.Name = "rentalHistoryToolStripMenuItem";
            this.rentalHistoryToolStripMenuItem.Size = new System.Drawing.Size(152, 54);
            this.rentalHistoryToolStripMenuItem.Text = "Rental History";
            this.rentalHistoryToolStripMenuItem.Click += new System.EventHandler(this.rentalHistoryToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.profileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.Image")));
            this.profileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(97, 54);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.PnUC);
            this.Controls.Add(this.FormmenuStrip);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.FormmenuStrip.ResumeLayout(false);
            this.FormmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnUC;
        private System.Windows.Forms.MenuStrip FormmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}