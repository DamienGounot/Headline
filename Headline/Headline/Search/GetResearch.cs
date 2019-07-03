namespace Headline.Search
{
    public class GetResearch
    {
        public string KeyWordToUrl(string keyword)
        {
            var result = keyword;
            var totalkeyword = "";
            if (keyword != "")
            {
                totalkeyword = "q=" + result + "&";
                //param = param + 1;
            }
            else
            {
                totalkeyword = "";
            }
            return totalkeyword;
        }

        public string CountryToUrl(string country)
        {
            var totalcountry = "";
            if (country != "")
            {
                totalcountry = "country=" + country + "&";
                //param = param + 1;
            }
            else
            {
                totalcountry = "";
            }
            return totalcountry;

        }
        public string SourceToUrl(string source)
        {
            var totalsource = "";
            if (source != "")
            {
                totalsource = "sources=" + source + "&";
                //param = param + 1;
            }
            else
            {
                totalsource = "";
            }
            return totalsource;
        }
    }
}
