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
       
    public partial class Form2 : Form
    {
        public string connectionString = "Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public string[] Mas1 = new string[14];
        
        //public Form2(string[] array)
        public Form2()
        {
            InitializeComponent();
      //      myArray = array;                       
            //comboBox1.SelectedIndex = Convert.ToInt32(cmbx14.Value);
            
            //comboBox1.SelectedIndex = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Object selectedItem = comboBox1.SelectedItem;

            //MessageBox.Show(comboBox1.Text);
            this.Close();
        }

        /***************************************************************************/
        
        /***************************************************************************/
        //string[] myArray;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Желаете сохранить исправленный запись", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Обновить
                
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE [Notebook] SET  [notebook] = @notebook, [price] = @price, [id_money] = @id_money, [id_firm] = @id_firm, [id_tip] = @id_tip, [id_proc] = @id_proc, [id_oper] = @id_oper, [id_hdd] = @id_hdd, [id_disk] = @id_disk, [id_diag] = @id_diag, [id_os] = @id_os, [id_bluetooth] = @id_bluetooth, [id_using] = @id_using WHERE [id]=@id";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@notebook", textBox1.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                /*
                cmd.Parameters.AddWithValue("@id_money", comboBox1.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_firm", comboBox2.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_tip", comboBox3.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_proc", comboBox4.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_oper", comboBox5.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_hdd", comboBox6.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_disk", comboBox7.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_diag", comboBox8.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_os", comboBox9.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_bluetooth", comboBox10.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@id_using", comboBox11.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Id", Data_id.Value.ToString());
                MessageBox.Show((comboBox1.SelectedIndex + 1).ToString());
                MessageBox.Show((comboBox1.SelectedValue.ToString());
                */
                cmd.Parameters.AddWithValue("@id_money", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_firm", comboBox2.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_tip", comboBox3.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_proc", comboBox4.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_oper", comboBox5.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_hdd", comboBox6.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_disk", comboBox7.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_diag", comboBox8.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_os", comboBox9.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_bluetooth", comboBox10.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@id_using", comboBox11.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Id", Data_id.Value.ToString());
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                 
                //MessageBox.Show(comboBox1.SelectedIndex.ToString() + " -->  " + myArray[14].ToString());
                MessageBox.Show("Запись обновлен. ");
                /****************************************/
                //MessageBox.Show(myArray[1].ToString());
                //MessageBox.Show(cmbx14.Value);    //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                
                //do something else
            }
            
        }


        
        
        
        
        private void Form2_Load(object sender, EventArgs e)
        {            
// TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet3.Notebook". При необходимости она может быть перемещена или удалена.
this.notebookTableAdapter.Fill(this.notebookDataSet3.Notebook);
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
                                    
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=notebook;Integrated Security=True");
            string sqlExpression = "SELECT * FROM notebook WHERE id = @id;";
            SqlCommand cmd = new SqlCommand(sqlExpression, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Data_id.Value.ToString());

            
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                textBox1.Text = reader.GetValue(1).ToString();
                textBox2.Text = reader.GetValue(3).ToString();
                
                comboBox1.SelectedValue = reader.GetValue(5);
                comboBox2.SelectedValue = reader.GetValue(4);
                comboBox3.SelectedValue = reader.GetValue(6);
                comboBox4.SelectedValue = reader.GetValue(7);
                comboBox5.SelectedValue = reader.GetValue(8);
                comboBox6.SelectedValue = reader.GetValue(9);
                comboBox7.SelectedValue = reader.GetValue(10);
                comboBox8.SelectedValue = reader.GetValue(11);
                comboBox9.SelectedValue = reader.GetValue(12);
                comboBox10.SelectedValue = reader.GetValue(13);
                comboBox11.SelectedValue = reader.GetValue(14);
                /*                 
                comboBox1.SelectedIndex = Convert.ToInt32(reader.GetValue(5)) - 1;
                comboBox2.SelectedIndex = Convert.ToInt32(reader.GetValue(4)) - 1;
                comboBox3.SelectedIndex = Convert.ToInt32(reader.GetValue(6)) - 1;
                comboBox4.SelectedIndex = Convert.ToInt32(reader.GetValue(7)) - 1;
                comboBox5.SelectedIndex = Convert.ToInt32(reader.GetValue(8)) - 1;
                comboBox6.SelectedIndex = Convert.ToInt32(reader.GetValue(9)) - 1;
                comboBox7.SelectedIndex = Convert.ToInt32(reader.GetValue(10)) - 1;
                comboBox8.SelectedIndex = Convert.ToInt32(reader.GetValue(11)) - 1;
                comboBox9.SelectedIndex = Convert.ToInt32(reader.GetValue(12)) - 1;
                comboBox10.SelectedIndex = Convert.ToInt32(reader.GetValue(13)) - 1;
                comboBox11.SelectedIndex = Convert.ToInt32(reader.GetValue(14)) - 1;
                 */
            }          
                        
            reader.Close();
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            Form1 frm = new Form1(); //тут создаешь новую форму. это не гуд, так как старая про нее ничего не знает.
            frm.dataGridView.Rows.Clear();
            frm.UpdateGrid();
             */
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mas1 = new string[2] { textBox1.Text, textBox2.Text};

            Mas1[0] = textBox1.Text;
            Mas1[1] = textBox2.Text;
            Mas1[2] = comboBox1.Text;
            Mas1[3] = comboBox2.Text;
            Mas1[4] = comboBox3.Text;
            Mas1[5] = comboBox4.Text;
            Mas1[6] = comboBox5.Text;
            Mas1[7] = comboBox6.Text;
            Mas1[8] = comboBox7.Text;
            Mas1[9] = comboBox8.Text;
            Mas1[10] = comboBox9.Text;
            Mas1[11] = comboBox10.Text;
            Mas1[12] = comboBox11.Text;

            
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
