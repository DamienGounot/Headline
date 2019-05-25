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

namespace Headline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Error : username and password are required");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(@"Data Source=sql184.main-hosting.eu; Initial Catalog=u173266564_mydb; User=u173266564_root; Password=rootroot");
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);

                }

                MySqlCommand querry = new MySqlCommand("SELECT * FROM Users WHERE Username='" + textBox_username.Text + "' AND Password='" + textBox_password.Text + "'", connection);

                MySqlDataReader reader = querry.ExecuteReader();

                if (reader.Read()) // si le login est OK
                {
                    MessageBox.Show("login succes");
                    Registration_Panel.Visible = true; // on affiche le registration panel (pour pouvoir afficher le home au final)
                    Home_Panel.Visible = true; // on affiche le panel home
                    this.Text = "Home"; // on change le text du form sur home

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password !");
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                }
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Text = "Registration";
            Registration_Panel.Visible = true; // on affiche le panel pour s'enregistrer
        }
    }
}
