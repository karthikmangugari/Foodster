using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class MyApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        myMethod();
    }

    void myMethod()
    {
        try
        {
            string sURL = "https://developers.zomato.com/api/v2.1/cities?q=Omaha";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.Method = "GET";
            request.Accept = "application/json; charset=utf-8";
            request.Headers.Add("user-key", "08db76e22ccb7e3569c7caa5dd56514c");
            var response = (HttpWebResponse)request.GetResponse();
            string jsonText;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonText = sr.ReadToEnd();
            }
            Response.Write(jsonText);

        }
        catch (Exception e)
        {
            throw e;
        }
    }
}