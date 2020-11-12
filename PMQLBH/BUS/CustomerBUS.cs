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
    public class CustomerBUS
    {
        CustomerDAO customerDAO = new CustomerDAO();

        public DataTable LoadAllData()
        {
            return customerDAO.LoadAllData();
        }

        public int AddNewCustomer(CustomerInfo customerInfo)
        {
            return customerDAO.AddNewCustomer(customerInfo);
        }

        public CustomerInfo LoadInfo(int id)
        {
            return customerDAO.LoadInfo(id);
        }

        public int DeleteCustomer(int id)
        {
            return customerDAO.DeleteCustomer(id);
        }

        public int UpdateCustomer(CustomerInfo customerInfo)
        {
            return customerDAO.UpdateCustomer(customerInfo);
        }
    }
}
