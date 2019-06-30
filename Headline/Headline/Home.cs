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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private static Home _instance;

        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;

            }
        }

        private void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }


        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

    

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowForm(Search.Instance);
        }

        private void btn_Pref_Click(object sender, EventArgs e)
        {
            ShowForm(Preferences.Instance);
        }

        public void SetArticlesLink1(string text1,string imageLocation1)
        {
            this.pictureBoxArticle1.ImageLocation = imageLocation1;
            this.titlehome1.Text = text1;

        }

        public void SetArticlesLink2(string text2,string imageLocation2)
        {

            this.pictureBoxArticle2.ImageLocation = imageLocation2;
           this.titlehome2.Text = text2;
  
        }

        public void SetArticlesLink3(string text3, string imageLocation3)
        {

            this.pictureBoxArticle3.ImageLocation = imageLocation3;
            this.titlehome3.Text = text3;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search.Instance.showarticle(API.Instance.source1, API.Instance.author1, API.Instance.content1, API.Instance.date1, API.Instance.description1, API.Instance.title1, API.Instance.image1, API.Instance.url1);
            ShowForm(Article.Instance);
            API.Instance.urlweb = API.Instance.url1;



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Search.Instance.showarticle(API.Instance.source2, API.Instance.author2, API.Instance.content2, API.Instance.date2, API.Instance.description2, API.Instance.title2, API.Instance.image2, API.Instance.url2);
            ShowForm(Article.Instance);
            API.Instance.urlweb = API.Instance.url2;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search.Instance.showarticle(API.Instance.source3, API.Instance.author3, API.Instance.content3, API.Instance.date3, API.Instance.description3, API.Instance.title3, API.Instance.image3, API.Instance.url3);
            ShowForm(Article.Instance);
            API.Instance.urlweb = API.Instance.url3;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            ShowForm(Login.Instance);

        }


    }
}
