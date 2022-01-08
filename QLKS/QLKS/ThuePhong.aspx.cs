using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class ThuePhong1 : System.Web.UI.Page
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
            GridTP.DataSource = pt.GetAllThuePhong();
            GridTP.DataBind();
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
            ThuePhong tp = new ThuePhong
            {
                makh = mkh,
                ngayden = ngayden,
                ngaydi = ngaydi,
                maphong = maphong,
                manv=manv,
                trangthai = false,
            };
            return tp;
        }
        protected void Btnthem_Click(object sender, EventArgs e)
        {
            string maphong = txtmaphong.Text;
            ThuePhong tp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            Phong ph = pt.GetUserPhong(maphong);
            bool exist = pt.CheckThuePhong(maphong, tp.ngayden, tp.ngaydi);
                if (ph.trangthai == false)
                {
                    bool result = pt.InsertThuePhong(tp);
                    if (result)
                    {
                        lbltb.Text = "Thêm thành công ! ";
                        pt.UpdateTTPhong(maphong, true);
                        laydulieulenGridview();
                    }
                    else
                    {
                        lbltb.Text = "Đặt phòng không thành công";
                    }
                }
                else
                {
                    lbltb.Text = "Phòng đã có người ở, vui lòng chọn phòng khác! ";
                }
        }

        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            lbltb.Text = "";
            txtcmnd.Text = "";
            txtht.Text = "";
            txtmaphong.Text = "";
            txtmnv.Text = "";
            txtngden.Text = "";
            txtngdi.Text = "";
            txtcmnd.Focus();
            laydulieulenGridview();
        }

        protected void Btnluu_Click(object sender, EventArgs e)
        {
            ThuePhong tp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.UpdateThuePhong(tp);
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

        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
        }
        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridTP.DataSource = pt.GetTPbyCMND(cmnd);
            GridTP.DataBind();
        }
        protected void cldngdi_SelectionChanged(object sender, EventArgs e)
        {
            txtngdi.Text = cldngdi.SelectedDate.Date.ToShortDateString();
            cldngdi.Visible = false;
        }
        protected void cldngden_SelectionChanged(object sender, EventArgs e)
        {
            txtngden.Text = cldngden.SelectedDate.Date.ToShortDateString();
            cldngden.Visible = false;
        }
        protected void lnkPickngden_Click(object sender, EventArgs e)
        {
            cldngden.Visible = true;
        }
        protected void lnkPickngdi_Click(object sender, EventArgs e)
        {
            cldngdi.Visible = true;
        }
        private void DoDuLieuLenForm()
        {
            int makh = Int32.Parse(GridTP.SelectedRow.Cells[0].Text);
            string maphong = GridTP.SelectedRow.Cells[2].Text;
            string ngden = GridTP.SelectedRow.Cells[4].Text;
            string ngdi = GridTP.SelectedRow.Cells[5].Text;
            string manv = GridTP.SelectedRow.Cells[6].Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang khach = pt.GetUserByMaKH(makh);
            txtcmnd.Text = khach.cmnd;
            txtht.Text = khach.hoten;
            txtngden.Text = ngden;
            txtngdi.Text = ngdi;
            txtmaphong.Text = maphong;
            txtmnv.Text = manv;
        }
        protected void GridTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = GridTP.SelectedRow.Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            DoDuLieuLenForm();
        }

        protected void GridTP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int makh = Int32.Parse(GridTP.Rows[e.RowIndex].Cells[0].Text);
            string maph = GridTP.Rows[e.RowIndex].Cells[2].Text;
            string ngden = GridTP.Rows[e.RowIndex].Cells[4].Text;
            string ngdi = GridTP.Rows[e.RowIndex].Cells[5].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteThuePhong(makh, maph, ngden, ngdi);
            if (result)
            {
                lbltb.Text = "Đã xóa thành công ! ";
                pt.UpdateTTPhong(maph, false);
                //ph.trangthai = false;
                laydulieulenGridview();
            }
            else
            {
                lbltb.Text = "Xóa không thành công";
            }
        }
        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
    }
}