using System;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
            Instance = this;
        }


        public static FormContainer Instance;

        public void Container_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        public static ToolStripMenuItem login;
        public static ToolStripMenuItem register;
        public static ToolStripMenuItem deconnexion;
        public static ToolStripMenuItem search;
        public static ToolStripMenuItem preferences;
        public static ToolStripMenuItem home;
        public static ToolStripMenuItem back;

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
            back = goBackToolStripMenuItem;
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToStart();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.NavigationBar.Instance.Search();
            FormSearch search = new FormSearch();
            search.MdiParent = this;
            search.Show();
            search.WindowState = FormWindowState.Maximized;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.NavigationBar.Instance.Preferences();
            FormPreferences preferences = new FormPreferences();
            preferences.MdiParent = this;
            preferences.Show();
            preferences.WindowState = FormWindowState.Maximized;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToHome();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToHome();
        }

        private void GoToHome()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Visible == true && form.GetType() != typeof(FormHome))
                {
                    form.Hide();
                    break;
                }
            }
            UI.NavigationBar.Instance.Connexion();
        }

        private void GoToStart()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.Visible == true && form.GetType() != typeof(FormContainer))
                {
                    form.Hide();
                    break;
                }
            }
            UI.NavigationBar.Instance.Deconnexion();
        }
    }
}
