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
    class CompanyInfoDAO
    {
        DB dB = new DB();

        public CompanyInfo LoadInfo()
        {
            string sqlStr = string.Format("SELECT * FROM Company");
            DataTable dt = dB.getData(sqlStr);
            CompanyInfo company = new CompanyInfo()
            {
                CompanyID = int.Parse(dt.Rows[0]["CompanyID"].ToString()),
                CompanyName = dt.Rows[0]["CompanyName"].ToString(),
                Address = dt.Rows[0]["Address"].ToString(),
                PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString(),
                Fax = dt.Rows[0]["Fax"].ToString(),
                Website = dt.Rows[0]["Website"].ToString(),
                Email = dt.Rows[0]["Email"].ToString(),
                FiledID = int.Parse(dt.Rows[0]["FieldID"].ToString()),
                Tax = dt.Rows[0]["Tax"].ToString(),
                GPKD = dt.Rows[0]["GPKD"].ToString()
            };
            return company;
        }

        public int UpdateInfo(CompanyInfo company)
        {
            string strSQL = "Info_Update";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@CompanyID", Value = company.CompanyID },
                    new SqlParameter { ParameterName = "@CompanyName", Value = company.CompanyName },
                    new SqlParameter { ParameterName = "@Address", Value = company.Address },
                    new SqlParameter { ParameterName = "@PhoneNumber", Value = company.PhoneNumber },
                    new SqlParameter { ParameterName = "@Fax", Value = company.Fax },
                    new SqlParameter { ParameterName = "@Website", Value = company.Website },
                    new SqlParameter { ParameterName = "@Email", Value = company.Email },
                    new SqlParameter { ParameterName = "@FieldID", Value = company.FiledID },
                    new SqlParameter { ParameterName = "@Tax", Value = company.Tax },
                    new SqlParameter { ParameterName = "@GPKD", Value = company.GPKD }
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }
    }
}
