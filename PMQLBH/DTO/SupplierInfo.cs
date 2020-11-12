using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class SupplierInfo
    {
        private int _supplierID;
        private string _supplierName;
        private string _contact;
        private string _address;
        private string _phoneNumber;
        private string _fax;
        private string _position;
        private int _areaID;
        private int _code;

        public int SupplierID { get => _supplierID; set => _supplierID = value; }
        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Address { get => _address; set => _address = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string Position { get => _position; set => _position = value; }
        public int AreaID { get => _areaID; set => _areaID = value; }
        public int Code { get => _code; set => _code = value; }
    }
}
