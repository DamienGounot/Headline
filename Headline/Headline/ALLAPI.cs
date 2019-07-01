using System.Collections.Generic;

namespace Headline
{
    public  class allAPI
    {
        public static allAPI Instance;

        List<article1> lastResearchedarticles = new List<article1>();
        GetResearch research = new GetResearch();
        CreateUrl url = new CreateUrl();
        CallAPI api = new CallAPI();
        
        public allAPI()
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

        public List<article1> GetLastResearchedArticles()
        {
            return lastResearchedarticles;
        }

    }
}
