namespace Headline
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.Registration_Panel = new System.Windows.Forms.Panel();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.preferences_panel = new System.Windows.Forms.Panel();
            this.search_panel = new System.Windows.Forms.Panel();
            this.button_make_search = new System.Windows.Forms.Button();
            this.button_home_from_search = new System.Windows.Forms.Button();
            this.textBox_country_search = new System.Windows.Forms.TextBox();
            this.textBox_source_search = new System.Windows.Forms.TextBox();
            this.textBox_date_search = new System.Windows.Forms.TextBox();
            this.textBox_keyword_search = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_from_search_to_pref = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_save_pref = new System.Windows.Forms.Button();
            this.butn_home_pref = new System.Windows.Forms.Button();
            this.textBox_source_pref = new System.Windows.Forms.TextBox();
            this.textBox_date_pref = new System.Windows.Forms.TextBox();
            this.textBox_country_pref = new System.Windows.Forms.TextBox();
            this.textBox_keyword_pref = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBoxArticle3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArticle2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArticle1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pref = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_home_from_reg = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Login_Panel.SuspendLayout();
            this.Registration_Panel.SuspendLayout();
            this.Home_Panel.SuspendLayout();
            this.preferences_panel.SuspendLayout();
            this.search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_Panel.Controls.Add(this.Registration_Panel);
            this.Login_Panel.Controls.Add(this.textBox_username);
            this.Login_Panel.Controls.Add(this.textBox_password);
            this.Login_Panel.Controls.Add(this.button_register);
            this.Login_Panel.Controls.Add(this.button_login);
            this.Login_Panel.Controls.Add(this.picture);
            this.Login_Panel.Controls.Add(this.label_Password);
            this.Login_Panel.Controls.Add(this.Label_UserName);
            this.Login_Panel.Location = new System.Drawing.Point(1, 1);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(800, 450);
            this.Login_Panel.TabIndex = 7;
            // 
            // Registration_Panel
            // 
            this.Registration_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registration_Panel.Controls.Add(this.button_home_from_reg);
            this.Registration_Panel.Controls.Add(this.confirm);
            this.Registration_Panel.Controls.Add(this.password);
            this.Registration_Panel.Controls.Add(this.email);
            this.Registration_Panel.Controls.Add(this.username);
            this.Registration_Panel.Controls.Add(this.buttonRegister);
            this.Registration_Panel.Controls.Add(this.label5);
            this.Registration_Panel.Controls.Add(this.label6);
            this.Registration_Panel.Controls.Add(this.label7);
            this.Registration_Panel.Controls.Add(this.label8);
            this.Registration_Panel.Controls.Add(this.pictureBox1);
            this.Registration_Panel.Location = new System.Drawing.Point(0, 0);
            this.Registration_Panel.Name = "Registration_Panel";
            this.Registration_Panel.Size = new System.Drawing.Size(800, 450);
            this.Registration_Panel.TabIndex = 14;
            this.Registration_Panel.Visible = false;
            // 
            // Home_Panel
            // 
            this.Home_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home_Panel.Controls.Add(this.preferences_panel);
            this.Home_Panel.Controls.Add(this.linkLabel3);
            this.Home_Panel.Controls.Add(this.linkLabel2);
            this.Home_Panel.Controls.Add(this.linkLabel1);
            this.Home_Panel.Controls.Add(this.pictureBoxArticle3);
            this.Home_Panel.Controls.Add(this.pictureBoxArticle2);
            this.Home_Panel.Controls.Add(this.pictureBoxArticle1);
            this.Home_Panel.Controls.Add(this.label3);
            this.Home_Panel.Controls.Add(this.label2);
            this.Home_Panel.Controls.Add(this.label1);
            this.Home_Panel.Controls.Add(this.btn_Pref);
            this.Home_Panel.Controls.Add(this.btn_Search);
            this.Home_Panel.Controls.Add(this.pictureBox2);
            this.Home_Panel.Location = new System.Drawing.Point(1, 1);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(800, 450);
            this.Home_Panel.TabIndex = 33;
            this.Home_Panel.Visible = false;
            // 
            // preferences_panel
            // 
            this.preferences_panel.Controls.Add(this.search_panel);
            this.preferences_panel.Controls.Add(this.btn_save_pref);
            this.preferences_panel.Controls.Add(this.butn_home_pref);
            this.preferences_panel.Controls.Add(this.textBox_source_pref);
            this.preferences_panel.Controls.Add(this.textBox_date_pref);
            this.preferences_panel.Controls.Add(this.textBox_country_pref);
            this.preferences_panel.Controls.Add(this.textBox_keyword_pref);
            this.preferences_panel.Controls.Add(this.label11);
            this.preferences_panel.Controls.Add(this.label10);
            this.preferences_panel.Controls.Add(this.label9);
            this.preferences_panel.Controls.Add(this.label4);
            this.preferences_panel.Controls.Add(this.pictureBox3);
            this.preferences_panel.Location = new System.Drawing.Point(0, 0);
            this.preferences_panel.Name = "preferences_panel";
            this.preferences_panel.Size = new System.Drawing.Size(797, 450);
            this.preferences_panel.TabIndex = 23;
            this.preferences_panel.Visible = false;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.button_make_search);
            this.search_panel.Controls.Add(this.button_home_from_search);
            this.search_panel.Controls.Add(this.textBox_country_search);
            this.search_panel.Controls.Add(this.textBox_source_search);
            this.search_panel.Controls.Add(this.textBox_date_search);
            this.search_panel.Controls.Add(this.textBox_keyword_search);
            this.search_panel.Controls.Add(this.label15);
            this.search_panel.Controls.Add(this.label14);
            this.search_panel.Controls.Add(this.label13);
            this.search_panel.Controls.Add(this.label12);
            this.search_panel.Controls.Add(this.button_from_search_to_pref);
            this.search_panel.Controls.Add(this.pictureBox4);
            this.search_panel.Location = new System.Drawing.Point(0, 0);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(797, 450);
            this.search_panel.TabIndex = 23;
            this.search_panel.Visible = false;
            // 
            // button_make_search
            // 
            this.button_make_search.Location = new System.Drawing.Point(348, 342);
            this.button_make_search.Name = "button_make_search";
            this.button_make_search.Size = new System.Drawing.Size(75, 23);
            this.button_make_search.TabIndex = 24;
            this.button_make_search.Text = "Search";
            this.button_make_search.UseVisualStyleBackColor = true;
            this.button_make_search.Click += new System.EventHandler(this.button_make_search_Click_1);
            // 
            // button_home_from_search
            // 
            this.button_home_from_search.Location = new System.Drawing.Point(243, 342);
            this.button_home_from_search.Name = "button_home_from_search";
            this.button_home_from_search.Size = new System.Drawing.Size(75, 23);
            this.button_home_from_search.TabIndex = 23;
            this.button_home_from_search.Text = "Go Home";
            this.button_home_from_search.UseVisualStyleBackColor = true;
            this.button_home_from_search.Click += new System.EventHandler(this.button_home_from_search_Click_1);
            // 
            // textBox_country_search
            // 
            this.textBox_country_search.Location = new System.Drawing.Point(321, 267);
            this.textBox_country_search.Name = "textBox_country_search";
            this.textBox_country_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_country_search.TabIndex = 22;
            // 
            // textBox_source_search
            // 
            this.textBox_source_search.Location = new System.Drawing.Point(321, 225);
            this.textBox_source_search.Name = "textBox_source_search";
            this.textBox_source_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_source_search.TabIndex = 21;
            // 
            // textBox_date_search
            // 
            this.textBox_date_search.Location = new System.Drawing.Point(321, 176);
            this.textBox_date_search.Name = "textBox_date_search";
            this.textBox_date_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_date_search.TabIndex = 20;
            // 
            // textBox_keyword_search
            // 
            this.textBox_keyword_search.Location = new System.Drawing.Point(323, 126);
            this.textBox_keyword_search.Name = "textBox_keyword_search";
            this.textBox_keyword_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_keyword_search.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Country :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Sources :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Keyword :";
            // 
            // button_from_search_to_pref
            // 
            this.button_from_search_to_pref.Location = new System.Drawing.Point(540, 56);
            this.button_from_search_to_pref.Name = "button_from_search_to_pref";
            this.button_from_search_to_pref.Size = new System.Drawing.Size(75, 23);
            this.button_from_search_to_pref.TabIndex = 14;
            this.button_from_search_to_pref.Text = "Preferences";
            this.button_from_search_to_pref.UseVisualStyleBackColor = true;
            this.button_from_search_to_pref.Click += new System.EventHandler(this.button_from_search_to_pref_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(285, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(237, 62);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btn_save_pref
            // 
            this.btn_save_pref.Location = new System.Drawing.Point(367, 333);
            this.btn_save_pref.Name = "btn_save_pref";
            this.btn_save_pref.Size = new System.Drawing.Size(75, 23);
            this.btn_save_pref.TabIndex = 22;
            this.btn_save_pref.Text = "Save";
            this.btn_save_pref.UseVisualStyleBackColor = true;
            this.btn_save_pref.Click += new System.EventHandler(this.btn_save_pref_Click_1);
            // 
            // butn_home_pref
            // 
            this.butn_home_pref.Location = new System.Drawing.Point(282, 333);
            this.butn_home_pref.Name = "butn_home_pref";
            this.butn_home_pref.Size = new System.Drawing.Size(75, 23);
            this.butn_home_pref.TabIndex = 21;
            this.butn_home_pref.Text = "Go Home";
            this.butn_home_pref.UseVisualStyleBackColor = true;
            this.butn_home_pref.Click += new System.EventHandler(this.butn_home_pref_Click_1);
            // 
            // textBox_source_pref
            // 
            this.textBox_source_pref.Location = new System.Drawing.Point(342, 254);
            this.textBox_source_pref.Name = "textBox_source_pref";
            this.textBox_source_pref.Size = new System.Drawing.Size(100, 20);
            this.textBox_source_pref.TabIndex = 20;
            // 
            // textBox_date_pref
            // 
            this.textBox_date_pref.Location = new System.Drawing.Point(342, 211);
            this.textBox_date_pref.Name = "textBox_date_pref";
            this.textBox_date_pref.Size = new System.Drawing.Size(100, 20);
            this.textBox_date_pref.TabIndex = 19;
            // 
            // textBox_country_pref
            // 
            this.textBox_country_pref.Location = new System.Drawing.Point(342, 178);
            this.textBox_country_pref.Name = "textBox_country_pref";
            this.textBox_country_pref.Size = new System.Drawing.Size(100, 20);
            this.textBox_country_pref.TabIndex = 18;
            // 
            // textBox_keyword_pref
            // 
            this.textBox_keyword_pref.Location = new System.Drawing.Point(342, 140);
            this.textBox_keyword_pref.Name = "textBox_keyword_pref";
            this.textBox_keyword_pref.Size = new System.Drawing.Size(100, 20);
            this.textBox_keyword_pref.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Source :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Country :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Keyword :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 62);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(571, 261);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(55, 13);
            this.linkLabel3.TabIndex = 22;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(396, 261);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(184, 261);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // pictureBoxArticle3
            // 
            this.pictureBoxArticle3.Location = new System.Drawing.Point(541, 181);
            this.pictureBoxArticle3.Name = "pictureBoxArticle3";
            this.pictureBoxArticle3.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxArticle3.TabIndex = 19;
            this.pictureBoxArticle3.TabStop = false;
            // 
            // pictureBoxArticle2
            // 
            this.pictureBoxArticle2.Location = new System.Drawing.Point(381, 181);
            this.pictureBoxArticle2.Name = "pictureBoxArticle2";
            this.pictureBoxArticle2.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxArticle2.TabIndex = 18;
            this.pictureBoxArticle2.TabStop = false;
            // 
            // pictureBoxArticle1
            // 
            this.pictureBoxArticle1.Location = new System.Drawing.Point(169, 181);
            this.pictureBoxArticle1.Name = "pictureBoxArticle1";
            this.pictureBoxArticle1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxArticle1.TabIndex = 17;
            this.pictureBoxArticle1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // btn_Pref
            // 
            this.btn_Pref.Location = new System.Drawing.Point(541, 56);
            this.btn_Pref.Name = "btn_Pref";
            this.btn_Pref.Size = new System.Drawing.Size(75, 23);
            this.btn_Pref.TabIndex = 13;
            this.btn_Pref.Text = "Preferences";
            this.btn_Pref.UseVisualStyleBackColor = true;
            this.btn_Pref.Click += new System.EventHandler(this.btn_Pref_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(541, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 62);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // button_home_from_reg
            // 
            this.button_home_from_reg.Location = new System.Drawing.Point(332, 380);
            this.button_home_from_reg.Name = "button_home_from_reg";
            this.button_home_from_reg.Size = new System.Drawing.Size(75, 23);
            this.button_home_from_reg.TabIndex = 32;
            this.button_home_from_reg.Text = "Back";
            this.button_home_from_reg.UseVisualStyleBackColor = true;
            this.button_home_from_reg.Click += new System.EventHandler(this.button_home_from_reg_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(396, 307);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 20);
            this.confirm.TabIndex = 31;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(396, 264);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 30;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(396, 215);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 29;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(396, 176);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 28;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(434, 380);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 27;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "e-mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Username :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(381, 222);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 13;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(381, 261);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 12;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(407, 325);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 40);
            this.button_register.TabIndex = 11;
            this.button_register.Text = "Not a member ? Register now !";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(282, 334);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 10;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click_1);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(282, 85);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(237, 62);
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(294, 264);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(59, 13);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password :";
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(294, 222);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(63, 13);
            this.Label_UserName.TabIndex = 7;
            this.Label_UserName.Text = "UserName :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Home_Panel);
            this.Controls.Add(this.Login_Panel);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.Registration_Panel.ResumeLayout(false);
            this.Registration_Panel.PerformLayout();
            this.Home_Panel.ResumeLayout(false);
            this.Home_Panel.PerformLayout();
            this.preferences_panel.ResumeLayout(false);
            this.preferences_panel.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Panel Registration_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_home_from_reg;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.Panel preferences_panel;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Button button_make_search;
        private System.Windows.Forms.Button button_home_from_search;
        private System.Windows.Forms.TextBox textBox_country_search;
        private System.Windows.Forms.TextBox textBox_source_search;
        private System.Windows.Forms.TextBox textBox_date_search;
        private System.Windows.Forms.TextBox textBox_keyword_search;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_from_search_to_pref;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_save_pref;
        private System.Windows.Forms.Button butn_home_pref;
        private System.Windows.Forms.TextBox textBox_source_pref;
        private System.Windows.Forms.TextBox textBox_date_pref;
        private System.Windows.Forms.TextBox textBox_country_pref;
        private System.Windows.Forms.TextBox textBox_keyword_pref;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxArticle3;
        private System.Windows.Forms.PictureBox pictureBoxArticle2;
        private System.Windows.Forms.PictureBox pictureBoxArticle1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pref;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

