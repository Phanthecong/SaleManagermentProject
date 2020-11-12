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
    public class ProductBUS
    {
        ProductDAO productDAO = new ProductDAO();

        public DataTable LoadAllData()
        {
            return productDAO.LoadAllData();
        }
        public int AddNew(ProductInfo productInfo)
        {
            return productDAO.AddNew(productInfo);
        }
        public  ProductInfo LoadInfo(int id)
        {
            return productDAO.LoadInfo(id);
        }
        public int Delete(int id)
        {
            return productDAO.Delete(id);
        }
        public int Update(ProductInfo productInfo)
        {
            return productDAO.Update(productInfo);
        }
    }
}
