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
    public partial class Login_form : Form
    {
        public static string username;
        public static string favoriteKeyword;
        public static string favoriteCountry;
        public static string initURL;

        public Login_form()
        {
            InitializeComponent();
        }
        public static Login_form _instance;

        public static Login_form Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login_form();
                return _instance;

            }
        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }

        public void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
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



                if (DB.Instance.CheckLogin(textBox_username.Text, textBox_password.Text)) // si le login est OK
                {
                    MessageBox.Show("login succes");
                    username = textBox_username.Text;
                    favoriteCountry = DB.Instance.GetFavoriteCountry(username);
                    favoriteKeyword = DB.Instance.GetFavoriteKeyword(username);

                    LoginResearch(favoriteCountry, favoriteKeyword);

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    reset();
                }


            }
        }

        private void button_register_Click_1(object sender, EventArgs e)
        {
            ShowForm(Registration.Instance);

        }

        private void LoginResearch(string favoriteCountry,string favoriteKeyword)
        {
            if ((favoriteCountry == " " || favoriteKeyword == " " ) || (favoriteCountry == "" && favoriteKeyword == ""))
            {
                Home_form mainform = new Home_form(1, "", "us", "");
                this.Hide();
                mainform.Show();
            }
            else
            {
                Home_form mainform = new Home_form(1, favoriteKeyword, favoriteCountry, "");
                this.Hide();
                mainform.Show();
            }
        }

        private void reset()
        {
            textBox_username.Text = "";
            textBox_password.Text = "";
        }

 
    }
}
