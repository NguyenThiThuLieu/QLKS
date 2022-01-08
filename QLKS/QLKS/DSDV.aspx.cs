using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
	public partial class DSDV : System.Web.UI.Page
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
            GridDV.DataSource = pt.GetAllDV();
            GridDV.DataBind();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {
            string madv = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridDV.DataSource = pt.GetUserByDichVu(madv);
            GridDV.DataBind();

        }
        
        protected void GridDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madv = GridDV.SelectedRow.Cells[0].Text;
            string tendv = GridDV.SelectedRow.Cells[1].Text;
            float giadv = float.Parse(GridDV.SelectedRow.Cells[2].Text);
            PhuongThuc pt = new PhuongThuc();
            DichVu dv = pt.GetUserByDichVu(madv);
            txtmadv.Text = madv;
            txttendv.Text = dv.tendv;
            txtgiadv.Text = giadv.ToString();
        }
        
        public DichVu LaydulieutuForm()
        {
            string mdv = txtmadv.Text;
            string tdv = txttendv.Text;
            string gia = txtgiadv.Text;
            DichVu dv = new DichVu
            {
                madv=mdv,
                tendv=tdv,
                giadv=float.Parse(gia),
            };
            return dv;
        }
        protected void GridKH_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string madv = GridDV.Rows[e.RowIndex].Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteDV(madv);
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
            txtmadv.Text = "";
            txttendv.Text = "";
            txtgiadv.Text = "";
            txttim.Text = "";
            lbltb.Text = "";
            txtmadv.Focus();
            laydulieulenGridview();
        }

        protected void Btnluu_Click(object sender, EventArgs e)
        {
            DichVu dv = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckDV(dv.madv);
            if (exist)
            {
                bool result = pt.UpdateDV(dv);
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
                bool result = pt.InsertDV(dv);
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
        }

        protected void Btnall_Click(object sender, EventArgs e)
        {
            laydulieulenGridview();
        }

        protected void linkThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrangChu.aspx");
        }

        protected void GridDV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string madv = GridDV.Rows[e.RowIndex].Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            bool result = pt.DeleteDV(madv);
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