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
            this.titleUc = new System.Windows.Forms.TextBox();
            this.linkUC = new System.Windows.Forms.LinkLabel();
            this.pictureUC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUC)).BeginInit();
            this.SuspendLayout();
            // 
            // titleUc
            // 
            this.titleUc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleUc.Enabled = false;
            this.titleUc.Location = new System.Drawing.Point(3, 11);
            this.titleUc.Multiline = true;
            this.titleUc.Name = "titleUc";
            this.titleUc.Size = new System.Drawing.Size(217, 45);
            this.titleUc.TabIndex = 26;
            // 
            // linkUC
            // 
            this.linkUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkUC.AutoSize = true;
            this.linkUC.Location = new System.Drawing.Point(67, 200);
            this.linkUC.Name = "linkUC";
            this.linkUC.Size = new System.Drawing.Size(68, 13);
            this.linkUC.TabIndex = 25;
            this.linkUC.TabStop = true;
            this.linkUC.Text = "Read more...";
            this.linkUC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureUC
            // 
            this.pictureUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUC.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureUC.ErrorImage")));
            this.pictureUC.Image = ((System.Drawing.Image)(resources.GetObject("pictureUC.Image")));
            this.pictureUC.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureUC.InitialImage")));
            this.pictureUC.Location = new System.Drawing.Point(3, 61);
            this.pictureUC.Name = "pictureUC";
            this.pictureUC.Size = new System.Drawing.Size(216, 125);
            this.pictureUC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUC.TabIndex = 24;
            this.pictureUC.TabStop = false;
            // 
            // UcArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleUc);
            this.Controls.Add(this.linkUC);
            this.Controls.Add(this.pictureUC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcArticle";
            this.Size = new System.Drawing.Size(222, 228);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleUc;
        private System.Windows.Forms.LinkLabel linkUC;
        private System.Windows.Forms.PictureBox pictureUC;
    }
}
