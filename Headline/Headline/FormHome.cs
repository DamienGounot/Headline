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
    public partial class FormHome : Form
    {
        public int which_article = 0;
        public int index;

        public FormHome(int count,string keyword, string country, string sources)
        {
            InitializeComponent();

            if (count > 0)
            {
                if (count!=5)
                {
                    API.AllAPI.Instance.search(keyword, country, sources);
                }
               
                List<Research.Article> articles = API.AllAPI.Instance.GetLastResearchedArticles();

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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.NavigationBar.Instance.Article();
            FormArticle articlepage = new FormArticle(which_article);
            articlepage.MdiParent = this.MdiParent;
            articlepage.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.NavigationBar.Instance.Article();
            FormArticle articlepage = new FormArticle(which_article+1);
            articlepage.MdiParent = this.MdiParent;
            articlepage.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.NavigationBar.Instance.Article();
            FormArticle articlepage = new FormArticle(which_article+2);
            articlepage.MdiParent = this.MdiParent;
            articlepage.Show();
            this.Hide();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (which_article < 15)
            {
                which_article = which_article + 3;
            }
            List<Research.Article> articles = API.AllAPI.Instance.GetLastResearchedArticles();

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
            List<Research.Article> articles = API.AllAPI.Instance.GetLastResearchedArticles();
            
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
