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



namespace Headline
{
    public partial class Form1 : Form
    {

        #region init
        string source1 = "";
        string author1 = "";
        string date1 = "";
        string description1 = "";
        string title1 = "";
        string content1 = "";
        string image1;

        string source2 = "";
        string author2 = "";
        string date2 = "";
        string description2 = "";
        string title2 = "";
        string content2 = "";
        string image2;

        string source3 = "";
        string author3 = "";
        string date3 = "";
        string description3 = "";
        string title3 = "";
        string content3 = "";
        string image3;

        string favoriteKeyword;
        string favoriteCountry;
        string initURL;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region Login Page
        // Login Page

        private void button_login_Click_1(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Error : username and password are required");
            }
            else
            {
                // MySqlConnection connection = new MySqlConnection(@"Data Source=sql184.main-hosting.eu; Initial Catalog=u173266564_mydb; User=u173266564_root; Password=rootroot");
                // MySqlCommand querry = new MySqlCommand("SELECT * FROM Users WHERE Username='" + textBox_username.Text + "' AND Password='" + textBox_password.Text + "'", connection);

                string sql = "SELECT * FROM Users WHERE Username='" + textBox_username.Text + "' AND Password='" + textBox_password.Text + "'";


                // MySqlDataReader reader = querry.ExecuteReader();
                SqlDataReader reader = DB.Instance.GetDataReader(sql);

                if (reader.Read()) // si le login est OK
                {
                    MessageBox.Show("login succes");
                    Login_Panel.Visible = true;
                    Registration_Panel.Visible = true;
                    Home_Panel.Visible = true; // on affiche le panel home
                    reader.Close();

                    this.Text = "Home"; // on change le text du form sur home
                    string sqlpref = "SELECT favoriteKeyword,favoriteCountry FROM Users WHERE Username='" + textBox_username.Text + "'";
                    SqlDataReader retrievePref = DB.Instance.GetDataReader(sqlpref);
                    while (retrievePref.Read())
                    {
                        favoriteKeyword = retrievePref.GetString(0);
                        favoriteCountry = retrievePref.GetString(1);

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

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Text = "Registration";
            Home_Panel.Visible = false;
            Login_Panel.Visible = true;
            Registration_Panel.Visible = true; // on affiche le panel pour s'enregistrer

        }



        private void initapi()
        {


            if (favoriteCountry !="" || favoriteKeyword !="") {


                 initURL = "https://newsapi.org/v2/top-headlines?" + "q=" + favoriteKeyword + "&country=" +
    favoriteCountry +
    "&apiKey=fba415c197974798bd1833b9f86de604";
            }
            else
            {
                 initURL = "https://newsapi.org/v2/top-headlines?country=us&apiKey=fba415c197974798bd1833b9f86de604";
            }





            var json = new WebClient().DownloadString(initURL);



            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);

            var i = 1;
            foreach (var num in jPerson.articles)
            {


                if (i == 1)
                {
                    source1 = num.source.name;
                    author1 = num.author;
                    content1 = num.content;
                    date1 = num.publishedAt;
                    description1 = num.description;
                    title1 = num.title;
                    image1 = num.urlToImage;

                    pictureBoxArticle1.ImageLocation = num.urlToImage;
                    titlehome1.Text = num.title;





                }
                else if (i == 2)
                {

                    source2 = num.source.name;
                    author2 = num.author;
                    content2 = num.content;
                    date2 = num.publishedAt;
                    description2 = num.description;
                    title2 = num.title;
                    image2 = num.urlToImage;

                    pictureBoxArticle2.ImageLocation = num.urlToImage;
                    titlehome2.Text = num.title;
                }
                else if (i == 3)
                {

                    source3 = num.source.name;
                    author3 = num.author;
                    content3 = num.content;
                    date3 = num.publishedAt;
                    description3 = num.description;
                    title3 = num.title;
                    image3 = num.urlToImage;

                    pictureBoxArticle3.ImageLocation = num.urlToImage;
                    titlehome3.Text = num.title;
                }

                i++;


            }


        }


        #endregion

        #region Registration page

        // Registration Page

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (username.Text == "" || email.Text == "" || password.Text == "" || confirm.Text == "")
            {
                MessageBox.Show("Error : every fields are required");
                error = true;

            }

            if (password.Text != confirm.Text)
            {
                MessageBox.Show("Error : password not match");
                error = true;
            }

            if (!error)
            {


                error = false;
                // MySqlCommand querry = new MySqlCommand("SELECT * FROM Users WHERE Username='" + username.Text + "'", connection);
                // MySqlDataReader reader = querry.ExecuteReader();

                string sql = "SELECT * FROM Users WHERE Username='" + username.Text + "'";
                SqlDataReader reader = DB.Instance.GetDataReader(sql);

                if (reader.Read()) // si user exist
                {
                    MessageBox.Show("this username is already used");
                    error = true;
                }

                reader.Close();

                // MySqlCommand querryMail = new MySqlCommand("SELECT * FROM Users WHERE email='" + email.Text + "'", connection);
                //MySqlDataReader readerMail = querryMail.ExecuteReader();

                string querryMail = "SELECT * FROM Users WHERE email='" + email.Text + "'";
                SqlDataReader readerMail = DB.Instance.GetDataReader(querryMail);


                if (readerMail.Read()) // si mail exist
                {
                    MessageBox.Show("this email is already used");
                    error = true;
                }

                readerMail.Close();

                if (!error)
                {

                    string insertQuerry = "INSERT INTO Users (username, email, password) VALUES ('" + username.Text + "','" + email.Text + "','" + password.Text + "')";

                    // MySqlCommand insertNewUser = new MySqlCommand(insertQuerry, connection);
                    //MySqlDataReader readerInsert = insertNewUser.ExecuteReader();

                    SqlDataReader readerInsert = DB.Instance.GetDataReader(insertQuerry);

                    MessageBox.Show("Your account has been created succesfully");
                    readerInsert.Close();

                }


            }

        }

        private void button_home_from_reg_Click(object sender, EventArgs e)
        {
            this.Text = "Login";
            Registration_Panel.Visible = false;

        }


        #endregion

        #region Home page
        // Home Page

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            this.Text = "Search";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
        }

        private void btn_Pref_Click_1(object sender, EventArgs e)
        {
            this.Text = "Preferences";
            preferences_panel.Visible = true;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showarticle(source1, author1, content1, date1, description1, title1,image1);
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
            
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showarticle(source2, author2, content2, date2, description2, title2,image2);
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showarticle(source3, author3, content3, date3, description3, title3,image3);
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
        }

        #endregion

        #region Preferences page
        // Preferences Page

        private void butn_home_pref_Click(object sender, EventArgs e)
        {
            this.Text = "Home";
            preferences_panel.Visible = false;
            search_panel.Visible = false;
        }

        private void btn_save_pref_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Users SET favoriteKeyword='" + textBox_keyword_pref.Text + "', favoriteCountry='" + textBox_country_pref.Text + "' WHERE Username='" + textBox_username.Text + "'";
            SqlDataReader updatePref = DB.Instance.GetDataReader(sql);
            MessageBox.Show("Update Preferences succes");
            updatePref.Close();

        }
        #endregion

        #region Search page
        // Search Page

        private void button_home_from_search_Click(object sender, EventArgs e)
        {
            this.Text = "Home";
            search_panel.Visible = false;
            preferences_panel.Visible = false;
        }

        private void button_make_search_Click(object sender, EventArgs e)
        {
            callapi();
        }


        private void showarticle(string source, string author, string content, string date, string description, string title,string image)
        {
            callapi();
            article_source.Text = source;
            article_author.Text = author;
            article_content.Text = content;
            article_date.Text = date;
            article_description.Text = description;
            article_title.Text = title;
            pictureBox6.ImageLocation = image;

        }

        #region newsapi
        private void callapi(){

            var errors = 0;
            var param=0;

            #region keyword

            var keyword = "";
            var totalkeyword = "";

            if (textBox_keyword_search.Text == "")
            {                
                totalkeyword = "";
            }
            else if (textBox_keyword_search.Text!="")
            {
                keyword = textBox_keyword_search.Text;
                totalkeyword = "q=" + keyword + "&";
                param = param + 1;
                
            }

            #endregion

            #region country
            var country = "";
            var totalcountry = "";

            if (textBox_country_search.Text=="")
            {
                totalcountry = "";
            }else if (textBox_country_search.Text!="")
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

            if (textBox_source_search.Text=="")
            {
                totalsource = "";
            }else if (textBox_source_search.Text!="")
            {
                source = textBox_source_search.Text;
                totalsource= "sources=" + source + "&";
                errors = errors + 1;
                param = param + 1;
            }

            #endregion

            if (errors >= 2)
            {
                MessageBox.Show("You cannot search with country and source parameters at the same time");
            }else if (param<1)
            {
              //  MessageBox.Show("You need to have one parameter at least");
            }
            else
            {

                var url = "https://newsapi.org/v2/top-headlines?" + totalkeyword +
                    totalcountry + totalsource +
                    "apiKey=fba415c197974798bd1833b9f86de604";
                MessageBox.Show(url);
                var json = new WebClient().DownloadString(url);



                var jPerson = JsonConvert.DeserializeObject<dynamic>(json);

                var i = 1;
                foreach (var num in jPerson.articles)
                {
                   

                    if (i == 1)
                    {
                        source1 = num.source.name;
                        author1 = num.author;
                        content1 = num.content;
                        date1 = num.publishedAt;
                        description1 = num.description;
                        title1 = num.title;
                        image1 = num.urlToImage;

                        pictureBoxArticle1.ImageLocation = num.urlToImage;
                        titlehome1.Text = num.title;
                  




                    }else if (i == 2)
                    {

                        source2 = num.source.name;
                        author2 = num.author;
                        content2 = num.content;
                        date2 = num.publishedAt;
                        description2 = num.description;
                        title2 = num.title;
                        image2 = num.urlToImage;

                        pictureBoxArticle2.ImageLocation = num.urlToImage;
                        titlehome2.Text = num.title;
                    }
                    else if (i == 3)
                    {

                        source3 = num.source.name;
                        author3 = num.author;
                        content3 = num.content;
                        date3 = num.publishedAt;
                        description3 = num.description;
                        title3 = num.title;
                        image3 = num.urlToImage;

                        pictureBoxArticle3.ImageLocation = num.urlToImage;
                        titlehome3.Text = num.title;
                    }

                    i++;
                    

                }


            }
            
            
            
           
        }



     

        #endregion



        private void button_from_search_to_pref_Click_1(object sender, EventArgs e)
        {
            this.Text = "Preferences";
            search_panel.Visible = false;
        }
        #endregion


        #region Article page
        // Article Page
        private void btn_article_toSearch_Click(object sender, EventArgs e)
        {
            this.Text = "Search";
            panel_article.Visible = false;
        }

        private void btn_article_toPref_Click(object sender, EventArgs e)
        {
            this.Text = "Preferences";
            panel_article.Visible = false;
            search_panel.Visible = false;
        }

        private void btn_article_toHome_Click_1(object sender, EventArgs e)
        {
            this.Text = "Home";
            panel_article.Visible = false;
            search_panel.Visible = false;
            preferences_panel.Visible = false;
            Home_Panel.Visible = true;
        }


        #endregion

    }
}
