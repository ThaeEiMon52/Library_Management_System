using LMS.DAO.Book;
using LMS.DAO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.User
{
    public class UserServiceBook
    {
        private UserDao userDao = new UserDao();

        public DataTable GetUserNameAndNRC(int userId)
        {
            return userDao.GetUserNameAndNRC(userId);
        }

        public bool UserExists(int userId)
        {
            int userCount = (int)userDao.UserExists(userId);
            if (userCount > 0)
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
