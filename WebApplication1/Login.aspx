<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div style="height:100vh;background-color:#f8f0cc;">
            <div style="width:1280px; height:708px; margin:auto; background-image:url(Image/01.jpg)">
                <div style="padding-top:480px; padding-left:220px;">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="col-lg-3"></asp:TextBox>
                </div>
                <div style="padding-left:220px; padding-top:63px;">
                    <div>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="col-lg-3"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="LOGIN" CssClass="btn btn-primary" OnClick="Button1_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
