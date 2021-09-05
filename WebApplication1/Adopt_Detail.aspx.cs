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
    public partial class Adopt_Detail : System.Web.UI.Page
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
                    setControl_Add();
                }
                else
                {
                    setControl_Edit();

                    string sql = "Select * From ADOPTERS where ID = " + sID;
                    DataTable dt = new DataTable();

                    SqlConnection sqlconn = new SqlConnection();
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlconn);

                    sqlconn.ConnectionString = strCon;
                    sqlconn.Open();

                    SqlDataReader Sqldr = sqlCmd.ExecuteReader();
                    dt.Load(Sqldr);
                    Sqldr.Close();

                    string sSEX = string.Empty;

                    if(dt.Rows[0]["ADOPTERS_SEX"].ToString() == "0")
                    {
                        //sSEX = "男";
                        RadioButton1.Checked = true;
                    }
                    else
                    {
                        //sSEX = "女";
                        RadioButton2.Checked = true;
                    }
                    TextBox1.Text = dt.Rows[0]["ADOPTERS_NAME"].ToString();
                    //TextBox2.Text = sSEX;
                    TextBox5.Text = dt.Rows[0]["ADOPTERS_TEL"].ToString();
                    TextBox3.Text = dt.Rows[0]["ADOPTERS_MAIL"].ToString();
                    TextBox4.Text = dt.Rows[0]["ADOPTERS_ADDR"].ToString();
                    TextBox6.Text = dt.Rows[0]["ADOPTERS_HOME"].ToString();
                    //TextBox7.Text = dt.Rows[0]["ADOPTERS_EXP"].ToString();
                    if (dt.Rows[0]["ADOPTERS_EXP"].ToString() == "0")
                    {
                        //sSEX = "男";
                        RadioButton3.Checked = true;
                    }
                    else
                    {
                        //sSEX = "女";
                        RadioButton4.Checked = true;
                    }
                    TextBox8.Text = dt.Rows[0]["ADOPTERS_INCOM"].ToString();

                    sqlCmd.Cancel();
                    sqlconn.Close();
                    sqlconn.Dispose();
                }
            }
        }

        private void setControl_Add()
        {
            TextBox1.ReadOnly = false;
            //TextBox2.ReadOnly = false;
            TextBox3.ReadOnly = false;
            TextBox4.ReadOnly = false;
            TextBox5.ReadOnly = false;
            TextBox6.ReadOnly = false;
            //TextBox7.ReadOnly = false;
            TextBox8.ReadOnly = false;
        }

        private void setControl_Edit()
        {
            TextBox1.ReadOnly = true;
            //TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
            TextBox5.ReadOnly = true;
            TextBox6.ReadOnly = true;
            //TextBox7.ReadOnly = true;
            TextBox8.ReadOnly = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strDel = @"Delete ADOPTERS where ID = @ID";
            SqlConnection sqlconn = new SqlConnection();
            SqlCommand sqlCmd = new SqlCommand(strDel, sqlconn);
            sqlconn.ConnectionString = strCon;
            sqlconn.Open();

            sqlCmd.Parameters.AddWithValue("@ID", sID);

            sqlCmd.ExecuteNonQuery();
            sqlCmd.Cancel();
            sqlconn.Close();
            sqlconn.Dispose();

            Server.Transfer("Adopt.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.ReadOnly = true;
            //TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = false;
            TextBox4.ReadOnly = false;
            TextBox5.ReadOnly = false;
            TextBox6.ReadOnly = false;
            //TextBox7.ReadOnly = false;
            TextBox8.ReadOnly = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (sType == "A")
            {
                string strIns = @"Insert into ADOPTERS(ADOPTERS_NAME, ADOPTERS_SEX, ADOPTERS_TEL, ADOPTERS_MAIL, ADOPTERS_ADDR, ADOPTERS_HOME, ADOPTERS_EXP, ADOPTERS_INCOM, CREATE_DATE) values(@ADOPTERS_NAME, @ADOPTERS_SEX, @ADOPTERS_TEL, @ADOPTERS_MAIL, @ADOPTERS_ADDR, @ADOPTERS_HOME, @ADOPTERS_EXP, @ADOPTERS_INCOM, getdate())";
                SqlConnection sqlconn = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand(strIns, sqlconn);
                sqlconn.ConnectionString = strCon;
                sqlconn.Open();
                int iSex = 0;
                int iEXP = 0;

                if(RadioButton2.Checked == true)
                {
                    iSex = 1;
                }

                if (RadioButton4.Checked == true)
                {
                    iEXP = 1;
                }

                sqlCmd.Parameters.AddWithValue("@ADOPTERS_NAME", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_SEX", iSex);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_TEL", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_MAIL", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_ADDR", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_HOME", TextBox6.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_EXP", iEXP);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_INCOM", TextBox8.Text);



                sqlCmd.ExecuteNonQuery();
                sqlCmd.Cancel();
                sqlconn.Close();
                sqlconn.Dispose();

                Server.Transfer("Adopt.aspx");
            }
            else
            {
                string strUp = @"Update ADOPTERS SET ADOPTERS_TEL = @ADOPTERS_TEL, ADOPTERS_MAIL = @ADOPTERS_MAIL, ADOPTERS_ADDR = @ADOPTERS_ADDR, ADOPTERS_HOME = @ADOPTERS_HOME, ADOPTERS_EXP = @ADOPTERS_EXP, ADOPTERS_INCOM = @ADOPTERS_INCOM where ID = @ID";
                SqlConnection sqlconn = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand(strUp, sqlconn);
                sqlconn.ConnectionString = strCon;
                sqlconn.Open();

                int iEXP = 0;
                if (RadioButton4.Checked == true)
                {
                    iEXP = 1;
                }

                sqlCmd.Parameters.AddWithValue("@ADOPTERS_TEL", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_MAIL", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_ADDR", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_HOME", TextBox6.Text);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_EXP", iEXP);
                sqlCmd.Parameters.AddWithValue("@ADOPTERS_INCOM", TextBox8.Text);
                sqlCmd.Parameters.AddWithValue("@ID", sID);

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Cancel();
                sqlconn.Close();
                sqlconn.Dispose();

                Server.Transfer("Adopt.aspx");
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked == true)
            {
                RadioButton2.Checked = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                RadioButton1.Checked = false;
            }
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked == true)
            {
                RadioButton4.Checked = false;
            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                RadioButton3.Checked = false;
            }
        }
    }
}