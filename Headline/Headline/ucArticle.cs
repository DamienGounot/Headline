using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headline
{
    public partial class UcArticle : UserControl
    {
        public Form MdiForm { get; set; }

        public UcArticle()
        {
            InitializeComponent();
        }

        public Search.Article article;

        public Search.Article Artickle
        {
            get { return article; }
            set {
                if (value != article)
                {
                    article = value;
                    titlehome1.Text = article.title;
                    pictureBoxArticle1.ImageLocation = article.image;
                }
            }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.NavigationBar.Instance.Article();
            FormArticle articlepage = new FormArticle(article);
            articlepage.MdiParent = MdiForm;
            articlepage.Show();
            articlepage.WindowState = FormWindowState.Maximized;
        }
    }
}
