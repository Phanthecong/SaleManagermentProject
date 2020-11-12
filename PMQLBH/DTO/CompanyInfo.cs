using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    class CompanyInfo
    {
        int _companyID;
        string _companyName;
        string _address;
        string _phoneNumber;
        string _fax;
        string _website;
        string _email;
        int _filedID;
        string _tax;
        string _gPKD;

        
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string Address { get => _address; set => _address = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string Website { get => _website; set => _website = value; }
        public string Email { get => _email; set => _email = value; }
        public int FiledID { get => _filedID; set => _filedID = value; }
        public string Tax { get => _tax; set => _tax = value; }
        public string GPKD { get => _gPKD; set => _gPKD = value; }
        public int CompanyID { get => _companyID; set => _companyID = value; }
    }
}
