using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    public class WarehouseDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Warehouse");
            return dB.getData(sqlStr);
        }
        public int Add(WarehouseInfo p)
        {
            string sql = string.Format("INSERT INTO Warehouse (ManagementStaff,Name,Contact,Address,Status,Note) VALUES ('{0}','{1}','{2}','{3}','{4}', '{5}')", p.ManagermentStaff, p.Name, p.Contact, p.Address, p.Status, p.Note);
            return dB.ExecuteNonQuery(CommandType.Text, sql);
        }
    }
}
