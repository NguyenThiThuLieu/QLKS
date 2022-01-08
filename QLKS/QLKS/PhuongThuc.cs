using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace QLKS
{
    public class PhuongThuc
    {
        string connectString = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
        public bool CheckNV(string manv)
        {
            string sql = @"Select count(*) from NhanVien where MaNV= @ma";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", manv);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckPhong(string maph)
        {
            string sql = @"Select count(*) from Phong where MaPhong= @ma";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maph);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckDV(string madv)
        {
            string sql = @"Select count(*) from DichVu where MaDV= @ma";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", madv);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckKH(string cm)
        {
            string sql = @"Select count(*) from KhachHang where CMND= @cm";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cm", cm);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckDatPhong(string maphong,string ngayden,string ngaydi)
        {
            string sql = @"select COUNT(*) from DatPhong where MaPhong=@maphong and (( NgayDen <= @ngayden and NgayDi >= @ngayden)   or (NgayDen <= @ngaydi and NgayDi>= @ngaydi))";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                cmd.Parameters.AddWithValue("@ngayden", ngayden);
                cmd.Parameters.AddWithValue("@ngaydi", ngaydi);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckHoaDon(float tien, int makh, string ngay)
        {
            string sql = @"select COUNT(*) from HoaDon where ThanhTien=@tien and MaKH=@makh and NgayThanhToan=@ngay";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tien", tien);
                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckThuePhong(string maphong, string ngayden, string ngaydi)
        {
            string sql = @"select COUNT(*) from ThuePhong where MaPhong=@maphong and (( NgayDen <= @ngayden and NgayDi >= @ngayden)   or (NgayDen <= @ngaydi and NgayDi>= @ngaydi))";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                cmd.Parameters.AddWithValue("@ngayden", ngayden);
                cmd.Parameters.AddWithValue("@ngaydi", ngaydi);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool CheckLogin(string manv,string matkhau)
        {
            string sql = @"Select count(*) from NhanVien where MaNV= @ma and MatKhau=@mk";
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", manv);
                cmd.Parameters.AddWithValue("@mk", matkhau);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return (count >= 1);
            }
        }
        public bool InsertPhong(Phong phong)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO Phong(MaPhong,TenPhong,LoaiPhong,TrangThai,Gia,HinhAnh)
                                VALUES(@ma,@ten,@loai,@trang,@gia,@hinh)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma", phong.maphong);
                command.Parameters.AddWithValue("@ten", phong.tenphong);
                command.Parameters.AddWithValue("@loai", phong.loaiphong);
                command.Parameters.AddWithValue("@trang", phong.trangthai);
                command.Parameters.AddWithValue("@gia", phong.giaphong);
                command.Parameters.AddWithValue("@hinh", phong.hinhanh);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }


        public bool InsertNV(NhanVien nhanvien)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO NhanVien(MaNV,TenNV,Ngaysinh,GioiTinh,SDT,MatKhau) Values (@manv,@tennv,@ngsinh,@gt,@sdt,@mk)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@manv", nhanvien.manv);
                command.Parameters.AddWithValue("@tennv", nhanvien.tennv);
                command.Parameters.AddWithValue("@ngsinh", nhanvien.ngaysinh);
                command.Parameters.AddWithValue("@gt", nhanvien.gioitinh);
                command.Parameters.AddWithValue("@sdt", nhanvien.sdt);
                command.Parameters.AddWithValue("@mk", nhanvien.matkhau);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }

        }
        public bool InsertKH(KhachHang khachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO KhachHang(HoTen,CMND,SDT,QuocTich,VIP) Values (@ht,@cm,@sdt,@qt,@vip)";
                SqlCommand command = new SqlCommand(sql, connection);
        
                command.Parameters.AddWithValue("@ht", khachHang.hoten);
                command.Parameters.AddWithValue("@cm", khachHang.cmnd);
                command.Parameters.AddWithValue("@sdt", khachHang.sdt);
                command.Parameters.AddWithValue("@qt", khachHang.quoctich);
                command.Parameters.AddWithValue("@vip", "false");
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }

        }
        public bool InsertThuePhong(ThuePhong thue)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO ThuePhong(MaKH,NgayDen,NgayDi,MaPhong,MaNV,TrangThai) Values (@makh,@ngden,@ngdi,@maph,@manv,'false')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", thue.makh);
                command.Parameters.AddWithValue("@ngden", thue.ngayden);
                command.Parameters.AddWithValue("@ngdi", thue.ngaydi);
                command.Parameters.AddWithValue("@maph", thue.maphong);
                command.Parameters.AddWithValue("@manv", thue.manv);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }

        }
        public bool InsertDatPhong(DatPhong1 dat)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO DatPhong(MaKH,NgayDen,NgayDi,MaPhong,TienCoc) Values (@makh,@ngden,@ngdi,@maph,@tiencoc)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", dat.makh);
                command.Parameters.AddWithValue("@ngden", dat.ngayden);
                command.Parameters.AddWithValue("@ngdi", dat.ngaydi);
                command.Parameters.AddWithValue("@maph", dat.maphong);
                command.Parameters.AddWithValue("@tiencoc", dat.tiencoc);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool InsertSDDV(SDDV sudungdv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO SDDV(MaKH,MaDV,NgaySD,TrangThai) Values (@makh,@madv,@ngsd,'false')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", sudungdv.makh);
                command.Parameters.AddWithValue("@madv", sudungdv.madv);
                command.Parameters.AddWithValue("@ngsd", sudungdv.ngsd);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }

        }
        public bool InsertDV(DichVu dv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO DichVu(MaDV,TenDV,GiaDV) Values (@madv,@ten,@gia)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@madv", dv.madv);
                command.Parameters.AddWithValue("@ten", dv.tendv);
                command.Parameters.AddWithValue("@gia", dv.giadv);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }

        }
        public bool InsertHD(HoaDon hoadon)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"INSERT INTO HoaDon(MaKH,ThanhTien,TrangThai,NgayThanhToan) Values (@makh,@tt,@tr,@ng)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", hoadon.makh);
                command.Parameters.AddWithValue("@tt", hoadon.thanhtien);
                command.Parameters.AddWithValue("@tr", hoadon.trangthai);
                command.Parameters.AddWithValue("@ng", hoadon.ngaythanhtoan);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        ///Xoa
        public bool DeleteKH(string makh)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM KhachHang WHERE MaKH='" + makh + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeletePhong(string maph)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM Phong WHERE MaPhong='" + maph + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteNV(string manv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM NhanVien WHERE MaNV='" + manv + "'";
                SqlCommand command = new SqlCommand(sql, connection);              
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteDV(string madv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM DichVu WHERE MaDV='" + madv + "'";
                SqlCommand command = new SqlCommand(sql, connection);                
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteHD(int mahd)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM HoaDon WHERE MaHD='" + mahd + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteThuePhong(int makh, string maph, string ngden, string ngdi)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM ThuePhong WHERE MaKH='" + makh + "' and MaPhong='" + maph + "'and NgayDen='" + ngden + "'and NgayDi='" + ngdi + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteDatPhong(int makh,string maph,string ngden,string ngdi)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM DatPhong WHERE MaKH='" + makh + "' and MaPhong='" + maph + "'and NgayDen='"+ngden+"'and NgayDi='"+ngdi+"'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        public bool DeleteSDDV(string makh,string madv,string ngsd)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"DELETE FROM SDDV WHERE MaKH='" + makh + "'and MaDV='" + madv + "'and NgaySD='" + ngsd + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                return result >= 1;
            }
        }
        //getall
        public DataTable GetKHbyCMND(string cmnd)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM KhachHang WHERE CMND='"+cmnd+"'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetSDDVbyCMND(string cmnd)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT SDDV.MaKH,HoTen,SDDV.MaDV,TenDV,GiaDV,NgaySD,TrangThai FROM SDDV,DichVu, KhachHang where SDDV.MaDV=DichVu.MaDV and KhachHang.MaKH=SDDV.MaKH and CMND='" + cmnd + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetDPbyCMND(string cmnd)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM DatPhong, KhachHang where KhachHang.MaKH=DatPhong.MaKH and CMND='" + cmnd + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetTPbyCMND(string cmnd)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT ThuePhong.MaKH,HoTen,ThuePhong.MaPhong,Gia,NgayDen,NgayDi,MaNV,ThuePhong.TrangThai FROM ThuePhong, KhachHang,Phong where KhachHang.MaKH=ThuePhong.MaKH and Phong.MaPhong=ThuePhong.MaPhong and CMND='" + cmnd + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetNVbyMANV(string manv)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM NhanVien Where MaNV='" +manv + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllKH()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM KhachHang ";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetKHVip()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM KhachHang Where VIP='true'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllDV()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM DichVu";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetPhong(string maphong,string loai)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            // maphong = maphong + "%";
           // if (maphong =="V")
          //  {
                string sql = @"select * from Phong where MaPhong like " + maphong + " and TrangThai = 'false'  and LoaiPhong like " + loai + "";
          //  }
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllPhong()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM Phong";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllThuePhong()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"select ThuePhong.MaKH,HoTen,ThuePhong.MaPhong,Gia,NgayDen,NgayDi,MaNV,ThuePhong.TrangThai from KhachHang,Phong,ThuePhong where KhachHang.MaKH=ThuePhong.MaKH and Phong.MaPhong=ThuePhong.MaPhong Order by TrangThai";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllDatPhong()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM DatPhong" ;
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllNV()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM NhanVien";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllHoadon()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT MaHD,HoaDon.MaKH,HoTen,ThuePhong.MaPhong,NgayDen,NgayDi,ThanhTien,HoaDon.TrangThai FROM KhachHang,HoaDon,ThuePhong where HoaDon.MaKH=KhachHang.MaKH and ThuePhong.MaKH=HoaDon.MaKH";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetHoadon(string ma)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT MaHD,HoaDon.MaKH,HoTen,ThuePhong.MaPhong,NgayThanhToan,ThanhTien,HoaDon.TrangThai FROM KhachHang,HoaDon,ThuePhong where HoaDon.MaKH=KhachHang.MaKH and ThuePhong.MaKH=HoaDon.MaKH and CMND='"+ma+"'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetAllSDDV()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT SDDV.MaKH,HoTen,SDDV.MaDV,TenDV,GiaDV,NgaySD,TrangThai FROM SDDV,DichVu, KhachHang where SDDV.MaDV=DichVu.MaDV and KhachHang.MaKH=SDDV.MaKH"; 
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public KhachHang GetUserByMaKH(int makh)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM KhachHang WHERE MaKH=@ma";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", makh);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    KhachHang kh = new KhachHang
                    {
                        makh = (int) reader["MaKH"],
                        hoten = (string)reader["HoTen"],
                        cmnd = (string)reader["CMND"],
                        sdt = (string)reader["SDT"],
                        quoctich = (string)reader["QuocTich"],
                        vip = (Boolean)reader["VIP"],
                      
                    };
                    return kh;
                }
            }
            return null;

        }
        public KhachHang GetUserByCMNDKH(string cmnd)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM KhachHang WHERE CMND=@cmnd";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cmnd", cmnd);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    KhachHang kh = new KhachHang
                    {
                        makh= (int)reader["MaKH"],
                        hoten = (string)reader["HoTen"],
                        cmnd = (string)reader["CMND"],
                        sdt = (string)reader["SDT"],
                        quoctich = (string)reader["QuocTich"],
                        vip = (Boolean)reader["VIP"],

                    };
                    return kh;
                }
            }
            return null;

        }
        public DichVu GetUserByDichVu(string madv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM DichVu WHERE MaDV=@ma";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", madv);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DichVu dv = new DichVu
                    {
                        madv = (string)reader["MaDV"],
                        tendv = (string)reader["TenDV"],
                        giadv = float.Parse(reader["GiaDV"].ToString()),
                    };
                    return dv;
                }
            }
            return null;

        }

        public NhanVien GetUserByNV(string manv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM NhanVien WHERE MaNV=@ma";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", manv);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NhanVien nv = new NhanVien
                    {
                        manv = (string)reader["MaNV"],
                        tennv = (string)reader["TenNV"],
                        ngaysinh = (string)reader["Ngaysinh"].ToString(),
                        gioitinh = (string)reader["GioiTinh"],
                        sdt = (string)reader["SDT"],
                        matkhau = (string)reader["MatKhau"],
                        
                    };
                    return nv;
                }
            }
            return null;

        }
        public HoaDon GetUserByHoaDon(int makh,float tien, string ngay)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM HoaDon WHERE MaKH=@mkh and ThanhTien=@tt and NgayThanhToan=@ng";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@mkh", makh);
                cmd.Parameters.AddWithValue("@tt", tien);
                cmd.Parameters.AddWithValue("@ng", ngay);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    HoaDon hoadon= new HoaDon
                    {
                        mahd = (int)reader["MaHD"],
                        makh = (int)reader["MaKH"],
                        thanhtien = float.Parse(reader["ThanhTien"].ToString()),
                        trangthai= (Boolean)reader["TrangThai"],
                        ngaythanhtoan = (string)reader["NgayThanhToan"].ToString(),    
                    };
                    return hoadon;
                }
            }
            return null;
        }
        public Phong GetUserPhong(string maphong)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM Phong WHERE MaPhong=@ma";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", maphong);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                   Phong phong = new Phong
                    {
                        maphong = (string)reader["MaPhong"],
                        tenphong = (string)reader["TenPhong"],
                        loaiphong = (string)reader["LoaiPhong"],
                        trangthai = (Boolean)reader["TrangThai"],
                        giaphong = float.Parse(reader["Gia"].ToString()),
                        hinhanh= (string)reader["HinhAnh"]
                    };
                    return phong;
                }
            }
            return null;

        }
        public DataTable GetPhong(string maphong)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"SELECT * FROM Phong where MaPhong='"+maphong+"'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public float TongHD(int makh)
        {
            float sumdv;
            SqlConnection connection = new SqlConnection(connectString);
            string sql = @"select sum(GiaDV) as ThanhTien from SDDV,DichVu where MaKH='" + makh + "' and SDDV.MaDV= DichVu.MaDV and TrangThai='false'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (DBNull.Value.Equals(reader.Read()))
            {
                return 0;
                
            }
            else
            {
                if (DBNull.Value.Equals(reader["ThanhTien"]))
                {
                    sumdv = 0;
                }
                else sumdv = float.Parse(reader["ThanhTien"].ToString());
                return sumdv;
            }
        }

        public float TienCoc(int makh,string maphong,string ngden,string ngdi)
        {
            float sumdv;
            SqlConnection connection = new SqlConnection(connectString);
            string sql = @"select TienCoc from DatPhong where MaKH='" + makh + "'and MaPHong='" + maphong + "'and NgayDen='" + ngden + "'and NgayDi='" + ngdi + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (DBNull.Value.Equals(reader.Read()))
            {
                return 0;

            }
            else
            {
                if (DBNull.Value.Equals(reader["TienCoc"]))
                {
                    sumdv = 0;
                }
                else sumdv = float.Parse(reader["TienCoc"].ToString());
                return sumdv;
            }
        }
        public ThuePhong GetUserByThuePhong(string cmnd)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"select ThuePhong.MaKH,ThuePhong.MaPhong,NgayDen,NgayDi,MaNV from ThuePhong,Phong,KhachHang 
                        where ThuePhong.MaKH=KhachHang.MaKH and Phong.MaPhong=ThuePhong.MaPhong and (CMND=@cmnd or ThuePhong.MaPhong=@cmnd)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@cmnd",cmnd);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ThuePhong thuephong=new ThuePhong
                    {
                        makh = (int)reader["MaKH"],
                        ngayden = (string)reader["NgayDen"],
                        ngaydi = (string)reader["NgayDi"],
                        maphong = (string)reader["MaPhong"],
                        manv = (string)reader["MaNV"]
                    };
                    return thuephong;
                }
            }
            return null;
        }
        public ThuePhong GetThuePhong(string maph,string ngden,string ngdi)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"select MaKH,MaNV from ThuePhong where MaPhong='" + maph + "'and NgayDen='" + ngden + "'and NgayDi='" + ngdi + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ThuePhong thuephong = new ThuePhong
                    {
                        makh = (int)reader["MaKH"],
                        manv = (string)reader["MaNV"]
                    };
                    return thuephong;
                }
            }
            return null;
        }
        public DataTable GetPhongNowChiTiet(string maphong)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"select ThuePhong.MaPhong,Gia,ThuePhong.MaKH,HoTen,SDDV.MaDV,GiaDV from Phong,ThuePhong,KhachHang,DichVu,SDDV
                             where Phong.MaPhong=ThuePhong.MaPhong and KhachHang.MaKH=ThuePhong.MaKH 
                                 and DichVu.MaDV=SDDV.MaDV and KhachHang.MaKH=SDDV.MaKH and Phong.MaPhong='" + maphong + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DataTable GetPhongNow()
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"select MaKH,Phong.MaPhong,TenPhong,LoaiPhong,Gia,NgayDi,NgayDen,MaNV,ThuePhong.TrangThai from ThuePhong,Phong 
                    where ThuePhong.MaPhong=Phong.MaPHong and
                        NgayDen<=GETDATE() and (NgayDi is null or NgayDi>= GETDATE()) and ThuePhong.TrangThai='false' ";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;

        }
        public DataTable GetPhongNowCMND(string cmnd)
        {
            SqlDataAdapter da;
            DataTable ds = new DataTable();
            string sql = @"select KhachHang.MaKH,Phong.MaPhong,TenPhong,LoaiPhong,Gia,NgayDi,NgayDen,MaNV,ThuePhong.TrangThai from KhachHang,ThuePhong,Phong 
                    where ThuePhong.MaPhong=Phong.MaPHong and KhachHang.MaKH=ThuePhong.MaKH and 
                        NgayDen<=GETDATE() and (NgayDi is null or NgayDi>= GETDATE()) and CMND='" + cmnd + "'";
            da = new SqlDataAdapter(sql, connectString);
            da.Fill(ds);
            return ds;
        }
        public DatPhong1 GetUserByDatPhong(string makh)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM DatPhong WHERE MaKH=@ma";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ma", makh);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DatPhong1 datphong = new DatPhong1
                    {
                        makh = (int)reader["MaKH"],
                        ngayden = (string)reader["NgayDen"].ToString(),
                        ngaydi = (string)reader["NgayDi"].ToString(),
                        maphong = (string)reader["MaPhong"],
                        tiencoc = (float)reader["TienCoc"]

                    };
                    return datphong;
                }
            }
            return null;
        }
        public SDDV GetUserBySDDV(int makh)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"SELECT * FROM SDDV WHERE MaKH="+makh;
                SqlCommand cmd = new SqlCommand(sql, connection);
                //cmd.Parameters.AddWithValue("@ma", makh);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SDDV sd = new SDDV
                    {
                        makh = (int)reader["MaKH"],
                        madv = (string)reader["MaDV"],
                        ngsd = (string)reader["NgaySD"].ToString(),
                    };
                    return sd;
                }
            }
            return null;
        }
        public bool UpdateTTThuePhong(string maphong,bool trangthai,int makh,string ngden,string ngdi)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE ThuePhong SET TrangThai=@trang where MaPhong=@ma and MaKH=@mkh and NgayDen=@ngden and NgayDi=@ngdi";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma",maphong);
                command.Parameters.AddWithValue("@mkh", makh);
                command.Parameters.AddWithValue("@ngden", ngden);
                command.Parameters.AddWithValue("@ngdi",ngdi);
                command.Parameters.AddWithValue("@trang", trangthai);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UpdateTTPhong(string maphong,bool trangthai)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE Phong SET TrangThai=@trang where MaPhong=@ma";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma", maphong);
                command.Parameters.AddWithValue("@trang", trangthai);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UpdateKHVIP(int makh, bool trangthai)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE KhachHang SET VIP=@trang where MaKH=@ma";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma", makh);
                command.Parameters.AddWithValue("@trang", trangthai);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool UpdatePHONG(Phong phong)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE Phong SET TenPhong=@ten,LoaiPhong=@loai,TrangThai=@trang,Gia=@gia,HinhAnh=@hinh where MaPhong=@ma";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma", phong.maphong);
                command.Parameters.AddWithValue("@ten", phong.tenphong);
                command.Parameters.AddWithValue("@loai", phong.loaiphong);
                command.Parameters.AddWithValue("@trang", phong.trangthai);
                command.Parameters.AddWithValue("@gia", phong.giaphong);
                command.Parameters.AddWithValue("@hinh", phong.hinhanh);
                connection.Open();
                int result = (int)command.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        

        public bool UpdateNV(NhanVien nhanvien)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE NhanVien set TenNV=@tennv,Ngaysinh=@ngsinh,GioiTinh=@gt,SDT=@sdt where MaNV=@manv";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@manv", nhanvien.manv);
                command.Parameters.AddWithValue("@tennv", nhanvien.tennv);
                command.Parameters.AddWithValue("@ngsinh", nhanvien.ngaysinh);
                command.Parameters.AddWithValue("@gt", nhanvien.gioitinh);
                command.Parameters.AddWithValue("@sdt", nhanvien.sdt);
                //command.Parameters.AddWithValue("@mk", nhanvien.matkhau);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateMKNV(NhanVien nhanvien)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE NhanVien set MatKhau=@mk where MaNV=@manv";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@manv", nhanvien.manv);
                command.Parameters.AddWithValue("@mk", nhanvien.matkhau);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateKH(KhachHang khachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE KhachHang SET HoTen=@ht,CMND=@cm,SDT=@sdt,QuocTich=@qt,VIP=@vip WHERE MaKH=@ma ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ma", khachHang.makh);
                command.Parameters.AddWithValue("@ht", khachHang.hoten);
                command.Parameters.AddWithValue("@cm", khachHang.cmnd);
                command.Parameters.AddWithValue("@sdt", khachHang.sdt);
                command.Parameters.AddWithValue("@qt", khachHang.quoctich);
                command.Parameters.AddWithValue("@vip", khachHang.vip);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateDV(DichVu dv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE DichVu SET TenDV=@ten,GiaDV=@gia WHERE MaDV=@ma ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ten", dv.tendv);
                command.Parameters.AddWithValue("@gia", dv.giadv);
                command.Parameters.AddWithValue("@ma", dv.madv);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateThuePhong(ThuePhong thue)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"Update ThuePhong SET NgayDen=@ngden,NgayDi=@ngdi,MaNV=@manv where MaKH=@makh and MaPhong=@maph";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", thue.makh);
                command.Parameters.AddWithValue("@ngden", thue.ngayden);
                command.Parameters.AddWithValue("@ngdi", thue.ngaydi);
                command.Parameters.AddWithValue("@maph", thue.maphong);
                command.Parameters.AddWithValue("@manv", thue.manv);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateNgayDi(int makh, string maph, string ngdi)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"Update ThuePhong SET NgayDi=@ngdi where MaKH=@makh and MaPhong=@maph";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", makh);
                command.Parameters.AddWithValue("@ngdi", ngdi);
                command.Parameters.AddWithValue("@maph", maph);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateDatPhong(DatPhong1 dat)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"Update DatPhong SET NgayDen=@ngden,NgayDi=@ngdi,TienCoc=@tiencoc where MaKH=@makh and MaPhong=@maph";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", dat.makh);
                command.Parameters.AddWithValue("@ngden", dat.ngayden);
                command.Parameters.AddWithValue("@ngdi", dat.ngaydi);
                command.Parameters.AddWithValue("@maph", dat.maphong);
                command.Parameters.AddWithValue("@tiencoc", dat.tiencoc);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateSDDV(SDDV sudungdv)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE SDDV SET MaDV=@madv WHERE MaKH=@makh and NgaySD=@ngsd";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", sudungdv.makh);
                command.Parameters.AddWithValue("@madv", sudungdv.madv);
                command.Parameters.AddWithValue("@ngsd", sudungdv.ngsd);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateTTSDDV(int makh)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE SDDV SET TrangThai='true'  WHERE MaKH=@makh";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh",makh);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
        public bool UpdateHD(HoaDon hoadon)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string sql = @"UPDATE HoaDon SET TrangThai=@tr WHERE MaKH=@makh and ThanhTien=@tt and NgayThanhToan=@ng ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@makh", hoadon.makh);
                command.Parameters.AddWithValue("@tt", hoadon.thanhtien);
                command.Parameters.AddWithValue("@tr", hoadon.trangthai);
                command.Parameters.AddWithValue("@ng", hoadon.ngaythanhtoan);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (result >= 1);
            }
        }
    }
}