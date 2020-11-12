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
    public class CustomerDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Customer");
            return dB.getData(sqlStr);
        }

        public CustomerInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Customer WHERE CustomerID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.CustomerID = int.Parse(dt.Rows[0]["CustomerID"].ToString());
            customerInfo.Name = dt.Rows[0]["Name"].ToString();
            customerInfo.Contact = dt.Rows[0]["Contact"].ToString();
            customerInfo.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
            customerInfo.Email = dt.Rows[0]["Email"].ToString();
            customerInfo.Fax = dt.Rows[0]["Fax"].ToString();
            customerInfo.Tax = dt.Rows[0]["Tax"].ToString();
            customerInfo.Address = dt.Rows[0]["Address"].ToString();
            customerInfo.Website = dt.Rows[0]["Website"].ToString();
            customerInfo.AccountNumber = dt.Rows[0]["AccountNumber"].ToString();

            return customerInfo;
        }

        public int AddNewCustomer(CustomerInfo customerInfo)
        {
            string strSQL = "INSERT INTO Customer VALUES(@CustomerID, @Name, @Contact, @PhoneNumber, @Email, @Fax, @Tax, @Address, @Website, @AccountNumber)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,

                new SqlParameter { ParameterName = "@Name", Value = customerInfo.Name },
                new SqlParameter { ParameterName = "@Contact", Value = customerInfo.Contact },
                new SqlParameter { ParameterName = "@Phonenumber", Value = customerInfo.PhoneNumber },
                new SqlParameter { ParameterName = "@Email", Value = customerInfo.Email },
                new SqlParameter { ParameterName = "@Fax", Value = customerInfo.Fax },
                new SqlParameter { ParameterName = "@Tax", Value = customerInfo.Tax },
                new SqlParameter { ParameterName = "@Address", Value = customerInfo.Address },
                new SqlParameter { ParameterName = "@Website", Value = customerInfo.Website },
                new SqlParameter { ParameterName = "@AccountNumber", Value = customerInfo.AccountNumber }
              
                );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }

        public int DeleteCustomer(int id)
        {
            string strSQL = "DELETE FROM Customer WHERE CustomerID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }

        public int UpdateCustomer(CustomerInfo customerInfo)
        {
            string strSQL = "UpdateCustomer";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@CustomerID", Value = customerInfo.CustomerID },
                    new SqlParameter { ParameterName = "@Name", Value = customerInfo.Name },
                    new SqlParameter { ParameterName = "@Contact", Value = customerInfo.Contact },
                    new SqlParameter { ParameterName = "@PhoneNumber", Value = customerInfo.PhoneNumber },
                    new SqlParameter { ParameterName = "@Email", Value = customerInfo.Email },
                    new SqlParameter { ParameterName = "@Fax", Value = customerInfo.Fax },
                    new SqlParameter { ParameterName = "@Tax", Value = customerInfo.Tax },
                    new SqlParameter { ParameterName = "@Address", Value = customerInfo.Address },
                    new SqlParameter { ParameterName = "@Website", Value = customerInfo.Website },
                    new SqlParameter { ParameterName = "@AccountNumber", Value = customerInfo.AccountNumber }
                    
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
