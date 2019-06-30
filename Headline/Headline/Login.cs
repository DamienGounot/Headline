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
    public partial class Login : Form
    {
        public  Login()
        {
            InitializeComponent();
        }



        public static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;

            }
        }


        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        public void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }


        #region Login Page
        // Login Page

        public void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Error : username and password are required");
            }
            else
            {

                string sql = "SELECT * FROM Users WHERE Username='" + textBox_username.Text + "' AND Password='" + textBox_password.Text + "'";

                SqlDataReader reader = DB.Instance.GetDataReader(sql);

                if (reader.Read()) // si le login est OK
                {
                    MessageBox.Show("login succes");

                    ShowForm(Home.Instance);

                    Init.Instance.username = textBox_username.Text;

                    reader.Close();

                    string sqlpref = "SELECT favoriteKeyword,favoriteCountry FROM Users WHERE Username='" + textBox_username.Text + "'";
                    SqlDataReader retrievePref = DB.Instance.GetDataReader(sqlpref);
                    while (retrievePref.Read())
                    {
                        Init.Instance.favoriteKeyword = retrievePref.GetString(0);
                        Init.Instance.favoriteCountry = retrievePref.GetString(1);

                    }
                    retrievePref.Close();

                    initapi();





                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                }


            }
        }

        public void button_register_Click(object sender, EventArgs e)
        {
            ShowForm(Registration.Instance);
        }



        public void initapi()
        {


            if (Init.Instance.favoriteCountry != "" || Init.Instance.favoriteKeyword != "")
            {


                Init.Instance.initURL = "https://newsapi.org/v2/top-headlines?" + "q=" + Init.Instance.favoriteKeyword + "&country=" +
   Init.Instance.favoriteCountry +
   "&apiKey=fba415c197974798bd1833b9f86de604";
            }
            else
            {
                Init.Instance.initURL = "https://newsapi.org/v2/top-headlines?country=us&apiKey=fba415c197974798bd1833b9f86de604";
            }





            var json = new WebClient().DownloadString(Init.Instance.initURL);





            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);

            if (jPerson.totalResults == 0)
            {
                MessageBox.Show("There is no top headlines about your preferences");
                Init.Instance.initURL = "https://newsapi.org/v2/top-headlines?country=us&apiKey=fba415c197974798bd1833b9f86de604";
                json = new WebClient().DownloadString(Init.Instance.initURL);
                jPerson = JsonConvert.DeserializeObject<dynamic>(json);

            }



            var i = 1;
            foreach (var num in jPerson.articles)
            {


                if (i == 1)
                {
                    Init.Instance.source1 = num.source.name;
                    Init.Instance.author1 = num.author;
                    Init.Instance.content1 = num.content;
                    Init.Instance.date1 = num.publishedAt;
                    Init.Instance.description1 = num.description;
                    Init.Instance.title1 = num.title;
                    Init.Instance.image1 = num.urlToImage;

                    Home.Instance.SetArticlesLink1(Init.Instance.title1,Init.Instance.image1);
  
                    Init.Instance.url1 = num.url;





                }
                else if (i == 2)
                {

                    Init.Instance.source2 = num.source.name;
                    Init.Instance.author2 = num.author;
                    Init.Instance.content2 = num.content;
                    Init.Instance.date2 = num.publishedAt;
                    Init.Instance.description2 = num.description;
                    Init.Instance.title2 = num.title;
                    Init.Instance.image2 = num.urlToImage;

                    Home.Instance.SetArticlesLink2(Init.Instance.title2,Init.Instance.image2);

                    Init.Instance.url2 = num.url2;
                }
                else if (i == 3)
                {

                    Init.Instance.source3 = num.source.name;
                    Init.Instance.author3 = num.author;
                    Init.Instance.content3 = num.content;
                    Init.Instance.date3 = num.publishedAt;
                    Init.Instance.description3 = num.description;
                    Init.Instance.title3 = num.title;
                    Init.Instance.image3 = num.urlToImage;

                    Home.Instance.SetArticlesLink3(Init.Instance.title3, Init.Instance.image3);

                    Init.Instance.url3 = num.url;
                }

                i++;


            }


        }


        #endregion

 
    }
}
