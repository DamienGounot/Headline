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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (isNotCompleted())
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

                if (DB.Instance.CheckUserNotRegistered(username.Text)) // si user exist
                {
                    MessageBox.Show("this username is already used");
                    error = true;
                    username.Text = "";
                }



                if (DB.Instance.CheckEmailNotRegistered(email.Text)) // si mail exist
                {
                    MessageBox.Show("this email is already used");
                    error = true;
                    email.Text = "";
                }

                if (!error)
                {

                    DB.Instance.InsertNewUser(username.Text, email.Text, password.Text);
                    MessageBox.Show("Your account has been created succesfully");
                    ShowForm(Login_form.Instance);
                    reset();
                }
            }
        }

        private void button_home_from_reg_Click(object sender, EventArgs e)
        {
            ShowForm(Login_form.Instance);
            reset();

        }



        private void reset()
        {
            username.Text = "";
            email.Text = "";
            password.Text = "";
            confirm.Text = "";
        }

        private bool isNotCompleted()
        {
            if (username.Text == "" || email.Text == "" || password.Text == "" || confirm.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
