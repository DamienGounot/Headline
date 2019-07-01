using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;

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
            this.Hide();
        }

        private void btn_save_pref_Click(object sender, EventArgs e)
        {
            UI.NavigationBar.Instance.Connexion();
            DataBase.DB.Instance.UpdateUserPref(FormLogin.username, textBox_keyword_pref.Text,textBox_country_pref.Text);
            MessageBox.Show("Update Preferences succes");
            goHome(5, FormPreferences.Instance.textBox_keyword_pref.Text, FormPreferences.Instance.textBox_country_pref.Text, "");

        }
    }
}
