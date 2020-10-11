using System;
using System.Net;
using System.Linq;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace InstagramScrapper
{
    class Program
    {
        static  void Main(string[] args)
        {
            Scrapper();
        }
         static async void Scrapper()
        {
            var url = "https://www.instagram.com/oleksiy_lopatskiy03/followers/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var names = htmlDocument.DocumentNode.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("FPmhX notranslate  _0imsa ")).ToList();
            foreach (var name in names)
            {
                var Name = name.Descendants().FirstOrDefault().InnerText;
                Console.WriteLine(Name);
            }
        }
    }
}
