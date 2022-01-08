using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKS
{
    public partial class DSPhong : System.Web.UI.Page
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
            GridPH.DataSource = pt.GetAllPhong();
            GridPH.DataBind();
        }

        protected void Btntim_Click(object sender, EventArgs e)
        {
            string maph = txttim.Text;
            PhuongThuc pt = new PhuongThuc();
            GridPH.DataSource = pt.GetPhong(maph);
            GridPH.DataBind();
        }

        protected void GridPH_SelectedIndexChanged(object sender, EventArgs e)
        {
           string maph = GridPH.SelectedRow.Cells[0].Text;
            PhuongThuc pt = new PhuongThuc();
            Phong ph = pt.GetUserPhong(maph);
            txtmaph.Text = maph;
            txtten.Text = ph.tenphong;
            txtloai.Text = ph.loaiphong;
            txtgia.Text = ph.giaphong.ToString();
        }
        
        public Phong LaydulieutuForm()
        {
            string ten = txtten.Text;
            string ma = txtmaph.Text;
            string loai = txtloai.Text;
            string gia = txtgia.Text;
            string ex = System.IO.Path.GetExtension(FileUpload.FileName);
            string tenhinh = ma + ex;
            Phong ph = new Phong
            {
                maphong = ma,
                tenphong = ten,
                loaiphong = loai,
                giaphong = float.Parse(gia),
                trangthai = false,
                hinhanh= tenhinh,
            };
            return ph;
        }
        protected void Btnmoi_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            lbltb.Text = "";
            txtmaph.Text = "";
            txtten.Text = "";
            txtgia.Text = "";
            txtloai.Text = "";
            txtmaph.Focus();
            laydulieulenGridview();
        }

        private void TaiAnh(string tenhinh)
        {
            String filePath = "~/images/" + tenhinh;
            if (FileUpload.HasFile)
            {
                FileUpload.SaveAs(Server.MapPath(filePath));
            }    
        }
        protected void Btnluu_Click(object sender, EventArgs e)
        {
            Phong ph = LaydulieutuForm();
            PhuongThuc pt = new PhuongThuc();
            bool exist = pt.CheckPhong(ph.maphong);
            if (exist)
            {
                bool result = pt.UpdatePHONG(ph);
                TaiAnh(ph.hinhanh);
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
                bool result = pt.InsertPhong(ph);
                TaiAnh(ph.hinhanh);
                if (result)
                {
                    lbltb.Text = "Thêm một phòng mới thành công ! ";
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


    }
}