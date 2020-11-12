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
    public class SupplierBUS
    {
        SupplierDAO supplierDAO = new SupplierDAO();

        public DataTable LoadAllData()
        {
            return supplierDAO.LoadAllData();
        }

        public SupplierInfo LoadInfo(int id)
        {
            return supplierDAO.LoadInfo(id);
        }

        public int AddNewSupplier(SupplierInfo supplierInfo)
        {
            return supplierDAO.AddNewSupplier(supplierInfo);
        }

        public int DeleteSupplier(int id)
        {
            return supplierDAO.DeleteSupplier(id);
        }

        public int UpdateSupplier(SupplierInfo supplierInfo)
        {
            return supplierDAO.UpdateSupplier(supplierInfo);
        }
    }
}
