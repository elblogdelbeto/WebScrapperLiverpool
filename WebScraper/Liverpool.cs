using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WebScraper
{
    internal class Liverpool
    {
        static internal void ObtenerNintendos()
        {
            string url = "https://www.liverpool.com.mx/tienda/consolas-nintendo/catst16854843";

            HtmlDocument htmlDocument = new HtmlDocument();
            HtmlWeb htmlWeb = new HtmlWeb();

            htmlWeb.OverrideEncoding = Encoding.UTF8;
            htmlWeb.UserAgent = "Mozilla/5.0 (iPad; CPU OS 12_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148";
            htmlDocument = htmlWeb.Load(url);
            var jsonNode = htmlDocument.DocumentNode.SelectSingleNode(@"//script[@id=""__NEXT_DATA__""]/text()");
            
            // Parse the JSON string to get the 'records' section
            JObject jsonObject = JObject.Parse(jsonNode.OuterHtml);
            JToken recordsToken = jsonObject["query"]!["data"]!["mainContent"]!["records"]!;



            // Deserialize the 'records' section into a list of Record objects
            List<Record>? records = JsonConvert.DeserializeObject<List<Record>>(recordsToken.ToString());

       

        }
         
    }
}
