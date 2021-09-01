using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class User_Detail : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["Animal_HouseConnectionString"].ConnectionString;
        string sID = string.Empty;
        string sType = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            sID = Request.QueryString["ID"];
            sType = Request.QueryString["Type"];

            if (!IsPostBack)//如果不是用PostBack回來的話
            {
                if (sType == "A")
                {
                    TextBox1.Text = string.Empty;
                    TextBox2.Text = string.Empty;
                    TextBox5.Text = string.Empty;

                    TextBox1.ReadOnly = false;
                    TextBox2.ReadOnly = false;
                    TextBox5.ReadOnly = false;

                    Button2.Text = "新增帳號";
                    Button3.Visible = false;

                    Label6.Text = "員工編號";
                    Label2.Text = "姓名";
                    Label3.Text = "帳號";
                    Label4.Text = "密碼";
                    row.Visible = false;
                }
                else
                {
                    string sql = "Select * From USER_ACC where ID = " + sID;
                    DataTable dt = new DataTable();

                    SqlConnection sqlconn = new SqlConnection();
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlconn);

                    sqlconn.ConnectionString = strCon;
                    sqlconn.Open();

                    SqlDataReader Sqldr = sqlCmd.ExecuteReader();
                    dt.Load(Sqldr);
                    Sqldr.Close();

                    TextBox1.Text = dt.Rows[0]["USER_NAME"].ToString();
                    TextBox2.Text = dt.Rows[0]["ACCOUNT"].ToString();
                    TextBox5.Text = dt.Rows[0]["PASSWORD"].ToString();

                    TextBox1.ReadOnly = true;
                    TextBox2.ReadOnly = true;
                    TextBox5.ReadOnly = true;

                    Button2.Text = "密碼變更";
                    Button3.Visible = true;

                    Label6.Text = "姓名";
                    Label2.Text = "帳號";
                    Label3.Text = "原密碼";
                    Label4.Text = "新密碼";
                    Label5.Text = "確認密碼";
                    row.Visible = true;


                    sqlCmd.Cancel();
                    sqlconn.Close();
                    sqlconn.Dispose();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if(sType == "A")
            {
                string strIns = @"Insert into USER_ACC(USER_NUM, USER_NAME, ACCOUNT, PASSWORD) values(@USER_NUM, @USER_NAME, @ACCOUNT, @PASSWORD)";
                SqlConnection sqlconn = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand(strIns, sqlconn);
                sqlconn.ConnectionString = strCon;
                sqlconn.Open();

                sqlCmd.Parameters.AddWithValue("@USER_NUM", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@USER_NAME", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@ACCOUNT", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@PASSWORD", TextBox3.Text);

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Cancel();
                sqlconn.Close();
                sqlconn.Dispose();

                Server.Transfer("User.aspx");
            }
            else
            {
                if (TextBox3.Text != TextBox4.Text)
                {
                    Response.Write("<script language='javascript'>alert('新密碼與確認密碼不同，請重新輸入。')</script>");
                    //return;
                }
                else
                {
                    string strUp = @"Update USER_ACC SET PASSWORD = @PASSWORD where ID = @ID";
                    SqlConnection sqlconn = new SqlConnection();
                    SqlCommand sqlCmd = new SqlCommand(strUp, sqlconn);
                    sqlconn.ConnectionString = strCon;
                    sqlconn.Open();

                    sqlCmd.Parameters.AddWithValue("@PASSWORD", TextBox3.Text);
                    sqlCmd.Parameters.AddWithValue("@ID", sID);

                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Cancel();
                    sqlconn.Close();
                    sqlconn.Dispose();

                    Server.Transfer("User.aspx");
                }
            }

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string strDel = @"Delete USER_ACC where ID = @ID";
            SqlConnection sqlconn = new SqlConnection();
            SqlCommand sqlCmd = new SqlCommand(strDel, sqlconn);
            sqlconn.ConnectionString = strCon;
            sqlconn.Open();

            sqlCmd.Parameters.AddWithValue("@ID", sID);

            sqlCmd.ExecuteNonQuery();
            sqlCmd.Cancel();
            sqlconn.Close();
            sqlconn.Dispose();

            Server.Transfer("User.aspx");
        }
    }
}