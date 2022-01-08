using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class PhongDat : System.Web.UI.Page
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
            string songuoi = Request.QueryString["songuoi"].ToString();
            string loai = Request.QueryString["loai"].ToString();
            PhuongThuc pt = new PhuongThuc();
            GridPD.DataSource = pt.GetPhong(loai, songuoi);
            GridPD.DataBind();
        }

        protected void btndangki_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }

        protected void GridPD_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhuongThuc pt = new PhuongThuc();
            int mkh = Int32.Parse(Request.QueryString["makh"].ToString());
            string ngden = Request.QueryString["ngayden"].ToString();
            string tt = Request.QueryString["thongtin"].ToString();
            string ngdi = Request.QueryString["ngaydi"].ToString();
            string songuoi = Request.QueryString["songuoi"].ToString();
            string loai = Request.QueryString["loai"].ToString();
            string maphong = GridPD.SelectedRow.Cells[0].Text;
            Phong ph = pt.GetUserPhong(maphong);
            float tiencoc = (ph.giaphong * 30) / 100;
            //int mkh = Int32.Parse(makh);
            DatPhong1 dp = new DatPhong1
            {
                makh = mkh,
                ngayden = ngden,
                ngaydi = ngdi,
                maphong = maphong,
                tiencoc = tiencoc,
            };
            bool exist = pt.CheckDatPhong(maphong, ngden, ngdi);
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
                    // laydulieulenGridview();
                }
                else
                {
                    lbltb.Text = "Đặt phòng không thành công";
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
            Response.Redirect("DatPhong.aspx");
        }
    }
}