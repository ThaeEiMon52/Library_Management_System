namespace LMS.APP.Views.Book
{
    partial class UCRentalHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRentalHistory = new System.Windows.Forms.DataGridView();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRentStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcReturnStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoDataFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental History";
            // 
            // dgvRentalHistory
            // 
            this.dgvRentalHistory.AllowUserToAddRows = false;
            this.dgvRentalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcName,
            this.gcNRC,
            this.gcPhone,
            this.gcEmail,
            this.gcAddress,
            this.gcBookTitle,
            this.gcAuthor,
            this.gcRentDate,
            this.gcDueDate,
            this.gcRentStaff,
            this.gcReturnDate,
            this.gcReturnStaff,
            this.Column2,
            this.Column3,
            this.gcRentalID});
            this.dgvRentalHistory.Location = new System.Drawing.Point(24, 190);
            this.dgvRentalHistory.Name = "dgvRentalHistory";
            this.dgvRentalHistory.Size = new System.Drawing.Size(1143, 319);
            this.dgvRentalHistory.TabIndex = 1;
            this.dgvRentalHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentalHistory_CellContentClick);
            this.dgvRentalHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRentalHistory_CellFormatting);
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "user_name";
            this.gcName.HeaderText = "Name";
            this.gcName.Name = "gcName";
            // 
            // gcNRC
            // 
            this.gcNRC.DataPropertyName = "nrc";
            this.gcNRC.HeaderText = "NRC";
            this.gcNRC.Name = "gcNRC";
            // 
            // gcPhone
            // 
            this.gcPhone.DataPropertyName = "phone";
            this.gcPhone.HeaderText = "Phone";
            this.gcPhone.Name = "gcPhone";
            // 
            // gcEmail
            // 
            this.gcEmail.DataPropertyName = "email";
            this.gcEmail.HeaderText = "Email";
            this.gcEmail.Name = "gcEmail";
            // 
            // gcAddress
            // 
            this.gcAddress.DataPropertyName = "address";
            this.gcAddress.HeaderText = "Address";
            this.gcAddress.Name = "gcAddress";
            // 
            // gcBookTitle
            // 
            this.gcBookTitle.DataPropertyName = "title";
            this.gcBookTitle.HeaderText = "Book Tile";
            this.gcBookTitle.Name = "gcBookTitle";
            // 
            // gcAuthor
            // 
            this.gcAuthor.DataPropertyName = "author";
            this.gcAuthor.HeaderText = "Author";
            this.gcAuthor.Name = "gcAuthor";
            // 
            // gcRentDate
            // 
            this.gcRentDate.DataPropertyName = "issue_date";
            this.gcRentDate.HeaderText = "Rent Date";
            this.gcRentDate.Name = "gcRentDate";
            // 
            // gcDueDate
            // 
            this.gcDueDate.DataPropertyName = "due_date";
            this.gcDueDate.HeaderText = "Due Date";
            this.gcDueDate.Name = "gcDueDate";
            this.gcDueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gcRentStaff
            // 
            this.gcRentStaff.DataPropertyName = "staff_issue_name";
            this.gcRentStaff.HeaderText = "Rent Staff";
            this.gcRentStaff.Name = "gcRentStaff";
            // 
            // gcReturnDate
            // 
            this.gcReturnDate.DataPropertyName = "return_date";
            this.gcReturnDate.HeaderText = "Return Date";
            this.gcReturnDate.Name = "gcReturnDate";
            // 
            // gcReturnStaff
            // 
            this.gcReturnStaff.DataPropertyName = "staff_receive_name";
            this.gcReturnStaff.HeaderText = "Return Staff";
            this.gcReturnStaff.Name = "gcReturnStaff";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "status_display";
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fine_amount";
            this.Column3.HeaderText = "Fine Amount";
            this.Column3.Name = "Column3";
            // 
            // gcRentalID
            // 
            this.gcRentalID.DataPropertyName = "rental_id";
            this.gcRentalID.HeaderText = "Rental ID";
            this.gcRentalID.Name = "gcRentalID";
            this.gcRentalID.Visible = false;
            // 
            // cboFilterBy
            // 
            this.cboFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterBy.FormattingEnabled = true;
            this.cboFilterBy.Items.AddRange(new object[] {
            "All",
            "Borrowed",
            "Returned",
            "Lost"});
            this.cboFilterBy.Location = new System.Drawing.Point(578, 134);
            this.cboFilterBy.Name = "cboFilterBy";
            this.cboFilterBy.Size = new System.Drawing.Size(121, 28);
            this.cboFilterBy.TabIndex = 2;
            this.cboFilterBy.SelectedIndexChanged += new System.EventHandler(this.cboFilterBy_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(866, 136);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1083, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(575, 104);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 16);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(719, 104);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(72, 16);
            this.lblSearchBy.TabIndex = 6;
            this.lblSearchBy.Text = "Search By:";
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Due Date",
            "Return Date",
            "Rent Date"});
            this.cboSearchBy.Location = new System.Drawing.Point(722, 134);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(121, 28);
            this.cboSearchBy.TabIndex = 7;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(712, 545);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 32);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1092, 545);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(854, 555);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(0, 13);
            this.lblPageNumber.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(863, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter the date in YYYY-MM-DD format";
            // 
            // lblNoDataFound
            // 
            this.lblNoDataFound.AutoSize = true;
            this.lblNoDataFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDataFound.ForeColor = System.Drawing.Color.Red;
            this.lblNoDataFound.Location = new System.Drawing.Point(540, 340);
            this.lblNoDataFound.Name = "lblNoDataFound";
            this.lblNoDataFound.Size = new System.Drawing.Size(0, 16);
            this.lblNoDataFound.TabIndex = 12;
            // 
            // UCRentalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.Controls.Add(this.lblNoDataFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.cboSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboFilterBy);
            this.Controls.Add(this.dgvRentalHistory);
            this.Controls.Add(this.panel1);
            this.Name = "UCRentalHistory";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.UCRentalHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRentalHistory;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoDataFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRentStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcReturnStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRentalID;
    }
}
