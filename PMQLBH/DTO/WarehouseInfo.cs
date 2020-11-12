using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class WarehouseInfo
    {
        private int _warehouseID;
        private int _managermentStaff;
        private string _name;
        private string _contact;
        private string _address;
        private string _status;
        private string _note;

        public int WarehouseID { get => _warehouseID; set => _warehouseID = value; }
        public int ManagermentStaff { get => _managermentStaff; set => _managermentStaff = value; }
        public string Name { get => _name; set => _name = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Status { get => _status; set => _status = value; }
        public string Note { get => _note; set => _note = value; }
        public string Address { get => _address; set => _address = value; }
    }
}
