using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headline.Research
{
    public class CreateUrl
    {
        public string GenerateUrl(string partkeyword, string partcountry, string partsource)
        {

            var url = "https://newsapi.org/v2/top-headlines?" + partkeyword +
                    partcountry + partsource +
                    "apiKey=fba415c197974798bd1833b9f86de604";


            return url;
        }
    }
}
