<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatPhong.aspx.cs" Inherits="QLKS.DatPhong" %>

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

		    .auto-style1 {
                width: 1067px;
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
               <td class="cot">  <li><a href="ThongTinKH.aspx?thongtin=tc" title="">Đặt Phòng</a> </li> </td>
                    
             </tr>          
        </table>
    </ul>
    </nav>  
        <p>
            <table style="width:100%;">
                <tr>
                    <td>
         <asp:LinkButton ID="LinkCancel" runat="server" Width="78px" OnClick="LinkCancel_Click">< Trở lại</asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><a>Số người</a></td>
                    <td>
                        <asp:DropDownList ID="Dropsonguoi" runat="server" Height="30px" Width="134px" AutoPostBack="True">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <a>Loại phòng</a></td>
                    <td>
                        <asp:DropDownList ID="Droploai" runat="server"  Height="30px" Width="101px" AutoPostBack="True">
                            <asp:ListItem Value="V%">VIP</asp:ListItem>
                            <asp:ListItem Value="F%">Thường</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><a>Ngày đến</a></td>
                    <td>
                       <asp:TextBox ID="txtngayden" runat="server"  Height="24px" Width="134px" AutoPostBack="True" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkPickngden" runat ="server" OnClick="lnkPickngden_Click" Width="17px">...</asp:LinkButton>
                    </td>
                    <td>
                        <a>Ngày đi</a></td>
                    <td>
                        <asp:TextBox ID="txtngaydi" runat="server" Height="24px" Width="134px" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td>
                          <asp:LinkButton ID="LinkPickngdi" runat ="server" OnClick="lnkPickngdi_Click" Width="34px">...</asp:LinkButton>
                    </td>
                    <td rowspan="2">
                       <b> Định dạng: Tháng/Ngày/Năm</b></td>
                    <td colspan="2" rowspan="2">
                        &nbsp;</td>
                    <td rowspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">
                       <asp:Calendar ID="cldngden" runat="server" Visible="False" OnSelectionChanged="cldngden_SelectionChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                           <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                           <NextPrevStyle VerticalAlign="Bottom" />
                           <OtherMonthDayStyle ForeColor="#808080" />
                           <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                           <SelectorStyle BackColor="#CCCCCC" />
                           <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                           <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                           <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Calendar ID="cldngdi" runat="server" Visible="false" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="cldngdi_SelectionChanged">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="4">
                        <asp:Button ID="btndangki" runat="server" Height="36px" Text="Đăng ký" Width="95px" OnClick="btndangki_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                       <b> <asp:Label ID="lbltb" runat="server"></asp:Label></b>
                    </td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="8">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
