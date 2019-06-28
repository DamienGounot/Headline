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
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }



        public static Article _instance;

        public static Article Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Article();
                return _instance;

            }

        }


        private void Article_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }





        #region Article page
        // Article Page
        private void btn_article_toSearch_Click(object sender, EventArgs e)
        {
            ShowForm(Search.Instance);
        }

        private void btn_article_toPref_Click(object sender, EventArgs e)
        {
            ShowForm(Preferences.Instance);
        }

        private void btn_article_toHome_Click(object sender, EventArgs e)
        {
            ShowForm(Home.Instance);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Init.Instance.urlweb);
        }
        #endregion

        public void FeedArticle(string source, string author, string content, string date, string description, string title, string image, string url)
        {
            Instance.article_source.Text = source;
            Instance.article_author.Text = author;
            Instance.article_content.Text = content;
            Instance.article_date.Text = date;
            Instance.article_description.Text = description;
            Instance.article_title.Text = title;
            Instance.pictureBox6.ImageLocation = image;
            Instance.linkLabel4.Text = url;
           
        }

    }
}
