using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class ChangePassword
    {
        UserDAO userDAO = new UserDAO();
        public UserInfo LoadPass()
        {
            return userDAO.LoadPass();
        }

        public int ChangePass(UserInfo userInfo)
        {
            return userDAO.ChangePassword(userInfo);
        }
    }
}
