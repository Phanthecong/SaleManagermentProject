using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.GUI
{
    public class EmpolyeeInfo
    {
        private int _employeeID;
        private int _userID;
        private string _employeeName;
        private string _adress;
        private string _phoneNumber;
        private string _email;

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public int UserID { get => _userID; set => _userID = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
