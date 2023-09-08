namespace ExampleSQLApp
{
    partial class LoginForm
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
            System.Windows.Forms.Label passText;
            System.Windows.Forms.Label loginText;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Main = new System.Windows.Forms.Panel();
            this.TextError = new System.Windows.Forms.Label();
            this.RegText = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.footerText = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pass_icon = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.user_icon = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            passText = new System.Windows.Forms.Label();
            loginText = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // passText
            // 
            passText.AutoSize = true;
            passText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passText.ForeColor = System.Drawing.Color.Gold;
            passText.Location = new System.Drawing.Point(99, 211);
            passText.Name = "passText";
            passText.Size = new System.Drawing.Size(85, 30);
            passText.TabIndex = 7;
            passText.Text = "Пароль";
            // 
            // loginText
            // 
            loginText.AutoSize = true;
            loginText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginText.ForeColor = System.Drawing.Color.Gold;
            loginText.Location = new System.Drawing.Point(99, 132);
            loginText.Name = "loginText";
            loginText.Size = new System.Drawing.Size(71, 30);
            loginText.TabIndex = 6;
            loginText.Text = "Логин";
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.TextError);
            this.Main.Controls.Add(this.RegText);
            this.Main.Controls.Add(this.Footer);
            this.Main.Controls.Add(passText);
            this.Main.Controls.Add(loginText);
            this.Main.Controls.Add(this.buttonLogin);
            this.Main.Controls.Add(this.passField);
            this.Main.Controls.Add(this.pass_icon);
            this.Main.Controls.Add(this.loginField);
            this.Main.Controls.Add(this.user_icon);
            this.Main.Controls.Add(this.Header);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.Color.Black;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(431, 491);
            this.Main.TabIndex = 0;
            this.Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // TextError
            // 
            this.TextError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextError.ForeColor = System.Drawing.Color.Gold;
            this.TextError.Location = new System.Drawing.Point(0, 280);
            this.TextError.Name = "TextError";
            this.TextError.Size = new System.Drawing.Size(430, 49);
            this.TextError.TabIndex = 11;
            this.TextError.Text = "INFO";
            this.TextError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegText
            // 
            this.RegText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegText.ForeColor = System.Drawing.Color.Gold;
            this.RegText.Location = new System.Drawing.Point(-1, 389);
            this.RegText.Name = "RegText";
            this.RegText.Size = new System.Drawing.Size(430, 49);
            this.RegText.TabIndex = 10;
            this.RegText.Text = "Зарегистрироваться";
            this.RegText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegText.Click += new System.EventHandler(this.RegText_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(77)))));
            this.Footer.Controls.Add(this.footerText);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 442);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(429, 47);
            this.Footer.TabIndex = 9;
            // 
            // footerText
            // 
            this.footerText.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.footerText.ForeColor = System.Drawing.Color.Gold;
            this.footerText.Location = new System.Drawing.Point(-1, 0);
            this.footerText.Name = "footerText";
            this.footerText.Size = new System.Drawing.Size(431, 47);
            this.footerText.TabIndex = 7;
            this.footerText.Text = "Sgiman Creative Studio";
            this.footerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonLogin.Location = new System.Drawing.Point(97, 331);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(238, 55);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(97, 244);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(238, 35);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pass_icon
            // 
            this.pass_icon.Image = global::ExampleSQLApp.Properties.Resources._lock;
            this.pass_icon.Location = new System.Drawing.Point(56, 244);
            this.pass_icon.Name = "pass_icon";
            this.pass_icon.Size = new System.Drawing.Size(35, 35);
            this.pass_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pass_icon.TabIndex = 3;
            this.pass_icon.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(97, 165);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(238, 35);
            this.loginField.TabIndex = 2;
            // 
            // user_icon
            // 
            this.user_icon.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.user_icon.Location = new System.Drawing.Point(56, 165);
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
            this.Header.Size = new System.Drawing.Size(429, 98);
            this.Header.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(402, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 29);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(429, 98);
            this.title.TabIndex = 0;
            this.title.Text = "Авторизация";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 491);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pass_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_icon)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.PictureBox user_icon;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pass_icon;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label footerText;
        private System.Windows.Forms.Label RegText;
        private System.Windows.Forms.Label TextError;
    }
}