using System;
using System.Configuration;
using System.Collections;
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
    public partial class Выбор_по_характеристикам : Form
    {
        SqlConnection con =  new SqlConnection(ConfigurationManager.ConnectionStrings["Vybor_noutbuka.Properties.Settings.NOTEBOOKConnectionString"].ConnectionString);
        
        public Выбор_по_характеристикам()
        {
            InitializeComponent();
                        
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Proizvodit fr_pr = new Proizvodit();
            
            if (fr_pr.ShowDialog() != DialogResult.OK)
            {
                textBox1.Text = "";
                
                    return;
            }
            else
            {
                 textBox1.Text = fr_pr.firma;
                 label2.Text = fr_pr.id_firma;

                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proc fr_proc = new Proc();
            if (fr_proc.ShowDialog() != DialogResult.OK)
            {
                textBox2.Text = "";
                return;
            }
            else
            {
                textBox2.Text = fr_proc.proc;
                label3.Text = fr_proc.id_pr;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operativ fr_ozy = new Operativ();
            if (fr_ozy.ShowDialog() != DialogResult.OK)
            {
                textBox3.Text = "";
                return;
            }
            else
            {
                textBox3.Text = fr_ozy.ozy;
                label4.Text = fr_ozy.id_ozy;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hdd fr_hdd = new hdd();
            if (fr_hdd.ShowDialog() != DialogResult.OK)
            {
                textBox4.Text = "";
                return;
            }
            else
            {
                textBox4.Text = fr_hdd.hddisk;
                label5.Text = fr_hdd.id_hddisk;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Disk fr_disk = new Disk();
            if (fr_disk.ShowDialog() != DialogResult.OK)
            {
                textBox5.Text = "";
                return;
            }
            else
            {
                textBox5.Text = fr_disk.disk_tip;
                label6.Text = fr_disk.id_disk_tip;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("Не выбраны параметры для поиска", "Ошибка");
                return;
            }
            else
            {

                /*
                string f = "";
                if (textBox1.Text != "")
                    f += "(Parameters like '%" + textBox1.Text + "%') And ";
                if (textBox2.Text != "")
                    f += "(Parameters like '%" + textBox2.Text + "%') And ";
                if (textBox3.Text != "")
                    f += "(Parameters like '%" + textBox3.Text + "%') And ";
                if (textBox4.Text != "")
                    f += "(Parameters like '%" + textBox4.Text + "%') And ";
                if (textBox5.Text != "")
                    f += "(Parameters like '%" + textBox5.Text + "%') And ";
                
                f = " \nWHERE " + f.Remove(f.Length - 5);
                */
                string f = "";
                if (textBox1.Text != "")
                    f += "(id_firm =" + label2.Text +") And ";
                if (textBox2.Text != "")
                    f += "(id_proc = " + label3.Text + ") And ";
                if (textBox3.Text != "")
                    f += "(id_oper = " + label4.Text + ") And ";
                if (textBox4.Text != "")
                    f += "(id_hdd = " + label5.Text + ") And ";
                if (textBox5.Text != "")
                    f += "(id_disk = " + label6.Text + ") And ";

                f = " \nWHERE " + f.Remove(f.Length - 5);

                con.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(sql + f, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds, "notebook");
                dataGridView1.DataSource = ds.Tables[0];
                
                con.Close();
            }


        }
        string sql;
        private void Выбор_по_характеристикам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nOTEBOOKDataSet.Notebook". При необходимости она может быть перемещена или удалена.
            this.notebookTableAdapter.Fill(this.nOTEBOOKDataSet.Notebook);
            sql = @"SELECT id, Notebook, Price, Parameters FROM Notebook";
        }

        private void Выбор_по_характеристикам_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
