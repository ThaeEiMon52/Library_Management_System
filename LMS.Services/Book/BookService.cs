using System;
using System.Collections.Generic;
using System.Data;
using LMS.DAO.Book;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Book;
using LMS.Entities.Book;

namespace LMS.Services.Book
{
    public class BookService
    {
        private BookDao bookDao = new BookDao();

        public DataTable GetAll()
        {
            DataTable dt = bookDao.GetAll();
            return dt;
        }
        public DataTable GetAll1()
        {
            DataTable dt = bookDao.GetAll1();
            return dt;
        }
        public DataTable Get(int id)
        {
            DataTable dt = bookDao.Get(id);
            return dt;
        }
        public DataTable Get1(int id)
        {
            DataTable dt = bookDao.Get1(id);
            return dt;
        }

        public bool Insert(BookEntity bookEntity)
        {
            return bookDao.Insert(bookEntity);
        }

        public bool Update(BookEntity bookEntity)
        {
            return bookDao.Update(bookEntity);
        }
        public bool Delete(int id)
        {
            return bookDao.Delete(id);
        }

        public DataTable GetRentedBookByUserId(int userId)
        {
            return bookDao.GetRentedBookByUserId(userId);
        }

        public DataTable GetBookTitleAndAvailability(int bookId)
        {
            return bookDao.GetBookTitleAndAvailability(bookId);
        }

        public bool BookExists(int bookId)
        {
            int bookCount = (int)bookDao.BookExists(bookId);
            if (bookCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
