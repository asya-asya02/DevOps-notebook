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
    public partial class Form9 : Form
    {
        public string connectionString = @"Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавить
            if (textBox1.Text.Trim() != "")
            {
                if (textBox2.Text.Trim() != "")
                {
                    if (textBox3.Text.Trim() != "")
                    {
                        string SqlText = "INSERT INTO Users (FIO, Login, Hash_Pwd) VALUES (" + "'" + textBox1.Text + "'" + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + ")";
                        //MessageBox.Show(SqlText);
                        /*************************************************************************************/
                        string connectionString = @"Data Source=.;Initial Catalog=NOTEBOOK;Integrated Security=True";

                        SqlConnection SQLCon = new SqlConnection(connectionString);
                        SqlCommand sqlcomm = new SqlCommand();
                        sqlcomm.Connection = SQLCon;

                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandText = "chck_rec"; 
                        sqlcomm.Parameters.AddWithValue("@login", textBox2.Text);
                                                
                        var returnParam1 = new SqlParameter
                        {
                            ParameterName = "@id",
                            Direction = ParameterDirection.Output,
                            Size = 3
                        };
                        sqlcomm.Parameters.Add(returnParam1);                        

                        SQLCon.Open();
                        sqlcomm.ExecuteNonQuery();

                        string retunvalue = (string)sqlcomm.Parameters["@id"].Value;
                        //MessageBox.Show(retunvalue);
                        SQLCon.Close();
                        if (retunvalue != "-1")
                        {
                            MessageBox.Show("Такой ЛОГИН уже усть!");
                         
                        }
                        /*************************************************************************************/
                        else
                        {
                            MyExecuteNonQuery(SqlText);
                            MessageBox.Show("Запись добавлена !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите пароль!");
                    }
                }
                else
                {
                    MessageBox.Show("Введите Логин!");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле ФИО");
            }


        }
    }
}
