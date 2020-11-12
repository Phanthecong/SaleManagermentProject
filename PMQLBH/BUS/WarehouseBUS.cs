using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class WarehouseBUS
    {
        WarehouseDAO warehouseDAO = new WarehouseDAO();

        public DataTable LoadAllData()
        {
            return warehouseDAO.LoadAllData();
        }
        public int Add(WarehouseInfo p)
        {
            return warehouseDAO.Add(p);
        }
    }
}
