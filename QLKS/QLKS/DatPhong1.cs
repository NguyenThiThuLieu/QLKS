using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class DatPhong1
    {
        private int MaKH;
        private string NgayDen;
        private string NgayDi;
        private string MaPhong;
        private float TienCoc;
        public DatPhong1()
        {
            MaKH = 0;
            NgayDen = "";
            NgayDi = "";
            MaPhong = "";
            TienCoc = 0;
        }
        public DatPhong1(int makh,string nden, string ngdi,string maph,float tc)
        {
            MaKH = makh;
            NgayDen = nden;
            NgayDi = ngdi;
            MaPhong = maph;
            TienCoc = tc;
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
        public float tiencoc
        {
            get { return TienCoc; }
            set { TienCoc = value; }
        }
    }
}