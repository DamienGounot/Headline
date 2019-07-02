using System;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormPreferences : Form
    {
        public FormPreferences()
        {
            InitializeComponent();
        }




        private static FormPreferences _instance;

        public static FormPreferences Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormPreferences();
                return _instance;

            }
        }


        private void Preferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void goHome(int count, string keyword, string country, string sources)
        {
            UI.NavigationBar.Instance.Connexion();
            FormHome Home = new FormHome(count, keyword, country, sources);
            Home.MdiParent = this.MdiParent;
            Home.Show();
            Home.WindowState = FormWindowState.Maximized;
            this.Hide();
        }

        private void btn_save_pref_Click(object sender, EventArgs e)
        {
            DataBase.DB.Instance.UpdateUserPref(FormLogin.username, textBox_keyword_pref.Text,textBox_country_pref.Text);
            label_save.Visible = true;


        }

        private void textBox_country_pref_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_save.Visible = false;
        }

        private void textBox_keyword_pref_TextChanged(object sender, EventArgs e)
        {
            label_save.Visible = false;
        }
    }
}
