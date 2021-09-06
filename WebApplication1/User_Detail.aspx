<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="User_Detail.aspx.cs" Inherits="WebApplication1.User_Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:auto auto; height:100vh; background-color:#f8f0cc;">
        <div style="margin:auto auto; width:600px; background-color:#f8f0cc;">
            <div>
                <asp:Label ID="Label1" runat="server" Text="使用者（員工）管理"></asp:Label>
            </div>
            <div>
                <asp:Table ID="Table1" runat="server" CellPadding="0" CellSpacing="0" CssClass="table">
                    <asp:TableHeaderRow>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></asp:TableCell>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></asp:TableCell>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></asp:TableCell>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></asp:TableCell>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="row" runat="server">
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></asp:TableCell>
                        <asp:TableCell BorderStyle="Solid" BorderColor="Black" BorderWidth="1"><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
            <div class="row">
                <div style="width:150px; float:left;">
                    <asp:Button ID="Button2" runat="server" Text="密碼變更" OnClick="Button2_Click" CssClass="btn btn-primary" />
                </div>
                <div style="width:150px; float:left;">
                    <asp:Button ID="Button3" runat="server" Text="刪除帳號" OnClick="Button3_Click" CssClass="btn btn-warning"/>
                </div>
            </div>
        </div>
    </div>
    
    
</asp:Content>
