//**********************************************************************************
// LoginForm.cs
// 007 - Переход между окнами в приложении
// ---------------------------------------------------------------------------------
// С# | Visual Studio 2022
// .NET 4.8, MySQL(MariaDB), Windows Forms (.NET Framework)
// Template - App Windows Forms (.NET Framework)
// ---------------------------------------------------------------------------------
// icon finder
// https://www.iconfinder.com/
//
// Connector/NET 8.1.0//
// https://dev.mysql.com/downloads/connector/net/
// ---------------------------------------------------------------------------------
// Уроки C# .NET Windows Forms + Базы данных SQL (Gosha Dudar)
// Writing by sgiman @ 2023
//**********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   // for MySQL


namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        //********************
        //      METHODS
        //********************

        public LoginForm()
        {
            InitializeComponent();

            // откл. AutoSize
            this.passField.AutoSize = false;
            
            // новая высота для пароля
            this.passField.Size = new Size(this.passField.Size.Width, 35);

            TextError.Text = "";
        }


        // -------------------
        //   Window moving        
        // -------------------

        // --- Title Move ---
        Point lastPoint1;
        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            // Если была нажата левая кнопка
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }
        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        // --- Panel Move ---
        Point lastPoint2;
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            // Если была нажата левая кнопка
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }


        // ------------------
        //  Close Button (x)
        // ------------------
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.YellowGreen;
        }
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }


        // ----------------
        //   Button Login  
        // ----------------
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------------------
            // Connect to Server MySQL       
            string connstr = "server=localhost;user=root;database=scs;password=''";
            
            MySqlConnection conn = new MySqlConnection(connstr);    // подключить MySQL DB
            conn.Open();

            string sql ="SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string strOut = reader[0].ToString() + " " + reader[1].ToString() + '\n';
                MessageBox.Show(strOut);
            }

            reader.Close();     // закрыть reader
            conn.Close();       // закрыть connect
            -------------------------------------------------------------------------------*/
         
            // Получить данные из формы 
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            // Выделить память для объекта db (mysql)
            DB db = new DB();                                   // data base
            db.OpenConnection();

            DataTable table = new DataTable();                  // таблица
            MySqlDataAdapter adapter = new MySqlDataAdapter();  // адаптер

            // Заглушки @uL и @uP для безопасности         
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND pass = @uP", db.getConnection());        
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;                    // выбрать и выполнить sql-команду
            
            adapter.Fill(table);                                // заполнить таблицу

            // Еcли зарегистрирован хотя бы один user 
            if (table.Rows.Count > 0)
            {
                TextError.Text = "ВХОД";
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            } 
            else
                TextError.Text = "НЕ ЗАРЕГИСТРИРОВАН";


        } // ---- buttonLogin_Click ---

        // ------------------
        //    REGISTRATION
        // ------------------
        // --- Перейти на форму RegisterForm ---
        private void RegText_Click(object sender, EventArgs e)
        {
            // Скрыть LoginForm
            this.Hide();

            // Отобразить форму регистрации - RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

    } // --- class LoginForm ---

} // --- namespace ExampleSQLApp ---
