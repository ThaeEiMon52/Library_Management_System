using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using LMS.DAO.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAO.User
{
    public class UserDao
    {
        private DbConnection connection = new DbConnection();

        private string strSql;

        public DataTable GetUserNameAndNRC(int userId)
        {
            strSql = "SELECT name, nrc FROM users WHERE  user_id = " + userId;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        public object UserExists(int userId)
        {
            strSql = "SELECT COUNT(*) FROM users WHERE user_id = @userId;";

            SqlParameter[] sqlParams = { new SqlParameter("@userId", userId) };

            return connection.ExecuteScalar(CommandType.Text, strSql, sqlParams);
        }
        #endregion


    }
}
