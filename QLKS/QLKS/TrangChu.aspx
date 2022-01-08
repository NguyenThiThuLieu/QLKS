<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="QLKS.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server"> 
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/> 
		<title>Trang chủ</title>
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
nav> ul li a{
    display: block;
    padding: 0 25px;
    line-height: 30px;
    color: #000000	;
    text-decoration: none;
    text-align: center;
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

		    .auto-style2 {
                height: 394px;
            }

		    .auto-style3 {
                height: 948px;
            }

		    .auto-style4 {
                width: 260px;
            }
            .auto-style5 {
                width: 236px;
            }

		    .auto-style6 {
                width: 225px;
            }
            .auto-style7 {
                width: 248px;
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

        <p class="auto-style3"> <br /><br /> Đề tài : Quản lý Khách sạn.<br /><br />Thành viên:<br />Nguyễn Thị Thu Liễu<br />Bùi Văn Tình<div class="auto-style2"> </div></p>  
    </form>
</body>
</html>
