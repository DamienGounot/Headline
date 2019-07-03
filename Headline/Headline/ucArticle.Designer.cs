namespace Headline
{
    partial class UcArticle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcArticle));
            this.titlehome1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBoxArticle1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlehome1
            // 
            this.titlehome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titlehome1.Location = new System.Drawing.Point(4, 13);
            this.titlehome1.Margin = new System.Windows.Forms.Padding(4);
            this.titlehome1.Multiline = true;
            this.titlehome1.Name = "titlehome1";
            this.titlehome1.Size = new System.Drawing.Size(288, 54);
            this.titlehome1.TabIndex = 26;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(202, 244);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 17);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Read more...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBoxArticle1
            // 
            this.pictureBoxArticle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxArticle1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArticle1.ErrorImage")));
            this.pictureBoxArticle1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArticle1.InitialImage")));
            this.pictureBoxArticle1.Location = new System.Drawing.Point(4, 75);
            this.pictureBoxArticle1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxArticle1.Name = "pictureBoxArticle1";
            this.pictureBoxArticle1.Size = new System.Drawing.Size(288, 154);
            this.pictureBoxArticle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticle1.TabIndex = 24;
            this.pictureBoxArticle1.TabStop = false;
            // 
            // ucArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titlehome1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBoxArticle1);
            this.Name = "ucArticle";
            this.Size = new System.Drawing.Size(296, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlehome1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxArticle1;
    }
}
