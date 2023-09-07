using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LMS.DAO.Common;
using LMS.Entities.Staff;


namespace LMS.DAO.Staff
{
    /// <summary>
    /// Defines the <see cref="ProductDao" />.
    /// </summary>
    public class StaffDao
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


        /// <summary>
        /// Get All
        /// </summary>

        public DataTable GetAll()
        {
            strSql = "SELECT * FROM staffs ";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        public DataTable Get(int ID)
        {
            strSql = "SELECT * FROM staffs " +
                      "WHERE  staff_id= " + ID;

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }

  


        /// <summary>
        /// Create staff  
        /// </summary>
        /// <param name="StaffEntity">.</param>

        public bool Insert(StaffEntity staffEntity)
        {
            staffEntity.role = 0;
            strSql = "INSERT INTO staffs " +
                    "(name,email,password,phone,gender,address,role)" +
                     "VALUES('" + staffEntity.name + "','" + staffEntity.email + "','" + staffEntity.password + "','" + staffEntity.phone + "','" + staffEntity.gender + "','" + staffEntity.address + "','" + staffEntity.role+ "')";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@name", staffEntity.name),
                                        new SqlParameter("@email", staffEntity.email),
                                        new SqlParameter("@password", staffEntity.password),
                                        new SqlParameter("@phone", staffEntity.phone),
                                        new SqlParameter("@gender", staffEntity.gender),
                                        new SqlParameter("@address", staffEntity.address)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }


        public bool Update(StaffEntity staffEntity)
        {
            strSql = "UPDATE staffs SET name=@name," +
                      "password=@password,phone=@phone, email=@email,address=@address, gender=@gender WHERE staff_id = @staff_id";

            SqlParameter[] sqlParam = {
                                        new SqlParameter("@staff_id",staffEntity.staff_id),
                                        new SqlParameter("@name", staffEntity.name),
                                       // new SqlParameter("@photo", staffEntity.photo),
                                        new SqlParameter("@password", staffEntity.password),
                                        new SqlParameter("@phone", staffEntity.phone),
                                        new SqlParameter("@email", staffEntity.email),
                                        new SqlParameter("@address", staffEntity.address),
                                        new SqlParameter("@gender", staffEntity.gender),
                                  //      new SqlParameter("@role", staffEntity.role)

                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);

            return success;
        }


        /// <summary>
        /// Delete.
        /// </summary>
        /// <param name="staff_id">.</param>

        public bool Delete(int ID)
        {
            strSql = "DELETE FROM staffs WHERE staff_id= @staff_id";
            SqlParameter[] sqlParam = {
                                        new SqlParameter("@staff_id",ID)
                                      };
            bool success = connection.ExecuteNonQuery(CommandType.Text, strSql, sqlParam);
            return success;
        }

        public DataTable Search(string search)
        {
            strSql = "SELECT staff_id,name,phone,email,address,gender FROM staffs WHERE CONCAT( staff_id , name , phone ,email ,address ,gender ) LIKE '%" + search + "%'";

            return connection.ExecuteDataTable(CommandType.Text, strSql);
        }


    }




}

