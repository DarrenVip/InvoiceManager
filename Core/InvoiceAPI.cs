using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;


namespace InvoiceManager.Core
{
    internal class InvoiceAPI
    {

        private const String host = "https://dgfp.market.alicloudapi.com";
        private const String path = "/ocrservice/invoice";
        private const String method = "POST";


        public class DataResult { 
            public string DateTime { get; set; }
            public string Amount { get; set; }

        }

        public  String AppCode  { get; set; }

        public InvoiceAPI(string appCode) {
            this.AppCode = appCode;
        }

        public string ORC(string filePath)
        {
            String querys = "";
            String bodys = string.Empty;
            String url = host + path;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
                string base64String = Convert.ToBase64String(imageData);

                JsonObject obj = new JsonObject();
                obj.Add("img", base64String);

                bodys = obj.ToString();


            }

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (host.Contains("https://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + this.AppCode);
            //根据API的要求，定义相对应的Content-Type
            httpRequest.ContentType = "application/json; charset=UTF-8";


            if (0 < bodys.Length)
            {
                

                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }

           
            Stream st = httpResponse.GetResponseStream();
            StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
            string json = reader.ReadToEnd();
            return json;

            

        }


        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

    }
}







