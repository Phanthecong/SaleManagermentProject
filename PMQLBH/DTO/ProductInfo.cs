using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class ProductInfo
    {
        private int _productID;
        private string _name;
        private string _description;
        private string _image;
        private int _quantity;
        private int _unitID;
        private float _price;
        private string _code;
        private int _supplierID;
        private int _warehouseID;

        public int ProductID { get => _productID; set => _productID = value; }
     
        public string Description { get => _description; set => _description = value; }
        public string Image { get => _image; set => _image = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int UnitID { get => _unitID; set => _unitID = value; }
        public float Price { get => _price; set => _price = value; }
        public string Code { get => _code; set => _code = value; }
        public int SupplierID { get => _supplierID; set => _supplierID = value; }
        public int WarehouseID { get => _warehouseID; set => _warehouseID = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
