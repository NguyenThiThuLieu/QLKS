using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class KhachHang1 : System.Web.UI.Page
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
            GridKH.DataSource = pt.GetAllKH();
            GridKH.DataBind();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridKH.DataSource = pt.GetKHbyCMND(cmnd);
            GridKH.DataBind();
        }

        protected void GridKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makh = Int32.Parse(GridKH.SelectedRow.Cells[0].Text);
            PhuongThuc pt = new PhuongThuc();
            KhachHang kh = pt.GetUserByMaKH(makh);
            if (kh != null)
            {
                DoDuLieuLenForm(kh);
            }
        }
        private void DoDuLieuLenForm(KhachHang kh)
        {
            txtmakh.Text =  kh.makh.ToString();
            txtht.Text = kh.hoten;
            txtcmnd.Text = kh.cmnd;
            txtsdt.Text = kh.sdt;
            txtqt.Text = kh.quoctich;
        }
        public KhachHang LaydulieutuForm()
        {
            int mkh = Int32.Parse(txtmakh.Text);
            string ht = txtht.Text;
            string cm = txtcmnd.Text;
            string so = txtsdt.Text;
            string qt = txtqt.Text;
            KhachHang kh = new KhachHang
            {
               makh=mkh,
               hoten=ht,
               cmnd=cm,
               sdt=so,
               quoctich=qt
            };
            return kh;
        }
        protected void GridKH_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string makh = GridKH.Rows[e.RowIndex].Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteKH(makh);
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
        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txtht.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
            txtqt.Text = "";
            txtmakh.Focus();
            txttim.Text = "";
            lbltb.Text = "";
            laydulieulenGridview();
        }

        protected void Btnluu_Click(object sender, EventArgs e)
        {
            KhachHang kh = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckKH(kh.cmnd);
            if (exist)
            {
                bool result = pt.UpdateKH(kh);
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
            else

            {
                bool result = pt.InsertKH(kh);
                if (result)
                {
                    lbltb.Text = "Thêm khách hàng thành công ! ";
                    laydulieulenGridview();
                }
                else
                {
                    lbltb.Text = "Có lỗi. Vui lòng thử lại.";
                }
            }
        }

        protected void Btnthem_Click(object sender, EventArgs e)
        {
            KhachHang dp = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckKH(dp.cmnd);
            if (exist)
            {
                bool vip = pt.UpdateKHVIP(dp.makh, true);
                lbltb.Text = "Đăng ký VIP thành công!!";
            }
            else

            {
                bool result = pt.InsertKH(dp);
                if (result)
                {
                    bool vip = pt.UpdateKHVIP(dp.makh, true);
                    lbltb.Text = "Thêm, Đăng ký VIP thành công!!";
                    laydulieulenGridview();
                }
                else
                {
                    lbltb.Text = "Thêm không thành công";
                }

            }
        }

        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
        }

        protected void Btnvip_Click(object sender, EventArgs e)
        {
            PhuongThuc pt = new PhuongThuc();
            GridKH.DataSource = pt.GetKHVip();
            GridKH.DataBind();
        }

        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
    }
}