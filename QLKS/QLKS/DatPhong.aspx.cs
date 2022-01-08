using System;
using System.Web.UI;

namespace QLKS
{
    public partial class DatPhong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                lbltb.Text = "";
            }
        }


        protected void btndangki_Click(object sender, EventArgs e)
        {
            string makh = Request.QueryString["makhachhang"].ToString();
            string tt = Request.QueryString["thongtin"].ToString();
            DateTime ngdi = cldngden.SelectedDate;
            DateTime ngden = cldngdi.SelectedDate;

            Response.Redirect("PhongDat.aspx?makh=" +makh+ "&&ngayden=" + cldngden.SelectedDate + "&&ngaydi=" + cldngdi.SelectedDate + "&&songuoi='" + Dropsonguoi.SelectedValue + "'&&loai='" + Droploai.SelectedValue + "'&&thongtin=" + tt);
        }
        protected void lnkPickngden_Click(object sender, EventArgs e)
        {
            cldngden.Visible = true;
        }

        protected void lnkPickngdi_Click(object sender, EventArgs e)
        {
            cldngdi.Visible = true;
        }
        protected void cldngden_SelectionChanged(object sender, EventArgs e)
        {
            txtngayden.Text = cldngden.SelectedDate.Date.ToShortDateString();
            cldngden.Visible = false;
        }

        protected void cldngdi_SelectionChanged(object sender, EventArgs e)
        {
            txtngaydi.Text = cldngdi.SelectedDate.Date.ToShortDateString();
            cldngdi.Visible = false;
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
            Response.Redirect("ThongTinKH.aspx");
        }
    }
}