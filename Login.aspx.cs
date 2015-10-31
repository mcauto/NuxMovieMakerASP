using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    private MySqlConnection conn;
    private MySqlCommand cmd;

    string connStr = String.Format("server=203.241.249.106;user id=root;pwd=ghkdlxld;database=PRACTICE");


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string id;
            string pass;
            id = TextBox1.Text;
            pass = TextBox2.Text;

            conn = new MySqlConnection(connStr);

            conn.Open();

            DataSet ds = new DataSet();


            string sql = "select USER_ID from USER where USER_ID='" + id + "' and " + "PASSWORD=" + pass;

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(ds, "PRACTICE");

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                    Label1.Text = r["USER_ID"] + " 님이 접속하셨습니다.";
                Session.Add("id",id);
            }

            else
                Label1.Text = "존재하지 않는 아이디거나 비밀번호 오류";

            conn.Close();
            Response.Redirect("Uploads.aspx");
        }

        catch(Exception ex)
        {
            Label1.Text = "Error";
        }

    }
}