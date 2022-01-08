using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class ThuePhong
    {
            private int MaKH;
            private string NgayDen;
            private string NgayDi;
            private string MaPhong;
            private string MaNV;
            private Boolean TrangThai;
            public ThuePhong()
            {
                MaKH = 0;
                NgayDen = "";
                NgayDi = "";
                MaPhong = "";
                MaNV = "";
            }
            public ThuePhong(int makh, string nden, string ngdi, string maph, string manv,bool tt)
            {
                MaKH = makh;
                NgayDen = nden;
                NgayDi = ngdi;
                MaPhong = maph;
                MaNV = manv;
                TrangThai = tt;
            }
            public int makh
            {
                get { return MaKH; }
                set { MaKH = value; }
            }
            public string ngayden
            {
                get { return NgayDen; }
                set { NgayDen = value; }
            }
            public string ngaydi
            {
                get { return NgayDi; }
                set { NgayDi = value; }
            }
            public string maphong
            {
                get { return MaPhong; }
                set { MaPhong = value; }
            }
           public string manv
           {
              get { return MaNV; }
              set { MaNV = value; }
           }
           public Boolean trangthai
           {
            get { return TrangThai; }
            set { TrangThai = value; }
           }
    }
}