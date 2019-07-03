using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Headline
{
    public partial class FormArticle : Form
    {
        

        public FormArticle(Search.Article article)
        {
            InitializeComponent();
           
            article_title.Text = article.title;
            article_date.Text = article.date;
            pictureBox6.ImageLocation = article.image;
            linkLabel4.Text = article.url;
            article_description.Text = article.description;
            article_author.Text = article.author;
            article_source.Text = article.source;
            article_content.Text = article.content;

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel4.Text);
        }
    }
}
