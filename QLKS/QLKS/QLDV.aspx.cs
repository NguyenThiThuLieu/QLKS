using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class QLDV : System.Web.UI.Page
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
            GridSDDV.DataSource = pt.GetAllSDDV();
            GridSDDV.DataBind();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridSDDV.DataSource = pt.GetSDDVbyCMND(cmnd);
            GridSDDV.DataBind();
        }

        protected void Btnall_Click(object sender, EventArgs e)
        {             
            laydulieulenGridview();
            lbltb.Text = "";
        }
        public SDDV LaydulieutuForm()
        {
            string cmnd = txtmakh.Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang kh = pt.GetUserByCMNDKH(cmnd);
            int mkh = kh.makh;
            string ht = txtht.Text;
            string mdv = txtmadv.Text;
            string ngsd = txtngsd.Text;
            SDDV sd = new SDDV
            {
                makh = mkh,
                madv = mdv,
                ngsd = ngsd,
                trthai = false,
            };
            return sd;
        }
        protected void Btnluu_Click(object sender, EventArgs e)
        {
            SDDV sd = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.UpdateSDDV(sd);
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
        protected void cldngsd_SelectionChanged(object sender, EventArgs e)
        {
            txtngsd.Text = cldngsd.SelectedDate.Date.ToShortDateString();
            cldngsd.Visible = false;
        }

        protected void lnkPickngsd_Click(object sender, EventArgs e)
        {
            cldngsd.Visible = true;
        }

        protected void Btnthem_Click(object sender, EventArgs e)
        {
            SDDV sd = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.InsertSDDV(sd);
            if (result)
            {
                lbltb.Text = "Thêm thành công ! ";
                laydulieulenGridview();
            }
            else
            {
                lbltb.Text = "Có lỗi. Vui lòng thử lại.";
            }
        }

        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            lbltb.Text = "";
            txtmakh.Text = "";
            txtht.Text = "";
            txtmadv.Text = "";
            txtngsd.Text = "";
            txtmakh.Focus();
            laydulieulenGridview();
        }

        protected void GridSDDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makh = Int32.Parse(GridSDDV.SelectedRow.Cells[0].Text);
            string madv = GridSDDV.SelectedRow.Cells[2].Text;
            string ngsd = GridSDDV.SelectedRow.Cells[5].Text;
            PhuongThuc pt = new PhuongThuc();
            KhachHang khhang = pt.GetUserByMaKH(makh);
            SDDV sd = pt.GetUserBySDDV(makh);
            if (khhang != null && sd !=null)
            {
                DoDuLieuLenForm(khhang,sd);
                txtngsd.Text = ngsd;
            }
        }
        private void DoDuLieuLenForm(KhachHang kh,SDDV dv)
        {

            txtmakh.Text = kh.cmnd;
            txtht.Text = kh.hoten;
            txtmadv.Text = dv.madv;
            ///txtngsd.Text = dv.ngsd;
        }

        protected void GridSDDV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string makh = GridSDDV.Rows[e.RowIndex].Cells[0].Text;
            string madv = GridSDDV.Rows[e.RowIndex].Cells[2].Text;
            string nsd = GridSDDV.Rows[e.RowIndex].Cells[5].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteSDDV(makh,madv,nsd);
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

        protected void BtntimDV_Click(object sender, EventArgs e)
        {

        }

        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
    }
}