<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Pet_Detail.aspx.cs" Inherits="WebApplication1.Pet_Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="width:510px; float:left; margin:auto 20px;">
            <div>
                <div style="margin:auto auto; width:100px;"><asp:Label ID="Label1" runat="server" Text="002"></asp:Label></div>
                <div style="margin:auto auto; width:200px;"><asp:Image ID="Image1" runat="server" ImageUrl="Image/03.jpg" /></div>
            </div>
            <div style="padding-left:160px; margin-top:30px;">
                <div style="margin:auto auto; width:100px; float:left;">
                    <asp:Button ID="Button1" runat="server" Text="編輯" OnClick="Button1_Click" />
                    <asp:Button ID="Button4" runat="server" Text="儲存" OnClick="Button4_Click" style="height: 27px" />
                </div>
                <div style="margin:auto auto; width:100px; float:left;"><asp:Button ID="Button2" runat="server" Text="刪除" OnClick="Button2_Click" /></div>
            </div>
            <div style="padding-left:160px; margin-top:30px;">
                <asp:Button ID="Button3" runat="server" Text="返回列表頁" />
            </div>
        </div>
        <div style="width:510px; float:left; margin:auto 20px;">
            <div>
                <table>
                    <tr>
                        <td>品種：</td>
                        <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>類別：</td>
                        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>體重：</td>
                        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>性別：</td>
                        <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>毛色：</td>
                        <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>年齡：</td>
                        <td><asp:TextBox ID="TextBox6" runat="server" Height="23px"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>編號：</td>
                        <td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>進所日期：</td>
                        <td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
            <div style="margin:20px auto;">
                <table>
                    <tr>
                        <td>個性行為：</td>
                        <td><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>結扎與否：</td>
                        <td><asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>疫苗施打：</td>
                        <td><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>驅蟲與否：</td>
                        <td><asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
