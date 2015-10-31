using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Uploads : System.Web.UI.Page
{
    private MySqlConnection conn;
    private MySqlCommand cmd;
    string connStr = String.Format("server=203.241.249.106;user id=root;pwd=ghkdlxld;database=PRACTICE");

    //경로 : /var/www/uploads
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                if (conn.State == ConnectionState.Open)
                {

                    string sql = "SELECT * FROM BACKG_DAY_TIME";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "BACKG_DAY_TIME");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["DAY_TIME"] + "";
                            ListItem list = new ListItem(list_str);
                            DayList.Items.Add(list);
                        }
                    }
                    ds.Reset();


                    sql = "SELECT * FROM BACKG_ERA";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "BACKG_ERA");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["ERA"] + "";
                            ListItem list = new ListItem(list_str);
                            EraList.Items.Add(list);
                        }
                    }
                    ds.Reset();

                    sql = "SELECT * FROM BACKG_INANDOUT";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "BACKG_INANDOUT");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["INANDOUT"] + "";
                            ListItem list = new ListItem(list_str);
                            AreaList.Items.Add(list);
                        }
                    }
                    ds.Reset();

                    sql = "SELECT * FROM CH_JOB_CATE1";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "CH_JOB_CATE1");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["JOB_CATE1"] + "";
                            ListItem list = new ListItem(list_str);
                            JobCList.Items.Add(list);
                        }
                    }
                    ds.Reset();
                    /*
                    sql = "SELECT * FROM BACKG_PLACE";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "BACKG_PLACE");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["INANDOUT"] + "";
                            ListItem list = new ListItem(list_str);
                            EraList.Items.Add(list);
                        }
                    }
                    ds.Reset();*/


                    sql = "SELECT * FROM BACKG_SEASON";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "BACKG_SEASON");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["SEASON"] + "";
                            ListItem list = new ListItem(list_str);
                            SeasonList.Items.Add(list);
                        }
                    }
                    ds.Reset();


                    sql = "SELECT * FROM CHARAC_AGE";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "CHARAC_AGE");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["AGE"] + "";
                            ListItem list = new ListItem(list_str);
                            AgeList.Items.Add(list);
                        }
                    }
                    ds.Reset();


                    sql = "SELECT * FROM CHARAC_SEX";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "CHARAC_SEX");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["SEX"] + "";
                            ListItem list = new ListItem(list_str);
                            SexList.Items.Add(list);
                        }
                    }
                    ds.Reset();


                    sql = "SELECT * FROM INCID_CATE1";
                    adpt = new MySqlDataAdapter(sql, conn);
                    adpt.Fill(ds, "INCID_CATE1");
                    if (ds.Tables.Count > 0)
                    {

                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            string list_str = r["INCID_CATE1"] + "";
                            ListItem list = new ListItem(list_str);
                            IncidCList.Items.Add(list);
                        }
                    }
                    ds.Reset();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                //Label1.Text = "insert Error";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        conn = new MySqlConnection(connStr);
        try
        {
            conn.Open();
            DataSet ds = new DataSet();
            if (conn.State == ConnectionState.Open)
            {
                //string sql = "SELECT * FROM BACKG_PLACE WHERE INANDOUT='" + AreaList.SelectedItem.Text + "'";
                string sql = "SELECT * FROM BACKG_PLACE";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "BACKG_PLACE");
                if (ds.Tables.Count > 0)
                {
                    PlaceList.Items.Clear();
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        if ((string)r["INANDOUT"] == AreaList.SelectedItem.Text)
                        {
                            string list_str = r["PLACE"] + "";
                            ListItem list = new ListItem(list_str);
                            PlaceList.Items.Add(list);
                        }
                    }
                }
                ds.Reset();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error" + ex.Message.ToString();
        }
    }

    protected void IncidCList_SelectedIndexChanged(object sender, EventArgs e)
    {
        conn = new MySqlConnection(connStr);
        try
        {
            conn.Open();
            DataSet ds = new DataSet();
            if (conn.State == ConnectionState.Open)
            {
                //string sql = "SELECT * FROM BACKG_PLACE WHERE INANDOUT='" + AreaList.SelectedItem.Text + "'";
                string sql = "SELECT * FROM INCIDENT";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "INCIDENT");
                if (ds.Tables.Count > 0)
                {
                    IncidList.Items.Clear();
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        if ((string)r["INCID_CATE1"] == IncidCList.SelectedItem.Text)
                        {
                            string list_str = r["INCIDENT"] + "";
                            ListItem list = new ListItem(list_str);
                            IncidList.Items.Add(list);
                        }
                    }
                }
                ds.Reset();
            }
            conn.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error" + ex.Message.ToString();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string savePath = "C:\\Users\\JK\\Test\\";
            string fileName = FileUpload1.FileName;

            FileUpload1.PostedFile.SaveAs(@"C:\Users\JK\Test\\" + "file1.jpeg");
        }
    }
}