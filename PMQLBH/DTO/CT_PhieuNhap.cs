using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class CT_PhieuNhap
    {
        string _maPN;
        int _sTT;
        string _tenHang;
        int _donVi;
        int _soLuong;
        float _donGia;
        float _thanhTien;

        public string MaPN { get => _maPN; set => _maPN = value; }
        public int STT { get => _sTT; set => _sTT = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public int DonVi { get => _donVi; set => _donVi = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public float DonGia { get => _donGia; set => _donGia = value; }
        public float ThanhTien { get => _thanhTien; set => _thanhTien = value; }
    }
}
