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
            UI.NavigationBar.Instance.Connexion();
            keyword = textBox_keyword_search.Text;
            country = textBox_country_search.Text;
            source= textBox_source_search.Text;
            int b = 1;
            FormHome mainform = new FormHome(b,keyword,country,source);
            mainform.MdiParent = this.MdiParent;
            mainform.Show();
            this.Hide();
        }
    }
}
