namespace Headline
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.search_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_error = new System.Windows.Forms.Label();
            this.textBox_country_search = new System.Windows.Forms.ComboBox();
            this.textBox_source_search = new System.Windows.Forms.ComboBox();
            this.button_make_search = new System.Windows.Forms.Button();
            this.textBox_keyword_search = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.search_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // search_panel
            // 
            this.search_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_panel.Controls.Add(this.panel1);
            this.search_panel.Location = new System.Drawing.Point(0, 0);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(1264, 681);
            this.search_panel.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label_error);
            this.panel1.Controls.Add(this.textBox_country_search);
            this.panel1.Controls.Add(this.textBox_source_search);
            this.panel1.Controls.Add(this.button_make_search);
            this.panel1.Controls.Add(this.textBox_keyword_search);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 30;
            // 
            // label_error
            // 
            this.label_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(575, 130);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(119, 13);
            this.label_error.TabIndex = 34;
            this.label_error.Text = "Error : No parameter set";
            this.label_error.Visible = false;
            // 
            // textBox_country_search
            // 
            this.textBox_country_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_country_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_country_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textBox_country_search.FormattingEnabled = true;
            this.textBox_country_search.Items.AddRange(new object[] {
            "ar",
            "au",
            "at",
            "be",
            "br",
            "bg",
            "ca",
            "cn",
            "co",
            "cu",
            "cz",
            "eg",
            "fr",
            "de",
            "gr",
            "hk",
            "hu",
            "in",
            "id",
            "ie",
            "il",
            "it",
            "jp",
            "lv",
            "lt",
            "my",
            "mx",
            "ma",
            "nl",
            "nz",
            "ng",
            "no",
            "ph",
            "pl",
            "pt",
            "ro",
            "ru",
            "sa",
            "rs",
            "sg",
            "sk",
            "si",
            "za",
            "kr",
            "se",
            "ch",
            "tw",
            "th",
            "tr",
            "ae",
            "ua",
            "gb",
            "us",
            "ve"});
            this.textBox_country_search.Location = new System.Drawing.Point(588, 242);
            this.textBox_country_search.Name = "textBox_country_search";
            this.textBox_country_search.Size = new System.Drawing.Size(121, 21);
            this.textBox_country_search.TabIndex = 33;
            // 
            // textBox_source_search
            // 
            this.textBox_source_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_source_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_source_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textBox_source_search.FormattingEnabled = true;
            this.textBox_source_search.Items.AddRange(new object[] {
            "abc-news",
            "abc-news-au",
            "aftenposten",
            "al-jazeera-english",
            "ansa",
            "associated-press",
            "australian-financial-review",
            "bbc-news",
            "bbc-sport",
            "blasting-news-br",
            "bleacher-report",
            "business-insider",
            "business-insider-uk",
            "buzzfeed",
            "cbc-news",
            "cbs-news",
            "cnn",
            "daily-mail",
            "der-tagesspiegel",
            "die-zeit",
            "financial-post",
            "fox-news",
            "fox-sports",
            "google-news",
            "ign",
            "independent",
            "le-monde",
            "lequipe",
            "les-echos",
            "liberation",
            "national-geographic",
            "national-review",
            "nbc-news",
            "news24",
            "new-york-magazine",
            "reddit-r-all",
            "spiegel-online",
            "the-american-conservative",
            "the-economist",
            "the-huffington-post",
            "the-new-york-times",
            "the-wall-street-journal",
            "the-washington-post",
            "vice-news"});
            this.textBox_source_search.Location = new System.Drawing.Point(588, 203);
            this.textBox_source_search.Name = "textBox_source_search";
            this.textBox_source_search.Size = new System.Drawing.Size(121, 21);
            this.textBox_source_search.TabIndex = 30;
            // 
            // button_make_search
            // 
            this.button_make_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_make_search.Location = new System.Drawing.Point(588, 288);
            this.button_make_search.Name = "button_make_search";
            this.button_make_search.Size = new System.Drawing.Size(75, 23);
            this.button_make_search.TabIndex = 24;
            this.button_make_search.Text = "Search";
            this.button_make_search.UseVisualStyleBackColor = true;
            this.button_make_search.Click += new System.EventHandler(this.button_make_search_Click);
            // 
            // textBox_keyword_search
            // 
            this.textBox_keyword_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_keyword_search.Location = new System.Drawing.Point(590, 172);
            this.textBox_keyword_search.Name = "textBox_keyword_search";
            this.textBox_keyword_search.Size = new System.Drawing.Size(119, 20);
            this.textBox_keyword_search.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(497, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Country :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(495, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Sources :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Keyword :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(510, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(237, 62);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.search_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.search_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox textBox_country_search;
        private System.Windows.Forms.ComboBox textBox_source_search;
        private System.Windows.Forms.Button button_make_search;
        private System.Windows.Forms.TextBox textBox_keyword_search;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_error;
    }
}