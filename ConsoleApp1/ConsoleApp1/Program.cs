using System;
using System.Net;
using System.Linq;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrapper();
        }
        static  void Scrapper()
        {
           
            WebClient w = new WebClient();

            String html =  w.DownloadString("https://www.instagram.com/oleksiy_lopatskiy03/");

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            Console.Write(html);

           /* var names = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("d7ByH")).ToList();
            foreach (var name in names)
            {
                var Name = name.Descendants("a").FirstOrDefault().InnerText;
                Console.WriteLine(Name);
            }*/
        }
    }
}
