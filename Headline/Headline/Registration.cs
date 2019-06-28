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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private static Registration _instance;

        public static Registration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registration();
                return _instance;

            }
        }


        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void ShowForm(Form frm)
        {
            frm.Show();
            frm.Activate();
            this.Hide();
        }







        #region Registration page

        // Registration Page

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (username.Text == "" || email.Text == "" || password.Text == "" || confirm.Text == "")
            {
                MessageBox.Show("Error : every fields are required");
                error = true;

            }

            if (password.Text != confirm.Text)
            {
                MessageBox.Show("Error : password not match");
                error = true;
                password.Text = "";
                confirm.Text = "";
            }

            if (!error)
            {


                error = false;
                // MySqlCommand querry = new MySqlCommand("SELECT * FROM Users WHERE Username='" + username.Text + "'", connection);
                // MySqlDataReader reader = querry.ExecuteReader();

                string sql = "SELECT * FROM Users WHERE Username='" + username.Text + "'";
                SqlDataReader reader = DB.Instance.GetDataReader(sql);

                if (reader.Read()) // si user exist
                {
                    MessageBox.Show("this username is already used");
                    error = true;
                    username.Text = "";
                }

                reader.Close();

                // MySqlCommand querryMail = new MySqlCommand("SELECT * FROM Users WHERE email='" + email.Text + "'", connection);
                //MySqlDataReader readerMail = querryMail.ExecuteReader();

                string querryMail = "SELECT * FROM Users WHERE email='" + email.Text + "'";
                SqlDataReader readerMail = DB.Instance.GetDataReader(querryMail);


                if (readerMail.Read()) // si mail exist
                {
                    MessageBox.Show("this email is already used");
                    error = true;
                    email.Text = "";
                }

                readerMail.Close();

                if (!error)
                {
                    string space = "";
                    string insertQuerry = "INSERT INTO Users (username, email, password, favoriteKeyword, favoriteCountry) VALUES ('" + username.Text + "','" + email.Text + "','" + password.Text + "','" + space + "','" + space + "')";

                    // MySqlCommand insertNewUser = new MySqlCommand(insertQuerry, connection);
                    //MySqlDataReader readerInsert = insertNewUser.ExecuteReader();

                    SqlDataReader readerInsert = DB.Instance.GetDataReader(insertQuerry);

                    MessageBox.Show("Your account has been created succesfully");
                    readerInsert.Close();
                    ShowForm(Login.Instance);
                    username.Text = "";
                    email.Text = "";
                    password.Text = "";
                    confirm.Text = "";



                }


            }

        }

        private void button_home_from_reg_Click(object sender, EventArgs e)
        {
            ShowForm(Login.Instance);
            username.Text = "";
            email.Text = "";
            password.Text = "";
            confirm.Text = "";

        }


        #endregion


    }
}
