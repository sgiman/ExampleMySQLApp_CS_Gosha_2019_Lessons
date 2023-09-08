//**********************************************************************************
// DB.cs
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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   // for MySQL connection

namespace ExampleSQLApp
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password='';database=scs");

        // Подключить MySql
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        // Отключить MySql
        public void CloseConnection()
        { 
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Возвратить MySql-подключение  
        public MySqlConnection getConnection()
        {
            OpenConnection();
            return connection;
        }
    }

}
