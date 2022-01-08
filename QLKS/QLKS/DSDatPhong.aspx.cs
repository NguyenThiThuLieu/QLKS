using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class DSDatPhong : System.Web.UI.Page
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
            GridDP.DataSource = pt.GetAllDatPhong();
            GridDP.DataBind();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridDP.DataSource = pt.GetDPbyCMND(cmnd);
            GridDP.DataBind();
        }

        protected void Btnall_Click(object sender, EventArgs e)
        {
            
                laydulieulenGridview();
            
        }

        public DatPhong1 LaydulieutuForm()
        {
            PhuongThuc pt = new PhuongThuc();
            string cmnd = txtmakh.Text;
            KhachHang kh = pt.GetUserByCMNDKH(cmnd);
            int mkh = kh.makh;
            string maphong = txtmadv.Text;
            string ngayden = txtg.Text;
            string ngaydi = txtngaydi.Text;
            float tiencoc = (float)Convert.ToDecimal(txttiencoc.Text);
            DatPhong1 dp = new DatPhong1
            {
                makh = mkh,
                ngayden = ngayden,
                ngaydi = ngaydi,
                maphong = maphong,
                tiencoc = tiencoc,
            };
            return dp;
        }
        protected void Btnluu_Click(object sender, EventArgs e)
        {
            DatPhong1 dp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.UpdateDatPhong(dp);
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

        protected void Btnthem_Click(object sender, EventArgs e)
        {
            DatPhong1 dp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckDatPhong(dp.maphong, dp.ngayden, dp.ngaydi);
            if (exist)
            {
                lbltb.Text = "Phòng đã được đặt trước, vui lòng chọn phòng khác! ";
               }
            else
            {
                bool result = pt.InsertDatPhong(dp);
                if (result)
                {
                    lbltb.Text = "Đặt phòng thành công ! ";
                    laydulieulenGridview();
                }
                else
                {
                    lbltb.Text = "Đặt phòng không thành công";
                }
            }
        }
        private void DoDuLieuLenForm()
        {
            int makh = Int32.Parse(GridDP.SelectedRow.Cells[0].Text);
            string maphong = GridDP.SelectedRow.Cells[1].Text;
            string ngden = GridDP.SelectedRow.Cells[2].Text;
            string ngdi = GridDP.SelectedRow.Cells[3].Text;
            string tiencoc = GridDP.SelectedRow.Cells[4].Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang khach = pt.GetUserByMaKH(makh);
            txtmakh.Text = khach.cmnd;
            txtht.Text = khach.hoten;
            txtg.Text = ngden;
            txtngaydi.Text = ngdi;
            txtmadv.Text = maphong;
            txttiencoc.Text = tiencoc;
        }
        protected void GridDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makh = GridDP.SelectedRow.Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            DoDuLieuLenForm();
        }

        protected void cldngdi_SelectionChanged(object sender, EventArgs e)
        {
            txtngaydi.Text = cldngdi.SelectedDate.Date.ToShortDateString();
            cldngdi.Visible = false;
        }

        protected void cldngden_SelectionChanged(object sender, EventArgs e)
        {
            txtg.Text = cldngden.SelectedDate.Date.ToShortDateString();
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

        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            lbltb.Text = "";
            txtmakh.Text = "";
            txtht.Text = "";
            txtg.Text = "";
            txtngaydi.Text = "";
            txtmadv.Text = "";
            txttiencoc.Text = "";
            lbltb.Text = "";
            txtmakh.Focus();
            laydulieulenGridview();
        }                 
        protected void GridDP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int makh = Int32.Parse(GridDP.Rows[e.RowIndex].Cells[0].Text);
            string maph = GridDP.Rows[e.RowIndex].Cells[1].Text;
            string ngden = GridDP.Rows[e.RowIndex].Cells[2].Text;
            string ngdi = GridDP.Rows[e.RowIndex].Cells[3].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteDatPhong(makh,maph,ngden,ngdi);
            if (result)
            {
                lbltb.Text = "Đã xóa thành công ! ";
                laydulieulenGridview();
            }
            else
            {
                lbltb.Text = "Xóa không thành công";
            }
        }    
        protected void BtnCheckin_Click(object sender, EventArgs e)
        {
            PhuongThuc pt = new PhuongThuc();
            string cmnd = txtmakh.Text;
            KhachHang kh = pt.GetUserByCMNDKH(cmnd);
            int mkh = kh.makh;
            string maphong = txtmadv.Text;
            string ngayden = txtg.Text;
            string ngaydi = txtngaydi.Text;
            float tiencoc = (float)Convert.ToDecimal(txttiencoc.Text);
            Phong ph = pt.GetUserPhong(maphong);
            ThuePhong tp = new ThuePhong
            {
                makh = mkh,
                ngayden = ngayden,
                ngaydi = ngaydi,
                maphong = maphong,
                manv="NV1",
            };
            bool result = pt.InsertThuePhong(tp);
            if (result)
            {
                ph.trangthai = true;
                lbltb.Text = "Check-in thành công ! ";
                pt.DeleteDatPhong(mkh, maphong,ngayden,ngaydi);
                laydulieulenGridview();
            }
            else
            {
                lbltb.Text = "Nhận phòng không thành công";
            }
        }

        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
    }
}