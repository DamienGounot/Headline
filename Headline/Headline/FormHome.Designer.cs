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
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.Home_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Home_Panel
            // 
            this.Home_Panel.AutoSize = true;
            this.Home_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home_Panel.Controls.Add(this.button_previous);
            this.Home_Panel.Controls.Add(this.button_next);
            this.Home_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_Panel.Location = new System.Drawing.Point(0, 0);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(963, 635);
            this.Home_Panel.TabIndex = 35;
            // 
            // button_previous
            // 
            this.button_previous.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_previous.Location = new System.Drawing.Point(0, 23);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(963, 23);
            this.button_previous.TabIndex = 27;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_next.Location = new System.Drawing.Point(0, 0);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(963, 23);
            this.button_next.TabIndex = 26;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // FormHome
            // 
            this.AccessibleName = "HomeMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(963, 635);
            this.ControlBox = false;
            this.Controls.Add(this.Home_Panel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Home_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_previous;
    }
}