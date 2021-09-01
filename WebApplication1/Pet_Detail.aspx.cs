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
    public partial class Pet_Detail : System.Web.UI.Page
    {
        string strCon = ConfigurationManager.ConnectionStrings["Animal_HouseConnectionString"].ConnectionString;
        string sID = string.Empty;
        string sType = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            sType = Request.QueryString["Type"];
            sID = Request.QueryString["ID"];

            if (!IsPostBack)//如果不是用PostBack回來的話
            {
                if(sType == "A")
                {

                    SetControl_ADD();
                }
                else
                {
                    SetControl_Edit();
                    string sql = "Select * From PET_SIAZE where ID = " + sID;
                    DataTable dt = new DataTable();

                    SqlConnection sqlconn = new SqlConnection();
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlconn);

                    sqlconn.ConnectionString = strCon;
                    sqlconn.Open();

                    SqlDataReader Sqldr = sqlCmd.ExecuteReader();
                    dt.Load(Sqldr);
                    Sqldr.Close();

                    TextBox1.Text = dt.Rows[0]["PET_TYPE"].ToString();
                    TextBox2.Text = dt.Rows[0]["PET_VARIETY"].ToString();
                    TextBox3.Text = dt.Rows[0]["PET_SEX"].ToString();
                    TextBox4.Text = dt.Rows[0]["PET_WEIGHT"].ToString();
                    TextBox5.Text = dt.Rows[0]["PET_COLOR"].ToString();
                    TextBox6.Text = dt.Rows[0]["PET_OLD"].ToString();
                    //TextBox7.Text = "";
                    TextBox8.Text = dt.Rows[0]["PET_NUM"].ToString();
                    TextBox9.Text = dt.Rows[0]["ENTER_DATE"].ToString();
                    TextBox10.Text = dt.Rows[0]["PERSONALITY"].ToString();
                    TextBox11.Text = dt.Rows[0]["LIGATION"].ToString();
                    TextBox12.Text = dt.Rows[0]["VACCINE"].ToString();
                    TextBox13.Text = dt.Rows[0]["DEWORMING"].ToString();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.ReadOnly = false;
            TextBox2.ReadOnly = false;
            TextBox3.ReadOnly = false;
            TextBox4.ReadOnly = false;
            TextBox5.ReadOnly = false;
            TextBox6.ReadOnly = false;
            //TextBox7.ReadOnly = false;
            TextBox8.ReadOnly = false;
            TextBox9.ReadOnly = false;
            TextBox10.ReadOnly = false;
            TextBox11.ReadOnly = false;
            TextBox12.ReadOnly = false;
            TextBox13.ReadOnly = false;

            Button1.Visible = false;
            Button2.Visible = true;
            Button4.Visible = true;
        }

        private void SetControl_ADD()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            //TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";

            Button1.Visible = false;
            Button2.Visible = false;
            Button4.Visible = true;
        }

        private void SetControl_Edit()
        {
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
            TextBox5.ReadOnly = true;
            TextBox6.ReadOnly = true;
            //TextBox7.ReadOnly = true;
            TextBox8.ReadOnly = true;
            TextBox9.ReadOnly = true;
            TextBox10.ReadOnly = true;
            TextBox11.ReadOnly = true;
            TextBox12.ReadOnly = true;
            TextBox13.ReadOnly = true;

            Button1.Visible = true;
            Button2.Visible = true;
            Button4.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (sType == "A")
            {
                string strIns = @"Insert into PET_SIAZE(PET_TYPE, PET_VARIETY, PET_SEX, PET_WEIGHT,PET_COLOR,PET_OLD,PET_NUM,ENTER_DATE,PERSONALITY,LIGATION,VACCINE,DEWORMING,CREATE_DATE) values(@PET_TYPE, @PET_VARIETY, @PET_SEX, @PET_WEIGHT,@PET_COLOR,@PET_OLD,@PET_NUM,@ENTER_DATE,@PERSONALITY,@LIGATION,@VACCINE,@DEWORMING,getdate())";
                SqlConnection sqlconn = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand(strIns, sqlconn);
                sqlconn.ConnectionString = strCon;
                sqlconn.Open();

                sqlCmd.Parameters.AddWithValue("@PET_TYPE", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@PET_VARIETY", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@PET_SEX", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@PET_WEIGHT", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@PET_COLOR", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@PET_OLD", TextBox6.Text);
                sqlCmd.Parameters.AddWithValue("@PET_NUM", TextBox8.Text);
                sqlCmd.Parameters.AddWithValue("@ENTER_DATE", TextBox9.Text);
                sqlCmd.Parameters.AddWithValue("@PERSONALITY", TextBox10.Text);
                sqlCmd.Parameters.AddWithValue("@LIGATION", TextBox11.Text);
                sqlCmd.Parameters.AddWithValue("@VACCINE", TextBox12.Text);
                sqlCmd.Parameters.AddWithValue("@DEWORMING", TextBox13.Text);
                

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Cancel();
                sqlconn.Close();
                sqlconn.Dispose();

                Server.Transfer("Pet.aspx");
            }
            else
            {
                string strUp = @"Update PET_SIAZE SET PET_TYPE = @PET_TYPE, PET_VARIETY = @PET_VARIETY, PET_SEX = @PET_SEX, PET_WEIGHT = @PET_WEIGHT, PET_COLOR = @PET_COLOR, PET_OLD = @PET_OLD, PET_NUM = @PET_NUM, ENTER_DATE = @ENTER_DATE, PERSONALITY = @PERSONALITY, LIGATION = @LIGATION, VACCINE = @VACCINE, DEWORMING = @DEWORMING where ID = @ID";
                SqlConnection sqlconn = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand(strUp, sqlconn);
                sqlconn.ConnectionString = strCon;
                sqlconn.Open();

                sqlCmd.Parameters.AddWithValue("@PET_TYPE", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("@PET_VARIETY", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("@PET_SEX", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("@PET_WEIGHT", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("@PET_COLOR", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("@PET_OLD", TextBox6.Text);
                sqlCmd.Parameters.AddWithValue("@PET_NUM", TextBox8.Text);
                sqlCmd.Parameters.AddWithValue("@ENTER_DATE", TextBox9.Text);
                sqlCmd.Parameters.AddWithValue("@PERSONALITY", TextBox10.Text);
                sqlCmd.Parameters.AddWithValue("@LIGATION", TextBox11.Text);
                sqlCmd.Parameters.AddWithValue("@VACCINE", TextBox12.Text);
                sqlCmd.Parameters.AddWithValue("@DEWORMING", TextBox13.Text);
                sqlCmd.Parameters.AddWithValue("@ID", sID);

                sqlCmd.ExecuteNonQuery();
                sqlCmd.Cancel();
                sqlconn.Close();
                sqlconn.Dispose();

                Server.Transfer("Pet.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string strDel = @"Delete PET_SIAZE where ID = @ID";
            SqlConnection sqlconn = new SqlConnection();
            SqlCommand sqlCmd = new SqlCommand(strDel, sqlconn);
            sqlconn.ConnectionString = strCon;
            sqlconn.Open();

            sqlCmd.Parameters.AddWithValue("@ID", sID);

            sqlCmd.ExecuteNonQuery();
            sqlCmd.Cancel();
            sqlconn.Close();
            sqlconn.Dispose();

            Server.Transfer("Pet.aspx");
        }
    }
}