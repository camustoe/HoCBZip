using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace HouseOfCommonsBusiness.Services
{
    public class Services
    {


        public string Test()
        {
            return Get("http://data.parliament.uk/membersdataplatform/services/mnis/members/query/id=579/");
        }



        private string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);

            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }


        }

        

    }


}