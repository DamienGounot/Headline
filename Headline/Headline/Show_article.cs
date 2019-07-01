using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headline
{
    public partial class Show_article : Form
    {
        

        public Show_article(int index)
        {
            InitializeComponent();
            List<article1> articles = allAPI.Instance.GetLastResearchedArticles();

            article_title.Text = articles[index].title;
            article_date.Text = articles[index].date;
            pictureBox6.ImageLocation = articles[index].image;
            linkLabel4.Text = articles[index].url;
            article_description.Text = articles[index].description;
            article_author.Text = articles[index].author;
            article_source.Text = articles[index].source;
            article_content.Text = articles[index].content;

        }

        private void btn_article_toSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void btn_article_toHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_form home = new Home_form(5,"keyword","country","sources");
            home.Show();
           
        }

        private void btn_article_toPref_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preferences pref = new Preferences();
            pref.Show();
        }
    }
}
