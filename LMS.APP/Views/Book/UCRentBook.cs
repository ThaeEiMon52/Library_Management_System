using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Services.Book;
using LMS.Services.User;
using LMS.Services.BookRental;
using LMS.Entities.BookRental;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace LMS.APP.Views.Book
{
    public partial class UCRentBook : UserControl
    {
        int bookId, userId;
        BookService bookService = new BookService();
        BookRentalService bookRentalService = new BookRentalService();
        UserServiceBook userService = new UserServiceBook();
        public UCRentBook()
        {
            InitializeComponent();
            dtpDueDate.Value = DateTime.Today.AddDays(7);
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            //int bookId;

            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please enter a book ID.");
                txtBookID.Focus();
                return;
            }

            if (!int.TryParse(txtBookID.Text, out bookId))
            {
                MessageBox.Show("Please enter a valid book ID (numeric value).");
                txtBookID.Focus();
                return;
            }

            DataTable dt = bookService.GetBookTitleAndAvailability(bookId);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string bookTitle = (string)row["book_title"]; 
                string availability = (string)row["availability"];

                string labelFormat = "{0} - {1}";
                lblBookTitle.Text = string.Format(labelFormat, bookTitle, availability);
                lblBookTitle.ForeColor = Color.SeaGreen;
            }else
            {
                lblBookTitle.Text = "No book found in the database.";
                lblBookTitle.ForeColor = Color.Red;
            }
        }


        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            //int userId;

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

            // Get the user id input from the TextBox control
            //int userId = int.Parse(txtUserID.Text);
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
                dgvRentedBook.Columns["price"].Visible = false;
                dgvRentedBook.Columns["call_number"].Visible = false;
                dgvRentedBook.Columns["rental_id"].Visible = false;
            }
            else
            {
                lblUserName.Text = "No user found in the database.";
                lblUserName.ForeColor = Color.Red;
            }
        }

        
        private void btnRentBook_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
            {
                return;
            }

            InsertBookRentalEntity bookRentalEntity = CreateData();

            bool success = bookRentalService.InsertBookRental(bookRentalEntity);
            if (success)
            {
                MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);

                dgvRentedBook.DataSource = bookService.GetRentedBookByUserId(userId);
                dgvRentedBook.Columns["price"].Visible = false;
                dgvRentedBook.Columns["call_number"].Visible = false;
                dgvRentedBook.Columns["rental_id"].Visible = false;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private InsertBookRentalEntity CreateData()
        {
            InsertBookRentalEntity bookRentalEntity = new InsertBookRentalEntity();
            bookRentalEntity.userId = Convert.ToInt32(txtUserID.Text);
            bookRentalEntity.bookId = Convert.ToInt32(txtBookID.Text);
            bookRentalEntity.staffIssueId = Convert.ToInt32("11");
            bookRentalEntity.issueDate = Convert.ToDateTime(dtpRentDate.Text);
            bookRentalEntity.dueDate = Convert.ToDateTime(dtpDueDate.Text);

            return bookRentalEntity;
        }

        private void dgvRentedBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime cellDate = Convert.ToDateTime(dgvRentedBook.Rows[e.RowIndex].Cells["gcDueDate"].Value);
            if (cellDate < DateTime.Today)
            {
                dgvRentedBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }
            else
            {
                dgvRentedBook.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrEmpty(txtBookID.Text))
            {
                MessageBox.Show("Book ID cannot be empty.");
                txtBookID.Focus();
                return false;
            }

            int bookId;
            if (!int.TryParse(txtBookID.Text, out bookId))
            {
                MessageBox.Show("Book ID must be a number.");
                txtBookID.Focus();
                return false;
            }


            // Check if book with the given ID exists in the database
            if (!bookService.BookExists(bookId))
            {
                MessageBox.Show("Book with the given ID does not exist.");
                txtBookID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("User ID cannot be empty.");
                txtUserID.Focus();
                return false;
            }

            int userId;
            if (!int.TryParse(txtUserID.Text, out userId))
            {
                MessageBox.Show("User ID must be a number.");
                txtUserID.Focus();
                return false;
            }

            // Check if user with the given ID exists in the database
            if (!userService.UserExists(userId))
            {
                MessageBox.Show("User with the given ID does not exist.");
                txtUserID.Focus();
                return false;
            }

            // Check if user is already renting the same book
            if (bookRentalService.CheckUserRentingSameBook(userId, bookId))
            {
                MessageBox.Show("User is already renting the same book.");
                txtBookID.Focus();
                return false;
            }

            // Check if user is exceeding renting limit
            if (bookRentalService.CheckCurrentRentingBookNumber(userId))
            {
                MessageBox.Show("User is not allowed to rent more than three books. Exceeding the limit.");
                return false;
            }

            // Check if rent date is less than today date
            if (dtpRentDate.Value < DateTime.Today)
            {
                MessageBox.Show("Rent date must be greater than or equal to today's date.");
                return false;
            }

            // Check if due date is no more than 2 weeks
            if (dtpDueDate.Value > DateTime.Today.AddDays(14))
            {
                MessageBox.Show("Due date cannot be more than 2 weeks from today's date.");
                return false;
            }

            return true;
        }

        private void UCRentBook_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtUserID.Clear();
            dtpRentDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
        }
    }
}
