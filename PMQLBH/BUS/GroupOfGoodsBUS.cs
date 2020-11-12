using PMQLBH.DAO;
using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.BUS
{
    public class GroupOfGoodsBUS
    {
        GroupOfGoodsDAO groupOfGoodsDAO = new GroupOfGoodsDAO();

        public DataTable LoadAllData()
        {
            return groupOfGoodsDAO.LoadAllData();
        }

        public int UpdateGroupOfGoods(GroupOfGoodsInfo groupOfGoodsInfo)
        {
            return groupOfGoodsDAO.UpdateGroupOfGoods(groupOfGoodsInfo);
        }

        public int DeleteGroupOfGoods(int id)
        {
            return groupOfGoodsDAO.DeleteGroupOfGoods(id);
        }

        public int AddNewGroupOfGoods(GroupOfGoodsInfo groupOfGoodsInfo)
        {
            return groupOfGoodsDAO.AddNewGroupOfGoods(groupOfGoodsInfo);
        }

        public GroupOfGoodsInfo LoadInfo(int id)
        {
            return groupOfGoodsDAO.LoadInfo(id);
        }
    }
}
