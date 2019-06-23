﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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

                    this.Text = "Home"; // on change le text du form sur home

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                }

                reader.Close();
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Text = "Registration";
            Home_Panel.Visible = false;
            Login_Panel.Visible = true;
            Registration_Panel.Visible = true; // on affiche le panel pour s'enregistrer

        }


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
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Text = "Article";
            preferences_panel.Visible = true;
            search_panel.Visible = true;
            panel_article.Visible = true;
        }

        // Preferences Page

        private void butn_home_pref_Click_1(object sender, EventArgs e)
        {
            this.Text = "Home";
            preferences_panel.Visible = false;
            search_panel.Visible = false;
        }

        private void btn_save_pref_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");

        }


        // Search Page


        private void button_home_from_search_Click_1(object sender, EventArgs e)
        {
            this.Text = "Home";
            search_panel.Visible = false;
            preferences_panel.Visible = false;
        }

        private void button_make_search_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Not Implemented Yet");

            callapi();

        }


        #region newsapi
        private void callapi(){
            
       
          
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
            }

            #endregion
            
            var url = "https://newsapi.org/v2/top-headlines?" + totalkeyword+
                    totalcountry + totalsource +
                    "apiKey=fba415c197974798bd1833b9f86de604";
            MessageBox.Show(url);
            var json = new WebClient().DownloadString(url);



            var jPerson = JsonConvert.DeserializeObject<dynamic>(json);


            foreach(var num in jPerson.articles)
            {
                article_source.Text = num.source.name;
                article_author.Text = num.author;
                article_content.Text = num.content;
                article_date.Text = num.publishedAt;
                article_description.Text = num.description;
                article_title.Text = num.title;

            }
            
           
        }

        #endregion



        private void button_from_search_to_pref_Click(object sender, EventArgs e)
        {
            this.Text = "Preferences";
            search_panel.Visible = false;
        }

        // Article Page


        private void btn_article_toSearch_Click_1(object sender, EventArgs e)
        {
            this.Text = "Search";
            panel_article.Visible = false;
        }

        private void btn_article_toPref_Click_1(object sender, EventArgs e)
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
    }
}
