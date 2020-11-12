using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    public class EmployeeDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Employee");
            return dB.getData(sqlStr);
        }
    }
}
