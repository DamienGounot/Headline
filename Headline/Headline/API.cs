using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Headline
{
   public  class API
    {

        public static API _instance;

        public static API Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new API();
                return _instance;

            }
        }


        public void initapi()
        {
            string space = " ";

            if (Login.favoriteCountry != space || Login.favoriteKeyword != space)
            {


                Login.initURL = "https://newsapi.org/v2/top-headlines?q=" + Login.favoriteKeyword + "&country=" +
  Login.favoriteCountry +
   "&apiKey=fba415c197974798bd1833b9f86de604";

            }
            else
            {
                Login.initURL = "https://newsapi.org/v2/top-headlines?country=us&apiKey=fba415c197974798bd1833b9f86de604";
            }



            var json = new WebClient().DownloadString(Login.initURL);

            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);

            if (jPerson.totalResults == 0)
            {
                MessageBox.Show("There is no top headlines about your preferences");
                Login.initURL = "https://newsapi.org/v2/top-headlines?country=us&apiKey=fba415c197974798bd1833b9f86de604";
                json = new WebClient().DownloadString(Login.initURL);
                jPerson = JsonConvert.DeserializeObject<dynamic>(json);

            }



            var i = 1;
            foreach (var num in jPerson.articles)
            {


                if (i == 1)
                {
                    API.Instance.source1 = num.source.name;
                    API.Instance.author1 = num.author;
                    API.Instance.content1 = num.content;
                    API.Instance.date1 = num.publishedAt;
                    API.Instance.description1 = num.description;
                    API.Instance.title1 = num.title;
                    API.Instance.image1 = num.urlToImage;

                    Home.Instance.SetArticlesLink1(API.Instance.title1, API.Instance.image1);

                    API.Instance.url1 = num.url;





                }
                else if (i == 2)
                {

                    API.Instance.source2 = num.source.name;
                    API.Instance.author2 = num.author;
                    API.Instance.content2 = num.content;
                    API.Instance.date2 = num.publishedAt;
                    API.Instance.description2 = num.description;
                    API.Instance.title2 = num.title;
                    API.Instance.image2 = num.urlToImage;

                    Home.Instance.SetArticlesLink2(API.Instance.title2, API.Instance.image2);

                    API.Instance.url2 = num.url2;
                }
                else if (i == 3)
                {

                    API.Instance.source3 = num.source.name;
                    API.Instance.author3 = num.author;
                    API.Instance.content3 = num.content;
                    API.Instance.date3 = num.publishedAt;
                    API.Instance.description3 = num.description;
                    API.Instance.title3 = num.title;
                    API.Instance.image3 = num.urlToImage;

                    Home.Instance.SetArticlesLink3(API.Instance.title3, API.Instance.image3);

                    API.Instance.url3 = num.url;
                }

                i++;


            }


        }


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
    }
}
