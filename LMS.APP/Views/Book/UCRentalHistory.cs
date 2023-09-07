using LMS.Entities.BookRental;
using LMS.Services.BookRental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS.APP.Views.Book
{
    public partial class UCRentalHistory : UserControl
    {
        private int pageSize = 5;
        private int pageNumber = 1;
        //List<FilterBookRentalEntity> filterBookRentalList = new List<FilterBookRentalEntity>();

        private System.Data.DataTable rentalHistoryTable;
        private BindingSource rentalHistoryBindingSource;
        private DataView rentalHistoryView;
        
        BookRentalService bookRentalService = new BookRentalService();
        public UCRentalHistory()
        {
            InitializeComponent();
            cboFilterBy.SelectedIndex = 0;
            cboSearchBy.SelectedIndex = 0;
            

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Operation";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvRentalHistory.Columns.Insert(0, deleteButtonColumn); // insert after Age column
        }

        private void UCRentalHistory_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvRentalHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (cboFilterBy.SelectedIndex == 0)
            {
                DateTime dueDate = Convert.ToDateTime(dgvRentalHistory.Rows[e.RowIndex].Cells["gcDueDate"].Value);

                if (dueDate < DateTime.Today && string.IsNullOrEmpty(Convert.ToString(dgvRentalHistory.Rows[e.RowIndex].Cells["gcReturnDate"].Value)))
                {
                    dgvRentalHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
                else if (dgvRentalHistory.Rows[e.RowIndex].Cells["gcReturnDate"].Value != null && dgvRentalHistory.Rows[e.RowIndex].Cells["gcReturnDate"].Value != DBNull.Value && dgvRentalHistory.Rows[e.RowIndex].Cells["gcReturnDate"].Value != "")
                {
                    DateTime returnDate = Convert.ToDateTime(dgvRentalHistory.Rows[e.RowIndex].Cells["gcReturnDate"].Value);

                    if (dueDate < returnDate)
                    {
                        dgvRentalHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvRentalHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            char filterBy = 'A';
            switch (cboFilterBy.SelectedIndex)
            {
                case 0:
                    filterBy = 'A';
                    break;
                case 1:
                    filterBy = 'B';
                    break;
                case 2:
                    filterBy = 'R';
                    break;
                case 3:
                    filterBy = 'L';
                    break;
                default:
                    MessageBox.Show("Invalid filter option selected.");
                    return;
            }

            rentalHistoryTable = bookRentalService.GetRentalHistory(filterBy);

            if (rentalHistoryTable.Rows.Count > 0)
            {
                lblNoDataFound.Text = "";

                rentalHistoryTable.Columns.Add("rownum", typeof(int));
                for (int i = 0; i < rentalHistoryTable.Rows.Count; i++)
                {
                    rentalHistoryTable.Rows[i]["rownum"] = i + 1;
                }

                rentalHistoryView = new DataView(rentalHistoryTable);
                rentalHistoryBindingSource = new BindingSource();
                rentalHistoryBindingSource.DataSource = rentalHistoryView;

                // Bind the BindingSource to the DataGridView control
                dgvRentalHistory.DataSource = rentalHistoryBindingSource;
                dgvRentalHistory.Columns["rownum"].Visible = false;

                // Display the first page of data
                DisplayPage();

                // Calculate the total number of pages
                int totalPages = (int)Math.Ceiling((double)rentalHistoryTable.Rows.Count / pageSize);

                // Set the label text to display the current page number and total number of pages
                lblPageNumber.Text = $"Page {pageNumber} of {totalPages}, Total Records: {rentalHistoryTable.Rows.Count}";
            }
            else
            {
                rentalHistoryView.Table.Clear(); // if using DataView
                                                 // or
                rentalHistoryTable.Clear(); // if using DataTable

                lblNoDataFound.Text = "No rental history found.";
                lblNoDataFound.ForeColor = Color.Red;
            }


        }

        private void DisplayPage()
        {
            int startIndex = (pageNumber - 1) * pageSize;

            // Apply the filter to display only the desired page
            rentalHistoryView.RowFilter = $"rownum >= {startIndex + 1} AND rownum <= {startIndex + pageSize}";

            // Update the label to show the current page number
            int totalPages = (int)Math.Ceiling((double)rentalHistoryTable.Rows.Count / pageSize);
            //lblPageNumber.Text = $"Page {pageNumber} of {totalPages}";
            lblPageNumber.Text = $"Page {pageNumber} of {totalPages}, Total Records: {rentalHistoryTable.Rows.Count}";

            // Disable the Previous and Next buttons if necessary
            btnPrevious.Enabled = (pageNumber > 1);
            btnNext.Enabled = (pageNumber < totalPages);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                DisplayPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)rentalHistoryTable.Rows.Count / pageSize);
            if (pageNumber < totalPages)
            {
                pageNumber++;
                DisplayPage();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            if (!DateTime.TryParseExact(txtSearch.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var searchDate))
            {
                MessageBox.Show("Please enter a date in the format 'yyyy-MM-dd'.");
                return;
            }

            char filterBy = 'A';
            switch (cboFilterBy.SelectedIndex)
            {
                case 0:
                    filterBy = 'A';
                    break;
                case 1:
                    filterBy = 'B';
                    break;
                case 2:
                    filterBy = 'R';
                    break;
                case 3:
                    filterBy = 'L';
                    break;
                default:
                    MessageBox.Show("Invalid filter option selected.");
                    return;
            }

            string searchColumn = string.Empty;
            switch (cboSearchBy.SelectedItem.ToString())
            {
                case "Due Date":
                    searchColumn = "rh.due_date";
                    break;
                case "Rent Date":
                    searchColumn = "rh.issue_date";
                    break;
                case "Return Date":
                    searchColumn = "rh.return_date";
                    break;
                default:
                    MessageBox.Show("Invalid search option selected.");
                    return;
            }

            rentalHistoryTable = bookRentalService.SearchRentalHistory(searchColumn, filterBy, searchDate.ToString("yyyy-MM-dd"));

            if (rentalHistoryTable != null && rentalHistoryTable.Rows.Count > 0)
            {
                lblNoDataFound.Text = "";
                rentalHistoryTable.Columns.Add("rownum", typeof(int));
                for (int i = 0; i < rentalHistoryTable.Rows.Count; i++)
                {
                    rentalHistoryTable.Rows[i]["rownum"] = i + 1;
                }

                rentalHistoryView = new DataView(rentalHistoryTable);
                rentalHistoryBindingSource = new BindingSource();
                rentalHistoryBindingSource.DataSource = rentalHistoryView;

                // Bind the BindingSource to the DataGridView control
                dgvRentalHistory.DataSource = rentalHistoryBindingSource;
                dgvRentalHistory.Columns["rownum"].Visible = false;

                // Display the first page of data
                DisplayPage();

                // Calculate the total number of pages
                int totalPages = (int)Math.Ceiling((double)rentalHistoryTable.Rows.Count / pageSize);

                // Set the label text to display the current page number and total number of pages
                lblPageNumber.Text = $"Page {pageNumber} of {totalPages}, Total Records: {rentalHistoryTable.Rows.Count}";
            }
            else
            {
                rentalHistoryView.Table.Clear(); // if using DataView
                                                 // or
                rentalHistoryTable.Clear(); // if using DataTable

                lblNoDataFound.Text = "No rental history found.";
                lblNoDataFound.ForeColor = Color.Red;
            }



        }

        private void BindGrid()
        {
            rentalHistoryTable = bookRentalService.GetRentalHistory('A');

            if (rentalHistoryTable.Rows.Count > 0)
            {
                lblNoDataFound.Text = "";
                rentalHistoryTable.Columns.Add("rownum", typeof(int));
                for (int i = 0; i < rentalHistoryTable.Rows.Count; i++)
                {
                    rentalHistoryTable.Rows[i]["rownum"] = i + 1;
                }

                rentalHistoryView = new DataView(rentalHistoryTable);
                rentalHistoryBindingSource = new BindingSource();
                rentalHistoryBindingSource.DataSource = rentalHistoryView;

                // Bind the BindingSource to the DataGridView control
                dgvRentalHistory.DataSource = rentalHistoryBindingSource;
                dgvRentalHistory.Columns["rownum"].Visible = false;

                // Display the first page of data
                DisplayPage();

                // Calculate the total number of pages
                int totalPages = (int)Math.Ceiling((double)rentalHistoryTable.Rows.Count / pageSize);

                // Set the label text to display the current page number and total number of pages
                lblPageNumber.Text = $"Page {pageNumber} of {totalPages}, Total Records: {rentalHistoryTable.Rows.Count}";
            }
            else
            {
                rentalHistoryView.Table.Clear(); // if using DataView
                                                 // or
                rentalHistoryTable.Clear(); // if using DataTable

                lblNoDataFound.Text = "No rental history found.";
                lblNoDataFound.ForeColor = Color.Red;
            }
        }

        private void dgvRentalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRentalHistory.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Retrieve the row to be deleted
                DataGridViewRow row = dgvRentalHistory.Rows[e.RowIndex];

                // Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    

                    // Delete the row from the underlying data source
                    int rentalHistoryId = Convert.ToInt32(row.Cells["gcRentalID"].Value);
                    if (bookRentalService.DeleteRentalHistory(rentalHistoryId))
                    {
                        // Delete the row from the DataGridView
                        dgvRentalHistory.Rows.Remove(row);
                        MessageBox.Show("success");
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
            }
        }
    }
}
