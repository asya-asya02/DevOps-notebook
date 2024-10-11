using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vybor_noutbuka
{
    public partial class Form5 : Form
    {
        public string connectionString = @"Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public string[] Mas1 = new string[1];
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //выход
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавить
            //MessageBox.Show(tab1.Value);
            //MessageBox.Show(col1.Value);
            
            if (textBox1.Text.Trim() != "")
            {
             
                string SqlText = "INSERT INTO "+tab1.Value+" (["+col1.Value+"]) VALUES ("+"'"+textBox1.Text+"'"+") ";
                //MessageBox.Show(SqlText);
                MyExecuteNonQuery(SqlText);
                MessageBox.Show("Запись добавлена !");
             
            }
            else
            {
                MessageBox.Show("Заполните поле !");
            }
            
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn; // экземпляр класса типа SqlConnection
            SqlCommand cmd;

            // выделение памяти с инициализацией строки соединения с базой данных
            cn = new SqlConnection(connectionString);
            cn.Open(); // открыть источник данных
            cmd = cn.CreateCommand(); // задать SQL-команду
            cmd.CommandText = SqlText; // задать командную строку
            cmd.ExecuteNonQuery(); // выполнить SQL-команду
            cn.Close(); // закрыть источник данных
        }
    }
}
