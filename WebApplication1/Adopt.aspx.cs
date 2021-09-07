using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Adopt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Adopt_Detail.aspx?Type=A");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Adopt.aspx?Text=" + TextBox1.Text);
        }
    }
}