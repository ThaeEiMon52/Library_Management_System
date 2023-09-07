using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Users;
using LMS.Entities.Users;


namespace LMS.Services.User
{
    /// <summary>
    /// Defines the <see cref="UserService" />.
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Define user Dao..
        /// </summary>
        private UserDao userDao = new UserDao();


        #region==========User========== 
        /// <summary>
        /// Get All.
        /// </summary>
        public DataTable GetAll()
        {
            DataTable dt = userDao.GetAll();
            return dt;
        }
        #endregion

        /// <summary>
        /// Get.
        /// </summary>
        /// <param name="id">.</param>
        /// <returns>.</returns>
        public DataTable Get(int id)
        {
            DataTable dt = userDao.Get(id);
            return dt;
        }


        /// <summary>
        /// Save user.
        /// </summary>
        /// <param name="userEntity">.</param>
        public bool Insert(UserEntity userEntity)
        {
            return userDao.Insert(userEntity);

        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="userEntity">.</param>
        public bool Update(UserEntity userEntity)
        {
            return userDao.Update(userEntity);
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">.</param>
        public bool Delete(int id)
        {
            return userDao.Delete(id);
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <param string="search"></param>
        /// <returns></returns>
        public DataTable Search(string search)
        {
            DataTable dt = userDao.Search(search);
            return dt;
        }
    }
}