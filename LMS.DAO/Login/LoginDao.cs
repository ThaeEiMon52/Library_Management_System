using LMS.Entities.Staff;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Common;
using LMS.Entities.Login;


namespace LMS.DAO.Login
{
    public class LoginDao
    {

        /// <summary>
        /// Defines the <see cref="ProductDao" />.
        /// </summary>

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


        /// <summary>
        /// Get All
        /// </summary>

        public DataTable Login(string email)
        {
            // Query to check if the user exists in the database
            string strSql = "SELECT staff_id, role, password FROM staffs WHERE email = '" + email +"'";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="getstaff"></param>
        /// <returns></returns>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>

        public DataTable Get(int staff_id)
        {
            strSql = "SELECT * FROM staffs" +
                      "WHERE  staff_id= " + staff_id;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

       

    

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="getuser"></param>
        /// <returns></returns>
        /// 
        //public DataTable GetUser()
        //{
        //    strSql = " SELECT email,password FROM users";

        //    return connection.ExecuteDataTable(CommandType.Text, strSql);
        //}


    }
}



