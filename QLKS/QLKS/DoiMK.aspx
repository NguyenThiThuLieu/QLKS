<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoiMK.aspx.cs" Inherits="QLKS.DoiMK" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

p { margin: 5px 2%;
    color:#006400;
    text-align:center;
    font-size: 30px;
    background:#E0FFFF;
}

		    *{
    margin: 0;
    padding: 0;
}
nav{
    background: #87CEFA; /*tô màu cho menu cha*/
    border-radius: 5px; /* bo góc */
}
nav{
    /* canh giữa cách lề mỗi bên 2% */
    margin: 5px 2%;
}
nav ul{
    display: flex;
}
nav ul li:first-child {
    border-left: none; /* bỏ đường kè trái của phần tử đầu tiên */
}

nav> ul li{
    list-style: none; /* bỏ dấu chấm mặc định của li */
    /* kẻ đường bên trái và bên phải của li */
    border-right: 1px solid #ccc;
    border-left:1px solid #333;
}
a{
    font-size:20px;
    display: block;
    padding: 0 25px;
    line-height: 30px;
    color: #000000	;
    text-decoration: none;
    text-align: center;
}

		    .auto-style4 {
            width: 78%;
            height: 187px;
        }
        .auto-style5 {
            height: 31px;
        }
        .auto-style6 {
            width: 243px;
        }
        .auto-style7 {
            height: 31px;
            width: 243px;
        }
        .auto-style11 {
            width: 243px;
            height: 35px;
        }
        .auto-style12 {
            height: 35px;
        }
        .auto-style13 {
            height: 35px;
            width: 379px;
        }
        .auto-style14 {
            height: 31px;
            width: 379px;
        }
        .auto-style15 {
            width: 379px;
        }
        .auto-style16 {
            width: 373px;
        }
        .auto-style18 {
            width: 351px;
        }
        .auto-style19 {
            width: 356px;
        }
        .auto-style20 {
            width: 1141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">  
    <p> NOTHING HOTEL</p>  
               <nav>
             <ul> 
        <table class="auto-style20">
            <tr>
               <td class="auto-style19">  <li><a href="TrangChu.aspx" title="Trang chủ">Trang chủ</a></li></td>
              
               <td class="auto-style18">  <li><a href="DangNhap.aspx" title="Đăng nhập">Đăng nhập</a></li> </td>
               <td class="auto-style16">  <li><a href="ThongTinKH.aspx?thongtin=tc" title="">Đặt Phòng</a> </li> </td>
              
               
             </tr>          
        </table>
    </ul>
    </nav>  
        <p>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style11">
                        <a>Mã nhân viên</a></td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtmanv" runat="server" Height="25px" Width="183px" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                      <a> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nhập mã nhân viên" ControlToValidate="txtmanv" ForeColor="#FF3300">*</asp:RequiredFieldValidator></a> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <a>Mật khẩu hiện tại</a></td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtmatkhau" runat="server" Height="26px" Width="182px" TextMode="Password" CausesValidation="True"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                      <a> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nhập mật khẩu" ForeColor="#FF3300" ControlToValidate="txtmatkhau">*</asp:RequiredFieldValidator></a> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <a>Mật khẩu mới</a></td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtmatkhaunew" runat="server" Height="26px" Width="182px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                      <a> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Nhập mật khẩu mới" ForeColor="#FF3300" ControlToValidate="txtmatkhaunew">*</asp:RequiredFieldValidator></a> 
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <a>Nhập lại mật khẩu </a></td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtnewagain" runat="server" Height="26px" Width="182px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                      <a> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Nhập mật khẩu" ForeColor="#FF3300" ControlToValidate="txtnewagain">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtmatkhaunew" ControlToValidate="txtnewagain" ErrorMessage="Mật khẩu không khớp" ForeColor="Red">*</asp:CompareValidator>
                        </a> 
                    </td>
                </tr>
                <tr>
                    <td>
                       <a> <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" /></a>
                    </td>
                    <td>
                        <asp:Button ID="btndoimk" runat="server" Text="Đổi mật khẩu" Width="122px" OnClick="btndoimk_Click" Height="37px" />
                    </td>
                    <td>
                      <a>  <asp:Label ID="lbltb" runat="server" ForeColor="Red"></asp:Label></a>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style15">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table></p>
    </form>
</body>
</html>
