using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class Phong
    {
        private string MaPhong;
        private string TenPhong;
        private string LoaiPhong;
        private bool TrangThai;
        private float GiaPhong;
        private string HinhAnh;
        public Phong()
        {
            MaPhong = "";
            TenPhong = "";
            LoaiPhong = "";
            TrangThai = false;
            GiaPhong = 0;
            HinhAnh = "";
        }
        public Phong(string ma,string ten,string loai,bool tt, float gia,string ha)
        {
            MaPhong = ma;
            TenPhong = ten;
            LoaiPhong = loai;
            TrangThai = tt;
            GiaPhong = gia;
            HinhAnh = ha;
        }
        public string maphong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        public string tenphong
        {
            get { return TenPhong; }
            set { TenPhong = value; }
        }
        public string loaiphong
        {
            get { return LoaiPhong; }
            set { LoaiPhong = value; }
        }
        public bool trangthai
        {
            get { return TrangThai; }
            set { TrangThai = value; }
        }
        public float giaphong
        {
            get { return GiaPhong; }
            set { GiaPhong = value; }
        }
        public string hinhanh
        {
            get { return HinhAnh; }
            set { HinhAnh = value; }
        }

    }
}