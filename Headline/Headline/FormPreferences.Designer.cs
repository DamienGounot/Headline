namespace Headline
{
    partial class FormPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreferences));
            this.preferences_panel = new System.Windows.Forms.Panel();
            this.label_save = new System.Windows.Forms.Label();
            this.textBox_country_pref = new System.Windows.Forms.ComboBox();
            this.btn_save_pref = new System.Windows.Forms.Button();
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
            this.preferences_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preferences_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.preferences_panel.Controls.Add(this.label_save);
            this.preferences_panel.Controls.Add(this.textBox_country_pref);
            this.preferences_panel.Controls.Add(this.btn_save_pref);
            this.preferences_panel.Controls.Add(this.textBox_keyword_pref);
            this.preferences_panel.Controls.Add(this.label9);
            this.preferences_panel.Controls.Add(this.label4);
            this.preferences_panel.Controls.Add(this.pictureBox3);
            this.preferences_panel.Location = new System.Drawing.Point(0, 0);
            this.preferences_panel.Name = "preferences_panel";
            this.preferences_panel.Size = new System.Drawing.Size(1264, 681);
            this.preferences_panel.TabIndex = 32;
            // 
            // label_save
            // 
            this.label_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_save.AutoSize = true;
            this.label_save.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_save.Location = new System.Drawing.Point(528, 160);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(137, 13);
            this.label_save.TabIndex = 28;
            this.label_save.Text = "Save Preferences Succes !";
            this.label_save.Visible = false;
            // 
            // textBox_country_pref
            // 
            this.textBox_country_pref.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.textBox_country_pref.Location = new System.Drawing.Point(544, 269);
            this.textBox_country_pref.Name = "textBox_country_pref";
            this.textBox_country_pref.Size = new System.Drawing.Size(121, 21);
            this.textBox_country_pref.TabIndex = 27;
            this.textBox_country_pref.SelectedIndexChanged += new System.EventHandler(this.textBox_country_pref_SelectedIndexChanged);
            // 
            // btn_save_pref
            // 
            this.btn_save_pref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save_pref.Location = new System.Drawing.Point(544, 332);
            this.btn_save_pref.Name = "btn_save_pref";
            this.btn_save_pref.Size = new System.Drawing.Size(75, 23);
            this.btn_save_pref.TabIndex = 22;
            this.btn_save_pref.Text = "Save";
            this.btn_save_pref.UseVisualStyleBackColor = true;
            this.btn_save_pref.Click += new System.EventHandler(this.btn_save_pref_Click);
            // 
            // textBox_keyword_pref
            // 
            this.textBox_keyword_pref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_keyword_pref.Location = new System.Drawing.Point(546, 233);
            this.textBox_keyword_pref.Name = "textBox_keyword_pref";
            this.textBox_keyword_pref.Size = new System.Drawing.Size(119, 20);
            this.textBox_keyword_pref.TabIndex = 17;
            this.textBox_keyword_pref.TextChanged += new System.EventHandler(this.textBox_keyword_pref_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Country :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Keyword :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(467, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 62);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.preferences_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPreferences";
            this.ShowIcon = false;
            this.Text = "Preferences";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.preferences_panel.ResumeLayout(false);
            this.preferences_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel preferences_panel;
        private System.Windows.Forms.ComboBox textBox_country_pref;
        private System.Windows.Forms.Button btn_save_pref;
        private System.Windows.Forms.TextBox textBox_keyword_pref;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_save;
    }
}