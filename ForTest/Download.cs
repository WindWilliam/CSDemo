using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    public class Download
    {
        public static void GetHttpFile()
        {
            string sUrl = "http://localhost/Land.WebGIS.Service.Major/user/land_9Tree.json";
            HttpWebRequest hwr = HttpWebRequest.Create(sUrl) as HttpWebRequest;
            hwr.Method = "GET";

            HttpWebResponse res = hwr.GetResponse() as HttpWebResponse;

            if(res.StatusCode == HttpStatusCode.OK)
            {
                string sFile = AppDomain.CurrentDomain.BaseDirectory + "23333";
                Stream s = res.GetResponseStream();

                using (StreamWriter sw = new StreamWriter(sFile, false))
                {
                    s.CopyTo(sw.BaseStream);

                    sw.Flush();
                }
            }
        }
    }
}
