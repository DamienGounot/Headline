namespace Headline
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.preferences_panel = new System.Windows.Forms.Panel();
            this.textBox_country_pref = new System.Windows.Forms.ComboBox();
            this.btn_save_pref = new System.Windows.Forms.Button();
            this.butn_home_pref = new System.Windows.Forms.Button();
            this.textBox_keyword_pref = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.preferences_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // preferences_panel
            // 
            this.preferences_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.preferences_panel.Controls.Add(this.textBox_country_pref);
            this.preferences_panel.Controls.Add(this.btn_save_pref);
            this.preferences_panel.Controls.Add(this.butn_home_pref);
            this.preferences_panel.Controls.Add(this.textBox_keyword_pref);
            this.preferences_panel.Controls.Add(this.label9);
            this.preferences_panel.Controls.Add(this.label4);
            this.preferences_panel.Controls.Add(this.pictureBox3);
            this.preferences_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferences_panel.Location = new System.Drawing.Point(0, 0);
            this.preferences_panel.Name = "preferences_panel";
            this.preferences_panel.Size = new System.Drawing.Size(800, 450);
            this.preferences_panel.TabIndex = 31;
            // 
            // textBox_country_pref
            // 
            this.textBox_country_pref.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_country_pref.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.textBox_country_pref.FormattingEnabled = true;
            this.textBox_country_pref.Items.AddRange(new object[] {
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
            this.textBox_country_pref.Location = new System.Drawing.Point(340, 176);
            this.textBox_country_pref.Name = "textBox_country_pref";
            this.textBox_country_pref.Size = new System.Drawing.Size(121, 21);
            this.textBox_country_pref.TabIndex = 27;
            // 
            // btn_save_pref
            // 
            this.btn_save_pref.Location = new System.Drawing.Point(367, 333);
            this.btn_save_pref.Name = "btn_save_pref";
            this.btn_save_pref.Size = new System.Drawing.Size(75, 23);
            this.btn_save_pref.TabIndex = 22;
            this.btn_save_pref.Text = "Save";
            this.btn_save_pref.UseVisualStyleBackColor = true;
            this.btn_save_pref.Click += new System.EventHandler(this.btn_save_pref_Click);
            // 
            // butn_home_pref
            // 
            this.butn_home_pref.Location = new System.Drawing.Point(282, 333);
            this.butn_home_pref.Name = "butn_home_pref";
            this.butn_home_pref.Size = new System.Drawing.Size(75, 23);
            this.butn_home_pref.TabIndex = 21;
            this.butn_home_pref.Text = "Go Home";
            this.butn_home_pref.UseVisualStyleBackColor = true;
            this.butn_home_pref.Click += new System.EventHandler(this.butn_home_pref_Click);
            // 
            // textBox_keyword_pref
            // 
            this.textBox_keyword_pref.Location = new System.Drawing.Point(342, 140);
            this.textBox_keyword_pref.Name = "textBox_keyword_pref";
            this.textBox_keyword_pref.Size = new System.Drawing.Size(119, 20);
            this.textBox_keyword_pref.TabIndex = 17;
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
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(285, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 62);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preferences_panel);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.preferences_panel.ResumeLayout(false);
            this.preferences_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel preferences_panel;
        private System.Windows.Forms.ComboBox textBox_country_pref;
        private System.Windows.Forms.Button btn_save_pref;
        private System.Windows.Forms.Button butn_home_pref;
        private System.Windows.Forms.TextBox textBox_keyword_pref;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}