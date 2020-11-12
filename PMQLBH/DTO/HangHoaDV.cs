using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    class HangHoaDV
    {
        private string gOGName;
        private string companyName;
        private string name;
        private int warehouseID;
        private int productID;
        private int gOGID;
        private string note;
        public string GOGName { get => gOGName; set => gOGName = value; }
        public string CompanyID { get => companyName; set => companyName = value; }
        public string Name { get => name; set => name = value; }
        public int WarehouseID { get => warehouseID; set => warehouseID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int GOGID { get => gOGID; set => gOGID = value; }
        public string Note { get => note; set => note = value; }
    }
}
