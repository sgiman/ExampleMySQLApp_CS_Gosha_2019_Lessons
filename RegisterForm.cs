//**********************************************************************************
// RegisterForm.cs
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
using MySql.Data.MySqlClient;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            
            InitializeComponent();
            
            FirstNameField.Text = "Имя";
            FirstNameField.ForeColor = Color.Gray;

            SeсondNameField.Text= "Фамилия";
            SeсondNameField.ForeColor = Color.Gray;

            LoginField.Text = "Login";
            LoginField.ForeColor = Color.Gray;

            PassField.Text = "Password";
            PassField.ForeColor = Color.Gray;

            EmailField.Text = "Email";
            EmailField.ForeColor = Color.Gray;

            TelField.Text = "Phone";
            TelField.ForeColor = Color.Gray;

        }


        // *******************
        //   Window moving        
        // *******************

        // --- Title move ---
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

        // --- Panel move ---
        Point lastPoint2;
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
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
        // Close Button (x)
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


        //////////////////////
        //       Fields     //
        //////////////////////

        // --- FirstName Field--- 
        private void FisrtNameField_Enter(object sender, EventArgs e)
        {
            if (FirstNameField.Text == "Имя")
            {
                FirstNameField.Text = "";
                FirstNameField.ForeColor = Color.Black;
            }
        }
        private void FisrtNameField_Leave(object sender, EventArgs e)
        {
            if (FirstNameField.Text == "")
            {
                FirstNameField.Text = "Имя";
                FirstNameField.ForeColor = Color.Gray;
            }
        }

        // --- SeсondName Field --- 
        private void SeсondNameField_Enter(object sender, EventArgs e)
        {
            if (SeсondNameField.Text == "Фамилия")
            {
                SeсondNameField.Text = "";
                SeсondNameField.ForeColor = Color.Black;
            }
        }
        private void SeсondNameField_Leave(object sender, EventArgs e)
        {
            if (SeсondNameField.Text == "")
            {
                SeсondNameField.Text = "Фамилия";
                SeсondNameField.ForeColor = Color.Gray;
            }
        }

        // --- Login Field --- 
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text == "Login")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Login";
                LoginField.ForeColor = Color.Gray;
            }
        }

        // --- Password Field --- 
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Password")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }
        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Password";
                PassField.ForeColor = Color.Gray;
            }
        }

        // --- Email Field --- 
        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Email")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }
        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Email";
                EmailField.ForeColor = Color.Gray;
            }
        }

        // --- Phone Field --- 
        private void TelField_Enter(object sender, EventArgs e)
        {
            if (TelField.Text == "Phone")
            {
                TelField.Text = "";
                TelField.ForeColor = Color.Black;
            }
        }
        private void TelField_Leave(object sender, EventArgs e)
        {
            if (TelField.Text == "")
            {
                TelField.Text = "Phone";
                TelField.ForeColor = Color.Gray;
            }
        }

        //*************************
        ///////////////////////////
        //  Button Registration  //
        //*************************
        ///////////////////////////
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CLICK REGISTRATION!!");

            // ------------------------
            //   Control Input fields
            // ------------------------
            if (FirstNameField.Text == "Имя" || SeсondNameField.Text == "Фамилия" ||
                LoginField.Text == "Логин" || PassField.Text == "Password")
            {
                textError.Text = "Заполните поля: Имя, Фамилия, Логин, Пароль";
                //MessageBox.Show("Введите поля: Имя, Фамилия, Логин, Пароль");
                return;
            }
            else
            {
                textError.Text = "РЕГИСТРАЦИЯ...";
            }


            //************************ 
            //   Register New User
            //************************ 

            DB db = new DB();       // object for connect MySQL

            if (isUserExist())      // если введённый логин уже есть в DB
                return;

            MySqlCommand command = new MySqlCommand("INSERT INTO users " +
                "(login, pass, email, firstname, secondname, phone) " +
                "VALUES (@login, @pass, @email, @firstname, @secondname, @phone)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailField.Text;
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = FirstNameField.Text;
            command.Parameters.Add("@secondname", MySqlDbType.VarChar).Value = SeсondNameField.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = TelField.Text;

            db.OpenConnection();    // подключить DB (mysql)

            if(command.ExecuteNonQuery() == 1)
            {
                textError.Text = "ПОДРАВЛЯЕМ! ВЫ БЫЛИ УСПЕШНО ЗАРЕГИСТРИРОВАНЫ";
                //MessageBox.Show("Аккаунт был создан");
            }
            else
            {
                textError.Text = "Аккаунт не был создан";
                //MessageBox.Show("Аккаунт не был создан");
            }

            db.CloseConnection();   // закрыть, чтобы не перегружать DB

        } // --- buttonLogin_Click ---


        //*************************
        //       Check Login
        //*************************
        public Boolean isUserExist()
        {
            DB db = new DB();                                   // Data Base
            db.OpenConnection();

            DataTable table = new DataTable();                  // Data Set 
            MySqlDataAdapter adapter = new MySqlDataAdapter();  // Adapter

            // Найти логин 
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text; // дабавить параметер для SELECT          
            adapter.SelectCommand = command;                                            // выбрать и выполнить sql-команду
            adapter.Fill(table);                                                        // заполнить таблицу
            
            // Еcли зарегистрирован user с этим логином 
            if (table.Rows.Count > 0)
            {
                textError.Text = "Такой логин уже есть, введите другой логин";
                return true;
            }
            else
            {
                //MessageBox.Show("OK");
                textError.Text = "COUNT = " + table.Rows.Count;
                return false;
            }
        }

        // ------------------
        //       LOGIN
        // ------------------
        // --- Перейти на форму LoginForm ---
        private void textAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        

    } // --- class RegisterForm ---

} // --- namespace ExampleSQLApp ---
