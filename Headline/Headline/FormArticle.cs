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

    }
}
