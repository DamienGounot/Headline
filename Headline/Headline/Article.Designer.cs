namespace Headline
{
    partial class Article
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Article));
            this.panel_article = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.btn_article_toPref = new System.Windows.Forms.Button();
            this.btn_article_toSearch = new System.Windows.Forms.Button();
            this.btn_article_toHome = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.article_content = new System.Windows.Forms.RichTextBox();
            this.article_date = new System.Windows.Forms.Label();
            this.article_source = new System.Windows.Forms.Label();
            this.article_author = new System.Windows.Forms.Label();
            this.article_description = new System.Windows.Forms.Label();
            this.article_title = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel_article.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_article
            // 
            this.panel_article.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_article.Controls.Add(this.linkLabel4);
            this.panel_article.Controls.Add(this.btn_article_toPref);
            this.panel_article.Controls.Add(this.btn_article_toSearch);
            this.panel_article.Controls.Add(this.btn_article_toHome);
            this.panel_article.Controls.Add(this.pictureBox6);
            this.panel_article.Controls.Add(this.article_content);
            this.panel_article.Controls.Add(this.article_date);
            this.panel_article.Controls.Add(this.article_source);
            this.panel_article.Controls.Add(this.article_author);
            this.panel_article.Controls.Add(this.article_description);
            this.panel_article.Controls.Add(this.article_title);
            this.panel_article.Controls.Add(this.pictureBox5);
            this.panel_article.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_article.Location = new System.Drawing.Point(0, 0);
            this.panel_article.Name = "panel_article";
            this.panel_article.Size = new System.Drawing.Size(800, 450);
            this.panel_article.TabIndex = 35;
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel4.Location = new System.Drawing.Point(11, 106);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(786, 23);
            this.linkLabel4.TabIndex = 26;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "ah";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // btn_article_toPref
            // 
            this.btn_article_toPref.Location = new System.Drawing.Point(528, 46);
            this.btn_article_toPref.Name = "btn_article_toPref";
            this.btn_article_toPref.Size = new System.Drawing.Size(75, 23);
            this.btn_article_toPref.TabIndex = 25;
            this.btn_article_toPref.Text = "Preferences";
            this.btn_article_toPref.UseVisualStyleBackColor = true;
            this.btn_article_toPref.Click += new System.EventHandler(this.btn_article_toPref_Click);
            // 
            // btn_article_toSearch
            // 
            this.btn_article_toSearch.Location = new System.Drawing.Point(528, 17);
            this.btn_article_toSearch.Name = "btn_article_toSearch";
            this.btn_article_toSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_article_toSearch.TabIndex = 24;
            this.btn_article_toSearch.Text = "Search";
            this.btn_article_toSearch.UseVisualStyleBackColor = true;
            this.btn_article_toSearch.Click += new System.EventHandler(this.btn_article_toSearch_Click);
            // 
            // btn_article_toHome
            // 
            this.btn_article_toHome.Location = new System.Drawing.Point(187, 32);
            this.btn_article_toHome.Name = "btn_article_toHome";
            this.btn_article_toHome.Size = new System.Drawing.Size(75, 23);
            this.btn_article_toHome.TabIndex = 23;
            this.btn_article_toHome.Text = "Home";
            this.btn_article_toHome.UseVisualStyleBackColor = true;
            this.btn_article_toHome.Click += new System.EventHandler(this.btn_article_toHome_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Location = new System.Drawing.Point(285, 142);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(275, 103);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // article_content
            // 
            this.article_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_content.Location = new System.Drawing.Point(49, 310);
            this.article_content.Name = "article_content";
            this.article_content.Size = new System.Drawing.Size(713, 127);
            this.article_content.TabIndex = 21;
            this.article_content.Text = "";
            // 
            // article_date
            // 
            this.article_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_date.AutoSize = true;
            this.article_date.Location = new System.Drawing.Point(505, 271);
            this.article_date.Name = "article_date";
            this.article_date.Size = new System.Drawing.Size(30, 13);
            this.article_date.TabIndex = 20;
            this.article_date.Text = "Date";
            // 
            // article_source
            // 
            this.article_source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_source.AutoSize = true;
            this.article_source.Location = new System.Drawing.Point(396, 271);
            this.article_source.Name = "article_source";
            this.article_source.Size = new System.Drawing.Size(41, 13);
            this.article_source.TabIndex = 19;
            this.article_source.Text = "Source";
            // 
            // article_author
            // 
            this.article_author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_author.AutoSize = true;
            this.article_author.Location = new System.Drawing.Point(282, 271);
            this.article_author.Name = "article_author";
            this.article_author.Size = new System.Drawing.Size(38, 13);
            this.article_author.TabIndex = 18;
            this.article_author.Text = "Author";
            // 
            // article_description
            // 
            this.article_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_description.Location = new System.Drawing.Point(11, 248);
            this.article_description.Name = "article_description";
            this.article_description.Size = new System.Drawing.Size(779, 23);
            this.article_description.TabIndex = 17;
            this.article_description.Text = "Description";
            this.article_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // article_title
            // 
            this.article_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.article_title.Location = new System.Drawing.Point(11, 90);
            this.article_title.Name = "article_title";
            this.article_title.Size = new System.Drawing.Size(779, 16);
            this.article_title.TabIndex = 16;
            this.article_title.Text = "Title";
            this.article_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(285, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(237, 62);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_article);
            this.Name = "Article";
            this.Text = "Article";
            this.panel_article.ResumeLayout(false);
            this.panel_article.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_article;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button btn_article_toPref;
        private System.Windows.Forms.Button btn_article_toSearch;
        private System.Windows.Forms.Button btn_article_toHome;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RichTextBox article_content;
        private System.Windows.Forms.Label article_date;
        private System.Windows.Forms.Label article_source;
        private System.Windows.Forms.Label article_author;
        private System.Windows.Forms.Label article_description;
        private System.Windows.Forms.Label article_title;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}