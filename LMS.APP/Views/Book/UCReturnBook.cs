using LMS.Services.Book;
using LMS.Services.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Services.Book;
using LMS.Services.User;
using LMS.Services.BookRental;
using LMS.Entities.BookRental;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS.APP.Views.Book
{
    public partial class UCReturnBook : UserControl
    {
        BookService bookService = new BookService();
        BookRentalService bookRentalService = new BookRentalService();
        UserServiceBook userService = new UserServiceBook();
        public UCReturnBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int userId;

            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please enter a user ID.");
                txtUserID.Focus();
                return;
            }

            if (!int.TryParse(txtUserID.Text, out userId))
            {
                MessageBox.Show("Please enter a valid user ID (numeric value).");
                txtUserID.Focus();
                return;
            }

            DataTable dt = userService.GetUserNameAndNRC(userId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string name = (string)row["name"];
                string nrc = (string)row["nrc"];

                string labelFormat = "{0} - {1}";
                lblUserName.Text = string.Format(labelFormat, name, nrc);
                lblUserName.ForeColor = Color.SeaGreen;

                dgvRentedBook.DataSource = bookService.GetRentedBookByUserId(userId);
                ckbLostBook.Enabled = (dgvRentedBook.RowCount > 0);
            }
            else
            {
                lblUserName.Text = "No user found in the database.";
                lblUserName.ForeColor = Color.Red;
            }
        }

        private void dgvRentedBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the click was on a row, not the column header
            {
                dgvRentedBook.CurrentCell = dgvRentedBook.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvRentedBook.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ckbLostBook_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLostBook.Checked)
            {
                if (dgvRentedBook.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Lost the book? Then system will calculate the fine to be paid for the lost book.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // perform the task and get the result
                        //string taskResult = DoTask();

                        // update the textbox with the result
                        //ckbLostBook.Text = taskResult;
                        DataGridViewRow selectedRow = dgvRentedBook.SelectedRows[0];
                        
                        DataGridViewCell cell = selectedRow.Cells["gcPrice"];
                        if (cell != null && cell.Value != null)
                        {
                            decimal value;
                            if (decimal.TryParse(cell.Value.ToString(), out value))
                            {
                                txtFineAmount.Text = (value * 1.5m).ToString();
                                ckbLostBook.Enabled = false;
                            }
                            else
                            {
                                // handle error
                            }
                        }
                    }
                    else
                    {
                        // uncheck the checkbox
                        ckbLostBook.Checked = false;
                    }
                }
                else
                {
                    // No selected row exists
                    // show error message or perform alternative action
                    MessageBox.Show("Select a row", "OK");
                    ckbLostBook.Checked = false;
                }
            }
        }

        private void UCReturnBook_Load(object sender, EventArgs e)
        {
            ckbLostBook.Enabled = (dgvRentedBook.RowCount > 0);
        }

        private void dgvRentedBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRentedBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRentedBook.SelectedRows[0];
                ckbLostBook.Enabled = true;
                ckbLostBook.Checked = false;
                txtFineAmount.Clear();
                // Do something with the selected row
            }
        }
    }
}
