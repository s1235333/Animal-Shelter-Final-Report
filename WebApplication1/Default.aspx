<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#div01").hide();
        });
    </script>
    <div class="container" style="background-color:#f8f0cc; height:100vh;" >
        <div style="width:1125px; margin:auto auto;">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <div style="width:1125px; margin:auto auto;">
            <div style="width:373px; height:650px; float:left;">
                <div style="margin:50% 8%; float:left;">
                    <a href="Pet.aspx"><img src="Image/05.jpg"/></a>
                </div>
            </div>
            <div style="width:373px; height:650px; float:left;">
                <div style="margin:50% 8%; float:left;">
                    <a href="Adopt.aspx"><img src="Image/06.jpg"/></a>
                </div>
            </div>
            <div style="width:373px; height:650px; float:left;"">
                
                <div style="margin:50% 8%; float:left;"" >
                    <a href="User.aspx"><img src="Image/07.jpg"/></a>
                </div>
            </div>
        </div>
    </div>
    
    
</asp:Content>
