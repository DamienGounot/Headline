using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormHome : Form
    {
        public int which_article = 0;
        public int index;
        string keyword;
        string country;
        string sources;

        private List<Search.Article> articles;

        public FormHome(string keyword, string country, string sources)
        {
            InitializeComponent();
            this.keyword = keyword;
            this.country = country;
            this.sources = sources;
            GetListOfArticles();
            DisplayResults(GetArticlesToDisplay(false, false));

        }

        private void GetListOfArticles()
        {
            Cursor.Current = Cursors.WaitCursor;
            API.AllAPI.Instance.search(keyword, country, sources);
            articles = API.AllAPI.Instance.GetLastResearchedArticles();
            Cursor.Current = Cursors.Default;
        }

        private void DisplayResults(List<Search.Article> articles)
        {
            RemoveUserController();

            for (int i = 0; i < 3; i++)
            {
                UcArticle uc = new UcArticle();
                uc.FormContainer = FormContainer.Instance;
                uc.Artickle = articles[i];
                uc.Location = new System.Drawing.Point((i * uc.Width + 200) + 10, 200);
                Home_Panel.Controls.Add(uc);
            }           
        }

        private List<Search.Article> GetArticlesToDisplay(bool previous = false, bool next = false)
        {
            if (previous){which_article -= 3; which_article = Math.Max(which_article, 0);}
            if (next){ which_article += 3; which_article = Math.Min(which_article, articles.Count - 3);}
            List <Search.Article> articlesToDisplay = new List<Search.Article>();
            for(int i=0;i<3; i++)
            articlesToDisplay.Add(articles[which_article+i]);


            return articlesToDisplay;
        }


        private void button_next_Click(object sender, EventArgs e)
        {
            DisplayResults(GetArticlesToDisplay(false, true));
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
          DisplayResults(GetArticlesToDisplay(true, false));
        }

        private void RemoveUserController()
        {
            foreach (System.Windows.Forms.Control c in Home_Panel.Controls)
            {
                if (c.GetType() == typeof(UcArticle))
                    Home_Panel.Controls.Remove(c);
            }
            foreach (System.Windows.Forms.Control c in Home_Panel.Controls)
            {
                if (c.GetType() == typeof(UcArticle))
                    Home_Panel.Controls.Remove(c);
            }

        }
    }
}
