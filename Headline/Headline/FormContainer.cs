using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }


        public static FormContainer _instance;

        public static FormContainer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormContainer();
                return _instance;

            }
        }

        public void Container_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }

        public static ToolStripMenuItem login;
        public static ToolStripMenuItem register;
        public static ToolStripMenuItem deconnexion;
        public static ToolStripMenuItem search;
        public static ToolStripMenuItem preferences;
        public static ToolStripMenuItem home;




        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Visible = false;
            }
            FormLogin Login = new FormLogin();
            Login.MdiParent = this;
            Login.Show();
            InitNavbar();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Visible = false;
            }

            FormRegistration registration = new FormRegistration();
            registration.MdiParent = this;
            registration.Show();
            InitNavbar();
            

        }

        private void InitNavbar()
        {
            login = loginToolStripMenuItem;
            register = createAccountToolStripMenuItem;
            deconnexion = deconnexionToolStripMenuItem;
            search = searchToolStripMenuItem;
            preferences = preferencesToolStripMenuItem;
            home = homeToolStripMenuItem;
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            UI.NavigationBar.Instance.Deconnexion();
            FormLogin login = new FormLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            UI.NavigationBar.Instance.Search();
            FormSearch search = new FormSearch();
            search.MdiParent = this;
            search.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            UI.NavigationBar.Instance.Preferences();
            FormPreferences preferences = new FormPreferences();
            preferences.MdiParent = this;
            preferences.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Visible = false;
            UI.NavigationBar.Instance.Connexion();
            FormHome home = new FormHome(5, "keyword", "country", "sources");
            home.MdiParent = this;
            home.Show();
        }
    }
}
