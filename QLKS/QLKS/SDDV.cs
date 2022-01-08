using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class SDDV
    {
        private int MaKH;
        private string MaDV;
        private string NgaySD;
        private Boolean TrangThai;
        public SDDV()
        {
            MaDV = "";
            NgaySD = "";
        }
        public SDDV(int makh,string madv,string ngsd)
        {
            MaKH = makh;
            MaDV = madv;
            NgaySD = ngsd;
        }
        public int makh
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string madv
        {
            get { return MaDV; }
            set { MaDV = value; }
        }
        public string ngsd
        {
            get { return NgaySD; }
            set { NgaySD = value; }
        }
        public Boolean trthai
        {
            get { return TrangThai; }
            set { TrangThai = value; }
        }
    }
}