using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class UserInfo
    {
        string _userName;
        string _password;
        int _roleId;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public int RoleId { get => _roleId; set => _roleId = value; }
    }
}
