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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.Label_UserName = new System.Windows.Forms.Label();
            this.Registration_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.Registration_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Panel
            // 
            this.Login_Panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Login_Panel.Controls.Add(this.Registration_Panel);
            this.Login_Panel.Controls.Add(this.textBox_username);
            this.Login_Panel.Controls.Add(this.textBox_password);
            this.Login_Panel.Controls.Add(this.button_register);
            this.Login_Panel.Controls.Add(this.button_login);
            this.Login_Panel.Controls.Add(this.picture);
            this.Login_Panel.Controls.Add(this.label_Password);
            this.Login_Panel.Controls.Add(this.Label_UserName);
            this.Login_Panel.Location = new System.Drawing.Point(0, 0);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(800, 450);
            this.Login_Panel.TabIndex = 7;
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
            // Registration_Panel
            // 
            this.Registration_Panel.Controls.Add(this.Home_Panel);
            this.Registration_Panel.Controls.Add(this.pictureBox1);
            this.Registration_Panel.Location = new System.Drawing.Point(0, 0);
            this.Registration_Panel.Name = "Registration_Panel";
            this.Registration_Panel.Size = new System.Drawing.Size(800, 450);
            this.Registration_Panel.TabIndex = 14;
            this.Registration_Panel.Visible = false;
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
            // Home_Panel
            // 
            this.Home_Panel.Controls.Add(this.pictureBox2);
            this.Home_Panel.Location = new System.Drawing.Point(0, 0);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(800, 450);
            this.Home_Panel.TabIndex = 11;
            this.Home_Panel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 62);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_Panel);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.Registration_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Home_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

