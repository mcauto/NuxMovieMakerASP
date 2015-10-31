using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Default3 : System.Web.UI.Page
{
    private MySqlConnection conn;
    private MySqlCommand cmd;
    string connStr = String.Format("server=203.241.249.106;user id=root;pwd=ghkdlxld;database=PRACTICE");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBox3.Text == TextBox4.Text)
        {
            Label8.Text = "correct";
        }
        else
        {
            Label8.Text = "incorrect password is wrong";
        }
        if (RegularExpressionValidator1.IsValid)
        {
            Label9.Text = "good";
        }
        else
        {
            Label9.Text = "e-mail adress is wrong";
        }

        string id, pass, name, email, sex;
        id = TextBox1.Text;
        pass = TextBox3.Text;
        name = TextBox2.Text;
        email = TextBox5.Text;
        sex = TextBox6.Text;
        string script = "alert(\"Hello!\");";
        string sql = "insert into USER(USER_ID, PASSWORD, USER_NAME, USER_SEX,E_MAIL) VALUES('" + id + "'," + pass +
            ",'" + name + "','" + sex + "','" + email + "')";

        conn = new MySqlConnection(connStr);
        cmd = new MySqlCommand(sql, conn);
        // cmd.Connection = conn;
        try
        {

            conn.Open();
            cmd.ExecuteNonQuery();

            ScriptManager.RegisterStartupScript(this, GetType(),
                                         "ServerControlScript", script, true);
           
            conn.Close();
            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            conn.Close();
        }
    }
}