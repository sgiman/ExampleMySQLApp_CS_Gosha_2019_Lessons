namespace ExampleSQLApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.footerText = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.textAuthor = new System.Windows.Forms.Label();
            this.textError = new System.Windows.Forms.Label();
            this.textSurName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.Label();
            this.conatct_icon = new System.Windows.Forms.PictureBox();
            this.TelField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.SeсondNameField = new System.Windows.Forms.TextBox();
            this.pass_icon = new System.Windows.Forms.PictureBox();
            this.user_icon = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.Footer.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conatct_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(726, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 29);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(12)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(54)))), ((int)(((byte)(25)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(16)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(217)))), ((int)(((byte)(10)))));
            this.buttonLogin.Location = new System.Drawing.Point(239, 433);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(270, 55);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Зарегистрироваться";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(383, 324);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(250, 35);
            this.PassField.TabIndex = 4;
            this.PassField.Text = "Password";
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // FirstNameField
            // 
            this.FirstNameField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameField.Location = new System.Drawing.Point(115, 152);
            this.FirstNameField.Multiline = true;
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(250, 35);
            this.FirstNameField.TabIndex = 2;
            this.FirstNameField.Text = "Имя";
            this.FirstNameField.Enter += new System.EventHandler(this.FisrtNameField_Enter);
            this.FirstNameField.Leave += new System.EventHandler(this.FisrtNameField_Leave);
            // 
            // footerText
            // 
            this.footerText.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footerText.ForeColor = System.Drawing.Color.Gold;
            this.footerText.Location = new System.Drawing.Point(-1, 0);
            this.footerText.Name = "footerText";
            this.footerText.Size = new System.Drawing.Size(755, 47);
            this.footerText.TabIndex = 7;
            this.footerText.Text = "Sgiman Creative Studio";
            this.footerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.Footer.Controls.Add(this.footerText);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 551);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(753, 47);
            this.Footer.TabIndex = 9;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.textAuthor);
            this.Main.Controls.Add(this.textError);
            this.Main.Controls.Add(this.textSurName);
            this.Main.Controls.Add(this.textName);
            this.Main.Controls.Add(this.textPhone);
            this.Main.Controls.Add(this.textEmail);
            this.Main.Controls.Add(this.textPassword);
            this.Main.Controls.Add(this.textLogin);
            this.Main.Controls.Add(this.conatct_icon);
            this.Main.Controls.Add(this.TelField);
            this.Main.Controls.Add(this.EmailField);
            this.Main.Controls.Add(this.LoginField);
            this.Main.Controls.Add(this.SeсondNameField);
            this.Main.Controls.Add(this.Footer);
            this.Main.Controls.Add(this.buttonLogin);
            this.Main.Controls.Add(this.PassField);
            this.Main.Controls.Add(this.pass_icon);
            this.Main.Controls.Add(this.FirstNameField);
            this.Main.Controls.Add(this.user_icon);
            this.Main.Controls.Add(this.Header);
            this.Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.Color.Black;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(755, 600);
            this.Main.TabIndex = 1;
            this.Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // textAuthor
            // 
            this.textAuthor.AutoSize = true;
            this.textAuthor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAuthor.ForeColor = System.Drawing.Color.Gold;
            this.textAuthor.Location = new System.Drawing.Point(300, 506);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(151, 25);
            this.textAuthor.TabIndex = 22;
            this.textAuthor.Text = "Авторизоваться";
            this.textAuthor.Click += new System.EventHandler(this.textAuthor_Click);
            // 
            // textError
            // 
            this.textError.AutoSize = true;
            this.textError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textError.ForeColor = System.Drawing.Color.Gold;
            this.textError.Location = new System.Drawing.Point(110, 383);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(156, 25);
            this.textError.TabIndex = 21;
            this.textError.Text = "Зполните форму";
            // 
            // textSurName
            // 
            this.textSurName.AutoSize = true;
            this.textSurName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSurName.ForeColor = System.Drawing.Color.Gold;
            this.textSurName.Location = new System.Drawing.Point(378, 119);
            this.textSurName.Name = "textSurName";
            this.textSurName.Size = new System.Drawing.Size(248, 30);
            this.textSurName.TabIndex = 20;
            this.textSurName.Text = "*Фамилия (обязательно)";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.Color.Gold;
            this.textName.Location = new System.Drawing.Point(113, 119);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(203, 30);
            this.textName.TabIndex = 19;
            this.textName.Text = "*Имя (обязательно)";
            // 
            // textPhone
            // 
            this.textPhone.AutoSize = true;
            this.textPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPhone.ForeColor = System.Drawing.Color.Gold;
            this.textPhone.Location = new System.Drawing.Point(378, 197);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(95, 30);
            this.textPhone.TabIndex = 18;
            this.textPhone.Text = "Телефон";
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEmail.ForeColor = System.Drawing.Color.Gold;
            this.textEmail.Location = new System.Drawing.Point(110, 197);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(72, 30);
            this.textEmail.TabIndex = 17;
            this.textEmail.Text = "E-Mail";
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPassword.ForeColor = System.Drawing.Color.Gold;
            this.textPassword.Location = new System.Drawing.Point(378, 291);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(233, 30);
            this.textPassword.TabIndex = 13;
            this.textPassword.Text = "*Пароль (обязательно)";
            // 
            // textLogin
            // 
            this.textLogin.AutoSize = true;
            this.textLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.ForeColor = System.Drawing.Color.Gold;
            this.textLogin.Location = new System.Drawing.Point(110, 291);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(219, 30);
            this.textLogin.TabIndex = 12;
            this.textLogin.Text = "*Логин (обязательно)";
            // 
            // conatct_icon
            // 
            this.conatct_icon.Image = global::ExampleSQLApp.Properties.Resources.mail;
            this.conatct_icon.Location = new System.Drawing.Point(60, 230);
            this.conatct_icon.Name = "conatct_icon";
            this.conatct_icon.Size = new System.Drawing.Size(35, 35);
            this.conatct_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conatct_icon.TabIndex = 16;
            this.conatct_icon.TabStop = false;
            // 
            // TelField
            // 
            this.TelField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelField.Location = new System.Drawing.Point(383, 230);
            this.TelField.Multiline = true;
            this.TelField.Name = "TelField";
            this.TelField.Size = new System.Drawing.Size(250, 35);
            this.TelField.TabIndex = 15;
            this.TelField.Text = "Телефон";
            this.TelField.Enter += new System.EventHandler(this.TelField_Enter);
            this.TelField.Leave += new System.EventHandler(this.TelField_Leave);
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.Location = new System.Drawing.Point(115, 230);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(250, 35);
            this.EmailField.TabIndex = 14;
            this.EmailField.Text = "Email";
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(115, 324);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(250, 35);
            this.LoginField.TabIndex = 11;
            this.LoginField.Text = "Логин";
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // SeсondNameField
            // 
            this.SeсondNameField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeсondNameField.Location = new System.Drawing.Point(383, 152);
            this.SeсondNameField.Multiline = true;
            this.SeсondNameField.Name = "SeсondNameField";
            this.SeсondNameField.Size = new System.Drawing.Size(250, 35);
            this.SeсondNameField.TabIndex = 10;
            this.SeсondNameField.Text = "Фамилия";
            this.SeсondNameField.Enter += new System.EventHandler(this.SeсondNameField_Enter);
            this.SeсondNameField.Leave += new System.EventHandler(this.SeсondNameField_Leave);
            // 
            // pass_icon
            // 
            this.pass_icon.Image = global::ExampleSQLApp.Properties.Resources._lock;
            this.pass_icon.Location = new System.Drawing.Point(60, 324);
            this.pass_icon.Name = "pass_icon";
            this.pass_icon.Size = new System.Drawing.Size(35, 35);
            this.pass_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass_icon.TabIndex = 3;
            this.pass_icon.TabStop = false;
            // 
            // user_icon
            // 
            this.user_icon.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.user_icon.Location = new System.Drawing.Point(60, 152);
            this.user_icon.Name = "user_icon";
            this.user_icon.Size = new System.Drawing.Size(35, 35);
            this.user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_icon.TabIndex = 1;
            this.user_icon.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.title);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(753, 98);
            this.Header.TabIndex = 0;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(753, 98);
            this.title.TabIndex = 0;
            this.title.Text = "Регистрация";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 600);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Footer.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conatct_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pass_icon;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.PictureBox user_icon;
        private System.Windows.Forms.Label footerText;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox SeсondNameField;
        private System.Windows.Forms.Label textLogin;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.TextBox TelField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.PictureBox conatct_icon;
        private System.Windows.Forms.Label textSurName;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textPhone;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label textError;
        private System.Windows.Forms.Label textAuthor;
    }
}