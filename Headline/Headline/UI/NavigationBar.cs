using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headline.UI
{
    public class NavigationBar
    {


        private static NavigationBar _instance;

        public static NavigationBar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NavigationBar();
                return _instance;

            }
        }



        public void Connexion()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = true;
            FormContainer.preferences.Visible = true;
            FormContainer.home.Visible = false;
        }

        public void Deconnexion()
        {
            FormContainer.login.Visible = true;
            FormContainer.register.Visible = true;
            FormContainer.deconnexion.Visible = false;
            FormContainer.search.Visible = false;
            FormContainer.preferences.Visible = false;
            FormContainer.home.Visible = false;
        }

        public void Search()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = false;
            FormContainer.preferences.Visible = true;
            FormContainer.home.Visible = true;
        }

        public void Preferences()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = true;
            FormContainer.preferences.Visible = false;
            FormContainer.home.Visible = true;
        }

        public void Article()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = true;
            FormContainer.preferences.Visible = true;
            FormContainer.home.Visible = true;
        }


    }
}
