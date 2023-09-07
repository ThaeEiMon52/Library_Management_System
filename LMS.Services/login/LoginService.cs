using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DAO.Login;
using LMS.Entities.Login;


namespace LMS.Services.login
{
    public class LoginService
    {
        private LoginDao loginDao = new LoginDao();


        public DataTable Login(string email)
        {
            DataTable dt = loginDao.Login(email);
            return dt;
        }



        /// <param name="loginEntity">.</param>

        
        //public DataTable GetUser()
        //{
        //    DataTable dt = loginDao.GetUser();
        //    return dt;
        //}

    }
}
