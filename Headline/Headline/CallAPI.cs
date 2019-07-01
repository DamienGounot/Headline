using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Headline
{
    public class CallAPI
    {
        public string API(string url)
        {
            var json = new WebClient().DownloadString(url);

            return json;
        }


        public List<article1> showTITLE(string json)
        {

            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);
            int y = jPerson.totalResults;
            
            List<article1> articles = new List<article1>();
            foreach (var num in jPerson.articles)
             {
                article1 article = new article1();
                article.title = num.title;
                article.image = num.urlToImage;
                article.source = num.source.name;
                article.url = num.url;
                article.description = num.description;
                article.date = num.publishedAt;
                article.content = num.content;
                article.author = num.author;
                articles.Add(article);
             }

            return articles;
        }
    }
}
