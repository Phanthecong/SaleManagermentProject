using PMQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class EmployeeBUS
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();

        public DataTable LoadAllData()
        {
            return employeeDAO.LoadAllData();
        }
    }
}
