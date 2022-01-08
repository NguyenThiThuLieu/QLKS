using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class QLKhachSan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                laydulieulenGridview();
            }

        }
        private void laydulieulenGridview()
        {
            PhuongThuc pt = new PhuongThuc();
            GridQLKS.DataSource = pt.GetPhongNow();
            GridQLKS.DataBind();
        }
        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridQLKS.DataSource = pt.GetPhongNowCMND(cmnd);
            GridQLKS.DataBind();
        }
        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttenkh.Text = "";
            txtmaphong.Text = "";
            txtcmnd.Text = "";
            txtngden.Text = "";
            txtngdi.Text = "";
            txttongtien.Text = "";
            txtmnv.Focus();
            txttim.Text = "";
            lbltb.Text = "";
            Lblph.Text = "";
            Lbldv.Text = "";
            Lblvip.Text = "";
            laydulieulenGridview();
        }
        public ThuePhong LaydulieutuForm()
        {
            PhuongThuc pt = new PhuongThuc();
            string cmnd = txtcmnd.Text;
            KhachHang kh = pt.GetUserByCMNDKH(cmnd);
            int mkh = kh.makh;
            string maphong = txtmaphong.Text;
            string ngayden = txtngden.Text;
            string ngaydi = txtngdi.Text;
            string manv = txtmnv.Text;
            ThuePhong dp = new ThuePhong
            {
                makh = mkh,
                ngayden = ngayden,
                ngaydi = ngaydi,
                maphong = maphong,
                manv = manv,
                trangthai = false
            };
            return dp;
        }
        protected void Btnluu_Click(object sender, EventArgs e)
        {

            ThuePhong dp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.UpdateThuePhong(dp);
            if (result)
            {
                lbltb.Text = "Cập nhật thành công ! ";
                laydulieulenGridview();
            }
            else
            {
                lbltb.Text = "Cập nhật không thành công";
            }
        }
        protected void GridQLKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makh = Int32.Parse(GridQLKS.SelectedRow.Cells[0].Text);
            float giaph = float.Parse(GridQLKS.SelectedRow.Cells[4].Text);
            string ngden = GridQLKS.SelectedRow.Cells[5].Text;         
            string maphong = GridQLKS.SelectedRow.Cells[1].Text;
            string manv = GridQLKS.SelectedRow.Cells[6].Text;
            string tthai = GridQLKS.SelectedRow.Cells[8].Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang kh = pt.GetUserByMaKH(makh);
            txttenkh.Text = kh.hoten;
            txtcmnd.Text = kh.cmnd;
            txtmaphong.Text = maphong;
            txtngden.Text = ngden;
            DateTime now = DateTime.Now;
            //txtngdi.Text = now.ToShortDateString();
            txtmnv.Text = manv;
            Phong ph = pt.GetUserPhong(maphong);
            float km = 0;
            if (kh.vip == true)
            {
                km = 200000;
            }
            else
            {
                km = 0;
            }
            DateTime d2 = DateTime.Parse(ngden);         
            int songay = (now - d2).Days;
            float tong = pt.TongHD(makh) + ph.giaphong * songay - km;
            txttongtien.Text = tong.ToString();
            float tienphong = ph.giaphong * songay;
            Lbldv.Text = pt.TongHD(makh).ToString();
            Lblph.Text = tienphong.ToString();
            if (kh.vip == true)
            {
                Lblvip.Text = "-200000";
            }
            else Lblvip.Text = "0";
        }
        private void DoDuLieuLenForm(KhachHang kh, Phong ph, ThuePhong thph, NhanVien nv, DichVu dv)
        {
        }
        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
            lbltb.Text = "";
        }
        protected void Btndat_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinKH.aspx?thongtin=dat");
        }

        protected void Btnthue_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinKH.aspx?thongtin=thue");
        }
        protected void BtnThanhToan_Click(object sender, EventArgs e)
        {
            PhuongThuc pt = new PhuongThuc();
            ThuePhong tp = LaydulieutuForm();
            Phong ph = pt.GetUserPhong(tp.maphong);
            KhachHang kh = pt.GetUserByMaKH(tp.makh);
            float km = 0;
            if (kh.vip == true)
            {
                km = 200000;
            }
            else
            {
                km = 0;
            }
            DateTime d2 = DateTime.Parse(tp.ngayden);
            DateTime now = DateTime.Now;
            int songay = (now - d2).Days;
            float tienphong = ph.giaphong * songay;
            float tong = pt.TongHD(tp.makh) + ph.giaphong * songay - km;
            txttongtien.Text = tong.ToString();
            HoaDon hd = new HoaDon
            {
                makh = tp.makh,
                thanhtien = tong,
                trangthai = true,
                ngaythanhtoan = now.ToShortDateString(),
            };
            bool count = pt.CheckHoaDon(hd.thanhtien, hd.makh, hd.ngaythanhtoan);
            if (count)
            {
                lbltb.Text = "Đã thanh toán";
            }
            else
            {
                bool exist = pt.InsertHD(hd);
                if (exist)
                {
                    lbltb.Text = "Thanh toán thành công ! " + tong;
                    pt.UpdateTTSDDV(tp.makh);
                }
                else
                {
                    lbltb.Text = "Thanh toán không thành công";
                }
            }
        }
        protected void GridQLKS_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int mkh = Int32.Parse(GridQLKS.Rows[e.RowIndex].Cells[0].Text);
            string maph = GridQLKS.Rows[e.RowIndex].Cells[1].Text;
            string ngden = GridQLKS.Rows[e.RowIndex].Cells[5].Text;
            string manv = GridQLKS.Rows[e.RowIndex].Cells[6].Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang kh = pt.GetUserByMaKH(mkh);
            Phong ph = pt.GetUserPhong(maph);
            float km = 0;
            if (kh.vip == true)
            {
                km = 200000;
            }
            else
            {
                km = 0;
            }
            DateTime d2 = DateTime.Parse(ngden);
            DateTime now = DateTime.Now;
            int songay = (now - d2).Days;
            float tong = pt.TongHD(mkh) + ph.giaphong * songay - km;
            bool count = pt.CheckHoaDon(tong, mkh, now.ToShortDateString());
            if (count)
            {
                pt.UpdateNgayDi(mkh, maph, now.ToShortDateString());
                bool rs = pt.UpdateTTThuePhong(maph, true, mkh, ngden, now.ToShortDateString());
                if (rs)
                {
                    bool rs1 = pt.UpdateTTPhong(maph, false);
                    if (rs1)
                    {
                        laydulieulenGridview();
                        lbltb.Text = "Trả phòng thành công";  
                    }
                    else lbltb.Text = "Phòng chưa cập nhật";
                }
                else lbltb.Text = "Trả phòng thất bại";
            }
            else
            {
                lbltb.Text = "Chọn chi tiết, thanh toán để lập hóa đơn và thanh toán trước khi trả phòng !!!";
            }
        } 
        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
    }
}