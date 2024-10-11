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
    public partial class Opisanie : Form
    {
        public Opisanie()
        {
            InitializeComponent();
        }

        private void Описание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet3.Notebook". При необходимости она может быть перемещена или удалена.
            this.notebookTableAdapter.Fill(this.notebookDataSet3.Notebook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet3.Firm". При необходимости она может быть перемещена или удалена.
            this.firmTableAdapter.Fill(this.notebookDataSet3.Firm);
            dataGridView1[1, 0].Selected = true;
         //   dataGridView1.CurrentCell = dataGridView1[0, 0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Samsung frsamsung = new Samsung();
            frsamsung.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acer fraser = new Acer();
            fraser.ShowDialog();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Apple frapple = new Apple();
            frapple.ShowDialog();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lenovo frlenovo = new Lenovo();
            frlenovo.ShowDialog();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Asus frasus = new Asus();
            frasus.ShowDialog();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sony frsony = new Sony();
            frsony.ShowDialog();            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HP frhp = new HP();
            frhp.ShowDialog();            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Notebook fntbk = new Notebook();
            CallBackMy.callbackEventHandler(@name_ntbk, @ntbk, @Prmtr);
            fntbk.ShowDialog();
        }
        public string Prmtr = "";
        string name_ntbk = "";
        string ntbk = "";
        //string ids = "";
        string id_s;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
           
            id_s = selectedRow.Cells[0].Value.ToString();

            object id_firm = 1;
            object id_ntbk = 1;
            object id_name_ntbk = 1;
            SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=notebook;Integrated Security=True");
            string sqlExpression = "SELECT * FROM vnotebook WHERE id = @cmbox;";
            SqlCommand cmd = new SqlCommand(sqlExpression, con1);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cmbox", id_s);

            con1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id_ntbk = reader.GetValue(1);
                id_name_ntbk = reader.GetValue(4);
                id_firm = reader.GetValue(3) + "," + reader.GetValue(4) + ","
                    + reader.GetValue(5) + "," + reader.GetValue(6) + "," + reader.GetValue(7) + "," 
                    + reader.GetValue(8) + "," + reader.GetValue(9) + "," + reader.GetValue(10) + ","
                    + reader.GetValue(11) + "," + reader.GetValue(12) + "," + reader.GetValue(13);
                ntbk = id_firm.ToString();
                Prmtr = id_ntbk.ToString();
                name_ntbk = id_name_ntbk.ToString();
                //MessageBox.Show(id_firm.ToString());
                //MessageBox.Show(comboBox1.Text);
            }
            reader.Close();
            con1.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            dataGridView1[1, 0].Selected = true;
         
        }

        }
    }
