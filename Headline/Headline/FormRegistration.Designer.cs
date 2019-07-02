namespace Headline
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.Registration_Panel = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_error_user = new System.Windows.Forms.Label();
            this.label_error_pass2 = new System.Windows.Forms.Label();
            this.label_error_pass = new System.Windows.Forms.Label();
            this.label_error_mail = new System.Windows.Forms.Label();
            this.label_correct = new System.Windows.Forms.Label();
            this.Registration_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration_Panel
            // 
            this.Registration_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registration_Panel.Controls.Add(this.label_correct);
            this.Registration_Panel.Controls.Add(this.label_error_mail);
            this.Registration_Panel.Controls.Add(this.label_error_pass);
            this.Registration_Panel.Controls.Add(this.label_error_pass2);
            this.Registration_Panel.Controls.Add(this.label_error_user);
            this.Registration_Panel.Controls.Add(this.confirm);
            this.Registration_Panel.Controls.Add(this.password);
            this.Registration_Panel.Controls.Add(this.email);
            this.Registration_Panel.Controls.Add(this.username);
            this.Registration_Panel.Controls.Add(this.buttonRegister);
            this.Registration_Panel.Controls.Add(this.label5);
            this.Registration_Panel.Controls.Add(this.label6);
            this.Registration_Panel.Controls.Add(this.label7);
            this.Registration_Panel.Controls.Add(this.label8);
            this.Registration_Panel.Controls.Add(this.pictureBox1);
            this.Registration_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Registration_Panel.Location = new System.Drawing.Point(0, 0);
            this.Registration_Panel.Name = "Registration_Panel";
            this.Registration_Panel.Size = new System.Drawing.Size(1264, 681);
            this.Registration_Panel.TabIndex = 19;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(575, 337);
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '*';
            this.confirm.Size = new System.Drawing.Size(100, 20);
            this.confirm.TabIndex = 31;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(575, 294);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 30;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(575, 245);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 29;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(575, 206);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 28;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(553, 392);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 27;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "e-mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Username :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(488, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label_error_user
            // 
            this.label_error_user.AutoSize = true;
            this.label_error_user.Location = new System.Drawing.Point(692, 209);
            this.label_error_user.Name = "label_error_user";
            this.label_error_user.Size = new System.Drawing.Size(35, 13);
            this.label_error_user.TabIndex = 32;
            this.label_error_user.Text = "Error :";
            this.label_error_user.Visible = false;
            // 
            // label_error_pass2
            // 
            this.label_error_pass2.AutoSize = true;
            this.label_error_pass2.Location = new System.Drawing.Point(692, 340);
            this.label_error_pass2.Name = "label_error_pass2";
            this.label_error_pass2.Size = new System.Drawing.Size(35, 13);
            this.label_error_pass2.TabIndex = 33;
            this.label_error_pass2.Text = "Error :";
            this.label_error_pass2.Visible = false;
            // 
            // label_error_pass
            // 
            this.label_error_pass.AutoSize = true;
            this.label_error_pass.Location = new System.Drawing.Point(692, 297);
            this.label_error_pass.Name = "label_error_pass";
            this.label_error_pass.Size = new System.Drawing.Size(35, 13);
            this.label_error_pass.TabIndex = 34;
            this.label_error_pass.Text = "Error :";
            this.label_error_pass.Visible = false;
            // 
            // label_error_mail
            // 
            this.label_error_mail.AutoSize = true;
            this.label_error_mail.Location = new System.Drawing.Point(692, 248);
            this.label_error_mail.Name = "label_error_mail";
            this.label_error_mail.Size = new System.Drawing.Size(35, 13);
            this.label_error_mail.TabIndex = 35;
            this.label_error_mail.Text = "Error :";
            this.label_error_mail.Visible = false;
            // 
            // label_correct
            // 
            this.label_correct.AutoSize = true;
            this.label_correct.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_correct.Location = new System.Drawing.Point(499, 145);
            this.label_correct.Name = "label_correct";
            this.label_correct.Size = new System.Drawing.Size(261, 13);
            this.label_correct.TabIndex = 36;
            this.label_correct.Text = "Correct : Your account has been succesfully created !";
            this.label_correct.Visible = false;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.Registration_Panel);
            this.Name = "FormRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Registration_Panel.ResumeLayout(false);
            this.Registration_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Registration_Panel;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_error_mail;
        private System.Windows.Forms.Label label_error_pass;
        private System.Windows.Forms.Label label_error_pass2;
        private System.Windows.Forms.Label label_error_user;
        private System.Windows.Forms.Label label_correct;
    }
}