<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DSPhong.aspx.cs" Inherits="QLKS.DSPhong" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

v{
    margin: 5px 2%;
    text-align:center;
    background:#E0FFFF; 
   font-size:12px;
}
p { margin: 5px 2%;
    text-align:center;
    color:#006400;
    background:#E0FFFF; 
    font-size: 30px;
    border-radius: 5px;
}

		    *{
    margin: 0;
    padding: 0;
}
nav{
    /* canh giữa cách lề mỗi bên 2% */
    margin: 5px 2%;
}
nav{
    background: #87CEFA; /*tô màu cho menu cha*/
    /* bo góc */
}
nav ul li:first-child {
    border-left: none; /* bỏ đường kè trái của phần tử đầu tiên */
}
nav ul{
   
}

li{
    border-left: none; 
    list-style: none; /* bỏ dấu chấm mặc định của li */
    /* kẻ đường bên trái và bên phải của li */
  
}
nav> ul li a{
    display: block;
   
    line-height: 30px;
    color: #000000	;
   
    
}
aa{  text-decoration: none;
    text-align: center;
    font-size:20px;
    color: #000000	; 
    padding: 0 25px;
}
a{  text-decoration: none;
    text-align: center;
    font-size:20px;
    color: #000000	; 
    padding: 0 10px;
}
		    cot {
            text-align:center;
            width: 100px;
            height:30px;
        }
        .auto-style4 {
           text-align:right;
        }
		    		 
		    .auto-style8 {
            width: 124px;
        }
        .auto-style9 {
            width: 574px;
        }
		    		 
		    .auto-style10 {
            width: 1282px;
        }
        .auto-style11 {
            width: 39px;
        }
		    		 
		    </style>
</head>
<body>
    <form id="form2" runat="server">  
    <p class="auto-style2"> NOTHING HOTEL</p>
        <p class="auto-style4"> 
            <asp:LinkButton ID="linkThoat" runat="server" OnClick="linkThoat_Click">Đăng xuất</asp:LinkButton>
        </p>
    <nav>
        <ul>
        <table class="auto-style10">
            <tr>
               <td>  <li><a href="QLKhachSan.aspx" title="Trang chủ">Trang chủ</a></li></td>
               <td> <li><a href="KhachHang.aspx" title="Khách hàng">Khách Hàng</a></li> </td>
                 <td>  <li><a href="DSPhong.aspx" title="Phòng">Phòng</a></li> </td>
               <td>  <li><a href="ThuePhong.aspx" title="Thuê Phòng">Thuê phòng</a> </li> </td>
               <td>  <li><a href="DSDatPhong.aspx" title="DS Đặt Phòng">Đặt phòng</a> </li> </td>
               <td>  <li><a href="QLDV.aspx" title="Dịch vụ">Sử dụng dịch vụ</a></li> </td>
               <td>  <li><a href="QLNV.aspx" title="Nhân viên">Nhân viên</a></li> </td>
                <td>  <li><a href="DSDV.aspx" title="DSDV">Dịch vụ</a></li> </td>
                 <td>  <li><a href="HoaDon.aspx" title="Hóa đơn">Hóa đơn</a></li> </td>
             </tr>          
        </table></ul>
    </nav>  
  <p>
      
      <table class="auto-style2">
          <tr>

              <td class="auto-style11"  >
                  &nbsp;</td>

              <td colspan="3"  >
                  <a>&nbsp;&nbsp; </a>
                  <br />
                  <a>&nbsp;</a></td>

              <td colspan="3"  >
                  <a> <asp:TextBox ID="txttim" runat="server" Height="26px" Width="166px" AutoPostBack="True" CssClass="auto-style4"></asp:TextBox>
                  <asp:Button ID="Btntim" runat="server" Text="Tìm" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btntim_Click" />
                  <asp:Button ID="Btnall" runat="server" Text="Xem tất cả" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btnall_Click" /></a>
                  </td>

          </tr>
          <tr>
              <td class="auto-style11">
                  &nbsp;</td>
              <td class="auto-style8">
                  <a> Mã phòng</a></td>
              <td class="cot">
                  <asp:TextBox ID="txtmaph" runat="server" Height="25px" Width="170px"></asp:TextBox>
              </td>
              <td class="cot">
                  <a>  Loại phòng</a></td>
              <td class="cot">
                  <asp:TextBox ID="txtloai" runat="server" Height="25px" Width="118px"></asp:TextBox>
              </td>
              <td class="cot">
                  <a>Tên phòng</a></td>
              <td class="auto-style9">
                  <asp:TextBox ID="txtten" runat="server" Height="25px"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="auto-style11">
                  &nbsp;</td>
              <td class="cot">
                  <a>  Giá phòng</a></td>
              <td class="cot">
                  <asp:TextBox ID="txtgia" runat="server" Height="25px"></asp:TextBox>
              </td>
              <td class="cot" colspan="4">
                  <asp:FileUpload ID="FileUpload" runat="server" />
              </td>
          </tr>
          <tr>
              <td class="auto-style11">
                  &nbsp;</td>
              <td colspan="3">
                  &nbsp;</td>
              <td colspan="3">
                  <asp:Button ID="Btnluu" runat="server" Text="Lưu" BackColor="#FF99CC" Height="32px" Width="72px" OnClick="Btnluu_Click" />
                  <asp:Button ID="Btnmoi" runat="server" Text="Làm mới" BackColor="#FF99CC" Height="32px" Width="79px" OnClick="Btnmoi_Click" />
              </td>
          </tr>
          <tr>
              <td class="auto-style11">
                  &nbsp;</td>
              <td colspan="6">
                  <asp:Label ID="lbltb" runat="server" ForeColor="Red"></asp:Label>
              </td>
          </tr>
          <tr>
              <td class="auto-style11">
                  &nbsp;</td>
              <td colspan="6">
                  <a>  &nbsp;<asp:GridView ID="GridPH" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="1214px"  OnSelectedIndexChanged="GridPH_SelectedIndexChanged" Height="212px">
                      <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                      <Columns>
                          
                          <asp:BoundField DataField="MaPhong" HeaderText="Mã phòng" SortExpression="MaPhong" />
                          <asp:BoundField DataField="TenPhong" HeaderText="Tên Phòng" SortExpression="TenPhong" />
                          <asp:BoundField DataField="LoaiPhong" HeaderText="Loại" SortExpression="LoaiPhong" />
                          <asp:BoundField DataField="Gia" HeaderText="Giá" SortExpression="Gia" />
                          <asp:BoundField DataField="TrangThai" HeaderText="Trạng thái" SortExpression="TrangThai" />
                          <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="~/images/{0}" HeaderText="Hình ảnh">
                                  </asp:ImageField>
                          <asp:CommandField ShowSelectButton="True" SelectText="Chi tiết" />
                         
                      </Columns>
                      <EditRowStyle BackColor="#999999" />
                      <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                      <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                      <SortedAscendingCellStyle BackColor="#E9E7E2" />
                      <SortedAscendingHeaderStyle BackColor="#506C8C" />
                      <SortedDescendingCellStyle BackColor="#FFFDF8" />
                      <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                  </asp:GridView> </a></td>
          </tr>
          </table>
     
            </p>
    </form>
</body>
</html>

