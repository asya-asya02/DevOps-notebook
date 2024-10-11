using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vybor_noutbuka
{

    public partial class Notebook : Form
    {
        //Form fsmg = Application.OpenForms["Samsung"];
        public Notebook()
        {
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.Reload);       
            InitializeComponent();
        }
        string par3;
        string par1;
        void Reload(string param1, string param2, string param3)
        {
            label1.Text = param1;
            Text = param1;
            par1 = param2;
            par3 = param3;
        }

        private void Notebook_Load(object sender, EventArgs e)
        {            
            dataGridView1.Columns.Add("1", "Характеристики");
            dataGridView1.Columns.Add("2", @par3);
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "Диапазон цены";
            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "Модель";
            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "Тип";
            dataGridView1.Rows.Add();
            dataGridView1[0, 3].Value = "Процессор";
            dataGridView1.Rows.Add();
            dataGridView1[0, 4].Value = "Оперативный память";
            dataGridView1.Rows.Add();
            dataGridView1[0, 5].Value = "Жесткий диск";
            dataGridView1.Rows.Add();
            dataGridView1[0, 6].Value = "Дисковод";
            dataGridView1.Rows.Add();
            dataGridView1[0, 7].Value = "Диагональ экрана";
            dataGridView1.Rows.Add();
            dataGridView1[0, 8].Value = "ОС";
            dataGridView1.Rows.Add();
            dataGridView1[0, 9].Value = "Bluetooth";
            dataGridView1.Rows.Add();
            dataGridView1[0, 10].Value = "Назначение";

            string s = @par1;
            //MessageBox.Show(par1);
            string[] array = s.Split(','); 
                        
            for (int j = 0; j < array.GetLength(0); j++)
                dataGridView1[1, j].Value = array[j];

            dataGridView1.Columns[0].Width = 185;
            dataGridView1.Columns[1].Width = 185;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
