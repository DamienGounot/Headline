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
    public partial class Search : Form
    {

        public static Search Instance;
        public static string keyword;
        public static string country;
        public static string source;




       

        public Search()
        {
            InitializeComponent();
            Instance = this;
        }


      
        private void button_home_from_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_form home = new Home_form(5, "keyword", "country", "sources");
            home.Show();
        }

        private void button_from_search_to_pref_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preferences pref = new Preferences();
            pref.Show();
        }

        public void button_make_search_Click(object sender, EventArgs e)
        {
            keyword = textBox_keyword_search.Text;
            country = textBox_country_search.Text;
            source= textBox_source_search.Text;
            this.Hide();
            int b = 1;
            Home_form mainform = new Home_form(b,keyword,country,source);           
            mainform.Show();
        }
    }
}
