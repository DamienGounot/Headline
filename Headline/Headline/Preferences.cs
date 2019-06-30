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
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }




        private static Preferences _instance;

        public static Preferences Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Preferences();
                return _instance;

            }
        }


        private void Preferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }

        private void butn_home_pref_Click(object sender, EventArgs e)
        {
            ShowForm(Home.Instance);
        }

        private void btn_save_pref_Click(object sender, EventArgs e)
        {
            DB.Instance.UpdateUserPref(Login.username, Preferences.Instance.textBox_keyword_pref.Text, Preferences.Instance.textBox_country_pref.Text);
            MessageBox.Show("Update Preferences succes");
            ShowForm(Home.Instance);

        }

    }
}
