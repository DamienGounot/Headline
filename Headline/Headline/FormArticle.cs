using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Headline
{
    public partial class FormArticle : Form
    {
        

        public FormArticle(int index)
        {
            InitializeComponent();
            List<Research.Article> articles = API.AllAPI.Instance.GetLastResearchedArticles();

            article_title.Text = articles[index].title;
            article_date.Text = articles[index].date;
            pictureBox6.ImageLocation = articles[index].image;
            linkLabel4.Text = articles[index].url;
            article_description.Text = articles[index].description;
            article_author.Text = articles[index].author;
            article_source.Text = articles[index].source;
            article_content.Text = articles[index].content;

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel4.Text);
        }
    }
}
