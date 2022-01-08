using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class HoaDon1 : System.Web.UI.Page
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
            GridHD.DataSource = pt.GetAllHoadon();
            GridHD.DataBind();
        }
        protected void Btntim_Click(object sender, EventArgs e)
        {
            string cmnd = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridHD.DataSource = pt.GetHoadon(cmnd);
            GridHD.DataBind();
        }
        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
        }
        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }
        protected void GridHD_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int mhd = Int32.Parse(GridHD.Rows[e.RowIndex].Cells[0].Text);
            int makh = Int32.Parse(GridHD.Rows[e.RowIndex].Cells[1].Text);
            string maph = GridHD.Rows[e.RowIndex].Cells[3].Text;
            string ngden = GridHD.Rows[e.RowIndex].Cells[4].Text;
            string ngdi = GridHD.Rows[e.RowIndex].Cells[5].Text;
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.DeleteHD(mhd);
            if (exist)
            {
                pt.UpdateTTPhong(maph, true);
                pt.UpdateTTThuePhong(maph, false, makh, ngden, ngdi);
                laydulieulenGridview();
            }    
        }
    }
}