using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLKS
{
    public class NhanVien
    {
        private string MaNV;
        private string TenNV;
        private string NgaySinh;
        private string GioiTinh;
        private string SDT;
        private string MatKhau;
        public NhanVien()
        {
            MaNV = "";
            TenNV = "";
            NgaySinh = "";
            GioiTinh = "";
            SDT = "";
            MatKhau = "";
        }
        public NhanVien(string ma,string ten,string ngsinh,string gt,string sdt,string mk)
        {
            MaNV = ma;
            TenNV = ten;
            NgaySinh = ngsinh;
            GioiTinh = gt;
            SDT = sdt;
            MatKhau = mk;
        }
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public string tennv
        {
            get { return TenNV; }
            set { TenNV = value; }
        }
        public string ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        public string gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string matkhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
    }
}