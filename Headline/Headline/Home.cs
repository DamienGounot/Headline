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

        #region Home page
        // Home Page

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
            Search.Instance.showarticle(Init.Instance.source1, Init.Instance.author1, Init.Instance.content1, Init.Instance.date1, Init.Instance.description1, Init.Instance.title1, Init.Instance.image1, Init.Instance.url1);
            ShowForm(Article.Instance);
            Init.Instance.urlweb = Init.Instance.url1;



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Search.Instance.showarticle(Init.Instance.source2, Init.Instance.author2, Init.Instance.content2, Init.Instance.date2, Init.Instance.description2, Init.Instance.title2, Init.Instance.image2, Init.Instance.url2);
            ShowForm(Article.Instance);
            Init.Instance.urlweb = Init.Instance.url2;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search.Instance.showarticle(Init.Instance.source3, Init.Instance.author3, Init.Instance.content3, Init.Instance.date3, Init.Instance.description3, Init.Instance.title3, Init.Instance.image3, Init.Instance.url3);
            ShowForm(Article.Instance);
            Init.Instance.urlweb = Init.Instance.url3;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            ShowForm(Login.Instance);

        }

        #endregion

    }
}
