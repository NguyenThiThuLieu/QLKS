using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
	public partial class DangNhap : System.Web.UI.Page
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
            NhanVien nhanvien = new NhanVien
            {
                manv = ma,
                matkhau=mat
            };
            return nhanvien;
        }
        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            txtmatkhau.Attributes["value"] = txtmatkhau.Text;
            string ma = txtmanv.Text;
            string mat = txtmatkhau.Attributes["value"];
            NhanVien nv = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckLogin(ma,mat);
            if (exist)
            {                                 
                Response.Redirect("QLKhachSan.aspx");
            }
            else
            {
               lbltb.Text="Mã nhân viên hoặc mật khẩu sai!!!";;
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoiMK.aspx");
        }
    }
}