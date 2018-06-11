using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace SSL.Controllers
{
    public class MainController : ApiController
    {
       /*HttpWebRequest webRequest =
                    WebRequest.Create("https://developers.zomato.com/api/v2.1/cities?q=Omaha")
                            as HttpWebRequest;
        HttpWebResponse webResponse = null;
        WebRequest.Headers.Add("X-Zomato-API-Key", "08db76e22ccb7e3569c7caa5dd56514c"); 
        webRequest.Method = "GET";
        webResponse = (HttpWebResponse) webRequest.GetResponse();
        if (WebResponse.StatusCode == HttpStatusCode.OK)
    {
         StreamReader responseReader = new
                            StreamReader(webResponse.GetResponseStream());
        string responseData = responseReader.ReadToEnd();
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(responseData);
         XmlNodeReader xmlReader = new XmlNodeReader(doc);
        DataSet ds = new DataSet();
        ds.ReadXml(xmlReader);
         return ds;
    }
    */
    }
}
