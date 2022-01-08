<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="QLKS.KhachHang1" %>

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
  .auto-style2 {
           text-align: right;
        }
		    cot {
            
            width: 100px;
            height:30px;
        }
        .auto-style4 {
            width: 90px;
        }
		    		 
		    .auto-style5 {
            text-align: right;
            width: 1285px;
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
        <table class="auto-style5">
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
      
      <table>
          <tr>
              <td></td>
              <td  >
                  <br />
              </td>

              <td  >
                  <a>Nhập thông tin&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txttim" runat="server" Height="26px" Width="166px" AutoPostBack="True" CssClass="auto-style4"></asp:TextBox>
                  <asp:Button ID="Btntim" runat="server" Text="Tìm" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btntim_Click" />
                  <asp:Button ID="Btnall" runat="server" Text="Xem tất cả" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btnall_Click" />
                  <asp:Button ID="BtnVip" runat="server" Text="Vip" BackColor="#FF9999" Height="32px" Width="72px" OnClick="Btnvip_Click" /></a>
              </td>

          </tr>
          <tr>
              <td class="cot">
                  <a> Mã khách hàng</a></td>
              <td>
                  <asp:TextBox ID="txtmakh" runat="server" Height="25px"></asp:TextBox>
              </td>
              <td class="cot" rowspan="7">
                  <a>   <asp:GridView ID="GridKH" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="979px" OnRowDeleting="GridKH_RowDeleting" OnSelectedIndexChanged="GridKH_SelectedIndexChanged" Height="212px">
                      <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                      <Columns>
                          <asp:BoundField DataField="MaKH" HeaderText="Mã khách hàng" SortExpression="MaKH" />
                          <asp:BoundField DataField="HoTen" HeaderText="Họ và tên" SortExpression="HoTen" />
                          <asp:BoundField DataField="CMND" HeaderText="CMND" SortExpression="CMND" />
                          <asp:BoundField DataField="SDT" HeaderText="Số điện thoại" SortExpression="SDT" />
                          <asp:BoundField DataField="QuocTich" HeaderText="Quốc tịch" SortExpression="QuocTich" />
                          <asp:BoundField DataField="VIP" HeaderText="VIP" SortExpression="VIP" />
                          <asp:CommandField ShowSelectButton="True" />
                          <asp:CommandField ShowDeleteButton="True"  />
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
          <tr>
              <td class="cot">
                <a> Họ và tên</a> </td>
              <td class="cot">
                  <asp:TextBox ID="txtht" runat="server" Height="25px"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="cot">
                <a>  CMND</a> </td>
              <td class="cot">
                  <asp:TextBox ID="txtcmnd" runat="server" Height="25px" ></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="cot">
                  <a> Số điện thoại</a> </td>
              <td class="cot">
                  <asp:TextBox ID="txtsdt" runat="server" Height="25px"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="cot">
                 <a> Quốc tịch</a> </td>
              <td class="cot">
                  <asp:TextBox ID="txtqt" runat="server" Height="25px"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="cot" colspan="2">
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Btnthem" runat="server" Text="Thêm" BackColor="#FF99CC" Height="32px" Width="72px" OnClick="Btnthem_Click" />
                  &nbsp;<asp:Button ID="Btnmoi" runat="server" Text="Làm mới" BackColor="#FF99CC" Height="32px" Width="79px" OnClick="Btnmoi_Click" />
                  <asp:Button ID="Btnluu" runat="server" Text="Lưu" BackColor="#FF99CC" Height="32px" Width="72px" OnClick="Btnluu_Click" />
              </td>
          </tr>
          <tr>
              <td class="cot" colspan="2">
                  <asp:Label ID="lbltb" runat="server" ForeColor="Red"></asp:Label>
              </td>
          </tr>
          </table>
     
            </p>
    </form>
</body>
</html>
