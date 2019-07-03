using System.Collections.Generic;

namespace Headline.API
{
    public  class AllAPI
    {
        public static AllAPI Instance;

        List<Search.Article> lastResearchedarticles = new List<Search.Article>();
        Search.GetResearch research = new Search.GetResearch();
        Search.CreateUrl url = new Search.CreateUrl();
        CallAPI api = new CallAPI();
        
        public AllAPI()
        {
            Instance = this;
        }

        public void search(string keyword, string country, string source)
        {
            string x = research.KeyWordToUrl(keyword);
            string y = research.CountryToUrl(country);
            string z = research.SourceToUrl(source);
            

            string urll = url.GenerateUrl(x, y, z);
            string json = api.API(urll);
            lastResearchedarticles = api.showTITLE(json);
        }

        public List<Search.Article> GetLastResearchedArticles()
        {
            return lastResearchedarticles;
        }

        public int GetLength()
        {
            return lastResearchedarticles.Count;
        }

    }
}
