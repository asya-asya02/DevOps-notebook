using System;
using System.Configuration;
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
    
    public partial class Naznachen : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Vybor_noutbuka.Properties.Settings.NOTEBOOKConnectionString"].ConnectionString);
        public Naznachen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Цена fr_cena = new Цена();
            if (fr_cena.ShowDialog() != DialogResult.OK)
            {
                textBox1.Text = "";
                return;
            }
            else
            {
                textBox1.Text = fr_cena.diapozon;
                label2.Text = fr_cena.id_diapozon;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Цель fr_isp = new Цель();
            if (fr_isp.ShowDialog() != DialogResult.OK)
            {
                textBox2.Text = "";
                return;
            }
            else
            {
                textBox2.Text = fr_isp.isp;
                label3.Text = fr_isp.id_isp;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Дюймы fr_diag = new Дюймы();
            if (fr_diag.ShowDialog() != DialogResult.OK)
            {
                textBox3.Text = "";
                return;
            }
            else
            {
                textBox3.Text = fr_diag.diag;
                label4.Text = fr_diag.id_diag;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OC fr_os = new OC();
            if (fr_os.ShowDialog() != DialogResult.OK)
            {
                textBox4.Text = "";
                return;
            }
            else
            {
                textBox4.Text = fr_os.op_sys;
                label5.Text = fr_os.id_op_sys;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bluetooth fr_bl = new Bluetooth();
            if (fr_bl.ShowDialog() != DialogResult.OK)
            {
                textBox5.Text = "";
                return;
            }
            else
            {
                textBox5.Text = fr_bl.bl_podkl;
                label6.Text = fr_bl.id_bl_podkl;
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
                    f += "(id_money = " + label2.Text + ") And ";
                if (textBox2.Text != "")
                    f += "(id_using = " + label3.Text + ") And ";
                if (textBox3.Text != "")
                    f += "(id_diag = " + label4.Text + ") And ";
                if (textBox4.Text != "")
                    f += "(id_os = " + label5.Text + ") And ";
                if (textBox5.Text != "")
                    f += "(id_bluetooth = " + label6.Text + ") And ";

                f = " \nWHERE " + f.Remove(f.Length - 5);

        //        SqlConnection connectionString = new SqlConnection("Data Source=USER-PC;Initial Catalog=NOTEBOOK;Integrated Security=True");
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

        private void Выбор_по_назначению_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nOTEBOOKDataSet.Notebook". При необходимости она может быть перемещена или удалена.
            this.notebookTableAdapter.Fill(this.nOTEBOOKDataSet.Notebook);
            sql = @"SELECT        id, Notebook, Parameters, Price
FROM            Notebook";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
