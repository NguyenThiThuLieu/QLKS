using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class HoaDon
    {
        private int MaHD;
        private int MaKH;
        private float ThanhTien;
        private bool TrangThai;
        private string NgayThanhToan;
        public HoaDon()
        {
          
   
            ThanhTien = 0;
            TrangThai = false;
            NgayThanhToan = "";
        }
        public HoaDon(int mahd,int makh,float tt, bool tr,string ngay)
        {
            MaHD = mahd;
            MaKH = makh;
            ThanhTien = tt;
            TrangThai = tr;
            NgayThanhToan = ngay;
        }
        public int mahd
        {
            get { return MaHD; }
            set { MaHD = value; }
        }
        public int makh
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public float thanhtien
        {
            get { return ThanhTien; }
            set { ThanhTien = value; }
        }
        public bool trangthai
        {
            get { return TrangThai; }
            set { TrangThai = value; }
        }
        public string ngaythanhtoan
        {
            get { return NgayThanhToan; }
            set { NgayThanhToan = value; }
        }
    }
}