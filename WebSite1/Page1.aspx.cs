using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string sURL = "https://developers.zomato.com/api/v2.1/search?entity_type=city&q=" + txtSearch.Text;
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
             //Response.Write(jsonText);
            dynamic obj = JsonConvert.DeserializeObject(jsonText);
           // Response.Write(obj);
            int n = (int)obj.results_shown;
            Response.Write("List offf Restaurants:");
            int i;
            Response.Write("<ul>");
            for (i=0;i<n;i++)
            {
                Response.Write("<li>"+obj.restaurants[i].restaurant.name+ "<a href="+obj.restaurants[i].restaurant.url+" > "+"Click for more details"+"</a>"+"</li>");
            }
            Response.Write("</ul>");
            // Response.Write("Click here for more photos"+"<a href="+obj.restaurants[0].restaurant.photos_url+">Click </a>");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



}