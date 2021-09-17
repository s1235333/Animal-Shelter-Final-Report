using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["Animal_HouseConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            string sql = "Select * from PET_SIAZE where DATEDIFF(month,LEAVE_DATE, getdate()) >= 6 AND IS_ADOPT = 0 AND LEAVE_DATE <> ''";
            DataTable dt = new DataTable();

            SqlConnection sqlconn = new SqlConnection();
            SqlCommand sqlCmd = new SqlCommand(sql, sqlconn);

            sqlconn.ConnectionString = strCon;
            sqlconn.Open();

            SqlDataReader Sqldr = sqlCmd.ExecuteReader();
            dt.Load(Sqldr);
            Sqldr.Close();

            string s = string.Empty;
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    s += "編號：" + dt.Rows[i]["PET_NUM"].ToString() + "已離所半年,請致電給領養者追蹤提醒施打疫苗。";
                }
            }
            string sText = "<MARQUEE>" + s + "</MARQUEE>";

            Label1.Text = sText;
            
        }
    }
}