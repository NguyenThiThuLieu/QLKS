using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class DoiMK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbltb.Text = "";
            }
        }
        public NhanVien LaydulieutuForm()
        {
            string ma = txtmanv.Text;
            string mat = txtmatkhau.Text;
            string mkm = txtmatkhaunew.Text;
            string nlmk = txtnewagain.Text;
            PhuongThuc pt = new PhuongThuc();
            NhanVien nv = pt.GetUserByNV(ma);
            bool check = pt.CheckLogin(ma,mat);
            string mkhau;
            if (check)
            {
                mkhau = mkm;
            }
            else
            {
                mkhau = mat;
                lbltb.Text = "Tên đăng nhập hoặc mật khẩu sai !!";
            }
            NhanVien nhanvien = new NhanVien
            {
                manv = ma,
                matkhau = mkhau
            };
            return nhanvien;
        }
        protected void btndoimk_Click(object sender, EventArgs e)
        {
            NhanVien nv = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool doi = pt.UpdateMKNV(nv);
            if (doi)
            {
                lbltb.Text = "Đổi mật khẩu thành công !";
            }    
            else
            {
                lbltb.Text = "Thất bại !";
            }    
        }
    }
}