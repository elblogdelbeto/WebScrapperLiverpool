using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

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
            var tituloElemento = htmlDocument.DocumentNode.SelectSingleNode(@"//script[@id=""__NEXT_DATA__""]/text()");

            string outerHtml = htmlDocument.DocumentNode.OuterHtml;

            HttpClient httpClient = new HttpClient();
            string htmlString = httpClient.GetStringAsync(url).Result;
            htmlDocument.LoadHtml(htmlString);

            tituloElemento = htmlDocument.DocumentNode.SelectSingleNode(@"//h5[@class='card-title a-card-description']/span[@class='m-description-spcbrand']/parent::h5");
            var titulo = tituloElemento.InnerText.Trim();

        }
         
    }
}
