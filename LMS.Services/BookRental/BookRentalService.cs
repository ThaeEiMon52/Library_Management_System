using LMS.DAO.BookRental;
using LMS.Entities.BookRental;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.BookRental
{
    public class BookRentalService
    {
        private BookRentalDao bookRentalDao = new BookRentalDao();

        public bool CheckUserRentingSameBook(int userId, int bookId)
        {
            int rowCount = (int)bookRentalDao.CheckUserRentingSameBook(userId, bookId);
            if(rowCount > 0 )
            {
                return true;
            }else { return false; }
        }

        public bool CheckCurrentRentingBookNumber(int userId)
        {
            int rowCount = (int)bookRentalDao.CheckCurrentRentingBookNumber(userId);
            if (rowCount > 3)
            {
                return true;
            }
            else { return false; }
        }

        public bool InsertBookRental(InsertBookRentalEntity bookRentalEntity)
        {
            return bookRentalDao.InsertBookRental(bookRentalEntity);
        }

        public bool DeleteRentalHistory(int rentalId)
        {
            return bookRentalDao.DeleteRentalHistory(rentalId);
        }

        public DataTable GetRentalHistory(char filterBy)
        {
            DataTable dt = new DataTable();
            return dt = bookRentalDao.GetRentalHistory(filterBy);
        }

        public DataTable SearchRentalHistory(string searchColumn, char filterBy, string searchTerm)
        {
            DataTable dt = new DataTable();
            return dt = bookRentalDao.SearchRentalHistory(searchColumn, filterBy, searchTerm);
        }
    }
}
