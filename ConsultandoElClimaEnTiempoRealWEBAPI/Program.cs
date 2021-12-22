using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ConsultandoElClimaEnTiempoRealWEBAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string url = @"http://api.weatherunlocked.com/api/current/us.90001?app_id=38be557a&app_key=e9d94947416b42e32c15dd1e48c98a37";
            WebRequest webRequest = WebRequest.Create(url);
            HttpWebResponse httpWebResponse = null;
            httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

            string result = string.Empty;
            using (Stream stream = httpWebResponse.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(stream);
                result = streamReader.ReadToEnd();
                streamReader.Close();
            }

        }
    }
}
