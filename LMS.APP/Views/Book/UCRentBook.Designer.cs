namespace LMS.APP.Views.Book
{
    partial class UCRentBook
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
            this.pnRentBook = new System.Windows.Forms.Panel();
            this.lblRentBook = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnRentBook = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvRentedBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnRentBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnRentBook
            // 
            this.pnRentBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(228)))), ((int)(((byte)(2)))));
            this.pnRentBook.Controls.Add(this.lblRentBook);
            this.pnRentBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRentBook.Location = new System.Drawing.Point(0, 0);
            this.pnRentBook.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.pnRentBook.Name = "pnRentBook";
            this.pnRentBook.Size = new System.Drawing.Size(1200, 80);
            this.pnRentBook.TabIndex = 0;
            // 
            // lblRentBook
            // 
            this.lblRentBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRentBook.AutoSize = true;
            this.lblRentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentBook.ForeColor = System.Drawing.Color.White;
            this.lblRentBook.Location = new System.Drawing.Point(520, 27);
            this.lblRentBook.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblRentBook.Name = "lblRentBook";
            this.lblRentBook.Size = new System.Drawing.Size(123, 26);
            this.lblRentBook.TabIndex = 0;
            this.lblRentBook.Text = "Rent Book";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(35, 143);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(95, 17);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Enter Book ID";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(35, 229);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(93, 17);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Enter User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rent Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Due Date";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(38, 172);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(225, 26);
            this.txtBookID.TabIndex = 6;
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(38, 258);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(225, 26);
            this.txtUserID.TabIndex = 7;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(38, 354);
            this.dtpRentDate.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(225, 26);
            this.dtpRentDate.TabIndex = 8;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(38, 434);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(225, 26);
            this.dtpDueDate.TabIndex = 9;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(281, 172);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(93, 26);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(281, 258);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(93, 26);
            this.btnSearchUser.TabIndex = 11;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnRentBook
            // 
            this.btnRentBook.BackColor = System.Drawing.Color.Lime;
            this.btnRentBook.Location = new System.Drawing.Point(178, 484);
            this.btnRentBook.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnRentBook.Name = "btnRentBook";
            this.btnRentBook.Size = new System.Drawing.Size(85, 28);
            this.btnRentBook.TabIndex = 13;
            this.btnRentBook.Text = "Checkout";
            this.btnRentBook.UseVisualStyleBackColor = false;
            this.btnRentBook.Click += new System.EventHandler(this.btnRentBook_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Wheat;
            this.btnClear.Location = new System.Drawing.Point(38, 484);
            this.btnClear.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvRentedBook
            // 
            this.dgvRentedBook.AllowUserToAddRows = false;
            this.dgvRentedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentedBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.gcDueDate});
            this.dgvRentedBook.Location = new System.Drawing.Point(451, 172);
            this.dgvRentedBook.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dgvRentedBook.Name = "dgvRentedBook";
            this.dgvRentedBook.RowHeadersVisible = false;
            this.dgvRentedBook.RowHeadersWidth = 62;
            this.dgvRentedBook.RowTemplate.Height = 28;
            this.dgvRentedBook.Size = new System.Drawing.Size(718, 231);
            this.dgvRentedBook.TabIndex = 17;
            this.dgvRentedBook.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRentedBook_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "book_id";
            this.Column1.HeaderText = "Book ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "title";
            this.Column2.HeaderText = "Title";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "author";
            this.Column3.HeaderText = "Author";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "publisher";
            this.Column4.HeaderText = "Publisher";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "edition_number";
            this.Column6.HeaderText = "Edition Number";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "publication_date";
            this.Column7.HeaderText = "Publication Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "category_name";
            this.Column8.HeaderText = "Category";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "language";
            this.Column9.HeaderText = "Language";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "rent_date";
            this.Column10.HeaderText = "Rent Date";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            // 
            // gcDueDate
            // 
            this.gcDueDate.DataPropertyName = "due_date";
            this.gcDueDate.HeaderText = "Due Date";
            this.gcDueDate.MinimumWidth = 8;
            this.gcDueDate.Name = "gcDueDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rented Books";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(35, 201);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(0, 13);
            this.lblBookTitle.TabIndex = 19;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(35, 287);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 20;
            // 
            // UCRentBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(2)))));
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRentedBook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRentBook);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.pnRentBook);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "UCRentBook";
            this.Size = new System.Drawing.Size(1200, 1200);
            this.Load += new System.EventHandler(this.UCRentBook_Load);
            this.pnRentBook.ResumeLayout(false);
            this.pnRentBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnRentBook;
        private System.Windows.Forms.Label lblRentBook;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnRentBook;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvRentedBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDueDate;
    }
}
