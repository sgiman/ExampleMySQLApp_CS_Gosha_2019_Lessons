//**********************************************************************************
// MainForm.cs
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

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        // -----------------
        //  CloseButton (x)
        // -----------------
        private void CloseButton_Click(object sender, EventArgs e)
        {
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

        // --- Main Panel move ---
        Point lastPoint2;
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }


    } // --- class MainForm ---

} // --- namespace ExampleSQLApp ---
