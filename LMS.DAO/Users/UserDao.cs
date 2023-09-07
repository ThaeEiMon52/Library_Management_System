using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Common;
using LMS.Entities.Users;

namespace LMS.DAO.Users
{
    /// <summary>
    /// Defines the <see cref="UserDao" />.
    /// </summary>
    public class UserDao
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

        #region==========User========== 

        /// <summary>
        /// Get All
        /// </summary>
        public DataTable GetAll()
        {
            strSql = "SELECT * FROM users";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Get(int id)
        {
            strSql = "SELECT * FROM users " +
                      "WHERE  user_id= " + id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }






        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="userentity">.</param>
        public bool Insert(UserEntity userentity)
        {
            strSql = "INSERT INTO users(name,nrc,phone,email,gender,address)" +
                     "VALUES(@uname,@unrc,@uphone,@uemail,@ugender,@uaddresss)";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@uname", userentity.UserName),
                                         new SqlParameter("@unrc", userentity.UserNRC),
                                        new SqlParameter("@uphone", userentity.UserPhone),
                                        new SqlParameter("@uemail", userentity.UserEmail),
                                        new SqlParameter("@ugender", userentity.UserGender),
                                        new SqlParameter("@uaddresss", userentity.UserAddress)

                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }

        /// <summary>
        /// Create User
        /// </summary>
        /// <param name="userentity">.</param>
        public bool Update(UserEntity userentity)
        {
            strSql = "UPDATE users SET name=@uname,nrc=@unrc,phone=@uphone,email=@uemail,gender=@ugender,address=@uaddresss WHERE user_id = @uid";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@uid", userentity.UserID),
                                       new SqlParameter("@uname", userentity.UserName),
                                        new SqlParameter("@unrc", userentity.UserNRC),
                                        new SqlParameter("@uphone", userentity.UserPhone),
                                        new SqlParameter("@uemail", userentity.UserEmail),
                                        new SqlParameter("@ugender", userentity.UserGender),
                                        new SqlParameter("@uaddresss", userentity.UserAddress)
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
            strSql = "DELETE FROM users WHERE user_id = @uid";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@uid", id)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param string="search"></param>
        /// <returns></returns>
        public DataTable Search(string search)
        {
            strSql = "SELECT user_id,name,nrc,phone,email,address,gender FROM users WHERE CONCAT( user_id , name , nrc, phone ,email ,address ,gender ) LIKE '%" + search + "%'";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }
        #endregion


    }
}
