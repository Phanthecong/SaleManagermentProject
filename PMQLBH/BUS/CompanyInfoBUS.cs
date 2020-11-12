using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    class CompanyInfoBUS
    {
        CompanyInfoDAO companyInfo = new CompanyInfoDAO(); 
        public CompanyInfo LoadInfo()
        {
            return companyInfo.LoadInfo();
        }

        public int UpdateInfo(CompanyInfo company)
        {
            return companyInfo.UpdateInfo(company);
        }
    }
}
