using System;
using System.Windows.Forms;

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

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                Check(label_error, "Error : username and password are required");
            }
            else
            {
                if (DataBase.DB.Instance.CheckLogin(textBox_username.Text, textBox_password.Text)) // si le login est OK
                {
                    username = textBox_username.Text;
                    favoriteCountry = DataBase.DB.Instance.GetFavoriteCountry(username);
                    favoriteKeyword = DataBase.DB.Instance.GetFavoriteKeyword(username);
                    LoginResearch(favoriteCountry, favoriteKeyword);
                    UI.NavigationBar.Instance.Connexion();
                }
                else
                {
                    Check(label_error, "Error : Incorrect Username or Password");
                    reset();
                }
            }
        }

        private void LoginResearch(string favoriteCountry,string favoriteKeyword)
        {
            if ((favoriteCountry == " " || favoriteKeyword == " " ) || (favoriteCountry == "" && favoriteKeyword == ""))
            {
                FormHome mainform = new FormHome("", "us", "");
                InitializeForm(mainform);
            }
            else
            {
                FormHome mainform = new FormHome(favoriteKeyword, favoriteCountry, "");
                InitializeForm(mainform);
            }
        }

        private void reset()
        {
            textBox_username.Text = "";
            textBox_password.Text = "";
        }

        private void Check(System.Windows.Forms.Label label,string message)
        {
            label.Text = message;
            label.ForeColor = System.Drawing.Color.Red;
            label.Visible = true;
        }

        private void InitializeForm(System.Windows.Forms.Form mainform)
        {
            mainform.MdiParent = FormContainer.Instance;
            mainform.Show();
            mainform.WindowState = FormWindowState.Maximized;
            this.Hide();
        }
    }
}
