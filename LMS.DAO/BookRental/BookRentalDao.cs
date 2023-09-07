using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using LMS.DAO.Common;
using LMS.Entities.BookRental;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace LMS.DAO.BookRental
{
    public class BookRentalDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql;

        public object CheckUserRentingSameBook(int userId, int bookId)
        {
            strSql = "SELECT COUNT(*) FROM rental_histories WHERE book_id = @bookId AND user_id = @userId";

            SqlParameter[] sqlParams = { new SqlParameter("@bookId", bookId), new SqlParameter("@userId", userId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }

        public object CheckCurrentRentingBookNumber(int userId)
        {
            strSql = "SELECT COUNT(*) FROM rental_histories WHERE  user_id = @userId AND status = 'B'";

            SqlParameter[] sqlParams = { new SqlParameter("@userId", userId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }

        public bool InsertBookRental(InsertBookRentalEntity bookRentalEntity)
        {
            strSql = "INSERT INTO rental_histories(user_id, book_id, staff_issue_id , issue_date , due_date)" +
                     "VALUES(@userId, @bookId, @staffIssueId, @issueDate, @dueDate)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@userId", bookRentalEntity.userId),
                                        new SqlParameter("@bookId", bookRentalEntity.bookId),
                                        new SqlParameter("@staffIssueId", bookRentalEntity.staffIssueId),
                                        new SqlParameter("@issueDate", bookRentalEntity.issueDate),
                                        new SqlParameter("@dueDate", bookRentalEntity.dueDate)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public bool DeleteRentalHistory(int rentalId)
        {
            strSql = "DELETE FROM rental_histories WHERE rental_id = @rentalId";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@rentalId", rentalId)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        public DataTable GetRentalHistory(char filterBy)
        {
            strSql = "SELECT u.name AS user_name, u.nrc, u.email, u.phone, u.address, " +
         "b.title, b.author, rh.issue_date, rh.due_date, " +
         "si.name AS staff_issue_name, rh.return_date, CASE rh.status WHEN 'L' THEN 'Lost' WHEN 'B' THEN 'Rented' WHEN 'R' THEN 'Returned' ELSE rh.status END AS status_display, rh.rental_id, rh.fine_amount, " +
         "sr.name AS staff_receive_name " +
         "FROM rental_histories rh " +
         "JOIN users u ON rh.user_id = u.user_id " +
         "JOIN books b ON rh.book_id = b.book_id " +
         "JOIN staffs si ON rh.staff_issue_id = si.staff_id " +
         "LEFT JOIN staffs sr ON rh.staff_receive_id = sr.staff_id ";

            if (filterBy != 'A')
            {
                strSql += " WHERE rh.status = '" + filterBy + "'";
            }
            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        public DataTable SearchRentalHistory(string searchColumn, char filterBy, string searchTerm)
        {
            
                strSql = "SELECT u.name AS user_name, u.nrc, u.email, u.phone, u.address, " +
         "b.title, b.author, rh.issue_date, rh.due_date, " +
         "si.name AS staff_issue_name, rh.return_date, CASE rh.status WHEN 'L' THEN 'Lost' WHEN 'B' THEN 'Rented' WHEN 'R' THEN 'Returned' ELSE rh.status END AS status_display, rh.rental_id, rh.fine_amount, " +
         "sr.name AS staff_receive_name " +
         "FROM rental_histories rh " +
         "JOIN users u ON rh.user_id = u.user_id " +
         "JOIN books b ON rh.book_id = b.book_id " +
         "JOIN staffs si ON rh.staff_issue_id = si.staff_id " +
         "LEFT JOIN staffs sr ON rh.staff_receive_id = sr.staff_id " +
         "WHERE " + searchColumn + " = '" + searchTerm + "'";

            if (filterBy != 'A')
            {
                strSql += " AND rh.status = '" + filterBy + "'";
            }



            return connection.ExecuteDataTable(CommandType.Text, strSql);

        }
    }
}
