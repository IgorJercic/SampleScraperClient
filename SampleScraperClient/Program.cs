using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;

namespace SampleScraperClient
{
    class Program
    {
        static void Main(string[] args)
        {


            #region orginal

            // setup the browser
            //ScrapingBrowser Browser = new ScrapingBrowser();
            //Browser.AllowAutoRedirect = true; // Browser has many settings you can access in setup
            //Browser.AllowMetaRedirect = true;
            ////go to the home page
            //WebPage PageResult = Browser.NavigateToPage(new Uri("http://localhost:51621/"));
            //// get first piece of data, the page title
            //HtmlNode TitleNode = PageResult.Html.CssSelect(".navbar-brand").First();
            //string PageTitle = TitleNode.InnerText; //text inside navbar



            //// get a list of data from a table
            //List<String> Names = new List<string>();
            //var Table = PageResult.Html.CssSelect("#PersonTable").First(); //ovo ti je table id ili klasi


            //foreach (var row in Table.SelectNodes("tbody/tr")) //lista unutar tablice  tr td/ tr td
            //{
            //    foreach (var cell in row.SelectNodes("td[1]"))
            //    {
            //        Names.Add(cell.InnerText);
            //    }
            //}


            //// find a form and send back data
            //PageWebForm form = PageResult.FindFormById("dataForm");
            //// assign values to the form fields
            //form["UserName"] = "AJSON";
            //form["Gender"] = "M";
            //form.Method = HttpVerb.Post;
            //WebPage resultsPage = form.Submit();



            #endregion



            #region
            //setup the browser
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true; // Browser has many settings you can access in setup
            Browser.AllowMetaRedirect = true;
            //go to the home page
            WebPage PageResult = Browser.NavigateToPage(new Uri("http://www.xscores.com/soccer"));
            // get first piece of data, the page title
            //HtmlNode TitleNode = PageResult.Html.CssSelect(".tooltip_flag").Last();
            //string PageTitle = TitleNode.InnerText; //text inside navbar

            // HtmlNode TextNode = PageResult.Html.CssSelect(".score_info score_cell").First();
            //string TextPokupi = TextNode.InnerText;



            //Console.WriteLine(PageTitle);
            //Console.WriteLine(TextPokupi);





            // get a list of data from a table
            List<String> Names = new List<string>();
            var Table = PageResult.Html.CssSelect(".score_header").First(); //ovo ti je table id ili klasi


            foreach (var row in Table.CssSelect(".country_header/.score_row")) //lista unutar tablice  tr td/ tr td
            {
                foreach (var cell in row.CssSelect(".score_cell[1]"))
                {
                    Names.Add(cell.InnerText);
                }
            }




            Console.ReadKey();


            #endregion

        }


    }
}
