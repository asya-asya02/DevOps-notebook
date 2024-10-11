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
    public partial class Form3 : Form
    {
        public string connectionString = "Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
        
        string str1;
        string str2;
            
        private void button1_Click(object sender, EventArgs e)
        {            
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            // Добавить
            
            if (textBox1.Text.Trim() != "Модель")
            {
                if (textBox1.Text.Trim() != "")
                {
                    if (textBox2.Text != "Цена")
                    {
                        if (textBox2.Text.Trim() != "")
                        {
                            if (comboBox1.Text != "Диапазон цены")
                            {
                                if (comboBox2.Text != "Производитель")
                                {
                                    if (comboBox3.Text != "Тип")
                                    {
                                        if (comboBox4.Text != "Процессор")
                                        {
                                            if (comboBox5.Text != "ОЗУ")
                                            {
                                                if (comboBox6.Text != "HDD")
                                                {
                                                    if (comboBox7.Text != "Привод")
                                                    {
                                                        if (comboBox8.Text != "Диагональ")
                                                        {
                                                            if (comboBox9.Text != "ОС")
                                                            {
                                                                if (comboBox10.Text != "Блутус")
                                                                {
                                                                    if (comboBox11.Text != "Назначение")
                                                                    {
                                                                        
                                                                        SqlConnection con = new SqlConnection(connectionString);
                                                                        SqlCommand cmd = new SqlCommand();
                                                                        cmd.CommandType = CommandType.Text;
                                                                        cmd.CommandText = "INSERT Notebook (notebook, price, id_money, id_firm, id_tip, id_proc, id_oper, id_hdd, id_disk, id_diag, id_os, id_bluetooth, id_using) VALUES" + "(@notebook, @price, @id_money, @id_firm, @id_tip, @id_proc, @id_oper, @id_hdd, @id_disk, @id_diag, @id_os, @id_bluetooth, @id_using)";
                                                                        cmd.Connection = con;
                                                                        cmd.Parameters.AddWithValue("@notebook", textBox1.Text);
                                                                        cmd.Parameters.AddWithValue("@price", textBox2.Text);
                                                                        cmd.Parameters.AddWithValue("@id_money", Convert.ToInt32(comboBox1.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_firm", Convert.ToInt32(comboBox2.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_tip", Convert.ToInt32(comboBox3.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_proc", Convert.ToInt32(comboBox4.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_oper", Convert.ToInt32(comboBox5.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_hdd", Convert.ToInt32(comboBox6.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_disk", Convert.ToInt32(comboBox7.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_diag", Convert.ToInt32(comboBox8.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_os", Convert.ToInt32(comboBox9.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_bluetooth", Convert.ToInt32(comboBox10.SelectedValue));
                                                                        cmd.Parameters.AddWithValue("@id_using", Convert.ToInt32(comboBox11.SelectedValue));
                                                                        str1 = textBox1.Text;
                                                                        if (str1 !=str2)
                                                                        {
                                                                            str2 = str1;
                                                                        con.Open();
                                                                        cmd.ExecuteNonQuery();
                                                                        con.Close();
                                                                        MessageBox.Show("Новая запись добавлена. ");                                                                        
                                                                        } else 
                                                                        {
                                                                            str1 = str2;
                                                                            //MessageBox.Show(str1);
                                                                            MessageBox.Show("Модель уже существует ! ");  
                                                                        }
                                                                        
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Обязательно выберите <Назначение> !!!");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Обязательно выберите <Bluetooth> !!!");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Обязательно выберите <ОС> !!!");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Обязательно выберите <Диагональ> !!!");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Обязательно выберите <Привод> !!!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Обязательно выберите <HDD> !!!");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Обязательно выберите <ОЗУ> !!!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Обязательно выберите <Процессор> !!!");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Обязательно выберите <Тип> !!!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Обязательно выберите <Производитель> !!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Обязательно выберите <Диапазон Цены> !!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заполните ячейку <Цена>!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ячейка <Цена> не должна быть пустым !");
                    }
                }
                else 
                {
                    MessageBox.Show("Ячейка <Модель> не должна быть  пустым !");                
                }
             }
            else
            {                
                    MessageBox.Show("Заполните ячейку <Модель> !");                
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {            
            this.usingTableAdapter.Fill(this.notebookDataSet3.Using);         
            this.bluetoothTableAdapter.Fill(this.notebookDataSet3.bluetooth);         
            this.oSTableAdapter.Fill(this.notebookDataSet3.OS);         
            this.diagonalTableAdapter.Fill(this.notebookDataSet3.Diagonal);         
            this.diskTableAdapter.Fill(this.notebookDataSet3.Disk);         
            this.hDDTableAdapter.Fill(this.notebookDataSet3.HDD);         
            this.operativTableAdapter.Fill(this.notebookDataSet3.Operativ);         
            this.processorTableAdapter.Fill(this.notebookDataSet3.Processor);         
            this.tipTableAdapter.Fill(this.notebookDataSet3.tip);         
            this.firmTableAdapter.Fill(this.notebookDataSet3.Firm);         
            this.moneyTableAdapter.Fill(this.notebookDataSet3.Money);
            textBox1.Text = "Модель";
            textBox2.Text = "Цена";
            comboBox1.Text = "Диапазон цены";
            comboBox2.Text = "Производитель";
            comboBox3.Text = "Тип";
            comboBox4.Text = "Процессор";
            comboBox5.Text = "ОЗУ";
            comboBox6.Text = "HDD";
            comboBox7.Text = "Привод";
            comboBox8.Text = "Диагональ";
            comboBox9.Text = "ОС";
            comboBox10.Text = "Блутус";
            comboBox11.Text = "Назначение";
        }
    }
}
