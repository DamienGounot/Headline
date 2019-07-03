using System;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormSearch : Form
    {

        public static FormSearch Instance;
        public static string keyword;
        public static string country;
        public static string source;




       

        public FormSearch()
        {
            InitializeComponent();
            Instance = this;
        }

        public void button_make_search_Click(object sender, EventArgs e)
        {
            keyword = textBox_keyword_search.Text;
            country = textBox_country_search.Text;
            source= textBox_source_search.Text;

            if (FormSearch.keyword != "" || FormSearch.country != "" || FormSearch.source != "")
            {
                UI.NavigationBar.Instance.Connexion();
                FormHome mainform = new FormHome(keyword, country, source);
                mainform.MdiParent = this.MdiParent;
                mainform.Show();
                mainform.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                label_error.Visible = true;
            }

        }
    }
}
