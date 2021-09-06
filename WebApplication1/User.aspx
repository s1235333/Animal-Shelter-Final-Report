<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="WebApplication1.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="height:100vh; background-color:#f8f0cc;">
        <div>
            <asp:Label ID="Label1" runat="server" Text="使用者（員工）管理"></asp:Label>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand" OnRowCreated="GridView1_RowCreated" CssClass="table">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="USER_NUM" HeaderText="員工編號" SortExpression="USER_NUM" />
                    <asp:BoundField DataField="USER_NAME" HeaderText="姓名" SortExpression="USER_NAME" />
                    <asp:BoundField DataField="ACCOUNT" HeaderText="帳號" SortExpression="ACCOUNT" />
                    <asp:BoundField HeaderText="密碼" DataField="PASSWORD" SortExpression="PASSWORD" />
                    <asp:ButtonField CausesValidation="True" CommandName="EditCommand" Text="Edit" />
                </Columns>
            </asp:GridView>
        </div>
        <div style="width:100px; padding-left:250px; padding-top:25px; float:right;">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
        
    </div>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Animal_HouseConnectionString %>" SelectCommand="SELECT * FROM [USER_ACC]"></asp:SqlDataSource>
</asp:Content>
