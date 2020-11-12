using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class CustomerInfo
    {
        private int _customerID;
        private string _name;
        private string _contact;
        private string _phoneNumber;
        private string _email;
        private string _fax;
        private string _tax;
        private string _address;
        private string _website;
        private string _accountNumber;
        private int _areaID;

        public int CustomerID { get => _customerID; set => _customerID = value; }
        public string Name { get => _name; set => _name = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string Tax { get => _tax; set => _tax = value; }
        public string Address { get => _address; set => _address = value; }
        public string Website { get => _website; set => _website = value; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public int AreaID { get => _areaID; set => _areaID = value; }
    }
}
