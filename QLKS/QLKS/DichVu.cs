using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class DichVu
    {
        private string MaDV;
        private string TenDV;
        private float GiaDV;

        public DichVu()
        {
            MaDV = "";
            TenDV = "";
            GiaDV = 0;
        }
        public DichVu(string ma,string ten,float gia)
        {
            MaDV = ma;
            TenDV = ten;
            GiaDV = gia;
        }
        public string madv
        {
            get { return MaDV; }
            set { MaDV = value; }
        }
        public string tendv
        {
            get { return TenDV; }
            set { TenDV = value; }
        }
        public float giadv
        {
            get { return GiaDV; }
            set { GiaDV = value; }
        }
    }
}