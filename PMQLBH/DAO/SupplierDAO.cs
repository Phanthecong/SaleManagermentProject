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
    public class SupplierDAO
    {
        DB dB = new DB();

        public DataTable LoadAllData()
        {
            string sqlStr = string.Format("SELECT * FROM Supplier");
            return dB.getData(sqlStr);
        }

        public SupplierInfo LoadInfo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Supplier WHERE SupplierID = {0}", id);
            DataTable dt = dB.getData(sqlStr);
            SupplierInfo supplierInfo = new SupplierInfo
            {
                SupplierID = int.Parse(dt.Rows[0]["SupplierID"].ToString()),
                SupplierName = dt.Rows[0]["Name"].ToString(),
                Contact = dt.Rows[0]["Contact"].ToString(),
                Address = dt.Rows[0]["Address"].ToString(),
                PhoneNumber = dt.Rows[0]["Phonenumber"].ToString(),
                Fax = dt.Rows[0]["Fax"].ToString(),
                Position = dt.Rows[0]["Position"].ToString(),
                
            };
            return supplierInfo;
        }

        public int AddNewSupplier(SupplierInfo supplierInfo)
        {
            string strSQL = "INSERT INTO Supplier VALUES(@Name, @Contact, @Address, @Phonenumber, @Fax, @Position)";
            int nRow = 0;
            try
            {
                nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@Name", Value = supplierInfo.SupplierName },
                new SqlParameter { ParameterName = "@Contact", Value = supplierInfo.Contact },
                new SqlParameter { ParameterName = "@Address", Value = supplierInfo.Address },
                new SqlParameter { ParameterName = "@Phonenumber", Value = supplierInfo.PhoneNumber },
                new SqlParameter { ParameterName = "@Fax", Value = supplierInfo.Fax },
                new SqlParameter { ParameterName = "@Position", Value = supplierInfo.Position }
        
                );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return nRow;
        }

        public int DeleteSupplier(int id)
        {
            string strSQL = "DELETE FROM Supplier WHERE SupplierID = @id";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.Text, strSQL,
                new SqlParameter { ParameterName = "@id", Value = id });
            return nRow;
        }

        public int UpdateSupplier(SupplierInfo supplierInfo)
        {
            string strSQL = "UpdateSupplier";
            int nRow = 0;
            nRow = dB.ExecuteNonQuery(CommandType.StoredProcedure, strSQL,
                new SqlParameter { ParameterName = "@SupplierID", Value = supplierInfo.SupplierID },
                new SqlParameter { ParameterName = "@Name", Value = supplierInfo.SupplierName },
                new SqlParameter { ParameterName = "@Contact", Value = supplierInfo.Contact },
                new SqlParameter { ParameterName = "@Address", Value = supplierInfo.Address },
                new SqlParameter { ParameterName = "@Phonenumber", Value = supplierInfo.PhoneNumber },
                new SqlParameter { ParameterName = "@Fax", Value = supplierInfo.Fax },
                new SqlParameter { ParameterName = "@Position", Value = supplierInfo.Position }
                );
            return nRow;
        }
    }
}
