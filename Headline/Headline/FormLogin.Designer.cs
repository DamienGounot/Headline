namespace Headline
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label_error = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_Panel.Controls.Add(this.picture);
            this.Login_Panel.Controls.Add(this.label_error);
            this.Login_Panel.Controls.Add(this.textBox_username);
            this.Login_Panel.Controls.Add(this.textBox_password);
            this.Login_Panel.Controls.Add(this.button_login);
            this.Login_Panel.Controls.Add(this.label_Password);
            this.Login_Panel.Controls.Add(this.Label_UserName);
            this.Login_Panel.Location = new System.Drawing.Point(0, 0);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(1283, 812);
            this.Login_Panel.TabIndex = 9;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(392, 93);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(237, 62);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(459, 183);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(35, 13);
            this.label_error.TabIndex = 16;
            this.label_error.Text = "Error :";
            this.label_error.Visible = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(485, 235);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 13;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(485, 274);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 14;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(462, 336);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 15;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(398, 277);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(59, 13);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password :";
            // 
            // Label_UserName
            // 
            this.Label_UserName.AutoSize = true;
            this.Label_UserName.Location = new System.Drawing.Point(398, 235);
            this.Label_UserName.Name = "Label_UserName";
            this.Label_UserName.Size = new System.Drawing.Size(63, 13);
            this.Label_UserName.TabIndex = 7;
            this.Label_UserName.Text = "UserName :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 770);
            this.ControlBox = false;
            this.Controls.Add(this.Login_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label Label_UserName;
        private System.Windows.Forms.Label label_error;
    }
}