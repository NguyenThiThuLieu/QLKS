<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="QLKS.HoaDon1" %>

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
a{  text-decoration: none;
    text-align: center;
    font-size:20px;
    color: #000000	; 
    padding: 0 10px;
}
		    cot {
            
            width: 100px;
            height:30px;
        }
       
		    		 
		    .auto-style2 {
           text-align: right;
        }
        .auto-style6 {
            width: 1225px;
        }
		    		 
		    .auto-style7 {
            width: 134px;
        }
		    		 
		    .auto-style8 {
            text-align: right;
            width: 1287px;
        }
		    		 
		    </style>
</head>
<body>
    <form id="form2" runat="server">  
    <p> NOTHING HOTEL</p>
        <p class="auto-style2"> 
            <asp:LinkButton ID="linkThoat" runat="server" OnClick="linkThoat_Click">Đăng xuất</asp:LinkButton>
        </p>
    <nav>
        <ul>
        <table class="auto-style8">
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
      
      <table class="auto-style6">
          <tr>
              <td class="auto-style7" rowspan="2">
                  &nbsp;</td>

              <td  >
                  <a>Nhập CMND<asp:TextBox ID="txttim" runat="server" Height="26px" Width="166px" AutoPostBack="True" CssClass="auto-style4"></asp:TextBox>
                  <asp:Button ID="Btntim" runat="server" Text="Tìm" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btntim_Click" />
                  <asp:Button ID="Btnall" runat="server" Text="Xem tất cả" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btnall_Click" /></a>
              </td>

          </tr>
          <tr>
              <td class="cot">
                  <a>   <asp:GridView ID="GridHD" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="881px" Height="212px" OnRowDeleting="GridHD_RowDeleting">
                      <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                      <Columns>
                          <asp:BoundField DataField="MaHD" HeaderText="Mã HD" SortExpression="MaHD" />
                          <asp:BoundField DataField="MaKH" HeaderText="Mã KH" SortExpression="MaKH" />
                          <asp:BoundField DataField="HoTen" HeaderText="Tên KH" SortExpression="HoTen" />
                          <asp:BoundField DataField="MaPhong" HeaderText="Mã phòng" SortExpression="MaPhong" />
                          <asp:BoundField DataField="NgayDen" HeaderText="Ngày đến" SortExpression="NgayDen" DataFormatString="{0:MM/dd/yyyy}" />
                          <asp:BoundField DataField="NgayDi" HeaderText="Ngày đi" SortExpression="NgayDi" DataFormatString="{0:MM/dd/yyyy}" />
                           <asp:BoundField DataField="ThanhTien" HeaderText="Thành tiền" SortExpression="ThanhTien" />
                          <asp:BoundField DataField="TrangThai" HeaderText="Trạng thái" SortExpression="TrangThai" />
                         
                          <asp:CommandField ShowDeleteButton="True" />
                         
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
                  </asp:GridView> </a>
              </td>
          </tr>
          </table>
     
            </p>
    </form>
</body>
</html>
