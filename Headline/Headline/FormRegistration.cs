using System;
using System.Windows.Forms;

namespace Headline
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private static FormRegistration _instance;

        public static FormRegistration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormRegistration();
                return _instance;

            }
        }


        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }



        private void ShowForm(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool error,errorName,errorMail,errorPass=true;

            if (isNotCompleted())
            {
                Error(username,label_correct, "Every Fields are required", true);
                error = true;
            }
            else
            {
                label_correct.Visible = false;
                error =  false;
            }

            if (password.Text != confirm.Text && password.Text != "")
            {
                Error(password, label_error_pass, "Error : Not matching", true);
                Error(confirm, label_error_pass2, "Error : Not matching", true);
                errorPass = true;

            }
            if (password.Text == confirm.Text && password.Text != "")
            {
                Error(password, label_error_pass, "Error : Not matching", false);
                Error(confirm, label_error_pass2, "Error : Not matching", false);
                errorPass = false;
            }

            if (!error && !errorPass)
            {

                if (DataBase.DB.Instance.CheckUserNotRegistered(username.Text)) // si user exist
                {
                    Error(username,label_error_user, "Error : This username is already taken !", true);
                    errorName = true;
                }
                else
                {
                    Error(username, label_error_user, "Error : This username is already taken !", false);
                    errorName = false;
                }



                if (DataBase.DB.Instance.CheckEmailNotRegistered(email.Text)) // si mail exist
                {
                    Error(email,label_error_mail, "Error : This email is already used !", true);
                    errorMail = true;
                }
                else
                {
                    Error(email, label_error_mail, "Error : This email is already used !", false);
                    errorMail = false;
                }

                if (!errorName && !errorMail)
                {

                    DataBase.DB.Instance.InsertNewUser(username.Text, email.Text, password.Text);
                    reset();
                    Succes();
                }
            }
        }

        private void reset()
        {
            username.Text = "";
            email.Text = "";
            password.Text = "";
            confirm.Text = "";
            label_correct.Visible = false;
            label_error_mail.Visible = false;
            label_error_pass.Visible = false;
            label_error_pass2.Visible = false;
            label_error_user.Visible = false;
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





        private void Error(System.Windows.Forms.TextBox textBox,System.Windows.Forms.Label label,string text,bool error)
        {
            if (error) {
                label.Text = text;
                label.ForeColor = System.Drawing.Color.Red;
                label.Visible = true;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Black;
                label.Visible = false;
            }

        }

        private void Succes()
        {
            label_correct.ForeColor = System.Drawing.Color.DarkGreen;
            label_correct.Text = "Correct : Your account has been succesfully created !";
            label_correct.Visible = true;

        }



    }
}
