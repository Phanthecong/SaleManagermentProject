using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{

    public class UserDAO
    {
        DB db = new DB();

        public UserInfo login(string userName, string passWord)
        {
            string sqlStr = string.Format("SELECT * FROM Users WHERE Username = '{0}' AND Password = '{1}'", userName, passWord);
            DataTable dt = db.getData(sqlStr);
            UserInfo user = null;
            if (dt.Rows.Count > 0)
            {
                user = new UserInfo()
                {
                    UserName = dt.Rows[0]["Username"].ToString(),
                    Password = dt.Rows[0]["Password"].ToString(),
                    RoleId = int.Parse(dt.Rows[0]["RoleId"].ToString())
                };
                return user;
            }
            
            return user;
        }

        public UserInfo LoadPass()
        {
            string strSQL = "Select * from Users";
            DataTable dataTable = db.getData(strSQL);
            UserInfo userInfo = new UserInfo()
            {
                UserName = dataTable.Rows[0]["Username"].ToString(),
                Password = dataTable.Rows[0]["Password"].ToString()
            };
            return userInfo;
        }

        public int ChangePassword(UserInfo userInfo)
        {
            string strSQL = "ChangePassword";
            int nRow = 0;
            try
            {
                nRow = db.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@Username", Value = userInfo.UserName },
                    new SqlParameter { ParameterName = "@Password", Value = userInfo.Password });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }
    }
}
