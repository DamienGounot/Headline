using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Headline.API
{
    public class CallAPI
    {
        public string API(string url)
        {
                var json = new WebClient().DownloadString(url);

                return json;
  

        }

        public List<Search.Article> showTITLE(string json)
        {

            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);
            int y = jPerson.totalResults;
            
            List<Search.Article> articles = new List<Search.Article>();

            foreach (var num in jPerson.articles)
             {
                Search.Article article = new Search.Article();
                article.title = num.title;
                article.image = num.urlToImage;
                article.source = num.source.name;
                article.url = num.url;
                article.description = num.description;
                article.date = num.publishedAt;
                article.content = num.content;
                article.author = num.author;
                article.nbarticles = y;
                articles.Add(article);
             }

            return articles;
        }
    }
}
