using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class KhachHang
    {
        private int MaKH;
        private string HoTen;
        private string CMND;
        private string SDT;
        private string QuocTich;
        private bool VIP;
        public  KhachHang()
        {
            HoTen = "";
            CMND = "";
            SDT = "";
            QuocTich = "";
            VIP = false;
        }
        public KhachHang(int ma,string ht, string cm,string sodt,string qt,bool v)
        {
            MaKH = ma;
           HoTen = ht;
            CMND = cm;
            sodt = SDT;
            QuocTich = qt;
            VIP = v;
        }
        public string hoten
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public int makh
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string cmnd
        {
            get { return CMND; }
            set { CMND = value; }
        }
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string quoctich
        {
            get { return QuocTich; }
            set { QuocTich = value; }
        }
        public bool vip
        {
            get { return VIP; }
            set { VIP = value; }
        }
    }
}