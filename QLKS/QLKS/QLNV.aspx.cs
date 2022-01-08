using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class QLNV : System.Web.UI.Page
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
            GridNV.DataSource = pt.GetAllNV();
            GridNV.DataBind();
        }


        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {

            string manv = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridNV.DataSource = pt.GetNVbyMANV(manv);
            GridNV.DataBind();
        }
        public NhanVien LaydulieutuForm()
        {
            string manv = txtmanv.Text;
            string ht = txtht.Text;
            string ngsinh = txtngsinh.Text;
            string sdt = txtsdt.Text;
            NhanVien nv = new NhanVien
            {
               manv=manv,
               tennv=ht,
               ngaysinh=ngsinh,
                sdt = sdt,
            };
            return nv;
        }
        protected void Btnthem_Click(object sender, EventArgs e)
        {
            NhanVien nv = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckNV(nv.manv);
            if (exist)
            {
                lbltb.Text = "Trùng mã nhân viên!!";
            }
            else

            {
                nv.matkhau = "1111";
                bool result = pt.InsertNV(nv);
                if (result)
                {
                    lbltb.Text = "Thêm thành công ! ";
                    laydulieulenGridview();
                }
                else
                {
                    lbltb.Text = "Thêm không thành công";
                }
            }
        }
        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttim.Text="";
            lbltb.Text = "";
            txtmanv.Text = "";
            txtmanv.Focus();
            txtht.Text = "";
            txtsdt.Text = "";
            txtngsinh.Text = "";
            laydulieulenGridview();
        }

        protected void Btnluu_Click(object sender, EventArgs e)
        {
            NhanVien nv = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.UpdateNV(nv);
            if (exist)
            {
                lbltb.Text = "Cập nhật thành công ! ";
                laydulieulenGridview();
            }
            else
            {
               lbltb.Text = "Cập nhật không thành công";
            }
        }

        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
        private void DoDuLieuLenForm(NhanVien nv)
        {
            txtmanv.Text = nv.manv;
            txtht.Text = nv.tennv;
            txtngsinh.Text = nv.ngaysinh;
            txtsdt.Text = nv.sdt;
        }
        protected void GridNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manv = GridNV.SelectedRow.Cells[0].Text;
            string hoten = GridNV.SelectedRow.Cells[1].Text;
            string ngsinh = GridNV.SelectedRow.Cells[2].Text;
            string sdt = GridNV.SelectedRow.Cells[3].Text;
            PhuongThuc pt = new PhuongThuc();
            NhanVien nv = pt.GetUserByNV(manv);
             txtmanv.Text = manv;
             txtht.Text = nv.tennv;
             txtngsinh.Text = ngsinh;
             txtsdt.Text = sdt;
        }
        protected void GridNV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string manv = GridNV.Rows[e.RowIndex].Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteNV(manv);
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
    }
}