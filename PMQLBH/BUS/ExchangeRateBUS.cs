using PMQLBH.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class ExchangeRateBUS
    {
        ExchangeRateDAO exchangeRateDAO = new ExchangeRateDAO();

        public DataTable LoadAllData()
        {
            return exchangeRateDAO.LoadAllData();
        }
    }
}
