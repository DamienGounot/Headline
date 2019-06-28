using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headline
{
   public  class Init
    {

        public static Init _instance;

        public static Init Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Init();
                return _instance;

            }
        }

        #region init

        public  string urlweb;
        public  string source1;
        public  string author1;
        public  string date1;
        public  string description1;
        public  string title1;
        public  string content1;
        public  string image1;
        public  string url1;

        public  string source2;
        public  string author2;
        public  string date2;
        public  string description2;
        public  string title2;
        public  string content2;
        public  string image2;
        public  string url2;

        public  string source3;
        public  string author3;
        public  string date3;
        public  string description3;
        public  string title3;
        public  string content3;
        public  string image3;
        public  string url3;

        public  string favoriteKeyword;
        public  string favoriteCountry;
        public  string initURL;


        public  string username;

        public  string pictureBoxArticle1;
        public  string titlehome1;
        public  string pictureBoxArticle2;
        public  string titlehome2;
        public  string pictureBoxArticle3;
        public  string titlehome3;

        public  string source;
        public  string author;
        public  string content;
        public  string date;
        public  string description;
        public  string title;
        public  string image;
        public  string url;


        #endregion

    }
}
