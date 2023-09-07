using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using LMS.DAO.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Entities.Book;
using LMS.DAO;
using LMS.DAO.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS.DAO.Book
{
   
    public class BookDao
    {
        
        /// <summary>
        /// Defines Database Connection..
        /// </summary>
        private DbConnection connection = new DbConnection();

        /// <summary>
        /// Defines strSql..
        /// </summary>
        private string strSql = String.Empty;

        /// <summary>
        /// Defines the resultDataTable.
        /// </summary>
        private DataTable resultDataTable = new DataTable();

        /// <summary>
        /// Defines the existCount.
        /// </summary>
        private int existCount;

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM books ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public DataTable GetAll1()
        {
            strSql = "SELECT * FROM categories ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public object GetBookTitle(int bookId)
        {
            strSql = "SELECT title FROM books " + "WHERE  book_id = @bookId;";

            SqlParameter[] sqlParams = { new SqlParameter("@bookId", bookId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }

        public DataTable GetBookTitleAndAvailability(int bookId)
        {
            strSql = "SELECT b.title AS book_title, CASE WHEN SUM(CASE WHEN rh.status = 'B' THEN 1 ELSE 0 END) >= b.num_of_books THEN 'Not Available' ELSE 'Available' END AS availability FROM books b LEFT JOIN rental_histories rh ON b.book_id = rh.book_id WHERE b.book_id = " + bookId + "GROUP BY b.book_id, b.title, b.num_of_books";
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM books " +
                      "WHERE  book_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable Get1(int id)
        {
            strSql = "SELECT * FROM categories " +
                      "WHERE  category_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public object BookExists(int bookId)
        {
            strSql = "SELECT COUNT(*) FROM books " +
             "WHERE  book_id = @BookId;";

            SqlParameter[] sqlParams = { new SqlParameter("@BookId", bookId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }

        public object GetBookStatus(int bookId)
        {
            strSql = @"SELECT 
                          CASE WHEN 
                            (SELECT COUNT(*) FROM rental_histories WHERE book_id = @bookId AND return_date IS NULL) < 
                            (SELECT num_of_books FROM books WHERE book_id = @bookId) 
                            THEN 'Available' 
                            ELSE 'Unavailable' 
                          END AS is_available 
                        FROM 
                          rental_histories 
                        WHERE 
                          book_id =  @bookId;";


            SqlParameter[] sqlParams = { new SqlParameter("@bookId", bookId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }

        public DataTable GetRentedBookByUserId(int userId)
        {

            string strSql = "SELECT b.book_id, b.title, b.author, b.publisher, b.edition_number, b.price, b.call_number, b.publication_date, c.category_name, b.language, rh.issue_date AS rent_date, rh.due_date, rh.rental_id FROM rental_histories rh INNER JOIN books b ON rh.book_id = b.book_id INNER JOIN categories c ON b.category_id = c.category_id WHERE rh.user_id = '" + userId + "' AND rh.status ='" + 'B' + "'";


            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }




        public bool Insert(BookEntity bookEntity)
        {
            strSql = "INSERT INTO books(title,author,publisher,edition_number,publication_date,category_id,num_of_books,language)" +
                     "VALUES(@title,@author,@publisher,@edition_number,@publication_date,@category_id,@num_of_books,@language)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@title", bookEntity.book),
                                        new SqlParameter("@author", bookEntity.author),
                                        new SqlParameter("@publisher", bookEntity.publisher),
                                        new SqlParameter("@edition_number", bookEntity.edition),
                                        new SqlParameter("@publication_date", bookEntity.publishDate),
                                        new SqlParameter("@category_id  ", bookEntity.categoryId),
                                        new SqlParameter("@num_of_books", bookEntity.total),
                                        new SqlParameter("@language", bookEntity.language)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool Update(BookEntity bookEntity)
        {
            strSql = "UPDATE books SET title= @title,author=@author,publisher=@publisher,edition_number=@edition_number,publication_date=@publication_date,category_id=@category_id,num_of_books=@num_of_books,language=@language WHERE  book_id= @book_id";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@book_id", bookEntity.bookId),
                                        new SqlParameter("@title", bookEntity.book),
                                        new SqlParameter("@author", bookEntity.author),
                                        new SqlParameter("@publisher", bookEntity.publisher),
                                        new SqlParameter("@edition_number", bookEntity.edition),
                                        new SqlParameter("@publication_date", bookEntity.publishDate),
                                        new SqlParameter("@category_id  ", bookEntity.categoryId),
                                        new SqlParameter("@num_of_books", bookEntity.total),
                                        new SqlParameter("@language", bookEntity.language)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            strSql = "DELETE FROM books  WHERE book_id= @book_id";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@book_id", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }
    }
}
