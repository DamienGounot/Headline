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
            FormContainer.back.Visible = false;

        }

        public void Deconnexion()
        {
            FormContainer.login.Visible = true;
            FormContainer.register.Visible = true;
            FormContainer.deconnexion.Visible = false;
            FormContainer.search.Visible = false;
            FormContainer.preferences.Visible = false;
            FormContainer.home.Visible = false;
            FormContainer.back.Visible = false;

        }

        public void Search()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = false;
            FormContainer.preferences.Visible = true;
            FormContainer.home.Visible = true;
            FormContainer.back.Visible = true;

        }

        public void Preferences()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = true;
            FormContainer.preferences.Visible = false;
            FormContainer.home.Visible = true;
            FormContainer.back.Visible = true;
        }

        public void Article()
        {
            FormContainer.login.Visible = false;
            FormContainer.register.Visible = false;
            FormContainer.deconnexion.Visible = true;
            FormContainer.search.Visible = true;
            FormContainer.preferences.Visible = true;
            FormContainer.home.Visible = true;
            FormContainer.back.Visible = true;
        }


    }
}
