<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Pet.aspx.cs" Inherits="WebApplication1.Pet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%@ Import namespace="System.Data.SqlClient"%>
<%@ Import namespace="System.Data"%>
<%@ Import namespace="System.Configuration"%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="row">

            <%

                    string strCon = ConfigurationManager.ConnectionStrings["Animal_HouseConnectionString"].ConnectionString;
                    string sql = "Select * From USER_ACC where ID = ";
                    DataTable dt = new DataTable();
                    SqlConnection sqlconn = new SqlConnection();
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlconn);

                    sqlconn.ConnectionString = strCon;
                    sqlconn.Open();

                    SqlDataReader Sqldr = sqlCmd.ExecuteReader();
                    dt.Load(Sqldr);
                    Sqldr.Close();
                %>
                <%
                    if(dt.Rows.Count > 0)
                    {
                        for(int i = 0; i < dt.Rows.Count; i++)
                        {
                            string sType = dt.Rows[i]["PET_TYPE"].ToString();
                            string sPET_VARIETY = dt.Rows[i]["PET_VARIETY"].ToString();
                            string sSEX = dt.Rows[i]["PET_SEX"].ToString();

                            if(sType == "0")
                            {
                                sType = "狗";
                            }
                            else
                            {
                                sType = "貓";
                            }

                            if(sSEX == "0")
                            {
                                sType = "公";
                            }
                            else
                            {
                                sType = "母";
                            }
                %>
                            <div style="width:230px;">
                                <div style="width:160px; margin:auto auto;">
                                    <img src="Image/02.jpg" />
                                </div>
                                <div>
                                    <div><asp:Label ID="Label1" runat="server" Text="類別：<%=sType %>"></asp:Label></div>
                                    <div><asp:Label ID="Label2" runat="server" Text="品種：<%=sPET_VARIETY %>"></asp:Label></div>
                                    <div><asp:Label ID="Label3" runat="server" Text="性別：<%=sSEX %>"></asp:Label></div>
                                </div>
                            </div>

                <%
                        }
                    }
                %>

            
        </div>
    </div>
</asp:Content>
