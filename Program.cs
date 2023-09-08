//**********************************************************************************
// Program.cs
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
            //Application.Run(new RegisterForm());
            //Application.Run(new MainForm());
        }
    }
}
