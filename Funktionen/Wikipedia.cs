using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Klassen
{
    public static class Wikipedia
    {
        //Ließt über eine API den Wikipediaartikel aus
        public static string GetArtikel(string artikel, bool quick)
        {
            string antwort = "";
            string small = "";

            WebClient client = new WebClient();

            using (Stream stream =
            client.OpenRead(
            "http://de.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=" + artikel)
            )
            using (StreamReader reader = new StreamReader(stream))
            {
                JsonSerializer ser = new JsonSerializer();
                Result result = ser.Deserialize<Result>(new JsonTextReader(reader));

                foreach (Page page in result.query.pages.Values)
                {
                    antwort = page.extract;
                }
                small = antwort.Substring(0, 500);
            }

            if (quick)
                return small;
            else
                return antwort;
        }

        private class Result
        {
            public Query query { get; set; }
        }

        private class Query
        {
            public Dictionary<string, Page> pages { get; set; }
        }

        private class Page
        {
            public string extract { get; set; }
        }
    }
}
