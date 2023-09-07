namespace LMS.APP.Views.Staff
{
    partial class ViewStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitleViewStaff = new System.Windows.Forms.Panel();
            this.lblViewStaff = new System.Windows.Forms.Label();
            this.dgvViewStaff = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtViewStaffSearch = new System.Windows.Forms.TextBox();
            this.btnViewStaffExport = new System.Windows.Forms.Button();
            this.btnviewStaffSearch = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.gcStaffID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.gcPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcOperation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnTitleViewStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitleViewStaff
            // 
            this.pnTitleViewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.pnTitleViewStaff.Controls.Add(this.lblViewStaff);
            this.pnTitleViewStaff.Location = new System.Drawing.Point(0, 0);
            this.pnTitleViewStaff.Name = "pnTitleViewStaff";
            this.pnTitleViewStaff.Size = new System.Drawing.Size(1200, 55);
            this.pnTitleViewStaff.TabIndex = 0;
            // 
            // lblViewStaff
            // 
            this.lblViewStaff.AutoSize = true;
            this.lblViewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStaff.ForeColor = System.Drawing.Color.White;
            this.lblViewStaff.Location = new System.Drawing.Point(483, 14);
            this.lblViewStaff.Name = "lblViewStaff";
            this.lblViewStaff.Size = new System.Drawing.Size(110, 25);
            this.lblViewStaff.TabIndex = 0;
            this.lblViewStaff.Text = "View Staff";
            // 
            // dgvViewStaff
            // 
            this.dgvViewStaff.AllowUserToAddRows = false;
            this.dgvViewStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvViewStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewStaff.ColumnHeadersHeight = 30;
            this.dgvViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcStaffID,
            this.gcName,
            this.gcPhoto,
            this.gcPassword,
            this.gcPhone,
            this.gcemail,
            this.gcAddress,
            this.gcGender,
            this.gcRole,
            this.gcOperation});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewStaff.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvViewStaff.EnableHeadersVisualStyles = false;
            this.dgvViewStaff.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvViewStaff.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvViewStaff.Location = new System.Drawing.Point(23, 171);
            this.dgvViewStaff.Name = "dgvViewStaff";
            this.dgvViewStaff.ReadOnly = true;
            this.dgvViewStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvViewStaff.RowHeadersVisible = false;
            this.dgvViewStaff.Size = new System.Drawing.Size(1154, 304);
            this.dgvViewStaff.TabIndex = 1;
            this.dgvViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteStaff_CellClick);
            this.dgvViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStaff_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(159, 105);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            // 
            // txtViewStaffSearch
            // 
            this.txtViewStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewStaffSearch.Location = new System.Drawing.Point(245, 98);
            this.txtViewStaffSearch.Multiline = true;
            this.txtViewStaffSearch.Name = "txtViewStaffSearch";
            this.txtViewStaffSearch.Size = new System.Drawing.Size(377, 32);
            this.txtViewStaffSearch.TabIndex = 3;
            // 
            // btnViewStaffExport
            // 
            this.btnViewStaffExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnViewStaffExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaffExport.Location = new System.Drawing.Point(958, 105);
            this.btnViewStaffExport.Name = "btnViewStaffExport";
            this.btnViewStaffExport.Size = new System.Drawing.Size(109, 33);
            this.btnViewStaffExport.TabIndex = 5;
            this.btnViewStaffExport.Text = "Export";
            this.btnViewStaffExport.UseVisualStyleBackColor = false;
            this.btnViewStaffExport.Click += new System.EventHandler(this.btnViewStaffExport_Click);
            // 
            // btnviewStaffSearch
            // 
            this.btnviewStaffSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnviewStaffSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnviewStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewStaffSearch.ForeColor = System.Drawing.Color.Black;
            this.btnviewStaffSearch.Location = new System.Drawing.Point(647, 100);
            this.btnviewStaffSearch.Name = "btnviewStaffSearch";
            this.btnviewStaffSearch.Size = new System.Drawing.Size(114, 33);
            this.btnviewStaffSearch.TabIndex = 6;
            this.btnviewStaffSearch.Text = "Search";
            this.btnviewStaffSearch.UseMnemonic = false;
            this.btnviewStaffSearch.UseVisualStyleBackColor = false;
            this.btnviewStaffSearch.Click += new System.EventHandler(this.btnviewStaffSearch_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(488, 526);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(616, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.Location = new System.Drawing.Point(562, 529);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(31, 17);
            this.lblPageNumber.TabIndex = 9;
            this.lblPageNumber.Text = "1/2";
            // 
            // gcStaffID
            // 
            this.gcStaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcStaffID.DataPropertyName = "staff_id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcStaffID.DefaultCellStyle = dataGridViewCellStyle3;
            this.gcStaffID.FillWeight = 107.163F;
            this.gcStaffID.HeaderText = "Staff ID";
            this.gcStaffID.Name = "gcStaffID";
            this.gcStaffID.ReadOnly = true;
            this.gcStaffID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gcName.DefaultCellStyle = dataGridViewCellStyle4;
            this.gcName.FillWeight = 107.163F;
            this.gcName.HeaderText = "Name";
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            // 
            // gcPhoto
            // 
            this.gcPhoto.DataPropertyName = "photo";
            this.gcPhoto.FillWeight = 107.163F;
            this.gcPhoto.HeaderText = "Photo";
            this.gcPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.gcPhoto.MinimumWidth = 150;
            this.gcPhoto.Name = "gcPhoto";
            this.gcPhoto.ReadOnly = true;
            this.gcPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcPassword
            // 
            this.gcPassword.DataPropertyName = "password";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gcPassword.DefaultCellStyle = dataGridViewCellStyle5;
            this.gcPassword.FillWeight = 107.163F;
            this.gcPassword.HeaderText = "Password";
            this.gcPassword.Name = "gcPassword";
            this.gcPassword.ReadOnly = true;
            this.gcPassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gcPhone
            // 
            this.gcPhone.DataPropertyName = "phone";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gcPhone.DefaultCellStyle = dataGridViewCellStyle6;
            this.gcPhone.FillWeight = 107.163F;
            this.gcPhone.HeaderText = "Phone";
            this.gcPhone.Name = "gcPhone";
            this.gcPhone.ReadOnly = true;
            // 
            // gcemail
            // 
            this.gcemail.DataPropertyName = "email";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gcemail.DefaultCellStyle = dataGridViewCellStyle7;
            this.gcemail.FillWeight = 107.163F;
            this.gcemail.HeaderText = "Email";
            this.gcemail.Name = "gcemail";
            this.gcemail.ReadOnly = true;
            // 
            // gcAddress
            // 
            this.gcAddress.DataPropertyName = "address";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gcAddress.DefaultCellStyle = dataGridViewCellStyle8;
            this.gcAddress.FillWeight = 150F;
            this.gcAddress.HeaderText = "Address";
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.ReadOnly = true;
            // 
            // gcGender
            // 
            this.gcGender.DataPropertyName = "gender";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcGender.DefaultCellStyle = dataGridViewCellStyle9;
            this.gcGender.FillWeight = 70F;
            this.gcGender.HeaderText = "Gender";
            this.gcGender.Name = "gcGender";
            this.gcGender.ReadOnly = true;
            // 
            // gcRole
            // 
            this.gcRole.DataPropertyName = "role";
            this.gcRole.FillWeight = 70F;
            this.gcRole.HeaderText = "Role";
            this.gcRole.Name = "gcRole";
            this.gcRole.ReadOnly = true;
            // 
            // gcOperation
            // 
            this.gcOperation.DataPropertyName = "operation";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.gcOperation.DefaultCellStyle = dataGridViewCellStyle10;
            this.gcOperation.FillWeight = 107.163F;
            this.gcOperation.HeaderText = "Operation";
            this.gcOperation.Name = "gcOperation";
            this.gcOperation.ReadOnly = true;
            this.gcOperation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gcOperation.Text = "Delete";
            this.gcOperation.UseColumnTextForButtonValue = true;
            // 
            // ViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dgvViewStaff);
            this.Controls.Add(this.btnviewStaffSearch);
            this.Controls.Add(this.btnViewStaffExport);
            this.Controls.Add(this.txtViewStaffSearch);
            this.Controls.Add(this.pnTitleViewStaff);
            this.Controls.Add(this.lblSearch);
            this.Name = "ViewStaff";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.ViewStaff_Load);
            this.pnTitleViewStaff.ResumeLayout(false);
            this.pnTitleViewStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel pnTitleViewStaff;
        private System.Windows.Forms.Label lblViewStaff;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtViewStaffSearch;
        private System.Windows.Forms.Button btnViewStaffExport;
        private System.Windows.Forms.Button btnviewStaffSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.DataGridView dgvViewStaff;
        private System.Windows.Forms.DataGridViewLinkColumn gcStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewImageColumn gcPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRole;
        private System.Windows.Forms.DataGridViewButtonColumn gcOperation;
        //     private LibraryManagementSystemDBDataSet libraryManagementSystemDBDataSet;
    }
}
