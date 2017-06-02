using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Data.Common;
using SQLite;
//using MetroFramework.Components;
//using MetroFramework.Forms;

namespace Library3
{
    
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

//        string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
//        string userName = "root"; // Имя пользователя
//        string dbName = "library"; //Имя базы данных
//        string port = "3306"; // Порт для подключения
//        string password = "root"; // Пароль для подключения
//        MySql.Data.MySqlClient.MySqlConnection myConnection = new MySql.Data.MySqlClient.MySqlConnection(Connect);
//        MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(CommandText, myConnection);
//        myConnection.Open(); //Устанавливаем соединение с базой данных.
////Что то делаем...
//DbConnection.Close(); //Обязательно закрываем соединение!

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com");
        }

        private void jПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.database1DataSet1.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Library". При необходимости она может быть перемещена или удалена.
            this.libraryTableAdapter.Fill(this.database1DataSet.Library);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {

                for (int i = 0; i < this.dataGridView1.RowCount; i++)

                {

                    for (int j = 0; j < this.dataGridView1.Columns.Count; j++)

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))

                        {

                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aquamarine;

                        }

                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
          

           

                this.LibraryTableAdapter.Update(this.dirDataSet.Library);

            }
        }
    }
}
