using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class PhieuNhapDTO
    {
        string _maPN;
        string _nCC;
        int _khoXuat;
        string _ngay;
        string _ngayGiao;
        string _hanThanhToan;
        string _ghiChu;
        float _tongTien;

        public string MaPN { get => _maPN; set => _maPN = value; }
        public string NCC { get => _nCC; set => _nCC = value; }
        public int KhoXuat { get => _khoXuat; set => _khoXuat = value; }
        public string Ngay { get => _ngay; set => _ngay = value; }
        public string NgayGiao { get => _ngayGiao; set => _ngayGiao = value; }
        public string HanThanhToan { get => _hanThanhToan; set => _hanThanhToan = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
    }
}
