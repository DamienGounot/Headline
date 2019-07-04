using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormHome : Form
    {
        public int Index = 0;
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

            for (int i = 0; i < GetNumberOfArticles(); i++)
            {
                UcArticle uc = new UcArticle();
                uc.FormContainer = FormContainer.Instance;
                uc.Artickle = articles[i];
                uc.Location = new System.Drawing.Point((i * uc.Width) + 10, 200);
                Home_Panel.Controls.Add(uc);
            }
        }

        private List<Search.Article> GetArticlesToDisplay(bool previous = false, bool next = false)
        {
            if (previous) { Index -= GetNumberOfArticles(); Index = Math.Max(Index, 0); }
            if (next) { Index += GetNumberOfArticles(); Index = Math.Min(Index, articles.Count - GetNumberOfArticles()); }
            List<Search.Article> articlesToDisplay = new List<Search.Article>();
            for (int i = 0; i < GetNumberOfArticles(); i++)
                articlesToDisplay.Add(articles[Index + i]);


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
            for (int i = 0; i < 2; i++)
            {
                foreach (System.Windows.Forms.Control c in Home_Panel.Controls)
                {
                    if (c.GetType() == typeof(UcArticle))
                        Home_Panel.Controls.Remove(c);
                }
            }    
        }

        private int GetNumberOfArticles()
        {
            return this.Home_Panel.Size.Width / 230;

        }
    }
}
