<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinKH.aspx.cs" Inherits="QLKS.ThongTinKH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server"> 
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/> 
		<title>BusMap | Đăng nhập</title>
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

		    .auto-style2 {
                width: 160px;
            }
            .auto-style3 {
                width: 121px;
            }
            .auto-style4 {
                width: 160px;
                height: 36px;
            }
            .auto-style5 {
                width: 121px;
                height: 36px;
            }
            .auto-style6 {
                height: 36px;
            }
            .auto-style7 {
                text-align:left;
            }
            .auto-style8 {
                height: 36px;
                width: 50px;
            }
             .auto-style2 {
           text-align: right;
        }
		    .auto-style12 {
                width: 318px;
            }
            .auto-style13 {
                width: 306px;
            }
            .auto-style15 {
                width: 260px;
            }
		    .auto-style17 {
                width: 292px;
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
               <td class="auto-style15">  <li><a href="TrangChu.aspx" title="Trang chủ" class="auto-style17">Trang chủ</a></li></td>
               
               <td>  <li><a href="DangNhap.aspx" title="Đăng nhập" class="auto-style12">Đăng nhập</a></li> </td>
               <td>  <li><a href="ThongTinKH.aspx?thongtin=tc" title="" class="auto-style13">Đặt Phòng</a> </li> </td>
                       
             </tr>          
        </table>
    </ul>
    </nav>  

        <p>
            <table style="width:100%;">
                <tr>
                   <td colspan="3">
            <asp:LinkButton ID="LinkCancel" runat="server" Width="78px" OnClick="LinkCancel_Click">< Trở lại</asp:LinkButton> 
                    </td>
                   <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                   <td colspan="6"><p>Nhập thông tin khách hàng</p></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2"><a>Họ tên</a></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txthoten" runat="server" AutoPostBack="True" Height="26px" Width="164px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txthoten" ErrorMessage="Nhập họ tên" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2"><a>CMND</a></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtcmnd" runat="server" AutoPostBack="True" Height="26px" Width="164px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcmnd" ErrorMessage="Nhập CMND" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2"><a>Số điện thoại</a></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtsdt" runat="server" AutoPostBack="True" Height="26px" Width="164px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtsdt" ErrorMessage="Nhập số điện thoại" Font-Size="Large" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2"><a>Quốc tịch</a></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtquoctich" runat="server" AutoPostBack="True" Height="26px" Width="164px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style4">
                      <a>  <asp:Label ID="lbltb" runat="server" ForeColor="Red"></asp:Label></a>
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btntieptheo" runat="server" Text="Tiếp theo" OnClick="btntieptheo_Click" Height="37px" Width="94px" />
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style6"></td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
