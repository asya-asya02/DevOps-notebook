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
    public partial class Form10 : Form
    {
        public string connectionString = @"Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string id_user;
        private void button1_Click(object sender, EventArgs e)
        {
            // Обновить

            DialogResult dialogResult = MessageBox.Show("Желаете сохранить исправленный запись", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Обновить
                id_user = Data_id.Value.ToString();
                string sql = "UPDATE Users SET FIO = "+"'"+textBox1.Text.Trim()+"'"+", login =" +"'"+textBox2.Text.Trim()+"'"+", Hash_Pwd = "+"'"+textBox3.Text.Trim()+"'"+" WHERE id_user= "+"'"+id_user+"'";
                //MessageBox.Show(sql);
                
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = con;
                //cmd.Parameters.AddWithValue("@fio", textBox1.Text);
                //cmd.Parameters.AddWithValue("@login", textBox2.Text);
                //cmd.Parameters.AddWithValue("@pass", textBox3.Text);
                //cmd.Parameters.AddWithValue("@pass", id_user);
                
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
        string id_s;
        string fio;
        string login;
        string pass;
        private void Form10_Load(object sender, EventArgs e)
        {
            id_s = Data_id.Value.ToString();
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=notebook;Integrated Security=True");
            string sqlExpression = "SELECT * FROM Users WHERE id_user = @id_user";
            SqlCommand cmd = new SqlCommand(sqlExpression, con1);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_user", id_s);

            con1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                fio = reader.GetValue(1).ToString();
                login = reader.GetValue(2).ToString();
                pass = reader.GetValue(3).ToString();

            }
            reader.Close();
            con1.Close();
            textBox1.Text = fio;
            textBox2.Text = login;
            textBox3.Text = pass;
        }
    }
}
