using Data.Infrastructure;
using Data.Models;
using Domain;
using Newtonsoft.Json;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReclamationService:Service<reclamation>
    {
        private static DatabaseFactory df = new DatabaseFactory();
        private static UnitOfWork uf = new UnitOfWork(df);

        public ReclamationService() : base(uf)
        {
        }
            public void addRec(String subject, String message, String type)
        {

            DateTime reclamdate = DateTime.Now;
            int day = reclamdate.Day;
            int month = reclamdate.Month;
            int year = reclamdate.Year;
            string d = year + "-" + month + "-" + day;
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/ged-web/rest/reclamation");
            request.Method = "Post";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{
                        ""subject"": """ + subject + @""",
  ""message"": """ + message + @""",
  ""type"": """ + type + @""",
""reclamDate"": """ + d + @"""
                        }}");
                sw.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader r = new StreamReader(responseStream))
                            {

                            }
                        }
                    }

                }
            }
        }
        public IEnumerable<reclamation> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/ged-web/rest/reclamation");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            var objs = JsonConvert.DeserializeObject<List<reclamation>>(content,new TimeConversion());
            List<reclamation> liste = new List<reclamation>();
            foreach (reclamation r in objs)
            {
                reclamation rec = new reclamation() { subject = r.subject,message=r.message,type=r.type,reclamDate=r.reclamDate,dateTrait=r.dateTrait,dateSol=r.dateSol };

                liste.Add(rec);
            }
            return liste;
        }

        public void deleteRec(int id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/ged-web/rest/reclamation/" + id);
            request.Method = "DELETE";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }




    }
}

