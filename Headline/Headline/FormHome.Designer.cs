namespace Headline
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // Home_Panel
            // 
            this.Home_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Home_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home_Panel.Controls.Add(this.button_previous);
            this.Home_Panel.Controls.Add(this.button_next);
            this.Home_Panel.Controls.Add(this.pictureBox2);
            this.Home_Panel.Location = new System.Drawing.Point(0, -25);
            this.Home_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(1685, 838);
            this.Home_Panel.TabIndex = 35;
            // 
            // button_previous
            // 
            this.button_previous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_previous.Location = new System.Drawing.Point(619, 583);
            this.button_previous.Margin = new System.Windows.Forms.Padding(4);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(100, 28);
            this.button_previous.TabIndex = 27;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_next.Location = new System.Drawing.Point(776, 583);
            this.button_next.Margin = new System.Windows.Forms.Padding(4);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(100, 28);
            this.button_next.TabIndex = 26;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(635, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 76);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1685, 788);
            this.ControlBox = false;
            this.Controls.Add(this.Home_Panel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Home_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_previous;
    }
}