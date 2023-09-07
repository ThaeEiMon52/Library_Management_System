namespace LMS.APP.Views.User
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnttlviewusers = new System.Windows.Forms.Panel();
            this.lblViewuser = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExportLocation = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPagesCount = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.gcUserID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnttlviewusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnttlviewusers
            // 
            this.pnttlviewusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.pnttlviewusers.Controls.Add(this.lblViewuser);
            this.pnttlviewusers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnttlviewusers.Location = new System.Drawing.Point(0, 0);
            this.pnttlviewusers.Name = "pnttlviewusers";
            this.pnttlviewusers.Size = new System.Drawing.Size(1200, 61);
            this.pnttlviewusers.TabIndex = 38;
            // 
            // lblViewuser
            // 
            this.lblViewuser.AutoSize = true;
            this.lblViewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewuser.ForeColor = System.Drawing.Color.White;
            this.lblViewuser.Location = new System.Drawing.Point(565, 17);
            this.lblViewuser.Name = "lblViewuser";
            this.lblViewuser.Size = new System.Drawing.Size(130, 25);
            this.lblViewuser.TabIndex = 1;
            this.lblViewuser.Text = "View Users";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(552, 100);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(114, 31);
            this.btnExport.TabIndex = 42;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(432, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 31);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 101);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 30);
            this.txtSearch.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search :";
            // 
            // txtExportLocation
            // 
            this.txtExportLocation.AutoSize = true;
            this.txtExportLocation.Location = new System.Drawing.Point(660, 149);
            this.txtExportLocation.Name = "txtExportLocation";
            this.txtExportLocation.Size = new System.Drawing.Size(0, 13);
            this.txtExportLocation.TabIndex = 44;
            this.txtExportLocation.Visible = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(543, 498);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(55, 31);
            this.btnPrevious.TabIndex = 45;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(707, 498);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 31);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPagesCount
            // 
            this.lblPagesCount.AutoSize = true;
            this.lblPagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesCount.ForeColor = System.Drawing.Color.Black;
            this.lblPagesCount.Location = new System.Drawing.Point(618, 504);
            this.lblPagesCount.Name = "lblPagesCount";
            this.lblPagesCount.Size = new System.Drawing.Size(65, 25);
            this.lblPagesCount.TabIndex = 47;
            this.lblPagesCount.Text = "? ? ?";
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcUserID,
            this.gcName,
            this.gcNrc,
            this.gcPhone,
            this.gcEmail,
            this.gcAddress,
            this.gcGender});
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.Location = new System.Drawing.Point(3, 211);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.Size = new System.Drawing.Size(1162, 178);
            this.dgvUserList.TabIndex = 48;
            this.dgvUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelete_cellclick);
            this.dgvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellContentClick_1);
            // 
            // gcUserID
            // 
            this.gcUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcUserID.DataPropertyName = "user_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcUserID.DefaultCellStyle = dataGridViewCellStyle2;
            this.gcUserID.HeaderText = "User ID";
            this.gcUserID.Name = "gcUserID";
            this.gcUserID.ReadOnly = true;
            // 
            // gcName
            // 
            this.gcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcName.DataPropertyName = "name";
            this.gcName.HeaderText = "Name";
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            // 
            // gcNrc
            // 
            this.gcNrc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcNrc.DataPropertyName = "nrc";
            this.gcNrc.HeaderText = "NRC";
            this.gcNrc.Name = "gcNrc";
            this.gcNrc.ReadOnly = true;
            // 
            // gcPhone
            // 
            this.gcPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcPhone.DataPropertyName = "phone";
            this.gcPhone.HeaderText = "Phone";
            this.gcPhone.Name = "gcPhone";
            this.gcPhone.ReadOnly = true;
            // 
            // gcEmail
            // 
            this.gcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcEmail.DataPropertyName = "email";
            this.gcEmail.HeaderText = "Email";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.ReadOnly = true;
            // 
            // gcAddress
            // 
            this.gcAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcAddress.DataPropertyName = "address";
            this.gcAddress.HeaderText = "Address";
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.ReadOnly = true;
            // 
            // gcGender
            // 
            this.gcGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcGender.DataPropertyName = "gender";
            this.gcGender.HeaderText = "Gender";
            this.gcGender.Name = "gcGender";
            this.gcGender.ReadOnly = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.lblPagesCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnttlviewusers);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExportLocation);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.pnttlviewusers.ResumeLayout(false);
            this.pnttlviewusers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnttlviewusers;
        private System.Windows.Forms.Label lblViewuser;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog FolderBD;
        private System.Windows.Forms.Label txtExportLocation;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPagesCount;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.DataGridViewLinkColumn gcUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcGender;
    }
}
