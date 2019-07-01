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
    public partial class FormLogin : Form
    {
        public static string username;
        public static string favoriteKeyword;
        public static string favoriteCountry;
        public static string initURL;

        public FormLogin()
        {
            InitializeComponent();
        }
        public static FormLogin _instance;

        public static FormLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormLogin();
                return _instance;

            }
        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }

        public void ShowForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Hide();
        }





        private void button_login_Click(object sender, EventArgs e)
        {

            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Error : username and password are required");
            }
            else
            {



                if (DataBase.DB.Instance.CheckLogin(textBox_username.Text, textBox_password.Text)) // si le login est OK
                {
                    MessageBox.Show("login succes");
                    username = textBox_username.Text;
                    favoriteCountry = DataBase.DB.Instance.GetFavoriteCountry(username);
                    favoriteKeyword = DataBase.DB.Instance.GetFavoriteKeyword(username);

                    LoginResearch(favoriteCountry, favoriteKeyword);
                    UI.NavigationBar.Instance.Connexion();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    reset();
                }


            }
        }


        private void LoginResearch(string favoriteCountry,string favoriteKeyword)
        {
            if ((favoriteCountry == " " || favoriteKeyword == " " ) || (favoriteCountry == "" && favoriteKeyword == ""))
            {
                FormHome mainform = new FormHome(1, "", "us", "");
                mainform.MdiParent = this.MdiParent;
                mainform.Show();
                this.Hide();
            }
            else
            {
                FormHome mainform = new FormHome(1, favoriteKeyword, favoriteCountry, "");
                mainform.MdiParent = this.MdiParent;
                mainform.Show();
                this.Hide();
            }
        }

        private void reset()
        {
            textBox_username.Text = "";
            textBox_password.Text = "";
        }

 
    }
}
