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
    public partial class Home_form : Form
    {
        public int which_article = 0;
        public int index;

        public Home_form(int count,string keyword, string country, string sources)
        {
            InitializeComponent();

            if (count > 0)
            {
                if (count!=5)
                {
                    allAPI.Instance.search(keyword, country, sources);
                }
               
                List<article1> articles = allAPI.Instance.GetLastResearchedArticles();

                if (articles.Count >= 1)
                {
                    titlehome1.Text = articles[which_article+0].title;
                    pictureBoxArticle1.ImageLocation = articles[which_article+0].image;
                }

                if (articles.Count >= 2)
                {
                    titlehome2.Text = articles[which_article+1].title;
                    pictureBoxArticle2.ImageLocation = articles[which_article+1].image;
                }

                if (articles.Count >= 3)
                {
                    titlehome3.Text = articles[which_article+2].title;
                    pictureBoxArticle3.ImageLocation = articles[which_article+2].image;
                }
                         

            }
        }




        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form login = new Login_form();
            login.Show();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void btn_Pref_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preferences pref = new Preferences();
            pref.Show();
        }

        private void titlehome1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxArticle1_Click(object sender, EventArgs e)
        {
   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

          
            Show_article articlepage = new Show_article(which_article);
            articlepage.Show();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

           
            Show_article articlepage = new Show_article(which_article+1);
            articlepage.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

           
            Show_article articlepage = new Show_article(which_article+2);
            articlepage.Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (which_article < 15)
            {
                which_article = which_article + 3;
            }
            List<article1> articles = allAPI.Instance.GetLastResearchedArticles();

            if (articles.Count >= 1)
            {
                titlehome1.Text = articles[which_article + 0].title;
                pictureBoxArticle1.ImageLocation = articles[which_article + 0].image;
            }

            if (articles.Count >= 2)
            {
                titlehome2.Text = articles[which_article + 1].title;
                pictureBoxArticle2.ImageLocation = articles[which_article + 1].image;
            }

            if (articles.Count >= 3)
            {
                titlehome3.Text = articles[which_article + 2].title;
                pictureBoxArticle3.ImageLocation = articles[which_article + 2].image;
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (which_article >= 3)
            {
                which_article = which_article - 3;
            }
            List<article1> articles = allAPI.Instance.GetLastResearchedArticles();
            
            if (articles.Count >= 1)
            {
                titlehome1.Text = articles[which_article + 0].title;
                pictureBoxArticle1.ImageLocation = articles[which_article + 0].image;
            }

            if (articles.Count >= 2)
            {
                titlehome2.Text = articles[which_article + 1].title;
                pictureBoxArticle2.ImageLocation = articles[which_article + 1].image;
            }

            if (articles.Count >= 3)
            {
                titlehome3.Text = articles[which_article + 2].title;
                pictureBoxArticle3.ImageLocation = articles[which_article + 2].image;
            }
        }
    }
}
