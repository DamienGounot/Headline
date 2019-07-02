using System.Collections.Generic;

namespace Headline.API
{
    public  class AllAPI
    {
        public static AllAPI Instance;

        List<Research.Article> lastResearchedarticles = new List<Research.Article>();
        Research.GetResearch research = new Research.GetResearch();
        Research.CreateUrl url = new Research.CreateUrl();
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

        public List<Research.Article> GetLastResearchedArticles()
        {
            return lastResearchedarticles;
        }

        public int GetLength()
        {
            return lastResearchedarticles.Count;
        }

    }
}
