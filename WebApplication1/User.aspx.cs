using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class User : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["Animal_HouseConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlDataSource conn = new SqlDataSource();
            //conn.ConnectionString = strCon;
            //conn.SelectCommand = "Select * from USER_ACC";
            //DataView dv = (DataView)conn.Select(DataSourceSelectArguments.Empty);

            //GridView1.DataSource = dv;
            //GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "EditCommand")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int ID = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);

                Server.Transfer("User_Detail.aspx?ID="+ ID + "&Type=E");
            }
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("User_Detail.aspx?Type=A");
        }
    }
}