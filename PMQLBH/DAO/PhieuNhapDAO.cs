using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DAO
{
    public class PhieuNhapDAO
    {
        DB dB = new DB();
        public int LuuPhieuNhap(PhieuNhapDTO p)
        {
            string sql = string.Format("INSERT INTO PhieuNhap VALUES('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", p.MaPN, p.NCC, p.KhoXuat, p.Ngay, p.NgayGiao, p.HanThanhToan, p.GhiChu, p.TongTien);
            return dB.ExecuteNonQuery(System.Data.CommandType.Text, sql);
        }

        public int LuuCTPhieuNhap(CT_PhieuNhap p)
        {
            string sql = string.Format("INSERT INTO CT_PN VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", p.MaPN, p.STT, p.TenHang, p.DonGia, p.SoLuong, p.DonGia, p.ThanhTien);
            return dB.ExecuteNonQuery(System.Data.CommandType.Text, sql);
        }
    }
}
