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
    public partial class Login : Form
    {
        public static string username;
        public static string favoriteKeyword;
        public static string favoriteCountry;
        public static string initURL;



        public Login()
        {
            InitializeComponent();
        }

        public static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
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

        public void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Error : username and password are required");
            }
            else
            {



                if (DB.Instance.CheckLogin(textBox_username.Text,textBox_password.Text)) // si le login est OK
                {
                    MessageBox.Show("login succes");
                    ShowForm(Home.Instance);
                    Login.username = textBox_username.Text;

                    favoriteCountry = DB.Instance.GetFavoriteCountry(username);
                    favoriteKeyword = DB.Instance.GetFavoriteKeyword(username);
                    API.Instance.initapi();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                }


            }
        }

        public void button_register_Click(object sender, EventArgs e)
        {
            ShowForm(Registration.Instance);
        }



      



 
    }
}
