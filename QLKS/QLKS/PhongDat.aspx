<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhongDat.aspx.cs" Inherits="QLKS.PhongDat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server"> 
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/> 
		<title>Đặt phòng</title>
		<link href="style/css/login1.css" rel="stylesheet" type="text/css"/>
		<style>
			.bg{
				background-attachment: fixed;
				background-image: url("style/img/vinbusbglogin1.jpg");
				background-repeat: no-repeat; 
				background-size: cover;
				overflow: scroll;
			}
            *{
    margin: 0;
    padding: 0;
}
header, nav{
    /* canh giữa cách lề mỗi bên 2% */
    margin: 5px 2%;
}
nav{
    background: #87CEFA; /*tô màu cho menu cha*/
    border-radius: 5px; /* bo góc */
}
nav ul{
    display: flex;
}
nav> ul li{
    list-style: none; /* bỏ dấu chấm mặc định của li */
    /* kẻ đường bên trái và bên phải của li */
    border-right: 1px solid #ccc;
    border-left:1px solid #333;
}
 a{
    display: block;
    padding: 0 25px;
    line-height: 30px;
    color: #000000	;
    text-decoration: none;
    text-align: center;
    font-size:20px;
}
nav ul li:first-child {
    border-left: none; /* bỏ đường kè trái của phần tử đầu tiên */
}

/* Khi hover đến li, tô màu cho thẻ a */
nav ul li:hover>a{
    background: red;
    opacity: .7;
    color: yellow;
}
/*menu con*/

nav li>ul li{
    width: 30%;
    border: none;
    border-bottom: 1px solid #ccc;
    background: #999;
    text-align: left;
}
.auto-style1 {
      width: 100%;
     }
p { margin: 5px 2%;
    color:#006400;
    text-align:center;
    font-size: 30px;
    background:#E0FFFF;
}
 b{
    color: orangered	;
    text-align: center;
    font-size:15px;
 }

		    .auto-style2 {
               text-align:left;
            }
            .auto-style3 {
                width: 86px;
            }

		    .auto-style4 {
                margin-bottom: 0;
            }

		    </style>
	</head> 
<body>
   
    <form id="form1" runat="server">
   
    <p> NOTHING HOTEL</p>
        <nav>
    <ul> 
        <table class="auto-style1">
            <tr>
               <td>  <li><a href="TrangChu.aspx" title="Trang chủ">Trang chủ</a></li></td>
              
               <td>  <li><a href="DangNhap.aspx" title="Đăng nhập">Đăng nhập</a></li> </td>
               <td>  <li><a href="ThongTinKH.aspx?thongtin=tc" title="">Đặt Phòng</a> </li> </td>
                
             </tr>          
        </table>
    </ul>
    </nav>  
        <p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
        <asp:LinkButton ID="LinkCancel" runat="server" Width="78px" OnClick="LinkCancel_Click" CssClass="auto-style4">< Trở lại</asp:LinkButton>
                    </td>
                    <td colspan="5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td colspan="5">
                        <asp:Label ID="lbltb" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td colspan="5">
                        <p><a class="auto-style2"><asp:GridView ID="GridPD" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="814px" OnSelectedIndexChanged="GridPD_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="MaPhong" HeaderText="Mã phòng" SortExpression="MaPhong" />
                                <asp:BoundField DataField="TenPhong" HeaderText="Tên phòng" SortExpression="TenPhong" />
                                <asp:BoundField DataField="Gia" HeaderText="Giá phòng" SortExpression="Gia" />
                                <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="~/images/{0}" HeaderText="Hình ảnh">
                                   
                                </asp:ImageField>
                                <asp:CommandField ShowSelectButton="True" />
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
                        </asp:GridView></a></p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btndangki" runat="server" Height="36px" Text="Xong" Width="95px" OnClick="btndangki_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>

