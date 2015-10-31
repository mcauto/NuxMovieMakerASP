using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["id"].ToString()+"님이 접속하셨습니다.";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            
            Session.Clear();
            Session.Abandon();
            Label1.Text = Session["id"].ToString() + "로그아웃 됫습다";

        }
        catch (Exception ex)
        {
            Label1.Text = "Error";
        }

    }
}