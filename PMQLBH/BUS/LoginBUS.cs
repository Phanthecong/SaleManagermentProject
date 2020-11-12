using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class LoginBUS
    {
        UserDAO userDAO = new UserDAO();
        public UserInfo login(string userName, string passWord)
        {
            return userDAO.login(userName, passWord);
        }
    }
}
