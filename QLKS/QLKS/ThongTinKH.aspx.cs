using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class ThongTinKH : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbltb.Text = "";
            }     

        }
        public KhachHang LaydulieutuForm()
        {
            string ht = txthoten.Text;
            string cm = txtcmnd.Text;
            string so = txtsdt.Text;
            string qt = txtquoctich.Text;
            KhachHang kh = new KhachHang
            {
                hoten = ht,
                cmnd = cm,
                sdt = so,
                quoctich = qt
            };
            return kh;
        }
       
        protected void btntieptheo_Click(object sender, EventArgs e)
        {
            KhachHang kh = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckKH(kh.cmnd);
            if (exist)
            {

                //hiển thị thông báo đăng nhập thành công.
                KhachHang khach = pt.GetUserByCMNDKH(txtcmnd.Text);
                int mkh = khach.makh;
                string tt = Request.QueryString["thongtin"];
               
                    Response.Redirect("DatPhong.aspx?makhachhang="+mkh+ "&&thongtin='" + tt + "'");            
            }
            else

            {
                bool result = pt.InsertKH(kh);
                if (result)
                {
                    KhachHang khach = pt.GetUserByCMNDKH(txtcmnd.Text);
                    string mkh = khach.makh.ToString();
                    string tt = Request.QueryString["thongtin"];
                     Response.Redirect("DatPhong.aspx?makhachhang='" + mkh + "'&&thongtin=" + tt);
                }
                else
                {
                    lbltb.Text = "Có lỗi. Vui lòng thử lại.";
                }
            }
        }



        protected void LinkTC_Click(object sender, EventArgs e)
        {
            string tt = Request.QueryString["thongtin"].ToString();
            if (tt == "dat" || tt == "thue")
            {
                Response.Redirect("QLKhachSan.aspx");
            }
            else Response.Redirect("TrangChu.aspx");
        }

        protected void LinkCancel_Click(object sender, EventArgs e)
        {
            string tt = Request.QueryString["thongtin"].ToString();
            if (tt == "dat" || tt == "thue")
            {
                Response.Redirect("QLKhachSan.aspx");
            }
            else Response.Redirect("TrangChu.aspx");
        }
    }
}