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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }



        public  static Search _instance;

        public static  Search Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Search();
                return _instance;

            }
        }


        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }

        private void isFill()
        {
            if (this.textBox_keyword_search.Text == "" && this.textBox_country_search.Text == "" && this.textBox_source_search.Text == "")
            {
                MessageBox.Show("Error : you need to fill a field");
            }
            else
            {
                callapi();
            }
        }



        #region Search page
        // Search Page

        private void button_home_from_search_Click(object sender, EventArgs e)
        {
            ShowForm(Home.Instance);
        }

        private void button_make_search_Click(object sender, EventArgs e)
        {
            isFill();
        }


        public void callapi()
        {

            var errors = 0;
            var param = 0;

            #region keyword

            var keyword = "";
            var totalkeyword = "";

            if (textBox_keyword_search.Text == "")
            {
                totalkeyword = "";
            }
            else if (textBox_keyword_search.Text != "")
            {
                keyword = textBox_keyword_search.Text;
                totalkeyword = "q=" + keyword + "&";
                param = param + 1;

            }

            #endregion

            #region country
            var country = "";
            var totalcountry = "";

            if (textBox_country_search.Text == "")
            {
                totalcountry = "";
            }
            else if (textBox_country_search.Text != "")
            {
                country = textBox_country_search.Text;
                totalcountry = "country=" + country + "&";
                errors = errors + 1;
                param = param + 1;
            }
            #endregion


            #region source
            var source = "";
            var totalsource = "";

            if (textBox_source_search.Text == "")
            {
                totalsource = "";
            }
            else if (textBox_source_search.Text != "")
            {
                source = textBox_source_search.Text;
                totalsource = "sources=" + source + "&";
                errors = errors + 1;
                param = param + 1;
            }

            #endregion

            if (errors >= 2)
            {
                MessageBox.Show("You cannot search with country and source parameters at the same time");
            }
            else if (param < 1)
            {
                //  MessageBox.Show("You need to have one parameter at least");
            }
            else
            {

                var url = "https://newsapi.org/v2/top-headlines?" + totalkeyword +
                    totalcountry + totalsource +
                    "apiKey=fba415c197974798bd1833b9f86de604";
                // MessageBox.Show(url);
                var json = new WebClient().DownloadString(url);
                //MessageBox.Show("Search Ok");



                var jPerson = JsonConvert.DeserializeObject<dynamic>(json);




                if (jPerson.totalResults < 1)
                {
                    MessageBox.Show("There is no headlines news about this"); ;
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
                        API.Instance.url2 = num.url;
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

                    ShowForm(Home.Instance);

                }

                if (jPerson.totalResults == 1)
                {
                    Article.Instance.ResetArticle2();
                    Article.Instance.ResetArticle3();
                }
                else if (jPerson.totalResults == 2)
                {
                    Article.Instance.ResetArticle3();
                }


            }




        }

        public void showarticle(string source, string author, string content, string date, string description, string title, string image, string url)
        {
            callapi();
            Article.Instance.FeedArticle(source,author,content,date,description,title,image,url);
        }



        private void button_from_search_to_pref_Click(object sender, EventArgs e)
        {
            ShowForm(Preferences.Instance);
        }
    }
}
