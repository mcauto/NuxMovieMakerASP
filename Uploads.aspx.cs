﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.SessionState;
using System.Web.UI.HtmlControls;
using DirectShowLib;
using DirectShowLib.DES;
using System.Runtime.InteropServices;

public partial class Uploads : System.Web.UI.Page
{

    private MySqlConnection conn;
    private MySqlCommand cmd;
    string connStr = String.Format("server=203.241.249.106;user id=root;pwd=ghkdlxld;database=PRACTICE");

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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //이제 수정할거 -> 올릴때 movie1 , 2 , 3 .... 이런식으로 되도록
        
        //파일 이름
        string fileName = FileUpload1.PostedFile.FileName;
        //파일 경로
        string filePath = Server.MapPath("Data");
        //파일 확장자
        string fileInfo = FileUpload1.PostedFile.ContentType;

        conn = new MySqlConnection(connStr);
        try
        {
            //UPLOAD_VIDEO 테이블에
            //VIDEO_NUM (번호) ㅇ
            //TITLE     (파일이름) ㅇ
            //FILE_TYPE (확장자) ㅇ
            //RUNNING_TIME 
            //FILE_PATH (경로) ㅇ
            //THUMBNAIL_PATH (널)
            //MADE_BY (ID)
            
            conn.Open();

            int count = 0;
            DataSet ds = new DataSet();
            if (conn.State == ConnectionState.Open)
            {
                string query = "SELECT VIDEO_NUM FROM UPLOAD_VIDEO";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn);
                adpt.Fill(ds, "UPLOAD_VIDEO");
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        count++;
                    }
                }
                ds.Reset();
            }
            count++;

            string sql = "INSERT INTO UPLOAD_VIDEO(VIDEO_NUM,TITLE,FILE_TYPE,RUNNING_TIME,FILE_PATH,MADE_BY,CATEGORY) VALUES(" +
                count + ",'" + fileName + "','" + fileInfo + "','" + /*시간*/"','" + filePath + "','" + /*사용자(로그인)ID*/ "','" + "null')";

            conn = new MySqlConnection(connStr);
            cmd = new MySqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception ex)
        {
            Label1.Text = "Error" + ex.Message.ToString();
        }
        //VIDEO 테이블에
        /*
        KEYWORD
        FILE_TYPE - 파일타입
        RUNNING_TIME - 
        FILE_PATH - 경로됫고
        THUMBNAIL_PATH 
        COUNT  - DB존재하는 파일 카운트

        AGE - AgeList
        SEX - SexList
        JOB - JobList
        INCIDENT - IncList
        ERA - EraList
        SEASON - SeasonList
        DAY_TIME - DayList
        PLACE - PlaceList 
        */




        if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
        {
            string fn = System.IO.Path.GetFileName(fileName);
            string SaveLocation = filePath + "\\" + fn;
            try
            {
                FileUpload1.PostedFile.SaveAs(SaveLocation);
                //Label1.Text += "The file has been uploaded.";
            }
            catch (Exception ex)
            {
                //Label1.Text = "Error: " + ex.Message;
            }
        }
        else
        {
            //Label1.Text = "Please select a file to upload.";
        }
    }
}