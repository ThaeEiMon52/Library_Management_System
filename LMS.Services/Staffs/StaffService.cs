using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Staff;
using LMS.DAO.Users;
using LMS.Entities.Staff;

namespace LMS.Services.Staff
{

    public class StaffService
    {
        //define the Staff Dao


        private StaffDao staffDao = new StaffDao();


        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="ID">.</param>
        /// <returns>.</returns>

        public DataTable GetAll()
        {
            DataTable dt = staffDao.GetAll();
            return dt;
        }

        //  #endregion

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="ID">.</param>
        /// <returns>.</returns>
        public DataTable Get(int ID)
        {
            DataTable dt = staffDao.Get(ID);
            return dt;
        }


        /// <summary>
        /// Select data from staff
        /// </summary>
        /// <param name="staffEntity">.</param>

        //public bool Select(StaffEntity staffEntity)
        //{
        //    return staffDao.Select(staffEntity);
        //}



        /// <summary>
        /// Save course
        /// </summary>
        /// <param name="staffEntity">.</param>

        public bool Insert(StaffEntity staffEntity)
        {
            return staffDao.Insert(staffEntity);
        }

        /// <summary>
        /// Update Course
        /// </summary>
        /// <param name="staffEntity">.</param>
        public bool Update(StaffEntity staffEntity)
        {
            return staffDao.Update(staffEntity);
        }

        /// <summary>
        /// Delete Course
        /// </summary>
        /// <param name="ID">.</param>
        public bool Delete(int ID)
        {
            return staffDao.Delete(ID);
        }

        /// <summary>
        /// Delete Course
        /// </summary>
        /// <param name="search">.</param>
        public DataTable Search(string search)
        {
            DataTable dt = staffDao.Search(search);
            return dt;
        }

    }
}
